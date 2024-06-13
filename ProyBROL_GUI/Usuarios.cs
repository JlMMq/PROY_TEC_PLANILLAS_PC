using ProyBROL_BE;
using ProyBROL_BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyBROL_GUI
{
    public partial class Usuarios : Form
    {
        LoginOuBE _currentUser;
        UsuariosEmp formUsuariosEmp;
        LoginCredentials loginCredentials;

        LoginBL _login = new LoginBL();

        List<UserSystemBE> lstUser = new List<UserSystemBE>();
        List<UserSystemViewBE> viewl = new List<UserSystemViewBE>();

        UserSystemBE userSend = new UserSystemBE();

        public Usuarios(LoginOuBE currentUser)
        {
            _currentUser = currentUser;
            InitializeComponent();
        }

        private void btnGestionPers_Click(object sender, EventArgs e)
        {
            if (formUsuariosEmp == null)
            {
                formUsuariosEmp = new UsuariosEmp(_currentUser);
                formUsuariosEmp.FormClosed += new FormClosedEventHandler(EstaCerradoUsuarioEmp);
                formUsuariosEmp.Show();
            }
            else
            {
                formUsuariosEmp.BringToFront();
            }
        }
        void EstaCerradoUsuarioEmp(object sender, EventArgs e)
        {
            formUsuariosEmp = null;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (loginCredentials == null)
            {
                loginCredentials = new LoginCredentials(_currentUser,userSend);
                loginCredentials.FormClosed += new FormClosedEventHandler(EstaCerradoCredentials);
                loginCredentials.FormClosed += CloseEventLoginCredentials;
                loginCredentials.ShowDialog();
                
            }
            else
            {
                loginCredentials.BringToFront();
            }
        }

        private void CloseEventLoginCredentials(object sender, EventArgs e)
        {
            cargarVista();
        }

        void EstaCerradoCredentials(object sender, EventArgs e)
        {
            loginCredentials = null;
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            cargarVista();
        }

        private void cargarVista()
        {
            viewl = new List<UserSystemViewBE>();

            lstUser = _login.ListarUserSystem();
            foreach (UserSystemBE user in lstUser)
            {
                UserSystemViewBE addView = new UserSystemViewBE();
                addView.codUser = user.codUser;
                addView.nomUser = user.nomUser;

                if (user.correoUser == null) addView.correoUser = String.Empty;
                else addView.correoUser = user.correoUser;

                addView.permisoUser = user.permisoUser;

                if (user.str_apellidos == null) addView.str_apellidos = String.Empty;
                else addView.str_apellidos = user.str_apellidos;

                if (user.str_nombres == null) addView.str_nombres = String.Empty;
                else addView.str_nombres = user.str_nombres;

                addView.fec_Reg = user.fec_Reg;

                if (user.estdUser == 1)
                {
                    addView.estdUserView = "ACTIVO";
                }
                else
                {
                    addView.estdUserView = "INACTIVO";
                }

                viewl.Add(addView);
            }
            dtgUsers.DataSource = viewl;
        }

        private void txtFiltUser_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var userfilt = viewl.Where(e => e.nomUser.ToString().Contains(txtFiltUser.Text.Trim())).ToList();
                dtgUsers.DataSource = userfilt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void txtFiltApellido_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var userfilt = viewl.Where(e => e.str_apellidos.ToString().Contains(txtFiltApellido.Text.ToUpper())).ToList();
                dtgUsers.DataSource = userfilt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void txtFiltNombre_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var userfilt = viewl.Where(e => e.str_nombres.ToString().Contains(txtFiltNombre.Text.ToUpper())).ToList();
                dtgUsers.DataSource = userfilt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void dtgUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dtgUsers.Rows.Count > 0)
            {
                userSend.codUser = int.Parse(dtgUsers.SelectedCells[0].Value.ToString());
                var selectUser = lstUser.FirstOrDefault(u => u.codUser == userSend.codUser);

                userSend.nomUser = selectUser.nomUser;
                userSend.correoUser = selectUser.correoUser;
                userSend.permisoUser = selectUser.permisoUser;
                userSend.str_nombres = selectUser.str_nombres;
                userSend.str_apellidos = selectUser.str_apellidos;
                userSend.fec_Reg = selectUser.fec_Reg;
                userSend.estdUser = selectUser.estdUser;

                txtCodUser.Text = userSend.nomUser.ToString();
                txtCorreo.Text = userSend.correoUser == null ? String.Empty : userSend.correoUser.ToString();
                txtnomap.Text =  (userSend.str_apellidos == null ? String.Empty : userSend.str_apellidos.ToString())
                                    + (userSend.str_nombres == null ? String.Empty : ", " + userSend.str_nombres.ToString()) ;
                string permText = String.Empty;
                
                if(userSend.permisoUser == 3)
                {
                    permText = "ADMINISTRADOR";
                }
                else if(userSend.permisoUser == 2)
                {
                    permText = "SUPERVISOR";
                }
                else if(userSend.permisoUser == 1)
                {
                    permText = "EMPLEADO";
                }
                else
                {
                    permText = "NO REGISTRADO";
                }

                if (userSend.fec_Reg == null)
                {
                    dtpFecIngreso.Visible = false;
                }
                else
                {
                    dtpFecIngreso.Value = userSend.fec_Reg ?? DateTime.Now;
                    dtpFecIngreso.Visible = true;
                }
                txtperm.Text = permText;
                
             
                if(userSend.estdUser == 1)
                {
                    lblEstado.Text = "ACTIVO";
                    lblEstado.ForeColor = Color.YellowGreen;
                }
                else
                {
                    lblEstado.Text = "INACTIVO";
                    lblEstado.ForeColor = Color.Red;
                }
                
            }
        }
    }
}


