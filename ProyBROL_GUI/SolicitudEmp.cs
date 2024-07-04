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

using System.Text.Encodings;

using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.Globalization;
using Org.BouncyCastle.Tls;

namespace ProyBROL_GUI
{
    public partial class SolicitudEmp : Form
    {
        LoginOuBE _currentUser;
        LoginBL _login = new LoginBL();
        EmpleadoBL _empleadoBL = new EmpleadoBL();

        EmpleadoBE objEmpleado = new EmpleadoBE();
        List<EmpleadoLiteBE> listaEmpleados = new List<EmpleadoLiteBE>();
        EmpleadoLiteBE filter = new EmpleadoLiteBE();

        SolicitudInsertBE solicitud = new SolicitudInsertBE();
        SolicitudBL _solicitudBL = new SolicitudBL();

        SolicitudAdmin frmSoliAdmn;

        public SolicitudEmp(LoginOuBE currentUser)
        {
            InitializeComponent();
            _currentUser = currentUser;

            foreach (var groupBox in gbFormulario.Controls.OfType<GroupBox>())
            {
                foreach (var radioButton in groupBox.Controls.OfType<RadioButton>())
                {
                    radioButton.CheckedChanged += TripolaridadGroupRadioButton_CheckedChanged;
                }
            }
        }

        private void TripolaridadGroupRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            var selectedRadioButton = sender as RadioButton;

            if (selectedRadioButton != null && selectedRadioButton.Checked)
            {
                foreach (var groupBox in gbFormulario.Controls.OfType<GroupBox>())
                {
                    if (!groupBox.Controls.Contains(selectedRadioButton))
                    {
                        foreach (var radioButton in groupBox.Controls.OfType<RadioButton>())
                        {
                            radioButton.Checked = false;
                        }
                    }
                }
            }
        }

        private void SolicitudEmp_Load(object sender, EventArgs e)
        {
            listaEmpleados = _empleadoBL.ListarEmpleadosLite();

            if (int.TryParse(_currentUser.nomUser, out _))
            {
                objEmpleado = _empleadoBL.ConsultarEmpleado(Convert.ToInt32(_currentUser.nomUser.Trim()));
                txtApeNom.Text = objEmpleado.apellidos + ", " + objEmpleado.nombres;
                txtCodSolicitante.Text = objEmpleado.codEmpleado.ToString();
                txtDirec.Text = objEmpleado.direccion;
                txtTelf.Text = objEmpleado.telefono.ToString(); //esto debe cambiarse por un varchar

            }
            dtFechaIni.MinDate = DateTime.Now;
            dtFechaFin.MinDate = DateTime.Now;
        }

