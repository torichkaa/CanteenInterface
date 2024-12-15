namespace CanteenInterface
{
    partial class MenuDetailsForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelMealTime;
        private System.Windows.Forms.Label labelDish;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.ComboBox comboBoxMealTime;
        private System.Windows.Forms.ComboBox comboBoxDish;
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
            this.labelDate = new System.Windows.Forms.Label();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.labelMealTime = new System.Windows.Forms.Label();
            this.comboBoxMealTime = new System.Windows.Forms.ComboBox();
            this.labelDish = new System.Windows.Forms.Label();
            this.comboBoxDish = new System.Windows.Forms.ComboBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelDate.Location = new System.Drawing.Point(12, 15);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(49, 20);
            this.labelDate.TabIndex = 0;
            this.labelDate.Text = "Дата:";
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateTimePickerDate.Location = new System.Drawing.Point(120, 12);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(250, 26);
            this.dateTimePickerDate.TabIndex = 1;
            // 
            // labelMealTime
            // 
            this.labelMealTime.AutoSize = true;
            this.labelMealTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelMealTime.Location = new System.Drawing.Point(12, 55);
            this.labelMealTime.Name = "labelMealTime";
            this.labelMealTime.Size = new System.Drawing.Size(61, 20);
            this.labelMealTime.TabIndex = 2;
            this.labelMealTime.Text = "Час їжі:";
            // 
            // comboBoxMealTime
            // 
            this.comboBoxMealTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMealTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBoxMealTime.FormattingEnabled = true;
            this.comboBoxMealTime.Items.AddRange(new object[] {
            "сніданок",
            "обід",
            "вечеря"});
            this.comboBoxMealTime.Location = new System.Drawing.Point(120, 52);
            this.comboBoxMealTime.Name = "comboBoxMealTime";
            this.comboBoxMealTime.Size = new System.Drawing.Size(250, 28);
            this.comboBoxMealTime.TabIndex = 3;
            // 
            // labelDish
            // 
            this.labelDish.AutoSize = true;
            this.labelDish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelDish.Location = new System.Drawing.Point(12, 95);
            this.labelDish.Name = "labelDish";
            this.labelDish.Size = new System.Drawing.Size(66, 20);
            this.labelDish.TabIndex = 4;
            this.labelDish.Text = "Страва:";
            // 
            // comboBoxDish
            // 
            this.comboBoxDish.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBoxDish.FormattingEnabled = true;
            this.comboBoxDish.Location = new System.Drawing.Point(120, 92);
            this.comboBoxDish.Name = "comboBoxDish";
            this.comboBoxDish.Size = new System.Drawing.Size(250, 28);
            this.comboBoxDish.TabIndex = 5;
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonSave.Location = new System.Drawing.Point(120, 140);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(100, 40);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Зберегти";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonCancel.Location = new System.Drawing.Point(270, 140);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 40);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Скасувати";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // MenuDetailsForm
            // 
            this.ClientSize = new System.Drawing.Size(400, 200);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.comboBoxDish);
            this.Controls.Add(this.labelDish);
            this.Controls.Add(this.comboBoxMealTime);
            this.Controls.Add(this.labelMealTime);
            this.Controls.Add(this.dateTimePickerDate);
            this.Controls.Add(this.labelDate);
            this.Name = "MenuDetailsForm";
            this.Text = "Деталі меню";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}