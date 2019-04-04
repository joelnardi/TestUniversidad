namespace UI.Desktop
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
            this.tblAlumnoDesktop = new System.Windows.Forms.TableLayoutPanel();
            this.lblID = new System.Windows.Forms.Label();
            this.txbID = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.txbLegajo = new System.Windows.Forms.TextBox();
            this.lblLegajo = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.datFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.tblAlumnoDesktop.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblAlumnoDesktop
            // 
            this.tblAlumnoDesktop.ColumnCount = 4;
            this.tblAlumnoDesktop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.98653F));
            this.tblAlumnoDesktop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.01347F));
            this.tblAlumnoDesktop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tblAlumnoDesktop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.tblAlumnoDesktop.Controls.Add(this.lblID, 0, 0);
            this.tblAlumnoDesktop.Controls.Add(this.txbID, 1, 0);
            this.tblAlumnoDesktop.Controls.Add(this.lblNombre, 0, 1);
            this.tblAlumnoDesktop.Controls.Add(this.txbNombre, 1, 1);
            this.tblAlumnoDesktop.Controls.Add(this.txbLegajo, 1, 2);
            this.tblAlumnoDesktop.Controls.Add(this.lblLegajo, 0, 2);
            this.tblAlumnoDesktop.Controls.Add(this.lblFechaNacimiento, 0, 3);
            this.tblAlumnoDesktop.Controls.Add(this.btnCancelar, 2, 4);
            this.tblAlumnoDesktop.Controls.Add(this.btnAceptar, 3, 4);
            this.tblAlumnoDesktop.Controls.Add(this.datFechaNacimiento, 1, 3);
            this.tblAlumnoDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblAlumnoDesktop.Location = new System.Drawing.Point(0, 0);
            this.tblAlumnoDesktop.Name = "tblAlumnoDesktop";
            this.tblAlumnoDesktop.RowCount = 6;
            this.tblAlumnoDesktop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tblAlumnoDesktop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tblAlumnoDesktop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tblAlumnoDesktop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tblAlumnoDesktop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tblAlumnoDesktop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.tblAlumnoDesktop.Size = new System.Drawing.Size(453, 160);
            this.tblAlumnoDesktop.TabIndex = 0;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblID.Location = new System.Drawing.Point(77, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 27);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID";
            // 
            // txbID
            // 
            this.txbID.Dock = System.Windows.Forms.DockStyle.Left;
            this.txbID.Location = new System.Drawing.Point(101, 3);
            this.txbID.Name = "txbID";
            this.txbID.Size = new System.Drawing.Size(179, 20);
            this.txbID.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblNombre.Location = new System.Drawing.Point(51, 27);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 28);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(101, 30);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(179, 20);
            this.txbNombre.TabIndex = 3;
            // 
            // txbLegajo
            // 
            this.txbLegajo.Dock = System.Windows.Forms.DockStyle.Left;
            this.txbLegajo.Location = new System.Drawing.Point(101, 58);
            this.txbLegajo.Name = "txbLegajo";
            this.txbLegajo.Size = new System.Drawing.Size(179, 20);
            this.txbLegajo.TabIndex = 4;
            // 
            // lblLegajo
            // 
            this.lblLegajo.AutoSize = true;
            this.lblLegajo.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblLegajo.Location = new System.Drawing.Point(56, 55);
            this.lblLegajo.Name = "lblLegajo";
            this.lblLegajo.Size = new System.Drawing.Size(39, 29);
            this.lblLegajo.TabIndex = 5;
            this.lblLegajo.Text = "Legajo";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(35, 84);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(60, 43);
            this.lblFechaNacimiento.TabIndex = 6;
            this.lblFechaNacimiento.Text = "Fecha de Nacimiento";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancelar.Location = new System.Drawing.Point(310, 130);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(65, 23);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAceptar.Location = new System.Drawing.Point(381, 130);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(69, 23);
            this.btnAceptar.TabIndex = 9;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // datFechaNacimiento
            // 
            this.datFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datFechaNacimiento.Location = new System.Drawing.Point(101, 87);
            this.datFechaNacimiento.Name = "datFechaNacimiento";
            this.datFechaNacimiento.Size = new System.Drawing.Size(200, 20);
            this.datFechaNacimiento.TabIndex = 10;
            // 
            // AlumnoDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 160);
            this.Controls.Add(this.tblAlumnoDesktop);
            this.Name = "AlumnoDesktop";
            this.Text = "AlumnoDesktop";
            this.tblAlumnoDesktop.ResumeLayout(false);
            this.tblAlumnoDesktop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblAlumnoDesktop;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.TextBox txbLegajo;
        private System.Windows.Forms.Label lblLegajo;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.DateTimePicker datFechaNacimiento;
    }
}