namespace logistic_BD.Views.Doc_Views
{
    partial class ContractEditView
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLoadingAddress = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtUnloadingAddress = new System.Windows.Forms.TextBox();
            this.txtPaymentTerms = new System.Windows.Forms.TextBox();
            this.txtCostServices = new System.Windows.Forms.TextBox();
            this.txtContractNum = new System.Windows.Forms.TextBox();
            this.dtpContractDate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpUnloadingTime = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpLoadingTime = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbConsignee = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbShipper = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbOrganization = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbPerformer = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbLoadingContact = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cmbUnloadingContact = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(280, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Адрес погрузки";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(280, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Адрес выгрузки";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Стоимость услуг";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Номер договора-заявки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Идентификатор (автоматический)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Условия оплаты";
            // 
            // txtLoadingAddress
            // 
            this.txtLoadingAddress.Location = new System.Drawing.Point(283, 31);
            this.txtLoadingAddress.Name = "txtLoadingAddress";
            this.txtLoadingAddress.Size = new System.Drawing.Size(176, 20);
            this.txtLoadingAddress.TabIndex = 32;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(562, 366);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 35);
            this.btnCancel.TabIndex = 31;
            this.btnCancel.Text = "Назад";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(307, 366);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 35);
            this.btnSave.TabIndex = 30;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(43, 30);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(176, 20);
            this.txtId.TabIndex = 29;
            this.txtId.Text = "id";
            // 
            // txtUnloadingAddress
            // 
            this.txtUnloadingAddress.Location = new System.Drawing.Point(283, 133);
            this.txtUnloadingAddress.Name = "txtUnloadingAddress";
            this.txtUnloadingAddress.Size = new System.Drawing.Size(176, 20);
            this.txtUnloadingAddress.TabIndex = 28;
            // 
            // txtPaymentTerms
            // 
            this.txtPaymentTerms.Location = new System.Drawing.Point(43, 240);
            this.txtPaymentTerms.Name = "txtPaymentTerms";
            this.txtPaymentTerms.Size = new System.Drawing.Size(176, 20);
            this.txtPaymentTerms.TabIndex = 27;
            // 
            // txtCostServices
            // 
            this.txtCostServices.Location = new System.Drawing.Point(43, 185);
            this.txtCostServices.Name = "txtCostServices";
            this.txtCostServices.Size = new System.Drawing.Size(176, 20);
            this.txtCostServices.TabIndex = 26;
            // 
            // txtContractNum
            // 
            this.txtContractNum.Location = new System.Drawing.Point(43, 82);
            this.txtContractNum.Name = "txtContractNum";
            this.txtContractNum.Size = new System.Drawing.Size(176, 20);
            this.txtContractNum.TabIndex = 25;
            // 
            // dtpContractDate
            // 
            this.dtpContractDate.Location = new System.Drawing.Point(43, 133);
            this.dtpContractDate.Name = "dtpContractDate";
            this.dtpContractDate.Size = new System.Drawing.Size(173, 20);
            this.dtpContractDate.TabIndex = 47;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 13);
            this.label9.TabIndex = 46;
            this.label9.Text = "Дата оформления";
            // 
            // dtpUnloadingTime
            // 
            this.dtpUnloadingTime.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpUnloadingTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpUnloadingTime.Location = new System.Drawing.Point(283, 185);
            this.dtpUnloadingTime.Name = "dtpUnloadingTime";
            this.dtpUnloadingTime.Size = new System.Drawing.Size(173, 20);
            this.dtpUnloadingTime.TabIndex = 49;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(280, 169);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 13);
            this.label10.TabIndex = 48;
            this.label10.Text = "Время выгрузки";
            // 
            // dtpLoadingTime
            // 
            this.dtpLoadingTime.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpLoadingTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpLoadingTime.Location = new System.Drawing.Point(283, 82);
            this.dtpLoadingTime.Name = "dtpLoadingTime";
            this.dtpLoadingTime.Size = new System.Drawing.Size(173, 20);
            this.dtpLoadingTime.TabIndex = 51;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(280, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 13);
            this.label11.TabIndex = 50;
            this.label11.Text = "Время погрузки";
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(283, 240);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(176, 21);
            this.cmbCustomer.TabIndex = 53;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(280, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 13);
            this.label8.TabIndex = 52;
            this.label8.Text = "Идентификатор заказчика";
            // 
            // cmbConsignee
            // 
            this.cmbConsignee.FormattingEnabled = true;
            this.cmbConsignee.Location = new System.Drawing.Point(518, 30);
            this.cmbConsignee.Name = "cmbConsignee";
            this.cmbConsignee.Size = new System.Drawing.Size(176, 21);
            this.cmbConsignee.TabIndex = 55;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(515, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(175, 13);
            this.label7.TabIndex = 54;
            this.label7.Text = "Идентификатор грузополучателя";
            // 
            // cmbShipper
            // 
            this.cmbShipper.FormattingEnabled = true;
            this.cmbShipper.Location = new System.Drawing.Point(518, 83);
            this.cmbShipper.Name = "cmbShipper";
            this.cmbShipper.Size = new System.Drawing.Size(176, 21);
            this.cmbShipper.TabIndex = 57;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(515, 67);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(182, 13);
            this.label12.TabIndex = 56;
            this.label12.Text = "Идентификатор грузоотправителя";
            // 
            // cmbOrganization
            // 
            this.cmbOrganization.FormattingEnabled = true;
            this.cmbOrganization.Location = new System.Drawing.Point(518, 134);
            this.cmbOrganization.Name = "cmbOrganization";
            this.cmbOrganization.Size = new System.Drawing.Size(176, 21);
            this.cmbOrganization.TabIndex = 59;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(515, 118);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(155, 13);
            this.label13.TabIndex = 58;
            this.label13.Text = "Идентификатор организации";
            // 
            // cmbPerformer
            // 
            this.cmbPerformer.FormattingEnabled = true;
            this.cmbPerformer.Location = new System.Drawing.Point(518, 190);
            this.cmbPerformer.Name = "cmbPerformer";
            this.cmbPerformer.Size = new System.Drawing.Size(176, 21);
            this.cmbPerformer.TabIndex = 61;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(515, 174);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(155, 13);
            this.label14.TabIndex = 60;
            this.label14.Text = "Идентификатор исполнителя";
            // 
            // cmbLoadingContact
            // 
            this.cmbLoadingContact.FormattingEnabled = true;
            this.cmbLoadingContact.Location = new System.Drawing.Point(518, 242);
            this.cmbLoadingContact.Name = "cmbLoadingContact";
            this.cmbLoadingContact.Size = new System.Drawing.Size(176, 21);
            this.cmbLoadingContact.TabIndex = 63;
            this.cmbLoadingContact.SelectedIndexChanged += new System.EventHandler(this.cmbLoadingContact_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(515, 226);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(229, 13);
            this.label15.TabIndex = 62;
            this.label15.Text = "Идентификатор контактного лица погрузки";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // cmbUnloadingContact
            // 
            this.cmbUnloadingContact.FormattingEnabled = true;
            this.cmbUnloadingContact.Location = new System.Drawing.Point(518, 302);
            this.cmbUnloadingContact.Name = "cmbUnloadingContact";
            this.cmbUnloadingContact.Size = new System.Drawing.Size(176, 21);
            this.cmbUnloadingContact.TabIndex = 65;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(515, 286);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(231, 13);
            this.label16.TabIndex = 64;
            this.label16.Text = "Идентификатор контактного лица выгрузки";
            // 
            // ContractEditView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmbUnloadingContact);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.cmbLoadingContact);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.cmbPerformer);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cmbOrganization);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cmbShipper);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cmbConsignee);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbCustomer);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtpLoadingTime);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dtpUnloadingTime);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dtpContractDate);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLoadingAddress);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtUnloadingAddress);
            this.Controls.Add(this.txtPaymentTerms);
            this.Controls.Add(this.txtCostServices);
            this.Controls.Add(this.txtContractNum);
            this.Name = "ContractEditView";
            this.Size = new System.Drawing.Size(746, 450);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLoadingAddress;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtUnloadingAddress;
        private System.Windows.Forms.TextBox txtPaymentTerms;
        private System.Windows.Forms.TextBox txtCostServices;
        private System.Windows.Forms.TextBox txtContractNum;
        private System.Windows.Forms.DateTimePicker dtpContractDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpUnloadingTime;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpLoadingTime;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbCustomer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbConsignee;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbShipper;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbOrganization;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbPerformer;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbLoadingContact;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmbUnloadingContact;
        private System.Windows.Forms.Label label16;
    }
}
