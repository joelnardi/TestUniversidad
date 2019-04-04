using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;

namespace Business.Logic
{
    public class CursoLogic
    {
        public CursoAdapter CursoData
        {
            get; set;
        }

        public CursoLogic()
        {
            CursoData = new CursoAdapter();
        }

        public List<Curso> GetAll()
        {
            try
            {
                return CursoData.GetAll();
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        public Curso GetOne(int ID)
        {
            try
            {
                return CursoData.GetOne(ID);
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
                CursoData.Delete(ID);
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        public void Save(Curso cu)
        {
            try
            {
                CursoData.Save(cu);
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }
    }
}
