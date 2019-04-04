using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;

namespace Business.Logic
{
    public class AlumnoLogic
    {
        public AlumnoAdapter AlumnoData
        {
            get; set;
        }

        public AlumnoLogic()
        {
            AlumnoData = new AlumnoAdapter();
        }

        public List<Alumno> GetAll()
        {
            try
            {
                return AlumnoData.GetAll();
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        public Alumno GetOne(int ID)
        {
            try
            {
                return AlumnoData.GetOne(ID);
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        public void Delete(int ID)
        {
            try
            {
                AlumnoData.Delete(ID);
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        public void Save(Alumno al)
        {
            try
            {
                AlumnoData.Save(al);
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }
    }
}
