﻿namespace PryLacamoireInicioSesionEnable
{
    partial class FrmBienvenida
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
            this.CmdCancelar = new System.Windows.Forms.Button();
            this.LblBienvenido = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CmdCancelar
            // 
            this.CmdCancelar.Location = new System.Drawing.Point(331, 250);
            this.CmdCancelar.Name = "CmdCancelar";
            this.CmdCancelar.Size = new System.Drawing.Size(75, 23);
            this.CmdCancelar.TabIndex = 9;
            this.CmdCancelar.Text = "Cancelar";
            this.CmdCancelar.UseVisualStyleBackColor = true;
            this.CmdCancelar.Click += new System.EventHandler(this.CmdAceptar_Click);
            // 
            // LblBienvenido
            // 
            this.LblBienvenido.AutoSize = true;
            this.LblBienvenido.Location = new System.Drawing.Point(320, 102);
            this.LblBienvenido.Name = "LblBienvenido";
            this.LblBienvenido.Size = new System.Drawing.Size(111, 13);
            this.LblBienvenido.TabIndex = 10;
            this.LblBienvenido.Text = "Bienvenido al Sistema";
            // 
            // FrmBienvenida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblBienvenido);
            this.Controls.Add(this.CmdCancelar);
            this.Name = "FrmBienvenida";
            this.Text = "FrmBienvenida";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdCancelar;
        private System.Windows.Forms.Label LblBienvenido;
    }
}