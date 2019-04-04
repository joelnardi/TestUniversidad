using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Alumno : BusinessEntity
    {
        private string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private int legajo;
        public int Legajo
        {
            get { return legajo; }
            set { legajo = value; }
        }

        private DateTime fechaNacimiento;
        public DateTime FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }

        private int edad;
        public int Edad
        {
            get { return edad; }
            set { edad = DateTime.Today.AddTicks(-fechaNacimiento.Ticks).Year - 1; }
        }  
    }
}
