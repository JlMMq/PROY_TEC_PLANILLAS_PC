﻿using System;
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
    public partial class Usuarios : Form
    {
        int _permiso;
        UsuariosEmp formUsuariosEmp;
        LoginCredentials loginCredentials;
        public Usuarios(int permiso)
        {
            _permiso = permiso;
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnGestionPers_Click(object sender, EventArgs e)
        {
            if (formUsuariosEmp == null)
            {
                formUsuariosEmp = new UsuariosEmp();
                formUsuariosEmp.FormClosed += new FormClosedEventHandler(EstaCerradoUsuarioEmp);
                formUsuariosEmp.Show();
            }
            else
            {
                formUsuariosEmp.BringToFront();
            }
        }
        void EstaCerradoUsuarioEmp(object sender, EventArgs e)
        {
            formUsuariosEmp = null;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (loginCredentials == null)
            {
                loginCredentials = new LoginCredentials();
                loginCredentials.FormClosed += new FormClosedEventHandler(EstaCerradoCredentials);
                loginCredentials.ShowDialog();
            }
            else
            {
                loginCredentials.BringToFront();
            }
        }

        void EstaCerradoCredentials(object sender, EventArgs e)
        {
            loginCredentials = null;
        }


    }
}


