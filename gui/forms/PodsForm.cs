using Banbridge_Academy_SSD_Coursework.io.database.access;
using Banbridge_Academy_SSD_Coursework.models;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;

namespace Banbridge_Academy_SSD_Coursework.gui.list
{
    public partial class PodsForm : Form
    {
        public PodsForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListPodss_VisibleChanged(object sender, EventArgs e)
        {
            GeneralDBAccess dba = new GeneralDBAccess(App.db);
            List<PodModel> pl = dba.GetPods();

            if (pl.Count > 0)
            {
                PropertyInfo[] properties = pl[0].GetType().GetProperties();

                foreach (PropertyInfo property in properties)
                {
                    dataGridView1.Columns.Add(property.Name, property.Name);
                }

                foreach (PodModel p in pl)
                {
                    int rowIndex = dataGridView1.Rows.Add();
                    DataGridViewRow row = dataGridView1.Rows[rowIndex];

                    foreach (PropertyInfo property in properties)
                    {
                        row.Cells[property.Name].Value = property.GetValue(p, null);
                    }
                }
            }
        }

        private void sidebarMain1_Load(object sender, EventArgs e)
        {

        }
    }
}
