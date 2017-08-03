namespace Proyecto_Budget.Interfaz
{
    partial class frmPresupuestos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPresupuestos));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ttEliminar = new System.Windows.Forms.ToolTip(this.components);
            this.btnEliminarPresupuesto = new System.Windows.Forms.Button();
            this.ttAgregar = new System.Windows.Forms.ToolTip(this.components);
            this.btnAgregarPresupuesto = new System.Windows.Forms.Button();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.ttModificar = new System.Windows.Forms.ToolTip(this.components);
            this.btnEditarPresupuesto = new System.Windows.Forms.Button();
            this.btnBuscarPresupuesto = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ttBuscar = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvPresupuestos = new System.Windows.Forms.DataGridView();
            this.cbDepartamentos = new System.Windows.Forms.ComboBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtInicio = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtFin = new System.Windows.Forms.DateTimePicker();
            this.dgvDepartamentos = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPresupuestos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // ttEliminar
            // 
            this.ttEliminar.IsBalloon = true;
            // 
            // btnEliminarPresupuesto
            // 
            this.btnEliminarPresupuesto.Image = global::Proyecto_Budget.Properties.Resources._1496729761_flat_style_circle_delete_trash;
            this.btnEliminarPresupuesto.Location = new System.Drawing.Point(769, 32);
            this.btnEliminarPresupuesto.Name = "btnEliminarPresupuesto";
            this.btnEliminarPresupuesto.Size = new System.Drawing.Size(110, 100);
            this.btnEliminarPresupuesto.TabIndex = 50;
            this.ttEliminar.SetToolTip(this.btnEliminarPresupuesto, "Eliminar  presupuesto");
            this.btnEliminarPresupuesto.UseVisualStyleBackColor = true;
            this.btnEliminarPresupuesto.Click += new System.EventHandler(this.btnEliminarPresupuesto_Click);
            // 
            // ttAgregar
            // 
            this.ttAgregar.IsBalloon = true;
            // 
            // btnAgregarPresupuesto
            // 
            this.btnAgregarPresupuesto.Image = global::Proyecto_Budget.Properties.Resources._1496729731_flat_style_circle_add;
            this.btnAgregarPresupuesto.Location = new System.Drawing.Point(421, 32);
            this.btnAgregarPresupuesto.Name = "btnAgregarPresupuesto";
            this.btnAgregarPresupuesto.Size = new System.Drawing.Size(110, 100);
            this.btnAgregarPresupuesto.TabIndex = 49;
            this.ttAgregar.SetToolTip(this.btnAgregarPresupuesto, "Agregar nuevo presupuesto");
            this.btnAgregarPresupuesto.UseVisualStyleBackColor = true;
            this.btnAgregarPresupuesto.Click += new System.EventHandler(this.btnAgregarPresupuesto_Click);
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(256, 120);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(150, 20);
            this.txtMonto.TabIndex = 45;
            // 
            // ttModificar
            // 
            this.ttModificar.IsBalloon = true;
            // 
            // btnEditarPresupuesto
            // 
            this.btnEditarPresupuesto.Image = global::Proyecto_Budget.Properties.Resources._1496729902_circle_edit_line;
            this.btnEditarPresupuesto.Location = new System.Drawing.Point(653, 32);
            this.btnEditarPresupuesto.Name = "btnEditarPresupuesto";
            this.btnEditarPresupuesto.Size = new System.Drawing.Size(110, 100);
            this.btnEditarPresupuesto.TabIndex = 51;
            this.ttModificar.SetToolTip(this.btnEditarPresupuesto, "Modificar  presupuesto seleccionado");
            this.btnEditarPresupuesto.UseVisualStyleBackColor = true;
            this.btnEditarPresupuesto.Click += new System.EventHandler(this.btnEditarPresupuesto_Click);
            // 
            // btnBuscarPresupuesto
            // 
            this.btnBuscarPresupuesto.Image = global::Proyecto_Budget.Properties.Resources._1497137621_circle_edit_search_thin;
            this.btnBuscarPresupuesto.Location = new System.Drawing.Point(537, 32);
            this.btnBuscarPresupuesto.Name = "btnBuscarPresupuesto";
            this.btnBuscarPresupuesto.Size = new System.Drawing.Size(110, 100);
            this.btnBuscarPresupuesto.TabIndex = 52;
            this.ttBuscar.SetToolTip(this.btnBuscarPresupuesto, "Buscar presupuesto existente");
            this.btnBuscarPresupuesto.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Monto (Miles de $):";
            // 
            // ttBuscar
            // 
            this.ttBuscar.IsBalloon = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Departamento:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyecto_Budget.Properties.Resources._1496303858_money;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // dgvPresupuestos
            // 
            this.dgvPresupuestos.AllowUserToOrderColumns = true;
            this.dgvPresupuestos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPresupuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPresupuestos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvPresupuestos.Location = new System.Drawing.Point(12, 200);
            this.dgvPresupuestos.Name = "dgvPresupuestos";
            this.dgvPresupuestos.RowHeadersVisible = false;
            this.dgvPresupuestos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPresupuestos.Size = new System.Drawing.Size(609, 188);
            this.dgvPresupuestos.TabIndex = 37;
            this.dgvPresupuestos.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPresupuestos_CellEnter);
            // 
            // cbDepartamentos
            // 
            this.cbDepartamentos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbDepartamentos.FormattingEnabled = true;
            this.cbDepartamentos.Items.AddRange(new object[] {
            "Credito",
            "Tecnologia",
            "Contabilidad",
            "Ventas",
            "Gerencia",
            "Tesorería",
            "Cobros",
            "Recursos Humanos",
            "Mercadeo",
            "Capacitacion"});
            this.cbDepartamentos.Location = new System.Drawing.Point(256, 17);
            this.cbDepartamentos.Name = "cbDepartamentos";
            this.cbDepartamentos.Size = new System.Drawing.Size(150, 21);
            this.cbDepartamentos.TabIndex = 53;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(256, 44);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(150, 20);
            this.txtDesc.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(157, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 54;
            this.label3.Text = "Descripción:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(157, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 56;
            this.label4.Text = "Fecha inicio:";
            // 
            // dtInicio
            // 
            this.dtInicio.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInicio.Location = new System.Drawing.Point(256, 70);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(150, 20);
            this.dtInicio.TabIndex = 57;
            this.dtInicio.Value = new System.DateTime(2017, 8, 2, 15, 56, 2, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(157, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 58;
            this.label5.Text = "Expiración:";
            // 
            // dtFin
            // 
            this.dtFin.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFin.Location = new System.Drawing.Point(256, 96);
            this.dtFin.Name = "dtFin";
            this.dtFin.Size = new System.Drawing.Size(150, 20);
            this.dtFin.TabIndex = 60;
            this.dtFin.Value = new System.DateTime(2017, 8, 2, 15, 56, 2, 0);
            // 
            // dgvDepartamentos
            // 
            this.dgvDepartamentos.AllowUserToOrderColumns = true;
            this.dgvDepartamentos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDepartamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepartamentos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvDepartamentos.Location = new System.Drawing.Point(653, 200);
            this.dgvDepartamentos.Name = "dgvDepartamentos";
            this.dgvDepartamentos.RowHeadersVisible = false;
            this.dgvDepartamentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDepartamentos.Size = new System.Drawing.Size(226, 188);
            this.dgvDepartamentos.TabIndex = 61;
            this.dgvDepartamentos.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDepartamentos_CellEnter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label6.Location = new System.Drawing.Point(9, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 13);
            this.label6.TabIndex = 62;
            this.label6.Text = "Lista de presupuestos:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label7.Location = new System.Drawing.Point(650, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 13);
            this.label7.TabIndex = 63;
            this.label7.Text = "Lista de departamentos:";
            // 
            // frmPresupuestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(894, 403);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvDepartamentos);
            this.Controls.Add(this.dtFin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtInicio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbDepartamentos);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.btnBuscarPresupuesto);
            this.Controls.Add(this.btnEditarPresupuesto);
            this.Controls.Add(this.btnEliminarPresupuesto);
            this.Controls.Add(this.btnAgregarPresupuesto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvPresupuestos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmPresupuestos";
            this.Text = " c";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPresupuestos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartamentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip ttEliminar;
        private System.Windows.Forms.Button btnEliminarPresupuesto;
        private System.Windows.Forms.ToolTip ttAgregar;
        private System.Windows.Forms.Button btnAgregarPresupuesto;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.ToolTip ttModificar;
        private System.Windows.Forms.Button btnEditarPresupuesto;
        private System.Windows.Forms.Button btnBuscarPresupuesto;
        private System.Windows.Forms.ToolTip ttBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvPresupuestos;
        private System.Windows.Forms.ComboBox cbDepartamentos;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtInicio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtFin;
        private System.Windows.Forms.DataGridView dgvDepartamentos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}