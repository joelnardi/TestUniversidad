using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Inscripcion : BusinessEntity
    {
        private Alumno alumno;
        public Alumno Alumno
        {
            get { return alumno; }
            set { alumno = value; }
        }

        private Curso curso;
        public Curso Curso
        {
            get { return curso; }
            set { curso = value; }
        }

        private DateTime fechaInscripcion;
        public DateTime FechaInscripcion
        {
            get { return fechaInscripcion; }
            set { fechaInscripcion = value; }
        }

        private string estadoInsc;
        public string EstadoInsc
        {
            get { return estadoInsc; }
            set { estadoInsc = value; }
        }
    }
}
