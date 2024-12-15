using System;
using System.Windows.Forms;

namespace CanteenInterface
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DatabaseHelper.InitializeDatabase();
            Application.Run(new MainForm());
        }
    }
}