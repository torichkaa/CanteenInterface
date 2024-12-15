using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Windows.Forms;

namespace CanteenInterface
{
    public partial class StaffForm : Form
    {
        private List<CafeteriaStaff> staffList = new List<CafeteriaStaff>();

        public StaffForm()
        {
            InitializeComponent();
            LoadStaff();
        }

        private void LoadStaff()
        {
            staffList.Clear();
            string query = "SELECT * FROM cafeteria_staff";
            using (SQLiteConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                SQLiteDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    CafeteriaStaff staff = new CafeteriaStaff
                    {
                        StaffId = reader.GetInt32(0),
                        FirstName = reader.GetString(1),
                        LastName = reader.GetString(2),
                        Role = reader.GetString(3),
                        Phone = reader.IsDBNull(4) ? null : reader.GetString(4),
                        Email = reader.IsDBNull(5) ? null : reader.GetString(5),
                        HireDate = DateTime.Parse(reader.GetString(6))
                    };
                    staffList.Add(staff);
                }
                reader.Close();
                conn.Close();
            }
            listBoxStaff.DataSource = null;
            listBoxStaff.DataSource = staffList;
            listBoxStaff.DisplayMember = "DisplayInfo";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            StaffDetailsForm detailsForm = new StaffDetailsForm();
            if (detailsForm.ShowDialog() == DialogResult.OK)
            {
                CafeteriaStaff newStaff = detailsForm.Staff;
                string query = "INSERT INTO cafeteria_staff (first_name, last_name, role, phone, email, hire_date) VALUES (@FirstName, @LastName, @Role, @Phone, @Email, @HireDate)";
                using (SQLiteConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    SQLiteCommand cmd = new SQLiteCommand(query, conn);
                    cmd.Parameters.AddWithValue("@FirstName", newStaff.FirstName);
                    cmd.Parameters.AddWithValue("@LastName", newStaff.LastName);
                    cmd.Parameters.AddWithValue("@Role", newStaff.Role);
                    cmd.Parameters.AddWithValue("@Phone", newStaff.Phone);
                    cmd.Parameters.AddWithValue("@Email", newStaff.Email);
                    cmd.Parameters.AddWithValue("@HireDate", newStaff.HireDate.ToString("yyyy-MM-dd"));
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                LoadStaff();
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listBoxStaff.SelectedItem != null)
            {
                CafeteriaStaff selectedStaff = (CafeteriaStaff)listBoxStaff.SelectedItem;
                StaffDetailsForm detailsForm = new StaffDetailsForm(selectedStaff);
                if (detailsForm.ShowDialog() == DialogResult.OK)
                {
                    CafeteriaStaff updatedStaff = detailsForm.Staff;
                    string query = "UPDATE cafeteria_staff SET first_name=@FirstName, last_name=@LastName, role=@Role, phone=@Phone, email=@Email, hire_date=@HireDate WHERE staff_id=@StaffId";
                    using (SQLiteConnection conn = DatabaseHelper.GetConnection())
                    {
                        conn.Open();
                        SQLiteCommand cmd = new SQLiteCommand(query, conn);
                        cmd.Parameters.AddWithValue("@FirstName", updatedStaff.FirstName);
                        cmd.Parameters.AddWithValue("@LastName", updatedStaff.LastName);
                        cmd.Parameters.AddWithValue("@Role", updatedStaff.Role);
                        cmd.Parameters.AddWithValue("@Phone", updatedStaff.Phone);
                        cmd.Parameters.AddWithValue("@Email", updatedStaff.Email);
                        cmd.Parameters.AddWithValue("@HireDate", updatedStaff.HireDate.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@StaffId", updatedStaff.StaffId);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                    LoadStaff();
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxStaff.SelectedItem != null)
            {
                CafeteriaStaff selectedStaff = (CafeteriaStaff)listBoxStaff.SelectedItem;
                DialogResult result = MessageBox.Show("Ви впевнені, що хочете видалити цього співробітника?", "Підтвердження видалення", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    string query = "DELETE FROM cafeteria_staff WHERE staff_id=@StaffId";
                    using (SQLiteConnection conn = DatabaseHelper.GetConnection())
                    {
                        conn.Open();
                        SQLiteCommand cmd = new SQLiteCommand(query, conn);
                        cmd.Parameters.AddWithValue("@StaffId", selectedStaff.StaffId);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                    LoadStaff();
                }
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string search = textBoxSearch.Text.ToLower();
            var filteredList = staffList.FindAll(s => s.FirstName.ToLower().Contains(search) || s.LastName.ToLower().Contains(search) || s.Role.ToLower().Contains(search));
            listBoxStaff.DataSource = null;
            listBoxStaff.DataSource = filteredList;
            listBoxStaff.DisplayMember = "DisplayInfo";
        }
    }
}