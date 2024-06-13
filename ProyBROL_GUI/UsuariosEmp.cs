using ProyBROL_ADO;
using ProyBROL_BE;
using ProyBROL_BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyBROL_GUI
{
    public partial class UsuariosEmp : Form
    {
        LoginOuBE _currentUser;
        LoginBL _login = new LoginBL();
        public UsuariosEmp(LoginOuBE currentUser)
        {
            InitializeComponent();
            _currentUser = currentUser;
        }

        private void UsuariosEmp_Load(object sender, EventArgs e)
        {
            if (_currentUser.str_apellidos != null && _currentUser.str_nombres != null)
                lblBienven.Text = "Bienvenido " + _currentUser.str_apellidos + ", " + _currentUser.str_nombres + "!";
            else 
                lblBienven.Text = "Bienvenido " + _currentUser.nomUser+ "!";

            if (_currentUser.correoUser != null)
                txtCorreoIn.Text = _currentUser.correoUser.ToString();
            else
                txtCorreoIn.Text = "Ingrese un correo electronico.";
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if(txtCorreoNew.Text.Trim() != String.Empty )
            {
                UpdateMail req = new UpdateMail
                {
                    codUser = _currentUser.codUser,
                    correo = txtCorreoNew.Text.Trim()
                };

                if (_login.ActualizarCorreo(req)) {
                    lblCorreoStatus.Text = "Se realizaron los cambios correctamente.";
                    lblCorreoStatus.ForeColor = Color.Green;
                }
                else
                {
                    lblCorreoStatus.Text = "No se pudo actualizar el correo.";
                    lblCorreoStatus.ForeColor = Color.Red;
                }
            }

            if(txtOldPassword.Text.Trim() != String.Empty || txtNewPass1.Text.Trim() != String.Empty || txtNewPass2.Text.Trim() != String.Empty)
            {
                if (txtOldPassword.Text.Trim() == String.Empty || txtNewPass1.Text.Trim() == String.Empty || txtNewPass2.Text.Trim() == String.Empty)
                    lblPassStatus.Text = "Todos los campos tienen que ser completados.";
                    lblPassStatus.ForeColor = Color.Red;

                if (txtOldPassword.Text.Trim() != String.Empty && txtNewPass1.Text.Trim() != String.Empty && txtNewPass2.Text.Trim() != String.Empty)
                {
                    LoginInBE req = new LoginInBE
                    {
                        nomUser = _currentUser.nomUser,
                        passUser = txtOldPassword.Text.Trim()
                    };

                    LoginOuBE res = _login.ValidarUserSystem(req);
                    if (!res.estadoTrans)
                    {
                        lblPassStatus.Text = "La contraseña actual no es la correcta.";
                        lblPassStatus.ForeColor = Color.Red;
                    }
                    else
                    {
                       if(txtNewPass1.Text.Trim() == txtNewPass2.Text.Trim())
                        {
                            UpdatePassword reqp = new UpdatePassword {
                                codUser = _currentUser.codUser,
                                passUser = txtNewPass1.Text.Trim()
                            };

                            if (_login.ActualizarPassword(reqp))
                            {
                                lblPassStatus.Text = "Contraseña actualizada.";
                                lblPassStatus.ForeColor = Color.Green;
                            }
                            else
                            {
                                lblPassStatus.Text = "No se pudo cambiar la contraseña.";
                                lblPassStatus.ForeColor = Color.Red;
                            }
                        }
                        else
                        {
                            lblPassStatus.Text = "Los campos de la constraseña nueva no son iguales.";
                            lblPassStatus.ForeColor = Color.Red;
                        }
                    }

                }

            }
        }
    }
}
