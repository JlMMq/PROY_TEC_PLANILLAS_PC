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
            dtgSolicGen = new DataGridView();
            gbInfo = new GroupBox();
            btnVisualizar = new Button();
            label19 = new Label();
            txtCodFind = new TextBox();
            txtApeNomFind = new TextBox();
            label18 = new Label();
            label17 = new Label();
            imgFoto = new PictureBox();
            label2 = new Label();
            label7 = new Label();
            label6 = new Label();
            lblSolicitud = new Label();
            lblCodigo = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            lblPersona = new Label();
            button1 = new Button();
            gbSalir = new GroupBox();
            btnActualizar = new Button();
            dtgSolicPer = new DataGridView();
            lblPersonal = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgSolicGen).BeginInit();
            gbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgFoto).BeginInit();
            gbSalir.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgSolicPer).BeginInit();
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
            // dtgSolicGen
            // 
            dtgSolicGen.AllowUserToAddRows = false;
            dtgSolicGen.AllowUserToDeleteRows = false;
            dtgSolicGen.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgSolicGen.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgSolicGen.Location = new Point(31, 511);
            dtgSolicGen.Name = "dtgSolicGen";
            dtgSolicGen.ReadOnly = true;
            dtgSolicGen.Size = new Size(772, 377);
            dtgSolicGen.TabIndex = 6;
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
            gbInfo.Controls.Add(label2);
            gbInfo.Controls.Add(label7);
            gbInfo.Controls.Add(label6);
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(110, 160);
            label2.Name = "label2";
            label2.Size = new Size(113, 25);
            label2.TabIndex = 8;
            label2.Text = "PENDIENTE";
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
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(110, 129);
            label6.Name = "label6";
            label6.Size = new Size(86, 25);
            label6.TabIndex = 6;
            label6.Text = "ASUNTO";
            // 
            // lblSolicitud
            // 
            lblSolicitud.AutoSize = true;
            lblSolicitud.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSolicitud.Location = new Point(110, 99);
            lblSolicitud.Name = "lblSolicitud";
            lblSolicitud.Size = new Size(106, 25);
            lblSolicitud.TabIndex = 5;
            lblSolicitud.Text = "SOLICITUD";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Font = new Font("Segoe UI Semibold", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCodigo.Location = new Point(97, 43);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(134, 47);
            lblCodigo.TabIndex = 4;
            lblCodigo.Text = "000000";
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
            // 
            // dtgSolicPer
            // 
            dtgSolicPer.AllowUserToAddRows = false;
            dtgSolicPer.AllowUserToDeleteRows = false;
            dtgSolicPer.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtgSolicPer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgSolicPer.Location = new Point(31, 90);
            dtgSolicPer.Name = "dtgSolicPer";
            dtgSolicPer.ReadOnly = true;
            dtgSolicPer.Size = new Size(772, 380);
            dtgSolicPer.TabIndex = 40;
            // 
            // lblPersonal
            // 
            lblPersonal.AutoSize = true;
            lblPersonal.Location = new Point(31, 67);
            lblPersonal.Name = "lblPersonal";
            lblPersonal.Size = new Size(113, 15);
            lblPersonal.TabIndex = 41;
            lblPersonal.Text = "Solicitudes Enviadas";
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
            // SolicitudAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1197, 924);
            Controls.Add(label8);
            Controls.Add(lblPersonal);
            Controls.Add(dtgSolicPer);
            Controls.Add(gbSalir);
            Controls.Add(gbInfo);
            Controls.Add(dtgSolicGen);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SolicitudAdmin";
            Text = "Solicitudes";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dtgSolicGen).EndInit();
            gbInfo.ResumeLayout(false);
            gbInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgFoto).EndInit();
            gbSalir.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgSolicPer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dtgSolicGen;
        private GroupBox gbInfo;
        private Label label3;
        private Label lblPersona;
        private Label label7;
        private Label label6;
        private Label lblSolicitud;
        private Label lblCodigo;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label19;
        private TextBox txtCodFind;
        private TextBox txtApeNomFind;
        private Label label18;
        private Label label17;
        private PictureBox imgFoto;
        private Button btnVisualizar;
        private Button button1;
        private GroupBox gbSalir;
        private DataGridView dtgSolicPer;
        private Label lblPersonal;
        private Label label8;
        private Button btnActualizar;
    }
}