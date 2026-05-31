namespace logistic_BD.Views.Subdoc_Views
{
    partial class MedicalExamEditView
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
            this.btnOpenHealthWorker = new System.Windows.Forms.Button();
            this.cmbHealthWorker = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpExamDateTime = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.cmbExamType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOpenHealthWorker
            // 
            this.btnOpenHealthWorker.Location = new System.Drawing.Point(464, 293);
            this.btnOpenHealthWorker.Name = "btnOpenHealthWorker";
            this.btnOpenHealthWorker.Size = new System.Drawing.Size(40, 23);
            this.btnOpenHealthWorker.TabIndex = 235;
            this.btnOpenHealthWorker.Text = "Ред.";
            this.btnOpenHealthWorker.UseVisualStyleBackColor = true;
            this.btnOpenHealthWorker.Click += new System.EventHandler(this.btnOpenHealthWorker_Click);
            // 
            // cmbHealthWorker
            // 
            this.cmbHealthWorker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHealthWorker.FormattingEnabled = true;
            this.cmbHealthWorker.Location = new System.Drawing.Point(282, 295);
            this.cmbHealthWorker.Name = "cmbHealthWorker";
            this.cmbHealthWorker.Size = new System.Drawing.Size(176, 21);
            this.cmbHealthWorker.TabIndex = 234;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(279, 279);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 13);
            this.label12.TabIndex = 233;
            this.label12.Text = "Медработник";
            // 
            // dtpExamDateTime
            // 
            this.dtpExamDateTime.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dtpExamDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpExamDateTime.Location = new System.Drawing.Point(282, 191);
            this.dtpExamDateTime.Name = "dtpExamDateTime";
            this.dtpExamDateTime.Size = new System.Drawing.Size(173, 20);
            this.dtpExamDateTime.TabIndex = 218;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(279, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 13);
            this.label7.TabIndex = 217;
            this.label7.Text = "Дата и время медосмотра";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(279, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 13);
            this.label3.TabIndex = 215;
            this.label3.Text = "Результат медосмотра";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 13);
            this.label2.TabIndex = 214;
            this.label2.Text = "Идентификатор (автоматический)";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(555, 371);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 35);
            this.btnCancel.TabIndex = 213;
            this.btnCancel.Text = "Назад";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(305, 371);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 35);
            this.btnSave.TabIndex = 212;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(282, 88);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(176, 20);
            this.txtId.TabIndex = 211;
            this.txtId.Text = "id";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(282, 245);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(176, 20);
            this.txtResult.TabIndex = 210;
            // 
            // cmbExamType
            // 
            this.cmbExamType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbExamType.FormattingEnabled = true;
            this.cmbExamType.Location = new System.Drawing.Point(282, 141);
            this.cmbExamType.Name = "cmbExamType";
            this.cmbExamType.Size = new System.Drawing.Size(176, 21);
            this.cmbExamType.TabIndex = 237;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(279, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 236;
            this.label5.Text = "Тип медосмотра";
            // 
            // MedicalExamEditView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmbExamType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnOpenHealthWorker);
            this.Controls.Add(this.cmbHealthWorker);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dtpExamDateTime);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtResult);
            this.Name = "MedicalExamEditView";
            this.Size = new System.Drawing.Size(758, 458);
            this.Load += new System.EventHandler(this.MedicalExamEditView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenHealthWorker;
        private System.Windows.Forms.ComboBox cmbHealthWorker;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpExamDateTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.ComboBox cmbExamType;
        private System.Windows.Forms.Label label5;
    }
}
