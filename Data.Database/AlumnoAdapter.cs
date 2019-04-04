using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using System.Data;
using System.Data.SqlClient;

namespace Data.Database
{
    public class AlumnoAdapter : Adapter
    {
        public List<Alumno> GetAll()
        {
            List<Alumno> alumnos = new List<Alumno>();

            try
            {
                this.OpenConnection();
                SqlCommand cmdAlumnos = new SqlCommand("SELECT * FROM Alumnos", SqlConn);
                SqlDataReader drAlumnos = cmdAlumnos.ExecuteReader();
                while (drAlumnos.Read())
                {
                    Alumno al = new Alumno();
                    al.ID = (int)drAlumnos["IDAlumno"];
                    al.Nombre = (string)drAlumnos["Nombre"];
                    al.Legajo = (int)drAlumnos["Legajo"];
                    al.FechaNacimiento = (DateTime)drAlumnos["FechaNacimiento"];
                    al.Edad = (int)drAlumnos["Edad"];

                    alumnos.Add(al);
                }
                drAlumnos.Close();
            }
            catch (Exception exc)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar alumnos", exc);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }

            return alumnos;
        }

        public Alumno GetOne(int ID)
        {
            Alumno al = new Alumno();
            try
            {
                this.OpenConnection();
                SqlCommand cmdAlumnos = new SqlCommand("SELECT * FROM Alumnos WHERE Alumnos.IDAlumno = @id", SqlConn);
                cmdAlumnos.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                SqlDataReader drAlumnos = cmdAlumnos.ExecuteReader();

                if (drAlumnos.Read())
                {
                    al.ID = (int)drAlumnos["IDAlumno"];
                    al.Nombre = (string)drAlumnos["Nombre"];
                    al.Legajo = (int)drAlumnos["Legajo"];
                    al.Edad = (int)drAlumnos["Edad"];
                    al.FechaNacimiento = (DateTime)drAlumnos["FechaNacimiento"];
                }
            }
            catch (Exception exc)
            {
                Exception ExcepcionManejada = new Exception("No se pudo obtener el curso", exc);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return al;
        }

        public void Delete(int ID)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdDelete = new SqlCommand("DELETE Alumnos WHERE IDAlumno=@id", SqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception exc)
            {
                Exception ExcepcionManejada = new Exception("No se pudo eliminar alumno", exc);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Insert(Alumno al)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdInsert = new SqlCommand("INSERT Alumnos (Nombre, Legajo, Edad, FechaNacimiento)" +
                    "values (@nombre, @legajo, @edad, @fechanacimiento", SqlConn);
                cmdInsert.Parameters.Add("@nombre", SqlDbType.VarChar, 30).Value = al.Nombre;
                cmdInsert.Parameters.Add("@legajo", SqlDbType.Int).Value = al.Legajo;
                cmdInsert.Parameters.Add("@edad", SqlDbType.Int).Value = al.Edad;
                cmdInsert.Parameters.Add("@fechanacimiento", SqlDbType.Date).Value = al.FechaNacimiento;
                al.ID = Decimal.ToInt32((decimal)cmdInsert.ExecuteScalar());
            }
            catch (Exception exc)
            {
                Exception ExcepcionManejada = new Exception("No se pudo crear alumno", exc);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Update(Alumno al)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdUpdate = new SqlCommand("UPDATE Alumnos SET Nombre = @nombre, " +
                    "Legajo = @legajo, Edad = @edad, FechaNacimiento = @fechanacimiento WHERE IDAlumno = @id", SqlConn);
                cmdUpdate.Parameters.Add("@id", SqlDbType.Int).Value = al.ID;
                cmdUpdate.Parameters.Add("@nombre", SqlDbType.VarChar, 30).Value = al.Nombre;
                cmdUpdate.Parameters.Add("@legajo", SqlDbType.Int).Value = al.Legajo;
                cmdUpdate.Parameters.Add("@edad", SqlDbType.Int).Value = (int)(DateTime.Now.Year - al.FechaNacimiento.Year);
                cmdUpdate.Parameters.Add("@fechanacimiento", SqlDbType.Date).Value = al.FechaNacimiento;
                cmdUpdate.ExecuteNonQuery();
            }
            catch (Exception exc)
            {
                Exception ExcepcionManejada = new Exception("No se pudo actualizar", exc);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Save(Alumno alumno)
        {
            if (alumno.State == BusinessEntity.States.New)
            {
                try
                {
                    this.Insert(alumno);
                }
                catch (Exception exc)
                {
                    Exception ExcepcionManejada = new Exception("ERROR", exc);
                    throw ExcepcionManejada;
                }
            }
            else if (alumno.State == BusinessEntity.States.Deleted)
            {
                try
                {
                    this.Delete(alumno.ID);
                }
                catch (Exception exc)
                {
                    Exception ExcepcionManejada = new Exception("ERROR", exc);
                    throw ExcepcionManejada;
                }
            }
            else if (alumno.State == BusinessEntity.States.Modified)
            {
                try
                {
                    this.Update(alumno);
                }
                catch (Exception exc)
                {
                    Exception ExcepcionManejada = new Exception("ERROR", exc);
                    throw ExcepcionManejada;
                }
            }
            alumno.State = BusinessEntity.States.Unmodified;
        }
    }
}
