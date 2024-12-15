using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Windows.Forms;

namespace CanteenInterface
{
    public partial class MenuForm : Form
    {
        private List<Dish> dishList = new List<Dish>();
        private List<Menu> menuList = new List<Menu>();

        public MenuForm()
        {
            InitializeComponent();
            LoadDishes();
            InitializeMealTimeComboBox();
            LoadMenu();
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
                        Name = reader.GetString(1),
                        Type = reader.GetString(2),
                        Ingredients = reader.GetString(3),
                        Calories = reader.GetInt32(4)
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

        private void LoadMenu()
        {
            menuList.Clear();
            listBoxMenu.Items.Clear();
            string query = @"SELECT menu.menu_id, menu.date, menu.group_id, menu.dish_id, menu.meal_time, dishes.name
                             FROM menu
                             JOIN dishes ON menu.dish_id = dishes.dish_id
                             WHERE date = @Date AND meal_time = @MealTime";
            using (SQLiteConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@Date", dateTimePickerDate.Value.Date.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@MealTime", comboBoxMealTime.SelectedItem.ToString());
                SQLiteDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Menu menu = new Menu
                    {
                        MenuId = reader.GetInt32(0),
                        Date = DateTime.Parse(reader.GetString(1)),
                        GroupId = reader.GetInt32(2),
                        DishId = reader.GetInt32(3),
                        MealTime = reader.GetString(4),
                        DishName = reader.GetString(5)
                    };
                    menuList.Add(menu);
                    listBoxMenu.Items.Add(menu.DishName);
                }
                reader.Close();
                conn.Close();
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxDish.SelectedItem != null)
            {
                Dish selectedDish = (Dish)comboBoxDish.SelectedItem;
                string query = "INSERT INTO menu (date, group_id, dish_id, meal_time) VALUES (@Date, @GroupId, @DishId, @MealTime)";
                using (SQLiteConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    SQLiteCommand cmd = new SQLiteCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Date", dateTimePickerDate.Value.Date.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@GroupId", 0);
                    cmd.Parameters.AddWithValue("@DishId", selectedDish.DishId);
                    cmd.Parameters.AddWithValue("@MealTime", comboBoxMealTime.SelectedItem.ToString());
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                LoadMenu();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxMenu.SelectedItem != null)
            {
                string selectedDishName = listBoxMenu.SelectedItem.ToString();
                Menu selectedMenu = menuList.Find(m => m.DishName == selectedDishName);
                if (selectedMenu != null)
                {
                    string query = "DELETE FROM menu WHERE menu_id = @MenuId";
                    using (SQLiteConnection conn = DatabaseHelper.GetConnection())
                    {
                        conn.Open();
                        SQLiteCommand cmd = new SQLiteCommand(query, conn);
                        cmd.Parameters.AddWithValue("@MenuId", selectedMenu.MenuId);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                    LoadMenu();
                }
            }
        }

        private void dateTimePickerDate_ValueChanged(object sender, EventArgs e)
        {
            LoadMenu();
        }

        private void comboBoxMealTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMenu();
        }
    }
}