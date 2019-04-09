namespace Desktop
{
    partial class EstadoAcademico
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EstadoAcademico));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblAlumno = new System.Windows.Forms.Label();
            this.cmbAlumno = new System.Windows.Forms.ComboBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.dgvEstadoAcademico = new System.Windows.Forms.DataGridView();
            this.CursoStr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaInscripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoInscDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inscripcionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadoAcademico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inscripcionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.49004F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.50996F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 228F));
            this.tableLayoutPanel1.Controls.Add(this.lblAlumno, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmbAlumno, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnGo, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvEstadoAcademico, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.39564F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.60436F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(552, 282);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblAlumno
            // 
            this.lblAlumno.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblAlumno.AutoSize = true;
            this.lblAlumno.Location = new System.Drawing.Point(44, 12);
            this.lblAlumno.Name = "lblAlumno";
            this.lblAlumno.Size = new System.Drawing.Size(42, 13);
            this.lblAlumno.TabIndex = 0;
            this.lblAlumno.Text = "Alumno";
            // 
            // cmbAlumno
            // 
            this.cmbAlumno.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbAlumno.FormattingEnabled = true;
            this.cmbAlumno.Location = new System.Drawing.Point(92, 8);
            this.cmbAlumno.Name = "cmbAlumno";
            this.cmbAlumno.Size = new System.Drawing.Size(228, 21);
            this.cmbAlumno.TabIndex = 1;
            // 
            // btnGo
            // 
            this.btnGo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGo.Location = new System.Drawing.Point(367, 7);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(140, 23);
            this.btnGo.TabIndex = 2;
            this.btnGo.Text = "Ver Estado Academico";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // dgvEstadoAcademico
            // 
            this.dgvEstadoAcademico.AllowUserToAddRows = false;
            this.dgvEstadoAcademico.AllowUserToDeleteRows = false;
            this.dgvEstadoAcademico.AllowUserToResizeColumns = false;
            this.dgvEstadoAcademico.AllowUserToResizeRows = false;
            this.dgvEstadoAcademico.AutoGenerateColumns = false;
            this.dgvEstadoAcademico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstadoAcademico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CursoStr,
            this.fechaInscripcionDataGridViewTextBoxColumn,
            this.estadoInscDataGridViewTextBoxColumn});
            this.tableLayoutPanel1.SetColumnSpan(this.dgvEstadoAcademico, 3);
            this.dgvEstadoAcademico.DataSource = this.inscripcionBindingSource;
            this.dgvEstadoAcademico.Location = new System.Drawing.Point(3, 40);
            this.dgvEstadoAcademico.Name = "dgvEstadoAcademico";
            this.dgvEstadoAcademico.ReadOnly = true;
            this.dgvEstadoAcademico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEstadoAcademico.Size = new System.Drawing.Size(546, 239);
            this.dgvEstadoAcademico.TabIndex = 3;
            // 
            // CursoStr
            // 
            this.CursoStr.DataPropertyName = "CursoStr";
            this.CursoStr.HeaderText = "Cursos";
            this.CursoStr.Name = "CursoStr";
            this.CursoStr.ReadOnly = true;
            this.CursoStr.Width = 200;
            // 
            // fechaInscripcionDataGridViewTextBoxColumn
            // 
            this.fechaInscripcionDataGridViewTextBoxColumn.DataPropertyName = "FechaInscripcion";
            this.fechaInscripcionDataGridViewTextBoxColumn.HeaderText = "FechaInscripcion";
            this.fechaInscripcionDataGridViewTextBoxColumn.Name = "fechaInscripcionDataGridViewTextBoxColumn";
            this.fechaInscripcionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estadoInscDataGridViewTextBoxColumn
            // 
            this.estadoInscDataGridViewTextBoxColumn.DataPropertyName = "EstadoInsc";
            this.estadoInscDataGridViewTextBoxColumn.HeaderText = "EstadoInsc";
            this.estadoInscDataGridViewTextBoxColumn.Name = "estadoInscDataGridViewTextBoxColumn";
            this.estadoInscDataGridViewTextBoxColumn.ReadOnly = true;
            this.estadoInscDataGridViewTextBoxColumn.Width = 200;
            // 
            // inscripcionBindingSource
            // 
            this.inscripcionBindingSource.DataSource = typeof(Business.Entities.Inscripcion);
            // 
            // EstadoAcademico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 282);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(568, 321);
            this.MinimumSize = new System.Drawing.Size(568, 321);
            this.Name = "EstadoAcademico";
            this.Text = "EstadoAcademico";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadoAcademico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inscripcionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblAlumno;
        private System.Windows.Forms.ComboBox cmbAlumno;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.DataGridView dgvEstadoAcademico;
        private System.Windows.Forms.BindingSource inscripcionBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn CursoStr;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaInscripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoInscDataGridViewTextBoxColumn;
    }
}