        private void txtBuscarJefe_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtBuscarJefe.Text.Trim() != String.Empty)
                {
                    filter = listaEmpleados.Where(e => e.apenom.ToString().Contains(txtBuscarJefe.Text.Trim().ToUpper())).FirstOrDefault();
                    if (filter != null)
                    {
                        byte[] img = filter.foto;
                        if (img != null && img.Length > 0)
                        {
                            System.IO.MemoryStream memoryStream = new System.IO.MemoryStream(img);
                            imgFoto.Image = System.Drawing.Image.FromStream(memoryStream);
                        }
                        else
                        {
                            string basePath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
                            string fotosTempPath = Path.Combine(basePath, "FotosTemp\\");
                            imgFoto.Image = System.Drawing.Image.FromFile(fotosTempPath + "noimage.jpg");
                        }
                        txtApeNomFind.Text = filter.apenom;
                        txtCodFind.Text = filter.codEmpleado.ToString();
                        txtArea.Text = filter.nomArea;
                        txtCargo.Text = filter.nomCargo;

                        solicitud.codSupervisor = filter.codEmpleado;
                    }
                    else
                    {
                        string basePath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
                        string fotosTempPath = Path.Combine(basePath, "FotosTemp\\");
                        imgFoto.Image = System.Drawing.Image.FromFile(fotosTempPath + "noimage.jpg");
                        txtApeNomFind.Text = string.Empty;
                        txtCodFind.Text = string.Empty;
                        txtCargo.Text = string.Empty;
                        txtArea.Text = string.Empty;

                    }
                }
                else
                {
                    string basePath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
                    string fotosTempPath = Path.Combine(basePath, "FotosTemp\\");
                    imgFoto.Image = System.Drawing.Image.FromFile(fotosTempPath + "noimage.jpg");
                    txtApeNomFind.Text = string.Empty;
                    txtCodFind.Text = string.Empty;
                    txtCargo.Text = string.Empty;
                    txtArea.Text = string.Empty;
                }

            }
            catch (Exception ex)
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (filter != null)
            {
                txtApeNomJefe.Text = filter.apenom;
            }
        }

        string text_solicitud = String.Empty;
        string text_asunto = String.Empty;
        private void btnModificar_Click(object sender, EventArgs e)
        {
            solicitud.codSolicitante = objEmpleado.codEmpleado;
            solicitud.usuario = _currentUser.nomUser;
            solicitud.descrip = String.Empty;
            solicitud.descrip = txtContent.Text;
            solicitud.fechaIni = dtFechaIni.Value;
            solicitud.fechaFin = dtFechaFin.Value;
            solicitud.horaSalida = dtpHoraSalida.Value;
            solicitud.horaEntrada = dtpHoraRetorn.Value;

            if (VerificarRadioButtons())
            {
                //Permiso
                if (rbPerParticular.Checked)
                {
                    solicitud.tipoSolic = 1;
                    solicitud.tipoAsunto = 1;
                    solicitud.asunto = "Particular";
                    text_solicitud = "PERMISO";
                    text_asunto = "Particular";
                }
                if (rbdPerComision.Checked)
                {
                    solicitud.tipoSolic = 1;
                    solicitud.tipoAsunto = 2;
                    solicitud.asunto = "Comision Oficial";
                    text_solicitud = "PERMISO";
                    text_asunto = "Comision Oficial";
                }
                if (rbPerMedica.Checked)
                {
                    solicitud.tipoSolic = 1;
                    solicitud.tipoAsunto = 3;
                    solicitud.asunto = "Cita Medica";
                    text_solicitud = "PERMISO";
                    text_asunto = "Cita Medica";
                }
                if (rbPerOtros.Checked)
                {
                    solicitud.tipoSolic = 1;
                    solicitud.tipoAsunto = 4;
                    solicitud.asunto = "Otros";
                    text_solicitud = "PERMISO";
                    text_asunto = "Otros";
                }

                //Licencia
                if (rbLicMatrimonio.Checked)
                {
                    solicitud.tipoSolic = 2;
                    solicitud.tipoAsunto = 1;
                    solicitud.asunto = "Matrimonio o Union de Hecho";
                    text_solicitud = "LICENCIA";
                    text_asunto = "Matrimonio o Union de Hecho";
                }
                if (rbLicCalamidad.Checked)
                {
                    solicitud.tipoSolic = 2;
                    solicitud.tipoAsunto = 2;
                    solicitud.asunto = "Calamidad Domestica";
                    text_solicitud = "LICENCIA";
                    text_asunto = "Calamidad Domestica";
                }
                if (rbLicMaternidad.Checked)
                {
                    solicitud.tipoSolic = 2;
                    solicitud.tipoAsunto = 3;
                    solicitud.asunto = "Maternidad y/o Paternidad";
                    text_solicitud = "LICENCIA";
                    text_asunto = "Maternidad y/o Paternidad";
                }
                if (rbLicFamiliar.Checked)
                {
                    solicitud.tipoSolic = 2;
                    solicitud.tipoAsunto = 4;
                    solicitud.asunto = "Cuidado de Familiar con discapacidad";
                    text_solicitud = "LICENCIA";
                    text_asunto = "Cuidado de Familiar con discapacidad";
                }
                if (rbLicNacido.Checked)
                {
                    solicitud.tipoSolic = 2;
                    solicitud.tipoAsunto = 5;
                    solicitud.asunto = "Cuidado del recien nacido";
                    text_solicitud = "LICENCIA";
                    text_asunto = "Cuidado del recien nacido";
                }

                //Vacaciones
                if (rbVacCompleta.Checked)
                {
                    solicitud.tipoSolic = 3;
                    solicitud.tipoAsunto = 1;
                    solicitud.asunto = "Completas";
                    text_solicitud = "VACACIONES";
                    text_asunto = "Completas";

                }
                if (rbVacParticionada.Checked)
                {
                    solicitud.tipoSolic = 3;
                    solicitud.tipoAsunto = 2;
                    solicitud.asunto = "Particionadas";
                    text_solicitud = "VACACIONES";
                    text_asunto = "Particionadas";
                }
                if (solicitud.codSolicitante != null && solicitud.codSolicitante != 0)
                {
                    if (solicitud.codSupervisor != null && solicitud.codSupervisor != 0)
                    {
                        CrearPDF();
                        GenericResponse msm = new GenericResponse();
                        msm = _solicitudBL.InsertarSolicitud(solicitud);

                        MessageBox.Show(msm.MENSAJE, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                    }
                    else
                    {
                        MessageBox.Show("Debe seleccionar al encargado o jefe en la seccion de busqueda.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("No se encontro al solicitante del documento.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            }
            else
            {
                MessageBox.Show("Debe seleccionar una opcion de las solicitudes.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private bool VerificarRadioButtons()
        {
            bool estado = false;
            foreach (var groupBox in gbFormulario.Controls.OfType<GroupBox>())
            {
                foreach (var radioButton in groupBox.Controls.OfType<RadioButton>())
                {
                    if (radioButton.Checked) return true;
                }
            }
            return estado;
        }
        private void CrearPDF()
        {
            try
            {
                Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
                CultureInfo culture = new CultureInfo("es-ES");


                string formattedDate = DateTime.Now.ToString("dddd, d 'de' MMMM 'de' yyyy", culture);

                SaveFileDialog savefile = new SaveFileDialog();
                savefile.FileName = DateTime.Now.ToString("ddMMyyyyHHmmss") + ".pdf";
                //savefile.ShowDialog();

                string htmlsend = Properties.Resources.plantsoli.ToString();
                htmlsend = htmlsend.Replace("@APENOM", txtApeNom.Text.ToString());
                htmlsend = htmlsend.Replace("@CODIGO", txtCodSolicitante.Text.ToString());
                htmlsend = htmlsend.Replace("@DOMICIL", txtDirec.Text.ToString());
                htmlsend = htmlsend.Replace("@CEL", txtTelf.Text.ToString());

                htmlsend = htmlsend.Replace("@SOLICITUD", text_solicitud);
                htmlsend = htmlsend.Replace("@SOLIASUNT", text_asunto);
                htmlsend = htmlsend.Replace("@INFOADIC", txtContent.Text.ToString());
                htmlsend = htmlsend.Replace("@FECHAINI", dtFechaIni.Text.ToString());
                htmlsend = htmlsend.Replace("@FECHAFIN", dtFechaFin.Text.ToString());
                htmlsend = htmlsend.Replace("@HORASAL", dtpHoraSalida.Text.ToString());
                htmlsend = htmlsend.Replace("@HORARET", dtpHoraRetorn.Text.ToString());
                htmlsend = htmlsend.Replace("@JEFE", txtApeNomJefe.Text.ToString());
                htmlsend = htmlsend.Replace("@FECHAACTUAL", formattedDate);

                if (savefile.ShowDialog() == DialogResult.OK)
                {
                    /*
                    string direccion = savefile.FileName.ToString();
                    using (FileStream strm = new FileStream(savefile.FileName, FileMode.Create))
                    {
                        Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);
                        PdfWriter writer = PdfWriter.GetInstance(pdfDoc, strm);
                        pdfDoc.Open();

                        pdfDoc.Add(new Phrase(""));
                        using (StringReader sr = new StringReader(htmlsend))
                        {
                            XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                        }
                        solicitud.archivo = File.ReadAllBytes(direccion);
                        pdfDoc.Close();

                        strm.Close();
                    }*/
                    using (MemoryStream memoryStream = new MemoryStream())
                    {
                        Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);
                        PdfWriter writer = PdfWriter.GetInstance(pdfDoc, memoryStream);
                        pdfDoc.Open();

                        pdfDoc.Add(new Phrase(""));
                        using (StringReader sr = new StringReader(htmlsend))
                        {
                            XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                        }

                        pdfDoc.Close();
                        writer.Close();

                        solicitud.archivo = memoryStream.ToArray();
                        File.WriteAllBytes(savefile.FileName, solicitud.archivo);
                    }
                }

            }
            catch (Exception ex)
            {

            }
        }

        private void rbVacCompleta_CheckedChanged(object sender, EventArgs e)
        {
            if (rbVacCompleta.Checked)
            {
                dtFechaFin.MinDate = dtFechaIni.Value.AddDays(30);
            }
            else
            {
                dtFechaFin.MinDate = DateTime.Now;
                dtFechaFin.MaxDate = DateTime.Now.AddDays(365);
            }
        }

        private void dtFechaFin_DataContextChanged(object sender, EventArgs e)
        {

        }

        private void dtFechaIni_DataContextChanged(object sender, EventArgs e)
        {

        }

        private void dtFechaIni_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbVacCompleta.Checked || rbVacParticionada.Checked)
                {
                    dtFechaFin.MinDate = DateTime.Now;
                    dtFechaFin.MaxDate = DateTime.Now.AddDays(365);
                    if (rbVacCompleta.Checked)
                    {
                        dtFechaFin.MinDate = dtFechaIni.Value.AddDays(30);
                    }
                    if (rbVacParticionada.Checked)
                    {
                        dtFechaFin.MinDate = dtFechaIni.Value.AddDays(7);
                        dtFechaFin.MaxDate = dtFechaIni.Value.AddDays(30);
                    }
                }
                else
                {
                    dtFechaFin.MinDate = DateTime.Now;
                    dtFechaFin.MaxDate = DateTime.Now.AddDays(365);
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void rbVacParticionada_CheckedChanged(object sender, EventArgs e)
        {
            if (rbVacParticionada.Checked)
            {
                dtFechaFin.MinDate = dtFechaIni.Value.AddDays(7);
                dtFechaFin.MaxDate = dtFechaIni.Value.AddDays(30);
            }
            else
            {
                dtFechaFin.MinDate = DateTime.Now;
                dtFechaFin.MaxDate = DateTime.Now.AddDays(365);
            }
        }

        private void btnVerificarSolicitudes_Click(object sender, EventArgs e)
        {
            if (objEmpleado.codEmpleado != 0 && objEmpleado.codEmpleado != null)
            {
                if (frmSoliAdmn == null)
                {
                    frmSoliAdmn = new SolicitudAdmin(_currentUser, objEmpleado.codEmpleado);
                    frmSoliAdmn.FormClosed += new FormClosedEventHandler(EstaCerradoSolicitudAdmin);
                    frmSoliAdmn.Show();
                }
                else
                {
                    frmSoliAdmn.BringToFront();
                }
            }
            else
            {
                MessageBox.Show("El usuario no posee codigo de identificacion.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        void EstaCerradoSolicitudAdmin(object sender, EventArgs e)
        {
            frmSoliAdmn = null;
        }
    }
}
