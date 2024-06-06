namespace ProyBROL_GUI
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            label1 = new Label();
            imgLogo = new PictureBox();
            btnEmpleados = new Button();
            btnUsers = new Button();
            btnHorarios = new Button();
            btnRegAsist = new Button();
            btnSolicitudes = new Button();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgLogo).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(38, 68, 57);
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(btnEmpleados);
            flowLayoutPanel1.Controls.Add(btnUsers);
            flowLayoutPanel1.Controls.Add(btnHorarios);
            flowLayoutPanel1.Controls.Add(btnRegAsist);
            flowLayoutPanel1.Controls.Add(btnSolicitudes);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(186, 941);
            flowLayoutPanel1.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(imgLogo);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(183, 145);
            panel1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Leelawadee", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(29, 109);
            label1.Name = "label1";
            label1.Size = new Size(122, 25);
            label1.TabIndex = 1;
            label1.Text = "BROL S.A.C.";
            // 
            // imgLogo
            // 
            imgLogo.Image = Properties.Resources.logoBROL_W;
            imgLogo.Location = new Point(35, 22);
            imgLogo.Name = "imgLogo";
            imgLogo.Size = new Size(106, 91);
            imgLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            imgLogo.TabIndex = 0;
            imgLogo.TabStop = false;
            // 
            // btnEmpleados
            // 
            btnEmpleados.BackColor = Color.FromArgb(38, 68, 57);
            btnEmpleados.FlatAppearance.BorderSize = 0;
            btnEmpleados.FlatStyle = FlatStyle.Flat;
            btnEmpleados.Font = new Font("Leelawadee", 12F);
            btnEmpleados.ForeColor = SystemColors.ControlLightLight;
            btnEmpleados.Image = Properties.Resources.emplW1;
            btnEmpleados.ImageAlign = ContentAlignment.MiddleLeft;
            btnEmpleados.Location = new Point(3, 154);
            btnEmpleados.Name = "btnEmpleados";
            btnEmpleados.Padding = new Padding(20, 0, 0, 0);
            btnEmpleados.Size = new Size(183, 68);
            btnEmpleados.TabIndex = 7;
            btnEmpleados.Text = "      Empleados";
            btnEmpleados.UseVisualStyleBackColor = false;
            btnEmpleados.Visible = false;
            btnEmpleados.Click += btnEmpleados_Click;
            // 
            // btnUsers
            // 
            btnUsers.BackColor = Color.FromArgb(38, 68, 57);
            btnUsers.FlatAppearance.BorderSize = 0;
            btnUsers.FlatStyle = FlatStyle.Flat;
            btnUsers.Font = new Font("Leelawadee", 12F);
            btnUsers.ForeColor = SystemColors.ControlLightLight;
            btnUsers.Image = Properties.Resources.usersW;
            btnUsers.ImageAlign = ContentAlignment.MiddleLeft;
            btnUsers.Location = new Point(3, 228);
            btnUsers.Name = "btnUsers";
            btnUsers.Padding = new Padding(20, 0, 0, 0);
            btnUsers.Size = new Size(183, 68);
            btnUsers.TabIndex = 8;
            btnUsers.Text = "      Usuarios";
            btnUsers.UseVisualStyleBackColor = false;
            btnUsers.Visible = false;
            btnUsers.Click += btnUsers_Click;
            // 
            // btnHorarios
            // 
            btnHorarios.BackColor = Color.FromArgb(38, 68, 57);
            btnHorarios.FlatAppearance.BorderSize = 0;
            btnHorarios.FlatStyle = FlatStyle.Flat;
            btnHorarios.Font = new Font("Leelawadee", 12F);
            btnHorarios.ForeColor = SystemColors.ControlLightLight;
            btnHorarios.Image = Properties.Resources.relojW1;
            btnHorarios.ImageAlign = ContentAlignment.MiddleLeft;
            btnHorarios.Location = new Point(3, 302);
            btnHorarios.Name = "btnHorarios";
            btnHorarios.Padding = new Padding(20, 0, 0, 0);
            btnHorarios.Size = new Size(183, 68);
            btnHorarios.TabIndex = 7;
            btnHorarios.Text = "  Horarios";
            btnHorarios.UseVisualStyleBackColor = false;
            btnHorarios.Visible = false;
            // 
            // btnRegAsist
            // 
            btnRegAsist.BackColor = Color.FromArgb(38, 68, 57);
            btnRegAsist.FlatAppearance.BorderSize = 0;
            btnRegAsist.FlatStyle = FlatStyle.Flat;
            btnRegAsist.Font = new Font("Leelawadee", 12F);
            btnRegAsist.ForeColor = SystemColors.ControlLightLight;
            btnRegAsist.Image = Properties.Resources.calendW2;
            btnRegAsist.ImageAlign = ContentAlignment.MiddleLeft;
            btnRegAsist.Location = new Point(3, 376);
            btnRegAsist.Name = "btnRegAsist";
            btnRegAsist.Padding = new Padding(20, 0, 0, 0);
            btnRegAsist.Size = new Size(183, 68);
            btnRegAsist.TabIndex = 7;
            btnRegAsist.Text = "      Asistencias";
            btnRegAsist.UseVisualStyleBackColor = false;
            btnRegAsist.Visible = false;
            // 
            // btnSolicitudes
            // 
            btnSolicitudes.BackColor = Color.FromArgb(38, 68, 57);
            btnSolicitudes.FlatAppearance.BorderSize = 0;
            btnSolicitudes.FlatStyle = FlatStyle.Flat;
            btnSolicitudes.Font = new Font("Leelawadee", 12F);
            btnSolicitudes.ForeColor = SystemColors.ControlLightLight;
            btnSolicitudes.Image = Properties.Resources.solicitudW;
            btnSolicitudes.ImageAlign = ContentAlignment.MiddleLeft;
            btnSolicitudes.Location = new Point(3, 450);
            btnSolicitudes.Name = "btnSolicitudes";
            btnSolicitudes.Padding = new Padding(20, 0, 0, 0);
            btnSolicitudes.Size = new Size(183, 68);
            btnSolicitudes.TabIndex = 9;
            btnSolicitudes.Text = "      Solicitudes";
            btnSolicitudes.UseVisualStyleBackColor = false;
            btnSolicitudes.Visible = false;
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1604, 941);
            Controls.Add(flowLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            Name = "frmMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BROL.S.A.C. Sistema de R.R.H.H.";
            WindowState = FormWindowState.Maximized;
            Load += frmMenu_Load;
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Label label1;
        private PictureBox imgLogo;
        private Button btnEmpleados;
        private Button btnHorarios;
        private Button btnRegAsist;
        private Button btnUsers;
        private Button btnSolicitudes;
    }
}