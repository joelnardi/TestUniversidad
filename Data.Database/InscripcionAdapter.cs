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
            List<Inscripcion> inscriciones = new List<Inscripcion>();

            try
            {
                this.OpenConnection();
                SqlCommand cmdInscripciones = new SqlCommand("SELECT * FROM Inscripciones" +
                    "INNER JOIN Cursos ON Cursos.IDCurso = Inscripciones.IDCurso" +
                    "INNER JOIN Alumnos ON Alumnos.IDAlumno = Inscripciones.IDAlumno" +
                    "WHERE Alumnos.IDAlumno = @idal", SqlConn);
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
                    ic.Curso = cu;
                    ic.Alumno = al;
                    inscriciones.Add(ic);
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

            return inscriciones;
        }

        public List<Inscripcion> GetAllCursos(int IDCu)
        {
            List<Inscripcion> inscriciones = new List<Inscripcion>();

            try
            {
                this.OpenConnection();
                SqlCommand cmdInscripciones = new SqlCommand("SELECT * FROM Inscripciones" +
                    "INNER JOIN Cursos ON Cursos.IDCurso = Inscripciones.IDCurso" +
                    "INNER JOIN Alumnos ON Alumnos.IDAlumno = Inscripciones.IDAlumno" +
                    "WHERE Alumnos.IDCurso = @idcu", SqlConn);
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
                    ic.Curso = cu;
                    ic.Alumno = al;
                    inscriciones.Add(ic);
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

            return inscriciones;
        }

        public void Delete(int IDAl, int IDCu)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdDelete = new SqlCommand("DELETE Inscripciones WHERE IDAlumno=@idal AND IDCurso=@idcu", SqlConn);
                cmdDelete.Parameters.Add("@idal", SqlDbType.Int).Value = IDAl;
                cmdDelete.Parameters.Add("@idcu", SqlDbType.Int).Value = IDCu;
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
                SqlCommand cmdInsert = new SqlCommand("INSERT Inscripciones (IDAlumno, IDCurso, FechaInscripcion, Estado)" +
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
                    this.Delete(inscripcion.Alumno.ID, inscripcion.Alumno.ID);
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
