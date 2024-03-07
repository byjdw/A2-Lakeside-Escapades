using Banbridge_Academy_SSD_Coursework.io.database;
using System;
using System.Windows.Forms;

namespace Banbridge_Academy_SSD_Coursework
{
    internal static class App
    {
        public static Database db;
        public static OverviewForm origin;

        [STAThread]
        static void Main()
        {
            db = new Database();

            if (!db.connect())
            {
                MessageBox.Show("Failed to connect to database; please correct the error on previous screen and try again.", "ERROR");
            }

            origin = new OverviewForm();
            Application.EnableVisualStyles();
            Application.Run(origin);
        }
    }
}