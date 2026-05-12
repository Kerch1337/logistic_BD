namespace logistic_BD.Views.Doc_Views
{
    partial class ConsignmentNoteEditView
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
            this.btnCargo = new System.Windows.Forms.Button();
            this.btnOpenLoaderPerson = new System.Windows.Forms.Button();
            this.btnOpenLoadingPointOwner = new System.Windows.Forms.Button();
            this.btnOpenCarrier = new System.Windows.Forms.Button();
            this.btnOpenConsignee = new System.Windows.Forms.Button();
            this.btnOpenShipper = new System.Windows.Forms.Button();
            this.btnOpenWaybill = new System.Windows.Forms.Button();
            this.cmbLoaderPerson = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cmbLoadingPointOwner = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cmbCarrier = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbConsignee = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbShipper = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbWaybill = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpActualLoadingDate = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpCnDate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtLoadAddress = new System.Windows.Forms.TextBox();
            this.txtCnNum = new System.Windows.Forms.TextBox();
            this.dtpStatedLoadingDate = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.dtpActualDepartureLoad = new System.Windows.Forms.DateTimePicker();
            this.label18 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUnloadAddress = new System.Windows.Forms.TextBox();
            this.dtpActualUnloadingDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpStatedUnloadingDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpActualDepartureUnload = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.btnOpenCarriersRepresentative = new System.Windows.Forms.Button();
            this.cmbCarrierRepresentative = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCargo
            // 
            this.btnCargo.Location = new System.Drawing.Point(62, 376);
            this.btnCargo.Name = "btnCargo";
            this.btnCargo.Size = new System.Drawing.Size(114, 34);
            this.btnCargo.TabIndex = 115;
            this.btnCargo.Text = "Добавить груз";
            this.btnCargo.UseVisualStyleBackColor = true;
            this.btnCargo.Click += new System.EventHandler(this.btnCargo_Click);
            // 
            // btnOpenLoaderPerson
            // 
            this.btnOpenLoaderPerson.Location = new System.Drawing.Point(708, 299);
            this.btnOpenLoaderPerson.Name = "btnOpenLoaderPerson";
            this.btnOpenLoaderPerson.Size = new System.Drawing.Size(40, 23);
            this.btnOpenLoaderPerson.TabIndex = 114;
            this.btnOpenLoaderPerson.Text = "Ред.";
            this.btnOpenLoaderPerson.UseVisualStyleBackColor = true;
            this.btnOpenLoaderPerson.Click += new System.EventHandler(this.btnOpenLoaderPerson_Click);
            // 
            // btnOpenLoadingPointOwner
            // 
            this.btnOpenLoadingPointOwner.Location = new System.Drawing.Point(708, 249);
            this.btnOpenLoadingPointOwner.Name = "btnOpenLoadingPointOwner";
            this.btnOpenLoadingPointOwner.Size = new System.Drawing.Size(40, 23);
            this.btnOpenLoadingPointOwner.TabIndex = 113;
            this.btnOpenLoadingPointOwner.Text = "Ред.";
            this.btnOpenLoadingPointOwner.UseVisualStyleBackColor = true;
            this.btnOpenLoadingPointOwner.Click += new System.EventHandler(this.btnOpenLoadingPointOwner_Click);
            // 
            // btnOpenCarrier
            // 
            this.btnOpenCarrier.Location = new System.Drawing.Point(708, 197);
            this.btnOpenCarrier.Name = "btnOpenCarrier";
            this.btnOpenCarrier.Size = new System.Drawing.Size(40, 23);
            this.btnOpenCarrier.TabIndex = 112;
            this.btnOpenCarrier.Text = "Ред.";
            this.btnOpenCarrier.UseVisualStyleBackColor = true;
            this.btnOpenCarrier.Click += new System.EventHandler(this.btnOpenCarrier_Click);
            // 
            // btnOpenConsignee
            // 
            this.btnOpenConsignee.Location = new System.Drawing.Point(708, 151);
            this.btnOpenConsignee.Name = "btnOpenConsignee";
            this.btnOpenConsignee.Size = new System.Drawing.Size(40, 23);
            this.btnOpenConsignee.TabIndex = 111;
            this.btnOpenConsignee.Text = "Ред.";
            this.btnOpenConsignee.UseVisualStyleBackColor = true;
            this.btnOpenConsignee.Click += new System.EventHandler(this.btnOpenConsignee_Click);
            // 
            // btnOpenShipper
            // 
            this.btnOpenShipper.Location = new System.Drawing.Point(708, 96);
            this.btnOpenShipper.Name = "btnOpenShipper";
            this.btnOpenShipper.Size = new System.Drawing.Size(40, 23);
            this.btnOpenShipper.TabIndex = 110;
            this.btnOpenShipper.Text = "Ред.";
            this.btnOpenShipper.UseVisualStyleBackColor = true;
            this.btnOpenShipper.Click += new System.EventHandler(this.btnOpenShipper_Click);
            // 
            // btnOpenWaybill
            // 
            this.btnOpenWaybill.Location = new System.Drawing.Point(708, 48);
            this.btnOpenWaybill.Name = "btnOpenWaybill";
            this.btnOpenWaybill.Size = new System.Drawing.Size(40, 23);
            this.btnOpenWaybill.TabIndex = 109;
            this.btnOpenWaybill.Text = "Ред.";
            this.btnOpenWaybill.UseVisualStyleBackColor = true;
            this.btnOpenWaybill.Click += new System.EventHandler(this.btnOpenWaybill_Click);
            // 
            // cmbLoaderPerson
            // 
            this.cmbLoaderPerson.FormattingEnabled = true;
            this.cmbLoaderPerson.Location = new System.Drawing.Point(526, 301);
            this.cmbLoaderPerson.Name = "cmbLoaderPerson";
            this.cmbLoaderPerson.Size = new System.Drawing.Size(176, 21);
            this.cmbLoaderPerson.TabIndex = 107;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(523, 285);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(197, 13);
            this.label16.TabIndex = 106;
            this.label16.Text = "Идентификатор лица, осущ. погрузку";
            // 
            // cmbLoadingPointOwner
            // 
            this.cmbLoadingPointOwner.FormattingEnabled = true;
            this.cmbLoadingPointOwner.Location = new System.Drawing.Point(526, 251);
            this.cmbLoadingPointOwner.Name = "cmbLoadingPointOwner";
            this.cmbLoadingPointOwner.Size = new System.Drawing.Size(176, 21);
            this.cmbLoadingPointOwner.TabIndex = 105;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(523, 235);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(230, 13);
            this.label15.TabIndex = 104;
            this.label15.Text = "Идентификатор владельца пункта погрузки";
            // 
            // cmbCarrier
            // 
            this.cmbCarrier.FormattingEnabled = true;
            this.cmbCarrier.Location = new System.Drawing.Point(526, 199);
            this.cmbCarrier.Name = "cmbCarrier";
            this.cmbCarrier.Size = new System.Drawing.Size(176, 21);
            this.cmbCarrier.TabIndex = 103;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(523, 183);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(155, 13);
            this.label14.TabIndex = 102;
            this.label14.Text = "Идентификатор перевозчика";
            // 
            // cmbConsignee
            // 
            this.cmbConsignee.FormattingEnabled = true;
            this.cmbConsignee.Location = new System.Drawing.Point(526, 151);
            this.cmbConsignee.Name = "cmbConsignee";
            this.cmbConsignee.Size = new System.Drawing.Size(176, 21);
            this.cmbConsignee.TabIndex = 101;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(523, 135);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(175, 13);
            this.label13.TabIndex = 100;
            this.label13.Text = "Идентификатор грузополучателя";
            // 
            // cmbShipper
            // 
            this.cmbShipper.FormattingEnabled = true;
            this.cmbShipper.Location = new System.Drawing.Point(526, 99);
            this.cmbShipper.Name = "cmbShipper";
            this.cmbShipper.Size = new System.Drawing.Size(176, 21);
            this.cmbShipper.TabIndex = 99;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(523, 83);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(182, 13);
            this.label12.TabIndex = 98;
            this.label12.Text = "Идентификатор грузоотправителя";
            // 
            // cmbWaybill
            // 
            this.cmbWaybill.FormattingEnabled = true;
            this.cmbWaybill.Location = new System.Drawing.Point(526, 49);
            this.cmbWaybill.Name = "cmbWaybill";
            this.cmbWaybill.Size = new System.Drawing.Size(176, 21);
            this.cmbWaybill.TabIndex = 97;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(523, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 13);
            this.label7.TabIndex = 96;
            this.label7.Text = "Идентификатор путевого листа";
            // 
            // dtpActualLoadingDate
            // 
            this.dtpActualLoadingDate.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpActualLoadingDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpActualLoadingDate.Location = new System.Drawing.Point(18, 199);
            this.dtpActualLoadingDate.Name = "dtpActualLoadingDate";
            this.dtpActualLoadingDate.Size = new System.Drawing.Size(173, 20);
            this.dtpActualLoadingDate.TabIndex = 93;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 183);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(223, 13);
            this.label11.TabIndex = 92;
            this.label11.Text = "Фактические дата прибытия под погрузку";
            // 
            // dtpCnDate
            // 
            this.dtpCnDate.Location = new System.Drawing.Point(18, 99);
            this.dtpCnDate.Name = "dtpCnDate";
            this.dtpCnDate.Size = new System.Drawing.Size(173, 20);
            this.dtpCnDate.TabIndex = 89;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 13);
            this.label9.TabIndex = 88;
            this.label9.Text = "Дата оформления";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 13);
            this.label4.TabIndex = 85;
            this.label4.Text = "Адрес места погрузки";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(264, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 13);
            this.label3.TabIndex = 84;
            this.label3.Text = "Номер транспортной накладной";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 13);
            this.label2.TabIndex = 83;
            this.label2.Text = "Идентификатор (автоматический)";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(568, 376);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 35);
            this.btnCancel.TabIndex = 80;
            this.btnCancel.Text = "Назад";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(314, 376);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 35);
            this.btnSave.TabIndex = 79;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(15, 49);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(176, 20);
            this.txtId.TabIndex = 78;
            this.txtId.Text = "id";
            // 
            // txtLoadAddress
            // 
            this.txtLoadAddress.Location = new System.Drawing.Point(18, 151);
            this.txtLoadAddress.Name = "txtLoadAddress";
            this.txtLoadAddress.Size = new System.Drawing.Size(176, 20);
            this.txtLoadAddress.TabIndex = 75;
            // 
            // txtCnNum
            // 
            this.txtCnNum.Location = new System.Drawing.Point(267, 49);
            this.txtCnNum.Name = "txtCnNum";
            this.txtCnNum.Size = new System.Drawing.Size(176, 20);
            this.txtCnNum.TabIndex = 74;
            // 
            // dtpStatedLoadingDate
            // 
            this.dtpStatedLoadingDate.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpStatedLoadingDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStatedLoadingDate.Location = new System.Drawing.Point(18, 251);
            this.dtpStatedLoadingDate.Name = "dtpStatedLoadingDate";
            this.dtpStatedLoadingDate.Size = new System.Drawing.Size(173, 20);
            this.dtpStatedLoadingDate.TabIndex = 117;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(15, 235);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(217, 13);
            this.label17.TabIndex = 116;
            this.label17.Text = "Заявленные дата прибытия под погрузку";
            // 
            // dtpActualDepartureLoad
            // 
            this.dtpActualDepartureLoad.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpActualDepartureLoad.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpActualDepartureLoad.Location = new System.Drawing.Point(18, 301);
            this.dtpActualDepartureLoad.Name = "dtpActualDepartureLoad";
            this.dtpActualDepartureLoad.Size = new System.Drawing.Size(173, 20);
            this.dtpActualDepartureLoad.TabIndex = 119;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(15, 285);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(196, 13);
            this.label18.TabIndex = 118;
            this.label18.Text = "Фактические дата убытия (погрузка)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(264, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 121;
            this.label1.Text = "Адрес места выгрузки";
            // 
            // txtUnloadAddress
            // 
            this.txtUnloadAddress.Location = new System.Drawing.Point(267, 99);
            this.txtUnloadAddress.Name = "txtUnloadAddress";
            this.txtUnloadAddress.Size = new System.Drawing.Size(176, 20);
            this.txtUnloadAddress.TabIndex = 120;
            // 
            // dtpActualUnloadingDate
            // 
            this.dtpActualUnloadingDate.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpActualUnloadingDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpActualUnloadingDate.Location = new System.Drawing.Point(267, 151);
            this.dtpActualUnloadingDate.Name = "dtpActualUnloadingDate";
            this.dtpActualUnloadingDate.Size = new System.Drawing.Size(173, 20);
            this.dtpActualUnloadingDate.TabIndex = 123;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(264, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(225, 13);
            this.label5.TabIndex = 122;
            this.label5.Text = "Фактическая дата прибытия под выгрузку";
            // 
            // dtpStatedUnloadingDate
            // 
            this.dtpStatedUnloadingDate.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpStatedUnloadingDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStatedUnloadingDate.Location = new System.Drawing.Point(267, 199);
            this.dtpStatedUnloadingDate.Name = "dtpStatedUnloadingDate";
            this.dtpStatedUnloadingDate.Size = new System.Drawing.Size(173, 20);
            this.dtpStatedUnloadingDate.TabIndex = 125;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(264, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(217, 13);
            this.label6.TabIndex = 124;
            this.label6.Text = "Заявленная дата прибытия под выгрузку";
            // 
            // dtpActualDepartureUnload
            // 
            this.dtpActualDepartureUnload.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpActualDepartureUnload.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpActualDepartureUnload.Location = new System.Drawing.Point(267, 251);
            this.dtpActualDepartureUnload.Name = "dtpActualDepartureUnload";
            this.dtpActualDepartureUnload.Size = new System.Drawing.Size(173, 20);
            this.dtpActualDepartureUnload.TabIndex = 127;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(264, 235);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(198, 13);
            this.label8.TabIndex = 126;
            this.label8.Text = "Фактическая дата убытия (выгрузка)";
            // 
            // btnOpenCarriersRepresentative
            // 
            this.btnOpenCarriersRepresentative.Location = new System.Drawing.Point(449, 299);
            this.btnOpenCarriersRepresentative.Name = "btnOpenCarriersRepresentative";
            this.btnOpenCarriersRepresentative.Size = new System.Drawing.Size(40, 23);
            this.btnOpenCarriersRepresentative.TabIndex = 130;
            this.btnOpenCarriersRepresentative.Text = "Ред.";
            this.btnOpenCarriersRepresentative.UseVisualStyleBackColor = true;
            this.btnOpenCarriersRepresentative.Click += new System.EventHandler(this.btnOpenCarriersRepresentative_Click);
            // 
            // cmbCarrierRepresentative
            // 
            this.cmbCarrierRepresentative.FormattingEnabled = true;
            this.cmbCarrierRepresentative.Location = new System.Drawing.Point(267, 301);
            this.cmbCarrierRepresentative.Name = "cmbCarrierRepresentative";
            this.cmbCarrierRepresentative.Size = new System.Drawing.Size(176, 21);
            this.cmbCarrierRepresentative.TabIndex = 129;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(264, 285);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(234, 13);
            this.label10.TabIndex = 128;
            this.label10.Text = "Идентификатор представителя перевозчика";
            // 
            // ConsignmentNoteEditView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnOpenCarriersRepresentative);
            this.Controls.Add(this.cmbCarrierRepresentative);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dtpActualDepartureUnload);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtpStatedUnloadingDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpActualUnloadingDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUnloadAddress);
            this.Controls.Add(this.dtpActualDepartureLoad);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.dtpStatedLoadingDate);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.btnCargo);
            this.Controls.Add(this.btnOpenLoaderPerson);
            this.Controls.Add(this.btnOpenLoadingPointOwner);
            this.Controls.Add(this.btnOpenCarrier);
            this.Controls.Add(this.btnOpenConsignee);
            this.Controls.Add(this.btnOpenShipper);
            this.Controls.Add(this.btnOpenWaybill);
            this.Controls.Add(this.cmbLoaderPerson);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.cmbLoadingPointOwner);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.cmbCarrier);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cmbConsignee);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cmbShipper);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cmbWaybill);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpActualLoadingDate);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dtpCnDate);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtLoadAddress);
            this.Controls.Add(this.txtCnNum);
            this.Name = "ConsignmentNoteEditView";
            this.Size = new System.Drawing.Size(769, 441);
            this.Load += new System.EventHandler(this.ConsignmentNoteEditView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCargo;
        private System.Windows.Forms.Button btnOpenLoaderPerson;
        private System.Windows.Forms.Button btnOpenLoadingPointOwner;
        private System.Windows.Forms.Button btnOpenCarrier;
        private System.Windows.Forms.Button btnOpenConsignee;
        private System.Windows.Forms.Button btnOpenShipper;
        private System.Windows.Forms.Button btnOpenWaybill;
        private System.Windows.Forms.ComboBox cmbLoaderPerson;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cmbLoadingPointOwner;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmbCarrier;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbConsignee;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbShipper;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbWaybill;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpActualLoadingDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpCnDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtLoadAddress;
        private System.Windows.Forms.TextBox txtCnNum;
        private System.Windows.Forms.DateTimePicker dtpStatedLoadingDate;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker dtpActualDepartureLoad;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUnloadAddress;
        private System.Windows.Forms.DateTimePicker dtpActualUnloadingDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpStatedUnloadingDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpActualDepartureUnload;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnOpenCarriersRepresentative;
        private System.Windows.Forms.ComboBox cmbCarrierRepresentative;
        private System.Windows.Forms.Label label10;
    }
}
