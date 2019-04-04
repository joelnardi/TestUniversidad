using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Curso : BusinessEntity
    {
        private string asignatura;
        public string Asignatura
        {
            get { return asignatura; }
            set { asignatura = value; }
        }

        private int cupoMaximo;
        public int CupoMaximo
        {
            get { return cupoMaximo; }
            set { cupoMaximo = value; }
        }

        private string docente;
        public string Docente
        {
            get { return docente; }
            set { docente = value; }
        }
    }
}
