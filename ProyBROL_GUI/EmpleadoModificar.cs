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
    public partial class EmpleadoModificar : Form
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
        public int codEmpleado;
        public EmpleadoModificar(LoginOuBE currentUser, int codEmpleado)
        {
            InitializeComponent();
            _currentUser = currentUser;
            this.codEmpleado = codEmpleado;
            lblCodigo.Text = codEmpleado.ToString();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Deseas actualizar el empleado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
                    EmpleadoActuBE objEmpleadoActuBE = new EmpleadoActuBE();
                    objEmpleadoActuBE.codEmpleado = Convert.ToInt32(codEmpleado);
                    objEmpleadoActuBE.tipoDoc = cmbTipoDoc.SelectedValue.ToString();
                    objEmpleadoActuBE.numroDoc = txtNumDoc.Text;
                    objEmpleadoActuBE.apellidos = txtApelld.Text;
                    objEmpleadoActuBE.nombres = txtNom.Text;
                    objEmpleadoActuBE.fecNacimiento = dtpFecNac.Value;
                    objEmpleadoActuBE.genero = rdbMasculino.Checked ? "M" : "F";
                    objEmpleadoActuBE.correo = txtCorr.Text;
                    objEmpleadoActuBE.direccion = txtDirec.Text;
                    if (txtTelf.Text == "")
                    {
                        objEmpleadoActuBE.telefono = 0;
                    }
                    else
                    {
                        objEmpleadoActuBE.telefono = Convert.ToInt32(txtTelf.Text);
                    }
                    objEmpleadoActuBE.fecIngreso = dtpFecIngreso.Value;
                    objEmpleadoActuBE.codCargo = Convert.ToInt16(cmbCargo.SelectedValue);
                    objEmpleadoActuBE.codArea = Convert.ToInt16(cmbArea.SelectedValue);
                    objEmpleadoActuBE.codSede = Convert.ToInt16(cmbSede.SelectedValue);
                    objEmpleadoActuBE.codHorario = Convert.ToInt16(cmbHorar.SelectedValue);


                    if (imgFoto.Image == null)
                    {
                        string basePath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
                        string fotosTempPath = Path.Combine(basePath, "FotosTemp\\");
                        imgFoto.Image = Image.FromFile(fotosTempPath + "noimage.jpg");

                        System.IO.MemoryStream memoryStream = new System.IO.MemoryStream();
                        imgFoto.Image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                        objEmpleadoActuBE.foto = memoryStream.GetBuffer();
                    }
                    else
                    {
                        System.IO.MemoryStream memoryStream = new System.IO.MemoryStream();
                        imgFoto.Image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                        objEmpleadoActuBE.foto = memoryStream.GetBuffer();
                    }

                    objEmpleadoActuBE.usu_UltMod = _currentUser.nomUser;
                    objEmpleadoActuBE.estado = 1;

                    if (objEmpleadoBL.ActualizarEmpleado(objEmpleadoActuBE))
                    {
                        MessageBox.Show("Se ingreso correctamente el empleado.",
                            "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo ingresar el empleado.",
                            "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                this.Close();
            }
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

        private void EmpleadoModificar_Load(object sender, EventArgs e)
        {
            objEmpleadoBE = new EmpleadoBE();
            objEmpleadoBE = objEmpleadoBL.ConsultarEmpleado(Convert.ToInt32(codEmpleado));

            List<AreaBE> areas = objAreaBL.ListarArea();
            cmbArea.DataSource = areas;
            cmbArea.DisplayMember = "nomArea";
            cmbArea.ValueMember = "codArea";
            cmbArea.SelectedValue = objEmpleadoBE.codArea;
           
            List<CargoBE> cargos = objCargoBL.ListarCargo();
            cmbCargo.DataSource = cargos;
            cmbCargo.DisplayMember = "nomCargo";
            cmbCargo.ValueMember = "codCargo";
            cmbCargo.SelectedValue = objEmpleadoBE.codCargo;

           
            List<SedeBE> sedes = objSedeBL.ListarSede();
            cmbSede.DataSource = sedes;
            cmbSede.DisplayMember = "nomSede";
            cmbSede.ValueMember = "codSede";
            cmbSede.SelectedValue = objEmpleadoBE.codSede;

            List<DocumentoBE> documentos = objDocumentoBL.listarDocumentos();
            cmbTipoDoc.DataSource = documentos;
       
            cmbTipoDoc.DisplayMember = "descrLarga";
            cmbTipoDoc.ValueMember = "codDoc";
            cmbTipoDoc.SelectedValue = objEmpleadoBE.tipoDoc;

            if (objEmpleadoBE.genero == "F")
            {
                rdbFemenino.Checked = true;
                rdbMasculino.Checked = false;
            }
            else
            {
                rdbMasculino.Checked = true;
                rdbFemenino.Checked = false;
            }
            List<HorarioBE> horarios = objHorarioBL.listarHorarios();
            cmbHorar.DataSource = horarios;
          
            cmbHorar.DisplayMember = "desHorario";
            cmbHorar.ValueMember = "codHorario";
            cmbHorar.SelectedValue = objEmpleadoBE.codHorario;

            txtNumDoc.Text = objEmpleadoBE.numroDoc.ToString();
            txtApelld.Text = objEmpleadoBE.apellidos.ToString();
            txtNom.Text = objEmpleadoBE.nombres.ToString();
            txtCorr.Text = objEmpleadoBE.correo.ToString();
            txtDirec.Text = objEmpleadoBE.direccion.ToString();
            txtTelf.Text = objEmpleadoBE.telefono.ToString();

            dtpFecNac.Value = objEmpleadoBE.fecNacimiento;
            dtpFecIngreso.Value = objEmpleadoBE.fecIngreso;
            byte[] img = objEmpleadoBE.foto;
            if (img != null && img.Length > 0)
            {
                System.IO.MemoryStream memoryStream = new System.IO.MemoryStream(img);
                imgFoto.Image = Image.FromStream(memoryStream);
            }
            else
            {
                string basePath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
                string fotosTempPath = Path.Combine(basePath, "FotosTemp\\");
                imgFoto.Image = Image.FromFile(fotosTempPath + "noimage.jpg");
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
    }
}
