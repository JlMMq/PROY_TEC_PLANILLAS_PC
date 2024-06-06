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
    public partial class LoginCredentials : Form
    {
        UsuarioModificar formMod;
        public LoginCredentials()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            if (formMod == null)
            {
                formMod = new UsuarioModificar();
                formMod.FormClosed += new FormClosedEventHandler(EstaCerradoCredentials);
                formMod.ShowDialog();
            }
            else
            {
                formMod.BringToFront();
            }
        }

        void EstaCerradoCredentials(object sender, EventArgs e)
        {
            formMod = null;
        }
    }
}
