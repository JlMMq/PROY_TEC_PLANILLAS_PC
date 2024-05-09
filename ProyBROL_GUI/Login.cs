using ProyBROL_ADO;
using ProyBROL_BE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyBROL_GUI
{
    public partial class Login : Form
    {
        int intentos = 0;
        frmMenu menu;
        LoginADO _login = new LoginADO();
        LoginOuBE res = new LoginOuBE();
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginInBE req = new LoginInBE();
            if (txtNomUser.Text.Trim() != "" & txtPassUser.Text.Trim() != "")
            {
                req.nomUser = txtNomUser.Text.Trim();
                req.passUser = txtPassUser.Text.Trim();

                res = _login.ValidarUserSystem(req);

                if (!res.estadoTrans)
                {
                    intentos += 1;
                    LimiteIntentos();
                    MessageBox.Show("Usuario o contraseña incorrectos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else 
                {
                    txtNomUser.Text = String.Empty;
                    txtPassUser.Text = String.Empty;
                    if (menu == null)
                    {
                        menu = new frmMenu(res.permiso);
                        menu.FormClosed += new FormClosedEventHandler(EstaCerradofrmMenu);
                        menu.Show();
                    }
                    else
                    {
                        menu.BringToFront();
                    }
                }
            }
            else
            {
                MessageBox.Show("El campo usuario y contraseña son obligatorios",
                    "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                intentos += 1;
                LimiteIntentos();
            }
        }
        void EstaCerradofrmMenu(object sender, EventArgs e)
        {
            menu = null;
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
