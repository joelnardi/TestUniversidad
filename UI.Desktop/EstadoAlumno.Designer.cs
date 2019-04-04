namespace UI.Desktop
{
    partial class EstadoAlumno
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txbIDAlumno = new System.Windows.Forms.TextBox();
            this.btnVerAlumno = new System.Windows.Forms.Button();
            this.lblVerAlumno = new System.Windows.Forms.Label();
            this.dgvVerAlumno = new System.Windows.Forms.DataGridView();
            this.alumnoAdapterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inscripcionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alumnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cursoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaInscripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoInscDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerAlumno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnoAdapterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inscripcionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 94F));
            this.tableLayoutPanel1.Controls.Add(this.txbIDAlumno, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnVerAlumno, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblVerAlumno, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvVerAlumno, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.20468F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.79532F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(637, 302);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txbIDAlumno
            // 
            this.txbIDAlumno.Location = new System.Drawing.Point(274, 3);
            this.txbIDAlumno.Name = "txbIDAlumno";
            this.txbIDAlumno.Size = new System.Drawing.Size(164, 20);
            this.txbIDAlumno.TabIndex = 0;
            // 
            // btnVerAlumno
            // 
            this.btnVerAlumno.Location = new System.Drawing.Point(545, 3);
            this.btnVerAlumno.Name = "btnVerAlumno";
            this.btnVerAlumno.Size = new System.Drawing.Size(75, 20);
            this.btnVerAlumno.TabIndex = 1;
            this.btnVerAlumno.Text = "Ver Alumno";
            this.btnVerAlumno.UseVisualStyleBackColor = true;
            this.btnVerAlumno.Click += new System.EventHandler(this.btnVerAlumno_Click);
            // 
            // lblVerAlumno
            // 
            this.lblVerAlumno.AutoSize = true;
            this.lblVerAlumno.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblVerAlumno.Location = new System.Drawing.Point(132, 0);
            this.lblVerAlumno.Name = "lblVerAlumno";
            this.lblVerAlumno.Size = new System.Drawing.Size(136, 26);
            this.lblVerAlumno.TabIndex = 2;
            this.lblVerAlumno.Text = "Ingrese ID de Alumno a ver";
            this.lblVerAlumno.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgvVerAlumno
            // 
            this.dgvVerAlumno.AllowUserToOrderColumns = true;
            this.dgvVerAlumno.AutoGenerateColumns = false;
            this.dgvVerAlumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVerAlumno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.alumnoDataGridViewTextBoxColumn,
            this.cursoDataGridViewTextBoxColumn,
            this.fechaInscripcionDataGridViewTextBoxColumn,
            this.estadoInscDataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn,
            this.stateDataGridViewTextBoxColumn});
            this.tableLayoutPanel1.SetColumnSpan(this.dgvVerAlumno, 3);
            this.dgvVerAlumno.DataSource = this.inscripcionBindingSource;
            this.dgvVerAlumno.Location = new System.Drawing.Point(3, 29);
            this.dgvVerAlumno.Name = "dgvVerAlumno";
            this.tableLayoutPanel1.SetRowSpan(this.dgvVerAlumno, 2);
            this.dgvVerAlumno.Size = new System.Drawing.Size(631, 270);
            this.dgvVerAlumno.TabIndex = 3;
            // 
            // alumnoAdapterBindingSource
            // 
            this.alumnoAdapterBindingSource.DataSource = typeof(Data.Database.AlumnoAdapter);
            // 
            // inscripcionBindingSource
            // 
            this.inscripcionBindingSource.DataSource = typeof(Business.Entities.Inscripcion);
            // 
            // alumnoDataGridViewTextBoxColumn
            // 
            this.alumnoDataGridViewTextBoxColumn.DataPropertyName = "Alumno";
            this.alumnoDataGridViewTextBoxColumn.HeaderText = "Alumno";
            this.alumnoDataGridViewTextBoxColumn.Name = "alumnoDataGridViewTextBoxColumn";
            // 
            // cursoDataGridViewTextBoxColumn
            // 
            this.cursoDataGridViewTextBoxColumn.DataPropertyName = "Curso";
            this.cursoDataGridViewTextBoxColumn.HeaderText = "Curso";
            this.cursoDataGridViewTextBoxColumn.Name = "cursoDataGridViewTextBoxColumn";
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
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // stateDataGridViewTextBoxColumn
            // 
            this.stateDataGridViewTextBoxColumn.DataPropertyName = "State";
            this.stateDataGridViewTextBoxColumn.HeaderText = "State";
            this.stateDataGridViewTextBoxColumn.Name = "stateDataGridViewTextBoxColumn";
            // 
            // EstadoAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 302);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "EstadoAlumno";
            this.Text = "EstadoAlumno";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerAlumno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnoAdapterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inscripcionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txbIDAlumno;
        private System.Windows.Forms.Button btnVerAlumno;
        private System.Windows.Forms.Label lblVerAlumno;
        private System.Windows.Forms.DataGridView dgvVerAlumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn alumnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cursoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaInscripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoInscDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource inscripcionBindingSource;
        private System.Windows.Forms.BindingSource alumnoAdapterBindingSource;
    }
}