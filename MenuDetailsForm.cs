using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Windows.Forms;

namespace CanteenInterface
{
    public partial class MenuDetailsForm : Form
    {
        public Menu MenuItem { get; private set; }
        private List<Dish> dishList = new List<Dish>();

        public MenuDetailsForm()
        {
            InitializeComponent();
            InitializeMealTimeComboBox();
            LoadDishes();
        }

        public MenuDetailsForm(Menu menuItem) : this()
        {
            MenuItem = menuItem;
            dateTimePickerDate.Value = MenuItem.Date;
            comboBoxMealTime.SelectedItem = MenuItem.MealTime;
            comboBoxDish.SelectedValue = MenuItem.DishId;
        }

        private void InitializeMealTimeComboBox()
        {
            comboBoxMealTime.Items.Add("сніданок");
            comboBoxMealTime.Items.Add("обід");
            comboBoxMealTime.Items.Add("вечеря");
            comboBoxMealTime.SelectedIndex = 0;
        }

        private void LoadDishes()
        {
            dishList.Clear();
            string query = "SELECT * FROM dishes";
            using (SQLiteConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                SQLiteDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Dish dish = new Dish
                    {
                        DishId = reader.GetInt32(0),
                        Name = reader.GetString(1)
                    };
                    dishList.Add(dish);
                }
                reader.Close();
                conn.Close();
            }
            comboBoxDish.DataSource = null;
            comboBoxDish.DataSource = dishList;
            comboBoxDish.DisplayMember = "Name";
            comboBoxDish.ValueMember = "DishId";
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (MenuItem == null)
                MenuItem = new Menu();

            MenuItem.Date = dateTimePickerDate.Value.Date;
            MenuItem.MealTime = comboBoxMealTime.SelectedItem.ToString();
            MenuItem.DishId = (int)comboBoxDish.SelectedValue;

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