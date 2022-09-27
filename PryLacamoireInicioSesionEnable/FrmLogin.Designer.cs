namespace PryLacamoireInicioSesionEnable
{
    partial class FrmLogIn
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblIniciarSesion = new System.Windows.Forms.Label();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.LblPassword = new System.Windows.Forms.Label();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.LblModulo = new System.Windows.Forms.Label();
            this.LstModulo = new System.Windows.Forms.ComboBox();
            this.CmdAceptar = new System.Windows.Forms.Button();
            this.CmdCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblIniciarSesion
            // 
            this.LblIniciarSesion.AutoSize = true;
            this.LblIniciarSesion.Location = new System.Drawing.Point(305, 40);
            this.LblIniciarSesion.Name = "LblIniciarSesion";
            this.LblIniciarSesion.Size = new System.Drawing.Size(70, 13);
            this.LblIniciarSesion.TabIndex = 0;
            this.LblIniciarSesion.Text = "Iniciar Sesión";
            this.LblIniciarSesion.Click += new System.EventHandler(this.Lbl_Click);
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Location = new System.Drawing.Point(113, 107);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(43, 13);
            this.LblUsuario.TabIndex = 1;
            this.LblUsuario.Text = "Usuario";
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Location = new System.Drawing.Point(113, 158);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(61, 13);
            this.LblPassword.TabIndex = 2;
            this.LblPassword.Text = "Contraseña";
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Location = new System.Drawing.Point(275, 100);
            this.TxtUsuario.MaxLength = 10;
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(112, 20);
            this.TxtUsuario.TabIndex = 4;
            this.TxtUsuario.TextChanged += new System.EventHandler(this.TxtUsuario_TextChanged);
            // 
            // TxtPassword
            // 
            this.TxtPassword.Enabled = false;
            this.TxtPassword.Location = new System.Drawing.Point(275, 155);
            this.TxtPassword.MaxLength = 10;
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '#';
            this.TxtPassword.Size = new System.Drawing.Size(112, 20);
            this.TxtPassword.TabIndex = 5;
            this.TxtPassword.TextChanged += new System.EventHandler(this.TxtPassword_TextChanged);
            // 
            // LblModulo
            // 
            this.LblModulo.AutoSize = true;
            this.LblModulo.Location = new System.Drawing.Point(113, 213);
            this.LblModulo.Name = "LblModulo";
            this.LblModulo.Size = new System.Drawing.Size(42, 13);
            this.LblModulo.TabIndex = 6;
            this.LblModulo.Text = "Módulo";
            // 
            // LstModulo
            // 
            this.LstModulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LstModulo.Enabled = false;
            this.LstModulo.FormattingEnabled = true;
            this.LstModulo.Items.AddRange(new object[] {
            "ADM",
            "SIST",
            "COM",
            "VTA"});
            this.LstModulo.Location = new System.Drawing.Point(275, 213);
            this.LstModulo.Name = "LstModulo";
            this.LstModulo.Size = new System.Drawing.Size(112, 21);
            this.LstModulo.TabIndex = 7;
            this.LstModulo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // CmdAceptar
            // 
            this.CmdAceptar.Location = new System.Drawing.Point(532, 125);
            this.CmdAceptar.Name = "CmdAceptar";
            this.CmdAceptar.Size = new System.Drawing.Size(75, 23);
            this.CmdAceptar.TabIndex = 8;
            this.CmdAceptar.Text = "Aceptar";
            this.CmdAceptar.UseVisualStyleBackColor = true;
            this.CmdAceptar.Click += new System.EventHandler(this.CmdAceptar_Click);
            // 
            // CmdCancelar
            // 
            this.CmdCancelar.Location = new System.Drawing.Point(532, 179);
            this.CmdCancelar.Name = "CmdCancelar";
            this.CmdCancelar.Size = new System.Drawing.Size(75, 23);
            this.CmdCancelar.TabIndex = 9;
            this.CmdCancelar.Text = "Cancelar";
            this.CmdCancelar.UseVisualStyleBackColor = true;
            this.CmdCancelar.Click += new System.EventHandler(this.CmdCancelar_Click);
            // 
            // FrmLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CmdCancelar);
            this.Controls.Add(this.CmdAceptar);
            this.Controls.Add(this.LstModulo);
            this.Controls.Add(this.LblModulo);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtUsuario);
            this.Controls.Add(this.LblPassword);
            this.Controls.Add(this.LblUsuario);
            this.Controls.Add(this.LblIniciarSesion);
            this.Name = "FrmLogIn";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblIniciarSesion;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Label LblModulo;
        private System.Windows.Forms.ComboBox LstModulo;
        private System.Windows.Forms.Button CmdAceptar;
        private System.Windows.Forms.Button CmdCancelar;
    }
}

