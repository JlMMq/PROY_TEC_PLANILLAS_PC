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
            codRecibo = new DataGridViewTextBoxColumn();
            fechaEmision = new DataGridViewTextBoxColumn();
            codEmpleado = new DataGridViewTextBoxColumn();
            apenom = new DataGridViewTextBoxColumn();
            moneda = new DataGridViewTextBoxColumn();
            sueldoBase = new DataGridViewTextBoxColumn();
            descEssalud = new DataGridViewTextBoxColumn();
            descOnp = new DataGridViewTextBoxColumn();
            descAfp = new DataGridViewTextBoxColumn();
            descFaltas = new DataGridViewTextBoxColumn();
            sueldoTotal = new DataGridViewTextBoxColumn();
            label2 = new Label();
            groupBox1 = new GroupBox();
            txtCantReg = new TextBox();
            label5 = new Label();
            dtpFecFin = new DateTimePicker();
            dtpFecInicio = new DateTimePicker();
            label4 = new Label();
            label3 = new Label();
            gbBuscar = new GroupBox();
            label14 = new Label();
            txtDescFaltas = new TextBox();
            label13 = new Label();
            txtDescOnp = new TextBox();
            label12 = new Label();
            txtDescAfp = new TextBox();
            label11 = new Label();
            txtSueldoTotal = new TextBox();
            label10 = new Label();
            panel1 = new Panel();
            txtDescEssalud = new TextBox();
            label9 = new Label();
            line1 = new Panel();
            txtSueldoBase = new TextBox();
            txtMoneda = new TextBox();
            label8 = new Label();
            label7 = new Label();
            txtFechaEmision = new TextBox();
            label6 = new Label();
            button1 = new Button();
            txtCodRecibo = new TextBox();
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
            dgRecibos.AllowUserToAddRows = false;
            dgRecibos.AllowUserToDeleteRows = false;
            dgRecibos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgRecibos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgRecibos.Columns.AddRange(new DataGridViewColumn[] { codRecibo, fechaEmision, codEmpleado, apenom, moneda, sueldoBase, descEssalud, descOnp, descAfp, descFaltas, sueldoTotal });
            dgRecibos.Location = new Point(37, 147);
            dgRecibos.Name = "dgRecibos";
            dgRecibos.ReadOnly = true;
            dgRecibos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgRecibos.Size = new Size(829, 587);
            dgRecibos.TabIndex = 6;
            dgRecibos.CellClick += dgRecibos_CellClick;
            // 
            // codRecibo
            // 
            codRecibo.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            codRecibo.DataPropertyName = "codRecibo";
            codRecibo.HeaderText = "Codigo";
            codRecibo.Name = "codRecibo";
            codRecibo.ReadOnly = true;
            codRecibo.Width = 71;
            // 
            // fechaEmision
            // 
            fechaEmision.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            fechaEmision.DataPropertyName = "fechaEmision";
            fechaEmision.HeaderText = "Fecha de emisión";
            fechaEmision.Name = "fechaEmision";
            fechaEmision.ReadOnly = true;
            // 
            // codEmpleado
            // 
            codEmpleado.DataPropertyName = "codEmpleado";
            codEmpleado.HeaderText = "Empleado";
            codEmpleado.Name = "codEmpleado";
            codEmpleado.ReadOnly = true;
            codEmpleado.Visible = false;
            // 
            // apenom
            // 
            apenom.DataPropertyName = "apenom";
            apenom.HeaderText = "Apellidos y Nombres";
            apenom.Name = "apenom";
            apenom.ReadOnly = true;
            apenom.Visible = false;
            // 
            // moneda
            // 
            moneda.DataPropertyName = "moneda";
            moneda.HeaderText = "Moneda";
            moneda.Name = "moneda";
            moneda.ReadOnly = true;
            // 
            // sueldoBase
            // 
            sueldoBase.DataPropertyName = "sueldoBase";
            sueldoBase.HeaderText = "Sueldo Base";
            sueldoBase.Name = "sueldoBase";
            sueldoBase.ReadOnly = true;
            sueldoBase.Visible = false;
            // 
            // descEssalud
            // 
            descEssalud.DataPropertyName = "descEssalud";
            descEssalud.HeaderText = "Descuento Essalud";
            descEssalud.Name = "descEssalud";
            descEssalud.ReadOnly = true;
            descEssalud.Visible = false;
            // 
            // descOnp
            // 
            descOnp.DataPropertyName = "descOnp";
            descOnp.HeaderText = "Descuento ONP";
            descOnp.Name = "descOnp";
            descOnp.ReadOnly = true;
            descOnp.Visible = false;
            // 
            // descAfp
            // 
            descAfp.DataPropertyName = "descAfp";
            descAfp.HeaderText = "Descuento AFP";
            descAfp.Name = "descAfp";
            descAfp.ReadOnly = true;
            descAfp.Visible = false;
            // 
            // descFaltas
            // 
            descFaltas.DataPropertyName = "descFaltas";
            descFaltas.HeaderText = "Descuento Faltas";
            descFaltas.Name = "descFaltas";
            descFaltas.ReadOnly = true;
            descFaltas.Visible = false;
            // 
            // sueldoTotal
            // 
            sueldoTotal.DataPropertyName = "sueldoTotal";
            sueldoTotal.HeaderText = "Remuneracion";
            sueldoTotal.Name = "sueldoTotal";
            sueldoTotal.ReadOnly = true;
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
            groupBox1.Controls.Add(txtCantReg);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(dtpFecFin);
            groupBox1.Controls.Add(dtpFecInicio);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(37, 76);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(829, 65);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Buscar recibos por Fecha:";
            // 
            // txtCantReg
            // 
            txtCantReg.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtCantReg.BorderStyle = BorderStyle.FixedSingle;
            txtCantReg.Location = new Point(745, 29);
            txtCantReg.Name = "txtCantReg";
            txtCantReg.ReadOnly = true;
            txtCantReg.Size = new Size(57, 23);
            txtCantReg.TabIndex = 18;
            txtCantReg.Text = "0";
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
            // dtpFecFin
            // 
            dtpFecFin.CustomFormat = "";
            dtpFecFin.Format = DateTimePickerFormat.Short;
            dtpFecFin.Location = new Point(307, 29);
            dtpFecFin.Name = "dtpFecFin";
            dtpFecFin.Size = new Size(95, 23);
            dtpFecFin.TabIndex = 16;
            // 
            // dtpFecInicio
            // 
            dtpFecInicio.CustomFormat = "";
            dtpFecInicio.Format = DateTimePickerFormat.Short;
            dtpFecInicio.Location = new Point(109, 29);
            dtpFecInicio.Name = "dtpFecInicio";
            dtpFecInicio.Size = new Size(95, 23);
            dtpFecInicio.TabIndex = 15;
            dtpFecInicio.ValueChanged += dtpFecInicio_ValueChanged;
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
            gbBuscar.Controls.Add(label14);
            gbBuscar.Controls.Add(txtDescFaltas);
            gbBuscar.Controls.Add(label13);
            gbBuscar.Controls.Add(txtDescOnp);
            gbBuscar.Controls.Add(label12);
            gbBuscar.Controls.Add(txtDescAfp);
            gbBuscar.Controls.Add(label11);
            gbBuscar.Controls.Add(txtSueldoTotal);
            gbBuscar.Controls.Add(label10);
            gbBuscar.Controls.Add(panel1);
            gbBuscar.Controls.Add(txtDescEssalud);
            gbBuscar.Controls.Add(label9);
            gbBuscar.Controls.Add(line1);
            gbBuscar.Controls.Add(txtSueldoBase);
            gbBuscar.Controls.Add(txtMoneda);
            gbBuscar.Controls.Add(label8);
            gbBuscar.Controls.Add(label7);
            gbBuscar.Controls.Add(txtFechaEmision);
            gbBuscar.Controls.Add(label6);
            gbBuscar.Controls.Add(button1);
            gbBuscar.Controls.Add(txtCodRecibo);
            gbBuscar.Controls.Add(label17);
            gbBuscar.Location = new Point(896, 76);
            gbBuscar.Name = "gbBuscar";
            gbBuscar.Size = new Size(364, 494);
            gbBuscar.TabIndex = 9;
            gbBuscar.TabStop = false;
            gbBuscar.Text = "Informacion de seleccion:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(38, 316);
            label14.Name = "label14";
            label14.Size = new Size(62, 15);
            label14.TabIndex = 58;
            label14.Text = "Por faltas: ";
            // 
            // txtDescFaltas
            // 
            txtDescFaltas.BorderStyle = BorderStyle.FixedSingle;
            txtDescFaltas.Location = new Point(116, 311);
            txtDescFaltas.Name = "txtDescFaltas";
            txtDescFaltas.ReadOnly = true;
            txtDescFaltas.Size = new Size(144, 23);
            txtDescFaltas.TabIndex = 57;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(38, 287);
            label13.Name = "label13";
            label13.Size = new Size(38, 15);
            label13.TabIndex = 56;
            label13.Text = "ONP: ";
            // 
            // txtDescOnp
            // 
            txtDescOnp.BorderStyle = BorderStyle.FixedSingle;
            txtDescOnp.Location = new Point(116, 282);
            txtDescOnp.Name = "txtDescOnp";
            txtDescOnp.ReadOnly = true;
            txtDescOnp.Size = new Size(144, 23);
            txtDescOnp.TabIndex = 55;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(38, 259);
            label12.Name = "label12";
            label12.Size = new Size(34, 15);
            label12.TabIndex = 54;
            label12.Text = "AFP: ";
            // 
            // txtDescAfp
            // 
            txtDescAfp.BorderStyle = BorderStyle.FixedSingle;
            txtDescAfp.Location = new Point(116, 254);
            txtDescAfp.Name = "txtDescAfp";
            txtDescAfp.ReadOnly = true;
            txtDescAfp.Size = new Size(144, 23);
            txtDescAfp.TabIndex = 53;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(38, 229);
            label11.Name = "label11";
            label11.Size = new Size(61, 15);
            label11.TabIndex = 52;
            label11.Text = "ESSALUD: ";
            // 
            // txtSueldoTotal
            // 
            txtSueldoTotal.BorderStyle = BorderStyle.FixedSingle;
            txtSueldoTotal.Location = new Point(100, 366);
            txtSueldoTotal.Name = "txtSueldoTotal";
            txtSueldoTotal.ReadOnly = true;
            txtSueldoTotal.Size = new Size(144, 23);
            txtSueldoTotal.TabIndex = 51;
            // 
            // label10
            // 
            label10.Location = new Point(22, 368);
            label10.Name = "label10";
            label10.Size = new Size(72, 32);
            label10.TabIndex = 50;
            label10.Text = "Total Recibido:";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(22, 352);
            panel1.Name = "panel1";
            panel1.Size = new Size(326, 1);
            panel1.TabIndex = 49;
            // 
            // txtDescEssalud
            // 
            txtDescEssalud.BorderStyle = BorderStyle.FixedSingle;
            txtDescEssalud.Location = new Point(116, 224);
            txtDescEssalud.Name = "txtDescEssalud";
            txtDescEssalud.ReadOnly = true;
            txtDescEssalud.Size = new Size(144, 23);
            txtDescEssalud.TabIndex = 48;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(22, 200);
            label9.Name = "label9";
            label9.Size = new Size(71, 15);
            label9.TabIndex = 47;
            label9.Text = "Descuentos:";
            // 
            // line1
            // 
            line1.BackColor = SystemColors.ActiveCaptionText;
            line1.Location = new Point(22, 108);
            line1.Name = "line1";
            line1.Size = new Size(326, 1);
            line1.TabIndex = 46;
            // 
            // txtSueldoBase
            // 
            txtSueldoBase.BorderStyle = BorderStyle.FixedSingle;
            txtSueldoBase.Location = new Point(100, 163);
            txtSueldoBase.Name = "txtSueldoBase";
            txtSueldoBase.ReadOnly = true;
            txtSueldoBase.Size = new Size(144, 23);
            txtSueldoBase.TabIndex = 45;
            // 
            // txtMoneda
            // 
            txtMoneda.BorderStyle = BorderStyle.FixedSingle;
            txtMoneda.Location = new Point(100, 131);
            txtMoneda.Name = "txtMoneda";
            txtMoneda.ReadOnly = true;
            txtMoneda.Size = new Size(144, 23);
            txtMoneda.TabIndex = 44;
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
            // txtFechaEmision
            // 
            txtFechaEmision.BorderStyle = BorderStyle.FixedSingle;
            txtFechaEmision.Location = new Point(100, 68);
            txtFechaEmision.Name = "txtFechaEmision";
            txtFechaEmision.ReadOnly = true;
            txtFechaEmision.Size = new Size(206, 23);
            txtFechaEmision.TabIndex = 41;
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
            button1.Location = new Point(209, 416);
            button1.Name = "button1";
            button1.Size = new Size(130, 48);
            button1.TabIndex = 39;
            button1.Text = "DESCARGAR PDF";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtCodRecibo
            // 
            txtCodRecibo.BorderStyle = BorderStyle.FixedSingle;
            txtCodRecibo.Location = new Point(100, 35);
            txtCodRecibo.Name = "txtCodRecibo";
            txtCodRecibo.ReadOnly = true;
            txtCodRecibo.Size = new Size(206, 23);
            txtCodRecibo.TabIndex = 19;
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
            Load += Recibos_Load;
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
        private Label label2;
        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label5;
        private DateTimePicker dtpFecFin;
        private DateTimePicker dtpFecInicio;
        private TextBox txtCantReg;
        private GroupBox gbBuscar;
        private TextBox txtCodRecibo;
        private Label label17;
        private Button button1;
        private TextBox txtSueldoBase;
        private TextBox txtMoneda;
        private Label label8;
        private Label label7;
        private TextBox txtFechaEmision;
        private Label label6;
        private TextBox txtDescEssalud;
        private Label label9;
        private Panel line1;
        private TextBox txtSueldoTotal;
        private Label label10;
        private Panel panel1;
        private Label label14;
        private TextBox txtDescFaltas;
        private Label label13;
        private TextBox txtDescOnp;
        private Label label12;
        private TextBox txtDescAfp;
        private Label label11;
        private DataGridViewTextBoxColumn codRecibo;
        private DataGridViewTextBoxColumn fechaEmision;
        private DataGridViewTextBoxColumn codEmpleado;
        private DataGridViewTextBoxColumn apenom;
        private DataGridViewTextBoxColumn moneda;
        private DataGridViewTextBoxColumn sueldoBase;
        private DataGridViewTextBoxColumn descEssalud;
        private DataGridViewTextBoxColumn descOnp;
        private DataGridViewTextBoxColumn descAfp;
        private DataGridViewTextBoxColumn descFaltas;
        private DataGridViewTextBoxColumn sueldoTotal;
    }
}