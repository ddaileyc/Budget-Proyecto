﻿namespace Proyecto_Budget
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnConta = new System.Windows.Forms.Button();
            this.btnCompras = new System.Windows.Forms.Button();
            this.btnPresup = new System.Windows.Forms.Button();
            this.btnAdmon = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnReportes);
            this.panel1.Controls.Add(this.btnConta);
            this.panel1.Controls.Add(this.btnCompras);
            this.panel1.Controls.Add(this.btnPresup);
            this.panel1.Controls.Add(this.btnAdmon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1176, 90);
            this.panel1.TabIndex = 0;
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
            this.btnReportes.Size = new System.Drawing.Size(131, 90);
            this.btnReportes.TabIndex = 4;
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
            this.btnConta.Size = new System.Drawing.Size(131, 90);
            this.btnConta.TabIndex = 3;
            this.btnConta.Text = "Contabilidad";
            this.btnConta.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConta.UseVisualStyleBackColor = true;
            // 
            // btnCompras
            // 
            this.btnCompras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCompras.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCompras.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompras.Image = global::Proyecto_Budget.Properties.Resources._1496303860_money;
            this.btnCompras.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCompras.Location = new System.Drawing.Point(262, 0);
            this.btnCompras.Name = "btnCompras";
            this.btnCompras.Size = new System.Drawing.Size(131, 90);
            this.btnCompras.TabIndex = 2;
            this.btnCompras.Text = "Compras";
            this.btnCompras.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCompras.UseVisualStyleBackColor = true;
            // 
            // btnPresup
            // 
            this.btnPresup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPresup.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPresup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPresup.Image = global::Proyecto_Budget.Properties.Resources._1496303818_f080;
            this.btnPresup.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPresup.Location = new System.Drawing.Point(131, 0);
            this.btnPresup.Name = "btnPresup";
            this.btnPresup.Size = new System.Drawing.Size(131, 90);
            this.btnPresup.TabIndex = 1;
            this.btnPresup.Text = "Presupuestos";
            this.btnPresup.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPresup.UseVisualStyleBackColor = true;
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
            this.btnAdmon.Size = new System.Drawing.Size(131, 90);
            this.btnAdmon.TabIndex = 0;
            this.btnAdmon.Text = "Administración";
            this.btnAdmon.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdmon.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Image = global::Proyecto_Budget.Properties.Resources._1496303883_f08b;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLogout.Location = new System.Drawing.Point(1045, 0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(131, 90);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Salir";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1176, 643);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmPrincipal";
            this.Text = "BUDGET - Sistema de Control de Presupuestos";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnConta;
        private System.Windows.Forms.Button btnCompras;
        private System.Windows.Forms.Button btnPresup;
        private System.Windows.Forms.Button btnAdmon;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnLogout;
    }
}

