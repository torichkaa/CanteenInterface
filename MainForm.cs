using System;
using System.Windows.Forms;

namespace CanteenInterface
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonStaff_Click(object sender, EventArgs e)
        {
            StaffForm staffForm = new StaffForm();
            staffForm.ShowDialog();
        }

        private void buttonDishes_Click(object sender, EventArgs e)
        {
            DishesForm dishesForm = new DishesForm();
            dishesForm.ShowDialog();
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            MenuForm menuForm = new MenuForm();
            menuForm.ShowDialog();
        }

        private void buttonSupplies_Click(object sender, EventArgs e)
        {
            SuppliesForm suppliesForm = new SuppliesForm();
            suppliesForm.ShowDialog();
        }

        private void buttonMealConsumption_Click(object sender, EventArgs e)
        {
            MealConsumptionForm mealConsumptionForm = new MealConsumptionForm();
            mealConsumptionForm.ShowDialog();
        }

        private void buttonFeedback_Click(object sender, EventArgs e)
        {
            FeedbackForm feedbackForm = new FeedbackForm();
            feedbackForm.ShowDialog();
        }
    }
}