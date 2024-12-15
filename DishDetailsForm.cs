using System;
using System.Windows.Forms;

namespace CanteenInterface
{
    public partial class DishDetailsForm : Form
    {
        public Dish Dish { get; private set; }

        public DishDetailsForm()
        {
            InitializeComponent();
            comboBoxType.SelectedIndex = 0;
        }

        public DishDetailsForm(Dish dish) : this()
        {
            Dish = dish;
            textBoxName.Text = Dish.Name;
            comboBoxType.SelectedItem = Dish.Type;
            textBoxIngredients.Text = Dish.Ingredients;
            numericUpDownCalories.Value = Dish.Calories;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (Dish == null)
                Dish = new Dish();

            Dish.Name = textBoxName.Text;
            Dish.Type = comboBoxType.SelectedItem.ToString();
            Dish.Ingredients = textBoxIngredients.Text;
            Dish.Calories = (int)numericUpDownCalories.Value;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}