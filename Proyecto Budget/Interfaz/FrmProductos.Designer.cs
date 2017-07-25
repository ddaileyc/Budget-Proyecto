namespace Proyecto_Budget.Interfaz
{
    partial class FrmProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProductos));
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TxtProveedor = new System.Windows.Forms.TextBox();
            this.TxtCosto = new System.Windows.Forms.TextBox();
            this.TxtMarca = new System.Windows.Forms.TextBox();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.btnEditarProducto = new System.Windows.Forms.Button();
            this.btnEliminarProducto = new System.Windows.Forms.Button();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.ttModificar = new System.Windows.Forms.ToolTip(this.components);
            this.ttAgregar = new System.Windows.Forms.ToolTip(this.components);
            this.ttBuscar = new System.Windows.Forms.ToolTip(this.components);
            this.ttEliminar = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToOrderColumns = true;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvProductos.Location = new System.Drawing.Point(12, 176);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(869, 188);
            this.dgvProductos.TabIndex = 1;
            this.dgvProductos.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellEnter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyecto_Budget.Properties.Resources._1496305348_shopping_basket;
            this.pictureBox1.Location = new System.Drawing.Point(12, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // TxtProveedor
            // 
            this.TxtProveedor.Location = new System.Drawing.Point(247, 125);
            this.TxtProveedor.Name = "TxtProveedor";
            this.TxtProveedor.Size = new System.Drawing.Size(150, 20);
            this.TxtProveedor.TabIndex = 22;
            // 
            // TxtCosto
            // 
            this.TxtCosto.Location = new System.Drawing.Point(247, 99);
            this.TxtCosto.Name = "TxtCosto";
            this.TxtCosto.Size = new System.Drawing.Size(150, 20);
            this.TxtCosto.TabIndex = 21;
            // 
            // TxtMarca
            // 
            this.TxtMarca.Location = new System.Drawing.Point(247, 73);
            this.TxtMarca.Name = "TxtMarca";
            this.TxtMarca.Size = new System.Drawing.Size(150, 20);
            this.TxtMarca.TabIndex = 20;
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Location = new System.Drawing.Point(247, 47);
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(150, 20);
            this.TxtDescripcion.TabIndex = 19;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(247, 21);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(150, 20);
            this.TxtNombre.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(158, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Proveedor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(161, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Costo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Marca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Descripcion:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nombre:";
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.Image = global::Proyecto_Budget.Properties.Resources._1497137621_circle_edit_search_thin;
            this.btnBuscarProducto.Location = new System.Drawing.Point(539, 32);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(110, 100);
            this.btnBuscarProducto.TabIndex = 36;
            this.ttBuscar.SetToolTip(this.btnBuscarProducto, "Buscar producto existente");
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // btnEditarProducto
            // 
            this.btnEditarProducto.Image = global::Proyecto_Budget.Properties.Resources._1496729902_circle_edit_line;
            this.btnEditarProducto.Location = new System.Drawing.Point(655, 32);
            this.btnEditarProducto.Name = "btnEditarProducto";
            this.btnEditarProducto.Size = new System.Drawing.Size(110, 100);
            this.btnEditarProducto.TabIndex = 35;
            this.ttModificar.SetToolTip(this.btnEditarProducto, "Modificar producto seleccionado");
            this.btnEditarProducto.UseVisualStyleBackColor = true;
            this.btnEditarProducto.Click += new System.EventHandler(this.btnEditarProducto_Click);
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.Image = global::Proyecto_Budget.Properties.Resources._1496729761_flat_style_circle_delete_trash;
            this.btnEliminarProducto.Location = new System.Drawing.Point(771, 32);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(110, 100);
            this.btnEliminarProducto.TabIndex = 34;
            this.ttEliminar.SetToolTip(this.btnEliminarProducto, "Eliminar producto");
            this.btnEliminarProducto.UseVisualStyleBackColor = true;
            this.btnEliminarProducto.Click += new System.EventHandler(this.btnEliminarProducto_Click);
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Image = global::Proyecto_Budget.Properties.Resources._1496729731_flat_style_circle_add;
            this.btnAgregarProducto.Location = new System.Drawing.Point(423, 32);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(110, 100);
            this.btnAgregarProducto.TabIndex = 33;
            this.ttAgregar.SetToolTip(this.btnAgregarProducto, "Agregar nuevo producto");
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // ttModificar
            // 
            this.ttModificar.IsBalloon = true;
            // 
            // ttAgregar
            // 
            this.ttAgregar.IsBalloon = true;
            // 
            // ttBuscar
            // 
            this.ttBuscar.IsBalloon = true;
            // 
            // ttEliminar
            // 
            this.ttEliminar.IsBalloon = true;
            // 
            // FrmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(896, 376);
            this.Controls.Add(this.btnBuscarProducto);
            this.Controls.Add(this.btnEditarProducto);
            this.Controls.Add(this.btnEliminarProducto);
            this.Controls.Add(this.btnAgregarProducto);
            this.Controls.Add(this.TxtProveedor);
            this.Controls.Add(this.TxtCosto);
            this.Controls.Add(this.TxtMarca);
            this.Controls.Add(this.TxtDescripcion);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvProductos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmProductos";
            this.Text = "Administración de Productos";
            this.Load += new System.EventHandler(this.FrmProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TxtProveedor;
        private System.Windows.Forms.TextBox TxtCosto;
        private System.Windows.Forms.TextBox TxtMarca;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.Button btnEditarProducto;
        private System.Windows.Forms.Button btnEliminarProducto;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.ToolTip ttModificar;
        private System.Windows.Forms.ToolTip ttAgregar;
        private System.Windows.Forms.ToolTip ttBuscar;
        private System.Windows.Forms.ToolTip ttEliminar;
    }
}