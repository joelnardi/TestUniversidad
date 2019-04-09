namespace Desktop
{
    partial class EstadoCurso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EstadoCurso));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvEstadoCurso = new System.Windows.Forms.DataGridView();
            this.AlumnoStr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaInscripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoInscDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inscripcionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblDocente = new System.Windows.Forms.Label();
            this.lblCurso = new System.Windows.Forms.Label();
            this.cmbCurso = new System.Windows.Forms.ComboBox();
            this.txtDocente = new System.Windows.Forms.TextBox();
            this.btnVerCurso = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadoCurso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inscripcionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.14841F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.85159F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 145F));
            this.tableLayoutPanel1.Controls.Add(this.dgvEstadoCurso, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblDocente, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblCurso, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmbCurso, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtDocente, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnVerCurso, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.54237F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.45763F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 235F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(549, 295);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dgvEstadoCurso
            // 
            this.dgvEstadoCurso.AllowUserToAddRows = false;
            this.dgvEstadoCurso.AllowUserToDeleteRows = false;
            this.dgvEstadoCurso.AllowUserToResizeColumns = false;
            this.dgvEstadoCurso.AllowUserToResizeRows = false;
            this.dgvEstadoCurso.AutoGenerateColumns = false;
            this.dgvEstadoCurso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstadoCurso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AlumnoStr,
            this.fechaInscripcionDataGridViewTextBoxColumn,
            this.estadoInscDataGridViewTextBoxColumn});
            this.tableLayoutPanel1.SetColumnSpan(this.dgvEstadoCurso, 3);
            this.dgvEstadoCurso.DataSource = this.inscripcionBindingSource;
            this.dgvEstadoCurso.Location = new System.Drawing.Point(3, 62);
            this.dgvEstadoCurso.MultiSelect = false;
            this.dgvEstadoCurso.Name = "dgvEstadoCurso";
            this.dgvEstadoCurso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEstadoCurso.Size = new System.Drawing.Size(543, 230);
            this.dgvEstadoCurso.TabIndex = 0;
            // 
            // AlumnoStr
            // 
            this.AlumnoStr.DataPropertyName = "AlumnoStr";
            this.AlumnoStr.HeaderText = "Alumnos";
            this.AlumnoStr.Name = "AlumnoStr";
            this.AlumnoStr.ReadOnly = true;
            this.AlumnoStr.Width = 200;
            // 
            // fechaInscripcionDataGridViewTextBoxColumn
            // 
            this.fechaInscripcionDataGridViewTextBoxColumn.DataPropertyName = "FechaInscripcion";
            this.fechaInscripcionDataGridViewTextBoxColumn.HeaderText = "FechaInscripcion";
            this.fechaInscripcionDataGridViewTextBoxColumn.Name = "fechaInscripcionDataGridViewTextBoxColumn";
            // 
            // estadoInscDataGridViewTextBoxColumn
            // 
            this.estadoInscDataGridViewTextBoxColumn.DataPropertyName = "EstadoInsc";
            this.estadoInscDataGridViewTextBoxColumn.HeaderText = "EstadoInsc";
            this.estadoInscDataGridViewTextBoxColumn.Name = "estadoInscDataGridViewTextBoxColumn";
            this.estadoInscDataGridViewTextBoxColumn.Width = 200;
            // 
            // inscripcionBindingSource
            // 
            this.inscripcionBindingSource.DataSource = typeof(Business.Entities.Inscripcion);
            // 
            // lblDocente
            // 
            this.lblDocente.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDocente.AutoSize = true;
            this.lblDocente.Location = new System.Drawing.Point(54, 38);
            this.lblDocente.Name = "lblDocente";
            this.lblDocente.Size = new System.Drawing.Size(48, 13);
            this.lblDocente.TabIndex = 1;
            this.lblDocente.Text = "Docente";
            // 
            // lblCurso
            // 
            this.lblCurso.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCurso.AutoSize = true;
            this.lblCurso.Location = new System.Drawing.Point(68, 9);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(34, 13);
            this.lblCurso.TabIndex = 2;
            this.lblCurso.Text = "Curso";
            // 
            // cmbCurso
            // 
            this.cmbCurso.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbCurso.FormattingEnabled = true;
            this.cmbCurso.Location = new System.Drawing.Point(108, 5);
            this.cmbCurso.Name = "cmbCurso";
            this.cmbCurso.Size = new System.Drawing.Size(286, 21);
            this.cmbCurso.TabIndex = 3;
            // 
            // txtDocente
            // 
            this.txtDocente.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtDocente.Location = new System.Drawing.Point(108, 35);
            this.txtDocente.Name = "txtDocente";
            this.txtDocente.Size = new System.Drawing.Size(286, 20);
            this.txtDocente.TabIndex = 4;
            // 
            // btnVerCurso
            // 
            this.btnVerCurso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVerCurso.Location = new System.Drawing.Point(438, 4);
            this.btnVerCurso.Name = "btnVerCurso";
            this.btnVerCurso.Size = new System.Drawing.Size(75, 22);
            this.btnVerCurso.TabIndex = 5;
            this.btnVerCurso.Text = "Ver Curso";
            this.btnVerCurso.UseVisualStyleBackColor = true;
            this.btnVerCurso.Click += new System.EventHandler(this.btnVerCurso_Click);
            // 
            // EstadoCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 295);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(565, 334);
            this.MinimumSize = new System.Drawing.Size(565, 334);
            this.Name = "EstadoCurso";
            this.Text = "EstadoCurso";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstadoCurso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inscripcionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvEstadoCurso;
        private System.Windows.Forms.Label lblDocente;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.ComboBox cmbCurso;
        private System.Windows.Forms.TextBox txtDocente;
        private System.Windows.Forms.Button btnVerCurso;
        private System.Windows.Forms.BindingSource inscripcionBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlumnoStr;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaInscripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoInscDataGridViewTextBoxColumn;
    }
}