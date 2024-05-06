namespace ProyBROL_GUI
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pnFormLogin = new Panel();
            label5 = new Label();
            btnLogin = new Button();
            txtPassUser = new TextBox();
            label4 = new Label();
            txtNomUser = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            imgExit = new PictureBox();
            imgLogo = new PictureBox();
            pnFormLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgExit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgLogo).BeginInit();
            SuspendLayout();
            // 
            // pnFormLogin
            // 
            pnFormLogin.BackColor = Color.FromArgb(38, 68, 57);
            pnFormLogin.Controls.Add(label5);
            pnFormLogin.Controls.Add(btnLogin);
            pnFormLogin.Controls.Add(txtPassUser);
            pnFormLogin.Controls.Add(label4);
            pnFormLogin.Controls.Add(txtNomUser);
            pnFormLogin.Controls.Add(label3);
            pnFormLogin.Controls.Add(label2);
            pnFormLogin.Controls.Add(label1);
            pnFormLogin.Controls.Add(imgExit);
            pnFormLogin.Dock = DockStyle.Right;
            pnFormLogin.Location = new Point(191, 0);
            pnFormLogin.Name = "pnFormLogin";
            pnFormLogin.Size = new Size(309, 490);
            pnFormLogin.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ControlLight;
            label5.Location = new Point(21, 449);
            label5.Name = "label5";
            label5.Size = new Size(202, 15);
            label5.TabIndex = 8;
            label5.Text = "Usuario y contraseña de test \"admin\"";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(81, 145, 121);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Leelawadee", 9.75F);
            btnLogin.ForeColor = SystemColors.ControlLightLight;
            btnLogin.Location = new Point(21, 324);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(227, 41);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "Iniciar Sesión";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassUser
            // 
            txtPassUser.Location = new Point(21, 269);
            txtPassUser.Name = "txtPassUser";
            txtPassUser.Size = new Size(227, 23);
            txtPassUser.TabIndex = 6;
            txtPassUser.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Leelawadee", 9F);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(21, 243);
            label4.Name = "label4";
            label4.Size = new Size(109, 14);
            label4.TabIndex = 5;
            label4.Text = "Ingrese contraseña:";
            // 
            // txtNomUser
            // 
            txtNomUser.Location = new Point(21, 206);
            txtNomUser.Name = "txtNomUser";
            txtNomUser.Size = new Size(227, 23);
            txtNomUser.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Leelawadee", 9F);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(21, 180);
            label3.Name = "label3";
            label3.Size = new Size(150, 14);
            label3.TabIndex = 3;
            label3.Text = "Ingrese nombre de usuario:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Leelawadee", 9.75F);
            label2.ForeColor = SystemColors.ControlLight;
            label2.Location = new Point(21, 144);
            label2.Name = "label2";
            label2.Size = new Size(227, 15);
            label2.TabIndex = 2;
            label2.Text = "Por favor inicie sesión para conitnuar.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Leelawadee", 21.75F);
            label1.ForeColor = SystemColors.HighlightText;
            label1.Location = new Point(21, 100);
            label1.Name = "label1";
            label1.Size = new Size(213, 35);
            label1.TabIndex = 1;
            label1.Text = "Inicio de Sesión";
            // 
            // imgExit
            // 
            imgExit.Cursor = Cursors.Hand;
            imgExit.Image = Properties.Resources.xpng;
            imgExit.Location = new Point(277, 12);
            imgExit.Name = "imgExit";
            imgExit.Size = new Size(20, 20);
            imgExit.SizeMode = PictureBoxSizeMode.StretchImage;
            imgExit.TabIndex = 0;
            imgExit.TabStop = false;
            imgExit.Click += imgExit_Click;
            // 
            // imgLogo
            // 
            imgLogo.Image = Properties.Resources.logoBROL;
            imgLogo.Location = new Point(36, 81);
            imgLogo.Name = "imgLogo";
            imgLogo.Size = new Size(123, 113);
            imgLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            imgLogo.TabIndex = 3;
            imgLogo.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 490);
            Controls.Add(imgLogo);
            Controls.Add(pnFormLogin);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(500, 490);
            MinimumSize = new Size(500, 490);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BROL System";
            pnFormLogin.ResumeLayout(false);
            pnFormLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgExit).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnFormLogin;
        private Label label5;
        private Button btnLogin;
        private TextBox txtPassUser;
        private Label label4;
        private TextBox txtNomUser;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox imgExit;
        private PictureBox imgLogo;
    }
}