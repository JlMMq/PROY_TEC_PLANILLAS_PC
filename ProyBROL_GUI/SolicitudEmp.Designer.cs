namespace ProyBROL_GUI
{
    partial class SolicitudEmp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SolicitudEmp));
            label1 = new Label();
            gbFormulario = new GroupBox();
            dtpHoraRetorn = new DateTimePicker();
            dtpHoraSalida = new DateTimePicker();
            label26 = new Label();
            label25 = new Label();
            txtContent = new TextBox();
            label24 = new Label();
            gbVacaciones = new GroupBox();
            rbVacParticionada = new RadioButton();
            rbVacCompleta = new RadioButton();
            label22 = new Label();
            label23 = new Label();
            button1 = new Button();
            btnModificar = new Button();
            txtApeNomJefe = new TextBox();
            label14 = new Label();
            dtFechaFin = new DateTimePicker();
            label13 = new Label();
            dtFechaIni = new DateTimePicker();
            label12 = new Label();
            label11 = new Label();
            label9 = new Label();
            gbLicencia = new GroupBox();
            rbLicNacido = new RadioButton();
            rbLicEnfermedad = new RadioButton();
            rbLicFamiliar = new RadioButton();
            rbLicMaternidad = new RadioButton();
            rbLicCalamidad = new RadioButton();
            rbLicMatrimonio = new RadioButton();
            label7 = new Label();
            label10 = new Label();
            gbPermiso = new GroupBox();
            rbPerOtros = new RadioButton();
            rbPerMedica = new RadioButton();
            rbdPerComision = new RadioButton();
            rbPerParticular = new RadioButton();
            label6 = new Label();
            label8 = new Label();
            txtTelf = new TextBox();
            label5 = new Label();
            txtDirec = new TextBox();
            label4 = new Label();
            txtCodSolicitante = new TextBox();
            label3 = new Label();
            txtApeNom = new TextBox();
            label2 = new Label();
            gbBuscar = new GroupBox();
            txtCargo = new TextBox();
            txtArea = new TextBox();
            label21 = new Label();
            label20 = new Label();
            button2 = new Button();
            label19 = new Label();
            txtCodFind = new TextBox();
            txtApeNomFind = new TextBox();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            txtBuscarJefe = new TextBox();
            label15 = new Label();
            imgFoto = new PictureBox();
            gbFormulario.SuspendLayout();
            gbVacaciones.SuspendLayout();
            gbLicencia.SuspendLayout();
            gbPermiso.SuspendLayout();
            gbBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgFoto).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Leelawadee", 15.75F);
            label1.Location = new Point(29, 25);
            label1.Name = "label1";
            label1.Size = new Size(448, 25);
            label1.TabIndex = 4;
            label1.Text = "Formulario de Solicitud de Licencias y Permisos";
            // 
            // gbFormulario
            // 
            gbFormulario.Controls.Add(dtpHoraRetorn);
            gbFormulario.Controls.Add(dtpHoraSalida);
            gbFormulario.Controls.Add(label26);
            gbFormulario.Controls.Add(label25);
            gbFormulario.Controls.Add(txtContent);
            gbFormulario.Controls.Add(label24);
            gbFormulario.Controls.Add(gbVacaciones);
            gbFormulario.Controls.Add(button1);
            gbFormulario.Controls.Add(btnModificar);
            gbFormulario.Controls.Add(txtApeNomJefe);
            gbFormulario.Controls.Add(label14);
            gbFormulario.Controls.Add(dtFechaFin);
            gbFormulario.Controls.Add(label13);
            gbFormulario.Controls.Add(dtFechaIni);
            gbFormulario.Controls.Add(label12);
            gbFormulario.Controls.Add(label11);
            gbFormulario.Controls.Add(label9);
            gbFormulario.Controls.Add(gbLicencia);
            gbFormulario.Controls.Add(gbPermiso);
            gbFormulario.Controls.Add(txtTelf);
            gbFormulario.Controls.Add(label5);
            gbFormulario.Controls.Add(txtDirec);
            gbFormulario.Controls.Add(label4);
            gbFormulario.Controls.Add(txtCodSolicitante);
            gbFormulario.Controls.Add(label3);
            gbFormulario.Controls.Add(txtApeNom);
            gbFormulario.Controls.Add(label2);
            gbFormulario.Location = new Point(29, 53);
            gbFormulario.Name = "gbFormulario";
            gbFormulario.Size = new Size(777, 843);
            gbFormulario.TabIndex = 5;
            gbFormulario.TabStop = false;
            gbFormulario.Text = "Formulario ";
            // 
            // dtpHoraRetorn
            // 
            dtpHoraRetorn.CustomFormat = "HH:mm:ss tt";
            dtpHoraRetorn.Format = DateTimePickerFormat.Time;
            dtpHoraRetorn.Location = new Point(351, 621);
            dtpHoraRetorn.Name = "dtpHoraRetorn";
            dtpHoraRetorn.ShowUpDown = true;
            dtpHoraRetorn.Size = new Size(69, 23);
            dtpHoraRetorn.TabIndex = 44;
            // 
            // dtpHoraSalida
            // 
            dtpHoraSalida.CustomFormat = "HH:mm:ss tt";
            dtpHoraSalida.Format = DateTimePickerFormat.Time;
            dtpHoraSalida.Location = new Point(159, 621);
            dtpHoraSalida.Name = "dtpHoraSalida";
            dtpHoraSalida.ShowUpDown = true;
            dtpHoraSalida.Size = new Size(69, 23);
            dtpHoraSalida.TabIndex = 43;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(264, 625);
            label26.Name = "label26";
            label26.Size = new Size(81, 15);
            label26.TabIndex = 42;
            label26.Text = "Hora Retorno:";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(83, 625);
            label25.Name = "label25";
            label25.Size = new Size(70, 15);
            label25.TabIndex = 41;
            label25.Text = "Hora Salida:";
            // 
            // txtContent
            // 
            txtContent.BorderStyle = BorderStyle.FixedSingle;
            txtContent.Location = new Point(36, 463);
            txtContent.Multiline = true;
            txtContent.Name = "txtContent";
            txtContent.Size = new Size(709, 81);
            txtContent.TabIndex = 40;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(33, 445);
            label24.Name = "label24";
            label24.Size = new Size(183, 15);
            label24.TabIndex = 39;
            label24.Text = "Informacion adicional: (opcional)";
            // 
            // gbVacaciones
            // 
            gbVacaciones.Controls.Add(rbVacParticionada);
            gbVacaciones.Controls.Add(rbVacCompleta);
            gbVacaciones.Controls.Add(label22);
            gbVacaciones.Controls.Add(label23);
            gbVacaciones.Location = new Point(25, 365);
            gbVacaciones.Name = "gbVacaciones";
            gbVacaciones.Size = new Size(717, 65);
            gbVacaciones.TabIndex = 38;
            gbVacaciones.TabStop = false;
            // 
            // rbVacParticionada
            // 
            rbVacParticionada.AutoSize = true;
            rbVacParticionada.Location = new Point(372, 35);
            rbVacParticionada.Name = "rbVacParticionada";
            rbVacParticionada.Size = new Size(96, 19);
            rbVacParticionada.TabIndex = 29;
            rbVacParticionada.TabStop = true;
            rbVacParticionada.Text = "Particionadas";
            rbVacParticionada.UseVisualStyleBackColor = true;
            // 
            // rbVacCompleta
            // 
            rbVacCompleta.AutoSize = true;
            rbVacCompleta.Location = new Point(100, 35);
            rbVacCompleta.Name = "rbVacCompleta";
            rbVacCompleta.Size = new Size(82, 19);
            rbVacCompleta.TabIndex = 28;
            rbVacCompleta.TabStop = true;
            rbVacCompleta.Text = "Completas";
            rbVacCompleta.UseVisualStyleBackColor = true;
            rbVacCompleta.CheckedChanged += rbVacCompleta_CheckedChanged;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label22.Location = new Point(8, 0);
            label22.Name = "label22";
            label22.Size = new Size(90, 21);
            label22.TabIndex = 21;
            label22.Text = "Vacaciones";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(21, 33);
            label23.Name = "label23";
            label23.Size = new Size(55, 15);
            label23.TabIndex = 22;
            label23.Text = "ASUNTO:";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top;
            button1.BackColor = Color.Black;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Leelawadee", 9.75F);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(530, 742);
            button1.Name = "button1";
            button1.Size = new Size(103, 48);
            button1.TabIndex = 37;
            button1.Text = "CANCELAR";
            button1.UseVisualStyleBackColor = false;
            button1.Visible = false;
            // 
            // btnModificar
            // 
            btnModificar.Anchor = AnchorStyles.Top;
            btnModificar.BackColor = Color.Black;
            btnModificar.FlatAppearance.BorderSize = 0;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Leelawadee", 9.75F);
            btnModificar.ForeColor = SystemColors.ControlLightLight;
            btnModificar.Location = new Point(649, 742);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(103, 48);
            btnModificar.TabIndex = 36;
            btnModificar.Text = "ENVIAR";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // txtApeNomJefe
            // 
            txtApeNomJefe.BorderStyle = BorderStyle.FixedSingle;
            txtApeNomJefe.Location = new Point(277, 665);
            txtApeNomJefe.Name = "txtApeNomJefe";
            txtApeNomJefe.Size = new Size(470, 23);
            txtApeNomJefe.TabIndex = 35;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(38, 667);
            label14.Name = "label14";
            label14.Size = new Size(233, 15);
            label14.TabIndex = 34;
            label14.Text = "Apellidos y nombres del jefe (a) inmediato:";
            // 
            // dtFechaFin
            // 
            dtFechaFin.Location = new Point(407, 582);
            dtFechaFin.Name = "dtFechaFin";
            dtFechaFin.Size = new Size(226, 23);
            dtFechaFin.TabIndex = 33;
            dtFechaFin.DataContextChanged += dtFechaFin_DataContextChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(360, 588);
            label13.Name = "label13";
            label13.Size = new Size(41, 15);
            label13.TabIndex = 32;
            label13.Text = ", hasta";
            // 
            // dtFechaIni
            // 
            dtFechaIni.Location = new Point(128, 582);
            dtFechaIni.MinDate = new DateTime(2024, 7, 3, 20, 37, 36, 0);
            dtFechaIni.Name = "dtFechaIni";
            dtFechaIni.Size = new Size(226, 23);
            dtFechaIni.TabIndex = 31;
            dtFechaIni.Value = new DateTime(2024, 7, 3, 20, 37, 36, 0);
            dtFechaIni.ValueChanged += dtFechaIni_ValueChanged;
            dtFechaIni.DataContextChanged += dtFechaIni_DataContextChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(33, 558);
            label12.Name = "label12";
            label12.Size = new Size(140, 15);
            label12.TabIndex = 30;
            label12.Text = "Ausencia aproximada de:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(83, 588);
            label11.Name = "label11";
            label11.Size = new Size(39, 15);
            label11.TabIndex = 29;
            label11.Text = "Desde";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(36, 588);
            label9.Name = "label9";
            label9.Size = new Size(41, 15);
            label9.TabIndex = 28;
            label9.Text = "Fecha:";
            // 
            // gbLicencia
            // 
            gbLicencia.Controls.Add(rbLicNacido);
            gbLicencia.Controls.Add(rbLicEnfermedad);
            gbLicencia.Controls.Add(rbLicFamiliar);
            gbLicencia.Controls.Add(rbLicMaternidad);
            gbLicencia.Controls.Add(rbLicCalamidad);
            gbLicencia.Controls.Add(rbLicMatrimonio);
            gbLicencia.Controls.Add(label7);
            gbLicencia.Controls.Add(label10);
            gbLicencia.Location = new Point(25, 246);
            gbLicencia.Name = "gbLicencia";
            gbLicencia.Size = new Size(717, 113);
            gbLicencia.TabIndex = 27;
            gbLicencia.TabStop = false;
            // 
            // rbLicNacido
            // 
            rbLicNacido.AutoSize = true;
            rbLicNacido.Location = new Point(372, 81);
            rbLicNacido.Name = "rbLicNacido";
            rbLicNacido.Size = new Size(163, 19);
            rbLicNacido.TabIndex = 35;
            rbLicNacido.TabStop = true;
            rbLicNacido.Text = "Cuidado del recién nacido";
            rbLicNacido.UseVisualStyleBackColor = true;
            // 
            // rbLicEnfermedad
            // 
            rbLicEnfermedad.AutoSize = true;
            rbLicEnfermedad.Location = new Point(372, 56);
            rbLicEnfermedad.Name = "rbLicEnfermedad";
            rbLicEnfermedad.Size = new Size(89, 19);
            rbLicEnfermedad.TabIndex = 34;
            rbLicEnfermedad.TabStop = true;
            rbLicEnfermedad.Text = "Enfermedad";
            rbLicEnfermedad.UseVisualStyleBackColor = true;
            // 
            // rbLicFamiliar
            // 
            rbLicFamiliar.AutoSize = true;
            rbLicFamiliar.Location = new Point(372, 31);
            rbLicFamiliar.Name = "rbLicFamiliar";
            rbLicFamiliar.Size = new Size(226, 19);
            rbLicFamiliar.TabIndex = 33;
            rbLicFamiliar.TabStop = true;
            rbLicFamiliar.Text = "Cuidado de Familiar con discapacidad";
            rbLicFamiliar.UseVisualStyleBackColor = true;
            // 
            // rbLicMaternidad
            // 
            rbLicMaternidad.AutoSize = true;
            rbLicMaternidad.Location = new Point(100, 81);
            rbLicMaternidad.Name = "rbLicMaternidad";
            rbLicMaternidad.Size = new Size(167, 19);
            rbLicMaternidad.TabIndex = 32;
            rbLicMaternidad.TabStop = true;
            rbLicMaternidad.Text = "Maternidad y/o Paternidad";
            rbLicMaternidad.UseVisualStyleBackColor = true;
            // 
            // rbLicCalamidad
            // 
            rbLicCalamidad.AutoSize = true;
            rbLicCalamidad.Location = new Point(100, 56);
            rbLicCalamidad.Name = "rbLicCalamidad";
            rbLicCalamidad.Size = new Size(141, 19);
            rbLicCalamidad.TabIndex = 31;
            rbLicCalamidad.TabStop = true;
            rbLicCalamidad.Text = "Calamidad Domestica";
            rbLicCalamidad.UseVisualStyleBackColor = true;
            // 
            // rbLicMatrimonio
            // 
            rbLicMatrimonio.AutoSize = true;
            rbLicMatrimonio.Location = new Point(100, 31);
            rbLicMatrimonio.Name = "rbLicMatrimonio";
            rbLicMatrimonio.Size = new Size(187, 19);
            rbLicMatrimonio.TabIndex = 30;
            rbLicMatrimonio.TabStop = true;
            rbLicMatrimonio.Text = "Matrimonio o Unión de Hecho";
            rbLicMatrimonio.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(8, 0);
            label7.Name = "label7";
            label7.Size = new Size(68, 21);
            label7.TabIndex = 21;
            label7.Text = "Licencia";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(21, 33);
            label10.Name = "label10";
            label10.Size = new Size(55, 15);
            label10.TabIndex = 22;
            label10.Text = "ASUNTO:";
            // 
            // gbPermiso
            // 
            gbPermiso.Controls.Add(rbPerOtros);
            gbPermiso.Controls.Add(rbPerMedica);
            gbPermiso.Controls.Add(rbdPerComision);
            gbPermiso.Controls.Add(rbPerParticular);
            gbPermiso.Controls.Add(label6);
            gbPermiso.Controls.Add(label8);
            gbPermiso.Location = new Point(25, 150);
            gbPermiso.Name = "gbPermiso";
            gbPermiso.Size = new Size(717, 90);
            gbPermiso.TabIndex = 26;
            gbPermiso.TabStop = false;
            // 
            // rbPerOtros
            // 
            rbPerOtros.AutoSize = true;
            rbPerOtros.Location = new Point(534, 29);
            rbPerOtros.Name = "rbPerOtros";
            rbPerOtros.Size = new Size(54, 19);
            rbPerOtros.TabIndex = 31;
            rbPerOtros.Text = "Otros";
            rbPerOtros.UseVisualStyleBackColor = true;
            // 
            // rbPerMedica
            // 
            rbPerMedica.AutoSize = true;
            rbPerMedica.Location = new Point(335, 29);
            rbPerMedica.Name = "rbPerMedica";
            rbPerMedica.Size = new Size(88, 19);
            rbPerMedica.TabIndex = 30;
            rbPerMedica.Text = "Cita Médica";
            rbPerMedica.UseVisualStyleBackColor = true;
            // 
            // rbdPerComision
            // 
            rbdPerComision.AutoSize = true;
            rbdPerComision.Location = new Point(100, 56);
            rbdPerComision.Name = "rbdPerComision";
            rbdPerComision.Size = new Size(113, 19);
            rbdPerComision.TabIndex = 29;
            rbdPerComision.Text = "Comisión Oficial";
            rbdPerComision.UseVisualStyleBackColor = true;
            // 
            // rbPerParticular
            // 
            rbPerParticular.AutoSize = true;
            rbPerParticular.Checked = true;
            rbPerParticular.Location = new Point(100, 31);
            rbPerParticular.Name = "rbPerParticular";
            rbPerParticular.Size = new Size(75, 19);
            rbPerParticular.TabIndex = 28;
            rbPerParticular.TabStop = true;
            rbPerParticular.Text = "Particular";
            rbPerParticular.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(8, 0);
            label6.Name = "label6";
            label6.Size = new Size(68, 21);
            label6.TabIndex = 23;
            label6.Text = "Permiso";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(21, 33);
            label8.Name = "label8";
            label8.Size = new Size(55, 15);
            label8.TabIndex = 22;
            label8.Text = "ASUNTO:";
            // 
            // txtTelf
            // 
            txtTelf.BorderStyle = BorderStyle.FixedSingle;
            txtTelf.Location = new Point(125, 121);
            txtTelf.Name = "txtTelf";
            txtTelf.ReadOnly = true;
            txtTelf.Size = new Size(164, 23);
            txtTelf.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 123);
            label5.Name = "label5";
            label5.Size = new Size(94, 15);
            label5.TabIndex = 18;
            label5.Text = "Numero Celular:";
            // 
            // txtDirec
            // 
            txtDirec.BorderStyle = BorderStyle.FixedSingle;
            txtDirec.Location = new Point(157, 84);
            txtDirec.Name = "txtDirec";
            txtDirec.ReadOnly = true;
            txtDirec.Size = new Size(585, 23);
            txtDirec.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 86);
            label4.Name = "label4";
            label4.Size = new Size(126, 15);
            label4.TabIndex = 16;
            label4.Text = "Direccion Domiciliaria:";
            // 
            // txtCodSolicitante
            // 
            txtCodSolicitante.BorderStyle = BorderStyle.FixedSingle;
            txtCodSolicitante.Location = new Point(629, 41);
            txtCodSolicitante.Name = "txtCodSolicitante";
            txtCodSolicitante.ReadOnly = true;
            txtCodSolicitante.Size = new Size(113, 23);
            txtCodSolicitante.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(518, 43);
            label3.Name = "label3";
            label3.Size = new Size(105, 15);
            label3.TabIndex = 14;
            label3.Text = "Codigo empleado:";
            // 
            // txtApeNom
            // 
            txtApeNom.BorderStyle = BorderStyle.FixedSingle;
            txtApeNom.Location = new Point(151, 41);
            txtApeNom.Name = "txtApeNom";
            txtApeNom.ReadOnly = true;
            txtApeNom.Size = new Size(352, 23);
            txtApeNom.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 43);
            label2.Name = "label2";
            label2.Size = new Size(120, 15);
            label2.TabIndex = 0;
            label2.Text = "Apellidos y Nombres:";
            // 
            // gbBuscar
            // 
            gbBuscar.Controls.Add(txtCargo);
            gbBuscar.Controls.Add(txtArea);
            gbBuscar.Controls.Add(label21);
            gbBuscar.Controls.Add(label20);
            gbBuscar.Controls.Add(button2);
            gbBuscar.Controls.Add(label19);
            gbBuscar.Controls.Add(txtCodFind);
            gbBuscar.Controls.Add(txtApeNomFind);
            gbBuscar.Controls.Add(label18);
            gbBuscar.Controls.Add(label17);
            gbBuscar.Controls.Add(label16);
            gbBuscar.Controls.Add(txtBuscarJefe);
            gbBuscar.Controls.Add(label15);
            gbBuscar.Controls.Add(imgFoto);
            gbBuscar.Location = new Point(815, 53);
            gbBuscar.Name = "gbBuscar";
            gbBuscar.Size = new Size(357, 591);
            gbBuscar.TabIndex = 6;
            gbBuscar.TabStop = false;
            gbBuscar.Text = "Buscar empleado:";
            // 
            // txtCargo
            // 
            txtCargo.BorderStyle = BorderStyle.FixedSingle;
            txtCargo.Location = new Point(78, 265);
            txtCargo.Name = "txtCargo";
            txtCargo.ReadOnly = true;
            txtCargo.Size = new Size(220, 23);
            txtCargo.TabIndex = 42;
            // 
            // txtArea
            // 
            txtArea.BorderStyle = BorderStyle.FixedSingle;
            txtArea.Location = new Point(78, 234);
            txtArea.Name = "txtArea";
            txtArea.ReadOnly = true;
            txtArea.Size = new Size(210, 23);
            txtArea.TabIndex = 41;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(22, 267);
            label21.Name = "label21";
            label21.Size = new Size(42, 15);
            label21.TabIndex = 40;
            label21.Text = "Cargo:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(22, 236);
            label20.Name = "label20";
            label20.Size = new Size(34, 15);
            label20.TabIndex = 39;
            label20.Text = "Area:";
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top;
            button2.BackColor = Color.Black;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Leelawadee", 9.75F);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(245, 525);
            button2.Name = "button2";
            button2.Size = new Size(103, 48);
            button2.TabIndex = 38;
            button2.Text = "SELECCIONAR";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(34, 336);
            label19.Name = "label19";
            label19.Size = new Size(34, 15);
            label19.TabIndex = 21;
            label19.Text = "Foto:";
            // 
            // txtCodFind
            // 
            txtCodFind.BorderStyle = BorderStyle.FixedSingle;
            txtCodFind.Location = new Point(133, 194);
            txtCodFind.Name = "txtCodFind";
            txtCodFind.ReadOnly = true;
            txtCodFind.Size = new Size(136, 23);
            txtCodFind.TabIndex = 20;
            // 
            // txtApeNomFind
            // 
            txtApeNomFind.BorderStyle = BorderStyle.FixedSingle;
            txtApeNomFind.Location = new Point(22, 166);
            txtApeNomFind.Name = "txtApeNomFind";
            txtApeNomFind.ReadOnly = true;
            txtApeNomFind.Size = new Size(326, 23);
            txtApeNomFind.TabIndex = 19;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(22, 198);
            label18.Name = "label18";
            label18.Size = new Size(105, 15);
            label18.TabIndex = 18;
            label18.Text = "Codigo empleado:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(22, 141);
            label17.Name = "label17";
            label17.Size = new Size(164, 15);
            label17.TabIndex = 17;
            label17.Text = "Apellido y Nombre completo:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(17, 111);
            label16.Name = "label16";
            label16.Size = new Size(62, 15);
            label16.TabIndex = 16;
            label16.Text = "Resultado:";
            // 
            // txtBuscarJefe
            // 
            txtBuscarJefe.BorderStyle = BorderStyle.FixedSingle;
            txtBuscarJefe.Location = new Point(17, 68);
            txtBuscarJefe.Name = "txtBuscarJefe";
            txtBuscarJefe.Size = new Size(331, 23);
            txtBuscarJefe.TabIndex = 15;
            txtBuscarJefe.TextChanged += txtBuscarJefe_TextChanged;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(17, 43);
            label15.Name = "label15";
            label15.Size = new Size(180, 15);
            label15.TabIndex = 14;
            label15.Text = "Buscar por Nombres o Apellidos:";
            // 
            // imgFoto
            // 
            imgFoto.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            imgFoto.BorderStyle = BorderStyle.FixedSingle;
            imgFoto.Image = Properties.Resources.noimage;
            imgFoto.Location = new Point(109, 336);
            imgFoto.Name = "imgFoto";
            imgFoto.Size = new Size(179, 179);
            imgFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            imgFoto.TabIndex = 13;
            imgFoto.TabStop = false;
            // 
            // SolicitudEmp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1197, 924);
            Controls.Add(gbBuscar);
            Controls.Add(gbFormulario);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SolicitudEmp";
            Text = "Solicitudes";
            WindowState = FormWindowState.Maximized;
            Load += SolicitudEmp_Load;
            gbFormulario.ResumeLayout(false);
            gbFormulario.PerformLayout();
            gbVacaciones.ResumeLayout(false);
            gbVacaciones.PerformLayout();
            gbLicencia.ResumeLayout(false);
            gbLicencia.PerformLayout();
            gbPermiso.ResumeLayout(false);
            gbPermiso.PerformLayout();
            gbBuscar.ResumeLayout(false);
            gbBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgFoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox gbFormulario;
        private Label label2;
        private TextBox txtTelf;
        private Label label5;
        private TextBox txtDirec;
        private Label label4;
        private TextBox txtCodSolicitante;
        private Label label3;
        private TextBox txtApeNom;
        private Label label8;
        private Label label7;
        private GroupBox gbLicencia;
        private CheckBox checkBox8;
        private CheckBox checkBox4;
        private CheckBox checkBox5;
        private Label label10;
        private GroupBox gbPermiso;
        private RadioButton rbPerOtros;
        private RadioButton rbPerMedica;
        private RadioButton rbdPerComision;
        private Label label6;
        private CheckBox checkBox9;
        private Label label12;
        private Label label11;
        private Label label9;
        private Label label14;
        private DateTimePicker dtFechaFin;
        private Label label13;
        private DateTimePicker dtFechaIni;
        private TextBox txtApeNomJefe;
        private Button button1;
        private Button btnModificar;
        private GroupBox gbBuscar;
        private TextBox txtBuscarJefe;
        private Label label15;
        private PictureBox imgFoto;
        private Button button2;
        private Label label19;
        private TextBox txtCodFind;
        private TextBox txtApeNomFind;
        private Label label18;
        private Label label17;
        private Label label16;
        private TextBox txtCargo;
        private TextBox txtArea;
        private Label label21;
        private Label label20;
        private GroupBox gbVacaciones;
        private Label label22;
        private Label label23;
        private RadioButton radioButton1;
        private RadioButton rbVacParticionada;
        private RadioButton rbVacCompleta;
        private RadioButton radioButton6;
        private RadioButton radioButton5;
        private RadioButton radioButton4;
        private RadioButton rbPerParticular;
        private RadioButton rbLicMatrimonio;
        private RadioButton rbLicCalamidad;
        private RadioButton rbLicNacido;
        private RadioButton rbLicEnfermedad;
        private RadioButton rbLicFamiliar;
        private RadioButton rbLicMaternidad;
        private TextBox txtContent;
        private Label label24;
        private Label label25;
        private Label label26;
        private DateTimePicker dtpHoraRetorn;
        private DateTimePicker dtpHoraSalida;
    }
}