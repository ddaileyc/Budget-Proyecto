﻿namespace Proyecto_Budget.Interfaz
{
    partial class frmBudgetUser
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
            this.pnlToolbar = new System.Windows.Forms.Panel();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnConta = new System.Windows.Forms.Button();
            this.btnPresup = new System.Windows.Forms.Button();
            this.gbTipoCambio = new System.Windows.Forms.GroupBox();
            this.btnIR = new System.Windows.Forms.Button();
            this.lblVenta = new System.Windows.Forms.Label();
            this.lblCompra = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnCompras = new System.Windows.Forms.Button();
            this.btnAdminUsuario = new System.Windows.Forms.Button();
            this.pnlToolbar.SuspendLayout();
            this.gbTipoCambio.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlToolbar
            // 
            this.pnlToolbar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlToolbar.Controls.Add(this.btnReportes);
            this.pnlToolbar.Controls.Add(this.btnConta);
            this.pnlToolbar.Controls.Add(this.btnPresup);
            this.pnlToolbar.Controls.Add(this.gbTipoCambio);
            this.pnlToolbar.Controls.Add(this.btnLogout);
            this.pnlToolbar.Controls.Add(this.btnCompras);
            this.pnlToolbar.Controls.Add(this.btnAdminUsuario);
            this.pnlToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToolbar.Location = new System.Drawing.Point(0, 0);
            this.pnlToolbar.Name = "pnlToolbar";
            this.pnlToolbar.Size = new System.Drawing.Size(1242, 94);
            this.pnlToolbar.TabIndex = 1;
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
            this.btnReportes.TabIndex = 14;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReportes.UseVisualStyleBackColor = true;
            // 
            // btnConta
            // 
            this.btnConta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConta.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConta.Image = global::Proyecto_Budget.Properties.Resources._1496303887_calculator;
            this.btnConta.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnConta.Location = new System.Drawing.Point(393, 0);
            this.btnConta.Name = "btnConta";
            this.btnConta.Size = new System.Drawing.Size(131, 94);
            this.btnConta.TabIndex = 13;
            this.btnConta.Text = "Contabilidad";
            this.btnConta.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConta.UseVisualStyleBackColor = true;
            // 
            // btnPresup
            // 
            this.btnPresup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPresup.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPresup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPresup.Image = global::Proyecto_Budget.Properties.Resources.if_f155_213240;
            this.btnPresup.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPresup.Location = new System.Drawing.Point(262, 0);
            this.btnPresup.Name = "btnPresup";
            this.btnPresup.Size = new System.Drawing.Size(131, 94);
            this.btnPresup.TabIndex = 11;
            this.btnPresup.Text = "Presupuestos";
            this.btnPresup.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPresup.UseVisualStyleBackColor = true;
            this.btnPresup.Click += new System.EventHandler(this.btnPresup_Click);
            // 
            // gbTipoCambio
            // 
            this.gbTipoCambio.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gbTipoCambio.Controls.Add(this.btnIR);
            this.gbTipoCambio.Controls.Add(this.lblVenta);
            this.gbTipoCambio.Controls.Add(this.lblCompra);
            this.gbTipoCambio.Controls.Add(this.label1);
            this.gbTipoCambio.Controls.Add(this.label);
            this.gbTipoCambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTipoCambio.Location = new System.Drawing.Point(661, 3);
            this.gbTipoCambio.Name = "gbTipoCambio";
            this.gbTipoCambio.Size = new System.Drawing.Size(378, 88);
            this.gbTipoCambio.TabIndex = 10;
            this.gbTipoCambio.TabStop = false;
            this.gbTipoCambio.Text = "Tipo de cambio BCCR";
            // 
            // btnIR
            // 
            this.btnIR.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnIR.Location = new System.Drawing.Point(329, 57);
            this.btnIR.Name = "btnIR";
            this.btnIR.Size = new System.Drawing.Size(43, 25);
            this.btnIR.TabIndex = 13;
            this.btnIR.Text = "?";
            this.btnIR.UseVisualStyleBackColor = true;
            this.btnIR.Click += new System.EventHandler(this.btnIR_Click);
            // 
            // lblVenta
            // 
            this.lblVenta.AutoSize = true;
            this.lblVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVenta.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.lblVenta.Location = new System.Drawing.Point(263, 39);
            this.lblVenta.Name = "lblVenta";
            this.lblVenta.Size = new System.Drawing.Size(24, 17);
            this.lblVenta.TabIndex = 12;
            this.lblVenta.Text = "₡ ";
            // 
            // lblCompra
            // 
            this.lblCompra.AutoSize = true;
            this.lblCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompra.ForeColor = System.Drawing.Color.Tomato;
            this.lblCompra.Location = new System.Drawing.Point(93, 39);
            this.lblCompra.Name = "lblCompra";
            this.lblCompra.Size = new System.Drawing.Size(24, 17);
            this.lblCompra.TabIndex = 11;
            this.lblCompra.Text = "₡ ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.label1.Location = new System.Drawing.Point(211, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Venta: ";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.Tomato;
            this.label.Location = new System.Drawing.Point(30, 39);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(73, 17);
            this.label.TabIndex = 6;
            this.label.Text = "Compra: ";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Image = global::Proyecto_Budget.Properties.Resources._1496303883_f08b;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLogout.Location = new System.Drawing.Point(1111, 0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(131, 94);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Salir";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnCompras
            // 
            this.btnCompras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCompras.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCompras.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompras.Image = global::Proyecto_Budget.Properties.Resources._1496305349_shopping_basket;
            this.btnCompras.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCompras.Location = new System.Drawing.Point(131, 0);
            this.btnCompras.Name = "btnCompras";
            this.btnCompras.Size = new System.Drawing.Size(131, 94);
            this.btnCompras.TabIndex = 2;
            this.btnCompras.Text = "Compras";
            this.btnCompras.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCompras.UseVisualStyleBackColor = true;
            this.btnCompras.Click += new System.EventHandler(this.btnCompras_Click);
            // 
            // btnAdminUsuario
            // 
            this.btnAdminUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdminUsuario.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAdminUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminUsuario.Image = global::Proyecto_Budget.Properties.Resources._1496303895_f0c0;
            this.btnAdminUsuario.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdminUsuario.Location = new System.Drawing.Point(0, 0);
            this.btnAdminUsuario.Name = "btnAdminUsuario";
            this.btnAdminUsuario.Size = new System.Drawing.Size(131, 94);
            this.btnAdminUsuario.TabIndex = 0;
            this.btnAdminUsuario.Text = "Usuario";
            this.btnAdminUsuario.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdminUsuario.UseVisualStyleBackColor = true;
            this.btnAdminUsuario.Click += new System.EventHandler(this.btnAdminUsuario_Click);
            // 
            // frmBudgetUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1242, 804);
            this.Controls.Add(this.pnlToolbar);
            this.IsMdiContainer = true;
            this.Name = "frmBudgetUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BUDGET | Sistema de Control de Presupuestos | Usuario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlToolbar.ResumeLayout(false);
            this.gbTipoCambio.ResumeLayout(false);
            this.gbTipoCambio.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlToolbar;
        private System.Windows.Forms.GroupBox gbTipoCambio;
        private System.Windows.Forms.Label lblVenta;
        private System.Windows.Forms.Label lblCompra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnCompras;
        private System.Windows.Forms.Button btnAdminUsuario;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnConta;
        private System.Windows.Forms.Button btnPresup;
        private System.Windows.Forms.Button btnIR;
    }
}