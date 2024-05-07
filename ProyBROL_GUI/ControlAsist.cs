
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
    public partial class ControlAsist : Form
    {
        Login frmLogin;

        //EmpleadoBL objEmpleadoBL = new EmpleadoBL();
        EmpleadoBE objEmpleadoBE = new EmpleadoBE();

        DocumentoBE objDocumentoBE = new DocumentoBE();
        //DocumentoBL objDocumentoBL = new DocumentoBL();

        HorarioBE objHorarioBE = new HorarioBE();
        //HorarioBL objHorarioBL = new HorarioBL();

        MarcasBE objMarcasBE = new MarcasBE();
        //MarcasBL objMarcasBL = new MarcasBL();

        DiarioBE objDiarioBE = new DiarioBE();
        //DiarioBL objDiarioBL = new DiarioBL();

        public ControlAsist()
        {
            InitializeComponent();
        }

        private void dtTimer_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss");
            lblHoraDes.Text = DateTime.Now.ToLongDateString();
        }

        private void imgbtnLogin_Click(object sender, EventArgs e)
        {
            if (frmLogin == null)
            {
                frmLogin = new Login();
                frmLogin.FormClosed += Frm_Login_FormClosed;
                frmLogin.Show();
            }
            else
            {
                frmLogin.Activate();
            }
        }
        private void Frm_Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmLogin = null;
        }

        private void btnIngr_Click(object sender, EventArgs e)
        {

        }

        private void btnSalRefr_Click(object sender, EventArgs e)
        {

        }

        private void btnIngRefr_Click(object sender, EventArgs e)
        {

        }

        private void btnSald_Click(object sender, EventArgs e)
        {

        }
    }
}
