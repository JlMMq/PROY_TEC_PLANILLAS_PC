namespace ProyBROL_GUI
{
    partial class SolicitudArchivo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SolicitudArchivo));
            pnlPdf = new Panel();
            gbAcciones = new GroupBox();
            btnRechazar = new Button();
            btnAceptar = new Button();
            gbControles = new GroupBox();
            btnSalir = new Button();
            gbInfo = new GroupBox();
            label19 = new Label();
            txtCodFind = new TextBox();
            txtApeNomFind = new TextBox();
            label18 = new Label();
            label17 = new Label();
            imgFoto = new PictureBox();
            lblEstado = new Label();
            label7 = new Label();
            lblAsunto = new Label();
            lblSolicitud = new Label();
            lblCodigo = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            lblPersona = new Label();
            lblMensaje = new Label();
            gbAcciones.SuspendLayout();
            gbControles.SuspendLayout();
            gbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgFoto).BeginInit();
            SuspendLayout();
            // 
            // pnlPdf
            // 
            pnlPdf.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlPdf.Location = new Point(0, 0);
            pnlPdf.Name = "pnlPdf";
            pnlPdf.Size = new Size(851, 891);
            pnlPdf.TabIndex = 0;
            // 
            // gbAcciones
            // 
            gbAcciones.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            gbAcciones.Controls.Add(lblMensaje);
            gbAcciones.Controls.Add(btnRechazar);
            gbAcciones.Controls.Add(btnAceptar);
            gbAcciones.Location = new Point(857, 680);
            gbAcciones.Name = "gbAcciones";
            gbAcciones.Size = new Size(329, 99);
            gbAcciones.TabIndex = 1;
            gbAcciones.TabStop = false;
            gbAcciones.Text = "Acciones";
            // 
            // btnRechazar
            // 
            btnRechazar.Anchor = AnchorStyles.Top;
            btnRechazar.BackColor = Color.Black;
            btnRechazar.FlatAppearance.BorderSize = 0;
            btnRechazar.FlatStyle = FlatStyle.Flat;
            btnRechazar.Font = new Font("Leelawadee", 9.75F);
            btnRechazar.ForeColor = SystemColors.ControlLightLight;
            btnRechazar.Location = new Point(173, 31);
            btnRechazar.Name = "btnRechazar";
            btnRechazar.Size = new Size(103, 48);
            btnRechazar.TabIndex = 40;
            btnRechazar.Text = "RECHAZAR";
            btnRechazar.UseVisualStyleBackColor = false;
            btnRechazar.Click += btnRechazar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Anchor = AnchorStyles.Top;
            btnAceptar.BackColor = Color.Black;
            btnAceptar.FlatAppearance.BorderSize = 0;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Leelawadee", 9.75F);
            btnAceptar.ForeColor = SystemColors.ControlLightLight;
            btnAceptar.Location = new Point(64, 31);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(103, 48);
            btnAceptar.TabIndex = 39;
            btnAceptar.Text = "ACEPTAR";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // gbControles
            // 
            gbControles.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            gbControles.Controls.Add(btnSalir);
            gbControles.Location = new Point(857, 570);
            gbControles.Name = "gbControles";
            gbControles.Size = new Size(329, 104);
            gbControles.TabIndex = 2;
            gbControles.TabStop = false;
            gbControles.Text = "Controles";
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.Top;
            btnSalir.BackColor = Color.Black;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Leelawadee", 9.75F);
            btnSalir.ForeColor = SystemColors.ControlLightLight;
            btnSalir.Location = new Point(113, 28);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(103, 48);
            btnSalir.TabIndex = 39;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // gbInfo
            // 
            gbInfo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            gbInfo.Controls.Add(label19);
            gbInfo.Controls.Add(txtCodFind);
            gbInfo.Controls.Add(txtApeNomFind);
            gbInfo.Controls.Add(label18);
            gbInfo.Controls.Add(label17);
            gbInfo.Controls.Add(imgFoto);
            gbInfo.Controls.Add(lblEstado);
            gbInfo.Controls.Add(label7);
            gbInfo.Controls.Add(lblAsunto);
            gbInfo.Controls.Add(lblSolicitud);
            gbInfo.Controls.Add(lblCodigo);
            gbInfo.Controls.Add(label5);
            gbInfo.Controls.Add(label4);
            gbInfo.Controls.Add(label3);
            gbInfo.Controls.Add(lblPersona);
            gbInfo.Location = new Point(857, 12);
            gbInfo.Name = "gbInfo";
            gbInfo.Size = new Size(329, 552);
            gbInfo.TabIndex = 8;
            gbInfo.TabStop = false;
            gbInfo.Text = "Informacion";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(29, 321);
            label19.Name = "label19";
            label19.Size = new Size(34, 15);
            label19.TabIndex = 48;
            label19.Text = "Foto:";
            // 
            // txtCodFind
            // 
            txtCodFind.BorderStyle = BorderStyle.FixedSingle;
            txtCodFind.Location = new Point(129, 285);
            txtCodFind.Name = "txtCodFind";
            txtCodFind.ReadOnly = true;
            txtCodFind.Size = new Size(136, 23);
            txtCodFind.TabIndex = 47;
            // 
            // txtApeNomFind
            // 
            txtApeNomFind.BorderStyle = BorderStyle.FixedSingle;
            txtApeNomFind.Location = new Point(17, 256);
            txtApeNomFind.Name = "txtApeNomFind";
            txtApeNomFind.ReadOnly = true;
            txtApeNomFind.Size = new Size(301, 23);
            txtApeNomFind.TabIndex = 46;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(18, 289);
            label18.Name = "label18";
            label18.Size = new Size(105, 15);
            label18.TabIndex = 45;
            label18.Text = "Codigo empleado:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(14, 233);
            label17.Name = "label17";
            label17.Size = new Size(164, 15);
            label17.TabIndex = 44;
            label17.Text = "Apellido y Nombre completo:";
            // 
            // imgFoto
            // 
            imgFoto.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            imgFoto.BorderStyle = BorderStyle.FixedSingle;
            imgFoto.Image = Properties.Resources.noimage;
            imgFoto.Location = new Point(71, 339);
            imgFoto.Name = "imgFoto";
            imgFoto.Size = new Size(179, 179);
            imgFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            imgFoto.TabIndex = 43;
            imgFoto.TabStop = false;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEstado.Location = new Point(103, 160);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(0, 25);
            lblEstado.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(18, 168);
            label7.Name = "label7";
            label7.Size = new Size(45, 15);
            label7.TabIndex = 7;
            label7.Text = "Estado:";
            // 
            // lblAsunto
            // 
            lblAsunto.AutoSize = true;
            lblAsunto.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAsunto.Location = new Point(103, 129);
            lblAsunto.Name = "lblAsunto";
            lblAsunto.Size = new Size(0, 25);
            lblAsunto.TabIndex = 6;
            // 
            // lblSolicitud
            // 
            lblSolicitud.AutoSize = true;
            lblSolicitud.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSolicitud.Location = new Point(103, 99);
            lblSolicitud.Name = "lblSolicitud";
            lblSolicitud.Size = new Size(0, 25);
            lblSolicitud.TabIndex = 5;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Font = new Font("Segoe UI Semibold", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCodigo.Location = new Point(103, 43);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(96, 47);
            lblCodigo.TabIndex = 4;
            lblCodigo.Text = "0000";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 137);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 3;
            label5.Text = "Asunto:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 104);
            label4.Name = "label4";
            label4.Size = new Size(81, 15);
            label4.TabIndex = 2;
            label4.Text = "Tipo solicitud:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 28);
            label3.Name = "label3";
            label3.Size = new Size(113, 15);
            label3.TabIndex = 1;
            label3.Text = "Codigo de solicitud:";
            // 
            // lblPersona
            // 
            lblPersona.AutoSize = true;
            lblPersona.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPersona.Location = new Point(14, 203);
            lblPersona.Name = "lblPersona";
            lblPersona.Size = new Size(85, 21);
            lblPersona.TabIndex = 0;
            lblPersona.Text = "Solicitante:";
            // 
            // lblMensaje
            // 
            lblMensaje.BackColor = Color.Transparent;
            lblMensaje.Location = new Point(16, 40);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(302, 31);
            lblMensaje.TabIndex = 41;
            lblMensaje.Text = "NO SE PUEDE PROCESAR LA SOLICITUD PORQUE YA SE ENCUENTRA ";
            lblMensaje.TextAlign = ContentAlignment.MiddleCenter;
            lblMensaje.Visible = false;
            // 
            // SolicitudArchivo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1198, 891);
            Controls.Add(gbControles);
            Controls.Add(gbInfo);
            Controls.Add(gbAcciones);
            Controls.Add(pnlPdf);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SolicitudArchivo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Solicitudes";
            Load += SolicitudArchivo_Load;
            gbAcciones.ResumeLayout(false);
            gbControles.ResumeLayout(false);
            gbInfo.ResumeLayout(false);
            gbInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgFoto).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlPdf;
        private GroupBox gbAcciones;
        private GroupBox gbControles;
        private GroupBox gbInfo;
        private Label label19;
        private TextBox txtCodFind;
        private TextBox txtApeNomFind;
        private Label label18;
        private Label label17;
        private PictureBox imgFoto;
        private Label lblEstado;
        private Label label7;
        private Label lblAsunto;
        private Label lblSolicitud;
        private Label lblCodigo;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label lblPersona;
        private Button btnRechazar;
        private Button btnAceptar;
        private Button btnSalir;
        private Label lblMensaje;
    }
}