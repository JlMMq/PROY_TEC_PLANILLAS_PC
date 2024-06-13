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

namespace ProyBROL_GUI
{
    public partial class UsuarioModificar : Form
    {
        LoginOuBE _currentUser;
        UserSystemBE _trans;
        LoginBL _login = new LoginBL();
   
        public UsuarioModificar(LoginOuBE curr, UserSystemBE userTrans)
        {
            InitializeComponent();
            _currentUser = curr;
            _trans = userTrans;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            UpdateUserStatePerm req = new UpdateUserStatePerm();

            req.codUser = _trans.codUser;
            req.permiso = Convert.ToInt32(cboPermisos.SelectedValue);
            req.estado = chcActivo.Checked ? 1 : 0;

            if (_login.ActualizarEstadoUser(req))
            {
                MessageBox.Show("Se actualizo el usuario correctamente.");
                this.Close();
            }
            else
            {
                MessageBox.Show("No se pudo actualizar el usuario.");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UsuarioModificar_Load(object sender, EventArgs e)
        {
            txtCodUser.Text = _trans.codUser.ToString();
            txtCorreo.Text = _trans.correoUser == null ? String.Empty : _trans.correoUser.ToString();
            txtapenom.Text = (_trans.str_apellidos == null ? String.Empty : _trans.str_apellidos.ToString())
                                    + (_trans.str_nombres == null ? String.Empty : ", " + _trans.str_nombres.ToString());
            List<cboPermisosItem> lstPermisos = new List<cboPermisosItem>();

            cboPermisosItem perm1 = new cboPermisosItem(1, "EMPLEADO");
            cboPermisosItem perm2 = new cboPermisosItem(2, "SUPERVISOR");
            cboPermisosItem perm3 = new cboPermisosItem(3, "ADMINISTRADOR");

            lstPermisos.Add(perm1);
            lstPermisos.Add(perm2);
            lstPermisos.Add(perm3);

            cboPermisos.DisplayMember = "descripcion";
            cboPermisos.ValueMember = "permiso";

            cboPermisos.DataSource = lstPermisos;

            cboPermisos.SelectedIndex = _trans.permisoUser - 1;

            if (_trans.fec_Reg == null)
            {
                dtpFecIngreso.Visible = false;
            }
            else
            {
                dtpFecIngreso.Value = _trans.fec_Reg ?? DateTime.Now;
                dtpFecIngreso.Visible = true;
            }
            
             chcActivo.Checked = _trans.estdUser == 1 ? true : false;

        }
        private class cboPermisosItem
        {
            public int permiso { get; set; }
            public string descripcion { get; set; }

            public cboPermisosItem(int permiso, string descripcion)
            {
                this.permiso = permiso;
                this.descripcion = descripcion;
            }
        }

    }
}
