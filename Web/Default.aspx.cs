using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnInscripciones_Click(object sender, EventArgs e)
        {
            Page.Response.Redirect("~/Inscripciones.aspx");
        }

        protected void btnAlumnos_Click(object sender, EventArgs e)
        {
            Page.Response.Redirect("~/Alumnos.aspx");
        }

        protected void btnEstadoAcademico_Click(object sender, EventArgs e)
        {
            Page.Response.Redirect("~/EstadoAlumno.aspx");
        }

        protected void btnEstadoCurso_Click(object sender, EventArgs e)
        {
            Page.Response.Redirect("~/EstadoCurso.aspx");
        }
    }
}