namespace logistic_BD.Views.Subdoc_Views
{
    partial class DriverVehicleWorkEditView
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
            this.cmbWorkType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnOpenAuthorizedPerson = new System.Windows.Forms.Button();
            this.cmbAuthorizedPerson = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpScheduledDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtZeroRun = new System.Windows.Forms.TextBox();
            this.dtpScheduledTime = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpActualDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpActualTime = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtOdometer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmbWorkType
            // 
            this.cmbWorkType.FormattingEnabled = true;
            this.cmbWorkType.Location = new System.Drawing.Point(151, 146);
            this.cmbWorkType.Name = "cmbWorkType";
            this.cmbWorkType.Size = new System.Drawing.Size(176, 21);
            this.cmbWorkType.TabIndex = 250;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(148, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 249;
            this.label5.Text = "Тип работы";
            // 
            // btnOpenAuthorizedPerson
            // 
            this.btnOpenAuthorizedPerson.Location = new System.Drawing.Point(441, 305);
            this.btnOpenAuthorizedPerson.Name = "btnOpenAuthorizedPerson";
            this.btnOpenAuthorizedPerson.Size = new System.Drawing.Size(40, 23);
            this.btnOpenAuthorizedPerson.TabIndex = 248;
            this.btnOpenAuthorizedPerson.Text = "Ред.";
            this.btnOpenAuthorizedPerson.UseVisualStyleBackColor = true;
            this.btnOpenAuthorizedPerson.Click += new System.EventHandler(this.btnOpenAuthorizedPerson_Click);
            // 
            // cmbAuthorizedPerson
            // 
            this.cmbAuthorizedPerson.FormattingEnabled = true;
            this.cmbAuthorizedPerson.Location = new System.Drawing.Point(259, 307);
            this.cmbAuthorizedPerson.Name = "cmbAuthorizedPerson";
            this.cmbAuthorizedPerson.Size = new System.Drawing.Size(176, 21);
            this.cmbAuthorizedPerson.TabIndex = 247;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(256, 291);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(143, 13);
            this.label12.TabIndex = 246;
            this.label12.Text = "Идентификатор упол. лица";
            // 
            // dtpScheduledDate
            // 
            this.dtpScheduledDate.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpScheduledDate.Location = new System.Drawing.Point(151, 196);
            this.dtpScheduledDate.Name = "dtpScheduledDate";
            this.dtpScheduledDate.Size = new System.Drawing.Size(173, 20);
            this.dtpScheduledDate.TabIndex = 245;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(148, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 244;
            this.label7.Text = "Дата по графику";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(369, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 243;
            this.label3.Text = "Нулевой пробег";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 13);
            this.label2.TabIndex = 242;
            this.label2.Text = "Идентификатор (автоматический)";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(562, 362);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 35);
            this.btnCancel.TabIndex = 241;
            this.btnCancel.Text = "Назад";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(312, 362);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 35);
            this.btnSave.TabIndex = 240;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(151, 93);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(176, 20);
            this.txtId.TabIndex = 239;
            this.txtId.Text = "id";
            // 
            // txtZeroRun
            // 
            this.txtZeroRun.Location = new System.Drawing.Point(372, 196);
            this.txtZeroRun.Name = "txtZeroRun";
            this.txtZeroRun.Size = new System.Drawing.Size(176, 20);
            this.txtZeroRun.TabIndex = 238;
            // 
            // dtpScheduledTime
            // 
            this.dtpScheduledTime.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpScheduledTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpScheduledTime.Location = new System.Drawing.Point(151, 244);
            this.dtpScheduledTime.Name = "dtpScheduledTime";
            this.dtpScheduledTime.Size = new System.Drawing.Size(173, 20);
            this.dtpScheduledTime.TabIndex = 252;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 251;
            this.label1.Text = "Время по графику";
            // 
            // dtpActualDate
            // 
            this.dtpActualDate.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpActualDate.Location = new System.Drawing.Point(372, 93);
            this.dtpActualDate.Name = "dtpActualDate";
            this.dtpActualDate.Size = new System.Drawing.Size(173, 20);
            this.dtpActualDate.TabIndex = 254;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(369, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 253;
            this.label4.Text = "Дата по факту";
            // 
            // dtpActualTime
            // 
            this.dtpActualTime.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpActualTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpActualTime.Location = new System.Drawing.Point(372, 146);
            this.dtpActualTime.Name = "dtpActualTime";
            this.dtpActualTime.Size = new System.Drawing.Size(173, 20);
            this.dtpActualTime.TabIndex = 256;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(369, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 255;
            this.label6.Text = "Время по факту";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(369, 231);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 13);
            this.label8.TabIndex = 258;
            this.label8.Text = "Показания одометра";
            // 
            // txtOdometer
            // 
            this.txtOdometer.Location = new System.Drawing.Point(372, 247);
            this.txtOdometer.Name = "txtOdometer";
            this.txtOdometer.Size = new System.Drawing.Size(176, 20);
            this.txtOdometer.TabIndex = 257;
            // 
            // DriverVehicleWorkEditView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtOdometer);
            this.Controls.Add(this.dtpActualTime);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpActualDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpScheduledTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbWorkType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnOpenAuthorizedPerson);
            this.Controls.Add(this.cmbAuthorizedPerson);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dtpScheduledDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtZeroRun);
            this.Name = "DriverVehicleWorkEditView";
            this.Size = new System.Drawing.Size(761, 464);
            this.Load += new System.EventHandler(this.DriverVehicleWorkEditView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbWorkType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnOpenAuthorizedPerson;
        private System.Windows.Forms.ComboBox cmbAuthorizedPerson;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpScheduledDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtZeroRun;
        private System.Windows.Forms.DateTimePicker dtpScheduledTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpActualDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpActualTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtOdometer;
    }
}
