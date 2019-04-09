namespace Desktop
{
    partial class AlumnoDesktop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlumnoDesktop));
            this.tlAlumnoDesktop = new System.Windows.Forms.TableLayoutPanel();
            this.lblID = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblLegajo = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtLegajo = new System.Windows.Forms.TextBox();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.tlAlumnoDesktop.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlAlumnoDesktop
            // 
            this.tlAlumnoDesktop.ColumnCount = 2;
            this.tlAlumnoDesktop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlAlumnoDesktop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlAlumnoDesktop.Controls.Add(this.lblID, 0, 0);
            this.tlAlumnoDesktop.Controls.Add(this.lblNombre, 0, 1);
            this.tlAlumnoDesktop.Controls.Add(this.lblLegajo, 0, 2);
            this.tlAlumnoDesktop.Controls.Add(this.txtID, 1, 0);
            this.tlAlumnoDesktop.Controls.Add(this.txtNombre, 1, 1);
            this.tlAlumnoDesktop.Controls.Add(this.txtLegajo, 1, 2);
            this.tlAlumnoDesktop.Controls.Add(this.lblFechaNacimiento, 0, 3);
            this.tlAlumnoDesktop.Controls.Add(this.btnAceptar, 1, 4);
            this.tlAlumnoDesktop.Controls.Add(this.btnCancelar, 0, 4);
            this.tlAlumnoDesktop.Controls.Add(this.dtpFechaNacimiento, 1, 3);
            this.tlAlumnoDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlAlumnoDesktop.Location = new System.Drawing.Point(0, 0);
            this.tlAlumnoDesktop.Name = "tlAlumnoDesktop";
            this.tlAlumnoDesktop.RowCount = 5;
            this.tlAlumnoDesktop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tlAlumnoDesktop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tlAlumnoDesktop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tlAlumnoDesktop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tlAlumnoDesktop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tlAlumnoDesktop.Size = new System.Drawing.Size(422, 136);
            this.tlAlumnoDesktop.TabIndex = 0;
            // 
            // lblID
            // 
            this.lblID.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(190, 5);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID";
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(164, 29);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblLegajo
            // 
            this.lblLegajo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblLegajo.AutoSize = true;
            this.lblLegajo.Location = new System.Drawing.Point(169, 55);
            this.lblLegajo.Name = "lblLegajo";
            this.lblLegajo.Size = new System.Drawing.Size(39, 13);
            this.lblLegajo.TabIndex = 2;
            this.lblLegajo.Text = "Legajo";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(214, 3);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(200, 20);
            this.txtID.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(214, 27);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // txtLegajo
            // 
            this.txtLegajo.Location = new System.Drawing.Point(214, 51);
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.Size = new System.Drawing.Size(200, 20);
            this.txtLegajo.TabIndex = 5;
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(100, 82);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(108, 13);
            this.lblFechaNacimiento.TabIndex = 6;
            this.lblFechaNacimiento.Text = "Fecha de Nacimiento";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.Location = new System.Drawing.Point(344, 106);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 8;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(133, 106);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.CustomFormat = "";
            this.dtpFechaNacimiento.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(214, 78);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaNacimiento.TabIndex = 7;
            // 
            // AlumnoDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 136);
            this.Controls.Add(this.tlAlumnoDesktop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(438, 175);
            this.MinimumSize = new System.Drawing.Size(438, 175);
            this.Name = "AlumnoDesktop";
            this.Text = "AlumnoDesktop";
            this.tlAlumnoDesktop.ResumeLayout(false);
            this.tlAlumnoDesktop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlAlumnoDesktop;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblLegajo;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}