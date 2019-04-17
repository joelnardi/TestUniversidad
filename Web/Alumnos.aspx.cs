using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business.Logic;
using Business.Entities;

namespace Web
{
    public partial class Alumnos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void Actualizar()
        {
            try
            {
                this.dgvAlumnos.DataBind();
            }
            catch
            {
                throw;
            }
        }

        public enum FormModes
        {
            Alta,
            Baja,
            Modificacion
        }

        public FormModes FormMode
        {
            get { return (FormModes)this.ViewState["FormMode"]; }
            set { this.ViewState["FormMode"] = value; }
        }

        private AlumnoLogic _logic;
        public AlumnoLogic Logic
        {
            get
            {
                if (_logic == null)
                {
                    _logic = new AlumnoLogic();
                }
                return _logic;
            }
        }

        private int SelectedID
        {
            get
            {
                if (this.ViewState["SelectedID"] != null)
                {
                    return (int)ViewState["SelectedID"];
                }
                else
                {
                    return 0;
                }
            }

            set
            {
                this.ViewState["SelectedID"] = value;
            }
        }

        private bool IsEntitySelected
        {
            get
            {
                return (this.SelectedID != 0);
            }
        }

        private void EnableForm(bool enable)
        {
            txtID.Enabled = false;
            txtNombre.Enabled = enable;
            txtLegajo.Enabled = enable;
            cldFechaNacimiento.Enabled = enable;
        }

        private void LimpiarCampos()
        {
            txtID.Text = string.Empty;
            txtLegajo.Text = string.Empty;
            txtNombre.Text = string.Empty;
        }

        private void MapearAForm(Alumno al)
        {
            txtID.Text = al.ID.ToString();
            txtLegajo.Text = al.Legajo.ToString();
            txtNombre.Text = al.Nombre;
            cldFechaNacimiento.SelectedDate = al.FechaNacimiento;
        }

        private Alumno MapearADatos()
        {
            Alumno al = new Alumno();
            if (this.FormMode != FormModes.Alta)
            {
                al.ID = int.Parse(txtID.Text);
            }
            al.Nombre = txtNombre.Text;
            al.Legajo = int.Parse(txtLegajo.Text);
            al.FechaNacimiento = cldFechaNacimiento.SelectedDate;
            return al;
        }

        protected void dgvAlumnos_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ViewState["SelectedID"] = (int)this.dgvAlumnos.SelectedDataKey.Value;
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            this.FormMode = FormModes.Modificacion;
            this.LimpiarCampos();
            EnableForm(true);
            try
            {
                this.MapearAForm(this.Logic.GetOne(this.SelectedID));
            }
            catch
            {
                throw;
            }
            this.modoEdicion(true);
        }

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            this.FormMode = FormModes.Alta;
            this.LimpiarCampos();
            this.EnableForm(true);
            this.modoEdicion(true);
        }

        private void modoEdicion(bool activado)
        {
            if (activado)
            {
                this.lblTitulo.Text = "Alumnos - " + this.FormMode.ToString();
            }
            else
            {
                this.lblTitulo.Text = "Alumnos";
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            this.FormMode = FormModes.Baja;
            this.LimpiarCampos();
            EnableForm(false);
            try
            {
                this.MapearAForm(this.Logic.GetOne(this.SelectedID));
            }
            catch
            {
                throw;
            }
            this.modoEdicion(true);
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            this.modoEdicion(false);
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            Alumno al = MapearADatos();
            switch (FormMode)
            {
                case FormModes.Alta:
                    al.State = BusinessEntity.States.New;
                    break;
                case FormModes.Baja:
                    al.State = BusinessEntity.States.Deleted;
                    break;
                case FormModes.Modificacion:
                    al.State = BusinessEntity.States.Modified;
                    break;
                default:
                    al.State = BusinessEntity.States.Unmodified;
                    break;
            }
            try
            {
                this.Logic.Save(al);
            }
            catch 
            {
                throw;
            }
            this.Actualizar();
            this.modoEdicion(false);
        }
    }
}