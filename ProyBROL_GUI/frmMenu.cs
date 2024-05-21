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
            }
            else if (permiso == 2)
            {
                btnHorarios.Visible = true;
                btnRegAsist.Visible = true;
            }
            else if (permiso == 1)
            {
                btnRegAsist.Visible = true;
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
    }
}
