namespace UI.Desktop
{
    partial class Main
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnNuevoAlumno = new System.Windows.Forms.Button();
            this.btnEditarAlumno = new System.Windows.Forms.Button();
            this.btnNuevaInscripcion = new System.Windows.Forms.Button();
            this.btnEstadoAcademico = new System.Windows.Forms.Button();
            this.btnEstadoCurso = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.6921F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 191F));
            this.tableLayoutPanel1.Controls.Add(this.btnNuevoAlumno, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnEditarAlumno, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnNuevaInscripcion, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnEstadoAcademico, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnEstadoCurso, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(388, 237);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnNuevoAlumno
            // 
            this.btnNuevoAlumno.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNuevoAlumno.Location = new System.Drawing.Point(3, 3);
            this.btnNuevoAlumno.Name = "btnNuevoAlumno";
            this.btnNuevoAlumno.Size = new System.Drawing.Size(191, 73);
            this.btnNuevoAlumno.TabIndex = 0;
            this.btnNuevoAlumno.Text = "Registrar Alumno";
            this.btnNuevoAlumno.UseVisualStyleBackColor = true;
            this.btnNuevoAlumno.Click += new System.EventHandler(this.btnNuevoAlumno_Click);
            // 
            // btnEditarAlumno
            // 
            this.btnEditarAlumno.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEditarAlumno.Location = new System.Drawing.Point(3, 82);
            this.btnEditarAlumno.Name = "btnEditarAlumno";
            this.btnEditarAlumno.Size = new System.Drawing.Size(191, 73);
            this.btnEditarAlumno.TabIndex = 1;
            this.btnEditarAlumno.Text = "Editar Alumno";
            this.btnEditarAlumno.UseVisualStyleBackColor = true;
            // 
            // btnNuevaInscripcion
            // 
            this.btnNuevaInscripcion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNuevaInscripcion.Location = new System.Drawing.Point(3, 161);
            this.btnNuevaInscripcion.Name = "btnNuevaInscripcion";
            this.btnNuevaInscripcion.Size = new System.Drawing.Size(191, 73);
            this.btnNuevaInscripcion.TabIndex = 2;
            this.btnNuevaInscripcion.Text = "Inscribir Alumno a Curso";
            this.btnNuevaInscripcion.UseVisualStyleBackColor = true;
            // 
            // btnEstadoAcademico
            // 
            this.btnEstadoAcademico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEstadoAcademico.Location = new System.Drawing.Point(200, 3);
            this.btnEstadoAcademico.Name = "btnEstadoAcademico";
            this.btnEstadoAcademico.Size = new System.Drawing.Size(185, 73);
            this.btnEstadoAcademico.TabIndex = 3;
            this.btnEstadoAcademico.Text = "Estado Academico de Alumno";
            this.btnEstadoAcademico.UseVisualStyleBackColor = true;
            this.btnEstadoAcademico.Click += new System.EventHandler(this.btnEstadoAcademico_Click);
            // 
            // btnEstadoCurso
            // 
            this.btnEstadoCurso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEstadoCurso.Location = new System.Drawing.Point(200, 82);
            this.btnEstadoCurso.Name = "btnEstadoCurso";
            this.btnEstadoCurso.Size = new System.Drawing.Size(185, 73);
            this.btnEstadoCurso.TabIndex = 4;
            this.btnEstadoCurso.Text = "Estado de Curso";
            this.btnEstadoCurso.UseVisualStyleBackColor = true;
            this.btnEstadoCurso.Click += new System.EventHandler(this.btnEstadoCurso_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 237);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Main";
            this.Text = "Main";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnNuevoAlumno;
        private System.Windows.Forms.Button btnEditarAlumno;
        private System.Windows.Forms.Button btnNuevaInscripcion;
        private System.Windows.Forms.Button btnEstadoAcademico;
        private System.Windows.Forms.Button btnEstadoCurso;
    }
}

