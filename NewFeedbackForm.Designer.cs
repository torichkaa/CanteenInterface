namespace CanteenInterface
{
    partial class NewFeedbackForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelSubmittedBy;
        private System.Windows.Forms.Label labelContent;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.TextBox textBoxSubmittedBy;
        private System.Windows.Forms.TextBox textBoxContent;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.labelSubmittedBy = new System.Windows.Forms.Label();
            this.labelContent = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.textBoxSubmittedBy = new System.Windows.Forms.TextBox();
            this.textBoxContent = new System.Windows.Forms.TextBox();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelSubmittedBy
            // 
            this.labelSubmittedBy.AutoSize = true;
            this.labelSubmittedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelSubmittedBy.Location = new System.Drawing.Point(12, 15);
            this.labelSubmittedBy.Name = "labelSubmittedBy";
            this.labelSubmittedBy.Size = new System.Drawing.Size(75, 20);
            this.labelSubmittedBy.TabIndex = 0;
            this.labelSubmittedBy.Text = "Від кого:";
            // 
            // labelContent
            // 
            this.labelContent.AutoSize = true;
            this.labelContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelContent.Location = new System.Drawing.Point(12, 55);
            this.labelContent.Name = "labelContent";
            this.labelContent.Size = new System.Drawing.Size(111, 20);
            this.labelContent.TabIndex = 2;
            this.labelContent.Text = "Зміст відгуку:";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelDate.Location = new System.Drawing.Point(12, 215);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(52, 20);
            this.labelDate.TabIndex = 4;
            this.labelDate.Text = "Дата:";
            // 
            // textBoxSubmittedBy
            // 
            this.textBoxSubmittedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxSubmittedBy.Location = new System.Drawing.Point(120, 12);
            this.textBoxSubmittedBy.Name = "textBoxSubmittedBy";
            this.textBoxSubmittedBy.Size = new System.Drawing.Size(300, 26);
            this.textBoxSubmittedBy.TabIndex = 1;
            // 
            // textBoxContent
            // 
            this.textBoxContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxContent.Location = new System.Drawing.Point(120, 52);
            this.textBoxContent.Multiline = true;
            this.textBoxContent.Name = "textBoxContent";
            this.textBoxContent.Size = new System.Drawing.Size(300, 150);
            this.textBoxContent.TabIndex = 3;
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateTimePickerDate.Location = new System.Drawing.Point(120, 212);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(300, 26);
            this.dateTimePickerDate.TabIndex = 5;
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonSave.Location = new System.Drawing.Point(120, 260);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(122, 40);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Зберегти";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonCancel.Location = new System.Drawing.Point(298, 260);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(122, 40);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Скасувати";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // NewFeedbackForm
            // 
            this.ClientSize = new System.Drawing.Size(444, 321);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.dateTimePickerDate);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.textBoxContent);
            this.Controls.Add(this.labelContent);
            this.Controls.Add(this.textBoxSubmittedBy);
            this.Controls.Add(this.labelSubmittedBy);
            this.Name = "NewFeedbackForm";
            this.Text = "Новий відгук";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}