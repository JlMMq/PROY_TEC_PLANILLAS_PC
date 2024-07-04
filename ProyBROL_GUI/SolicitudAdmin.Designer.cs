namespace ProyBROL_GUI
{
    partial class SolicitudAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SolicitudAdmin));
            label1 = new Label();
            gbInfo = new GroupBox();
            btnVisualizar = new Button();
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
            button1 = new Button();
            gbSalir = new GroupBox();
            btnActualizar = new Button();
            dtgSolicEnviadas = new DataGridView();
            codSolicitud = new DataGridViewTextBoxColumn();
            codSolicitante = new DataGridViewTextBoxColumn();
            tipoAsunto = new DataGridViewTextBoxColumn();
            estado = new DataGridViewTextBoxColumn();
            foto = new DataGridViewTextBoxColumn();
            tipoSolic = new DataGridViewTextBoxColumn();
            codSupervisor = new DataGridViewTextBoxColumn();
            nomape = new DataGridViewTextBoxColumn();
            desc_solic = new DataGridViewTextBoxColumn();
            desc_asunto = new DataGridViewTextBoxColumn();
            desc_estado = new DataGridViewTextBoxColumn();
            desc_content = new DataGridViewTextBoxColumn();
            lbl = new Label();
            label8 = new Label();
            dtgSolicRecibidas = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn11 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn12 = new DataGridViewTextBoxColumn();
            gbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgFoto).BeginInit();
            gbSalir.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgSolicEnviadas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgSolicRecibidas).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Leelawadee", 15.75F);
            label1.Location = new Point(31, 28);
            label1.Name = "label1";
            label1.Size = new Size(334, 25);
            label1.TabIndex = 5;
            label1.Text = "Solicitudes de Licencias y Permisos";
            // 
            // gbInfo
            // 
            gbInfo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            gbInfo.Controls.Add(btnVisualizar);
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
            gbInfo.Location = new Point(829, 67);
            gbInfo.Name = "gbInfo";
            gbInfo.Size = new Size(344, 607);
            gbInfo.TabIndex = 7;
            gbInfo.TabStop = false;
            gbInfo.Text = "Informacion";
            // 
            // btnVisualizar
            // 
            btnVisualizar.Anchor = AnchorStyles.Top;
            btnVisualizar.BackColor = Color.Black;
            btnVisualizar.FlatAppearance.BorderSize = 0;
            btnVisualizar.FlatStyle = FlatStyle.Flat;
            btnVisualizar.Font = new Font("Leelawadee", 9.75F);
            btnVisualizar.ForeColor = SystemColors.ControlLightLight;
            btnVisualizar.Location = new Point(113, 528);
            btnVisualizar.Name = "btnVisualizar";
            btnVisualizar.Size = new Size(103, 48);
            btnVisualizar.TabIndex = 49;
            btnVisualizar.Text = "VISUALIZAR";
            btnVisualizar.UseVisualStyleBackColor = false;
            btnVisualizar.Click += btnVisualizar_Click;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(36, 321);
            label19.Name = "label19";
            label19.Size = new Size(34, 15);
            label19.TabIndex = 48;
            label19.Text = "Foto:";
            // 
            // txtCodFind
            // 
            txtCodFind.BorderStyle = BorderStyle.FixedSingle;
            txtCodFind.Location = new Point(136, 285);
            txtCodFind.Name = "txtCodFind";
            txtCodFind.ReadOnly = true;
            txtCodFind.Size = new Size(136, 23);
            txtCodFind.TabIndex = 47;
            // 
            // txtApeNomFind
            // 
            txtApeNomFind.BorderStyle = BorderStyle.FixedSingle;
            txtApeNomFind.Location = new Point(24, 256);
            txtApeNomFind.Name = "txtApeNomFind";
            txtApeNomFind.ReadOnly = true;
            txtApeNomFind.Size = new Size(301, 23);
            txtApeNomFind.TabIndex = 46;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(25, 289);
            label18.Name = "label18";
            label18.Size = new Size(105, 15);
            label18.TabIndex = 45;
            label18.Text = "Codigo empleado:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(21, 233);
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
            imgFoto.Location = new Point(97, 321);
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
            lblEstado.Location = new Point(110, 160);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(0, 25);
            lblEstado.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(25, 168);
            label7.Name = "label7";
            label7.Size = new Size(45, 15);
            label7.TabIndex = 7;
            label7.Text = "Estado:";
            // 
            // lblAsunto
            // 
            lblAsunto.AutoSize = true;
            lblAsunto.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAsunto.Location = new Point(110, 129);
            lblAsunto.Name = "lblAsunto";
            lblAsunto.Size = new Size(0, 25);
            lblAsunto.TabIndex = 6;
            // 
            // lblSolicitud
            // 
            lblSolicitud.AutoSize = true;
            lblSolicitud.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSolicitud.Location = new Point(110, 99);
            lblSolicitud.Name = "lblSolicitud";
            lblSolicitud.Size = new Size(0, 25);
            lblSolicitud.TabIndex = 5;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Font = new Font("Segoe UI Semibold", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCodigo.Location = new Point(110, 43);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(96, 47);
            lblCodigo.TabIndex = 4;
            lblCodigo.Text = "0000";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 137);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 3;
            label5.Text = "Asunto:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 104);
            label4.Name = "label4";
            label4.Size = new Size(81, 15);
            label4.TabIndex = 2;
            label4.Text = "Tipo solicitud:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 28);
            label3.Name = "label3";
            label3.Size = new Size(113, 15);
            label3.TabIndex = 1;
            label3.Text = "Codigo de solicitud:";
            // 
            // lblPersona
            // 
            lblPersona.AutoSize = true;
            lblPersona.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPersona.Location = new Point(21, 203);
            lblPersona.Name = "lblPersona";
            lblPersona.Size = new Size(85, 21);
            lblPersona.TabIndex = 0;
            lblPersona.Text = "Solicitante:";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top;
            button1.BackColor = Color.Black;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Leelawadee", 9.75F);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(174, 31);
            button1.Name = "button1";
            button1.Size = new Size(103, 48);
            button1.TabIndex = 38;
            button1.Text = "SALIR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // gbSalir
            // 
            gbSalir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            gbSalir.Controls.Add(btnActualizar);
            gbSalir.Controls.Add(button1);
            gbSalir.Location = new Point(829, 680);
            gbSalir.Name = "gbSalir";
            gbSalir.Size = new Size(344, 96);
            gbSalir.TabIndex = 39;
            gbSalir.TabStop = false;
            gbSalir.Text = "Controles";
            // 
            // btnActualizar
            // 
            btnActualizar.Anchor = AnchorStyles.Top;
            btnActualizar.BackColor = Color.Black;
            btnActualizar.FlatAppearance.BorderSize = 0;
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.Font = new Font("Leelawadee", 9.75F);
            btnActualizar.ForeColor = SystemColors.ControlLightLight;
            btnActualizar.Location = new Point(65, 31);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(103, 48);
            btnActualizar.TabIndex = 39;
            btnActualizar.Text = "ACTUALIZAR";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // dtgSolicEnviadas
            // 
            dtgSolicEnviadas.AllowUserToAddRows = false;
            dtgSolicEnviadas.AllowUserToDeleteRows = false;
            dtgSolicEnviadas.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtgSolicEnviadas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgSolicEnviadas.Columns.AddRange(new DataGridViewColumn[] { codSolicitud, codSolicitante, tipoAsunto, estado, foto, tipoSolic, codSupervisor, nomape, desc_solic, desc_asunto, desc_estado, desc_content });
            dtgSolicEnviadas.Location = new Point(31, 95);
            dtgSolicEnviadas.Name = "dtgSolicEnviadas";
            dtgSolicEnviadas.ReadOnly = true;
            dtgSolicEnviadas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgSolicEnviadas.Size = new Size(772, 380);
            dtgSolicEnviadas.TabIndex = 40;
            dtgSolicEnviadas.CellClick += dtgSolicEnviadas_CellClick;
            // 
            // codSolicitud
            // 
            codSolicitud.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            codSolicitud.DataPropertyName = "codSolicitud";
            codSolicitud.HeaderText = "Codigo";
            codSolicitud.Name = "codSolicitud";
            codSolicitud.ReadOnly = true;
            codSolicitud.Width = 71;
            // 
            // codSolicitante
            // 
            codSolicitante.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            codSolicitante.DataPropertyName = "codSolicitante";
            codSolicitante.HeaderText = "Solicitante";
            codSolicitante.Name = "codSolicitante";
            codSolicitante.ReadOnly = true;
            codSolicitante.Visible = false;
            // 
            // tipoAsunto
            // 
            tipoAsunto.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tipoAsunto.DataPropertyName = "tipoAsunto";
            tipoAsunto.HeaderText = "Tipo Asunto";
            tipoAsunto.Name = "tipoAsunto";
            tipoAsunto.ReadOnly = true;
            tipoAsunto.Visible = false;
            // 
            // estado
            // 
            estado.DataPropertyName = "estado";
            estado.HeaderText = "Estado N";
            estado.Name = "estado";
            estado.ReadOnly = true;
            estado.Visible = false;
            // 
            // foto
            // 
            foto.DataPropertyName = "foto";
            foto.HeaderText = "Foto";
            foto.Name = "foto";
            foto.ReadOnly = true;
            foto.Visible = false;
            // 
            // tipoSolic
            // 
            tipoSolic.DataPropertyName = "tipoSolic";
            tipoSolic.HeaderText = "Tipo Solicitud";
            tipoSolic.Name = "tipoSolic";
            tipoSolic.ReadOnly = true;
            tipoSolic.Visible = false;
            // 
            // codSupervisor
            // 
            codSupervisor.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            codSupervisor.DataPropertyName = "codSupervisor";
            codSupervisor.HeaderText = "Destinatario";
            codSupervisor.Name = "codSupervisor";
            codSupervisor.ReadOnly = true;
            // 
            // nomape
            // 
            nomape.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nomape.DataPropertyName = "nomape";
            nomape.HeaderText = "Apellidos y Nombres";
            nomape.Name = "nomape";
            nomape.ReadOnly = true;
            // 
            // desc_solic
            // 
            desc_solic.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            desc_solic.DataPropertyName = "desc_solic";
            desc_solic.HeaderText = "Solicitud";
            desc_solic.Name = "desc_solic";
            desc_solic.ReadOnly = true;
            // 
            // desc_asunto
            // 
            desc_asunto.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            desc_asunto.DataPropertyName = "desc_asunto";
            desc_asunto.HeaderText = "Asunto";
            desc_asunto.Name = "desc_asunto";
            desc_asunto.ReadOnly = true;
            // 
            // desc_estado
            // 
            desc_estado.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            desc_estado.DataPropertyName = "desc_estado";
            desc_estado.HeaderText = "Estado";
            desc_estado.Name = "desc_estado";
            desc_estado.ReadOnly = true;
            // 
            // desc_content
            // 
            desc_content.DataPropertyName = "desc_content";
            desc_content.HeaderText = "Contenido";
            desc_content.Name = "desc_content";
            desc_content.ReadOnly = true;
            desc_content.Visible = false;
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Location = new Point(31, 67);
            lbl.Name = "lbl";
            lbl.Size = new Size(113, 15);
            lbl.TabIndex = 41;
            lbl.Text = "Solicitudes Enviadas";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(31, 482);
            label8.Name = "label8";
            label8.Size = new Size(117, 15);
            label8.TabIndex = 42;
            label8.Text = "Solicitudes Recibidas";
            // 
            // dtgSolicRecibidas
            // 
            dtgSolicRecibidas.AllowUserToAddRows = false;
            dtgSolicRecibidas.AllowUserToDeleteRows = false;
            dtgSolicRecibidas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgSolicRecibidas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgSolicRecibidas.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8, dataGridViewTextBoxColumn9, dataGridViewTextBoxColumn10, dataGridViewTextBoxColumn11, dataGridViewTextBoxColumn12 });
            dtgSolicRecibidas.Location = new Point(31, 510);
            dtgSolicRecibidas.Name = "dtgSolicRecibidas";
            dtgSolicRecibidas.ReadOnly = true;
            dtgSolicRecibidas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgSolicRecibidas.Size = new Size(772, 380);
            dtgSolicRecibidas.TabIndex = 43;
            dtgSolicRecibidas.CellClick += dtgSolicRecibidas_CellClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewTextBoxColumn1.DataPropertyName = "codSolicitud";
            dataGridViewTextBoxColumn1.HeaderText = "Codigo";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 71;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn2.DataPropertyName = "codSolicitante";
            dataGridViewTextBoxColumn2.HeaderText = "Solicitante";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn3.DataPropertyName = "tipoAsunto";
            dataGridViewTextBoxColumn3.HeaderText = "Tipo Asunto";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "estado";
            dataGridViewTextBoxColumn4.HeaderText = "Estado N";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "foto";
            dataGridViewTextBoxColumn5.HeaderText = "Foto";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.DataPropertyName = "tipoSolic";
            dataGridViewTextBoxColumn6.HeaderText = "Tipo Solicitud";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            dataGridViewTextBoxColumn6.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn7.DataPropertyName = "codSupervisor";
            dataGridViewTextBoxColumn7.HeaderText = "Destinatario";
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            dataGridViewTextBoxColumn7.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn8.DataPropertyName = "nomape";
            dataGridViewTextBoxColumn8.HeaderText = "Apellidos y Nombres";
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn9.DataPropertyName = "desc_solic";
            dataGridViewTextBoxColumn9.HeaderText = "Solicitud";
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            dataGridViewTextBoxColumn10.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn10.DataPropertyName = "desc_asunto";
            dataGridViewTextBoxColumn10.HeaderText = "Asunto";
            dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            dataGridViewTextBoxColumn11.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn11.DataPropertyName = "desc_estado";
            dataGridViewTextBoxColumn11.HeaderText = "Estado";
            dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            dataGridViewTextBoxColumn12.DataPropertyName = "desc_content";
            dataGridViewTextBoxColumn12.HeaderText = "Contenido";
            dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            dataGridViewTextBoxColumn12.ReadOnly = true;
            dataGridViewTextBoxColumn12.Visible = false;
            // 
            // SolicitudAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1197, 924);
            Controls.Add(dtgSolicRecibidas);
            Controls.Add(label8);
            Controls.Add(lbl);
            Controls.Add(dtgSolicEnviadas);
            Controls.Add(gbSalir);
            Controls.Add(gbInfo);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SolicitudAdmin";
            Text = "Solicitudes";
            WindowState = FormWindowState.Maximized;
            Load += SolicitudAdmin_Load;
            gbInfo.ResumeLayout(false);
            gbInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgFoto).EndInit();
            gbSalir.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgSolicEnviadas).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgSolicRecibidas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox gbInfo;
        private Label label3;
        private Label lblPersona;
        private Label label7;
        private Label lblAsunto;
        private Label lblSolicitud;
        private Label lblCodigo;
        private Label label5;
        private Label label4;
        private Label lblEstado;
        private Label label19;
        private TextBox txtCodFind;
        private TextBox txtApeNomFind;
        private Label label18;
        private Label label17;
        private PictureBox imgFoto;
        private Button btnVisualizar;
        private Button button1;
        private GroupBox gbSalir;
        private DataGridView dtgSolicEnviadas;
        private Label lbl;
        private Label label8;
        private Button btnActualizar;
        private DataGridViewTextBoxColumn codSolicitud;
        private DataGridViewTextBoxColumn codSolicitante;
        private DataGridViewTextBoxColumn tipoAsunto;
        private DataGridViewTextBoxColumn estado;
        private DataGridViewTextBoxColumn foto;
        private DataGridViewTextBoxColumn tipoSolic;
        private DataGridViewTextBoxColumn codSupervisor;
        private DataGridViewTextBoxColumn nomape;
        private DataGridViewTextBoxColumn desc_solic;
        private DataGridViewTextBoxColumn desc_asunto;
        private DataGridViewTextBoxColumn desc_estado;
        private DataGridViewTextBoxColumn desc_content;
        private DataGridView dtgSolicRecibidas;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
    }
}