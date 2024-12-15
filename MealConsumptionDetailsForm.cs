using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Windows.Forms;

namespace CanteenInterface
{
    public partial class MealConsumptionDetailsForm : Form
    {
        public MealConsumption MealConsumption { get; private set; }
        private List<Dish> dishList = new List<Dish>();

        public MealConsumptionDetailsForm()
        {
            InitializeComponent();
            InitializeMealTimeComboBox();
            dateTimePickerDate.ValueChanged += DateTimePickerDate_ValueChanged;
            comboBoxMealTime.SelectedIndexChanged += ComboBoxMealTime_SelectedIndexChanged;
            LoadDishes();
        }

        public MealConsumptionDetailsForm(MealConsumption consumption) : this()
        {
            MealConsumption = consumption;
            numericUpDownChildId.Value = MealConsumption.ChildId;
            dateTimePickerDate.Value = MealConsumption.Date;
            comboBoxMealTime.SelectedItem = MealConsumption.MealTime;
            LoadDishes();
            comboBoxDish.SelectedValue = MealConsumption.DishId;
            textBoxPortionSize.Text = MealConsumption.PortionSize;
            textBoxRemarks.Text = MealConsumption.Remarks;
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
            string query = @"SELECT dishes.dish_id, dishes.name
                             FROM menu
                             JOIN dishes ON menu.dish_id = dishes.dish_id
                             WHERE menu.date = @Date AND menu.meal_time = @MealTime";
            using (SQLiteConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@Date", dateTimePickerDate.Value.Date.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@MealTime", comboBoxMealTime.SelectedItem.ToString());
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
            if (MealConsumption == null)
                MealConsumption = new MealConsumption();

            MealConsumption.ChildId = (int)numericUpDownChildId.Value;
            MealConsumption.Date = dateTimePickerDate.Value.Date;
            MealConsumption.MealTime = comboBoxMealTime.SelectedItem.ToString();
            MealConsumption.DishId = (int)comboBoxDish.SelectedValue;
            MealConsumption.PortionSize = textBoxPortionSize.Text;
            MealConsumption.Remarks = textBoxRemarks.Text;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void DateTimePickerDate_ValueChanged(object sender, EventArgs e)
        {
            LoadDishes();
        }

        private void ComboBoxMealTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDishes();
        }
    }
}