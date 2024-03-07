using System;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace Banbridge_Academy_SSD_Coursework.io.database
{
    internal class Database
    {
        SqlCommand cmd;
        SqlConnection conn;
        SqlDataReader rdr;

        public SqlCommand Cmd
        {
            get => cmd;
            set => cmd = value;
        }

        public SqlConnection Conn
        {
            get => conn;
            set => conn = value;
        }

        public SqlDataReader Rdr
        {
            get => rdr;
            set => rdr = value;
        }

        public bool connect()
        {
            SqlConnectionStringBuilder scStrBuild = new SqlConnectionStringBuilder();
            scStrBuild.DataSource = "(LocalDB)\\mssqllocaldb";

            // Get the project directory
            string projectDirectory = AppDomain.CurrentDomain.BaseDirectory;

            // Combine the project directory with the database file path
            string databaseFilePath = Path.Combine(projectDirectory, "ApplicationDatabase.mdf");
            scStrBuild.AttachDBFilename = databaseFilePath;

            scStrBuild.Encrypt = false;
            scStrBuild.IntegratedSecurity = true;

            conn = new SqlConnection(scStrBuild.ToString());

            try
            {
                conn.Open();
                return true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
