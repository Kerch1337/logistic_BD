namespace logistic_BD.Views.Driver_Views
{
    partial class DriverConsignmentNoteView
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
            this.txtWBNum = new System.Windows.Forms.TextBox();
            this.btnOpenCarriersRepresentative = new System.Windows.Forms.Button();
            this.dtpActualDepartureUnload = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpStatedUnloadingDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpActualUnloadingDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUnloadAddress = new System.Windows.Forms.TextBox();
            this.dtpActualDepartureLoad = new System.Windows.Forms.DateTimePicker();
            this.label18 = new System.Windows.Forms.Label();
            this.dtpStatedLoadingDate = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.btnCargo = new System.Windows.Forms.Button();
            this.btnOpenLoaderPerson = new System.Windows.Forms.Button();
            this.btnOpenLoadingPointOwner = new System.Windows.Forms.Button();
            this.btnOpenCarrier = new System.Windows.Forms.Button();
            this.btnOpenConsignee = new System.Windows.Forms.Button();
            this.btnOpenShipper = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpActualLoadingDate = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpCnDate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtLoadAddress = new System.Windows.Forms.TextBox();
            this.txtCnNum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtWBNum
            // 
            this.txtWBNum.Location = new System.Drawing.Point(547, 51);
            this.txtWBNum.Name = "txtWBNum";
            this.txtWBNum.Size = new System.Drawing.Size(176, 20);
            this.txtWBNum.TabIndex = 210;
            // 
            // btnOpenCarriersRepresentative
            // 
            this.btnOpenCarriersRepresentative.Location = new System.Drawing.Point(292, 304);
            this.btnOpenCarriersRepresentative.Name = "btnOpenCarriersRepresentative";
            this.btnOpenCarriersRepresentative.Size = new System.Drawing.Size(173, 23);
            this.btnOpenCarriersRepresentative.TabIndex = 209;
            this.btnOpenCarriersRepresentative.Text = "Представитель перевозчика";
            this.btnOpenCarriersRepresentative.UseVisualStyleBackColor = true;
            this.btnOpenCarriersRepresentative.Click += new System.EventHandler(this.btnOpenCarriersRepresentative_Click);
            // 
            // dtpActualDepartureUnload
            // 
            this.dtpActualDepartureUnload.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpActualDepartureUnload.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpActualDepartureUnload.Location = new System.Drawing.Point(292, 253);
            this.dtpActualDepartureUnload.Name = "dtpActualDepartureUnload";
            this.dtpActualDepartureUnload.Size = new System.Drawing.Size(173, 20);
            this.dtpActualDepartureUnload.TabIndex = 208;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(289, 237);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(198, 13);
            this.label8.TabIndex = 207;
            this.label8.Text = "Фактическая дата убытия (выгрузка)";
            // 
            // dtpStatedUnloadingDate
            // 
            this.dtpStatedUnloadingDate.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpStatedUnloadingDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStatedUnloadingDate.Location = new System.Drawing.Point(292, 201);
            this.dtpStatedUnloadingDate.Name = "dtpStatedUnloadingDate";
            this.dtpStatedUnloadingDate.Size = new System.Drawing.Size(173, 20);
            this.dtpStatedUnloadingDate.TabIndex = 206;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(289, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(217, 13);
            this.label6.TabIndex = 205;
            this.label6.Text = "Заявленная дата прибытия под выгрузку";
            // 
            // dtpActualUnloadingDate
            // 
            this.dtpActualUnloadingDate.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpActualUnloadingDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpActualUnloadingDate.Location = new System.Drawing.Point(292, 153);
            this.dtpActualUnloadingDate.Name = "dtpActualUnloadingDate";
            this.dtpActualUnloadingDate.Size = new System.Drawing.Size(173, 20);
            this.dtpActualUnloadingDate.TabIndex = 204;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(289, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(225, 13);
            this.label5.TabIndex = 203;
            this.label5.Text = "Фактическая дата прибытия под выгрузку";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(289, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 202;
            this.label1.Text = "Адрес места выгрузки";
            // 
            // txtUnloadAddress
            // 
            this.txtUnloadAddress.Location = new System.Drawing.Point(292, 101);
            this.txtUnloadAddress.Name = "txtUnloadAddress";
            this.txtUnloadAddress.Size = new System.Drawing.Size(176, 20);
            this.txtUnloadAddress.TabIndex = 201;
            // 
            // dtpActualDepartureLoad
            // 
            this.dtpActualDepartureLoad.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpActualDepartureLoad.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpActualDepartureLoad.Location = new System.Drawing.Point(43, 303);
            this.dtpActualDepartureLoad.Name = "dtpActualDepartureLoad";
            this.dtpActualDepartureLoad.Size = new System.Drawing.Size(173, 20);
            this.dtpActualDepartureLoad.TabIndex = 200;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(40, 287);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(196, 13);
            this.label18.TabIndex = 199;
            this.label18.Text = "Фактические дата убытия (погрузка)";
            // 
            // dtpStatedLoadingDate
            // 
            this.dtpStatedLoadingDate.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpStatedLoadingDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStatedLoadingDate.Location = new System.Drawing.Point(43, 253);
            this.dtpStatedLoadingDate.Name = "dtpStatedLoadingDate";
            this.dtpStatedLoadingDate.Size = new System.Drawing.Size(173, 20);
            this.dtpStatedLoadingDate.TabIndex = 198;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(40, 237);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(217, 13);
            this.label17.TabIndex = 197;
            this.label17.Text = "Заявленные дата прибытия под погрузку";
            // 
            // btnCargo
            // 
            this.btnCargo.Location = new System.Drawing.Point(87, 378);
            this.btnCargo.Name = "btnCargo";
            this.btnCargo.Size = new System.Drawing.Size(114, 34);
            this.btnCargo.TabIndex = 196;
            this.btnCargo.Text = "Груз";
            this.btnCargo.UseVisualStyleBackColor = true;
            this.btnCargo.Click += new System.EventHandler(this.btnCargo_Click);
            // 
            // btnOpenLoaderPerson
            // 
            this.btnOpenLoaderPerson.Location = new System.Drawing.Point(551, 304);
            this.btnOpenLoaderPerson.Name = "btnOpenLoaderPerson";
            this.btnOpenLoaderPerson.Size = new System.Drawing.Size(172, 23);
            this.btnOpenLoaderPerson.TabIndex = 195;
            this.btnOpenLoaderPerson.Text = "Лицо, осущ. погрузку";
            this.btnOpenLoaderPerson.UseVisualStyleBackColor = true;
            this.btnOpenLoaderPerson.Click += new System.EventHandler(this.btnOpenLoaderPerson_Click);
            // 
            // btnOpenLoadingPointOwner
            // 
            this.btnOpenLoadingPointOwner.Location = new System.Drawing.Point(551, 254);
            this.btnOpenLoadingPointOwner.Name = "btnOpenLoadingPointOwner";
            this.btnOpenLoadingPointOwner.Size = new System.Drawing.Size(172, 23);
            this.btnOpenLoadingPointOwner.TabIndex = 194;
            this.btnOpenLoadingPointOwner.Text = "Владелец пункта погрузки";
            this.btnOpenLoadingPointOwner.UseVisualStyleBackColor = true;
            this.btnOpenLoadingPointOwner.Click += new System.EventHandler(this.btnOpenLoadingPointOwner_Click);
            // 
            // btnOpenCarrier
            // 
            this.btnOpenCarrier.Location = new System.Drawing.Point(551, 198);
            this.btnOpenCarrier.Name = "btnOpenCarrier";
            this.btnOpenCarrier.Size = new System.Drawing.Size(172, 23);
            this.btnOpenCarrier.TabIndex = 193;
            this.btnOpenCarrier.Text = "Перевозчик";
            this.btnOpenCarrier.UseVisualStyleBackColor = true;
            this.btnOpenCarrier.Click += new System.EventHandler(this.btnOpenCarrier_Click);
            // 
            // btnOpenConsignee
            // 
            this.btnOpenConsignee.Location = new System.Drawing.Point(551, 151);
            this.btnOpenConsignee.Name = "btnOpenConsignee";
            this.btnOpenConsignee.Size = new System.Drawing.Size(172, 23);
            this.btnOpenConsignee.TabIndex = 192;
            this.btnOpenConsignee.Text = "Грузополучатель";
            this.btnOpenConsignee.UseVisualStyleBackColor = true;
            this.btnOpenConsignee.Click += new System.EventHandler(this.btnOpenConsignee_Click);
            // 
            // btnOpenShipper
            // 
            this.btnOpenShipper.Location = new System.Drawing.Point(551, 98);
            this.btnOpenShipper.Name = "btnOpenShipper";
            this.btnOpenShipper.Size = new System.Drawing.Size(172, 23);
            this.btnOpenShipper.TabIndex = 191;
            this.btnOpenShipper.Text = "Грузоотправитель";
            this.btnOpenShipper.UseVisualStyleBackColor = true;
            this.btnOpenShipper.Click += new System.EventHandler(this.btnOpenShipper_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(548, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 13);
            this.label7.TabIndex = 190;
            this.label7.Text = "Номер путевого листа";
            // 
            // dtpActualLoadingDate
            // 
            this.dtpActualLoadingDate.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpActualLoadingDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpActualLoadingDate.Location = new System.Drawing.Point(43, 201);
            this.dtpActualLoadingDate.Name = "dtpActualLoadingDate";
            this.dtpActualLoadingDate.Size = new System.Drawing.Size(173, 20);
            this.dtpActualLoadingDate.TabIndex = 189;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(40, 185);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(223, 13);
            this.label11.TabIndex = 188;
            this.label11.Text = "Фактические дата прибытия под погрузку";
            // 
            // dtpCnDate
            // 
            this.dtpCnDate.Location = new System.Drawing.Point(43, 101);
            this.dtpCnDate.Name = "dtpCnDate";
            this.dtpCnDate.Size = new System.Drawing.Size(173, 20);
            this.dtpCnDate.TabIndex = 187;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 13);
            this.label9.TabIndex = 186;
            this.label9.Text = "Дата оформления";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 13);
            this.label4.TabIndex = 185;
            this.label4.Text = "Адрес места погрузки";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(289, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 13);
            this.label3.TabIndex = 184;
            this.label3.Text = "Номер транспортной накладной";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 13);
            this.label2.TabIndex = 183;
            this.label2.Text = "Идентификатор (автоматический)";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(593, 378);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 35);
            this.btnCancel.TabIndex = 182;
            this.btnCancel.Text = "Назад";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(40, 51);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(176, 20);
            this.txtId.TabIndex = 180;
            this.txtId.Text = "id";
            // 
            // txtLoadAddress
            // 
            this.txtLoadAddress.Location = new System.Drawing.Point(43, 153);
            this.txtLoadAddress.Name = "txtLoadAddress";
            this.txtLoadAddress.Size = new System.Drawing.Size(176, 20);
            this.txtLoadAddress.TabIndex = 179;
            // 
            // txtCnNum
            // 
            this.txtCnNum.Location = new System.Drawing.Point(292, 51);
            this.txtCnNum.Name = "txtCnNum";
            this.txtCnNum.Size = new System.Drawing.Size(176, 20);
            this.txtCnNum.TabIndex = 178;
            // 
            // DriverConsignmentNoteView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtWBNum);
            this.Controls.Add(this.btnOpenCarriersRepresentative);
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
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpActualLoadingDate);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dtpCnDate);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtLoadAddress);
            this.Controls.Add(this.txtCnNum);
            this.Name = "DriverConsignmentNoteView";
            this.Size = new System.Drawing.Size(760, 449);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtWBNum;
        private System.Windows.Forms.Button btnOpenCarriersRepresentative;
        private System.Windows.Forms.DateTimePicker dtpActualDepartureUnload;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpStatedUnloadingDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpActualUnloadingDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUnloadAddress;
        private System.Windows.Forms.DateTimePicker dtpActualDepartureLoad;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DateTimePicker dtpStatedLoadingDate;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnCargo;
        private System.Windows.Forms.Button btnOpenLoaderPerson;
        private System.Windows.Forms.Button btnOpenLoadingPointOwner;
        private System.Windows.Forms.Button btnOpenCarrier;
        private System.Windows.Forms.Button btnOpenConsignee;
        private System.Windows.Forms.Button btnOpenShipper;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpActualLoadingDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpCnDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtLoadAddress;
        private System.Windows.Forms.TextBox txtCnNum;
    }
}
