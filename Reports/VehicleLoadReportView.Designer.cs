namespace logistic_BD.Views.ReportViews
{
    partial class VehicleLoadReportView
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTo = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.btnBack = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dateTo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dateFrom);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.btnOpen);
            this.panel1.Location = new System.Drawing.Point(0, 316);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 133);
            this.panel1.TabIndex = 9;
            // 
            // dateTo
            // 
            this.dateTo.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dateTo.Location = new System.Drawing.Point(479, 38);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(173, 20);
            this.dateTo.TabIndex = 186;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(476, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 185;
            this.label1.Text = "Дата до";
            // 
            // dateFrom
            // 
            this.dateFrom.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dateFrom.Location = new System.Drawing.Point(124, 38);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(173, 20);
            this.dateFrom.TabIndex = 184;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(498, 82);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(119, 37);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(121, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 183;
            this.label10.Text = "Дата от";
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(148, 82);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(119, 37);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Создать";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(758, 316);
            this.dataGridView1.TabIndex = 8;
            // 
            // VehicleLoadReportView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "VehicleLoadReportView";
            this.Size = new System.Drawing.Size(760, 449);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateFrom;
        private System.Windows.Forms.Label label10;
    }
}
