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
    public partial class EstadoAcademico : Form
    {
        public EstadoAcademico()
        {
            InitializeComponent();
            dgvEstadoAcademico.AutoGenerateColumns = false;

            List<Alumno> _listAlumnos = new List<Alumno>();
            _listAlumnos.Add(new Alumno());
            _listAlumnos.AddRange(new AlumnoLogic().GetAll());

            cmbAlumno.DataSource = _listAlumnos;
            cmbAlumno.DisplayMember = "Nombre";
            cmbAlumno.ValueMember = "ID";
        }

        public void Listar()
        {
            Alumno al = (Alumno)this.cmbAlumno.SelectedItem;
            this.dgvEstadoAcademico.DataSource = new InscripcionLogic().GetAllAlumnos(al.ID);
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            Listar();
        }
    }
}
