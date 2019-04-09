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
    public partial class Inscripciones : Form
    {
        public Inscripciones()
        {
            InitializeComponent();
            dgvInscripciones.AutoGenerateColumns = false;
            this.Listar();
        }

        public void Listar()
        {
            dgvInscripciones.DataSource = new InscripcionLogic().GetAll();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            InscripcionDesktop idesktop = new InscripcionDesktop(ApplicationForm.ModoForm.Alta);
            idesktop.ShowDialog();
            this.Listar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (this.dgvInscripciones.SelectedRows.Count != 0)
            {
                int ID = ((Business.Entities.Inscripcion)this.dgvInscripciones.SelectedRows[0].DataBoundItem).ID;
                InscripcionDesktop idesktop = new InscripcionDesktop(ID, ApplicationForm.ModoForm.Modificacion);
                idesktop.ShowDialog();
            }
            this.Listar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (this.dgvInscripciones.SelectedRows.Count != 0)
            {
                int ID = ((Business.Entities.Alumno)this.dgvInscripciones.SelectedRows[0].DataBoundItem).ID;
                InscripcionDesktop idesktop = new InscripcionDesktop(ID, ApplicationForm.ModoForm.Baja);
                idesktop.ShowDialog();
            }
            this.Listar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Listar();
        }
    }
}
