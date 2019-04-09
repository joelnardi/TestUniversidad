using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnAlumnos_Click(object sender, EventArgs e)
        {
            Alumnos al = new Alumnos();
            al.ShowDialog();
        }

        private void btnInscripciones_Click(object sender, EventArgs e)
        {
            Inscripciones insc = new Inscripciones();
            insc.ShowDialog();
        }

        private void btnEstadoCurso_Click(object sender, EventArgs e)
        {
            EstadoCurso estCurso = new EstadoCurso();
            estCurso.ShowDialog();
        }

        private void btnEstadoAcademico_Click(object sender, EventArgs e)
        {
            EstadoAcademico estAcad = new EstadoAcademico();
            estAcad.ShowDialog();
        }
    }
}
