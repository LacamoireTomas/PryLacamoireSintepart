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
    public partial class FrmBienvenida : Form
    {
        public FrmBienvenida()
        {
            InitializeComponent();
        }

        private void CmdAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
//