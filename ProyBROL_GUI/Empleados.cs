﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ProyBROL_BL;
using ProyBROL_BE;

namespace ProyBROL_GUI
{

    public partial class Empleados : Form
    {
        EmpleadoBL objEmpleadoBL = new EmpleadoBL();
        EmpleadoBE objEmpleadoBE = new EmpleadoBE();

        int codEmpleado;
        public String nomUser;

        EmpleadoNuevo formEmpleadoNuevo;
        EmpleadoModificar formEmpleadoModificar;
        DataView dtv;
        public Empleados(String nomUser)
        {
            InitializeComponent();
            this.nomUser = nomUser;
        }

        private void cargardtgEmpleados(String strFilter)
        {
            //dtv = new DataView(objEmpleadoBL.ListarEmpleados());
            dtgEmpleados.DataSource = objEmpleadoBL.ListarEmpleadosGrilla();
            txtNumReg.Text = dtgEmpleados.Rows.Count.ToString();
        }
        private void filtrarDatosNombre(String strFilter)
        {
            //dtv = new DataView(objEmpleadoBL.ListarEmpleados());
            //dtv.RowFilter = "nombres like '%" + strFilter + "%'";
            dtgEmpleados.DataSource = dtv;
            txtNumReg.Text = dtgEmpleados.Rows.Count.ToString();
        }
        private void filtrarDatosCodigo(String strFilter)
        {

            //dtv = new DataView(objEmpleadoBL.ListarEmpleados());
            //dtv.RowFilter = $"CONVERT(codEmpleado, 'System.String') LIKE '%{strFilter}%'";
            dtgEmpleados.DataSource = dtv;
            txtNumReg.Text = dtgEmpleados.Rows.Count.ToString();
        }
        private void filtrarDatosApellido(String strFilter)
        {
            //dtv = new DataView(objEmpleadoBL.ListarEmpleados());
            //dtv.RowFilter = "apellidos like '%" + strFilter + "%'";
            dtgEmpleados.DataSource = dtv;
            txtNumReg.Text = dtgEmpleados.Rows.Count.ToString();
        }

        private void Empleados_Load(object sender, EventArgs e)
        {
            cargardtgEmpleados("");
        }

        private void dtgEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgEmpleados.Rows.Count > 0)
            {
                codEmpleado = int.Parse(dtgEmpleados.SelectedCells[0].Value.ToString());
            }

        }

        private void txtFiltNombre_TextChanged(object sender, EventArgs e)
        {
            try
            {
                filtrarDatosNombre(txtFiltNombre.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void txtFiltCodigo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                filtrarDatosCodigo(txtFiltCodigo.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void txtFiltApellido_TextChanged(object sender, EventArgs e)
        {

            try
            {
                filtrarDatosApellido(txtFiltApellido.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //if (objEmpleadoBL.EliminarEmpleado(codEmpleado))
            //{
            //    cargardtgEmpleados("");
            //    lblMensaje.Text = "Se elimino el empleado correctamente.";
            //}
            //else
            //{
            //    lblMensaje.Text = "No se pudo eliminar el empleado. Puede ser que el empleado ya tenga una marca asignada.";
            //}
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

            if (formEmpleadoNuevo == null)
            {
                formEmpleadoNuevo = new EmpleadoNuevo(nomUser);
                formEmpleadoNuevo.FormClosed += new FormClosedEventHandler(EstaCerradoEmpleadoNuevo);
                formEmpleadoNuevo.BringToFront();
                formEmpleadoNuevo.ShowDialog();
                cargardtgEmpleados("");
            }
            else
            {
                formEmpleadoNuevo.BringToFront();
            }
        }

        void EstaCerradoEmpleadoNuevo(object sender, EventArgs e)
        {
            formEmpleadoNuevo = null;
        }
        void EstaCerradoEmpleadoModificar(object sender, EventArgs e)
        {
            formEmpleadoModificar = null;
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (formEmpleadoNuevo == null && codEmpleado != 0)
            {
                formEmpleadoModificar = new EmpleadoModificar(nomUser, codEmpleado);
                formEmpleadoModificar.FormClosed += new FormClosedEventHandler(EstaCerradoEmpleadoModificar);
                formEmpleadoModificar.BringToFront();
                formEmpleadoModificar.ShowDialog();
                cargardtgEmpleados("");
            }
            else if (codEmpleado == 0)
            {
                MessageBox.Show("Por favor, haga click en un valor de la tabla para continuar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                formEmpleadoModificar.BringToFront();
            }
        }
    }
}
