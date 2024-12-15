namespace CanteenInterface
{
    partial class FeedbackForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox listBoxFeedbacks;
        private System.Windows.Forms.TextBox textBoxContent;
        private System.Windows.Forms.TextBox textBoxResponse;
        private System.Windows.Forms.Button buttonAddResponse;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAddFeedback;
        private System.Windows.Forms.Label labelContent;
        private System.Windows.Forms.Label labelResponse;
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
            this.listBoxFeedbacks = new System.Windows.Forms.ListBox();
            this.textBoxContent = new System.Windows.Forms.TextBox();
            this.textBoxResponse = new System.Windows.Forms.TextBox();
            this.buttonAddResponse = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAddFeedback = new System.Windows.Forms.Button();
            this.labelContent = new System.Windows.Forms.Label();
            this.labelResponse = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxFeedbacks
            // 
            this.listBoxFeedbacks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.listBoxFeedbacks.FormattingEnabled = true;
            this.listBoxFeedbacks.ItemHeight = 20;
            this.listBoxFeedbacks.Location = new System.Drawing.Point(12, 52);
            this.listBoxFeedbacks.Name = "listBoxFeedbacks";
            this.listBoxFeedbacks.Size = new System.Drawing.Size(360, 384);
            this.listBoxFeedbacks.TabIndex = 0;
            this.listBoxFeedbacks.SelectedIndexChanged += new System.EventHandler(this.listBoxFeedbacks_SelectedIndexChanged);
            // 
            // textBoxContent
            // 
            this.textBoxContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxContent.Location = new System.Drawing.Point(388, 52);
            this.textBoxContent.Multiline = true;
            this.textBoxContent.Name = "textBoxContent";
            this.textBoxContent.ReadOnly = true;
            this.textBoxContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxContent.Size = new System.Drawing.Size(380, 150);
            this.textBoxContent.TabIndex = 1;
            // 
            // textBoxResponse
            // 
            this.textBoxResponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxResponse.Location = new System.Drawing.Point(388, 244);
            this.textBoxResponse.Multiline = true;
            this.textBoxResponse.Name = "textBoxResponse";
            this.textBoxResponse.ReadOnly = true;
            this.textBoxResponse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResponse.Size = new System.Drawing.Size(380, 150);
            this.textBoxResponse.TabIndex = 2;
            // 
            // buttonAddResponse
            // 
            this.buttonAddResponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonAddResponse.Location = new System.Drawing.Point(388, 410);
            this.buttonAddResponse.Name = "buttonAddResponse";
            this.buttonAddResponse.Size = new System.Drawing.Size(150, 40);
            this.buttonAddResponse.TabIndex = 3;
            this.buttonAddResponse.Text = "Додати відповідь";
            this.buttonAddResponse.UseVisualStyleBackColor = true;
            this.buttonAddResponse.Click += new System.EventHandler(this.buttonAddResponse_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonDelete.Location = new System.Drawing.Point(618, 410);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(150, 40);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "Видалити";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAddFeedback
            // 
            this.buttonAddFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonAddFeedback.Location = new System.Drawing.Point(12, 450);
            this.buttonAddFeedback.Name = "buttonAddFeedback";
            this.buttonAddFeedback.Size = new System.Drawing.Size(150, 40);
            this.buttonAddFeedback.TabIndex = 5;
            this.buttonAddFeedback.Text = "Додати відгук";
            this.buttonAddFeedback.UseVisualStyleBackColor = true;
            this.buttonAddFeedback.Click += new System.EventHandler(this.buttonAddFeedback_Click);
            // 
            // labelContent
            // 
            this.labelContent.AutoSize = true;
            this.labelContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelContent.Location = new System.Drawing.Point(384, 29);
            this.labelContent.Name = "labelContent";
            this.labelContent.Size = new System.Drawing.Size(116, 20);
            this.labelContent.TabIndex = 6;
            this.labelContent.Text = "Зміст відгуку:";
            // 
            // labelResponse
            // 
            this.labelResponse.AutoSize = true;
            this.labelResponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelResponse.Location = new System.Drawing.Point(384, 221);
            this.labelResponse.Name = "labelResponse";
            this.labelResponse.Size = new System.Drawing.Size(83, 20);
            this.labelResponse.TabIndex = 7;
            this.labelResponse.Text = "Відповідь:";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxSearch.Location = new System.Drawing.Point(85, 12);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(250, 26);
            this.textBoxSearch.TabIndex = 8;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelSearch.Location = new System.Drawing.Point(12, 15);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(67, 20);
            this.labelSearch.TabIndex = 9;
            this.labelSearch.Text = "Пошук:";
            // 
            // FeedbackForm
            // 
            this.ClientSize = new System.Drawing.Size(784, 511);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.labelResponse);
            this.Controls.Add(this.labelContent);
            this.Controls.Add(this.buttonAddFeedback);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAddResponse);
            this.Controls.Add(this.textBoxResponse);
            this.Controls.Add(this.textBoxContent);
            this.Controls.Add(this.listBoxFeedbacks);
            this.Name = "FeedbackForm";
            this.Text = "Управління відгуками";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}