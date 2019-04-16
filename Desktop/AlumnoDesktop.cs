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
using Business.Entities;

namespace Desktop
{
    public partial class AlumnoDesktop : ApplicationForm
    {
        public Alumno AlumnoActual
        {
            get; set;
        }

        public AlumnoDesktop() : base()
        {
            InitializeComponent();
        }

        public AlumnoDesktop(ModoForm modo) : this()
        {
            this.Modo = modo;
        }

        public AlumnoDesktop(int ID, ModoForm modo) : this()
        {
            this.Modo = modo;
            AlumnoLogic al = new AlumnoLogic();
            AlumnoActual = al.GetOne(ID);
            MapearDeDatos();
        }

        public override void MapearDeDatos()
        {
            this.txtID.Text = AlumnoActual.ID.ToString();
            this.txtLegajo.Text = AlumnoActual.Legajo.ToString();
            this.txtNombre.Text = AlumnoActual.Nombre.ToString();
            this.dtpFechaNacimiento.Value = AlumnoActual.FechaNacimiento;

            switch (this.Modo)
            {
                case ModoForm.Alta:
                    txtID.ReadOnly = true;
                    btnAceptar.Text = "Guardar";
                    break;
                case ModoForm.Baja:
                    btnAceptar.Text = "Eliminar";
                    txtLegajo.ReadOnly = true;
                    txtNombre.ReadOnly = true;
                    break;
                case ModoForm.Modificacion:
                    btnAceptar.Text = "Guardar";
                    txtID.ReadOnly = true;
                    break;
                case ModoForm.Consulta:
                    btnAceptar.Text = "Aceptar";
                    txtID.ReadOnly = true;
                    txtLegajo.ReadOnly = true;
                    txtNombre.ReadOnly = true;
                    break;
            }
        }

        public override void MapearADatos()
        {
            if (this.Modo == ModoForm.Alta)
            {
                AlumnoActual = new Alumno();
            }
            else
            {
                AlumnoActual.ID = int.Parse(txtID.Text);
            }

            AlumnoActual.Legajo = int.Parse(txtLegajo.Text);
            AlumnoActual.Nombre = txtNombre.Text;
            AlumnoActual.FechaNacimiento = dtpFechaNacimiento.Value;

            switch (this.Modo)
            {
                case ModoForm.Alta:
                    AlumnoActual.State = BusinessEntity.States.New;
                    break;
                case ModoForm.Baja:
                    AlumnoActual.State = BusinessEntity.States.Deleted;
                    break;
                case ModoForm.Modificacion:
                    AlumnoActual.State = BusinessEntity.States.Modified;
                    break;
                case ModoForm.Consulta:
                    AlumnoActual.State = BusinessEntity.States.Unmodified;
                    break;
                default:
                    break;
            }
        }

        public override void GuardarCambios()
        {
            MapearADatos();
            AlumnoLogic al = new AlumnoLogic();
            try
            {
                al.Save(AlumnoActual);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        public override bool Validar()
        {
            bool valido = false;
            if (txtLegajo.Text!="" && txtNombre.Text!="")
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
