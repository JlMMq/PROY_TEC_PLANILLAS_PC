namespace ProyBROL_GUI
{
    partial class UsuarioModificar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsuarioModificar));
            groupBox2 = new GroupBox();
            cboPermisos = new ComboBox();
            label10 = new Label();
            dtpFecIngreso = new DateTimePicker();
            label9 = new Label();
            label8 = new Label();
            txtCorreo = new TextBox();
            label7 = new Label();
            txtapenom = new TextBox();
            txtCodUser = new TextBox();
            label6 = new Label();
            label3 = new Label();
            btnModificar = new Button();
            label1 = new Label();
            button1 = new Button();
            chcActivo = new CheckBox();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBox2.Controls.Add(chcActivo);
            groupBox2.Controls.Add(cboPermisos);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(dtpFecIngreso);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(txtCorreo);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtapenom);
            groupBox2.Controls.Add(txtCodUser);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(22, 53);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(364, 283);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Usuario:";
            // 
            // cboPermisos
            // 
            cboPermisos.FormattingEnabled = true;
            cboPermisos.Location = new Point(138, 173);
            cboPermisos.Name = "cboPermisos";
            cboPermisos.Size = new Size(206, 23);
            cboPermisos.TabIndex = 18;
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
            // txtapenom
            // 
            txtapenom.BorderStyle = BorderStyle.FixedSingle;
            txtapenom.Enabled = false;
            txtapenom.Location = new Point(27, 88);
            txtapenom.Name = "txtapenom";
            txtapenom.Size = new Size(317, 23);
            txtapenom.TabIndex = 6;
            txtapenom.Text = "Apellidos, Nombres";
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
            // btnModificar
            // 
            btnModificar.BackColor = Color.Black;
            btnModificar.FlatAppearance.BorderSize = 0;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Leelawadee", 9.75F);
            btnModificar.ForeColor = SystemColors.ControlLightLight;
            btnModificar.Location = new Point(184, 350);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(96, 48);
            btnModificar.TabIndex = 18;
            btnModificar.Text = "ACEPTAR";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Leelawadee", 15.75F);
            label1.Location = new Point(22, 19);
            label1.Name = "label1";
            label1.Size = new Size(174, 25);
            label1.TabIndex = 19;
            label1.Text = "Modificar Usuario";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top;
            button1.BackColor = Color.Black;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Leelawadee", 9.75F);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(286, 350);
            button1.Name = "button1";
            button1.Size = new Size(100, 48);
            button1.TabIndex = 22;
            button1.Text = "CANCELAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // chcActivo
            // 
            chcActivo.AutoSize = true;
            chcActivo.Location = new Point(83, 242);
            chcActivo.Name = "chcActivo";
            chcActivo.Size = new Size(60, 19);
            chcActivo.TabIndex = 20;
            chcActivo.Text = "Activo";
            chcActivo.UseVisualStyleBackColor = true;
            // 
            // UsuarioModificar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(408, 419);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(btnModificar);
            Controls.Add(groupBox2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(424, 458);
            MinimumSize = new Size(424, 458);
            Name = "UsuarioModificar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Modificar Usuario";
            Load += UsuarioModificar_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox2;
        private Label label10;
        private DateTimePicker dtpFecIngreso;
        private Label label9;
        private Label label8;
        private TextBox txtCorreo;
        private Label label7;
        private TextBox txtapenom;
        private TextBox txtCodUser;
        private Label label6;
        private Label label3;
        private Button btnModificar;
        private Label label1;
        private Button button1;
        private ComboBox cboPermisos;
        private CheckBox chcActivo;
    }
}