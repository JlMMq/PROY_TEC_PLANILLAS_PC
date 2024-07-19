namespace ProyBROL_GUI
{
    partial class Asistencias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Asistencias));
            label1 = new Label();
            dtgDiario = new DataGridView();
            codDiar = new DataGridViewTextBoxColumn();
            fecha = new DataGridViewTextBoxColumn();
            empleado = new DataGridViewTextBoxColumn();
            apenom = new DataGridViewTextBoxColumn();
            horario = new DataGridViewTextBoxColumn();
            desHorario = new DataGridViewTextBoxColumn();
            hora1 = new DataGridViewTextBoxColumn();
            hora2 = new DataGridViewTextBoxColumn();
            hora3 = new DataGridViewTextBoxColumn();
            hora4 = new DataGridViewTextBoxColumn();
            ingrTard = new DataGridViewTextBoxColumn();
            exeRefr = new DataGridViewTextBoxColumn();
            exeJornd = new DataGridViewTextBoxColumn();
            observ = new DataGridViewTextBoxColumn();
            gbBusqueda = new GroupBox();
            chkAdmin = new CheckBox();
            btnBuscar = new Button();
            txtCodEmpleado = new TextBox();
            lblEmpleado = new Label();
            dtpFecFin = new DateTimePicker();
            dtpFecInicio = new DateTimePicker();
            label4 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgDiario).BeginInit();
            gbBusqueda.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Leelawadee", 15.75F);
            label1.Location = new Point(32, 23);
            label1.Name = "label1";
            label1.Size = new Size(293, 25);
            label1.TabIndex = 5;
            label1.Text = "Registro de asistencias por dia";
            // 
            // dtgDiario
            // 
            dtgDiario.AllowUserToAddRows = false;
            dtgDiario.AllowUserToDeleteRows = false;
            dtgDiario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgDiario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDiario.Columns.AddRange(new DataGridViewColumn[] { codDiar, fecha, empleado, apenom, horario, desHorario, hora1, hora2, hora3, hora4, ingrTard, exeRefr, exeJornd, observ });
            dtgDiario.Location = new Point(32, 144);
            dtgDiario.Name = "dtgDiario";
            dtgDiario.ReadOnly = true;
            dtgDiario.Size = new Size(1124, 551);
            dtgDiario.TabIndex = 6;
            dtgDiario.RowPrePaint += dtgDiario_RowPrePaint;
            // 
            // codDiar
            // 
            codDiar.DataPropertyName = "codDiar";
            codDiar.HeaderText = "Cod. Marcas";
            codDiar.Name = "codDiar";
            codDiar.ReadOnly = true;
            codDiar.Width = 80;
            // 
            // fecha
            // 
            fecha.DataPropertyName = "fecha";
            fecha.HeaderText = "Fecha de Marcas";
            fecha.Name = "fecha";
            fecha.ReadOnly = true;
            // 
            // empleado
            // 
            empleado.DataPropertyName = "empleado";
            empleado.HeaderText = "Cod.Empleado";
            empleado.Name = "empleado";
            empleado.ReadOnly = true;
            empleado.Visible = false;
            // 
            // apenom
            // 
            apenom.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            apenom.DataPropertyName = "apenom";
            apenom.HeaderText = "Apellidos y Nombres";
            apenom.Name = "apenom";
            apenom.ReadOnly = true;
            apenom.Visible = false;
            // 
            // horario
            // 
            horario.DataPropertyName = "horario";
            horario.HeaderText = "Codigo Horario";
            horario.Name = "horario";
            horario.ReadOnly = true;
            horario.Visible = false;
            // 
            // desHorario
            // 
            desHorario.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            desHorario.DataPropertyName = "desHorario";
            desHorario.HeaderText = "Horario";
            desHorario.Name = "desHorario";
            desHorario.ReadOnly = true;
            desHorario.Visible = false;
            // 
            // hora1
            // 
            hora1.DataPropertyName = "hora1";
            hora1.HeaderText = "Hora Ingreso";
            hora1.Name = "hora1";
            hora1.ReadOnly = true;
            // 
            // hora2
            // 
            hora2.DataPropertyName = "hora2";
            hora2.HeaderText = "Salida Almuerzo";
            hora2.Name = "hora2";
            hora2.ReadOnly = true;
            // 
            // hora3
            // 
            hora3.DataPropertyName = "hora3";
            hora3.HeaderText = "Entrada Almuerzo";
            hora3.Name = "hora3";
            hora3.ReadOnly = true;
            // 
            // hora4
            // 
            hora4.DataPropertyName = "hora4";
            hora4.HeaderText = "Hora Salida";
            hora4.Name = "hora4";
            hora4.ReadOnly = true;
            // 
            // ingrTard
            // 
            ingrTard.DataPropertyName = "ingrTard";
            ingrTard.HeaderText = "Tiempo Tardanza";
            ingrTard.Name = "ingrTard";
            ingrTard.ReadOnly = true;
            // 
            // exeRefr
            // 
            exeRefr.DataPropertyName = "exeRefr";
            exeRefr.HeaderText = "exeRefr";
            exeRefr.Name = "exeRefr";
            exeRefr.ReadOnly = true;
            exeRefr.Visible = false;
            // 
            // exeJornd
            // 
            exeJornd.DataPropertyName = "exeJornd";
            exeJornd.HeaderText = "exeJornd";
            exeJornd.Name = "exeJornd";
            exeJornd.ReadOnly = true;
            exeJornd.Visible = false;
            // 
            // observ
            // 
            observ.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            observ.DataPropertyName = "observ";
            observ.HeaderText = "Observacion";
            observ.Name = "observ";
            observ.ReadOnly = true;
            // 
            // gbBusqueda
            // 
            gbBusqueda.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gbBusqueda.Controls.Add(chkAdmin);
            gbBusqueda.Controls.Add(btnBuscar);
            gbBusqueda.Controls.Add(txtCodEmpleado);
            gbBusqueda.Controls.Add(lblEmpleado);
            gbBusqueda.Controls.Add(dtpFecFin);
            gbBusqueda.Controls.Add(dtpFecInicio);
            gbBusqueda.Controls.Add(label4);
            gbBusqueda.Controls.Add(label3);
            gbBusqueda.Location = new Point(32, 51);
            gbBusqueda.Name = "gbBusqueda";
            gbBusqueda.Size = new Size(1124, 78);
            gbBusqueda.TabIndex = 7;
            gbBusqueda.TabStop = false;
            gbBusqueda.Text = "Busqueda";
            // 
            // chkAdmin
            // 
            chkAdmin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            chkAdmin.AutoSize = true;
            chkAdmin.FlatStyle = FlatStyle.Flat;
            chkAdmin.Location = new Point(762, 34);
            chkAdmin.Name = "chkAdmin";
            chkAdmin.Size = new Size(165, 19);
            chkAdmin.TabIndex = 41;
            chkAdmin.Text = "Habilitar búsqueda general";
            chkAdmin.UseVisualStyleBackColor = true;
            chkAdmin.Visible = false;
            chkAdmin.CheckedChanged += chkAdmin_CheckedChanged;
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBuscar.BackColor = Color.Black;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Leelawadee", 9.75F);
            btnBuscar.ForeColor = SystemColors.ControlLightLight;
            btnBuscar.Location = new Point(956, 24);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(153, 38);
            btnBuscar.TabIndex = 40;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtCodEmpleado
            // 
            txtCodEmpleado.BorderStyle = BorderStyle.FixedSingle;
            txtCodEmpleado.Location = new Point(549, 30);
            txtCodEmpleado.Name = "txtCodEmpleado";
            txtCodEmpleado.Size = new Size(184, 23);
            txtCodEmpleado.TabIndex = 22;
            txtCodEmpleado.Visible = false;
            txtCodEmpleado.KeyPress += txtCodEmpleado_KeyPress;
            // 
            // lblEmpleado
            // 
            lblEmpleado.AutoSize = true;
            lblEmpleado.Location = new Point(422, 32);
            lblEmpleado.Name = "lblEmpleado";
            lblEmpleado.Size = new Size(121, 15);
            lblEmpleado.TabIndex = 21;
            lblEmpleado.Text = "Codigo de Empleado:";
            lblEmpleado.Visible = false;
            // 
            // dtpFecFin
            // 
            dtpFecFin.CustomFormat = "";
            dtpFecFin.Format = DateTimePickerFormat.Short;
            dtpFecFin.Location = new Point(305, 30);
            dtpFecFin.Name = "dtpFecFin";
            dtpFecFin.Size = new Size(95, 23);
            dtpFecFin.TabIndex = 20;
            // 
            // dtpFecInicio
            // 
            dtpFecInicio.CustomFormat = "";
            dtpFecInicio.Format = DateTimePickerFormat.Short;
            dtpFecInicio.Location = new Point(107, 30);
            dtpFecInicio.Name = "dtpFecInicio";
            dtpFecInicio.Size = new Size(95, 23);
            dtpFecInicio.TabIndex = 19;
            dtpFecInicio.ValueChanged += dtpFecInicio_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(225, 32);
            label4.Name = "label4";
            label4.Size = new Size(74, 15);
            label4.TabIndex = 18;
            label4.Text = "Fecha de fin:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 32);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 17;
            label3.Text = "Fecha inicio:";
            // 
            // Asistencias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1197, 924);
            Controls.Add(gbBusqueda);
            Controls.Add(dtgDiario);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Asistencias";
            Text = "Asistencias";
            WindowState = FormWindowState.Maximized;
            Load += Asistencias_Load;
            ((System.ComponentModel.ISupportInitialize)dtgDiario).EndInit();
            gbBusqueda.ResumeLayout(false);
            gbBusqueda.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dtgDiario;
        private GroupBox gbBusqueda;
        private DateTimePicker dtpFecFin;
        private DateTimePicker dtpFecInicio;
        private Label label4;
        private Label label3;
        private Label lblEmpleado;
        private TextBox txtCodEmpleado;
        private Button btnBuscar;
        private CheckBox chkAdmin;
        private DataGridViewTextBoxColumn codDiar;
        private DataGridViewTextBoxColumn fecha;
        private DataGridViewTextBoxColumn empleado;
        private DataGridViewTextBoxColumn apenom;
        private DataGridViewTextBoxColumn horario;
        private DataGridViewTextBoxColumn desHorario;
        private DataGridViewTextBoxColumn hora1;
        private DataGridViewTextBoxColumn hora2;
        private DataGridViewTextBoxColumn hora3;
        private DataGridViewTextBoxColumn hora4;
        private DataGridViewTextBoxColumn ingrTard;
        private DataGridViewTextBoxColumn exeRefr;
        private DataGridViewTextBoxColumn exeJornd;
        private DataGridViewTextBoxColumn observ;
    }
}