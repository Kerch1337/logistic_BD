namespace logistic_BD
{
    partial class MenuView
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOrg = new System.Windows.Forms.Button();
            this.btnCN = new System.Windows.Forms.Button();
            this.btnClient = new System.Windows.Forms.Button();
            this.btnContract = new System.Windows.Forms.Button();
            this.btnVehicle = new System.Windows.Forms.Button();
            this.btnWaybill = new System.Windows.Forms.Button();
            this.btnTrailer = new System.Windows.Forms.Button();
            this.btnWorker = new System.Windows.Forms.Button();
            this.btnDriver = new System.Windows.Forms.Button();
            this.btnHealthWorker = new System.Windows.Forms.Button();
            this.btnUserSetting = new System.Windows.Forms.Button();
            this.btnContractReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(225, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(329, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Нажмите на кнопку, чтобы смотреть и изменять таблицы в БД";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(503, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Документы";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(251, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Таблицы";
            // 
            // btnOrg
            // 
            this.btnOrg.Location = new System.Drawing.Point(296, 165);
            this.btnOrg.Name = "btnOrg";
            this.btnOrg.Size = new System.Drawing.Size(102, 31);
            this.btnOrg.TabIndex = 13;
            this.btnOrg.Text = "Организации";
            this.btnOrg.UseVisualStyleBackColor = true;
            this.btnOrg.Click += new System.EventHandler(this.btnOrg_Click_1);
            // 
            // btnCN
            // 
            this.btnCN.Location = new System.Drawing.Point(487, 219);
            this.btnCN.Name = "btnCN";
            this.btnCN.Size = new System.Drawing.Size(102, 38);
            this.btnCN.TabIndex = 22;
            this.btnCN.Text = "Транспортная накладная";
            this.btnCN.UseVisualStyleBackColor = true;
            this.btnCN.Click += new System.EventHandler(this.btnCN_Click);
            // 
            // btnClient
            // 
            this.btnClient.Location = new System.Drawing.Point(157, 270);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(102, 31);
            this.btnClient.TabIndex = 14;
            this.btnClient.Text = "Клиенты";
            this.btnClient.UseVisualStyleBackColor = true;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // btnContract
            // 
            this.btnContract.Location = new System.Drawing.Point(487, 270);
            this.btnContract.Name = "btnContract";
            this.btnContract.Size = new System.Drawing.Size(102, 31);
            this.btnContract.TabIndex = 21;
            this.btnContract.Text = "Договор-заявка";
            this.btnContract.UseVisualStyleBackColor = true;
            this.btnContract.Click += new System.EventHandler(this.btnContract_Click);
            // 
            // btnVehicle
            // 
            this.btnVehicle.Location = new System.Drawing.Point(228, 316);
            this.btnVehicle.Name = "btnVehicle";
            this.btnVehicle.Size = new System.Drawing.Size(102, 38);
            this.btnVehicle.TabIndex = 15;
            this.btnVehicle.Text = "Транспортные средства";
            this.btnVehicle.UseVisualStyleBackColor = true;
            this.btnVehicle.Click += new System.EventHandler(this.btnVehicle_Click);
            // 
            // btnWaybill
            // 
            this.btnWaybill.Location = new System.Drawing.Point(487, 165);
            this.btnWaybill.Name = "btnWaybill";
            this.btnWaybill.Size = new System.Drawing.Size(102, 31);
            this.btnWaybill.TabIndex = 20;
            this.btnWaybill.Text = "Путевой Лист";
            this.btnWaybill.UseVisualStyleBackColor = true;
            this.btnWaybill.Click += new System.EventHandler(this.btnWaybill_Click);
            // 
            // btnTrailer
            // 
            this.btnTrailer.Location = new System.Drawing.Point(296, 219);
            this.btnTrailer.Name = "btnTrailer";
            this.btnTrailer.Size = new System.Drawing.Size(102, 31);
            this.btnTrailer.TabIndex = 16;
            this.btnTrailer.Text = "Прицепы";
            this.btnTrailer.UseVisualStyleBackColor = true;
            this.btnTrailer.Click += new System.EventHandler(this.btnTrailer_Click);
            // 
            // btnWorker
            // 
            this.btnWorker.Location = new System.Drawing.Point(157, 219);
            this.btnWorker.Name = "btnWorker";
            this.btnWorker.Size = new System.Drawing.Size(102, 31);
            this.btnWorker.TabIndex = 19;
            this.btnWorker.Text = "Работник";
            this.btnWorker.UseVisualStyleBackColor = true;
            this.btnWorker.Click += new System.EventHandler(this.btnWorker_Click);
            // 
            // btnDriver
            // 
            this.btnDriver.Location = new System.Drawing.Point(157, 165);
            this.btnDriver.Name = "btnDriver";
            this.btnDriver.Size = new System.Drawing.Size(102, 31);
            this.btnDriver.TabIndex = 17;
            this.btnDriver.Text = "Водитель";
            this.btnDriver.UseVisualStyleBackColor = true;
            this.btnDriver.Click += new System.EventHandler(this.btnDriver_Click);
            // 
            // btnHealthWorker
            // 
            this.btnHealthWorker.Location = new System.Drawing.Point(296, 270);
            this.btnHealthWorker.Name = "btnHealthWorker";
            this.btnHealthWorker.Size = new System.Drawing.Size(102, 31);
            this.btnHealthWorker.TabIndex = 18;
            this.btnHealthWorker.Text = "Медработник";
            this.btnHealthWorker.UseVisualStyleBackColor = true;
            this.btnHealthWorker.Click += new System.EventHandler(this.btnHealthWorker_Click);
            // 
            // btnUserSetting
            // 
            this.btnUserSetting.Location = new System.Drawing.Point(612, 387);
            this.btnUserSetting.Name = "btnUserSetting";
            this.btnUserSetting.Size = new System.Drawing.Size(102, 38);
            this.btnUserSetting.TabIndex = 26;
            this.btnUserSetting.Text = "Настройка пользователей";
            this.btnUserSetting.UseVisualStyleBackColor = true;
            this.btnUserSetting.Click += new System.EventHandler(this.btnUserSetting_Click);
            // 
            // btnContractReport
            // 
            this.btnContractReport.Location = new System.Drawing.Point(35, 22);
            this.btnContractReport.Name = "btnContractReport";
            this.btnContractReport.Size = new System.Drawing.Size(102, 38);
            this.btnContractReport.TabIndex = 27;
            this.btnContractReport.Text = "Отчет Договор-заявка";
            this.btnContractReport.UseVisualStyleBackColor = true;
            this.btnContractReport.Click += new System.EventHandler(this.btnContractReport_Click);
            // 
            // MenuView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnContractReport);
            this.Controls.Add(this.btnUserSetting);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOrg);
            this.Controls.Add(this.btnCN);
            this.Controls.Add(this.btnClient);
            this.Controls.Add(this.btnContract);
            this.Controls.Add(this.btnVehicle);
            this.Controls.Add(this.btnWaybill);
            this.Controls.Add(this.btnTrailer);
            this.Controls.Add(this.btnWorker);
            this.Controls.Add(this.btnDriver);
            this.Controls.Add(this.btnHealthWorker);
            this.Name = "MenuView";
            this.Size = new System.Drawing.Size(747, 452);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOrg;
        private System.Windows.Forms.Button btnCN;
        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Button btnContract;
        private System.Windows.Forms.Button btnVehicle;
        private System.Windows.Forms.Button btnWaybill;
        private System.Windows.Forms.Button btnTrailer;
        private System.Windows.Forms.Button btnWorker;
        private System.Windows.Forms.Button btnDriver;
        private System.Windows.Forms.Button btnHealthWorker;
        private System.Windows.Forms.Button btnUserSetting;
        private System.Windows.Forms.Button btnContractReport;
    }
}
