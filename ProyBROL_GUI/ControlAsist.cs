﻿
using ProyBROL_BE;
using ProyBROL_BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
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

        EmpleadoBL objEmpleadoBL = new EmpleadoBL();
        EmpleadoBE objEmpleadoBE = new EmpleadoBE();

        DocumentoBE objDocumentoBE = new DocumentoBE();
        DocumentoBL objDocumentoBL = new DocumentoBL();

        HorarioBE objHorarioBE = new HorarioBE();
        HorarioBL objHorarioBL = new HorarioBL();

        MarcasBE objMarcasBE = new MarcasBE();
        MarcasBL objMarcasBL = new MarcasBL();

        DiarioBE objDiarioBE = new DiarioBE();
        DiarioBL objDiarioBL = new DiarioBL();

        public String nomUser = "System";

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
            DateTime tmrReg = DateTime.Now;

            if (ValidarEmpleado())
            {
                objDiarioBE = objDiarioBL.ConsultarDiarioFecEmpl(tmrReg, objEmpleadoBE.codEmpleado);

                if (objDiarioBE.empleado == null)
                {
                    objHorarioBE = objHorarioBL.ConsultarHorario(objEmpleadoBE.codHorario);
                    DayOfWeek diaSemana = tmrReg.DayOfWeek;
                    int dia = (int)diaSemana;
                    switch (dia)
                    {
                        case 1:
                            if (objHorarioBE.ingLUN == objHorarioBE.salLUN)
                            {
                                lblSituac.Text = "NO LABORABLE";
                                lblSituac.ForeColor = Color.Black;
                            }
                            else
                            {
                                procesarMarca(tmrReg);
                            }
                            break;
                        case 2:
                            if (objHorarioBE.ingMAR == objHorarioBE.salMAR)
                            {
                                lblSituac.Text = "NO LABORABLE";
                                lblSituac.ForeColor = Color.Black;
                            }
                            else
                            {
                                procesarMarca(tmrReg);
                            }
                            break;
                        case 3:
                            if (objHorarioBE.ingMIE == objHorarioBE.salMIE)
                            {
                                lblSituac.Text = "NO LABORABLE";
                                lblSituac.ForeColor = Color.Black;
                            }
                            else
                            {
                                procesarMarca(tmrReg);
                            }
                            break;
                        case 4:
                            if (objHorarioBE.ingJUE == objHorarioBE.salJUE)
                            {
                                lblSituac.Text = "NO LABORABLE";
                                lblSituac.ForeColor = Color.Black;
                            }
                            else
                            {
                                procesarMarca(tmrReg);
                            }
                            break;
                        case 5:
                            if (objHorarioBE.ingVIE == objHorarioBE.salVIE)
                            {
                                lblSituac.Text = "NO LABORABLE";
                                lblSituac.ForeColor = Color.Black;
                            }
                            else
                            {
                                procesarMarca(tmrReg);
                            }
                            break;
                        case 6:
                            if (objHorarioBE.ingSAB == objHorarioBE.salSAB)
                            {
                                lblSituac.Text = "NO LABORABLE";
                                lblSituac.ForeColor = Color.Black;
                            }
                            else
                            {
                                procesarMarca(tmrReg);
                            }
                            break;
                        case 7:
                            if (objHorarioBE.ingDOM == objHorarioBE.salDOM)
                            {
                                lblSituac.Text = "NO LABORABLE";
                                lblSituac.ForeColor = Color.Black;
                            }
                            else
                            {
                                procesarMarca(tmrReg);
                            }
                            break;
                    }

                }
                else
                {
                    lblMensaje.Text = "El empleado ya cuenta con un registro de INGRESO";
                    lblMensaje.ForeColor = Color.Red;
                    LimpiarLblsControlAsis();
                }
            }
        }

        private void btnSalRefr_Click(object sender, EventArgs e)
        {
            DateTime tmrReg = DateTime.Now;

            if (ValidarEmpleado())
            {
                objDiarioBE = objDiarioBL.ConsultarDiarioFecEmpl(tmrReg, objEmpleadoBE.codEmpleado);


                if (objDiarioBE.hora2 == null && objDiarioBE.hora1 != null)
                {
                    ImprimirInfEmpleado();
                    objMarcasBE.empleado = objEmpleadoBE.codEmpleado;
                    objMarcasBE.usu_Reg = nomUser;
                    objMarcasBE.tipo = 2;
                    DeterminarSituacion(objEmpleadoBE, tmrReg, 2);

                    if (objMarcasBL.InsertarMarca(objMarcasBE, objEmpleadoBE.codHorario, objDiarioBE.fecha))
                    {
                        lblMarca.Text = DateTime.Now.ToString("hh:mm:ss");
                        lblMensaje.Text = "Se ingreso correctamente la marca.";
                        lblMensaje.ForeColor = Color.Black;
                    }
                    else
                    {
                        lblMensaje.Text = "No se pudo ingresar la marca";
                        lblMensaje.ForeColor = Color.Black;
                        LimpiarLblsControlAsis();
                    }
                }
                else
                {
                    lblMensaje.Text = "El empleado ya cuenta con un registro de SALIDA REFRIGERIO";
                    lblMensaje.ForeColor = Color.Red;
                    LimpiarLblsControlAsis();
                }
            }
        }

        private void btnIngRefr_Click(object sender, EventArgs e)
        {
            DateTime tmrReg = DateTime.Now;

            if (ValidarEmpleado())
            {
                objDiarioBE = objDiarioBL.ConsultarDiarioFecEmpl(tmrReg, objEmpleadoBE.codEmpleado);


                if (objDiarioBE.hora3 == null && objDiarioBE.hora2 != null)
                {
                    ImprimirInfEmpleado();
                    objMarcasBE.empleado = objEmpleadoBE.codEmpleado;
                    objMarcasBE.usu_Reg = nomUser;
                    objMarcasBE.tipo = 3;
                    DeterminarSituacion(objEmpleadoBE, tmrReg, 3);

                    if (objMarcasBL.InsertarMarca(objMarcasBE, objEmpleadoBE.codHorario, objDiarioBE.fecha))
                    {
                        lblMarca.Text = DateTime.Now.ToString("hh:mm:ss");
                        lblMensaje.Text = "Se ingreso correctamente la marca.";
                        lblMensaje.ForeColor = Color.Black;
                    }
                    else
                    {
                        lblMensaje.Text = "No se pudo ingresar la marca";
                        lblMensaje.ForeColor = Color.Black;
                        LimpiarLblsControlAsis();
                    }
                }
                else
                {
                    lblMensaje.Text = "El empleado ya cuenta con un registro de INGRESO REFRIGERIO";
                    lblMensaje.ForeColor = Color.Red;
                    LimpiarLblsControlAsis();
                }
            }
        }

        private void btnSald_Click(object sender, EventArgs e)
        {
            DateTime tmrReg = DateTime.Now;

            if (ValidarEmpleado())
            {
                objDiarioBE = objDiarioBL.ConsultarDiarioFecEmpl(tmrReg, objEmpleadoBE.codEmpleado);


                if (objDiarioBE.hora4 == null)
                {
                    ImprimirInfEmpleado();
                    objMarcasBE.empleado = objEmpleadoBE.codEmpleado;
                    objMarcasBE.usu_Reg = nomUser;
                    objMarcasBE.tipo = 4;
                    DeterminarSituacion(objEmpleadoBE, tmrReg, 4);

                    if (objMarcasBL.InsertarMarca(objMarcasBE, objEmpleadoBE.codHorario, objDiarioBE.fecha))
                    {
                        lblMarca.Text = DateTime.Now.ToString("hh:mm:ss");
                        lblMensaje.Text = "Se ingreso correctamente la marca.";
                        lblMensaje.ForeColor = Color.Black;
                    }
                    else
                    {
                        lblMensaje.Text = "No se pudo ingresar la marca";
                        lblMensaje.ForeColor = Color.Black;
                        LimpiarLblsControlAsis();
                    }
                }
                else
                {
                    lblMensaje.Text = "El empleado ya cuenta con un registro de SALIDA";
                    lblMensaje.ForeColor = Color.Red;
                    LimpiarLblsControlAsis();
                }
            }
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void ImprimirInfEmpleado()
        {
            txtNombre.Text = objEmpleadoBE.apellidos.ToString() + ", " + objEmpleadoBE.nombres.ToString();
            txtCodOut.Text = objEmpleadoBE.codEmpleado.ToString();
            objDocumentoBE = objDocumentoBL.ConsultarDocumento(objEmpleadoBE.tipoDoc);
            txtDocm.Text = objDocumentoBE.descrLarga.ToString();
            txtNumDoc.Text = objEmpleadoBE.numroDoc.ToString();

            byte[] img = objEmpleadoBE.foto;
            if (img != null && img.Length > 0)
            {
                System.IO.MemoryStream memoryStream = new System.IO.MemoryStream(img);
                imgEmpl.Image = Image.FromStream(memoryStream);
            }
            else
            {
                string basePath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
                string fotosTempPath = Path.Combine(basePath, "FotosTemp\\");
                imgEmpl.Image = Image.FromFile(fotosTempPath + "noimage.jpg");
            }

            txtCodigo.Text = string.Empty;

        }
        private void LimpiarLblsControlAsis()
        {
            txtNombre.Text = string.Empty;
            txtCodOut.Text = string.Empty;
            txtDocm.Text = string.Empty;
            txtNumDoc.Text = string.Empty;
            txtCodigo.Text = string.Empty;
            lblSituac.Text = string.Empty;
            lblMarca.Text = "00:00:00";
            string basePath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string fotosTempPath = Path.Combine(basePath, "FotosTemp\\");
            imgEmpl.Image = Image.FromFile(fotosTempPath + "noimage.jpg");
        }
        private void imprPunTard(DateTime horaComparar, TimeSpan? horaReg)
        {
            TimeSpan horaCompararSpan = new TimeSpan(horaComparar.Hour, horaComparar.Minute, horaComparar.Second);
            if (horaCompararSpan <= horaReg)
            {
                lblSituac.Text = "PUNTUAL";
                lblSituac.ForeColor = Color.Green;
            }
            else
            {
                lblSituac.Text = "TARDE";
                lblSituac.ForeColor = Color.Red;
            }
        }
        private void DeterminarSituacion(EmpleadoBE empleado, DateTime tmrReg, int tipo)
        {
            DayOfWeek diaSemana = tmrReg.DayOfWeek;

            int dia = (int)diaSemana;
            objHorarioBE = objHorarioBL.ConsultarHorario(empleado.codHorario);
            if (tipo == 1)
            {
                switch (dia)
                {
                    case 0:
                        imprPunTard(tmrReg, objHorarioBE.ingDOM);
                        break;
                    case 1:
                        imprPunTard(tmrReg, objHorarioBE.ingLUN);
                        break;
                    case 2:
                        imprPunTard(tmrReg, objHorarioBE.ingMAR);
                        break;
                    case 3:
                        imprPunTard(tmrReg, objHorarioBE.ingMIE);
                        break;
                    case 4:
                        imprPunTard(tmrReg, objHorarioBE.ingJUE);
                        break;
                    case 5:
                        imprPunTard(tmrReg, objHorarioBE.ingVIE);
                        break;
                    case 6:
                        imprPunTard(tmrReg, objHorarioBE.ingSAB);
                        break;
                }
            }

        }

        private bool ValidarEmpleado()
        {
            if (txtCodigo.Text != "")
            {
                int codigoEmpleado = Convert.ToInt32(txtCodigo.Text.Trim());
                String numroDoc = txtCodigo.Text.Trim();
                objEmpleadoBE = objEmpleadoBL.ConsultarEmpleadoCodDoc(codigoEmpleado, numroDoc);

                if (objEmpleadoBE.nombres == null)
                {
                    lblMensaje.Text = "El empleado no existe o ingreso mal el codigo/documento";
                    lblMensaje.ForeColor = Color.Red;
                    LimpiarLblsControlAsis();
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                lblMensaje.Text = "El campo de codigo es obligatorio";
                lblMensaje.ForeColor = Color.Red;
                LimpiarLblsControlAsis();
                return false;
            }
        }

        private void procesarMarca(DateTime tmrReg)
        {
            LimpiarLblsControlAsis();
            ImprimirInfEmpleado();
            objMarcasBE.empleado = objEmpleadoBE.codEmpleado;
            objMarcasBE.usu_Reg = nomUser;
            objMarcasBE.tipo = 1;
            objDiarioBE.fecha = tmrReg;
            DeterminarSituacion(objEmpleadoBE, tmrReg, 1);

            if (objMarcasBL.InsertarMarca(objMarcasBE, objEmpleadoBE.codHorario, objDiarioBE.fecha))
            {
                lblMarca.Text = DateTime.Now.ToString("hh:mm:ss");
                lblMensaje.Text = "Se ingreso correctamente la marca.";
                lblMensaje.ForeColor = Color.Black;
            }
            else
            {
                lblMensaje.Text = "No se pudo ingresar la marca";
                lblMensaje.ForeColor = Color.Black;
                LimpiarLblsControlAsis();
            }
        }

        private void ControlAsist_Load(object sender, EventArgs e)
        {

        }

        private void dtClean_Tick(object sender, EventArgs e)
        {

        }

        private void btnMarca_Click(object sender, EventArgs e)
        {
            DateTime tmrReg = DateTime.Now;

            if (ValidarEmpleado())
            {
                objDiarioBE = objDiarioBL.ConsultarDiarioFecEmpl(tmrReg, objEmpleadoBE.codEmpleado);

                //INGRESO: Si es nulo es porque no existe ninguna marca hoy dia
                if (objDiarioBE.empleado == null)
                {
                    objHorarioBE = objHorarioBL.ConsultarHorario(objEmpleadoBE.codHorario);
                    DayOfWeek diaSemana = tmrReg.DayOfWeek;
                    int dia = (int)diaSemana;
                    switch (dia)
                    {
                        case 1:
                            if (objHorarioBE.ingLUN == objHorarioBE.salLUN)
                            {
                                lblSituac.Text = "NO LABORABLE";
                                lblSituac.ForeColor = Color.Black;
                            }
                            else
                            {
                                procesarMarca(tmrReg);
                            }
                            break;
                        case 2:
                            if (objHorarioBE.ingMAR == objHorarioBE.salMAR)
                            {
                                lblSituac.Text = "NO LABORABLE";
                                lblSituac.ForeColor = Color.Black;
                            }
                            else
                            {
                                procesarMarca(tmrReg);
                            }
                            break;
                        case 3:
                            if (objHorarioBE.ingMIE == objHorarioBE.salMIE)
                            {
                                lblSituac.Text = "NO LABORABLE";
                                lblSituac.ForeColor = Color.Black;
                            }
                            else
                            {
                                procesarMarca(tmrReg);
                            }
                            break;
                        case 4:
                            if (objHorarioBE.ingJUE == objHorarioBE.salJUE)
                            {
                                lblSituac.Text = "NO LABORABLE";
                                lblSituac.ForeColor = Color.Black;
                            }
                            else
                            {
                                procesarMarca(tmrReg);
                            }
                            break;
                        case 5:
                            if (objHorarioBE.ingVIE == objHorarioBE.salVIE)
                            {
                                lblSituac.Text = "NO LABORABLE";
                                lblSituac.ForeColor = Color.Black;
                            }
                            else
                            {
                                procesarMarca(tmrReg);
                            }
                            break;
                        case 6:
                            if (objHorarioBE.ingSAB == objHorarioBE.salSAB)
                            {
                                lblSituac.Text = "NO LABORABLE";
                                lblSituac.ForeColor = Color.Black;
                            }
                            else
                            {
                                procesarMarca(tmrReg);
                            }
                            break;
                        case 7:
                            if (objHorarioBE.ingDOM == objHorarioBE.salDOM)
                            {
                                lblSituac.Text = "NO LABORABLE";
                                lblSituac.ForeColor = Color.Black;
                            }
                            else
                            {
                                procesarMarca(tmrReg);
                            }
                            break;
                    }

                }
                

                //SALIDA al REFRIGERIO si cumple que hora2 es nulo y hora1 es distinto de nulo es porque es hora del almuerzo
                if (objDiarioBE.hora2 == null && objDiarioBE.hora1 != null)
                {
                    ImprimirInfEmpleado();
                    objMarcasBE.empleado = objEmpleadoBE.codEmpleado;
                    objMarcasBE.usu_Reg = nomUser;
                    objMarcasBE.tipo = 2;
                    DeterminarSituacion(objEmpleadoBE, tmrReg, 2);

                    if (objMarcasBL.InsertarMarca(objMarcasBE, objEmpleadoBE.codHorario, objDiarioBE.fecha))
                    {
                        lblMarca.Text = DateTime.Now.ToString("hh:mm:ss");
                        lblMensaje.Text = "Se ingreso correctamente la marca.";
                        lblMensaje.ForeColor = Color.Black;
                        lblSituac.Text = "REFRIGERIO";
                    }
                    else
                    {
                        lblMensaje.Text = "No se pudo ingresar la marca";
                        lblMensaje.ForeColor = Color.Black;
                        lblSituac.Text = "";
                        LimpiarLblsControlAsis();
                    }
                }
               

                //VUELTA DEL REGRIGERIO
                if (objDiarioBE.hora3 == null && objDiarioBE.hora2 != null)
                {
                    ImprimirInfEmpleado();
                    objMarcasBE.empleado = objEmpleadoBE.codEmpleado;
                    objMarcasBE.usu_Reg = nomUser;
                    objMarcasBE.tipo = 3;
                    DeterminarSituacion(objEmpleadoBE, tmrReg, 3);

                    if (objMarcasBL.InsertarMarca(objMarcasBE, objEmpleadoBE.codHorario, objDiarioBE.fecha))
                    {
                        lblMarca.Text = DateTime.Now.ToString("hh:mm:ss");
                        lblMensaje.Text = "Se ingreso correctamente la marca.";
                        lblSituac.Text = "REFRIGERIO";
                        lblMensaje.ForeColor = Color.Black;
                    }
                    else
                    {
                        lblMensaje.Text = "No se pudo ingresar la marca";
                        lblMensaje.ForeColor = Color.Black;
                        lblSituac.Text = "";
                        LimpiarLblsControlAsis();
                    }
                }
               

                //SALIDA 
                if (objDiarioBE.hora4 == null && objDiarioBE.hora1 != null && objDiarioBE.hora3 != null)
                {
                    ImprimirInfEmpleado();
                    objMarcasBE.empleado = objEmpleadoBE.codEmpleado;
                    objMarcasBE.usu_Reg = nomUser;
                    objMarcasBE.tipo = 4;
                    DeterminarSituacion(objEmpleadoBE, tmrReg, 4);

                    if (objMarcasBL.InsertarMarca(objMarcasBE, objEmpleadoBE.codHorario, objDiarioBE.fecha))
                    {
                        lblMarca.Text = DateTime.Now.ToString("hh:mm:ss");
                        lblMensaje.Text = "Se ingreso correctamente la marca.";
                        lblMensaje.ForeColor = Color.Black;
                        lblSituac.Text = "SALIDA";
                    }
                    else
                    {
                        lblMensaje.Text = "No se pudo ingresar la marca";
                        lblMensaje.ForeColor = Color.Black;
                        LimpiarLblsControlAsis();
                        lblSituac.Text = "";
                    }
                }

                if(objDiarioBE.hora1 != null && objDiarioBE.hora2 != null && objDiarioBE.hora3 != null && objDiarioBE.hora4 != null)
                {
                    lblMensaje.Text = "Proceso de marcas cerrado.";
                    lblSituac.Text = "CERRADO";
                }
            }
        }
    }
}
