namespace logistic_BD.Views.Doc_Views
{
    partial class WaybillEditView
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMedicalExam = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtWbNumber = new System.Windows.Forms.TextBox();
            this.dtpWbDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpUntil = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbTransportType = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbMessageType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDepartureTime = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpPreTripDate = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpPreTripTime = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.btnOpenVehicle = new System.Windows.Forms.Button();
            this.cmbVehicle = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnOpenDriver = new System.Windows.Forms.Button();
            this.cmbDriver = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnOpenCustomer = new System.Windows.Forms.Button();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnOpenOrg = new System.Windows.Forms.Button();
            this.cmbOrganization = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnOpenPersonFillingOut = new System.Windows.Forms.Button();
            this.cmbPersonFillingOut = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnOpenMechanic = new System.Windows.Forms.Button();
            this.cmbMechanic = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btnOpenController = new System.Windows.Forms.Button();
            this.cmbController = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.btnTrailer = new System.Windows.Forms.Button();
            this.btnWork = new System.Windows.Forms.Button();
            this.dtpArrivalTime = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMedicalExam
            // 
            this.btnMedicalExam.Location = new System.Drawing.Point(59, 327);
            this.btnMedicalExam.Name = "btnMedicalExam";
            this.btnMedicalExam.Size = new System.Drawing.Size(114, 34);
            this.btnMedicalExam.TabIndex = 148;
            this.btnMedicalExam.Text = "Медосмотры";
            this.btnMedicalExam.UseVisualStyleBackColor = true;
            this.btnMedicalExam.Click += new System.EventHandler(this.btnMedicalExam_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 13);
            this.label3.TabIndex = 144;
            this.label3.Text = "Номер путевого листа";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 13);
            this.label2.TabIndex = 143;
            this.label2.Text = "Идентификатор (автоматический)";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(549, 399);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 35);
            this.btnCancel.TabIndex = 140;
            this.btnCancel.Text = "Назад";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(299, 399);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 35);
            this.btnSave.TabIndex = 139;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(29, 31);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(176, 20);
            this.txtId.TabIndex = 138;
            this.txtId.Text = "id";
            // 
            // txtWbNumber
            // 
            this.txtWbNumber.Location = new System.Drawing.Point(29, 83);
            this.txtWbNumber.Name = "txtWbNumber";
            this.txtWbNumber.Size = new System.Drawing.Size(176, 20);
            this.txtWbNumber.TabIndex = 134;
            // 
            // dtpWbDate
            // 
            this.dtpWbDate.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpWbDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpWbDate.Location = new System.Drawing.Point(29, 134);
            this.dtpWbDate.Name = "dtpWbDate";
            this.dtpWbDate.Size = new System.Drawing.Size(173, 20);
            this.dtpWbDate.TabIndex = 168;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 167;
            this.label7.Text = "Дата оформления";
            // 
            // dtpFrom
            // 
            this.dtpFrom.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom.Location = new System.Drawing.Point(29, 188);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(173, 20);
            this.dtpFrom.TabIndex = 170;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 169;
            this.label1.Text = "Срок действия с";
            // 
            // dtpUntil
            // 
            this.dtpUntil.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpUntil.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpUntil.Location = new System.Drawing.Point(29, 238);
            this.dtpUntil.Name = "dtpUntil";
            this.dtpUntil.Size = new System.Drawing.Size(173, 20);
            this.dtpUntil.TabIndex = 172;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 171;
            this.label4.Text = "Срок действия до";
            // 
            // cmbTransportType
            // 
            this.cmbTransportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTransportType.FormattingEnabled = true;
            this.cmbTransportType.Location = new System.Drawing.Point(287, 31);
            this.cmbTransportType.Name = "cmbTransportType";
            this.cmbTransportType.Size = new System.Drawing.Size(176, 21);
            this.cmbTransportType.TabIndex = 174;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(284, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 13);
            this.label8.TabIndex = 173;
            this.label8.Text = "Сведения о виде перевозки";
            // 
            // cmbMessageType
            // 
            this.cmbMessageType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMessageType.FormattingEnabled = true;
            this.cmbMessageType.Location = new System.Drawing.Point(287, 83);
            this.cmbMessageType.Name = "cmbMessageType";
            this.cmbMessageType.Size = new System.Drawing.Size(176, 21);
            this.cmbMessageType.TabIndex = 176;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(284, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 13);
            this.label5.TabIndex = 175;
            this.label5.Text = "Сведения о виде сообщения";
            // 
            // dtpDepartureTime
            // 
            this.dtpDepartureTime.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpDepartureTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDepartureTime.Location = new System.Drawing.Point(287, 188);
            this.dtpDepartureTime.Name = "dtpDepartureTime";
            this.dtpDepartureTime.Size = new System.Drawing.Size(173, 20);
            this.dtpDepartureTime.TabIndex = 180;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(284, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 179;
            this.label9.Text = "Время убытия";
            // 
            // dtpPreTripDate
            // 
            this.dtpPreTripDate.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpPreTripDate.Location = new System.Drawing.Point(287, 238);
            this.dtpPreTripDate.Name = "dtpPreTripDate";
            this.dtpPreTripDate.Size = new System.Drawing.Size(173, 20);
            this.dtpPreTripDate.TabIndex = 182;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(284, 222);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(163, 13);
            this.label10.TabIndex = 181;
            this.label10.Text = "Дата предрейсового контроля";
            // 
            // dtpPreTripTime
            // 
            this.dtpPreTripTime.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpPreTripTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpPreTripTime.Location = new System.Drawing.Point(287, 289);
            this.dtpPreTripTime.Name = "dtpPreTripTime";
            this.dtpPreTripTime.Size = new System.Drawing.Size(173, 20);
            this.dtpPreTripTime.TabIndex = 184;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(284, 273);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(170, 13);
            this.label11.TabIndex = 183;
            this.label11.Text = "Время предрейсового контроля";
            // 
            // btnOpenVehicle
            // 
            this.btnOpenVehicle.Location = new System.Drawing.Point(211, 287);
            this.btnOpenVehicle.Name = "btnOpenVehicle";
            this.btnOpenVehicle.Size = new System.Drawing.Size(40, 23);
            this.btnOpenVehicle.TabIndex = 187;
            this.btnOpenVehicle.Text = "Ред.";
            this.btnOpenVehicle.UseVisualStyleBackColor = true;
            this.btnOpenVehicle.Click += new System.EventHandler(this.btnOpenVehicle_Click);
            // 
            // cmbVehicle
            // 
            this.cmbVehicle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVehicle.FormattingEnabled = true;
            this.cmbVehicle.Location = new System.Drawing.Point(29, 289);
            this.cmbVehicle.Name = "cmbVehicle";
            this.cmbVehicle.Size = new System.Drawing.Size(176, 21);
            this.cmbVehicle.TabIndex = 186;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(26, 273);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 13);
            this.label12.TabIndex = 185;
            this.label12.Text = "ТС";
            // 
            // btnOpenDriver
            // 
            this.btnOpenDriver.Location = new System.Drawing.Point(698, 29);
            this.btnOpenDriver.Name = "btnOpenDriver";
            this.btnOpenDriver.Size = new System.Drawing.Size(40, 23);
            this.btnOpenDriver.TabIndex = 190;
            this.btnOpenDriver.Text = "Ред.";
            this.btnOpenDriver.UseVisualStyleBackColor = true;
            this.btnOpenDriver.Click += new System.EventHandler(this.btnOpenDriver_Click);
            // 
            // cmbDriver
            // 
            this.cmbDriver.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDriver.FormattingEnabled = true;
            this.cmbDriver.Location = new System.Drawing.Point(516, 31);
            this.cmbDriver.Name = "cmbDriver";
            this.cmbDriver.Size = new System.Drawing.Size(176, 21);
            this.cmbDriver.TabIndex = 189;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(513, 15);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 13);
            this.label13.TabIndex = 188;
            this.label13.Text = "Водитель";
            // 
            // btnOpenCustomer
            // 
            this.btnOpenCustomer.Location = new System.Drawing.Point(698, 186);
            this.btnOpenCustomer.Name = "btnOpenCustomer";
            this.btnOpenCustomer.Size = new System.Drawing.Size(40, 23);
            this.btnOpenCustomer.TabIndex = 193;
            this.btnOpenCustomer.Text = "Ред.";
            this.btnOpenCustomer.UseVisualStyleBackColor = true;
            this.btnOpenCustomer.Click += new System.EventHandler(this.btnOpenCustomer_Click);
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(516, 188);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(176, 21);
            this.cmbCustomer.TabIndex = 192;
            this.cmbCustomer.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(513, 172);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 13);
            this.label14.TabIndex = 191;
            this.label14.Text = "Заказчик";
            // 
            // btnOpenOrg
            // 
            this.btnOpenOrg.Location = new System.Drawing.Point(698, 236);
            this.btnOpenOrg.Name = "btnOpenOrg";
            this.btnOpenOrg.Size = new System.Drawing.Size(40, 23);
            this.btnOpenOrg.TabIndex = 196;
            this.btnOpenOrg.Text = "Ред.";
            this.btnOpenOrg.UseVisualStyleBackColor = true;
            this.btnOpenOrg.Click += new System.EventHandler(this.btnOpenOrg_Click);
            // 
            // cmbOrganization
            // 
            this.cmbOrganization.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrganization.FormattingEnabled = true;
            this.cmbOrganization.Location = new System.Drawing.Point(516, 238);
            this.cmbOrganization.Name = "cmbOrganization";
            this.cmbOrganization.Size = new System.Drawing.Size(176, 21);
            this.cmbOrganization.TabIndex = 195;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(513, 222);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(132, 13);
            this.label15.TabIndex = 194;
            this.label15.Text = "Организация, запол. ПЛ";
            // 
            // btnOpenPersonFillingOut
            // 
            this.btnOpenPersonFillingOut.Location = new System.Drawing.Point(698, 81);
            this.btnOpenPersonFillingOut.Name = "btnOpenPersonFillingOut";
            this.btnOpenPersonFillingOut.Size = new System.Drawing.Size(40, 23);
            this.btnOpenPersonFillingOut.TabIndex = 199;
            this.btnOpenPersonFillingOut.Text = "Ред.";
            this.btnOpenPersonFillingOut.UseVisualStyleBackColor = true;
            this.btnOpenPersonFillingOut.Click += new System.EventHandler(this.btnOpenPersonFillingOut_Click);
            // 
            // cmbPersonFillingOut
            // 
            this.cmbPersonFillingOut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPersonFillingOut.FormattingEnabled = true;
            this.cmbPersonFillingOut.Location = new System.Drawing.Point(516, 83);
            this.cmbPersonFillingOut.Name = "cmbPersonFillingOut";
            this.cmbPersonFillingOut.Size = new System.Drawing.Size(176, 21);
            this.cmbPersonFillingOut.TabIndex = 198;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(513, 67);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(92, 13);
            this.label16.TabIndex = 197;
            this.label16.Text = "Лицо оформ. ПЛ";
            // 
            // btnOpenMechanic
            // 
            this.btnOpenMechanic.Location = new System.Drawing.Point(698, 132);
            this.btnOpenMechanic.Name = "btnOpenMechanic";
            this.btnOpenMechanic.Size = new System.Drawing.Size(40, 23);
            this.btnOpenMechanic.TabIndex = 202;
            this.btnOpenMechanic.Text = "Ред.";
            this.btnOpenMechanic.UseVisualStyleBackColor = true;
            this.btnOpenMechanic.Click += new System.EventHandler(this.btnOpenMechanic_Click);
            // 
            // cmbMechanic
            // 
            this.cmbMechanic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMechanic.FormattingEnabled = true;
            this.cmbMechanic.Location = new System.Drawing.Point(516, 134);
            this.cmbMechanic.Name = "cmbMechanic";
            this.cmbMechanic.Size = new System.Drawing.Size(176, 21);
            this.cmbMechanic.TabIndex = 201;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(513, 118);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(51, 13);
            this.label17.TabIndex = 200;
            this.label17.Text = "Механик";
            // 
            // btnOpenController
            // 
            this.btnOpenController.Location = new System.Drawing.Point(698, 287);
            this.btnOpenController.Name = "btnOpenController";
            this.btnOpenController.Size = new System.Drawing.Size(40, 23);
            this.btnOpenController.TabIndex = 205;
            this.btnOpenController.Text = "Ред.";
            this.btnOpenController.UseVisualStyleBackColor = true;
            this.btnOpenController.Click += new System.EventHandler(this.btnOpenController_Click);
            // 
            // cmbController
            // 
            this.cmbController.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbController.FormattingEnabled = true;
            this.cmbController.Location = new System.Drawing.Point(516, 289);
            this.cmbController.Name = "cmbController";
            this.cmbController.Size = new System.Drawing.Size(176, 21);
            this.cmbController.TabIndex = 204;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(513, 273);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(139, 13);
            this.label18.TabIndex = 203;
            this.label18.Text = "Контролер тех. состояния";
            // 
            // btnTrailer
            // 
            this.btnTrailer.Location = new System.Drawing.Point(308, 327);
            this.btnTrailer.Name = "btnTrailer";
            this.btnTrailer.Size = new System.Drawing.Size(114, 34);
            this.btnTrailer.TabIndex = 206;
            this.btnTrailer.Text = "Прицепы";
            this.btnTrailer.UseVisualStyleBackColor = true;
            this.btnTrailer.Click += new System.EventHandler(this.btnTrailer_Click);
            // 
            // btnWork
            // 
            this.btnWork.Location = new System.Drawing.Point(549, 327);
            this.btnWork.Name = "btnWork";
            this.btnWork.Size = new System.Drawing.Size(119, 34);
            this.btnWork.TabIndex = 207;
            this.btnWork.Text = "Работа водителя и автомобиля";
            this.btnWork.UseVisualStyleBackColor = true;
            this.btnWork.Click += new System.EventHandler(this.btnWork_Click);
            // 
            // dtpArrivalTime
            // 
            this.dtpArrivalTime.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpArrivalTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpArrivalTime.Location = new System.Drawing.Point(287, 134);
            this.dtpArrivalTime.Name = "dtpArrivalTime";
            this.dtpArrivalTime.Size = new System.Drawing.Size(173, 20);
            this.dtpArrivalTime.TabIndex = 209;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(284, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 208;
            this.label6.Text = "Время прибытия";
            // 
            // WaybillEditView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dtpArrivalTime);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnWork);
            this.Controls.Add(this.btnTrailer);
            this.Controls.Add(this.btnOpenController);
            this.Controls.Add(this.cmbController);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.btnOpenMechanic);
            this.Controls.Add(this.cmbMechanic);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.btnOpenPersonFillingOut);
            this.Controls.Add(this.cmbPersonFillingOut);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.btnOpenOrg);
            this.Controls.Add(this.cmbOrganization);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btnOpenCustomer);
            this.Controls.Add(this.cmbCustomer);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnOpenDriver);
            this.Controls.Add(this.cmbDriver);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnOpenVehicle);
            this.Controls.Add(this.cmbVehicle);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dtpPreTripTime);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dtpPreTripDate);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dtpDepartureTime);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbMessageType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbTransportType);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtpUntil);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpWbDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnMedicalExam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtWbNumber);
            this.Name = "WaybillEditView";
            this.Size = new System.Drawing.Size(759, 452);
            this.Load += new System.EventHandler(this.WaybillEditView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnMedicalExam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtWbNumber;
        private System.Windows.Forms.DateTimePicker dtpWbDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpUntil;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbTransportType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbMessageType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpDepartureTime;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpPreTripDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpPreTripTime;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnOpenVehicle;
        private System.Windows.Forms.ComboBox cmbVehicle;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnOpenDriver;
        private System.Windows.Forms.ComboBox cmbDriver;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnOpenCustomer;
        private System.Windows.Forms.ComboBox cmbCustomer;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnOpenOrg;
        private System.Windows.Forms.ComboBox cmbOrganization;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnOpenPersonFillingOut;
        private System.Windows.Forms.ComboBox cmbPersonFillingOut;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnOpenMechanic;
        private System.Windows.Forms.ComboBox cmbMechanic;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnOpenController;
        private System.Windows.Forms.ComboBox cmbController;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnTrailer;
        private System.Windows.Forms.Button btnWork;
        private System.Windows.Forms.DateTimePicker dtpArrivalTime;
        private System.Windows.Forms.Label label6;
    }
}
