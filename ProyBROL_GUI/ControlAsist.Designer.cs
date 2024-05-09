namespace ProyBROL_GUI
{
    partial class ControlAsist
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlAsist));
            gpControl = new GroupBox();
            btnSald = new Button();
            btnIngRefr = new Button();
            btnSalRefr = new Button();
            label11 = new Label();
            btnIngr = new Button();
            label2 = new Label();
            txtCodigo = new TextBox();
            lblHoraDes = new Label();
            lblHora = new Label();
            gpInfor = new GroupBox();
            lblMensaje = new Label();
            label10 = new Label();
            lblSituac = new Label();
            label9 = new Label();
            lblMarca = new Label();
            label8 = new Label();
            label7 = new Label();
            imgEmpl = new PictureBox();
            txtNumDoc = new TextBox();
            label6 = new Label();
            txtDocm = new TextBox();
            label5 = new Label();
            txtCodOut = new TextBox();
            label4 = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            label1 = new Label();
            label3 = new Label();
            dtTimer = new System.Windows.Forms.Timer(components);
            imgbtnLogin = new PictureBox();
            label12 = new Label();
            gpControl.SuspendLayout();
            gpInfor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgEmpl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgbtnLogin).BeginInit();
            SuspendLayout();
            // 
            // gpControl
            // 
            gpControl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gpControl.Controls.Add(btnSald);
            gpControl.Controls.Add(btnIngRefr);
            gpControl.Controls.Add(btnSalRefr);
            gpControl.Controls.Add(label11);
            gpControl.Controls.Add(btnIngr);
            gpControl.Controls.Add(label2);
            gpControl.Controls.Add(txtCodigo);
            gpControl.Font = new Font("Leelawadee", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gpControl.Location = new Point(30, 26);
            gpControl.Name = "gpControl";
            gpControl.Size = new Size(779, 285);
            gpControl.TabIndex = 2;
            gpControl.TabStop = false;
            gpControl.Text = "Control de Marcas";
            // 
            // btnSald
            // 
            btnSald.BackColor = SystemColors.ActiveCaptionText;
            btnSald.FlatAppearance.BorderSize = 0;
            btnSald.FlatStyle = FlatStyle.Flat;
            btnSald.Font = new Font("Leelawadee", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSald.ForeColor = SystemColors.ControlLightLight;
            btnSald.Location = new Point(555, 190);
            btnSald.Name = "btnSald";
            btnSald.Size = new Size(165, 70);
            btnSald.TabIndex = 6;
            btnSald.Text = "SALIDA";
            btnSald.UseVisualStyleBackColor = false;
            btnSald.Click += btnSald_Click;
            // 
            // btnIngRefr
            // 
            btnIngRefr.BackColor = SystemColors.ActiveCaptionText;
            btnIngRefr.FlatAppearance.BorderSize = 0;
            btnIngRefr.FlatStyle = FlatStyle.Flat;
            btnIngRefr.Font = new Font("Leelawadee", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIngRefr.ForeColor = SystemColors.ControlLightLight;
            btnIngRefr.Location = new Point(384, 190);
            btnIngRefr.Name = "btnIngRefr";
            btnIngRefr.Size = new Size(165, 70);
            btnIngRefr.TabIndex = 5;
            btnIngRefr.Text = "INGRESO REFRIGERIO";
            btnIngRefr.UseVisualStyleBackColor = false;
            btnIngRefr.Click += btnIngRefr_Click;
            // 
            // btnSalRefr
            // 
            btnSalRefr.BackColor = SystemColors.ActiveCaptionText;
            btnSalRefr.FlatAppearance.BorderSize = 0;
            btnSalRefr.FlatStyle = FlatStyle.Flat;
            btnSalRefr.Font = new Font("Leelawadee", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalRefr.ForeColor = SystemColors.ControlLightLight;
            btnSalRefr.Location = new Point(213, 190);
            btnSalRefr.Name = "btnSalRefr";
            btnSalRefr.Size = new Size(165, 71);
            btnSalRefr.TabIndex = 4;
            btnSalRefr.Text = "SALIDA REFRIGERIO";
            btnSalRefr.UseVisualStyleBackColor = false;
            btnSalRefr.Click += btnSalRefr_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Leelawadee", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.ControlDarkDark;
            label11.Location = new Point(38, 155);
            label11.Name = "label11";
            label11.Size = new Size(149, 25);
            label11.TabIndex = 3;
            label11.Text = "Tipo de marca:";
            // 
            // btnIngr
            // 
            btnIngr.BackColor = Color.Black;
            btnIngr.FlatAppearance.BorderSize = 0;
            btnIngr.FlatStyle = FlatStyle.Flat;
            btnIngr.Font = new Font("Leelawadee", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIngr.ForeColor = SystemColors.ControlLightLight;
            btnIngr.Location = new Point(42, 190);
            btnIngr.Name = "btnIngr";
            btnIngr.Size = new Size(165, 70);
            btnIngr.TabIndex = 2;
            btnIngr.Text = "INGRESO";
            btnIngr.UseVisualStyleBackColor = false;
            btnIngr.Click += btnIngr_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Leelawadee", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(38, 61);
            label2.Name = "label2";
            label2.Size = new Size(495, 29);
            label2.TabIndex = 0;
            label2.Text = "Ingrese el codigo o documento de identidad:";
            // 
            // txtCodigo
            // 
            txtCodigo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCodigo.BorderStyle = BorderStyle.FixedSingle;
            txtCodigo.Font = new Font("Leelawadee", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCodigo.Location = new Point(42, 103);
            txtCodigo.MaxLength = 15;
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(678, 49);
            txtCodigo.TabIndex = 1;
            txtCodigo.KeyPress += txtCodigo_KeyPress;
            // 
            // lblHoraDes
            // 
            lblHoraDes.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblHoraDes.AutoSize = true;
            lblHoraDes.Font = new Font("Tahoma", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHoraDes.ForeColor = SystemColors.ControlDarkDark;
            lblHoraDes.Location = new Point(926, 260);
            lblHoraDes.Name = "lblHoraDes";
            lblHoraDes.Size = new Size(191, 42);
            lblHoraDes.TabIndex = 3;
            lblHoraDes.Text = "NA NA NA";
            // 
            // lblHora
            // 
            lblHora.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblHora.AutoSize = true;
            lblHora.BackColor = Color.Transparent;
            lblHora.Font = new Font("Unispace", 99.7499847F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHora.Location = new Point(837, 101);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(715, 159);
            lblHora.TabIndex = 4;
            lblHora.Text = "00:00:00";
            // 
            // gpInfor
            // 
            gpInfor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gpInfor.Controls.Add(lblMensaje);
            gpInfor.Controls.Add(label10);
            gpInfor.Controls.Add(lblSituac);
            gpInfor.Controls.Add(label9);
            gpInfor.Controls.Add(lblMarca);
            gpInfor.Controls.Add(label8);
            gpInfor.Controls.Add(label7);
            gpInfor.Controls.Add(imgEmpl);
            gpInfor.Controls.Add(txtNumDoc);
            gpInfor.Controls.Add(label6);
            gpInfor.Controls.Add(txtDocm);
            gpInfor.Controls.Add(label5);
            gpInfor.Controls.Add(txtCodOut);
            gpInfor.Controls.Add(label4);
            gpInfor.Controls.Add(txtNombre);
            gpInfor.Controls.Add(lblNombre);
            gpInfor.Controls.Add(label1);
            gpInfor.Controls.Add(label3);
            gpInfor.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gpInfor.Location = new Point(30, 334);
            gpInfor.Name = "gpInfor";
            gpInfor.Size = new Size(1522, 581);
            gpInfor.TabIndex = 5;
            gpInfor.TabStop = false;
            gpInfor.Text = "Informacion Empleado";
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Font = new Font("Leelawadee", 11.25F);
            lblMensaje.Location = new Point(38, 518);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(0, 18);
            lblMensaje.TabIndex = 19;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = SystemColors.ControlDarkDark;
            label10.Location = new Point(26, 468);
            label10.Name = "label10";
            label10.Size = new Size(122, 37);
            label10.TabIndex = 18;
            label10.Text = "Mensaje:";
            // 
            // lblSituac
            // 
            lblSituac.AutoSize = true;
            lblSituac.Font = new Font("Unispace", 20.2499981F, FontStyle.Bold);
            lblSituac.Location = new Point(461, 358);
            lblSituac.Name = "lblSituac";
            lblSituac.Size = new Size(0, 33);
            lblSituac.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = SystemColors.ControlDarkDark;
            label9.Location = new Point(461, 314);
            label9.Name = "label9";
            label9.Size = new Size(249, 37);
            label9.TabIndex = 16;
            label9.Text = "Situacion de Marca:";
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Font = new Font("Unispace", 47.9999924F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMarca.Location = new Point(26, 368);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(345, 77);
            lblMarca.TabIndex = 15;
            lblMarca.Text = "00:00:00";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = SystemColors.ControlDarkDark;
            label8.Location = new Point(20, 314);
            label8.Name = "label8";
            label8.Size = new Size(309, 37);
            label8.TabIndex = 14;
            label8.Text = "Hora de marca rgistrada:";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(1102, 39);
            label7.Name = "label7";
            label7.Size = new Size(77, 37);
            label7.TabIndex = 13;
            label7.Text = "Foto:";
            // 
            // imgEmpl
            // 
            imgEmpl.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            imgEmpl.BorderStyle = BorderStyle.FixedSingle;
            imgEmpl.Image = Properties.Resources.noimage;
            imgEmpl.Location = new Point(1112, 88);
            imgEmpl.Name = "imgEmpl";
            imgEmpl.Size = new Size(388, 435);
            imgEmpl.SizeMode = PictureBoxSizeMode.StretchImage;
            imgEmpl.TabIndex = 12;
            imgEmpl.TabStop = false;
            // 
            // txtNumDoc
            // 
            txtNumDoc.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNumDoc.BorderStyle = BorderStyle.FixedSingle;
            txtNumDoc.Location = new Point(246, 241);
            txtNumDoc.Name = "txtNumDoc";
            txtNumDoc.ReadOnly = true;
            txtNumDoc.Size = new Size(841, 43);
            txtNumDoc.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ControlDarkDark;
            label6.Location = new Point(20, 243);
            label6.Name = "label6";
            label6.Size = new Size(220, 37);
            label6.TabIndex = 6;
            label6.Text = "Nro. Documento:";
            // 
            // txtDocm
            // 
            txtDocm.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDocm.BorderStyle = BorderStyle.FixedSingle;
            txtDocm.Location = new Point(694, 174);
            txtDocm.Name = "txtDocm";
            txtDocm.ReadOnly = true;
            txtDocm.Size = new Size(393, 43);
            txtDocm.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ControlDarkDark;
            label5.Location = new Point(429, 176);
            label5.Name = "label5";
            label5.Size = new Size(259, 37);
            label5.TabIndex = 7;
            label5.Text = "Tipo de Documento:";
            // 
            // txtCodOut
            // 
            txtCodOut.BorderStyle = BorderStyle.FixedSingle;
            txtCodOut.Location = new Point(151, 174);
            txtCodOut.Name = "txtCodOut";
            txtCodOut.ReadOnly = true;
            txtCodOut.Size = new Size(272, 43);
            txtCodOut.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(20, 176);
            label4.Name = "label4";
            label4.Size = new Size(125, 37);
            label4.TabIndex = 4;
            label4.Text = "Codigo : ";
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Location = new Point(26, 107);
            txtNombre.Name = "txtNombre";
            txtNombre.ReadOnly = true;
            txtNombre.Size = new Size(1061, 43);
            txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(20, 58);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(0, 37);
            lblNombre.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(20, 58);
            label1.Name = "label1";
            label1.Size = new Size(265, 37);
            label1.TabIndex = 0;
            label1.Text = "Apellidos y nombres:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 69);
            label3.Name = "label3";
            label3.Size = new Size(0, 37);
            label3.TabIndex = 3;
            // 
            // dtTimer
            // 
            dtTimer.Enabled = true;
            dtTimer.Tick += dtTimer_Tick;
            // 
            // imgbtnLogin
            // 
            imgbtnLogin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            imgbtnLogin.Cursor = Cursors.Hand;
            imgbtnLogin.Image = Properties.Resources.acceso;
            imgbtnLogin.Location = new Point(1512, 16);
            imgbtnLogin.Name = "imgbtnLogin";
            imgbtnLogin.Size = new Size(60, 56);
            imgbtnLogin.SizeMode = PictureBoxSizeMode.StretchImage;
            imgbtnLogin.TabIndex = 6;
            imgbtnLogin.TabStop = false;
            imgbtnLogin.Click += imgbtnLogin_Click;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(1510, 71);
            label12.Name = "label12";
            label12.Size = new Size(70, 21);
            label12.TabIndex = 7;
            label12.Text = "Ingresar";
            // 
            // ControlAsist
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1604, 941);
            Controls.Add(label12);
            Controls.Add(imgbtnLogin);
            Controls.Add(gpInfor);
            Controls.Add(lblHoraDes);
            Controls.Add(lblHora);
            Controls.Add(gpControl);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ControlAsist";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Control de marcas";
            WindowState = FormWindowState.Maximized;
            gpControl.ResumeLayout(false);
            gpControl.PerformLayout();
            gpInfor.ResumeLayout(false);
            gpInfor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgEmpl).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgbtnLogin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gpControl;
        private Button btnSald;
        private Button btnIngRefr;
        private Button btnSalRefr;
        private Label label11;
        private Button btnIngr;
        private Label label2;
        private TextBox txtCodigo;
        private Label lblHoraDes;
        private Label lblHora;
        private GroupBox gpInfor;
        private Label lblMensaje;
        private Label label10;
        private Label lblSituac;
        private Label label9;
        private Label lblMarca;
        private Label label8;
        private Label label7;
        private PictureBox imgEmpl;
        private TextBox txtNumDoc;
        private Label label6;
        private TextBox txtDocm;
        private Label label5;
        private TextBox txtCodOut;
        private Label label4;
        private TextBox txtNombre;
        private Label lblNombre;
        private Label label1;
        private Label label3;
        private System.Windows.Forms.Timer dtTimer;
        private PictureBox imgbtnLogin;
        private Label label12;
    }
}