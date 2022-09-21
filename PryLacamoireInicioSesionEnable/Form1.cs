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
               
               LstModulo.Enabled= false;
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
    }
}
