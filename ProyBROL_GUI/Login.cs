using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyBROL_GUI
{
    public partial class Login : Form
    {
        int intentos = 0;
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }

        private void imgExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void LimiteIntentos()
        {
            if (intentos == 3)
            {
                MessageBox.Show("Lo sentimos, ha sobrepaso el numero maximo de intentos",
                    "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }
    }
}
