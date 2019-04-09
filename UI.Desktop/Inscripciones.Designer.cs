namespace Desktop
{
    partial class Inscripciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inscripciones));
            this.tlInscripciones = new System.Windows.Forms.TableLayoutPanel();
            this.tspInscripciones = new System.Windows.Forms.ToolStrip();
            this.btnAgregar = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.btnActualizar = new System.Windows.Forms.ToolStripButton();
            this.dgvInscripciones = new System.Windows.Forms.DataGridView();
            this.AlumnoStr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CursoStr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaInscripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoInscDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inscripcionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tlInscripciones.SuspendLayout();
            this.tspInscripciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInscripciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inscripcionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tlInscripciones
            // 
            this.tlInscripciones.ColumnCount = 2;
            this.tlInscripciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlInscripciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlInscripciones.Controls.Add(this.tspInscripciones, 0, 0);
            this.tlInscripciones.Controls.Add(this.dgvInscripciones, 0, 1);
            this.tlInscripciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlInscripciones.Location = new System.Drawing.Point(0, 0);
            this.tlInscripciones.Name = "tlInscripciones";
            this.tlInscripciones.RowCount = 2;
            this.tlInscripciones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.95107F));
            this.tlInscripciones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.04893F));
            this.tlInscripciones.Size = new System.Drawing.Size(710, 327);
            this.tlInscripciones.TabIndex = 0;
            // 
            // tspInscripciones
            // 
            this.tlInscripciones.SetColumnSpan(this.tspInscripciones, 2);
            this.tspInscripciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAgregar,
            this.btnEditar,
            this.btnEliminar,
            this.btnActualizar});
            this.tspInscripciones.Location = new System.Drawing.Point(0, 0);
            this.tspInscripciones.Name = "tspInscripciones";
            this.tspInscripciones.Size = new System.Drawing.Size(710, 25);
            this.tspInscripciones.TabIndex = 0;
            this.tspInscripciones.Text = "toolStrip1";
            // 
            // btnAgregar
            // 
            this.btnAgregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(23, 22);
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(23, 22);
            this.btnEditar.Text = "Editar";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(23, 22);
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(23, 22);
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // dgvInscripciones
            // 
            this.dgvInscripciones.AllowUserToAddRows = false;
            this.dgvInscripciones.AllowUserToDeleteRows = false;
            this.dgvInscripciones.AllowUserToResizeColumns = false;
            this.dgvInscripciones.AllowUserToResizeRows = false;
            this.dgvInscripciones.AutoGenerateColumns = false;
            this.dgvInscripciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInscripciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.AlumnoStr,
            this.CursoStr,
            this.fechaInscripcionDataGridViewTextBoxColumn,
            this.estadoInscDataGridViewTextBoxColumn});
            this.tlInscripciones.SetColumnSpan(this.dgvInscripciones, 2);
            this.dgvInscripciones.DataSource = this.inscripcionBindingSource;
            this.dgvInscripciones.Location = new System.Drawing.Point(3, 28);
            this.dgvInscripciones.MaximumSize = new System.Drawing.Size(704, 296);
            this.dgvInscripciones.MinimumSize = new System.Drawing.Size(704, 296);
            this.dgvInscripciones.Name = "dgvInscripciones";
            this.dgvInscripciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInscripciones.Size = new System.Drawing.Size(704, 296);
            this.dgvInscripciones.TabIndex = 1;
            // 
            // AlumnoStr
            // 
            this.AlumnoStr.DataPropertyName = "AlumnoStr";
            this.AlumnoStr.HeaderText = "Alumnos";
            this.AlumnoStr.Name = "AlumnoStr";
            this.AlumnoStr.ReadOnly = true;
            this.AlumnoStr.Width = 200;
            // 
            // CursoStr
            // 
            this.CursoStr.DataPropertyName = "CursoStr";
            this.CursoStr.HeaderText = "Cursos";
            this.CursoStr.Name = "CursoStr";
            this.CursoStr.ReadOnly = true;
            this.CursoStr.Width = 200;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 40;
            // 
            // fechaInscripcionDataGridViewTextBoxColumn
            // 
            this.fechaInscripcionDataGridViewTextBoxColumn.DataPropertyName = "FechaInscripcion";
            this.fechaInscripcionDataGridViewTextBoxColumn.HeaderText = "FechaInscripcion";
            this.fechaInscripcionDataGridViewTextBoxColumn.Name = "fechaInscripcionDataGridViewTextBoxColumn";
            this.fechaInscripcionDataGridViewTextBoxColumn.Width = 70;
            // 
            // estadoInscDataGridViewTextBoxColumn
            // 
            this.estadoInscDataGridViewTextBoxColumn.DataPropertyName = "EstadoInsc";
            this.estadoInscDataGridViewTextBoxColumn.HeaderText = "EstadoInsc";
            this.estadoInscDataGridViewTextBoxColumn.Name = "estadoInscDataGridViewTextBoxColumn";
            this.estadoInscDataGridViewTextBoxColumn.Width = 150;
            // 
            // inscripcionBindingSource
            // 
            this.inscripcionBindingSource.DataSource = typeof(Business.Entities.Inscripcion);
            // 
            // Inscripciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 327);
            this.Controls.Add(this.tlInscripciones);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(726, 366);
            this.MinimumSize = new System.Drawing.Size(726, 366);
            this.Name = "Inscripciones";
            this.Text = "Inscripciones";
            this.tlInscripciones.ResumeLayout(false);
            this.tlInscripciones.PerformLayout();
            this.tspInscripciones.ResumeLayout(false);
            this.tspInscripciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInscripciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inscripcionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlInscripciones;
        private System.Windows.Forms.ToolStrip tspInscripciones;
        private System.Windows.Forms.DataGridView dgvInscripciones;
        private System.Windows.Forms.BindingSource inscripcionBindingSource;
        private System.Windows.Forms.ToolStripButton btnAgregar;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.ToolStripButton btnActualizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlumnoStr;
        private System.Windows.Forms.DataGridViewTextBoxColumn CursoStr;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaInscripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoInscDataGridViewTextBoxColumn;
    }
}