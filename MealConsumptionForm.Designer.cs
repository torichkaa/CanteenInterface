namespace CanteenInterface
{
    partial class MealConsumptionForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox listBoxConsumptions;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label labelSearch;

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
            this.listBoxConsumptions = new System.Windows.Forms.ListBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxConsumptions
            // 
            this.listBoxConsumptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.listBoxConsumptions.FormattingEnabled = true;
            this.listBoxConsumptions.ItemHeight = 20;
            this.listBoxConsumptions.Location = new System.Drawing.Point(12, 52);
            this.listBoxConsumptions.Name = "listBoxConsumptions";
            this.listBoxConsumptions.Size = new System.Drawing.Size(760, 384);
            this.listBoxConsumptions.TabIndex = 0;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonAdd.Location = new System.Drawing.Point(12, 450);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(100, 40);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Додати";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonEdit.Location = new System.Drawing.Point(118, 450);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(120, 40);
            this.buttonEdit.TabIndex = 2;
            this.buttonEdit.Text = "Редагувати";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonDelete.Location = new System.Drawing.Point(244, 450);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(100, 40);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Видалити";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxSearch.Location = new System.Drawing.Point(85, 12);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(250, 26);
            this.textBoxSearch.TabIndex = 4;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelSearch.Location = new System.Drawing.Point(12, 15);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(67, 20);
            this.labelSearch.TabIndex = 5;
            this.labelSearch.Text = "Пошук:";
            // 
            // MealConsumptionForm
            // 
            this.ClientSize = new System.Drawing.Size(784, 511);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listBoxConsumptions);
            this.Name = "MealConsumptionForm";
            this.Text = "Відстеження споживання їжі";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}