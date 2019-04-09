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
    public partial class InscripcionDesktop : ApplicationForm
    {
        public Inscripcion InscripcionActual
        {
            get; set;
        }

        public InscripcionDesktop() : base()
        {
            InitializeComponent();

            List<Curso> _listCursos = new List<Curso>();
            _listCursos.Add(new Curso());
            _listCursos.AddRange(new CursoLogic().GetAll());

            cmbCurso.DataSource = _listCursos;
            cmbCurso.DisplayMember = "Asignatura";
            cmbCurso.ValueMember = "ID";

            List<Alumno> _listAlumnos = new List<Alumno>();
            _listAlumnos.Add(new Alumno());
            _listAlumnos.AddRange(new AlumnoLogic().GetAll());

            cmbAlumno.DataSource = _listAlumnos;
            cmbAlumno.DisplayMember = "Nombre";
            cmbAlumno.ValueMember = "ID";
        }

        public override void MapearDeDatos()
        {
            this.txtID.Text = InscripcionActual.ID.ToString();
            this.dtpFechaInscripcion.Value = InscripcionActual.FechaInscripcion;
            this.cmbEstado.SelectedItem = InscripcionActual.EstadoInsc;
            this.cmbCurso.SelectedItem = InscripcionActual.Curso;
            this.cmbAlumno.SelectedItem = InscripcionActual.Alumno;

            switch (this.Modo)
            {
                case ModoForm.Alta:
                    txtID.ReadOnly = true;
                    btnAceptar.Text = "Guardar";
                    break;
                case ModoForm.Baja:
                    btnAceptar.Text = "Eliminar";
                    break;
                case ModoForm.Modificacion:
                    btnAceptar.Text = "Guardar";
                    txtID.ReadOnly = true;
                    break;
                case ModoForm.Consulta:
                    btnAceptar.Text = "Aceptar";
                    txtID.ReadOnly = true;
                    break;
                default:
                    break;
            }
        }

        public override void MapearADatos()
        {
            if (this.Modo == ModoForm.Alta)
            {
                InscripcionActual = new Inscripcion();
            }
            else
            {

                InscripcionActual.ID = int.Parse(txtID.Text);
            }

            InscripcionActual.EstadoInsc = cmbEstado.SelectedItem.ToString();
            InscripcionActual.FechaInscripcion = dtpFechaInscripcion.Value;
            InscripcionActual.Curso = (Curso)cmbCurso.SelectedItem;
            InscripcionActual.Alumno = (Alumno)cmbAlumno.SelectedItem;

            switch (this.Modo)
            {
                case ModoForm.Alta:
                    InscripcionActual.State = BusinessEntity.States.New;
                    break;
                case ModoForm.Baja:
                    InscripcionActual.State = BusinessEntity.States.Deleted;
                    break;
                case ModoForm.Modificacion:
                    InscripcionActual.State = BusinessEntity.States.Modified;
                    break;
                case ModoForm.Consulta:
                    InscripcionActual.State = BusinessEntity.States.Unmodified;
                    break;
                default:
                    break;
            }
        }

        public InscripcionDesktop(ModoForm modo) : this()
        {
            this.Modo = modo;
        }

        public InscripcionDesktop(int ID, ModoForm modo) : this()
        {
            this.Modo = modo;
            InscripcionLogic insc = new InscripcionLogic();
            InscripcionActual = insc.GetOne(ID);
            MapearDeDatos();
        }

        public override void GuardarCambios()
        {
            MapearADatos();
            InscripcionLogic il = new InscripcionLogic();
            try
            {
                il.Save(InscripcionActual);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        public override bool Validar()
        {
            bool valido = false;
            if (cmbAlumno.SelectedItem.ToString() != "" && 
                cmbCurso.SelectedItem.ToString() != "")
            {
                valido = true;
            }
            return valido;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                this.GuardarCambios();
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
