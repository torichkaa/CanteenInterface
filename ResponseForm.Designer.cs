namespace CanteenInterface
{
    partial class ResponseForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBoxResponse;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelResponse;

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
            this.textBoxResponse = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelResponse = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxResponse
            // 
            this.textBoxResponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxResponse.Location = new System.Drawing.Point(12, 42);
            this.textBoxResponse.Multiline = true;
            this.textBoxResponse.Name = "textBoxResponse";
            this.textBoxResponse.Size = new System.Drawing.Size(360, 150);
            this.textBoxResponse.TabIndex = 0;
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonSave.Location = new System.Drawing.Point(192, 210);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(80, 40);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Зберегти";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonCancel.Location = new System.Drawing.Point(292, 210);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(80, 40);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Скасувати";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelResponse
            // 
            this.labelResponse.AutoSize = true;
            this.labelResponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelResponse.Location = new System.Drawing.Point(12, 19);
            this.labelResponse.Name = "labelResponse";
            this.labelResponse.Size = new System.Drawing.Size(83, 20);
            this.labelResponse.TabIndex = 3;
            this.labelResponse.Text = "Відповідь:";
            // 
            // ResponseForm
            // 
            this.ClientSize = new System.Drawing.Size(384, 271);
            this.Controls.Add(this.labelResponse);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxResponse);
            this.Name = "ResponseForm";
            this.Text = "Додати відповідь";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}