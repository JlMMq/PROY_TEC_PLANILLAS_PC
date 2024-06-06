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
        private int permiso;
        Empleados formEmpleado;
        Usuarios formUsuarios;
        UsuariosEmp formUsuariosEmp;

        public frmMenu(int permiso)
        {
            InitializeComponent();
            this.permiso = permiso;
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            if (permiso == 3)
            {
                btnEmpleados.Visible = true;
                btnHorarios.Visible = true;
                btnRegAsist.Visible = true;
                btnUsers.Visible = true;
                btnSolicitudes.Visible = true;  
            }
            else if (permiso == 2)
            {
                btnHorarios.Visible = true;
                btnRegAsist.Visible = true;
                btnUsers.Visible = true;
                btnSolicitudes.Visible = true;
            }
            else if (permiso == 1)
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
                formEmpleado = new Empleados("admin");
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
            if (permiso == 3)
            {
                if (formUsuarios == null)
                {
                    formUsuarios = new Usuarios(permiso);
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
                    formUsuariosEmp = new UsuariosEmp();
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
