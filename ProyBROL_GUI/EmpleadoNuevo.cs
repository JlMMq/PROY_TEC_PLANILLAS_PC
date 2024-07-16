using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ProyBROL_BE;
using ProyBROL_BL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyBROL_GUI
{
    public partial class EmpleadoNuevo : Form
    {
        EmpleadoBE objEmpleadoBE;
        EmpleadoBL objEmpleadoBL = new EmpleadoBL();

        CargoBE objCargoBE = new CargoBE();
        CargoBL objCargoBL = new CargoBL();

        SedeBE objSedeBE = new SedeBE();
        SedeBL objSedeBL = new SedeBL();

        AreaBE objAreaBE = new AreaBE();
        AreaBL objAreaBL = new AreaBL();

        DocumentoBE objDocumentoBE = new DocumentoBE();
        DocumentoBL objDocumentoBL = new DocumentoBL();

        HorarioBL objHorarioBL = new HorarioBL();
        LoginOuBE _currentUser;

        PagoBL objPagoBL = new PagoBL();

        public EmpleadoNuevo(LoginOuBE currentUser)
        {
            InitializeComponent();
            _currentUser = currentUser;
        }

        private void EmpleadoNuevo_Load(object sender, EventArgs e)
        {
            cmbArea.DataSource = objAreaBL.ListarArea();
            cmbArea.SelectedIndex = 0;
            cmbArea.DisplayMember = "nomArea";
            cmbArea.ValueMember = "codArea";


            cmbCargo.DataSource = objCargoBL.ListarCargo();
            cmbCargo.SelectedIndex = 0;
            cmbCargo.DisplayMember = "nomCargo";
            cmbCargo.ValueMember = "codCargo";

            cmbSede.DataSource = objSedeBL.ListarSede();
            cmbSede.SelectedIndex = 0;
            cmbSede.DisplayMember = "nomSede";
            cmbSede.ValueMember = "codSede";

            cmbTipoDoc.DataSource = objDocumentoBL.listarDocumentos();
            cmbTipoDoc.SelectedIndex = 0;
            cmbTipoDoc.DisplayMember = "descrLarga";
            cmbTipoDoc.ValueMember = "codDoc";

            cmbHorar.DataSource = objHorarioBL.listarHorarios();
            cmbHorar.SelectedIndex = 0;
            cmbHorar.DisplayMember = "desHorario";
            cmbHorar.ValueMember = "codHorario";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtNumDoc.Text) ||
                string.IsNullOrWhiteSpace(txtNom.Text) ||
                string.IsNullOrWhiteSpace(txtApelld.Text) ||
                string.IsNullOrWhiteSpace(txtCorr.Text)
                )
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                EmpleadoInsertBE objEmpleadoInsertBE = new EmpleadoInsertBE();
                objEmpleadoInsertBE.tipoDoc = cmbTipoDoc.SelectedValue.ToString();
                objEmpleadoInsertBE.numroDoc = txtNumDoc.Text;
                objEmpleadoInsertBE.apellidos = txtApelld.Text;
                objEmpleadoInsertBE.nombres = txtNom.Text;
                objEmpleadoInsertBE.fecNacimiento = dtpFecNac.Value;
                objEmpleadoInsertBE.genero = rdbMasculino.Checked ? "M" : "F";
                objEmpleadoInsertBE.correo = txtCorr.Text;
                objEmpleadoInsertBE.direccion = txtDirec.Text;
                if (txtTelf.Text == "")
                {
                    objEmpleadoInsertBE.telefono = 0;
                }
                else
                {
                    objEmpleadoInsertBE.telefono = Convert.ToInt32(txtTelf.Text);
                }
                objEmpleadoInsertBE.fecIngreso = dtpFecIngreso.Value;
                objEmpleadoInsertBE.codCargo = Convert.ToInt32(cmbCargo.SelectedValue);
                objEmpleadoInsertBE.codArea = Convert.ToInt32(cmbArea.SelectedValue);
                objEmpleadoInsertBE.codSede = Convert.ToInt32(cmbSede.SelectedValue);
                objEmpleadoInsertBE.codHorario = Convert.ToInt32(cmbHorar.SelectedValue);


                if (imgFoto.Image == null)
                {
                    string basePath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
                    string fotosTempPath = Path.Combine(basePath, "FotosTemp\\");
                    imgFoto.Image = Image.FromFile(fotosTempPath + "noimage.jpg");

                    System.IO.MemoryStream memoryStream = new System.IO.MemoryStream();
                    imgFoto.Image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                    objEmpleadoInsertBE.foto = memoryStream.GetBuffer();
                }
                else
                {
                    System.IO.MemoryStream memoryStream = new System.IO.MemoryStream();
                    imgFoto.Image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                    objEmpleadoInsertBE.foto = memoryStream.GetBuffer();
                }

                objEmpleadoInsertBE.usu_Reg = _currentUser.nomUser;
                objEmpleadoInsertBE.estado = 1;

                EmpleadoInsertResponse resInsert = objEmpleadoBL.InsertarEmpleado(objEmpleadoInsertBE);
                if (resInsert.codigo != 0 && resInsert.codigo != null)
                {
                    SueldoInsert_Req sueldoReq = new SueldoInsert_Req();

                    sueldoReq.sueldo = Convert.ToDouble(txtSueldo.Text.ToString());
                    if (chckEssalud.Checked)
                    {
                        sueldoReq.flag_essalud = 1;
                    }
                    else
                    {
                        sueldoReq.flag_essalud = 0;
                    }

                    if (rbAfp.Checked)
                    {
                        sueldoReq.flag_afp = 1;
                        sueldoReq.flag_onp = 0;
                    }
                    else
                    {
                        sueldoReq.flag_afp = 0;
                        sueldoReq.flag_onp = 1;
                    }

                    sueldoReq.empleado = resInsert.codigo;
                    sueldoReq.usuario = _currentUser.nomUser;

                    PagoGeneric_Response resPago = objPagoBL.InsertarSueldo(sueldoReq);
                    if (resPago != null && resPago.CODIGO != 0) {
                        MessageBox.Show("Se ingreso correctamente el empleado.",
                        "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo ingresar el sueldo del empleado.",
                        "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    
                }
                else
                {
                    MessageBox.Show("No se pudo ingresar el empleado.",
                        "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                this.Close();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIngrFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            DialogResult rs = ofd.ShowDialog();
            if (rs == DialogResult.OK)
            {
                imgFoto.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void txtNumDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTelf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSueldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
