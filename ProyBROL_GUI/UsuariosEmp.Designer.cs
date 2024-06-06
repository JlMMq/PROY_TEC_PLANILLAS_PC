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
            textBox4 = new TextBox();
            label6 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            label3 = new Label();
            txtCorreo = new TextBox();
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
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(367, 263);
            groupBox2.MaximumSize = new Size(370, 239);
            groupBox2.MinimumSize = new Size(370, 239);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(370, 239);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Cambiar contraseña";
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Location = new Point(27, 175);
            textBox4.Name = "textBox4";
            textBox4.PasswordChar = '*';
            textBox4.Size = new Size(317, 23);
            textBox4.TabIndex = 17;
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
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Location = new Point(27, 120);
            textBox3.Name = "textBox3";
            textBox3.PasswordChar = '*';
            textBox3.Size = new Size(317, 23);
            textBox3.TabIndex = 15;
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
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(27, 63);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(317, 23);
            textBox2.TabIndex = 13;
            textBox2.TextChanged += textBox2_TextChanged;
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
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(367, 75);
            label2.Name = "label2";
            label2.Size = new Size(242, 21);
            label2.TabIndex = 14;
            label2.Text = "Bienvenido Nombres Apellidos!";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top;
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtCorreo);
            groupBox1.Controls.Add(label7);
            groupBox1.Location = new Point(367, 109);
            groupBox1.MaximumSize = new Size(370, 132);
            groupBox1.MinimumSize = new Size(370, 132);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(370, 132);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cambiar correo electronico";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(27, 94);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(317, 23);
            textBox1.TabIndex = 12;
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
            // txtCorreo
            // 
            txtCorreo.BorderStyle = BorderStyle.FixedSingle;
            txtCorreo.Enabled = false;
            txtCorreo.Location = new Point(27, 43);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(317, 23);
            txtCorreo.TabIndex = 10;
            txtCorreo.Text = "correoprueba@gmail.com";
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
            btnModificar.Location = new Point(564, 518);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(173, 48);
            btnModificar.TabIndex = 19;
            btnModificar.Text = "GUARDAR CAMBIOS";
            btnModificar.UseVisualStyleBackColor = false;
            // 
            // UsuariosEmp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1157, 670);
            Controls.Add(btnModificar);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(groupBox2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "UsuariosEmp";
            Text = "Usuarios";
            WindowState = FormWindowState.Maximized;
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
        private Label label2;
        private GroupBox groupBox1;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox1;
        private Label label3;
        private TextBox txtCorreo;
        private Label label7;
        private TextBox textBox4;
        private Label label6;
        private TextBox textBox3;
        private Label label5;
        private Button btnModificar;
    }
}