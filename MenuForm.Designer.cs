namespace CanteenInterface
{
    partial class MenuForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.ComboBox comboBoxMealTime;
        private System.Windows.Forms.ComboBox comboBoxDish;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.ListBox listBoxMenu;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelMealTime;
        private System.Windows.Forms.Label labelDish;
        private System.Windows.Forms.Label labelMenu;

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
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.comboBoxMealTime = new System.Windows.Forms.ComboBox();
            this.comboBoxDish = new System.Windows.Forms.ComboBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.listBoxMenu = new System.Windows.Forms.ListBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelMealTime = new System.Windows.Forms.Label();
            this.labelDish = new System.Windows.Forms.Label();
            this.labelMenu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateTimePickerDate.Location = new System.Drawing.Point(140, 20);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(250, 26);
            this.dateTimePickerDate.TabIndex = 0;
            this.dateTimePickerDate.ValueChanged += new System.EventHandler(this.dateTimePickerDate_ValueChanged);
            // 
            // comboBoxMealTime
            // 
            this.comboBoxMealTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMealTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBoxMealTime.FormattingEnabled = true;
            this.comboBoxMealTime.Location = new System.Drawing.Point(140, 60);
            this.comboBoxMealTime.Name = "comboBoxMealTime";
            this.comboBoxMealTime.Size = new System.Drawing.Size(250, 28);
            this.comboBoxMealTime.TabIndex = 1;
            this.comboBoxMealTime.SelectedIndexChanged += new System.EventHandler(this.comboBoxMealTime_SelectedIndexChanged);
            // 
            // comboBoxDish
            // 
            this.comboBoxDish.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.comboBoxDish.FormattingEnabled = true;
            this.comboBoxDish.Location = new System.Drawing.Point(140, 100);
            this.comboBoxDish.Name = "comboBoxDish";
            this.comboBoxDish.Size = new System.Drawing.Size(250, 28);
            this.comboBoxDish.TabIndex = 2;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonAdd.Location = new System.Drawing.Point(400, 100);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(100, 28);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "Додати";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonDelete.Location = new System.Drawing.Point(400, 140);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(100, 28);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "Видалити";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // listBoxMenu
            // 
            this.listBoxMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.listBoxMenu.FormattingEnabled = true;
            this.listBoxMenu.ItemHeight = 20;
            this.listBoxMenu.Location = new System.Drawing.Point(140, 140);
            this.listBoxMenu.Name = "listBoxMenu";
            this.listBoxMenu.Size = new System.Drawing.Size(250, 304);
            this.listBoxMenu.TabIndex = 5;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelDate.Location = new System.Drawing.Point(20, 25);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(49, 20);
            this.labelDate.TabIndex = 6;
            this.labelDate.Text = "Дата:";
            // 
            // labelMealTime
            // 
            this.labelMealTime.AutoSize = true;
            this.labelMealTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelMealTime.Location = new System.Drawing.Point(20, 65);
            this.labelMealTime.Name = "labelMealTime";
            this.labelMealTime.Size = new System.Drawing.Size(61, 20);
            this.labelMealTime.TabIndex = 7;
            this.labelMealTime.Text = "Час їжі:";
            // 
            // labelDish
            // 
            this.labelDish.AutoSize = true;
            this.labelDish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelDish.Location = new System.Drawing.Point(20, 105);
            this.labelDish.Name = "labelDish";
            this.labelDish.Size = new System.Drawing.Size(66, 20);
            this.labelDish.TabIndex = 8;
            this.labelDish.Text = "Страва:";
            // 
            // labelMenu
            // 
            this.labelMenu.AutoSize = true;
            this.labelMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelMenu.Location = new System.Drawing.Point(20, 145);
            this.labelMenu.Name = "labelMenu";
            this.labelMenu.Size = new System.Drawing.Size(59, 20);
            this.labelMenu.TabIndex = 9;
            this.labelMenu.Text = "Меню:";
            // 
            // MenuForm
            // 
            this.ClientSize = new System.Drawing.Size(524, 471);
            this.Controls.Add(this.labelMenu);
            this.Controls.Add(this.labelDish);
            this.Controls.Add(this.labelMealTime);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.listBoxMenu);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.comboBoxDish);
            this.Controls.Add(this.comboBoxMealTime);
            this.Controls.Add(this.dateTimePickerDate);
            this.Name = "MenuForm";
            this.Text = "Планування меню";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}