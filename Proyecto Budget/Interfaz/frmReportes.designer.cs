namespace Proyecto_Budget.Interfaz
{
    partial class frmReportes
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnExportar = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.BtnReporteCompra = new System.Windows.Forms.Button();
            this.BtnReporteFactura = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 159);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(418, 272);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // BtnExportar
            // 
            this.BtnExportar.Image = global::Proyecto_Budget.Properties.Resources._1496307046_file_text;
            this.BtnExportar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnExportar.Location = new System.Drawing.Point(331, 442);
            this.BtnExportar.Name = "BtnExportar";
            this.BtnExportar.Size = new System.Drawing.Size(99, 93);
            this.BtnExportar.TabIndex = 1;
            this.BtnExportar.Text = "Exportar reporte";
            this.BtnExportar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.BtnExportar, "Generar archivo de excel");
            this.BtnExportar.UseVisualStyleBackColor = true;
            this.BtnExportar.Click += new System.EventHandler(this.BtnExportar_Click);
            // 
            // BtnReporteCompra
            // 
            this.BtnReporteCompra.Image = global::Proyecto_Budget.Properties.Resources._1497137621_circle_edit_search_thin;
            this.BtnReporteCompra.Location = new System.Drawing.Point(12, 15);
            this.BtnReporteCompra.Name = "BtnReporteCompra";
            this.BtnReporteCompra.Size = new System.Drawing.Size(97, 119);
            this.BtnReporteCompra.TabIndex = 2;
            this.BtnReporteCompra.Text = "Reporte de compras";
            this.BtnReporteCompra.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnReporteCompra.UseVisualStyleBackColor = true;
            this.BtnReporteCompra.Click += new System.EventHandler(this.BtnReporteCompra_Click);
            // 
            // BtnReporteFactura
            // 
            this.BtnReporteFactura.Image = global::Proyecto_Budget.Properties.Resources._1497137621_circle_edit_search_thin;
            this.BtnReporteFactura.Location = new System.Drawing.Point(125, 15);
            this.BtnReporteFactura.Name = "BtnReporteFactura";
            this.BtnReporteFactura.Size = new System.Drawing.Size(97, 119);
            this.BtnReporteFactura.TabIndex = 3;
            this.BtnReporteFactura.Text = "Reporte de facturas";
            this.BtnReporteFactura.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnReporteFactura.UseVisualStyleBackColor = true;
            this.BtnReporteFactura.Click += new System.EventHandler(this.BtnReporteFactura_Click);
            // 
            // frmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(448, 547);
            this.Controls.Add(this.BtnReporteFactura);
            this.Controls.Add(this.BtnReporteCompra);
            this.Controls.Add(this.BtnExportar);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmReportes";
            this.Text = "Reportes de sistema";
            this.Load += new System.EventHandler(this.frmReportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnExportar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button BtnReporteCompra;
        private System.Windows.Forms.Button BtnReporteFactura;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}