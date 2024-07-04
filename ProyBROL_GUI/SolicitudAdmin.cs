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
    public partial class SolicitudAdmin : Form
    {
        LoginOuBE _currentUser;
        int _currentEmpleado = 0;
        SolicitudBL _soliBL = new SolicitudBL();
        List<SolicitudViewBE> listViewEnviados = new List<SolicitudViewBE>();
        List<SolicitudViewBE> listViewRecibidos = new List<SolicitudViewBE>();

        SolicitudArchivo frm;
        int codDocSelect = 0;
        int tipoSolSelect = 0;
        SolicitudViewBE SolSelect = new SolicitudViewBE();
        public SolicitudAdmin(LoginOuBE currentUser, int codigoEmpleado)
        {
            InitializeComponent();
            this._currentUser = currentUser;
            this._currentEmpleado = codigoEmpleado;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SolicitudAdmin_Load(object sender, EventArgs e)
        {
            SolicitudViewRequestBE soli = new SolicitudViewRequestBE
            {
                codSolicitante = _currentEmpleado,
                codSupervisor = 0
            };
            listViewEnviados = _soliBL.ListarSolicitudView(soli);
            dtgSolicEnviadas.DataSource = null;
            dtgSolicEnviadas.DataSource = listViewEnviados;

            soli.codSolicitante = 0;
            soli.codSupervisor = _currentEmpleado;

            listViewRecibidos = _soliBL.ListarSolicitudView(soli);
            dtgSolicRecibidas.DataSource = null;
            dtgSolicRecibidas.DataSource = listViewRecibidos;
        }

        private void dtgSolicEnviadas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tipoSolSelect = 1;
            if (dtgSolicEnviadas.Rows.Count > 0)
            {
                codDocSelect = int.Parse(dtgSolicEnviadas.SelectedCells[0].Value.ToString());
                var selectRow = listViewEnviados.FirstOrDefault(e => e.codSolicitud == codDocSelect);
                SolSelect = selectRow;

                lblCodigo.Text = codDocSelect.ToString();
                lblSolicitud.Text = selectRow.desc_solic;
                lblAsunto.Text = selectRow.desc_asunto;
                lblEstado.Text = selectRow.desc_estado;
                if (selectRow.estado == 0)
                {
                    lblEstado.ForeColor = Color.Gold;
                }
                else if (selectRow.estado == 1)
                {
                    lblEstado.ForeColor = Color.Green;
                }
                else if (selectRow.estado == 2)
                {
                    lblEstado.ForeColor = Color.Brown;
                }
                else if (selectRow.estado == 3)
                {
                    lblEstado.ForeColor = Color.Red;
                }
                else
                {
                    lblEstado.ForeColor = Color.Black;
                }


                lblPersona.Text = "Destinatario";

                txtApeNomFind.Text = selectRow.nomape;
                txtCodFind.Text = selectRow.codSupervisor.ToString();
                byte[] img = selectRow.foto;
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

        }

        private void dtgSolicRecibidas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tipoSolSelect = 2;
            if (dtgSolicRecibidas.Rows.Count > 0)
            {
                codDocSelect = int.Parse(dtgSolicRecibidas.SelectedCells[0].Value.ToString());
                var selectRow = listViewRecibidos.FirstOrDefault(e => e.codSolicitud == codDocSelect);

                SolSelect = selectRow;

                lblCodigo.Text = codDocSelect.ToString();
                lblSolicitud.Text = selectRow.desc_solic;
                lblAsunto.Text = selectRow.desc_asunto;
                lblEstado.Text = selectRow.desc_estado;
                if (selectRow.estado == 0)
                {
                    lblEstado.ForeColor = Color.Gold;
                }
                else if (selectRow.estado == 1)
                {
                    lblEstado.ForeColor = Color.Green;
                }
                else if (selectRow.estado == 2)
                {
                    lblEstado.ForeColor = Color.Brown;
                }
                else if (selectRow.estado == 3)
                {
                    lblEstado.ForeColor = Color.Red;
                }
                else
                {
                    lblEstado.ForeColor = Color.Black;
                }
                lblPersona.Text = "Solicitante";

                txtApeNomFind.Text = selectRow.nomape;
                txtCodFind.Text = selectRow.codSolicitante.ToString();
                byte[] img = selectRow.foto;
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
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            if (codDocSelect != 0 && codDocSelect != null)
            {

                if (frm == null)
                {
                    frm = new SolicitudArchivo(_currentUser, tipoSolSelect, SolSelect);
                    frm.FormClosed += new FormClosedEventHandler(EstaCerradoSolicitudArchivo);
                    frm.Show();
                }
                else
                {
                    frm.BringToFront();
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una solicitud.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void EstaCerradoSolicitudArchivo(object sender, EventArgs e)
        {
            frm = null;

            SolicitudViewRequestBE soli = new SolicitudViewRequestBE
            {
                codSolicitante = _currentEmpleado,
                codSupervisor = 0
            };
            listViewEnviados = _soliBL.ListarSolicitudView(soli);
            
            dtgSolicEnviadas.DataSource = listViewEnviados;

            soli.codSolicitante = 0;
            soli.codSupervisor = _currentEmpleado;

            listViewRecibidos = _soliBL.ListarSolicitudView(soli);
            
            dtgSolicRecibidas.DataSource = listViewRecibidos;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            SolicitudViewRequestBE soli = new SolicitudViewRequestBE
            {
                codSolicitante = _currentEmpleado,
                codSupervisor = 0
            };
            listViewEnviados = _soliBL.ListarSolicitudView(soli);
            
            dtgSolicEnviadas.DataSource = listViewEnviados;

            soli.codSolicitante = 0;
            soli.codSupervisor = _currentEmpleado;

            listViewRecibidos = _soliBL.ListarSolicitudView(soli);
            
            dtgSolicRecibidas.DataSource = listViewRecibidos;
        }
    }
}
