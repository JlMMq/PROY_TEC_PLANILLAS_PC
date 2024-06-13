using ProyBROL_BE;
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
    public partial class frmMenu : Form
    {
        Empleados formEmpleado;
        Usuarios formUsuarios;
        UsuariosEmp formUsuariosEmp;

        private LoginOuBE _currentUser;

        public frmMenu(LoginOuBE userLogin)
        {
            InitializeComponent();
            this._currentUser = userLogin;
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            if (_currentUser.permiso == 3)
            {
                btnEmpleados.Visible = true;
                btnHorarios.Visible = true;
                btnRegAsist.Visible = true;
                btnUsers.Visible = true;
                btnSolicitudes.Visible = true;  
            }
            else if (_currentUser.permiso == 2)
            {
                btnHorarios.Visible = true;
                btnRegAsist.Visible = true;
                btnUsers.Visible = true;
                btnSolicitudes.Visible = true;
            }
            else if (_currentUser.permiso == 1)
            {
                btnRegAsist.Visible = true;
                btnUsers.Visible = true;
                btnSolicitudes.Visible = true;
            }
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            if (formEmpleado == null)
            {
                formEmpleado = new Empleados(_currentUser);
                formEmpleado.MdiParent = this;
                formEmpleado.FormClosed += new FormClosedEventHandler(EstaCerradoEmpleado);
                formEmpleado.Show();
            }
            else
            {
                formEmpleado.BringToFront();
            }
        }
        void EstaCerradoEmpleado(object sender, EventArgs e)
        {
            formEmpleado = null;
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            if (_currentUser.permiso == 3)
            {
                if (formUsuarios == null)
                {
                    formUsuarios = new Usuarios(_currentUser);
                    formUsuarios.MdiParent = this;
                    formUsuarios.FormClosed += new FormClosedEventHandler(EstaCerradoUsuario);
                    formUsuarios.Show();
                }
                else
                {
                    formUsuarios.BringToFront();
                }
            }
            else
            {
                if (formUsuariosEmp == null)
                {
                    formUsuariosEmp = new UsuariosEmp(_currentUser);
                    formUsuariosEmp.MdiParent = this;
                    formUsuariosEmp.FormClosed += new FormClosedEventHandler(EstaCerradoUsuarioEmp);
                    formUsuariosEmp.Show();
                }
                else
                {
                    formUsuariosEmp.BringToFront();
                }
            }
        }
        void EstaCerradoUsuario(object sender, EventArgs e)
        {
            formUsuarios = null;
        }
        void EstaCerradoUsuarioEmp(object sender, EventArgs e)
        {
            formUsuariosEmp = null;
        }
    }
}
