namespace CanteenInterface
{
    partial class SupplyDetailsForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelItemName;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Label labelSupplier;
        private System.Windows.Forms.Label labelPurchaseDate;
        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.TextBox textBoxItemName;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.TextBox textBoxSupplier;
        private System.Windows.Forms.DateTimePicker dateTimePickerPurchaseDate;
        private System.Windows.Forms.NumericUpDown numericUpDownCost;
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
            this.labelItemName = new System.Windows.Forms.Label();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.labelSupplier = new System.Windows.Forms.Label();
            this.labelPurchaseDate = new System.Windows.Forms.Label();
            this.labelCost = new System.Windows.Forms.Label();
            this.textBoxItemName = new System.Windows.Forms.TextBox();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.textBoxSupplier = new System.Windows.Forms.TextBox();
            this.dateTimePickerPurchaseDate = new System.Windows.Forms.DateTimePicker();
            this.numericUpDownCost = new System.Windows.Forms.NumericUpDown();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCost)).BeginInit();
            this.SuspendLayout();
            // 
            // labelItemName
            // 
            this.labelItemName.AutoSize = true;
            this.labelItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelItemName.Location = new System.Drawing.Point(12, 15);
            this.labelItemName.Name = "labelItemName";
            this.labelItemName.Size = new System.Drawing.Size(116, 20);
            this.labelItemName.TabIndex = 0;
            this.labelItemName.Text = "Назва товару:";
            // 
            // textBoxItemName
            // 
            this.textBoxItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxItemName.Location = new System.Drawing.Point(134, 12);
            this.textBoxItemName.Name = "textBoxItemName";
            this.textBoxItemName.Size = new System.Drawing.Size(250, 26);
            this.textBoxItemName.TabIndex = 1;
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelQuantity.Location = new System.Drawing.Point(12, 55);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(83, 20);
            this.labelQuantity.TabIndex = 2;
            this.labelQuantity.Text = "Кількість:";
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxQuantity.Location = new System.Drawing.Point(134, 52);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(250, 26);
            this.textBoxQuantity.TabIndex = 3;
            // 
            // labelSupplier
            // 
            this.labelSupplier.AutoSize = true;
            this.labelSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelSupplier.Location = new System.Drawing.Point(12, 95);
            this.labelSupplier.Name = "labelSupplier";
            this.labelSupplier.Size = new System.Drawing.Size(116, 20);
            this.labelSupplier.TabIndex = 4;
            this.labelSupplier.Text = "Постачальник:";
            // 
            // textBoxSupplier
            // 
            this.textBoxSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxSupplier.Location = new System.Drawing.Point(134, 92);
            this.textBoxSupplier.Name = "textBoxSupplier";
            this.textBoxSupplier.Size = new System.Drawing.Size(250, 26);
            this.textBoxSupplier.TabIndex = 5;
            // 
            // labelPurchaseDate
            // 
            this.labelPurchaseDate.AutoSize = true;
            this.labelPurchaseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelPurchaseDate.Location = new System.Drawing.Point(12, 135);
            this.labelPurchaseDate.Name = "labelPurchaseDate";
            this.labelPurchaseDate.Size = new System.Drawing.Size(116, 20);
            this.labelPurchaseDate.TabIndex = 6;
            this.labelPurchaseDate.Text = "Дата закупівлі:";
            // 
            // dateTimePickerPurchaseDate
            // 
            this.dateTimePickerPurchaseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateTimePickerPurchaseDate.Location = new System.Drawing.Point(134, 132);
            this.dateTimePickerPurchaseDate.Name = "dateTimePickerPurchaseDate";
            this.dateTimePickerPurchaseDate.Size = new System.Drawing.Size(250, 26);
            this.dateTimePickerPurchaseDate.TabIndex = 7;
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelCost.Location = new System.Drawing.Point(12, 175);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(76, 20);
            this.labelCost.TabIndex = 8;
            this.labelCost.Text = "Вартість:";
            // 
            // numericUpDownCost
            // 
            this.numericUpDownCost.DecimalPlaces = 2;
            this.numericUpDownCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.numericUpDownCost.Location = new System.Drawing.Point(134, 172);
            this.numericUpDownCost.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownCost.Name = "numericUpDownCost";
            this.numericUpDownCost.Size = new System.Drawing.Size(250, 26);
            this.numericUpDownCost.TabIndex = 9;
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonSave.Location = new System.Drawing.Point(134, 220);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(100, 40);
            this.buttonSave.TabIndex = 10;
            this.buttonSave.Text = "Зберегти";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonCancel.Location = new System.Drawing.Point(284, 220);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 40);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "Скасувати";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // SupplyDetailsForm
            // 
            this.ClientSize = new System.Drawing.Size(410, 280);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.numericUpDownCost);
            this.Controls.Add(this.labelCost);
            this.Controls.Add(this.dateTimePickerPurchaseDate);
            this.Controls.Add(this.labelPurchaseDate);
            this.Controls.Add(this.textBoxSupplier);
            this.Controls.Add(this.labelSupplier);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.textBoxItemName);
            this.Controls.Add(this.labelItemName);
            this.Name = "SupplyDetailsForm";
            this.Text = "Деталі постачання";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}