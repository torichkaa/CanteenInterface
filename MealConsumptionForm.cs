using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Windows.Forms;

namespace CanteenInterface
{
    public partial class MealConsumptionForm : Form
    {
        private List<MealConsumption> consumptionList = new List<MealConsumption>();

        public MealConsumptionForm()
        {
            InitializeComponent();
            LoadMealConsumptions();
        }

        private void LoadMealConsumptions()
        {
            consumptionList.Clear();
            string query = @"SELECT meal_consumption.*, dishes.name AS DishName
                             FROM meal_consumption
                             JOIN dishes ON meal_consumption.dish_id = dishes.dish_id";
            using (SQLiteConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                SQLiteDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    MealConsumption consumption = new MealConsumption
                    {
                        ConsumptionId = reader.GetInt32(0),
                        ChildId = reader.GetInt32(1),
                        Date = DateTime.Parse(reader.GetString(2)),
                        MealTime = reader.GetString(3),
                        DishId = reader.GetInt32(4),
                        PortionSize = reader.GetString(5),
                        Remarks = reader.IsDBNull(6) ? null : reader.GetString(6),
                        DishName = reader.GetString(7)
                    };
                    consumptionList.Add(consumption);
                }
                reader.Close();
                conn.Close();
            }
            listBoxConsumptions.DataSource = null;
            listBoxConsumptions.DataSource = consumptionList;
            listBoxConsumptions.DisplayMember = "DisplayInfo";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            MealConsumptionDetailsForm detailsForm = new MealConsumptionDetailsForm();
            if (detailsForm.ShowDialog() == DialogResult.OK)
            {
                MealConsumption newConsumption = detailsForm.MealConsumption;
                string query = "INSERT INTO meal_consumption (child_id, date, meal_time, dish_id, portion_size, remarks) VALUES (@ChildId, @Date, @MealTime, @DishId, @PortionSize, @Remarks)";
                using (SQLiteConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    SQLiteCommand cmd = new SQLiteCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ChildId", newConsumption.ChildId);
                    cmd.Parameters.AddWithValue("@Date", newConsumption.Date.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@MealTime", newConsumption.MealTime);
                    cmd.Parameters.AddWithValue("@DishId", newConsumption.DishId);
                    cmd.Parameters.AddWithValue("@PortionSize", newConsumption.PortionSize);
                    cmd.Parameters.AddWithValue("@Remarks", newConsumption.Remarks);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                LoadMealConsumptions();
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listBoxConsumptions.SelectedItem != null)
            {
                MealConsumption selectedConsumption = (MealConsumption)listBoxConsumptions.SelectedItem;
                MealConsumptionDetailsForm detailsForm = new MealConsumptionDetailsForm(selectedConsumption);
                if (detailsForm.ShowDialog() == DialogResult.OK)
                {
                    MealConsumption updatedConsumption = detailsForm.MealConsumption;
                    string query = "UPDATE meal_consumption SET child_id=@ChildId, date=@Date, meal_time=@MealTime, dish_id=@DishId, portion_size=@PortionSize, remarks=@Remarks WHERE consumption_id=@ConsumptionId";
                    using (SQLiteConnection conn = DatabaseHelper.GetConnection())
                    {
                        conn.Open();
                        SQLiteCommand cmd = new SQLiteCommand(query, conn);
                        cmd.Parameters.AddWithValue("@ChildId", updatedConsumption.ChildId);
                        cmd.Parameters.AddWithValue("@Date", updatedConsumption.Date.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@MealTime", updatedConsumption.MealTime);
                        cmd.Parameters.AddWithValue("@DishId", updatedConsumption.DishId);
                        cmd.Parameters.AddWithValue("@PortionSize", updatedConsumption.PortionSize);
                        cmd.Parameters.AddWithValue("@Remarks", updatedConsumption.Remarks);
                        cmd.Parameters.AddWithValue("@ConsumptionId", updatedConsumption.ConsumptionId);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                    LoadMealConsumptions();
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxConsumptions.SelectedItem != null)
            {
                MealConsumption selectedConsumption = (MealConsumption)listBoxConsumptions.SelectedItem;
                DialogResult result = MessageBox.Show("Ви впевнені, що хочете видалити цей запис?", "Підтвердження видалення", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    string query = "DELETE FROM meal_consumption WHERE consumption_id=@ConsumptionId";
                    using (SQLiteConnection conn = DatabaseHelper.GetConnection())
                    {
                        conn.Open();
                        SQLiteCommand cmd = new SQLiteCommand(query, conn);
                        cmd.Parameters.AddWithValue("@ConsumptionId", selectedConsumption.ConsumptionId);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                    LoadMealConsumptions();
                }
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string search = textBoxSearch.Text.ToLower();
            var filteredList = consumptionList.FindAll(c => c.ChildId.ToString().Contains(search) || c.Date.ToString("yyyy-MM-dd").Contains(search) || c.DishName.ToLower().Contains(search));
            listBoxConsumptions.DataSource = null;
            listBoxConsumptions.DataSource = filteredList;
            listBoxConsumptions.DisplayMember = "DisplayInfo";
        }
    }
}