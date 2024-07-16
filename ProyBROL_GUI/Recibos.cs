using iTextSharp.text.pdf;
using iTextSharp.text;
using iTextSharp.tool.xml;
using ProyBROL_BE;
using ProyBROL_BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyBROL_GUI
{
    public partial class Recibos : Form
    {
        PagoBL _pagoBL = new PagoBL();
        EmpleadoBL _empleadoBL = new EmpleadoBL();

        EmpleadoBE objEmpleado = new EmpleadoBE();
        LoginOuBE _currentUser;

        int codReciboSelect = 0;
        ReciboBE rowSelect = new ReciboBE();
        List<ReciboBE> recibos;
        public Recibos(LoginOuBE currentUser)
        {
            InitializeComponent();
            _currentUser = currentUser;
        }

        private void Recibos_Load(object sender, EventArgs e)
        {
            dtpFecInicio.MaxDate = DateTime.Now;
            dtpFecFin.MaxDate = DateTime.Now;
            dtpFecFin.MinDate = dtpFecInicio.Value;

            if (int.TryParse(_currentUser.nomUser, out _))
            {
                objEmpleado = _empleadoBL.ConsultarEmpleado(Convert.ToInt32(_currentUser.nomUser.Trim()));
            }

            recibos = _pagoBL.ListarRecibosEmpleado(objEmpleado.codEmpleado);
            dgRecibos.DataSource = recibos;
            txtCantReg.Text = recibos.Count.ToString();
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

        private void dgRecibos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgRecibos.Rows.Count > 0)
                {
                    codReciboSelect = int.Parse(dgRecibos.SelectedCells[0].Value.ToString());
                    var selectRow = recibos.FirstOrDefault(r => r.codRecibo == codReciboSelect);

                    rowSelect = selectRow;
                    txtCodRecibo.Text = selectRow.codRecibo.ToString();
                    txtFechaEmision.Text = selectRow.fechaEmision.ToString();
                    txtMoneda.Text = selectRow.moneda.ToString();
                    txtSueldoBase.Text = "S/. " + selectRow.sueldoBase.ToString("F2");
                    txtSueldoTotal.Text = "S/. " + selectRow.sueldoTotal.ToString("F2");
                    txtDescEssalud.Text = "S/. -" + selectRow.descEssalud.ToString("F2");
                    txtDescAfp.Text = "S/. -" + selectRow.descAfp.ToString("F2");
                    txtDescOnp.Text = "S/. -" + selectRow.descOnp.ToString("F2");
                    txtDescFaltas.Text = "S/. -" + selectRow.descFaltas.ToString("F2");
                }

            }
            catch (Exception ex) { }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (rowSelect!= null && rowSelect.codRecibo != 0 && rowSelect.codRecibo != null)
                {
                    Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
                    CultureInfo culture = new CultureInfo("es-ES");


                    string formattedDate = rowSelect.fechaEmision.ToString("dddd, d 'de' MMMM 'de' yyyy", culture);

                    SaveFileDialog savefile = new SaveFileDialog();
                    savefile.FileName = DateTime.Now.ToString("ddMMyyyyHHmmss") + ".pdf";
                    //savefile.ShowDialog();

                    string template = Properties.Resources.plantrecib.ToString();
                    template = template.Replace("@CODRECIBO", rowSelect.codRecibo.ToString());
                    template = template.Replace("@CODEMPLEADO", rowSelect.codEmpleado.ToString());
                    template = template.Replace("@APENOM", rowSelect.apenom);
                    template = template.Replace("@FECHAEMISION", formattedDate);
                    template = template.Replace("@MONEDA", rowSelect.moneda);
                    template = template.Replace("@SUELDOBASE", rowSelect.sueldoBase.ToString("F2"));
                    template = template.Replace("@DESCESSALUD", rowSelect.descEssalud.ToString("F2"));
                    template = template.Replace("@DESCONP", rowSelect.descOnp.ToString("F2"));
                    template = template.Replace("@DESCAFP", rowSelect.descAfp.ToString("F2"));
                    template = template.Replace("@DESCFALTAS", rowSelect.descFaltas.ToString("F2"));
                    template = template.Replace("@SUELDOTOTAL", rowSelect.sueldoTotal.ToString("F2"));
                    

                    if (savefile.ShowDialog() == DialogResult.OK)
                    {
                        using (MemoryStream memoryStream = new MemoryStream())
                        {
                            Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);
                            PdfWriter writer = PdfWriter.GetInstance(pdfDoc, memoryStream);
                            pdfDoc.Open();

                            pdfDoc.Add(new Phrase(""));
                            using (StringReader sr = new StringReader(template))
                            {
                                XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                            }

                            pdfDoc.Close();
                            writer.Close();

                            byte[] archivo = memoryStream.ToArray();
                            File.WriteAllBytes(savefile.FileName, archivo);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un recibo en la tabla.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
