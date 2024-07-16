namespace ProyBROL_GUI
{
    partial class Recibos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Recibos));
            label1 = new Label();
            dgRecibos = new DataGridView();
            codigo = new DataGridViewTextBoxColumn();
            fecha = new DataGridViewTextBoxColumn();
            Archivo = new DataGridViewTextBoxColumn();
            label2 = new Label();
            groupBox1 = new GroupBox();
            txtCodSolicitante = new TextBox();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dtpFecIngreso = new DateTimePicker();
            label4 = new Label();
            label3 = new Label();
            gbBuscar = new GroupBox();
            textBox6 = new TextBox();
            label11 = new Label();
            textBox5 = new TextBox();
            label10 = new Label();
            panel1 = new Panel();
            textBox4 = new TextBox();
            label9 = new Label();
            line1 = new Panel();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label8 = new Label();
            label7 = new Label();
            textBox1 = new TextBox();
            label6 = new Label();
            button1 = new Button();
            txt1 = new TextBox();
            label17 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgRecibos).BeginInit();
            groupBox1.SuspendLayout();
            gbBuscar.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Leelawadee", 15.75F);
            label1.Location = new Point(37, 22);
            label1.Name = "label1";
            label1.Size = new Size(175, 25);
            label1.TabIndex = 5;
            label1.Text = "Recibos de Pagos";
            // 
            // dgRecibos
            // 
            dgRecibos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgRecibos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgRecibos.Columns.AddRange(new DataGridViewColumn[] { codigo, fecha, Archivo });
            dgRecibos.Location = new Point(37, 147);
            dgRecibos.Name = "dgRecibos";
            dgRecibos.Size = new Size(829, 587);
            dgRecibos.TabIndex = 6;
            // 
            // codigo
            // 
            codigo.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            codigo.HeaderText = "Codigo";
            codigo.Name = "codigo";
            codigo.Width = 71;
            // 
            // fecha
            // 
            fecha.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            fecha.HeaderText = "Fecha de emisión";
            fecha.Name = "fecha";
            // 
            // Archivo
            // 
            Archivo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Archivo.HeaderText = "Archivo";
            Archivo.Name = "Archivo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 50);
            label2.Name = "label2";
            label2.Size = new Size(410, 15);
            label2.TabIndex = 7;
            label2.Text = "Los recibos son generados automaticamente los dias 15 y 30 entre cada mes.";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(txtCodSolicitante);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(dtpFecIngreso);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(37, 76);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(829, 65);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Buscar recibos por Fecha:";
            // 
            // txtCodSolicitante
            // 
            txtCodSolicitante.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtCodSolicitante.BorderStyle = BorderStyle.FixedSingle;
            txtCodSolicitante.Location = new Point(745, 29);
            txtCodSolicitante.Name = "txtCodSolicitante";
            txtCodSolicitante.ReadOnly = true;
            txtCodSolicitante.Size = new Size(57, 23);
            txtCodSolicitante.TabIndex = 18;
            txtCodSolicitante.Text = "0";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(558, 31);
            label5.Name = "label5";
            label5.Size = new Size(170, 15);
            label5.TabIndex = 17;
            label5.Text = "Numero de recibos mostrados:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "";
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(307, 29);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(95, 23);
            dateTimePicker1.TabIndex = 16;
            // 
            // dtpFecIngreso
            // 
            dtpFecIngreso.CustomFormat = "";
            dtpFecIngreso.Format = DateTimePickerFormat.Short;
            dtpFecIngreso.Location = new Point(109, 29);
            dtpFecIngreso.Name = "dtpFecIngreso";
            dtpFecIngreso.Size = new Size(95, 23);
            dtpFecIngreso.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(227, 31);
            label4.Name = "label4";
            label4.Size = new Size(74, 15);
            label4.TabIndex = 1;
            label4.Text = "Fecha de fin:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 31);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 0;
            label3.Text = "Fecha inicio:";
            // 
            // gbBuscar
            // 
            gbBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            gbBuscar.Controls.Add(textBox6);
            gbBuscar.Controls.Add(label11);
            gbBuscar.Controls.Add(textBox5);
            gbBuscar.Controls.Add(label10);
            gbBuscar.Controls.Add(panel1);
            gbBuscar.Controls.Add(textBox4);
            gbBuscar.Controls.Add(label9);
            gbBuscar.Controls.Add(line1);
            gbBuscar.Controls.Add(textBox3);
            gbBuscar.Controls.Add(textBox2);
            gbBuscar.Controls.Add(label8);
            gbBuscar.Controls.Add(label7);
            gbBuscar.Controls.Add(textBox1);
            gbBuscar.Controls.Add(label6);
            gbBuscar.Controls.Add(button1);
            gbBuscar.Controls.Add(txt1);
            gbBuscar.Controls.Add(label17);
            gbBuscar.Location = new Point(896, 76);
            gbBuscar.Name = "gbBuscar";
            gbBuscar.Size = new Size(364, 544);
            gbBuscar.TabIndex = 9;
            gbBuscar.TabStop = false;
            gbBuscar.Text = "Informacion de seleccion:";
            // 
            // textBox6
            // 
            textBox6.BorderStyle = BorderStyle.FixedSingle;
            textBox6.Location = new Point(27, 344);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(321, 88);
            textBox6.TabIndex = 53;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(22, 326);
            label11.Name = "label11";
            label11.Size = new Size(87, 15);
            label11.TabIndex = 52;
            label11.Text = "Observaciones:";
            // 
            // textBox5
            // 
            textBox5.BorderStyle = BorderStyle.FixedSingle;
            textBox5.Location = new Point(100, 256);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(144, 23);
            textBox5.TabIndex = 51;
            // 
            // label10
            // 
            label10.Location = new Point(22, 256);
            label10.Name = "label10";
            label10.Size = new Size(72, 32);
            label10.TabIndex = 50;
            label10.Text = "Total Recibido:";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(22, 243);
            panel1.Name = "panel1";
            panel1.Size = new Size(326, 1);
            panel1.TabIndex = 49;
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Location = new Point(100, 198);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(144, 23);
            textBox4.TabIndex = 48;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(22, 202);
            label9.Name = "label9";
            label9.Size = new Size(66, 15);
            label9.TabIndex = 47;
            label9.Text = "Descuento:";
            // 
            // line1
            // 
            line1.BackColor = SystemColors.ActiveCaptionText;
            line1.Location = new Point(22, 108);
            line1.Name = "line1";
            line1.Size = new Size(326, 1);
            line1.TabIndex = 46;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Location = new Point(100, 163);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(144, 23);
            textBox3.TabIndex = 45;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(100, 131);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(144, 23);
            textBox2.TabIndex = 44;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(22, 137);
            label8.Name = "label8";
            label8.Size = new Size(54, 15);
            label8.TabIndex = 43;
            label8.Text = "Moneda:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(22, 169);
            label7.Name = "label7";
            label7.Size = new Size(35, 15);
            label7.TabIndex = 42;
            label7.Text = "Total:";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(100, 68);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(206, 23);
            textBox1.TabIndex = 41;
            // 
            // label6
            // 
            label6.Location = new Point(22, 64);
            label6.Name = "label6";
            label6.Size = new Size(72, 32);
            label6.TabIndex = 40;
            label6.Text = "Fecha de emision:";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top;
            button1.BackColor = Color.Black;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Leelawadee", 9.75F);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(218, 473);
            button1.Name = "button1";
            button1.Size = new Size(130, 48);
            button1.TabIndex = 39;
            button1.Text = "DESCARGAR Y VISUALIZAR PDF";
            button1.UseVisualStyleBackColor = false;
            // 
            // txt1
            // 
            txt1.BorderStyle = BorderStyle.FixedSingle;
            txt1.Location = new Point(100, 35);
            txt1.Name = "txt1";
            txt1.ReadOnly = true;
            txt1.Size = new Size(206, 23);
            txt1.TabIndex = 19;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(22, 41);
            label17.Name = "label17";
            label17.Size = new Size(72, 15);
            label17.TabIndex = 17;
            label17.Text = "Nro. Recibo:";
            // 
            // Recibos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1334, 911);
            Controls.Add(gbBuscar);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(dgRecibos);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Recibos";
            Text = "Recibos";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dgRecibos).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            gbBuscar.ResumeLayout(false);
            gbBuscar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgRecibos;
        private DataGridViewTextBoxColumn codigo;
        private DataGridViewTextBoxColumn fecha;
        private DataGridViewTextBoxColumn Archivo;
        private Label label2;
        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label5;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dtpFecIngreso;
        private TextBox txtCodSolicitante;
        private GroupBox gbBuscar;
        private TextBox txt1;
        private Label label17;
        private Button button1;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label8;
        private Label label7;
        private TextBox textBox1;
        private Label label6;
        private TextBox textBox4;
        private Label label9;
        private Panel line1;
        private TextBox textBox5;
        private Label label10;
        private Panel panel1;
        private TextBox textBox6;
        private Label label11;
    }
}