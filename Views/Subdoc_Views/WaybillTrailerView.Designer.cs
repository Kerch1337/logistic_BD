namespace logistic_BD.Views.Subdoc_Views
{
    partial class WaybillTrailerView
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
            this.cmbTrailer = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvTrailers = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOpenTrailer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrailers)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbTrailer
            // 
            this.cmbTrailer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTrailer.FormattingEnabled = true;
            this.cmbTrailer.Location = new System.Drawing.Point(37, 338);
            this.cmbTrailer.Name = "cmbTrailer";
            this.cmbTrailer.Size = new System.Drawing.Size(176, 21);
            this.cmbTrailer.TabIndex = 188;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(34, 322);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 13);
            this.label12.TabIndex = 187;
            this.label12.Text = "Идентификатор ТС";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(63, 377);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(114, 34);
            this.btnAdd.TabIndex = 189;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvTrailers
            // 
            this.dgvTrailers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrailers.Location = new System.Drawing.Point(0, 0);
            this.dgvTrailers.Name = "dgvTrailers";
            this.dgvTrailers.Size = new System.Drawing.Size(758, 299);
            this.dgvTrailers.TabIndex = 190;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(323, 377);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(114, 34);
            this.btnDelete.TabIndex = 191;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(592, 377);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(114, 34);
            this.btnCancel.TabIndex = 192;
            this.btnCancel.Text = "Назад";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOpenTrailer
            // 
            this.btnOpenTrailer.Location = new System.Drawing.Point(219, 336);
            this.btnOpenTrailer.Name = "btnOpenTrailer";
            this.btnOpenTrailer.Size = new System.Drawing.Size(40, 23);
            this.btnOpenTrailer.TabIndex = 206;
            this.btnOpenTrailer.Text = "Ред.";
            this.btnOpenTrailer.UseVisualStyleBackColor = true;
            this.btnOpenTrailer.Click += new System.EventHandler(this.btnOpenTrailer_Click);
            // 
            // WaybillTrailerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnOpenTrailer);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgvTrailers);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cmbTrailer);
            this.Controls.Add(this.label12);
            this.Name = "WaybillTrailerView";
            this.Size = new System.Drawing.Size(758, 447);
            this.Load += new System.EventHandler(this.WaybillTrailerView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrailers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTrailer;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvTrailers;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOpenTrailer;
    }
}
