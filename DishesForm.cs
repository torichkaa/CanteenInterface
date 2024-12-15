using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Windows.Forms;

namespace CanteenInterface
{
    public partial class DishesForm : Form
    {
        private List<Dish> dishList = new List<Dish>();

        public DishesForm()
        {
            InitializeComponent();
            LoadDishes();
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
            listBoxDishes.DataSource = null;
            listBoxDishes.DataSource = dishList;
            listBoxDishes.DisplayMember = "DisplayInfo";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            DishDetailsForm detailsForm = new DishDetailsForm();
            if (detailsForm.ShowDialog() == DialogResult.OK)
            {
                Dish newDish = detailsForm.Dish;
                string query = "INSERT INTO dishes (name, type, ingredients, calories) VALUES (@Name, @Type, @Ingredients, @Calories)";
                using (SQLiteConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    SQLiteCommand cmd = new SQLiteCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Name", newDish.Name);
                    cmd.Parameters.AddWithValue("@Type", newDish.Type);
                    cmd.Parameters.AddWithValue("@Ingredients", newDish.Ingredients);
                    cmd.Parameters.AddWithValue("@Calories", newDish.Calories);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                LoadDishes();
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listBoxDishes.SelectedItem != null)
            {
                Dish selectedDish = (Dish)listBoxDishes.SelectedItem;
                DishDetailsForm detailsForm = new DishDetailsForm(selectedDish);
                if (detailsForm.ShowDialog() == DialogResult.OK)
                {
                    Dish updatedDish = detailsForm.Dish;
                    string query = "UPDATE dishes SET name=@Name, type=@Type, ingredients=@Ingredients, calories=@Calories WHERE dish_id=@DishId";
                    using (SQLiteConnection conn = DatabaseHelper.GetConnection())
                    {
                        conn.Open();
                        SQLiteCommand cmd = new SQLiteCommand(query, conn);
                        cmd.Parameters.AddWithValue("@Name", updatedDish.Name);
                        cmd.Parameters.AddWithValue("@Type", updatedDish.Type);
                        cmd.Parameters.AddWithValue("@Ingredients", updatedDish.Ingredients);
                        cmd.Parameters.AddWithValue("@Calories", updatedDish.Calories);
                        cmd.Parameters.AddWithValue("@DishId", updatedDish.DishId);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                    LoadDishes();
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxDishes.SelectedItem != null)
            {
                Dish selectedDish = (Dish)listBoxDishes.SelectedItem;
                DialogResult result = MessageBox.Show("Ви впевнені, що хочете видалити цю страву? Це видалить всі записи, пов'язані з нею.", "Підтвердження видалення", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    using (SQLiteConnection conn = DatabaseHelper.GetConnection())
                    {
                        conn.Open();

                        string checkMealConsumption = "SELECT COUNT(*) FROM meal_consumption WHERE dish_id=@DishId";
                        SQLiteCommand checkCmd1 = new SQLiteCommand(checkMealConsumption, conn);
                        checkCmd1.Parameters.AddWithValue("@DishId", selectedDish.DishId);
                        int countMealConsumption = Convert.ToInt32(checkCmd1.ExecuteScalar());
                        if (countMealConsumption > 0)
                        {
                            string deleteMealConsumption = "DELETE FROM meal_consumption WHERE dish_id=@DishId";
                            SQLiteCommand deleteCmd1 = new SQLiteCommand(deleteMealConsumption, conn);
                            deleteCmd1.Parameters.AddWithValue("@DishId", selectedDish.DishId);
                            deleteCmd1.ExecuteNonQuery();
                        }

                        string checkMenu = "SELECT COUNT(*) FROM menu WHERE dish_id=@DishId";
                        SQLiteCommand checkCmd2 = new SQLiteCommand(checkMenu, conn);
                        checkCmd2.Parameters.AddWithValue("@DishId", selectedDish.DishId);
                        int countMenu = Convert.ToInt32(checkCmd2.ExecuteScalar());
                        if (countMenu > 0)
                        {
                            string deleteMenu = "DELETE FROM menu WHERE dish_id=@DishId";
                            SQLiteCommand deleteCmd2 = new SQLiteCommand(deleteMenu, conn);
                            deleteCmd2.Parameters.AddWithValue("@DishId", selectedDish.DishId);
                            deleteCmd2.ExecuteNonQuery();
                        }

                        string query = "DELETE FROM dishes WHERE dish_id=@DishId";
                        SQLiteCommand cmd = new SQLiteCommand(query, conn);
                        cmd.Parameters.AddWithValue("@DishId", selectedDish.DishId);
                        cmd.ExecuteNonQuery();

                        conn.Close();
                    }
                    LoadDishes();
                }
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string search = textBoxSearch.Text.ToLower();
            var filteredList = dishList.FindAll(d => d.Name.ToLower().Contains(search) || d.Type.ToLower().Contains(search));
            listBoxDishes.DataSource = null;
            listBoxDishes.DataSource = filteredList;
            listBoxDishes.DisplayMember = "DisplayInfo";
        }
    }
}