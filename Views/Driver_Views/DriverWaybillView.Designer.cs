namespace logistic_BD.Views.Driver_Views
{
    partial class DriverWaybillView
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
            this.dtpArrivalTime = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.btnWork = new System.Windows.Forms.Button();
            this.btnTrailer = new System.Windows.Forms.Button();
            this.btnOpenController = new System.Windows.Forms.Button();
            this.btnOpenMechanic = new System.Windows.Forms.Button();
            this.btnOpenPersonFillingOut = new System.Windows.Forms.Button();
            this.btnOpenOrg = new System.Windows.Forms.Button();
            this.btnOpenCustomer = new System.Windows.Forms.Button();
            this.btnOpenDriver = new System.Windows.Forms.Button();
            this.btnOpenVehicle = new System.Windows.Forms.Button();
            this.dtpPreTripTime = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpPreTripDate = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpDepartureTime = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbMessageType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbTransportType = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpUntil = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpWbDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.btnMedicalExam = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtWbNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dtpArrivalTime
            // 
            this.dtpArrivalTime.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpArrivalTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpArrivalTime.Location = new System.Drawing.Point(278, 138);
            this.dtpArrivalTime.Name = "dtpArrivalTime";
            this.dtpArrivalTime.Size = new System.Drawing.Size(173, 20);
            this.dtpArrivalTime.TabIndex = 257;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(275, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 256;
            this.label6.Text = "Время прибытия";
            // 
            // btnWork
            // 
            this.btnWork.Location = new System.Drawing.Point(540, 331);
            this.btnWork.Name = "btnWork";
            this.btnWork.Size = new System.Drawing.Size(119, 34);
            this.btnWork.TabIndex = 255;
            this.btnWork.Text = "Работа водителя и автомобиля";
            this.btnWork.UseVisualStyleBackColor = true;
            this.btnWork.Click += new System.EventHandler(this.btnWork_Click);
            // 
            // btnTrailer
            // 
            this.btnTrailer.Location = new System.Drawing.Point(300, 331);
            this.btnTrailer.Name = "btnTrailer";
            this.btnTrailer.Size = new System.Drawing.Size(114, 34);
            this.btnTrailer.TabIndex = 254;
            this.btnTrailer.Text = "Прицепы";
            this.btnTrailer.UseVisualStyleBackColor = true;
            this.btnTrailer.Click += new System.EventHandler(this.btnTrailer_Click);
            // 
            // btnOpenController
            // 
            this.btnOpenController.Location = new System.Drawing.Point(507, 290);
            this.btnOpenController.Name = "btnOpenController";
            this.btnOpenController.Size = new System.Drawing.Size(176, 23);
            this.btnOpenController.TabIndex = 253;
            this.btnOpenController.Text = "Контролер тех. состояния";
            this.btnOpenController.UseVisualStyleBackColor = true;
            this.btnOpenController.Click += new System.EventHandler(this.btnOpenController_Click);
            // 
            // btnOpenMechanic
            // 
            this.btnOpenMechanic.Location = new System.Drawing.Point(507, 138);
            this.btnOpenMechanic.Name = "btnOpenMechanic";
            this.btnOpenMechanic.Size = new System.Drawing.Size(176, 23);
            this.btnOpenMechanic.TabIndex = 250;
            this.btnOpenMechanic.Text = "Механик";
            this.btnOpenMechanic.UseVisualStyleBackColor = true;
            this.btnOpenMechanic.Click += new System.EventHandler(this.btnOpenMechanic_Click);
            // 
            // btnOpenPersonFillingOut
            // 
            this.btnOpenPersonFillingOut.Location = new System.Drawing.Point(507, 85);
            this.btnOpenPersonFillingOut.Name = "btnOpenPersonFillingOut";
            this.btnOpenPersonFillingOut.Size = new System.Drawing.Size(176, 23);
            this.btnOpenPersonFillingOut.TabIndex = 247;
            this.btnOpenPersonFillingOut.Text = "Лицо оформившее ПЛ";
            this.btnOpenPersonFillingOut.UseVisualStyleBackColor = true;
            this.btnOpenPersonFillingOut.Click += new System.EventHandler(this.btnOpenPersonFillingOut_Click);
            // 
            // btnOpenOrg
            // 
            this.btnOpenOrg.Location = new System.Drawing.Point(507, 243);
            this.btnOpenOrg.Name = "btnOpenOrg";
            this.btnOpenOrg.Size = new System.Drawing.Size(176, 23);
            this.btnOpenOrg.TabIndex = 244;
            this.btnOpenOrg.Text = "Орг. заполнившая ПЛ";
            this.btnOpenOrg.UseVisualStyleBackColor = true;
            this.btnOpenOrg.Click += new System.EventHandler(this.btnOpenOrg_Click);
            // 
            // btnOpenCustomer
            // 
            this.btnOpenCustomer.Location = new System.Drawing.Point(507, 189);
            this.btnOpenCustomer.Name = "btnOpenCustomer";
            this.btnOpenCustomer.Size = new System.Drawing.Size(176, 23);
            this.btnOpenCustomer.TabIndex = 241;
            this.btnOpenCustomer.Text = "Заказчик";
            this.btnOpenCustomer.UseVisualStyleBackColor = true;
            this.btnOpenCustomer.Click += new System.EventHandler(this.btnOpenCustomer_Click);
            // 
            // btnOpenDriver
            // 
            this.btnOpenDriver.Location = new System.Drawing.Point(507, 33);
            this.btnOpenDriver.Name = "btnOpenDriver";
            this.btnOpenDriver.Size = new System.Drawing.Size(176, 23);
            this.btnOpenDriver.TabIndex = 238;
            this.btnOpenDriver.Text = "Водитель";
            this.btnOpenDriver.UseVisualStyleBackColor = true;
            this.btnOpenDriver.Click += new System.EventHandler(this.btnOpenDriver_Click);
            // 
            // btnOpenVehicle
            // 
            this.btnOpenVehicle.Location = new System.Drawing.Point(20, 290);
            this.btnOpenVehicle.Name = "btnOpenVehicle";
            this.btnOpenVehicle.Size = new System.Drawing.Size(173, 23);
            this.btnOpenVehicle.TabIndex = 235;
            this.btnOpenVehicle.Text = "Транспортное средство";
            this.btnOpenVehicle.UseVisualStyleBackColor = true;
            this.btnOpenVehicle.Click += new System.EventHandler(this.btnOpenVehicle_Click);
            // 
            // dtpPreTripTime
            // 
            this.dtpPreTripTime.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpPreTripTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpPreTripTime.Location = new System.Drawing.Point(278, 293);
            this.dtpPreTripTime.Name = "dtpPreTripTime";
            this.dtpPreTripTime.Size = new System.Drawing.Size(173, 20);
            this.dtpPreTripTime.TabIndex = 232;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(275, 277);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(170, 13);
            this.label11.TabIndex = 231;
            this.label11.Text = "Время предрейсового контроля";
            // 
            // dtpPreTripDate
            // 
            this.dtpPreTripDate.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpPreTripDate.Location = new System.Drawing.Point(278, 242);
            this.dtpPreTripDate.Name = "dtpPreTripDate";
            this.dtpPreTripDate.Size = new System.Drawing.Size(173, 20);
            this.dtpPreTripDate.TabIndex = 230;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(275, 226);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(163, 13);
            this.label10.TabIndex = 229;
            this.label10.Text = "Дата предрейсового контроля";
            // 
            // dtpDepartureTime
            // 
            this.dtpDepartureTime.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpDepartureTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDepartureTime.Location = new System.Drawing.Point(278, 192);
            this.dtpDepartureTime.Name = "dtpDepartureTime";
            this.dtpDepartureTime.Size = new System.Drawing.Size(173, 20);
            this.dtpDepartureTime.TabIndex = 228;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(275, 176);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 227;
            this.label9.Text = "Время убытия";
            // 
            // cmbMessageType
            // 
            this.cmbMessageType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMessageType.FormattingEnabled = true;
            this.cmbMessageType.Location = new System.Drawing.Point(278, 87);
            this.cmbMessageType.Name = "cmbMessageType";
            this.cmbMessageType.Size = new System.Drawing.Size(176, 21);
            this.cmbMessageType.TabIndex = 226;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(275, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 13);
            this.label5.TabIndex = 225;
            this.label5.Text = "Сведения о виде сообщения";
            // 
            // cmbTransportType
            // 
            this.cmbTransportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTransportType.FormattingEnabled = true;
            this.cmbTransportType.Location = new System.Drawing.Point(278, 35);
            this.cmbTransportType.Name = "cmbTransportType";
            this.cmbTransportType.Size = new System.Drawing.Size(176, 21);
            this.cmbTransportType.TabIndex = 224;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(275, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 13);
            this.label8.TabIndex = 223;
            this.label8.Text = "Сведения о виде перевозки";
            // 
            // dtpUntil
            // 
            this.dtpUntil.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpUntil.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpUntil.Location = new System.Drawing.Point(20, 242);
            this.dtpUntil.Name = "dtpUntil";
            this.dtpUntil.Size = new System.Drawing.Size(173, 20);
            this.dtpUntil.TabIndex = 222;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 221;
            this.label4.Text = "Срок действия до";
            // 
            // dtpFrom
            // 
            this.dtpFrom.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom.Location = new System.Drawing.Point(20, 192);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(173, 20);
            this.dtpFrom.TabIndex = 220;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 219;
            this.label1.Text = "Срок действия с";
            // 
            // dtpWbDate
            // 
            this.dtpWbDate.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpWbDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpWbDate.Location = new System.Drawing.Point(20, 138);
            this.dtpWbDate.Name = "dtpWbDate";
            this.dtpWbDate.Size = new System.Drawing.Size(173, 20);
            this.dtpWbDate.TabIndex = 218;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 217;
            this.label7.Text = "Дата оформления";
            // 
            // btnMedicalExam
            // 
            this.btnMedicalExam.Location = new System.Drawing.Point(50, 331);
            this.btnMedicalExam.Name = "btnMedicalExam";
            this.btnMedicalExam.Size = new System.Drawing.Size(114, 34);
            this.btnMedicalExam.TabIndex = 216;
            this.btnMedicalExam.Text = "Медосмотры";
            this.btnMedicalExam.UseVisualStyleBackColor = true;
            this.btnMedicalExam.Click += new System.EventHandler(this.btnMedicalExam_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 13);
            this.label3.TabIndex = 215;
            this.label3.Text = "Номер путевого листа";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 13);
            this.label2.TabIndex = 214;
            this.label2.Text = "Идентификатор (автоматический)";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(540, 403);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 35);
            this.btnCancel.TabIndex = 213;
            this.btnCancel.Text = "Назад";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(20, 35);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(176, 20);
            this.txtId.TabIndex = 211;
            this.txtId.Text = "id";
            // 
            // txtWbNumber
            // 
            this.txtWbNumber.Location = new System.Drawing.Point(20, 87);
            this.txtWbNumber.Name = "txtWbNumber";
            this.txtWbNumber.Size = new System.Drawing.Size(176, 20);
            this.txtWbNumber.TabIndex = 210;
            // 
            // DriverWaybillView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dtpArrivalTime);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnWork);
            this.Controls.Add(this.btnTrailer);
            this.Controls.Add(this.btnOpenController);
            this.Controls.Add(this.btnOpenMechanic);
            this.Controls.Add(this.btnOpenPersonFillingOut);
            this.Controls.Add(this.btnOpenOrg);
            this.Controls.Add(this.btnOpenCustomer);
            this.Controls.Add(this.btnOpenDriver);
            this.Controls.Add(this.btnOpenVehicle);
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
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtWbNumber);
            this.Name = "DriverWaybillView";
            this.Size = new System.Drawing.Size(748, 457);
            this.Load += new System.EventHandler(this.DriverWaybillView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpArrivalTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnWork;
        private System.Windows.Forms.Button btnTrailer;
        private System.Windows.Forms.Button btnOpenController;
        private System.Windows.Forms.Button btnOpenMechanic;
        private System.Windows.Forms.Button btnOpenPersonFillingOut;
        private System.Windows.Forms.Button btnOpenOrg;
        private System.Windows.Forms.Button btnOpenCustomer;
        private System.Windows.Forms.Button btnOpenDriver;
        private System.Windows.Forms.Button btnOpenVehicle;
        private System.Windows.Forms.DateTimePicker dtpPreTripTime;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpPreTripDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpDepartureTime;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbMessageType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbTransportType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpUntil;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpWbDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnMedicalExam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtWbNumber;
    }
}
