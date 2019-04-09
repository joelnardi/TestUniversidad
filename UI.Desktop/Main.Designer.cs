namespace Desktop
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnInscripciones = new System.Windows.Forms.Button();
            this.btnEstadoAcademico = new System.Windows.Forms.Button();
            this.btnAlumnos = new System.Windows.Forms.Button();
            this.btnEstadoCurso = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnInscripciones, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnEstadoAcademico, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAlumnos, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnEstadoCurso, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(347, 118);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnInscripciones
            // 
            this.btnInscripciones.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnInscripciones.Location = new System.Drawing.Point(8, 77);
            this.btnInscripciones.Name = "btnInscripciones";
            this.btnInscripciones.Size = new System.Drawing.Size(157, 23);
            this.btnInscripciones.TabIndex = 1;
            this.btnInscripciones.Text = "Gestion de Inscripciones";
            this.btnInscripciones.UseVisualStyleBackColor = true;
            this.btnInscripciones.Click += new System.EventHandler(this.btnInscripciones_Click);
            // 
            // btnEstadoAcademico
            // 
            this.btnEstadoAcademico.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEstadoAcademico.Location = new System.Drawing.Point(182, 18);
            this.btnEstadoAcademico.Name = "btnEstadoAcademico";
            this.btnEstadoAcademico.Size = new System.Drawing.Size(156, 23);
            this.btnEstadoAcademico.TabIndex = 2;
            this.btnEstadoAcademico.Text = "Estado Academico Alumno";
            this.btnEstadoAcademico.UseVisualStyleBackColor = true;
            this.btnEstadoAcademico.Click += new System.EventHandler(this.btnEstadoAcademico_Click);
            // 
            // btnAlumnos
            // 
            this.btnAlumnos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAlumnos.Location = new System.Drawing.Point(8, 18);
            this.btnAlumnos.Name = "btnAlumnos";
            this.btnAlumnos.Size = new System.Drawing.Size(157, 23);
            this.btnAlumnos.TabIndex = 0;
            this.btnAlumnos.Text = "Gestion de Alumnos";
            this.btnAlumnos.UseVisualStyleBackColor = true;
            this.btnAlumnos.Click += new System.EventHandler(this.btnAlumnos_Click);
            // 
            // btnEstadoCurso
            // 
            this.btnEstadoCurso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEstadoCurso.Location = new System.Drawing.Point(184, 77);
            this.btnEstadoCurso.Name = "btnEstadoCurso";
            this.btnEstadoCurso.Size = new System.Drawing.Size(151, 23);
            this.btnEstadoCurso.TabIndex = 3;
            this.btnEstadoCurso.Text = "Estado de Curso";
            this.btnEstadoCurso.UseVisualStyleBackColor = true;
            this.btnEstadoCurso.Click += new System.EventHandler(this.btnEstadoCurso_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 118);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(363, 157);
            this.MinimumSize = new System.Drawing.Size(363, 157);
            this.Name = "Main";
            this.Text = "Test TECSO";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnInscripciones;
        private System.Windows.Forms.Button btnEstadoAcademico;
        private System.Windows.Forms.Button btnAlumnos;
        private System.Windows.Forms.Button btnEstadoCurso;
    }
}