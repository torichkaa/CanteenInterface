namespace CanteenInterface
{
    partial class DishDetailsForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelIngredients;
        private System.Windows.Forms.Label labelCalories;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.TextBox textBoxIngredients;
        private System.Windows.Forms.NumericUpDown numericUpDownCalories;
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.labelIngredients = new System.Windows.Forms.Label();
            this.labelCalories = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.textBoxIngredients = new System.Windows.Forms.TextBox();
            this.numericUpDownCalories = new System.Windows.Forms.NumericUpDown();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCalories)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelName.Location = new System.Drawing.Point(12, 15);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(65, 20);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Назва:";
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxName.Location = new System.Drawing.Point(120, 12);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(250, 26);
            this.textBoxName.TabIndex = 1;
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelType.Location = new System.Drawing.Point(12, 55);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(43, 20);
            this.labelType.TabIndex = 2;
            this.labelType.Text = "Тип:";
            // 
            // comboBoxType
            // 
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "перша",
            "друга",
            "десерт",
            "напій"});
            this.comboBoxType.Location = new System.Drawing.Point(120, 52);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(250, 28);
            this.comboBoxType.TabIndex = 3;
            // 
            // labelIngredients
            // 
            this.labelIngredients.AutoSize = true;
            this.labelIngredients.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelIngredients.Location = new System.Drawing.Point(12, 95);
            this.labelIngredients.Name = "labelIngredients";
            this.labelIngredients.Size = new System.Drawing.Size(102, 20);
            this.labelIngredients.TabIndex = 4;
            this.labelIngredients.Text = "Інгредієнти:";
            // 
            // textBoxIngredients
            // 
            this.textBoxIngredients.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxIngredients.Location = new System.Drawing.Point(120, 92);
            this.textBoxIngredients.Multiline = true;
            this.textBoxIngredients.Name = "textBoxIngredients";
            this.textBoxIngredients.Size = new System.Drawing.Size(250, 100);
            this.textBoxIngredients.TabIndex = 5;
            // 
            // labelCalories
            // 
            this.labelCalories.AutoSize = true;
            this.labelCalories.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelCalories.Location = new System.Drawing.Point(12, 205);
            this.labelCalories.Name = "labelCalories";
            this.labelCalories.Size = new System.Drawing.Size(105, 20);
            this.labelCalories.TabIndex = 6;
            this.labelCalories.Text = "Калорії (кКал):";
            // 
            // numericUpDownCalories
            // 
            this.numericUpDownCalories.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.numericUpDownCalories.Location = new System.Drawing.Point(120, 202);
            this.numericUpDownCalories.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownCalories.Name = "numericUpDownCalories";
            this.numericUpDownCalories.Size = new System.Drawing.Size(250, 26);
            this.numericUpDownCalories.TabIndex = 7;
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonSave.Location = new System.Drawing.Point(120, 250);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(100, 40);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Зберегти";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonCancel.Location = new System.Drawing.Point(270, 250);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 40);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "Скасувати";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // DishDetailsForm
            // 
            this.ClientSize = new System.Drawing.Size(400, 310);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.numericUpDownCalories);
            this.Controls.Add(this.labelCalories);
            this.Controls.Add(this.textBoxIngredients);
            this.Controls.Add(this.labelIngredients);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Name = "DishDetailsForm";
            this.Text = "Деталі страви";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCalories)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}