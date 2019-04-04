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
    public class CursoAdapter : Adapter
    {
        public List<Curso> GetAll()
        {
            List<Curso> cursos = new List<Curso>();

            try
            {
                this.OpenConnection();
                SqlCommand cmdCursos = new SqlCommand("SELECT * FROM Cursos", SqlConn);
                SqlDataReader drCursos = cmdCursos.ExecuteReader();
                while (drCursos.Read())
                {
                    Curso cu = new Curso();
                    cu.ID = (int)drCursos["IDCurso"];
                    cu.Asignatura = (string)drCursos["Asignatura"];
                    cu.CupoMaximo = (int)drCursos["CupoMaximo"];
                    cu.Docente = (string)drCursos["Docente"];

                    cursos.Add(cu);
                }
                drCursos.Close();
            }
            catch (Exception exc)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar cursos", exc);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }

            return cursos;
        }

        public Curso GetOne(int ID)
        {
            Curso cu = new Curso();
            try
            {
                this.OpenConnection();
                SqlCommand cmdCursos = new SqlCommand("SELECT * FROM Cursos WHERE Cursos.IDCurso = @id", SqlConn);
                cmdCursos.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                SqlDataReader drCursos = cmdCursos.ExecuteReader();
                
                if (drCursos.Read())
                {
                    cu.ID = (int)drCursos["IDCurso"];
                    cu.Asignatura = (string)drCursos["Asignatura"];
                    cu.CupoMaximo = (int)drCursos["CupoMaximo"];
                    cu.Docente = (string)drCursos["Docente"];
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
            return cu;
        }

        public void Delete (int ID)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdDelete = new SqlCommand("DELETE Cursos WHERE IDCurso=@id", SqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception exc)
            {
                Exception ExcepcionManejada = new Exception("No se pudo eliminar curso", exc);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Insert(Curso cu)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdInsert = new SqlCommand("INSERT Cursos (Asignatura, CupoMaximo, Docente)" +
                    "values (@asignatura, @cupomaximo, @docente", SqlConn);
                cmdInsert.Parameters.Add("@asignatura", SqlDbType.VarChar, 30).Value = cu.Asignatura;
                cmdInsert.Parameters.Add("@cupomaximo", SqlDbType.Int).Value = cu.CupoMaximo;
                cmdInsert.Parameters.Add("@docente", SqlDbType.VarChar, 30).Value = cu.Docente;
                cu.ID = Decimal.ToInt32((decimal)cmdInsert.ExecuteScalar());
            }
            catch (Exception exc)
            {
                Exception ExcepcionManejada = new Exception("No se pudo crear curso", exc);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Update (Curso cu)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdUpdate = new SqlCommand("UPDATE Cursos SET Asignatura = @asignatura, " +
                    "CupoMaximo = @cupomaximo, Docente = @docente WHERE IDCurso = @id", SqlConn);
                cmdUpdate.Parameters.Add("@id", SqlDbType.Int).Value = cu.ID;
                cmdUpdate.Parameters.Add("@asignatura", SqlDbType.VarChar, 30).Value = cu.Asignatura;
                cmdUpdate.Parameters.Add("@cupomaximo", SqlDbType.Int).Value = cu.CupoMaximo;
                cmdUpdate.Parameters.Add("@docente", SqlDbType.VarChar, 30).Value = cu.Docente;
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

        public void Save(Curso curso)
        {
            if (curso.State == BusinessEntity.States.New)
            {
                try
                {
                    this.Insert(curso);
                }
                catch (Exception exc)
                {
                    Exception ExcepcionManejada = new Exception("ERROR", exc);
                    throw ExcepcionManejada;
                }
            }
            else if (curso.State == BusinessEntity.States.Deleted)
            {
                try
                {
                    this.Delete(curso.ID);
                }
                catch (Exception exc)
                {
                    Exception ExcepcionManejada = new Exception("ERROR", exc);
                    throw ExcepcionManejada;
                }
            }
            else if (curso.State == BusinessEntity.States.Modified)
            {
                try
                {
                    this.Update(curso);
                }
                catch (Exception exc)
                {
                    Exception ExcepcionManejada = new Exception("ERROR", exc);
                    throw ExcepcionManejada;
                }
            }
            curso.State = BusinessEntity.States.Unmodified;
        }
    }
}
