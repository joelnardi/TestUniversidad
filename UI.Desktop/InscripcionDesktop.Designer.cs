namespace Desktop
{
    partial class InscripcionDesktop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InscripcionDesktop));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cmbAlumno = new System.Windows.Forms.ComboBox();
            this.cmbCurso = new System.Windows.Forms.ComboBox();
            this.lblAlumno = new System.Windows.Forms.Label();
            this.lblCurso = new System.Windows.Forms.Label();
            this.lblFechaInscripcion = new System.Windows.Forms.Label();
            this.dtpFechaInscripcion = new System.Windows.Forms.DateTimePicker();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.21348F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.78651F));
            this.tableLayoutPanel1.Controls.Add(this.cmbAlumno, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmbCurso, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblAlumno, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblCurso, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblFechaInscripcion, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.dtpFechaInscripcion, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblEstado, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.cmbEstado, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblID, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAceptar, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnCancelar, 0, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(394, 184);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // cmbAlumno
            // 
            this.cmbAlumno.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbAlumno.FormattingEnabled = true;
            this.cmbAlumno.Location = new System.Drawing.Point(118, 34);
            this.cmbAlumno.Name = "cmbAlumno";
            this.cmbAlumno.Size = new System.Drawing.Size(245, 21);
            this.cmbAlumno.TabIndex = 0;
            // 
            // cmbCurso
            // 
            this.cmbCurso.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbCurso.FormattingEnabled = true;
            this.cmbCurso.Location = new System.Drawing.Point(118, 64);
            this.cmbCurso.Name = "cmbCurso";
            this.cmbCurso.Size = new System.Drawing.Size(245, 21);
            this.cmbCurso.TabIndex = 1;
            // 
            // lblAlumno
            // 
            this.lblAlumno.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblAlumno.AutoSize = true;
            this.lblAlumno.Location = new System.Drawing.Point(70, 38);
            this.lblAlumno.Name = "lblAlumno";
            this.lblAlumno.Size = new System.Drawing.Size(42, 13);
            this.lblAlumno.TabIndex = 2;
            this.lblAlumno.Text = "Alumno";
            // 
            // lblCurso
            // 
            this.lblCurso.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCurso.AutoSize = true;
            this.lblCurso.Location = new System.Drawing.Point(78, 68);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(34, 13);
            this.lblCurso.TabIndex = 3;
            this.lblCurso.Text = "Curso";
            // 
            // lblFechaInscripcion
            // 
            this.lblFechaInscripcion.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblFechaInscripcion.AutoSize = true;
            this.lblFechaInscripcion.Location = new System.Drawing.Point(6, 99);
            this.lblFechaInscripcion.Name = "lblFechaInscripcion";
            this.lblFechaInscripcion.Size = new System.Drawing.Size(106, 13);
            this.lblFechaInscripcion.TabIndex = 4;
            this.lblFechaInscripcion.Text = "Fecha de Inscripcion";
            // 
            // dtpFechaInscripcion
            // 
            this.dtpFechaInscripcion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpFechaInscripcion.Location = new System.Drawing.Point(118, 95);
            this.dtpFechaInscripcion.Name = "dtpFechaInscripcion";
            this.dtpFechaInscripcion.Size = new System.Drawing.Size(245, 20);
            this.dtpFechaInscripcion.TabIndex = 5;
            // 
            // lblEstado
            // 
            this.lblEstado.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(72, 130);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(40, 13);
            this.lblEstado.TabIndex = 6;
            this.lblEstado.Text = "Estado";
            // 
            // cmbEstado
            // 
            this.cmbEstado.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "1-Inscripto",
            "2-Regular",
            "3-No Regularizo"});
            this.cmbEstado.Location = new System.Drawing.Point(118, 126);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(245, 21);
            this.cmbEstado.TabIndex = 7;
            // 
            // lblID
            // 
            this.lblID.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(94, 8);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 8;
            this.lblID.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtID.Location = new System.Drawing.Point(118, 5);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(89, 20);
            this.txtID.TabIndex = 9;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAceptar.Location = new System.Drawing.Point(217, 155);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 10;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancelar.Location = new System.Drawing.Point(20, 155);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // InscripcionDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 184);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(410, 223);
            this.MinimumSize = new System.Drawing.Size(410, 223);
            this.Name = "InscripcionDesktop";
            this.Text = "InscripcionDesktop";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox cmbAlumno;
        private System.Windows.Forms.ComboBox cmbCurso;
        private System.Windows.Forms.Label lblAlumno;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.Label lblFechaInscripcion;
        private System.Windows.Forms.DateTimePicker dtpFechaInscripcion;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cmbEstado;
    }
}