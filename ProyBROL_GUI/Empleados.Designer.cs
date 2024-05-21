namespace ProyBROL_GUI
{
    partial class Empleados
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Empleados));
            label1 = new Label();
            txtFiltNombre = new TextBox();
            label4 = new Label();
            txtFiltCodigo = new TextBox();
            label2 = new Label();
            label5 = new Label();
            txtFiltApellido = new TextBox();
            groupBox1 = new GroupBox();
            label3 = new Label();
            txtNumReg = new TextBox();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnNuevo = new Button();
            gbMantEmpl = new GroupBox();
            lblMensaje = new Label();
            empleadoObjBEBindingSource = new BindingSource(components);
            dtgEmpleados = new DataGridView();
            codEmpleadoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            numroDocDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreDocumento = new DataGridViewTextBoxColumn();
            apellidosDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombresDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreHorario = new DataGridViewTextBoxColumn();
            nombreArea = new DataGridViewTextBoxColumn();
            nombreCargo = new DataGridViewTextBoxColumn();
            direccion = new DataGridViewTextBoxColumn();
            telefono = new DataGridViewTextBoxColumn();
            estadoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            gbMantEmpl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)empleadoObjBEBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgEmpleados).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Leelawadee", 15.75F);
            label1.Location = new Point(26, 19);
            label1.Name = "label1";
            label1.Size = new Size(224, 25);
            label1.TabIndex = 1;
            label1.Text = "Registro de Empleados";
            // 
            // txtFiltNombre
            // 
            txtFiltNombre.BorderStyle = BorderStyle.FixedSingle;
            txtFiltNombre.Location = new Point(546, 17);
            txtFiltNombre.Name = "txtFiltNombre";
            txtFiltNombre.Size = new Size(156, 23);
            txtFiltNombre.TabIndex = 4;
            txtFiltNombre.TextChanged += txtFiltNombre_TextChanged;
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
            // txtFiltCodigo
            // 
            txtFiltCodigo.BorderStyle = BorderStyle.FixedSingle;
            txtFiltCodigo.Location = new Point(61, 16);
            txtFiltCodigo.Name = "txtFiltCodigo";
            txtFiltCodigo.Size = new Size(191, 23);
            txtFiltCodigo.TabIndex = 6;
            txtFiltCodigo.TextChanged += txtFiltCodigo_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(261, 19);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 7;
            label2.Text = "Apellido:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(486, 19);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 8;
            label5.Text = "Nombre:";
            // 
            // txtFiltApellido
            // 
            txtFiltApellido.BorderStyle = BorderStyle.FixedSingle;
            txtFiltApellido.Location = new Point(325, 17);
            txtFiltApellido.Name = "txtFiltApellido";
            txtFiltApellido.Size = new Size(156, 23);
            txtFiltApellido.TabIndex = 9;
            txtFiltApellido.TextChanged += txtFiltApellido_TextChanged;
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
            groupBox1.Location = new Point(26, 47);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(713, 50);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Buscar empleado ";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(26, 418);
            label3.Name = "label3";
            label3.Size = new Size(84, 15);
            label3.TabIndex = 11;
            label3.Text = "Nro. Registros:";
            // 
            // txtNumReg
            // 
            txtNumReg.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtNumReg.BorderStyle = BorderStyle.FixedSingle;
            txtNumReg.Location = new Point(112, 415);
            txtNumReg.Name = "txtNumReg";
            txtNumReg.ReadOnly = true;
            txtNumReg.Size = new Size(45, 23);
            txtNumReg.TabIndex = 12;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.Black;
            btnModificar.FlatAppearance.BorderSize = 0;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Leelawadee", 9.75F);
            btnModificar.ForeColor = SystemColors.ControlLightLight;
            btnModificar.Location = new Point(17, 31);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(91, 48);
            btnModificar.TabIndex = 13;
            btnModificar.Text = "MODIFICAR";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Black;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Leelawadee", 9.75F);
            btnEliminar.ForeColor = SystemColors.ControlLightLight;
            btnEliminar.Location = new Point(212, 31);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(97, 48);
            btnEliminar.TabIndex = 14;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.Black;
            btnNuevo.FlatAppearance.BorderSize = 0;
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.Font = new Font("Leelawadee", 9.75F);
            btnNuevo.ForeColor = SystemColors.ControlLightLight;
            btnNuevo.Location = new Point(114, 31);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(92, 48);
            btnNuevo.TabIndex = 15;
            btnNuevo.Text = "NUEVO";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // gbMantEmpl
            // 
            gbMantEmpl.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            gbMantEmpl.Controls.Add(btnNuevo);
            gbMantEmpl.Controls.Add(btnModificar);
            gbMantEmpl.Controls.Add(btnEliminar);
            gbMantEmpl.Location = new Point(413, 418);
            gbMantEmpl.Name = "gbMantEmpl";
            gbMantEmpl.Size = new Size(326, 100);
            gbMantEmpl.TabIndex = 16;
            gbMantEmpl.TabStop = false;
            gbMantEmpl.Text = "Mantenimiento de Empleados";
            // 
            // lblMensaje
            // 
            lblMensaje.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblMensaje.AutoSize = true;
            lblMensaje.Location = new Point(32, 546);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(0, 15);
            lblMensaje.TabIndex = 17;
            // 
            // empleadoObjBEBindingSource
            // 
            empleadoObjBEBindingSource.DataSource = typeof(ProyBROL_BE.EmpleadoObjBE);
            // 
            // dtgEmpleados
            // 
            dtgEmpleados.AllowUserToAddRows = false;
            dtgEmpleados.AllowUserToDeleteRows = false;
            dtgEmpleados.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtgEmpleados.AutoGenerateColumns = false;
            dtgEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgEmpleados.Columns.AddRange(new DataGridViewColumn[] { codEmpleadoDataGridViewTextBoxColumn, numroDocDataGridViewTextBoxColumn, nombreDocumento, apellidosDataGridViewTextBoxColumn, nombresDataGridViewTextBoxColumn, nombreHorario, nombreArea, nombreCargo, direccion, telefono, estadoDataGridViewTextBoxColumn });
            dtgEmpleados.DataSource = empleadoObjBEBindingSource;
            dtgEmpleados.Location = new Point(26, 103);
            dtgEmpleados.Name = "dtgEmpleados";
            dtgEmpleados.ReadOnly = true;
            dtgEmpleados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgEmpleados.Size = new Size(713, 300);
            dtgEmpleados.TabIndex = 18;
            dtgEmpleados.CellClick += dtgEmpleados_CellClick;
            // 
            // codEmpleadoDataGridViewTextBoxColumn
            // 
            codEmpleadoDataGridViewTextBoxColumn.DataPropertyName = "codEmpleado";
            codEmpleadoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            codEmpleadoDataGridViewTextBoxColumn.Name = "codEmpleadoDataGridViewTextBoxColumn";
            codEmpleadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numroDocDataGridViewTextBoxColumn
            // 
            numroDocDataGridViewTextBoxColumn.DataPropertyName = "numroDoc";
            numroDocDataGridViewTextBoxColumn.HeaderText = "Documento Identidad";
            numroDocDataGridViewTextBoxColumn.Name = "numroDocDataGridViewTextBoxColumn";
            numroDocDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDocumento
            // 
            nombreDocumento.DataPropertyName = "nombreDocumento";
            nombreDocumento.HeaderText = "Tipo";
            nombreDocumento.Name = "nombreDocumento";
            nombreDocumento.ReadOnly = true;
            nombreDocumento.Width = 50;
            // 
            // apellidosDataGridViewTextBoxColumn
            // 
            apellidosDataGridViewTextBoxColumn.DataPropertyName = "apellidos";
            apellidosDataGridViewTextBoxColumn.HeaderText = "Apellidos";
            apellidosDataGridViewTextBoxColumn.Name = "apellidosDataGridViewTextBoxColumn";
            apellidosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombresDataGridViewTextBoxColumn
            // 
            nombresDataGridViewTextBoxColumn.DataPropertyName = "nombres";
            nombresDataGridViewTextBoxColumn.HeaderText = "Nombres";
            nombresDataGridViewTextBoxColumn.Name = "nombresDataGridViewTextBoxColumn";
            nombresDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreHorario
            // 
            nombreHorario.DataPropertyName = "nombreHorario";
            nombreHorario.HeaderText = "Horario";
            nombreHorario.Name = "nombreHorario";
            nombreHorario.ReadOnly = true;
            // 
            // nombreArea
            // 
            nombreArea.DataPropertyName = "nombreArea";
            nombreArea.HeaderText = "Area";
            nombreArea.Name = "nombreArea";
            nombreArea.ReadOnly = true;
            // 
            // nombreCargo
            // 
            nombreCargo.DataPropertyName = "nombreCargo";
            nombreCargo.HeaderText = "Cargo";
            nombreCargo.Name = "nombreCargo";
            nombreCargo.ReadOnly = true;
            // 
            // direccion
            // 
            direccion.DataPropertyName = "direccion";
            direccion.FillWeight = 200F;
            direccion.HeaderText = "Direccion";
            direccion.Name = "direccion";
            direccion.ReadOnly = true;
            // 
            // telefono
            // 
            telefono.DataPropertyName = "telefono";
            telefono.HeaderText = "Telefono";
            telefono.Name = "telefono";
            telefono.ReadOnly = true;
            telefono.Width = 120;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            estadoDataGridViewTextBoxColumn.DataPropertyName = "estado";
            estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            estadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Empleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(770, 570);
            Controls.Add(dtgEmpleados);
            Controls.Add(lblMensaje);
            Controls.Add(gbMantEmpl);
            Controls.Add(txtNumReg);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimizeBox = false;
            Name = "Empleados";
            Text = "Empleados";
            TopMost = true;
            WindowState = FormWindowState.Maximized;
            Load += Empleados_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            gbMantEmpl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)empleadoObjBEBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgEmpleados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox txtFiltNombre;
        private Label label4;
        private TextBox txtFiltCodigo;
        private Label label2;
        private Label label5;
        private TextBox txtFiltApellido;
        private GroupBox groupBox1;
        private Label label3;
        private TextBox txtNumReg;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnNuevo;
        private GroupBox gbMantEmpl;
        private Label lblMensaje;
        private BindingSource empleadoObjBEBindingSource;
        private DataGridView dtgEmpleados;
        private DataGridViewTextBoxColumn codEmpleadoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn numroDocDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreDocumento;
        private DataGridViewTextBoxColumn apellidosDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombresDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreHorario;
        private DataGridViewTextBoxColumn nombreArea;
        private DataGridViewTextBoxColumn nombreCargo;
        private DataGridViewTextBoxColumn direccion;
        private DataGridViewTextBoxColumn telefono;
        private DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
    }
}