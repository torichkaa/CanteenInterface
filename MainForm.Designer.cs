namespace CanteenInterface
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button buttonStaff;
        private System.Windows.Forms.Button buttonDishes;
        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.Button buttonSupplies;
        private System.Windows.Forms.Button buttonMealConsumption;
        private System.Windows.Forms.Button buttonFeedback;

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
            this.buttonStaff = new System.Windows.Forms.Button();
            this.buttonDishes = new System.Windows.Forms.Button();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.buttonSupplies = new System.Windows.Forms.Button();
            this.buttonMealConsumption = new System.Windows.Forms.Button();
            this.buttonFeedback = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonStaff
            // 
            this.buttonStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonStaff.Location = new System.Drawing.Point(50, 50);
            this.buttonStaff.Name = "buttonStaff";
            this.buttonStaff.Size = new System.Drawing.Size(300, 60);
            this.buttonStaff.TabIndex = 0;
            this.buttonStaff.Text = "Управління персоналом";
            this.buttonStaff.UseVisualStyleBackColor = true;
            this.buttonStaff.Click += new System.EventHandler(this.buttonStaff_Click);
            // 
            // buttonDishes
            // 
            this.buttonDishes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonDishes.Location = new System.Drawing.Point(50, 130);
            this.buttonDishes.Name = "buttonDishes";
            this.buttonDishes.Size = new System.Drawing.Size(300, 60);
            this.buttonDishes.TabIndex = 1;
            this.buttonDishes.Text = "Управління стравами";
            this.buttonDishes.UseVisualStyleBackColor = true;
            this.buttonDishes.Click += new System.EventHandler(this.buttonDishes_Click);
            // 
            // buttonMenu
            // 
            this.buttonMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonMenu.Location = new System.Drawing.Point(50, 210);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(300, 60);
            this.buttonMenu.TabIndex = 2;
            this.buttonMenu.Text = "Планування меню";
            this.buttonMenu.UseVisualStyleBackColor = true;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // buttonSupplies
            // 
            this.buttonSupplies.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonSupplies.Location = new System.Drawing.Point(50, 290);
            this.buttonSupplies.Name = "buttonSupplies";
            this.buttonSupplies.Size = new System.Drawing.Size(300, 60);
            this.buttonSupplies.TabIndex = 3;
            this.buttonSupplies.Text = "Управління постачаннями";
            this.buttonSupplies.UseVisualStyleBackColor = true;
            this.buttonSupplies.Click += new System.EventHandler(this.buttonSupplies_Click);
            // 
            // buttonMealConsumption
            // 
            this.buttonMealConsumption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonMealConsumption.Location = new System.Drawing.Point(50, 370);
            this.buttonMealConsumption.Name = "buttonMealConsumption";
            this.buttonMealConsumption.Size = new System.Drawing.Size(300, 60);
            this.buttonMealConsumption.TabIndex = 4;
            this.buttonMealConsumption.Text = "Відстеження споживання їжі";
            this.buttonMealConsumption.UseVisualStyleBackColor = true;
            this.buttonMealConsumption.Click += new System.EventHandler(this.buttonMealConsumption_Click);
            // 
            // buttonFeedback
            // 
            this.buttonFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonFeedback.Location = new System.Drawing.Point(50, 450);
            this.buttonFeedback.Name = "buttonFeedback";
            this.buttonFeedback.Size = new System.Drawing.Size(300, 60);
            this.buttonFeedback.TabIndex = 5;
            this.buttonFeedback.Text = "Управління відгуками";
            this.buttonFeedback.UseVisualStyleBackColor = true;
            this.buttonFeedback.Click += new System.EventHandler(this.buttonFeedback_Click);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(400, 550);
            this.Controls.Add(this.buttonFeedback);
            this.Controls.Add(this.buttonMealConsumption);
            this.Controls.Add(this.buttonSupplies);
            this.Controls.Add(this.buttonMenu);
            this.Controls.Add(this.buttonDishes);
            this.Controls.Add(this.buttonStaff);
            this.Name = "MainForm";
            this.Text = "Canteen Interface";
            this.ResumeLayout(false);
        }
    }
}