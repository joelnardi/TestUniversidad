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

namespace Desktop
{
    public partial class EstadoCurso : Form
    {
        public EstadoCurso()
        {
            InitializeComponent();
            dgvEstadoCurso.AutoGenerateColumns = false;

            List<Curso> _listCursos = new List<Curso>();
            _listCursos.Add(new Curso());
            _listCursos.AddRange(new CursoLogic().GetAll());

            cmbCurso.DataSource = _listCursos;
            cmbCurso.DisplayMember = "Asignatura";
            cmbCurso.ValueMember = "ID";

            this.txtDocente.ReadOnly = true;
        }

        public void Listar()
        {
            Curso cu = (Curso)this.cmbCurso.SelectedItem;
            this.dgvEstadoCurso.DataSource = new InscripcionLogic().GetAllCursos(cu.ID);
            this.txtDocente.Text = cu.Docente;
        }

        private void btnVerCurso_Click(object sender, EventArgs e)
        {
            Listar();
        }
    }
}
