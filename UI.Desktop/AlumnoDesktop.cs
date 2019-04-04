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
    public partial class AlumnoDesktop : ApplicationForm
    {
        private Alumno _alumnoActual;

        public Alumno AlumnoActual
        {
            get { return _alumnoActual; }
            set { _alumnoActual = value; }
        }

        public AlumnoDesktop(ModoForm md) : this()
        {
            this.Modo = md;
        }

        public AlumnoDesktop(int ID, ModoForm md) : this()
        {
            this.Modo = md;
            AlumnoLogic alog = new AlumnoLogic();
            AlumnoActual = alog.GetOne(ID);
            MapearDeDatos();
        }

        public override void MapearDeDatos()
        {
            this.txbID.Text = AlumnoActual.ID.ToString();
            this.txbLegajo.Text = AlumnoActual.Legajo.ToString();
            this.txbNombre.Text = AlumnoActual.Nombre.ToString();
            
            switch(this.Modo)
            {
                case ModoForm.Alta:
                    btnAceptar.Text = "Guardar";
                    this.txbID.Enabled = false;
                    break;
                case ModoForm.Baja:
                    btnAceptar.Text = "Eliminar";
                    break;
                case ModoForm.Modificacion:
                    btnAceptar.Text = "Modificar";
                    break;
                case ModoForm.Consulta:
                    btnAceptar.Text = "Aceptar";
                    break;
                default:
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
                AlumnoActual.ID = int.Parse(txbID.Text);
            }
            AlumnoActual.Legajo = int.Parse(txbLegajo.Text);
            AlumnoActual.Nombre = txbNombre.Text;
            AlumnoActual.FechaNacimiento = datFechaNacimiento.Value.Date;

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

        public AlumnoDesktop() : base()
        {
            InitializeComponent();
        }

        public override void GuardarCambios()
        {
            MapearADatos();
            AlumnoLogic alogi = new AlumnoLogic();
            try
            {
                alogi.Save(AlumnoActual);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.GuardarCambios();
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
