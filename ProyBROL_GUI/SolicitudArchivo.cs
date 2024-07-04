using PdfiumViewer;
using ProyBROL_BE;
using ProyBROL_BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace ProyBROL_GUI
{
    public partial class SolicitudArchivo : Form
    {
        int _tipoSolSelect = 0;
        LoginOuBE _currentUser;
        SolicitudBL _soliBL = new SolicitudBL();
        SolicitudViewBE _select = new SolicitudViewBE();

        byte[] archivo;
        private PdfViewer pdfViewer;
        private MemoryStream pdfStream;

        GenericResponse msm = new GenericResponse();
        public SolicitudArchivo(LoginOuBE currentUser, int tipoSolSelect, SolicitudViewBE select)
        {
            InitializeComponent();
            this._tipoSolSelect = tipoSolSelect;
            this._currentUser = currentUser;
            this._select = select;

            pdfViewer = new PdfViewer();
            pdfViewer.Dock = DockStyle.Fill;
            pnlPdf.Controls.Add(pdfViewer);
        }

        private void SolicitudArchivo_Load(object sender, EventArgs e)
        {
            SolicitudArchivoRequestBE sol = new SolicitudArchivoRequestBE { codSolicitud = _select.codSolicitud };
            archivo = _soliBL.ConsultarArchivoSolicitud(sol).archivo;

            if (archivo != null && archivo.Length > 0)
            {

                pdfStream = new MemoryStream(archivo);
                pdfViewer.Document = PdfDocument.Load(pdfStream);
            }
            else
            {
                MessageBox.Show("No se pudo cargar el archivo PDF.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //ENVIADO
            if (_tipoSolSelect == 1)
            {
                lblCodigo.Text = _select.codSolicitud.ToString();
                lblSolicitud.Text = _select.desc_solic;
                lblAsunto.Text = _select.desc_asunto;
                lblEstado.Text = _select.desc_estado;
                if (_select.estado == 0)
                {
                    lblEstado.ForeColor = Color.Gold;
                }
                else if (_select.estado == 1)
                {
                    lblEstado.ForeColor = Color.Green;
                    btnAceptar.Enabled = false;
                    btnRechazar.Enabled = false;
                    btnAceptar.Visible = false;
                    btnRechazar.Visible = false;

                    lblMensaje.Visible = true;
                    lblMensaje.Text += " ACEPTADA"; 

                }
                else if (_select.estado == 2)
                {
                    lblEstado.ForeColor = Color.Brown;
                    btnAceptar.Enabled = false;
                    btnRechazar.Enabled = false;
                    btnAceptar.Visible = false;
                    btnRechazar.Visible = false;

                    lblMensaje.Visible = true;
                    lblMensaje.Text += " CADUCADA";
                }
                else if (_select.estado == 3)
                {
                    lblEstado.ForeColor = Color.Red;
                    btnAceptar.Enabled = false;
                    btnRechazar.Enabled = false;
                    btnAceptar.Visible = false;
                    btnRechazar.Visible = false;

                    lblMensaje.Visible = true;
                    lblMensaje.Text += " RECHAZADA";
                }
                else
                {
                    lblEstado.ForeColor = Color.Black;
                    btnAceptar.Enabled = false;
                    btnRechazar.Enabled = false;
                    btnAceptar.Visible = false;
                    btnRechazar.Visible = false;

                }


                lblPersona.Text = "Destinatario";

                txtApeNomFind.Text = _select.nomape;
                txtCodFind.Text = _select.codSupervisor.ToString();
                byte[] img = _select.foto;
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

                gbAcciones.Visible = false;
                gbAcciones.Enabled = false; 
            }
            else if (_tipoSolSelect == 2)
            {
                lblCodigo.Text = _select.codSolicitud.ToString();
                lblSolicitud.Text = _select.desc_solic;
                lblAsunto.Text = _select.desc_asunto;
                lblEstado.Text = _select.desc_estado;
                if (_select.estado == 0)
                {
                    lblEstado.ForeColor = Color.Gold;
                }
                else if (_select.estado == 1)
                {
                    lblEstado.ForeColor = Color.Green;
                    btnAceptar.Enabled = false;
                    btnRechazar.Enabled = false;
                    btnAceptar.Visible = false;
                    btnRechazar.Visible = false;

                    lblMensaje.Visible = true;
                    lblMensaje.Text += " ACEPTADA";

                }
                else if (_select.estado == 2)
                {
                    lblEstado.ForeColor = Color.Brown;
                    btnAceptar.Enabled = false;
                    btnRechazar.Enabled = false;
                    btnAceptar.Visible = false;
                    btnRechazar.Visible = false;

                    lblMensaje.Visible = true;
                    lblMensaje.Text += " CADUCADA";
                }
                else if (_select.estado == 3)
                {
                    lblEstado.ForeColor = Color.Red;
                    btnAceptar.Enabled = false;
                    btnRechazar.Enabled = false;
                    btnAceptar.Visible = false;
                    btnRechazar.Visible = false;

                    lblMensaje.Visible = true;
                    lblMensaje.Text += " RECHAZADA";
                }
                else
                {
                    lblEstado.ForeColor = Color.Black;
                    btnAceptar.Visible = false;
                    btnRechazar.Visible = false;
                }
                lblPersona.Text = "Solicitante";

                txtApeNomFind.Text = _select.nomape;
                txtCodFind.Text = _select.codSolicitante.ToString();
                byte[] img = _select.foto;
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
            }
            else
            {

            }

        }
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            pdfStream?.Dispose();
            base.OnFormClosed(e);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            SolicitudProcessBE soli = new SolicitudProcessBE
            {
                codSolicitud = _select.codSolicitud,
                estado = 1,
                usuario = _currentUser.nomUser
            };

            msm = _soliBL.ProcesarSolicitud(soli);

            MessageBox.Show(msm.MENSAJE, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnRechazar_Click(object sender, EventArgs e)
        {
            SolicitudProcessBE soli = new SolicitudProcessBE
            {
                codSolicitud = _select.codSolicitud,
                estado = 3,
                usuario = _currentUser.nomUser
            };
            msm = _soliBL.ProcesarSolicitud(soli);
            MessageBox.Show(msm.MENSAJE, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
