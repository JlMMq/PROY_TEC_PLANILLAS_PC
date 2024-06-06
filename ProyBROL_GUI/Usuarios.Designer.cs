namespace ProyBROL_GUI
{
    partial class Usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuarios));
            dataGridView1 = new DataGridView();
            Usuario = new DataGridViewTextBoxColumn();
            Correo = new DataGridViewTextBoxColumn();
            apellidos = new DataGridViewTextBoxColumn();
            nombres = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            label1 = new Label();
            groupBox1 = new GroupBox();
            label4 = new Label();
            txtFiltApellido = new TextBox();
            txtFiltNombre = new TextBox();
            label5 = new Label();
            txtFiltCodigo = new TextBox();
            label2 = new Label();
            groupBox2 = new GroupBox();
            btnModificar = new Button();
            label11 = new Label();
            label10 = new Label();
            dtpFecIngreso = new DateTimePicker();
            label9 = new Label();
            textBox2 = new TextBox();
            label8 = new Label();
            txtCorreo = new TextBox();
            label7 = new Label();
            textBox1 = new TextBox();
            txtCodUser = new TextBox();
            label6 = new Label();
            label3 = new Label();
            groupBox3 = new GroupBox();
            btnGestionPers = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Usuario, Correo, apellidos, nombres, Estado });
            dataGridView1.Location = new Point(21, 125);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(637, 601);
            dataGridView1.TabIndex = 0;
            // 
            // Usuario
            // 
            Usuario.HeaderText = "Usuario";
            Usuario.Name = "Usuario";
            // 
            // Correo
            // 
            Correo.HeaderText = "Correo";
            Correo.Name = "Correo";
            // 
            // apellidos
            // 
            apellidos.HeaderText = "Apellidos";
            apellidos.Name = "apellidos";
            // 
            // nombres
            // 
            nombres.HeaderText = "Nombres";
            nombres.Name = "nombres";
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.Name = "Estado";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Leelawadee", 15.75F);
            label1.Location = new Point(21, 20);
            label1.Name = "label1";
            label1.Size = new Size(91, 25);
            label1.TabIndex = 2;
            label1.Text = "Usuarios";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtFiltApellido);
            groupBox1.Controls.Add(txtFiltNombre);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtFiltCodigo);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(21, 58);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(637, 50);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Buscar usuario";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 19);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 5;
            label4.Text = "Codigo:";
            // 
            // txtFiltApellido
            // 
            txtFiltApellido.BorderStyle = BorderStyle.FixedSingle;
            txtFiltApellido.Location = new Point(246, 17);
            txtFiltApellido.Name = "txtFiltApellido";
            txtFiltApellido.Size = new Size(156, 23);
            txtFiltApellido.TabIndex = 9;
            // 
            // txtFiltNombre
            // 
            txtFiltNombre.BorderStyle = BorderStyle.FixedSingle;
            txtFiltNombre.Location = new Point(467, 17);
            txtFiltNombre.Name = "txtFiltNombre";
            txtFiltNombre.Size = new Size(156, 23);
            txtFiltNombre.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(407, 19);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 8;
            label5.Text = "Nombre:";
            // 
            // txtFiltCodigo
            // 
            txtFiltCodigo.BorderStyle = BorderStyle.FixedSingle;
            txtFiltCodigo.Location = new Point(61, 16);
            txtFiltCodigo.Name = "txtFiltCodigo";
            txtFiltCodigo.Size = new Size(105, 23);
            txtFiltCodigo.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(182, 19);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 7;
            label2.Text = "Apellido:";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox2.Controls.Add(btnModificar);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(dtpFecIngreso);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(txtCorreo);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(txtCodUser);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(678, 157);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(364, 334);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Usuario seleccionado:";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.Black;
            btnModificar.FlatAppearance.BorderSize = 0;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Leelawadee", 9.75F);
            btnModificar.ForeColor = SystemColors.ControlLightLight;
            btnModificar.Location = new Point(171, 273);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(173, 48);
            btnModificar.TabIndex = 18;
            btnModificar.Text = "MODIFICAR USUARIO";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.FromArgb(0, 192, 0);
            label11.Location = new Point(78, 235);
            label11.Name = "label11";
            label11.Size = new Size(79, 25);
            label11.TabIndex = 17;
            label11.Text = "ACTIVO";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(27, 243);
            label10.Name = "label10";
            label10.Size = new Size(45, 15);
            label10.TabIndex = 16;
            label10.Text = "Estado:";
            // 
            // dtpFecIngreso
            // 
            dtpFecIngreso.CustomFormat = "";
            dtpFecIngreso.Enabled = false;
            dtpFecIngreso.Format = DateTimePickerFormat.Short;
            dtpFecIngreso.Location = new Point(138, 203);
            dtpFecIngreso.Name = "dtpFecIngreso";
            dtpFecIngreso.Size = new Size(95, 23);
            dtpFecIngreso.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(27, 209);
            label9.Name = "label9";
            label9.Size = new Size(100, 15);
            label9.TabIndex = 11;
            label9.Text = "Fecha de registro:";
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Enabled = false;
            textBox2.Location = new Point(137, 174);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(207, 23);
            textBox2.TabIndex = 10;
            textBox2.Text = "ADMINISTRADOR";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(27, 176);
            label8.Name = "label8";
            label8.Size = new Size(104, 15);
            label8.TabIndex = 9;
            label8.Text = "Nivel de permisos:";
            // 
            // txtCorreo
            // 
            txtCorreo.BorderStyle = BorderStyle.FixedSingle;
            txtCorreo.Enabled = false;
            txtCorreo.Location = new Point(27, 139);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(317, 23);
            txtCorreo.TabIndex = 8;
            txtCorreo.Text = "correoprueba@gmail.com";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(27, 121);
            label7.Name = "label7";
            label7.Size = new Size(49, 15);
            label7.TabIndex = 7;
            label7.Text = "Correo: ";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Enabled = false;
            textBox1.Location = new Point(27, 88);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(317, 23);
            textBox1.TabIndex = 6;
            textBox1.Text = "Apellidos, Nombres";
            // 
            // txtCodUser
            // 
            txtCodUser.BorderStyle = BorderStyle.FixedSingle;
            txtCodUser.Enabled = false;
            txtCodUser.Location = new Point(83, 33);
            txtCodUser.Name = "txtCodUser";
            txtCodUser.Size = new Size(150, 23);
            txtCodUser.TabIndex = 5;
            txtCodUser.Text = "20240001";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 66);
            label6.Name = "label6";
            label6.Size = new Size(118, 15);
            label6.TabIndex = 1;
            label6.Text = "Apellidos y nombres:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 35);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 0;
            label3.Text = "Usuario:";
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox3.Controls.Add(btnGestionPers);
            groupBox3.Location = new Point(678, 58);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(364, 93);
            groupBox3.TabIndex = 19;
            groupBox3.TabStop = false;
            groupBox3.Text = "Gestionar cuenta personal:";
            // 
            // btnGestionPers
            // 
            btnGestionPers.BackColor = Color.Black;
            btnGestionPers.FlatAppearance.BorderSize = 0;
            btnGestionPers.FlatStyle = FlatStyle.Flat;
            btnGestionPers.Font = new Font("Leelawadee", 9.75F);
            btnGestionPers.ForeColor = SystemColors.ControlLightLight;
            btnGestionPers.Location = new Point(104, 22);
            btnGestionPers.Name = "btnGestionPers";
            btnGestionPers.Size = new Size(173, 49);
            btnGestionPers.TabIndex = 19;
            btnGestionPers.Text = "CUENTA PERSONAL";
            btnGestionPers.UseVisualStyleBackColor = false;
            btnGestionPers.Click += btnGestionPers_Click;
            // 
            // Usuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 798);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Usuarios";
            Text = "Usuarios";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private DataGridViewTextBoxColumn Usuario;
        private DataGridViewTextBoxColumn Correo;
        private DataGridViewTextBoxColumn apellidos;
        private DataGridViewTextBoxColumn nombres;
        private DataGridViewTextBoxColumn Estado;
        private GroupBox groupBox1;
        private Label label4;
        private TextBox txtFiltApellido;
        private TextBox txtFiltNombre;
        private Label label5;
        private TextBox txtFiltCodigo;
        private Label label2;
        private GroupBox groupBox2;
        private Label label6;
        private Label label3;
        private Label label8;
        private TextBox txtCorreo;
        private Label label7;
        private TextBox textBox1;
        private TextBox txtCodUser;
        private Label label9;
        private TextBox textBox2;
        private Label label11;
        private Label label10;
        private DateTimePicker dtpFecIngreso;
        private Button btnModificar;
        private GroupBox groupBox3;
        private Button btnGestionPers;
    }
}