using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business.Entities;
using Business.Logic;

namespace Web
{
    public partial class EstadoCurso : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnVerCurso_Click(object sender, EventArgs e)
        {
            CursoLogic cl = new CursoLogic();
            Curso cu = new Curso();
            cu = cl.GetOne(int.Parse(this.ddlCurso.SelectedValue));
            txtDocente.Text = cu.Docente;
        }
    }
}