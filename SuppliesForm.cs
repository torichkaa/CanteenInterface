using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Windows.Forms;

namespace CanteenInterface
{
    public partial class SuppliesForm : Form
    {
        private List<Supply> supplyList = new List<Supply>();

        public SuppliesForm()
        {
            InitializeComponent();
            LoadSupplies();
        }

        private void LoadSupplies()
        {
            supplyList.Clear();
            string query = "SELECT * FROM supplies";
            using (SQLiteConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                SQLiteDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Supply supply = new Supply
                    {
                        SupplyId = reader.GetInt32(0),
                        ItemName = reader.GetString(1),
                        Quantity = reader.GetString(2),
                        Supplier = reader.GetString(3),
                        PurchaseDate = DateTime.Parse(reader.GetString(4)),
                        Cost = reader.GetDecimal(5)
                    };
                    supplyList.Add(supply);
                }
                reader.Close();
                conn.Close();
            }
            listBoxSupplies.DataSource = null;
            listBoxSupplies.DataSource = supplyList;
            listBoxSupplies.DisplayMember = "DisplayInfo";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            SupplyDetailsForm detailsForm = new SupplyDetailsForm();
            if (detailsForm.ShowDialog() == DialogResult.OK)
            {
                Supply newSupply = detailsForm.Supply;
                string query = "INSERT INTO supplies (item_name, quantity, supplier, purchase_date, cost) VALUES (@ItemName, @Quantity, @Supplier, @PurchaseDate, @Cost)";
                using (SQLiteConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    SQLiteCommand cmd = new SQLiteCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ItemName", newSupply.ItemName);
                    cmd.Parameters.AddWithValue("@Quantity", newSupply.Quantity);
                    cmd.Parameters.AddWithValue("@Supplier", newSupply.Supplier);
                    cmd.Parameters.AddWithValue("@PurchaseDate", newSupply.PurchaseDate.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@Cost", newSupply.Cost);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                LoadSupplies();
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listBoxSupplies.SelectedItem != null)
            {
                Supply selectedSupply = (Supply)listBoxSupplies.SelectedItem;
                SupplyDetailsForm detailsForm = new SupplyDetailsForm(selectedSupply);
                if (detailsForm.ShowDialog() == DialogResult.OK)
                {
                    Supply updatedSupply = detailsForm.Supply;
                    string query = "UPDATE supplies SET item_name=@ItemName, quantity=@Quantity, supplier=@Supplier, purchase_date=@PurchaseDate, cost=@Cost WHERE supplie_id=@SupplyId";
                    using (SQLiteConnection conn = DatabaseHelper.GetConnection())
                    {
                        conn.Open();
                        SQLiteCommand cmd = new SQLiteCommand(query, conn);
                        cmd.Parameters.AddWithValue("@ItemName", updatedSupply.ItemName);
                        cmd.Parameters.AddWithValue("@Quantity", updatedSupply.Quantity);
                        cmd.Parameters.AddWithValue("@Supplier", updatedSupply.Supplier);
                        cmd.Parameters.AddWithValue("@PurchaseDate", updatedSupply.PurchaseDate.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@Cost", updatedSupply.Cost);
                        cmd.Parameters.AddWithValue("@SupplyId", updatedSupply.SupplyId);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                    LoadSupplies();
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxSupplies.SelectedItem != null)
            {
                Supply selectedSupply = (Supply)listBoxSupplies.SelectedItem;
                DialogResult result = MessageBox.Show("Ви впевнені, що хочете видалити це постачання?", "Підтвердження видалення", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    string query = "DELETE FROM supplies WHERE supplie_id=@SupplyId";
                    using (SQLiteConnection conn = DatabaseHelper.GetConnection())
                    {
                        conn.Open();
                        SQLiteCommand cmd = new SQLiteCommand(query, conn);
                        cmd.Parameters.AddWithValue("@SupplyId", selectedSupply.SupplyId);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                    LoadSupplies();
                }
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string search = textBoxSearch.Text.ToLower();
            var filteredList = supplyList.FindAll(s => s.ItemName.ToLower().Contains(search) || s.Supplier.ToLower().Contains(search));
            listBoxSupplies.DataSource = null;
            listBoxSupplies.DataSource = filteredList;
            listBoxSupplies.DisplayMember = "DisplayInfo";
        }
    }
}