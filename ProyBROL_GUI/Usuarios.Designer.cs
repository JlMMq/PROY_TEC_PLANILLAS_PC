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
            dtgUsers = new DataGridView();
            codUser = new DataGridViewTextBoxColumn();
            nomUser = new DataGridViewTextBoxColumn();
            correoUser = new DataGridViewTextBoxColumn();
            str_apellidos = new DataGridViewTextBoxColumn();
            str_nombres = new DataGridViewTextBoxColumn();
            fec_Reg = new DataGridViewTextBoxColumn();
            permisoUser = new DataGridViewTextBoxColumn();
            estdUserView = new DataGridViewTextBoxColumn();
            label1 = new Label();
            groupBox1 = new GroupBox();
            label4 = new Label();
            txtFiltApellido = new TextBox();
            txtFiltNombre = new TextBox();
            label5 = new Label();
            txtFiltUser = new TextBox();
            label2 = new Label();
            groupBox2 = new GroupBox();
            btnModificar = new Button();
            lblEstado = new Label();
            label10 = new Label();
            dtpFecIngreso = new DateTimePicker();
            label9 = new Label();
            txtperm = new TextBox();
            label8 = new Label();
            txtCorreo = new TextBox();
            label7 = new Label();
            txtnomap = new TextBox();
            txtCodUser = new TextBox();
            label6 = new Label();
            label3 = new Label();
            groupBox3 = new GroupBox();
            btnGestionPers = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgUsers).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // dtgUsers
            // 
            dtgUsers.AllowUserToAddRows = false;
            dtgUsers.AllowUserToDeleteRows = false;
            dtgUsers.AllowUserToOrderColumns = true;
            dtgUsers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgUsers.Columns.AddRange(new DataGridViewColumn[] { codUser, nomUser, correoUser, str_apellidos, str_nombres, fec_Reg, permisoUser, estdUserView });
            dtgUsers.Location = new Point(21, 114);
            dtgUsers.Name = "dtgUsers";
            dtgUsers.ReadOnly = true;
            dtgUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgUsers.Size = new Size(637, 601);
            dtgUsers.TabIndex = 0;
            dtgUsers.CellClick += dtgUsers_CellClick;
            // 
            // codUser
            // 
            codUser.DataPropertyName = "codUser";
            codUser.HeaderText = "Codigo";
            codUser.Name = "codUser";
            codUser.ReadOnly = true;
            codUser.Visible = false;
            // 
            // nomUser
            // 
            nomUser.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            nomUser.DataPropertyName = "nomUser";
            nomUser.HeaderText = "Usuario";
            nomUser.Name = "nomUser";
            nomUser.ReadOnly = true;
            nomUser.Width = 72;
            // 
            // correoUser
            // 
            correoUser.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            correoUser.DataPropertyName = "correoUser";
            correoUser.HeaderText = "Correo";
            correoUser.Name = "correoUser";
            correoUser.ReadOnly = true;
            // 
            // str_apellidos
            // 
            str_apellidos.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            str_apellidos.DataPropertyName = "str_apellidos";
            str_apellidos.HeaderText = "Apellidos";
            str_apellidos.Name = "str_apellidos";
            str_apellidos.ReadOnly = true;
            // 
            // str_nombres
            // 
            str_nombres.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            str_nombres.DataPropertyName = "str_nombres";
            str_nombres.HeaderText = "Nombres";
            str_nombres.Name = "str_nombres";
            str_nombres.ReadOnly = true;
            // 
            // fec_Reg
            // 
            fec_Reg.DataPropertyName = "fec_Reg";
            fec_Reg.HeaderText = "Fecha Registro";
            fec_Reg.Name = "fec_Reg";
            fec_Reg.ReadOnly = true;
            fec_Reg.Visible = false;
            // 
            // permisoUser
            // 
            permisoUser.DataPropertyName = "permisoUser";
            permisoUser.HeaderText = "Permiso";
            permisoUser.Name = "permisoUser";
            permisoUser.ReadOnly = true;
            permisoUser.Visible = false;
            // 
            // estdUserView
            // 
            estdUserView.DataPropertyName = "estdUserView";
            estdUserView.HeaderText = "Estado";
            estdUserView.Name = "estdUserView";
            estdUserView.ReadOnly = true;
            estdUserView.Width = 119;
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
            groupBox1.Controls.Add(txtFiltUser);
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
            label4.Size = new Size(50, 15);
            label4.TabIndex = 5;
            label4.Text = "Usuario:";
            // 
            // txtFiltApellido
            // 
            txtFiltApellido.BorderStyle = BorderStyle.FixedSingle;
            txtFiltApellido.Location = new Point(246, 17);
            txtFiltApellido.Name = "txtFiltApellido";
            txtFiltApellido.Size = new Size(156, 23);
            txtFiltApellido.TabIndex = 9;
            txtFiltApellido.TextChanged += txtFiltApellido_TextChanged;
            // 
            // txtFiltNombre
            // 
            txtFiltNombre.BorderStyle = BorderStyle.FixedSingle;
            txtFiltNombre.Location = new Point(467, 17);
            txtFiltNombre.Name = "txtFiltNombre";
            txtFiltNombre.Size = new Size(156, 23);
            txtFiltNombre.TabIndex = 4;
            txtFiltNombre.TextChanged += txtFiltNombre_TextChanged;
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
            // txtFiltUser
            // 
            txtFiltUser.BorderStyle = BorderStyle.FixedSingle;
            txtFiltUser.Location = new Point(61, 16);
            txtFiltUser.Name = "txtFiltUser";
            txtFiltUser.Size = new Size(105, 23);
            txtFiltUser.TabIndex = 6;
            txtFiltUser.TextChanged += txtFiltUser_TextChanged;
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
            groupBox2.Controls.Add(lblEstado);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(dtpFecIngreso);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(txtperm);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(txtCorreo);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtnomap);
            groupBox2.Controls.Add(txtCodUser);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(678, 157);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(364, 334);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Usuario seleccionado:";
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
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEstado.ForeColor = SystemColors.ActiveCaptionText;
            lblEstado.Location = new Point(78, 235);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(0, 25);
            lblEstado.TabIndex = 17;
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
            // txtperm
            // 
            txtperm.BorderStyle = BorderStyle.FixedSingle;
            txtperm.Enabled = false;
            txtperm.Location = new Point(137, 174);
            txtperm.Name = "txtperm";
            txtperm.Size = new Size(207, 23);
            txtperm.TabIndex = 10;
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
            // txtnomap
            // 
            txtnomap.BorderStyle = BorderStyle.FixedSingle;
            txtnomap.Enabled = false;
            txtnomap.Location = new Point(27, 88);
            txtnomap.Name = "txtnomap";
            txtnomap.Size = new Size(317, 23);
            txtnomap.TabIndex = 6;
            // 
            // txtCodUser
            // 
            txtCodUser.BorderStyle = BorderStyle.FixedSingle;
            txtCodUser.Enabled = false;
            txtCodUser.Location = new Point(83, 33);
            txtCodUser.Name = "txtCodUser";
            txtCodUser.Size = new Size(150, 23);
            txtCodUser.TabIndex = 5;
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
            Controls.Add(dtgUsers);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Usuarios";
            Text = "Usuarios";
            WindowState = FormWindowState.Maximized;
            Load += Usuarios_Load;
            ((System.ComponentModel.ISupportInitialize)dtgUsers).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgUsers;
        private Label label1;
        private GroupBox groupBox1;
        private Label label4;
        private TextBox txtFiltApellido;
        private TextBox txtFiltNombre;
        private Label label5;
        private TextBox txtFiltUser;
        private Label label2;
        private GroupBox groupBox2;
        private Label label6;
        private Label label3;
        private Label label8;
        private TextBox txtCorreo;
        private Label label7;
        private TextBox txtnomap;
        private TextBox txtCodUser;
        private Label label9;
        private TextBox txtperm;
        private Label lblEstado;
        private Label label10;
        private DateTimePicker dtpFecIngreso;
        private Button btnModificar;
        private GroupBox groupBox3;
        private Button btnGestionPers;
        private DataGridViewTextBoxColumn codUser;
        private DataGridViewTextBoxColumn nomUser;
        private DataGridViewTextBoxColumn correoUser;
        private DataGridViewTextBoxColumn str_apellidos;
        private DataGridViewTextBoxColumn str_nombres;
        private DataGridViewTextBoxColumn fec_Reg;
        private DataGridViewTextBoxColumn permisoUser;
        private DataGridViewTextBoxColumn estdUserView;
    }
}