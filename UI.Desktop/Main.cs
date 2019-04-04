using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Entities;
using Business.Logic;

namespace UI.Desktop
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnNuevoAlumno_Click(object sender, EventArgs e)
        {
            AlumnoDesktop formPlan = new AlumnoDesktop(ApplicationForm.ModoForm.Alta);
            formPlan.ShowDialog();
        }

        private void btnEstadoAcademico_Click(object sender, EventArgs e)
        {
            EstadoAlumno formPlan = new EstadoAlumno();
            formPlan.ShowDialog();
        }

        private void btnEstadoCurso_Click(object sender, EventArgs e)
        {
            EstadoCurso formPlan = new EstadoCurso();
            formPlan.ShowDialog();
        }
    }
}
