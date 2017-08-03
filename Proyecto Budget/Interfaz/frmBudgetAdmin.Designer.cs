namespace Proyecto_Budget
{
    partial class frmPrincipalAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipalAdmin));
            this.pnlToolbar = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnProv = new System.Windows.Forms.Button();
            this.btnProd = new System.Windows.Forms.Button();
            this.btnPresup = new System.Windows.Forms.Button();
            this.btnAdmon = new System.Windows.Forms.Button();
            this.pnlToolbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlToolbar
            // 
            this.pnlToolbar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlToolbar.Controls.Add(this.btnLogout);
            this.pnlToolbar.Controls.Add(this.btnReportes);
            this.pnlToolbar.Controls.Add(this.btnProv);
            this.pnlToolbar.Controls.Add(this.btnProd);
            this.pnlToolbar.Controls.Add(this.btnPresup);
            this.pnlToolbar.Controls.Add(this.btnAdmon);
            this.pnlToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToolbar.Location = new System.Drawing.Point(0, 0);
            this.pnlToolbar.Name = "pnlToolbar";
            this.pnlToolbar.Size = new System.Drawing.Size(1176, 94);
            this.pnlToolbar.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Image = global::Proyecto_Budget.Properties.Resources._1496303883_f08b;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLogout.Location = new System.Drawing.Point(1045, 0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(131, 94);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Salir";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReportes.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnReportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.Image = global::Proyecto_Budget.Properties.Resources._1496307039_line_chart;
            this.btnReportes.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReportes.Location = new System.Drawing.Point(524, 0);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(131, 94);
            this.btnReportes.TabIndex = 4;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // btnProv
            // 
            this.btnProv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProv.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnProv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProv.Image = global::Proyecto_Budget.Properties.Resources._1496303902_truck;
            this.btnProv.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnProv.Location = new System.Drawing.Point(393, 0);
            this.btnProv.Name = "btnProv";
            this.btnProv.Size = new System.Drawing.Size(131, 94);
            this.btnProv.TabIndex = 3;
            this.btnProv.Text = "Proveedores";
            this.btnProv.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProv.UseVisualStyleBackColor = true;
            this.btnProv.Click += new System.EventHandler(this.btnProv_Click);
            // 
            // btnProd
            // 
            this.btnProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProd.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProd.Image = global::Proyecto_Budget.Properties.Resources._1496305349_shopping_basket;
            this.btnProd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnProd.Location = new System.Drawing.Point(262, 0);
            this.btnProd.Name = "btnProd";
            this.btnProd.Size = new System.Drawing.Size(131, 94);
            this.btnProd.TabIndex = 2;
            this.btnProd.Text = "Productos";
            this.btnProd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProd.UseVisualStyleBackColor = true;
            this.btnProd.Click += new System.EventHandler(this.btnProd_Click);
            // 
            // btnPresup
            // 
            this.btnPresup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPresup.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPresup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPresup.Image = global::Proyecto_Budget.Properties.Resources.if_f155_213240;
            this.btnPresup.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPresup.Location = new System.Drawing.Point(131, 0);
            this.btnPresup.Name = "btnPresup";
            this.btnPresup.Size = new System.Drawing.Size(131, 94);
            this.btnPresup.TabIndex = 1;
            this.btnPresup.Text = "Presupuestos";
            this.btnPresup.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPresup.UseVisualStyleBackColor = true;
            this.btnPresup.Click += new System.EventHandler(this.btnPresup_Click);
            // 
            // btnAdmon
            // 
            this.btnAdmon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdmon.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAdmon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmon.Image = global::Proyecto_Budget.Properties.Resources._1496303895_f0c0;
            this.btnAdmon.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdmon.Location = new System.Drawing.Point(0, 0);
            this.btnAdmon.Name = "btnAdmon";
            this.btnAdmon.Size = new System.Drawing.Size(131, 94);
            this.btnAdmon.TabIndex = 0;
            this.btnAdmon.Text = "Usuarios";
            this.btnAdmon.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdmon.UseVisualStyleBackColor = true;
            this.btnAdmon.Click += new System.EventHandler(this.btnAdmon_Click);
            // 
            // frmPrincipalAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1176, 643);
            this.Controls.Add(this.pnlToolbar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmPrincipalAdmin";
            this.Text = "BUDGET | Sistema de Control de Presupuestos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.pnlToolbar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlToolbar;
        private System.Windows.Forms.Button btnProv;
        private System.Windows.Forms.Button btnProd;
        private System.Windows.Forms.Button btnPresup;
        private System.Windows.Forms.Button btnAdmon;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnLogout;
    }
}

