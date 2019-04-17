using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business.Entities;
using Business.Logic;

namespace Web
{
    public partial class Inscripciones : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void Actualizar()
        {
            try
            {
                this.dgvInscripciones.DataBind();
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

        private InscripcionLogic _logic;
        public InscripcionLogic Logic
        {
            get
            {
                if (_logic == null)
                {
                    _logic = new InscripcionLogic();
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
            ddlAlumno.Enabled = enable;
            ddlCurso.Enabled = enable;
            cldFechaInscripcion.Enabled = enable;
            ddlEstado.Enabled = enable;
        }

        private void LimpiarCampos()
        {
            txtID.Text = string.Empty;
        }

        private void MapearAForm(Inscripcion insc)
        {
            txtID.Text = insc.ID.ToString();
            ddlAlumno.SelectedItem.Value = insc.Alumno.Nombre;
            ddlCurso.SelectedItem.Value = insc.Curso.Asignatura;
            cldFechaInscripcion.SelectedDate = insc.FechaInscripcion;
            ddlEstado.SelectedItem.Value = insc.EstadoInsc;
        }

        private Inscripcion MapearADatos()
        {
            Inscripcion insc = new Inscripcion();
            if (this.FormMode != FormModes.Alta)
            {
                insc.ID = int.Parse(txtID.Text);
            }
            insc.EstadoInsc = ddlEstado.SelectedItem.Text;
            CursoLogic cursoLogic = new CursoLogic();
            insc.Curso = cursoLogic.GetOne(int.Parse(ddlCurso.SelectedValue));
            AlumnoLogic alumnoLogic = new AlumnoLogic();
            insc.Alumno = alumnoLogic.GetOne(int.Parse(ddlAlumno.SelectedValue));
            return insc;
        }

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            this.FormMode = FormModes.Alta;
            this.LimpiarCampos();
            this.EnableForm(true);
            this.modoEdicion(true);
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

        private void modoEdicion(bool activado)
        {
            if (activado)
            {
                this.lblTitulo.Text = "Inscripciones - " + this.FormMode.ToString();
            }
            else
            {
                this.lblTitulo.Text = "Inscripciones";
            }
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            Inscripcion insc = MapearADatos();
            switch (FormMode)
            {
                case FormModes.Alta:
                    insc.State = BusinessEntity.States.New;
                    break;
                case FormModes.Baja:
                    insc.State = BusinessEntity.States.Deleted;
                    break;
                case FormModes.Modificacion:
                    insc.State = BusinessEntity.States.Modified;
                    break;
                default:
                    insc.State = BusinessEntity.States.Unmodified;
                    break;
            }
            try
            {
                this.Logic.Save(insc);
            }
            catch
            {
                throw;
            }
            this.Actualizar();
            this.modoEdicion(false);
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            this.modoEdicion(false);
        }

        protected void dgvInscripciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ViewState["SelectedID"] = (int)this.dgvInscripciones.SelectedDataKey.Value;
        }
    }
}