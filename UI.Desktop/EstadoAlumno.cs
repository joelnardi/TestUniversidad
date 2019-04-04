using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Logic;

namespace UI.Desktop
{
    public partial class EstadoAlumno : Form
    {
        public EstadoAlumno()
        {
            InitializeComponent();
        }

        private void btnVerAlumno_Click(object sender, EventArgs e)
        {
            InscripcionLogic al = new InscripcionLogic();
            dgvVerAlumno.Rows.Add(al.GetAllAlumnos(int.Parse(txbIDAlumno.Text.ToString())));
        }
    }
}
