using System;
using System.Data.SQLite;
using System.IO;

namespace CanteenInterface
{
    public static class DatabaseHelper
    {
        private static string dbFile = "canteen.db";
        private static string connectionString = $"Data Source={dbFile};Version=3;";

        public static SQLiteConnection GetConnection()
        {
            return new SQLiteConnection(connectionString);
        }

        public static void InitializeDatabase()
        {
            if (!File.Exists(dbFile))
            {
                SQLiteConnection.CreateFile(dbFile);
                using (SQLiteConnection conn = GetConnection())
                {
                    conn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(conn))
                    {
                        cmd.CommandText = @"
                            CREATE TABLE IF NOT EXISTS cafeteria_staff (
                                staff_id INTEGER PRIMARY KEY AUTOINCREMENT,
                                first_name TEXT NOT NULL,
                                last_name TEXT NOT NULL,
                                role TEXT NOT NULL,
                                phone TEXT,
                                email TEXT,
                                hire_date DATE NOT NULL
                            );
                            CREATE TABLE IF NOT EXISTS dishes (
                                dish_id INTEGER PRIMARY KEY AUTOINCREMENT,
                                name TEXT NOT NULL,
                                type TEXT NOT NULL,
                                ingredients TEXT NOT NULL,
                                calories INTEGER NOT NULL
                            );
                            CREATE TABLE IF NOT EXISTS feedback (
                                feedback_id INTEGER PRIMARY KEY AUTOINCREMENT,
                                submitted_by TEXT NOT NULL,
                                content TEXT NOT NULL,
                                submission_date DATE NOT NULL,
                                response TEXT
                            );
                            CREATE TABLE IF NOT EXISTS meal_consumption (
                                consumption_id INTEGER PRIMARY KEY AUTOINCREMENT,
                                child_id INTEGER NOT NULL,
                                date DATE NOT NULL,
                                meal_time TEXT NOT NULL,
                                dish_id INTEGER NOT NULL,
                                portion_size TEXT NOT NULL,
                                remarks TEXT,
                                FOREIGN KEY(dish_id) REFERENCES dishes(dish_id)
                            );
                            CREATE TABLE IF NOT EXISTS menu (
                                menu_id INTEGER PRIMARY KEY AUTOINCREMENT,
                                date DATE NOT NULL,
                                group_id INTEGER NOT NULL,
                                dish_id INTEGER NOT NULL,
                                meal_time TEXT NOT NULL,
                                FOREIGN KEY(dish_id) REFERENCES dishes(dish_id)
                            );
                            CREATE TABLE IF NOT EXISTS supplies (
                                supplie_id INTEGER PRIMARY KEY AUTOINCREMENT,
                                item_name TEXT NOT NULL,
                                quantity TEXT NOT NULL,
                                supplier TEXT NOT NULL,
                                purchase_date DATE NOT NULL,
                                cost DECIMAL(10,2) NOT NULL
                            );
                        ";
                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                }
            }
        }
    }
}