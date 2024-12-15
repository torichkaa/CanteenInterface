namespace CanteenInterface
{
    partial class StaffDetailsForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelHireDate;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.ComboBox comboBoxRole;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.DateTimePicker dateTimePickerHireDate;
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
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelRole = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelHireDate = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.comboBoxRole = new System.Windows.Forms.ComboBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.dateTimePickerHireDate = new System.Windows.Forms.DateTimePicker();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelFirstName.Location = new System.Drawing.Point(12, 15);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(39, 20);
            this.labelFirstName.TabIndex = 0;
            this.labelFirstName.Text = "Ім'я:";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxFirstName.Location = new System.Drawing.Point(120, 12);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(250, 26);
            this.textBoxFirstName.TabIndex = 1;
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelLastName.Location = new System.Drawing.Point(12, 55);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(82, 20);
            this.labelLastName.TabIndex = 2;
            this.labelLastName.Text = "Прізвище:";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxLastName.Location = new System.Drawing.Point(120, 52);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(250, 26);
            this.textBoxLastName.TabIndex = 3;
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelRole.Location = new System.Drawing.Point(12, 95);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(51, 20);
            this.labelRole.TabIndex = 4;
            this.labelRole.Text = "Роль:";
            // 
            // comboBoxRole
            // 
            this.comboBoxRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBoxRole.FormattingEnabled = true;
            this.comboBoxRole.Items.AddRange(new object[] {
            "кухар",
            "помічник кухаря",
            "прибиральник",
            "інше"});
            this.comboBoxRole.Location = new System.Drawing.Point(120, 92);
            this.comboBoxRole.Name = "comboBoxRole";
            this.comboBoxRole.Size = new System.Drawing.Size(250, 28);
            this.comboBoxRole.TabIndex = 5;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelPhone.Location = new System.Drawing.Point(12, 135);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(80, 20);
            this.labelPhone.TabIndex = 6;
            this.labelPhone.Text = "Телефон:";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxPhone.Location = new System.Drawing.Point(120, 132);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(250, 26);
            this.textBoxPhone.TabIndex = 7;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelEmail.Location = new System.Drawing.Point(12, 175);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(52, 20);
            this.labelEmail.TabIndex = 8;
            this.labelEmail.Text = "Email:";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxEmail.Location = new System.Drawing.Point(120, 172);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(250, 26);
            this.textBoxEmail.TabIndex = 9;
            // 
            // labelHireDate
            // 
            this.labelHireDate.AutoSize = true;
            this.labelHireDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelHireDate.Location = new System.Drawing.Point(12, 215);
            this.labelHireDate.Name = "labelHireDate";
            this.labelHireDate.Size = new System.Drawing.Size(125, 20);
            this.labelHireDate.TabIndex = 10;
            this.labelHireDate.Text = "Дата прийому:";
            // 
            // dateTimePickerHireDate
            // 
            this.dateTimePickerHireDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateTimePickerHireDate.Location = new System.Drawing.Point(143, 212);
            this.dateTimePickerHireDate.Name = "dateTimePickerHireDate";
            this.dateTimePickerHireDate.Size = new System.Drawing.Size(227, 26);
            this.dateTimePickerHireDate.TabIndex = 11;
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonSave.Location = new System.Drawing.Point(120, 260);
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
            this.buttonCancel.Location = new System.Drawing.Point(270, 260);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 40);
            this.buttonCancel.TabIndex = 13;
            this.buttonCancel.Text = "Скасувати";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // StaffDetailsForm
            // 
            this.ClientSize = new System.Drawing.Size(400, 320);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.dateTimePickerHireDate);
            this.Controls.Add(this.labelHireDate);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.comboBoxRole);
            this.Controls.Add(this.labelRole);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.labelFirstName);
            this.Name = "StaffDetailsForm";
            this.Text = "Деталі співробітника";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}