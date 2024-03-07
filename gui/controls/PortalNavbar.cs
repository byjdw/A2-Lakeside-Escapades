using Banbridge_Academy_SSD_Coursework.gui.list;
using Banbridge_Academy_SSD_Coursework.gui.modify;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Banbridge_Academy_SSD_Coursework.gui.controls
{
    public partial class NavBarNew : UserControl
    {
        Form parent;


        public NavBarNew()
        {
            InitializeComponent();
        }

        private void HighlightActiveForm()
        {
            foreach (Button b in tableLayoutPanel1.Controls.OfType<Button>())
            {
                if (b.Text == parent.Text.ToUpper())
                {
                    b.ForeColor = Color.Orange;
                }
            }
        }

        private void RemovePreviousScreen()
        {
            if (parent.Text.ToUpper() == "OVERVIEW")
            {
                parent.Hide();
            }
            else
            {
                parent.Close();
            }
        }

        private void btn_NavBar1_Click(object sender, EventArgs e)
        {
            if (btn_NavBar1.ForeColor == Color.Orange) return;
            else
            {
                App.origin.Show();
                RemovePreviousScreen();
            }
        }

        private void btn_NavBar2_Click(object sender, EventArgs e)
        {
            if (btn_NavBar2.ForeColor == Color.Orange) return;
            else
            {
                new BookingsForm().Show();
                RemovePreviousScreen();
            }
        }

        private void btn_NavBar3_Click(object sender, EventArgs e)
        {
            if (btn_NavBar3.ForeColor == Color.Orange) return;
            else
            {
                new CoursesForm().Show();
                RemovePreviousScreen();
            }
        }

        private void btn_NavBar4_Click(object sender, EventArgs e)
        {
            if (btn_NavBar4.ForeColor == Color.Orange) return;
            else
            {
                new PodsForm().Show();
                RemovePreviousScreen();
            }
        }

        private void btn_NavBar5_Click(object sender, EventArgs e)
        {
            if (btn_NavBar5.ForeColor == Color.Orange) return;
            else
            {
                new ClientsForm().Show();
                RemovePreviousScreen();
            }
        }

        private void NavBarNew_VisibleChanged(object sender, EventArgs e)
        {
            parent = this.FindForm();
            HighlightActiveForm();
        }
    }
}
