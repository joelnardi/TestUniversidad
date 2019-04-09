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
    public class InscripcionAdapter : Adapter
    {
        public List<Inscripcion> GetAllAlumnos(int IDAl)
        {
            List<Inscripcion> inscripciones = new List<Inscripcion>();

            try
            {
                this.OpenConnection();
                SqlCommand cmdInscripciones = new SqlCommand("select * from Inscripciones " +
                    "inner join Cursos on Cursos.IDCurso = Inscripciones.IDCurso " +
                    "inner join Alumnos on Alumnos.IDAlumno = Inscripciones.IDAlumno " +
                    "where Alumnos.IDAlumno = @idal", SqlConn);
                cmdInscripciones.Parameters.Add("@idal", SqlDbType.Int).Value = IDAl;
                SqlDataReader drInscripciones = cmdInscripciones.ExecuteReader();
                while (drInscripciones.Read())
                {
                    Alumno al = new Alumno();
                    Curso cu = new Curso();
                    Inscripcion ic = new Inscripcion();
                    al.ID = (int)drInscripciones["IDAlumno"];
                    al.Nombre = (string)drInscripciones["Nombre"];
                    al.Legajo = (int)drInscripciones["Legajo"];
                    al.FechaNacimiento = (DateTime)drInscripciones["FechaNacimiento"];
                    al.Edad = (int)drInscripciones["Edad"];
                    cu.ID = (int)drInscripciones["IDCurso"];
                    cu.Asignatura = (string)drInscripciones["Asignatura"];
                    cu.CupoMaximo = (int)drInscripciones["CupoMaximo"];
                    cu.Docente = (string)drInscripciones["Docente"];
                    ic.EstadoInsc = (string)drInscripciones["Estado"];
                    ic.FechaInscripcion = (DateTime)drInscripciones["FechaInscripcion"];
                    ic.ID = (int)drInscripciones["IDInsc"];
                    ic.Curso = cu;
                    ic.Alumno = al;
                    inscripciones.Add(ic);
                }
                drInscripciones.Close();
            }
            catch (Exception exc)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar inscripciones", exc);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }

            return inscripciones;
        }

        public List<Inscripcion> GetAll()
        {
            List<Inscripcion> inscripciones = new List<Inscripcion>();

            try
            {
                this.OpenConnection();
                SqlCommand cmdInscripciones = new SqlCommand("select * from Inscripciones " +
                    "inner join Cursos on Cursos.IDCurso = Inscripciones.IDCurso " +
                    "inner join Alumnos on Alumnos.IDAlumno = Inscripciones.IDAlumno", SqlConn);
                SqlDataReader drInscripciones = cmdInscripciones.ExecuteReader();
                while (drInscripciones.Read())
                {
                    Alumno al = new Alumno();
                    Curso cu = new Curso();
                    Inscripcion ic = new Inscripcion();
                    al.ID = (int)drInscripciones["IDAlumno"];
                    al.Nombre = (string)drInscripciones["Nombre"];
                    al.Legajo = (int)drInscripciones["Legajo"];
                    al.FechaNacimiento = (DateTime)drInscripciones["FechaNacimiento"];
                    al.Edad = (int)drInscripciones["Edad"];
                    cu.ID = (int)drInscripciones["IDCurso"];
                    cu.Asignatura = (string)drInscripciones["Asignatura"];
                    cu.CupoMaximo = (int)drInscripciones["CupoMaximo"];
                    cu.Docente = (string)drInscripciones["Docente"];
                    ic.EstadoInsc = (string)drInscripciones["Estado"];
                    ic.FechaInscripcion = (DateTime)drInscripciones["FechaInscripcion"];
                    ic.ID = (int)drInscripciones["IDInsc"];
                    ic.Curso = cu;
                    ic.Alumno = al;
                    inscripciones.Add(ic);
                }
                drInscripciones.Close();
            }
            catch (Exception exc)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar inscripciones", exc);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }

            return inscripciones;
        }

        public Inscripcion GetOne(int ID)
        {
            Inscripcion ic = new Inscripcion();
            try
            {
                this.OpenConnection();
                SqlCommand cmdInscripciones = new SqlCommand("select * from Inscripciones " +
                    "inner join Cursos on Cursos.IDCurso = Inscripciones.IDCurso " +
                    "inner join Alumnos on Alumnos.IDAlumno = Inscripciones.IDAlumno " +
                    "where IDInsc = @id", SqlConn);
                cmdInscripciones.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                SqlDataReader drInscripciones = cmdInscripciones.ExecuteReader();
                if (drInscripciones.Read())
                {
                    Alumno al = new Alumno();
                    Curso cu = new Curso();
                    al.ID = (int)drInscripciones["IDAlumno"];
                    al.Nombre = (string)drInscripciones["Nombre"];
                    al.Legajo = (int)drInscripciones["Legajo"];
                    al.FechaNacimiento = (DateTime)drInscripciones["FechaNacimiento"];
                    al.Edad = (int)drInscripciones["Edad"];
                    cu.ID = (int)drInscripciones["IDCurso"];
                    cu.Asignatura = (string)drInscripciones["Asignatura"];
                    cu.CupoMaximo = (int)drInscripciones["CupoMaximo"];
                    cu.Docente = (string)drInscripciones["Docente"];
                    ic.EstadoInsc = (string)drInscripciones["Estado"];
                    ic.FechaInscripcion = (DateTime)drInscripciones["FechaInscripcion"];
                    ic.ID = (int)drInscripciones["IDInsc"];
                    ic.Curso = cu;
                    ic.Alumno = al;
                }
                drInscripciones.Close();
            }
            catch (Exception exc)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar inscripciones", exc);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return ic;
        }

        public List<Inscripcion> GetAllCursos(int IDCu)
        {
            List<Inscripcion> inscripciones = new List<Inscripcion>();

            try
            {
                this.OpenConnection();
                SqlCommand cmdInscripciones = new SqlCommand("select * from Inscripciones " +
                    "inner join Cursos on Cursos.IDCurso = Inscripciones.IDCurso " +
                    "inner join Alumnos on Alumnos.IDAlumno = Inscripciones.IDAlumno " +
                    "where Cursos.IDCurso = @idcu", SqlConn);
                cmdInscripciones.Parameters.Add("@idcu", SqlDbType.Int).Value = IDCu;
                SqlDataReader drInscripciones = cmdInscripciones.ExecuteReader();
                while (drInscripciones.Read())
                {
                    Alumno al = new Alumno();
                    Curso cu = new Curso();
                    Inscripcion ic = new Inscripcion();
                    al.ID = (int)drInscripciones["IDAlumno"];
                    al.Nombre = (string)drInscripciones["Nombre"];
                    al.Legajo = (int)drInscripciones["Legajo"];
                    al.FechaNacimiento = (DateTime)drInscripciones["FechaNacimiento"];
                    al.Edad = (int)drInscripciones["Edad"];
                    cu.ID = (int)drInscripciones["IDCurso"];
                    cu.Asignatura = (string)drInscripciones["Asignatura"];
                    cu.CupoMaximo = (int)drInscripciones["CupoMaximo"];
                    cu.Docente = (string)drInscripciones["Docente"];
                    ic.EstadoInsc = (string)drInscripciones["Estado"];
                    ic.FechaInscripcion = (DateTime)drInscripciones["FechaInscripcion"];
                    ic.ID = (int)drInscripciones["IDInsc"];
                    ic.Curso = cu;
                    ic.Alumno = al;
                    inscripciones.Add(ic);
                }
                drInscripciones.Close();
            }
            catch (Exception exc)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar inscripciones", exc);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }

            return inscripciones;
        }

        public void Delete(int ID)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdDelete = new SqlCommand("DELETE Inscripciones WHERE IDinsc=@id", SqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception exc)
            {
                Exception ExcepcionManejada = new Exception("No se pudo eliminar inscripcion", exc);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Insert(Inscripcion ic)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdInsert = new SqlCommand("INSERT Inscripciones (IDAlumno, IDCurso, FechaInscripcion, Estado) " +
                    "values (@idal, @idcu, @fechainscripcion, @estado", SqlConn);
                cmdInsert.Parameters.Add("@idal", SqlDbType.Int).Value = ic.Alumno.ID;
                cmdInsert.Parameters.Add("@idcu", SqlDbType.Int).Value = ic.Curso.ID;
                cmdInsert.Parameters.Add("@fechainscripcion", SqlDbType.Date).Value = ic.FechaInscripcion;
                cmdInsert.Parameters.Add("@estado", SqlDbType.VarChar, 50).Value = ic.EstadoInsc;
            }
            catch (Exception exc)
            {
                Exception ExcepcionManejada = new Exception("No se pudo crear inscripcion", exc);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Update(Inscripcion ic)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdUpdate = new SqlCommand("UPDATE Inscripciones SET Estado = @estado, " +
                    "FechaInscripcion = @fechainscripcion WHERE IDAlumno = @idal AND IDCurso = @idcu", SqlConn);
                cmdUpdate.Parameters.Add("@idal", SqlDbType.Int).Value = ic.Alumno.ID;
                cmdUpdate.Parameters.Add("@idcu", SqlDbType.Int).Value = ic.Curso.ID;
                cmdUpdate.Parameters.Add("@estado", SqlDbType.VarChar, 50).Value = ic.EstadoInsc;
                cmdUpdate.Parameters.Add("@fechainscripcion", SqlDbType.Date).Value = ic.FechaInscripcion;
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

        public void Save(Inscripcion inscripcion)
        {
            if (inscripcion.State == BusinessEntity.States.New)
            {
                try
                {
                    this.Insert(inscripcion);
                }
                catch (Exception exc)
                {
                    Exception ExcepcionManejada = new Exception("ERROR", exc);
                    throw ExcepcionManejada;
                }
            }
            else if (inscripcion.State == BusinessEntity.States.Deleted)
            {
                try
                {
                    this.Delete(inscripcion.ID);
                }
                catch (Exception exc)
                {
                    Exception ExcepcionManejada = new Exception("ERROR", exc);
                    throw ExcepcionManejada;
                }
            }
            else if (inscripcion.State == BusinessEntity.States.Modified)
            {
                try
                {
                    this.Update(inscripcion);
                }
                catch (Exception exc)
                {
                    Exception ExcepcionManejada = new Exception("ERROR", exc);
                    throw ExcepcionManejada;
                }
            }
            inscripcion.State = BusinessEntity.States.Unmodified;
        }
    }
}
