using Banbridge_Academy_SSD_Coursework.gui.controls;
using Banbridge_Academy_SSD_Coursework.io.database.access;
using Banbridge_Academy_SSD_Coursework.models;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;

namespace Banbridge_Academy_SSD_Coursework.gui.list
{
    public partial class ClientsForm : Form
    {
        public ClientsForm()
        {
            InitializeComponent();
        }

        private void lbl_TitleCard_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChangeMode();
        }

        private void ChangeMode()
        {
            pnl_RegisterClient.Visible = !pnl_RegisterClient.Visible;
            btn_ChangeFormMode.Visible = !btn_ChangeFormMode.Visible;
        }

        private void ListClients_VisibleChanged(object sender, EventArgs e)
        {
            GeneralDBAccess dba = new GeneralDBAccess(App.db);
            List<ClientModel> cl = dba.GetClients();

            if (cl.Count > 0)
            {
                PropertyInfo[] properties = cl[0].GetType().GetProperties();

                foreach (PropertyInfo property in properties)
                {
                    dataGridView1.Columns.Add(property.Name, property.Name);
                }

                foreach (ClientModel c in cl)
                {
                    int rowIndex = dataGridView1.Rows.Add();
                    DataGridViewRow row = dataGridView1.Rows[rowIndex];

                    foreach (PropertyInfo property in properties)
                    {
                        row.Cells[property.Name].Value = property.GetValue(c, null);
                    }
                }
            }
        }



        private void pic_Divider1_Click(object sender, EventArgs e)
        {

        }

        private void btn_BookInFull_Click(object sender, EventArgs e)
        {
            GeneralDBAccess dba = new GeneralDBAccess(App.db);
            ClientModel c = new ClientModel();
            c.ClientForename = txt_ClientForename.Text;
            c.ClientSurname = txt_ClientSurname.Text;
            c.ClientStreetAddress = txt_ClientAddress.Text;
            c.ClientCity = txt_ClientCity.Text;
            c.ClientPostcode = txt_ClientPostcode.Text;
            c.ClientPhoneNumber = txt_ClientPhoneNumber.Text;
            c.ClientEmail = txt_ClientEmail.Text;
            dba.AddClient(c);
            MessageBox.Show(
                $"Registered new client \"{c.ClientForename + c.ClientSurname}\" successfully.",
                "Registration Success"
                );
            ChangeMode();
        }

        private void btn_CancelBooking_Click(object sender, EventArgs e)
        {
            ChangeMode();
        }
    }
}
