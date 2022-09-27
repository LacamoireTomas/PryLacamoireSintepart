using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryLacamoireInicioSesionEnable
{
    public partial class FrmLogIn : Form
    {
        public FrmLogIn()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Lbl_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {
            if (TxtPassword.Text != "")
                LstModulo.Enabled = true;
            else
            {

                LstModulo.Enabled = false;
            }

        }

        private void TxtUsuario_TextChanged(object sender, EventArgs e)
        {
            if (TxtUsuario.Text != "")
            {
                TxtPassword.Enabled = true;
            }
            else
            {
                TxtPassword.Enabled = false;
            }






        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {



        }

        private void CmdCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int intentos = 0;
        private void CmdAceptar_Click(object sender, EventArgs e)
        {
            //Adam
            if (TxtUsuario.Text == ("Adm") &&
                TxtPassword.Text == ("@1a") &&
                LstModulo.Text == "ADM" || LstModulo.Text == "VTA" || LstModulo.Text == "COM")

            {
                this.Hide();   // oculta este formualrio
                FrmBienvenida f = new FrmBienvenida(); // crea el FrmBienvenida
                f.Text = TxtUsuario.Text;// asigna el texto de título
                f.ShowDialog(); ; // visualiza y ejecuta el FrmBienvenida
                this.Show(); // Muestra el nuevo formulario



            }
            else
            {

                //John
                if (TxtUsuario.Text == ("John") &&
                TxtPassword.Text == ("*2b") &&
                LstModulo.Text == "SIST")

                {
                    this.Hide();   // oculta este formualrio
                    FrmBienvenida f = new FrmBienvenida(); // crea el FrmBienvenida
                    f.Text = TxtUsuario.Text;// asigna el texto de título
                    f.ShowDialog(); ; // visualiza y ejecuta el FrmBienvenida
                    this.Show(); // Muestra el nuevo formulario



                }
                //Ceci
                if (TxtUsuario.Text == ("Ceci") &&
                TxtPassword.Text == ("*@3c") &&
                LstModulo.Text == "ADM" || LstModulo.Text == "VTA")



                {
                    this.Hide();   // oculta este formualrio
                    FrmBienvenida f = new FrmBienvenida(); // crea el FrmBienvenida
                    f.Text = TxtUsuario.Text;// asigna el texto de título
                    f.ShowDialog(); ; // visualiza y ejecuta el FrmBienvenida
                    this.Show(); // Muestra el nuevo formulario
                }
                //Gooood
                if (TxtUsuario.Text == ("God") &&
                TxtPassword.Text == ("@#4d") &&
                LstModulo.Text == "SIST" || LstModulo.Text == "ADM" || LstModulo.Text == "VTA" || LstModulo.Text == "COM")


                {
                    this.Hide();   // oculta este formualrio
                    FrmBienvenida f = new FrmBienvenida(); // crea el FrmBienvenida
                    f.Text = TxtUsuario.Text;// asigna el texto de título
                    f.ShowDialog(); ; // visualiza y ejecuta el FrmBienvenida
                    this.Show(); // Muestra el nuevo formulario
                }
                else
                {
                    MessageBox.Show("Datos incorrectos. Acceso Denegado.");
                    intentos++; // incrementa el contador de intentos fallidos
                    if (intentos == 2) // si se falla 2 veces cierra el formulario
                    {
                        MessageBox.Show("Usted excedió la cantidad de intentos permitida");
                        this.Close();
                    }




                }







            }
        }






    }
}
