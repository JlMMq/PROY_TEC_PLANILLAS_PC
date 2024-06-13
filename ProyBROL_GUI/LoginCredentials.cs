using ProyBROL_BE;
using ProyBROL_BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyBROL_GUI
{
    public partial class LoginCredentials : Form
    {
        UsuarioModificar formMod;
        LoginOuBE _currentUser;
        LoginBL _login = new LoginBL();
        UserSystemBE _trans;
        public LoginCredentials(LoginOuBE curr, UserSystemBE userTrans)
        {
            InitializeComponent();
            _currentUser = curr;
            _trans = userTrans;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            if (txtPass.Text.Trim() != String.Empty)
            {
                LoginInBE log = new LoginInBE
                {
                    nomUser = _currentUser.nomUser,
                    passUser = txtPass.Text.Trim()
                };

                LoginOuBE res = _login.ValidarUserSystem(log);

                if (!res.estadoTrans)
                {
                    lblResponse.Text = "La contraseña no es correcta.";
                    lblResponse.ForeColor = Color.Red;
                }
                else
                {
                    if (formMod == null)
                    {
                        formMod = new UsuarioModificar(_currentUser,_trans);
                        formMod.FormClosed += new FormClosedEventHandler(EstaCerradoCredentials);
                        formMod.ShowDialog();
                        this.Close();                    }
                    else
                    {
                        formMod.BringToFront();
                    }
                }
            }
            else
            {
                lblResponse.Text = "Ingrese la clave en el recuadro.";
                lblResponse.ForeColor = Color.Red;
            }

        }

        private void CloseEventformMod(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
        void EstaCerradoCredentials(object sender, EventArgs e)
        {
            formMod = null;
        }

        private void LoginCredentials_Load(object sender, EventArgs e)
        {

        }
    }
}
