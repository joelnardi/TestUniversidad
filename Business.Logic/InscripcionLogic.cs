using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;

namespace Business.Logic
{
    public class InscripcionLogic
    {
        public InscripcionAdapter InscripcionData
        {
            get; set;
        }
        
        public InscripcionLogic()
        {
            InscripcionData = new InscripcionAdapter();
        }

        public List<Inscripcion> GetAllAlumnos(int IDAl)
        {
            try
            {
                return InscripcionData.GetAllAlumnos(IDAl);
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        public List<Inscripcion> GetAllCursos(int IDCu)
        {
            try
            {
                return InscripcionData.GetAllCursos(IDCu);
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        public void Delete(int IDAl, int IDCu)
        {
            try
            {
                InscripcionData.Delete(IDAl, IDCu);
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        public void Save(Inscripcion ic)
        {
            try
            {
                InscripcionData.Save(ic);
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }
    }
}
