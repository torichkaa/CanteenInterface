namespace CanteenInterface
{
    partial class MealConsumptionDetailsForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelChildId;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelMealTime;
        private System.Windows.Forms.Label labelDish;
        private System.Windows.Forms.Label labelPortionSize;
        private System.Windows.Forms.Label labelRemarks;
        private System.Windows.Forms.NumericUpDown numericUpDownChildId;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.ComboBox comboBoxMealTime;
        private System.Windows.Forms.ComboBox comboBoxDish;
        private System.Windows.Forms.TextBox textBoxPortionSize;
        private System.Windows.Forms.TextBox textBoxRemarks;
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
            this.labelChildId = new System.Windows.Forms.Label();
            this.numericUpDownChildId = new System.Windows.Forms.NumericUpDown();
            this.labelDate = new System.Windows.Forms.Label();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.labelMealTime = new System.Windows.Forms.Label();
            this.comboBoxMealTime = new System.Windows.Forms.ComboBox();
            this.labelDish = new System.Windows.Forms.Label();
            this.comboBoxDish = new System.Windows.Forms.ComboBox();
            this.labelPortionSize = new System.Windows.Forms.Label();
            this.textBoxPortionSize = new System.Windows.Forms.TextBox();
            this.labelRemarks = new System.Windows.Forms.Label();
            this.textBoxRemarks = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownChildId)).BeginInit();
            this.SuspendLayout();
            // 
            // labelChildId
            // 
            this.labelChildId.AutoSize = true;
            this.labelChildId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelChildId.Location = new System.Drawing.Point(12, 15);
            this.labelChildId.Name = "labelChildId";
            this.labelChildId.Size = new System.Drawing.Size(88, 20);
            this.labelChildId.TabIndex = 0;
            this.labelChildId.Text = "ID дитини:";
            // 
            // numericUpDownChildId
            // 
            this.numericUpDownChildId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.numericUpDownChildId.Location = new System.Drawing.Point(120, 12);
            this.numericUpDownChildId.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownChildId.Name = "numericUpDownChildId";
            this.numericUpDownChildId.Size = new System.Drawing.Size(250, 26);
            this.numericUpDownChildId.TabIndex = 1;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelDate.Location = new System.Drawing.Point(12, 55);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(49, 20);
            this.labelDate.TabIndex = 2;
            this.labelDate.Text = "Дата:";
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateTimePickerDate.Location = new System.Drawing.Point(120, 52);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(250, 26);
            this.dateTimePickerDate.TabIndex = 3;
            // 
            // labelMealTime
            // 
            this.labelMealTime.AutoSize = true;
            this.labelMealTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelMealTime.Location = new System.Drawing.Point(12, 95);
            this.labelMealTime.Name = "labelMealTime";
            this.labelMealTime.Size = new System.Drawing.Size(61, 20);
            this.labelMealTime.TabIndex = 4;
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
            this.comboBoxMealTime.Location = new System.Drawing.Point(120, 92);
            this.comboBoxMealTime.Name = "comboBoxMealTime";
            this.comboBoxMealTime.Size = new System.Drawing.Size(250, 28);
            this.comboBoxMealTime.TabIndex = 5;
            // 
            // labelDish
            // 
            this.labelDish.AutoSize = true;
            this.labelDish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelDish.Location = new System.Drawing.Point(12, 135);
            this.labelDish.Name = "labelDish";
            this.labelDish.Size = new System.Drawing.Size(66, 20);
            this.labelDish.TabIndex = 6;
            this.labelDish.Text = "Страва:";
            // 
            // comboBoxDish
            // 
            this.comboBoxDish.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBoxDish.FormattingEnabled = true;
            this.comboBoxDish.Location = new System.Drawing.Point(120, 132);
            this.comboBoxDish.Name = "comboBoxDish";
            this.comboBoxDish.Size = new System.Drawing.Size(250, 28);
            this.comboBoxDish.TabIndex = 7;
            // 
            // labelPortionSize
            // 
            this.labelPortionSize.AutoSize = true;
            this.labelPortionSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelPortionSize.Location = new System.Drawing.Point(12, 175);
            this.labelPortionSize.Name = "labelPortionSize";
            this.labelPortionSize.Size = new System.Drawing.Size(108, 20);
            this.labelPortionSize.TabIndex = 8;
            this.labelPortionSize.Text = "Розмір порції:";
            // 
            // textBoxPortionSize
            // 
            this.textBoxPortionSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxPortionSize.Location = new System.Drawing.Point(120, 172);
            this.textBoxPortionSize.Name = "textBoxPortionSize";
            this.textBoxPortionSize.Size = new System.Drawing.Size(250, 26);
            this.textBoxPortionSize.TabIndex = 9;
            // 
            // labelRemarks
            // 
            this.labelRemarks.AutoSize = true;
            this.labelRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelRemarks.Location = new System.Drawing.Point(12, 215);
            this.labelRemarks.Name = "labelRemarks";
            this.labelRemarks.Size = new System.Drawing.Size(86, 20);
            this.labelRemarks.TabIndex = 10;
            this.labelRemarks.Text = "Примітки:";
            // 
            // textBoxRemarks
            // 
            this.textBoxRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxRemarks.Location = new System.Drawing.Point(120, 212);
            this.textBoxRemarks.Multiline = true;
            this.textBoxRemarks.Name = "textBoxRemarks";
            this.textBoxRemarks.Size = new System.Drawing.Size(250, 80);
            this.textBoxRemarks.TabIndex = 11;
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonSave.Location = new System.Drawing.Point(120, 310);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(100, 40);
            this.buttonSave.TabIndex = 12;
            this.buttonSave.Text = "Зберегти";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonCancel.Location = new System.Drawing.Point(270, 310);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 40);
            this.buttonCancel.TabIndex = 13;
            this.buttonCancel.Text = "Скасувати";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // MealConsumptionDetailsForm
            // 
            this.ClientSize = new System.Drawing.Size(400, 370);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxRemarks);
            this.Controls.Add(this.labelRemarks);
            this.Controls.Add(this.textBoxPortionSize);
            this.Controls.Add(this.labelPortionSize);
            this.Controls.Add(this.comboBoxDish);
            this.Controls.Add(this.labelDish);
            this.Controls.Add(this.comboBoxMealTime);
            this.Controls.Add(this.labelMealTime);
            this.Controls.Add(this.dateTimePickerDate);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.numericUpDownChildId);
            this.Controls.Add(this.labelChildId);
            this.Name = "MealConsumptionDetailsForm";
            this.Text = "Деталі споживання їжі";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownChildId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}