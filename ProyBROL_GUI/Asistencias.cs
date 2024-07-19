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
    public partial class Asistencias : Form
    {
        DiarioBL _diarioBL = new DiarioBL();
        EmpleadoBL _empleadoBL = new EmpleadoBL();

        List<DiarioView> vista = new List<DiarioView>();
        List<DiarioView> preVista = new List<DiarioView>();

        EmpleadoBE objEmpleado = new EmpleadoBE();
        LoginOuBE _currentUser;
        public Asistencias(LoginOuBE currentUser)
        {
            InitializeComponent();
            _currentUser = currentUser;

        }

        private void Asistencias_Load(object sender, EventArgs e)
        {
            dtpFecInicio.MaxDate = DateTime.Now;
            dtpFecFin.MaxDate = DateTime.Now;
            dtpFecFin.MinDate = dtpFecInicio.Value;

            if (int.TryParse(_currentUser.nomUser, out _))
            {
                objEmpleado = _empleadoBL.ConsultarEmpleado(Convert.ToInt32(_currentUser.nomUser.Trim()));
            }

            preVista = _diarioBL.ListarDiario();

            vista = preVista.Where(d => d.empleado == objEmpleado.codEmpleado).ToList();
            dtgDiario.DataSource = vista;

            if (_currentUser.permiso == 3 || _currentUser.permiso == 2)
            {
                lblEmpleado.Visible = true;
                txtCodEmpleado.Visible = true;
                chkAdmin.Visible = true;
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DateTime fechaInicio = dtpFecInicio.Value.Date;
            DateTime fechaFin = dtpFecFin.Value;
            if (!chkAdmin.Checked)
            {
                dtgDiario.Columns[2].Visible = false;
                dtgDiario.Columns[3].Visible = false;
                dtgDiario.Columns[4].Visible = false;
                dtgDiario.Columns[5].Visible = false;

                vista = preVista.Where(d => d.empleado == objEmpleado.codEmpleado
                                             && d.fecha >= fechaInicio
                                             && d.fecha <= fechaFin).ToList();
                dtgDiario.DataSource = vista;
            }
            else
            {
                dtgDiario.Columns[2].Visible = true;
                dtgDiario.Columns[3].Visible = true;
                dtgDiario.Columns[4].Visible = true;
                dtgDiario.Columns[5].Visible = true;


                if (txtCodEmpleado.Text.Trim() == String.Empty)
                {
                    vista = preVista;
                    dtgDiario.DataSource = vista;
                }
                else
                {
                    int cod = Convert.ToInt32(txtCodEmpleado.Text.Trim());
                    vista = preVista.Where(d => d.empleado == cod
                                             && d.fecha >= fechaInicio
                                             && d.fecha <= fechaFin).ToList();
                    dtgDiario.DataSource = vista;
                }
            }
        }

        private void dtpFecInicio_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                dtpFecFin.MinDate = dtpFecInicio.Value;
            }
            catch (Exception ex)
            {

            }
        }

        private void dtgDiario_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            string val = (dtgDiario.Rows[e.RowIndex].Cells[13].Value).ToString();

            if (val == "TARDE" || val == "FALTO")
            {
                dtgDiario.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightCoral;

            }
            else if (val == "PUNTUAL")
            {
                dtgDiario.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGreen;

            }
            else if (val == "VACACION" || val == "PERMISO")
            {
                dtgDiario.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Gold;
            }
        }

        private void chkAdmin_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkAdmin.Checked)
            {
                dtgDiario.Columns[2].Visible = false;
                dtgDiario.Columns[3].Visible = false;
                dtgDiario.Columns[4].Visible = false;
                dtgDiario.Columns[5].Visible = false;
            }
            else
            {
                dtgDiario.Columns[2].Visible = true;
                dtgDiario.Columns[3].Visible = true;
                dtgDiario.Columns[4].Visible = true;
                dtgDiario.Columns[5].Visible = true;
            }
        }

        private void txtCodEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
