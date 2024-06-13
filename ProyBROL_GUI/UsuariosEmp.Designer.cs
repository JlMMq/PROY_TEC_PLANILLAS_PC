namespace ProyBROL_GUI
{
    partial class UsuariosEmp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsuariosEmp));
            label1 = new Label();
            groupBox2 = new GroupBox();
            lblPassStatus = new Label();
            txtNewPass2 = new TextBox();
            label6 = new Label();
            txtNewPass1 = new TextBox();
            label5 = new Label();
            txtOldPassword = new TextBox();
            label4 = new Label();
            lblBienven = new Label();
            groupBox1 = new GroupBox();
            lblCorreoStatus = new Label();
            txtCorreoNew = new TextBox();
            label3 = new Label();
            txtCorreoIn = new TextBox();
            label7 = new Label();
            btnModificar = new Button();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Leelawadee", 15.75F);
            label1.Location = new Point(23, 21);
            label1.Name = "label1";
            label1.Size = new Size(187, 25);
            label1.TabIndex = 3;
            label1.Text = "Gestion de Usuario";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top;
            groupBox2.Controls.Add(lblPassStatus);
            groupBox2.Controls.Add(txtNewPass2);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtNewPass1);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtOldPassword);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(367, 287);
            groupBox2.MaximumSize = new Size(370, 239);
            groupBox2.MinimumSize = new Size(370, 239);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(370, 239);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Cambiar contraseña";
            // 
            // lblPassStatus
            // 
            lblPassStatus.AutoSize = true;
            lblPassStatus.Location = new Point(17, 212);
            lblPassStatus.Name = "lblPassStatus";
            lblPassStatus.Size = new Size(0, 15);
            lblPassStatus.TabIndex = 18;
            // 
            // txtNewPass2
            // 
            txtNewPass2.BorderStyle = BorderStyle.FixedSingle;
            txtNewPass2.Location = new Point(27, 175);
            txtNewPass2.Name = "txtNewPass2";
            txtNewPass2.PasswordChar = '*';
            txtNewPass2.Size = new Size(317, 23);
            txtNewPass2.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 157);
            label6.Name = "label6";
            label6.Size = new Size(151, 15);
            label6.TabIndex = 16;
            label6.Text = "Repita la nueva contraseña:";
            // 
            // txtNewPass1
            // 
            txtNewPass1.BorderStyle = BorderStyle.FixedSingle;
            txtNewPass1.Location = new Point(27, 120);
            txtNewPass1.Name = "txtNewPass1";
            txtNewPass1.PasswordChar = '*';
            txtNewPass1.Size = new Size(317, 23);
            txtNewPass1.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 102);
            label5.Name = "label5";
            label5.Size = new Size(105, 15);
            label5.TabIndex = 14;
            label5.Text = "Nueva contraseña:";
            // 
            // txtOldPassword
            // 
            txtOldPassword.BorderStyle = BorderStyle.FixedSingle;
            txtOldPassword.Location = new Point(27, 63);
            txtOldPassword.Name = "txtOldPassword";
            txtOldPassword.PasswordChar = '*';
            txtOldPassword.Size = new Size(317, 23);
            txtOldPassword.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 40);
            label4.Name = "label4";
            label4.Size = new Size(144, 15);
            label4.TabIndex = 0;
            label4.Text = "Ingrese contraseña actual:";
            // 
            // lblBienven
            // 
            lblBienven.Anchor = AnchorStyles.Top;
            lblBienven.AutoEllipsis = true;
            lblBienven.AutoSize = true;
            lblBienven.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBienven.Location = new Point(367, 75);
            lblBienven.Name = "lblBienven";
            lblBienven.Size = new Size(242, 21);
            lblBienven.TabIndex = 14;
            lblBienven.Text = "Bienvenido Nombres Apellidos!";
            lblBienven.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top;
            groupBox1.Controls.Add(lblCorreoStatus);
            groupBox1.Controls.Add(txtCorreoNew);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtCorreoIn);
            groupBox1.Controls.Add(label7);
            groupBox1.Location = new Point(367, 109);
            groupBox1.MaximumSize = new Size(370, 150);
            groupBox1.MinimumSize = new Size(370, 150);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(370, 150);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cambiar correo electronico";
            // 
            // lblCorreoStatus
            // 
            lblCorreoStatus.AutoSize = true;
            lblCorreoStatus.Location = new Point(15, 126);
            lblCorreoStatus.Name = "lblCorreoStatus";
            lblCorreoStatus.Size = new Size(0, 15);
            lblCorreoStatus.TabIndex = 13;
            // 
            // txtCorreoNew
            // 
            txtCorreoNew.BorderStyle = BorderStyle.FixedSingle;
            txtCorreoNew.Location = new Point(27, 94);
            txtCorreoNew.Name = "txtCorreoNew";
            txtCorreoNew.Size = new Size(317, 23);
            txtCorreoNew.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 76);
            label3.Name = "label3";
            label3.Size = new Size(85, 15);
            label3.TabIndex = 11;
            label3.Text = "Nuevo correo: ";
            // 
            // txtCorreoIn
            // 
            txtCorreoIn.BorderStyle = BorderStyle.FixedSingle;
            txtCorreoIn.Enabled = false;
            txtCorreoIn.Location = new Point(27, 43);
            txtCorreoIn.Name = "txtCorreoIn";
            txtCorreoIn.Size = new Size(317, 23);
            txtCorreoIn.TabIndex = 10;
            txtCorreoIn.Text = "correoprueba@gmail.com";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(27, 25);
            label7.Name = "label7";
            label7.Size = new Size(84, 15);
            label7.TabIndex = 9;
            label7.Text = "Correo actual: ";
            // 
            // btnModificar
            // 
            btnModificar.Anchor = AnchorStyles.Top;
            btnModificar.BackColor = Color.Black;
            btnModificar.FlatAppearance.BorderSize = 0;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Leelawadee", 9.75F);
            btnModificar.ForeColor = SystemColors.ControlLightLight;
            btnModificar.Location = new Point(564, 541);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(173, 48);
            btnModificar.TabIndex = 19;
            btnModificar.Text = "GUARDAR CAMBIOS";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // UsuariosEmp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1157, 670);
            Controls.Add(btnModificar);
            Controls.Add(groupBox1);
            Controls.Add(lblBienven);
            Controls.Add(groupBox2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "UsuariosEmp";
            Text = "Usuarios";
            WindowState = FormWindowState.Maximized;
            Load += UsuariosEmp_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox2;
        private Label lblBienven;
        private GroupBox groupBox1;
        private TextBox txtOldPassword;
        private Label label4;
        private TextBox txtCorreoNew;
        private Label label3;
        private TextBox txtCorreoIn;
        private Label label7;
        private TextBox txtNewPass2;
        private Label label6;
        private TextBox txtNewPass1;
        private Label label5;
        private Button btnModificar;
        private Label lblPassStatus;
        private Label lblCorreoStatus;
    }
}