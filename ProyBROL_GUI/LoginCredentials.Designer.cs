namespace ProyBROL_GUI
{
    partial class LoginCredentials
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginCredentials));
            label1 = new Label();
            txtPass = new TextBox();
            btnAceptar = new Button();
            button1 = new Button();
            lblResponse = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 18);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 0;
            label1.Text = "Contraseña:";
            // 
            // txtPass
            // 
            txtPass.BorderStyle = BorderStyle.FixedSingle;
            txtPass.Location = new Point(28, 36);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(317, 23);
            txtPass.TabIndex = 14;
            // 
            // btnAceptar
            // 
            btnAceptar.Anchor = AnchorStyles.Top;
            btnAceptar.BackColor = Color.Black;
            btnAceptar.FlatAppearance.BorderSize = 0;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Leelawadee", 9.75F);
            btnAceptar.ForeColor = SystemColors.ControlLightLight;
            btnAceptar.Location = new Point(139, 89);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(100, 48);
            btnAceptar.TabIndex = 20;
            btnAceptar.Text = "ACEPTAR";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top;
            button1.BackColor = Color.Black;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Leelawadee", 9.75F);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(245, 89);
            button1.Name = "button1";
            button1.Size = new Size(100, 48);
            button1.TabIndex = 21;
            button1.Text = "CANCELAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // lblResponse
            // 
            lblResponse.AutoSize = true;
            lblResponse.Location = new Point(29, 67);
            lblResponse.Name = "lblResponse";
            lblResponse.Size = new Size(0, 15);
            lblResponse.TabIndex = 22;
            // 
            // LoginCredentials
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 151);
            Controls.Add(lblResponse);
            Controls.Add(button1);
            Controls.Add(btnAceptar);
            Controls.Add(txtPass);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(400, 190);
            MinimumSize = new Size(400, 190);
            Name = "LoginCredentials";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Credenciales";
            Load += LoginCredentials_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtPass;
        private Button btnAceptar;
        private Button button1;
        private Label lblResponse;
    }
}