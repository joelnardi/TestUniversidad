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

namespace Desktop
{
    public partial class Alumnos : Form
    {
        public Alumnos()
        {
            InitializeComponent();
            dgvAlumnos.AutoGenerateColumns = false;
            Listar();
        }

        public void Listar()
        {
            dgvAlumnos.DataSource = new AlumnoLogic().GetAll();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AlumnoDesktop adesktop = new AlumnoDesktop(ApplicationForm.ModoForm.Alta);
            adesktop.ShowDialog();
            this.Listar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if(this.dgvAlumnos.SelectedRows.Count != 0)
            {
                int ID = ((Business.Entities.Alumno)this.dgvAlumnos.SelectedRows[0].DataBoundItem).ID;
                AlumnoDesktop adesktop = new AlumnoDesktop(ID, ApplicationForm.ModoForm.Modificacion);
                adesktop.ShowDialog();
            }
            this.Listar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.dgvAlumnos.SelectedRows.Count != 0)
            {
                int ID = ((Business.Entities.Alumno)this.dgvAlumnos.SelectedRows[0].DataBoundItem).ID;
                AlumnoDesktop adesktop = new AlumnoDesktop(ID, ApplicationForm.ModoForm.Baja);
                adesktop.ShowDialog();
            }
            this.Listar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Listar();
        }
    }
}
