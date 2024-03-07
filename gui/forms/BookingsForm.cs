using Banbridge_Academy_SSD_Coursework.io.database.access;
using Banbridge_Academy_SSD_Coursework.models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace Banbridge_Academy_SSD_Coursework.gui.list
{
    public partial class BookingsForm : Form
    {
        public BookingsForm()
        {
            // Initialise Winform Components.
            InitializeComponent();
            // Render available information from database.
            DisplayBookings();
            PopulateClientList();
            PopulateEndDateComboBox();
        }

        private void PopulatePodList()
        {
            dgv_BookingGuests.Rows.Clear();
            GeneralDBAccess dba = new GeneralDBAccess(App.db);
            List<string> pl = new List<string>();

            foreach (PodModel p in dba.GetPods())
            {
                pl.Add($"{p.PodId} - {p.PodType}");
            }

            ((DataGridViewComboBoxColumn) dgv_BookingGuests.Columns["Pod"]).DataSource = pl;
        }

        private void PopulateClientList()
        {
            List<ClientModel> cl = new GeneralDBAccess(App.db).GetClients();

            foreach (ClientModel c in cl)
            {
                string client = $"{c.ClientId}/{c.ClientPostcode} - {c.ClientForename} {c.ClientSurname}";
                cmb_ClientFilterSelect.Items.Add(client);
                cmb_CustomerSelection.Items.Add(client);
            }
        }

        private void ChangeMode(int BookingId)
        {
            if (!btn_ActivateCreateMode.Visible) return;

            pnl_BookingFilterFields.Visible = false;
            pnl_CreateBookingFields.Visible =
            dgv_BookingGuests.Visible = true;
            PopulatePodList();
            lbl_SubTitleCard.Text = "EDITING A BOOKING";

            btn_BookInFull.Text = "CONFIRM ✔️";
            btn_BookHold.Text = "COMMIT 💾";

            RestoreBookingInformation(BookingId);
        }

        private void RestoreBookingInformation(int bookingId)
        {
            GeneralDBAccess dba = new GeneralDBAccess(App.db);
            BookingModel booking = dba.GetBookingById(bookingId);
            ClientModel client = dba.GetClientById(booking.ClientId);
            
            cmb_CustomerSelection.SelectedItem = $"{booking.ClientId}/{client.ClientPostcode} - {client.ClientForename} {client.ClientSurname}";
            dtp_StartDate.Value = booking.StartDate;
            cmb_EndDateSelect.SelectedItem = booking.StartDate.AddDays(booking.Length - 1).ToString("dd MMMM yyyy", CultureInfo.InvariantCulture);

            List<GuestModel> sgl = dba.GetGuests().Where(g => g.BookingId == booking.BookingId).ToList();
            dgv_BookingGuests.Rows.Clear();

            foreach (GuestModel guest in sgl)
            {
                int rowIndex = dgv_BookingGuests.Rows.Add();
                dgv_BookingGuests.Rows[rowIndex].Cells["Forename"].Value = guest.Forename;
                dgv_BookingGuests.Rows[rowIndex].Cells["Surname"].Value = guest.Surname;

                PodModel pod = dba.GetPodById(guest.PodId);

                if (pod != null)
                {
                    dgv_BookingGuests.Rows[rowIndex].Cells["Pod"].Value = $"{pod.PodId} - {pod.PodType}";
                }
                else
                {
                    dgv_BookingGuests.Rows[rowIndex].Cells["Pod"].Value = "Pod not found :(";
                }
            }
        }

        private void ChangeMode()
        {
            switch (btn_ActivateCreateMode.Visible)
            {
                case true:
                    pnl_BookingFilterFields.Visible = false;
                    pnl_CreateBookingFields.Visible =
                    dgv_BookingGuests.Visible = true;
                    PopulatePodList();
                    lbl_SubTitleCard.Text = "ADDING A BOOKING";
                    break;
                case false:
                    pnl_BookingFilterFields.Visible = true;
                    pnl_CreateBookingFields.Visible =
                    dgv_BookingGuests.Visible = false;
                    lbl_SubTitleCard.Text = "VIEWING BOOKINGS";
                    break;
            }
        }

        private void btn_ActivateCreateModeClick(object sender, EventArgs e) => ChangeMode();

        private void btn_CancelBookingClick(object sender, EventArgs e) => ChangeMode();

        private void DisplayBookings()
        {
            GeneralDBAccess dba = new GeneralDBAccess(App.db);
            List<BookingModel> bl = dba.GetBookings();
            RefreshBookingGrid(bl);
        }

        private void DisplayBookingsByClientId(int clientId)
        {
            GeneralDBAccess dba = new GeneralDBAccess(App.db);
            List<BookingModel> bl = dba.GetBookingsFromClientId(clientId);
            RefreshBookingGrid(bl);
        }

        private void RefreshBookingGrid(List<BookingModel> bl)
        {
            dgv_BookingsView.Rows.Clear();
            dgv_BookingsView.Columns.Clear();

            if (bl.Count > 0)
            {
                PropertyInfo[] properties = bl[0].GetType().GetProperties();

                foreach (PropertyInfo property in properties) dgv_BookingsView.Columns.Add(property.Name, property.Name);
                

                dgv_BookingsView.Columns.Add("Delete", "Delete");
                dgv_BookingsView.Columns.Add("Edit", "Edit");

                foreach (BookingModel b in bl)
                {
                    DataGridViewRow row = dgv_BookingsView.Rows[dgv_BookingsView.Rows.Add()];

                    foreach (PropertyInfo property in properties) row.Cells[property.Name].Value = property.GetValue(b, null);
                    
                    DataGridViewButtonCell deleteButtonCell = new DataGridViewButtonCell();
                    deleteButtonCell.Value = "X";
                    deleteButtonCell.Tag = b.BookingId;
                    row.Cells["Delete"] = deleteButtonCell;

                    DataGridViewButtonCell editButtonCell = new DataGridViewButtonCell();
                    editButtonCell.Value = "✏️";
                    editButtonCell.Tag = b.BookingId;
                    row.Cells["Edit"] = editButtonCell;
                }
            }
        }

        private void dgv_BookingGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                GeneralDBAccess dba = new GeneralDBAccess(App.db);
                if (e.ColumnIndex == dgv_BookingsView.Columns["Delete"].Index)
                {
                    int bookingId = (int)dgv_BookingsView.Rows[e.RowIndex].Cells["Delete"].Tag;

                    dba.RemoveBooking(new BookingModel() { BookingId = bookingId });
                    Refresh();

                }
                else if (e.ColumnIndex == dgv_BookingsView.Columns["Edit"].Index)
                {
                    int bookingId = (int)dgv_BookingsView.Rows[e.RowIndex].Cells["Edit"].Tag;

                    ChangeMode(bookingId);
                }
            }
        }

        private void cmb_ClientFilterSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedClient = cmb_ClientFilterSelect.SelectedItem.ToString();
            string clientIdString = selectedClient.Split('/')[0];
            DisplayBookingsByClientId(int.Parse(clientIdString));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!pnl_BookingFilterFields.Visible) ChangeMode();
            Refresh();
        }

        private void btn_BookFullClick(object sender, EventArgs e) => SaveBooking(false);

        private void btn_BookHoldClick(object sender, EventArgs e) => SaveBooking(true);

        private void dgv_BookingGuests_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle button clicks
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dgv_BookingGuests.Columns["Remove"].Index)
                {
                    dgv_BookingGuests.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        // ---------
        // THE FOLLOWING CODE IS IN RELATION TO BOOKING DATE CALCULATION  
        // AND EVENT HANDLING :)
        // ---------

        private void SaveBooking(bool isProvisional)
        {
            // Get the booking data from the form controls
            int clientId = ExtractClientIdFromComboBox(); // Implement this method to get the selected client ID
            DateTime startDate = dtp_StartDate.Value;
            int length = CalculateBookingLength(); // Implement this method to calculate the booking length
            decimal cost = CalculateBookingCost(); // Implement this method to calculate the booking cost
            decimal balance = CalculateBalance(cost); // Implement this method to calculate the balance

            // Create a new Booking object
            BookingModel booking = new BookingModel()
            {
                ClientId = clientId,
                StartDate = startDate,
                Length = length,
                Cost = cost,
                Balance = balance,
                Provisional = isProvisional,
                BookingDate = new DateTime()
            };

            GeneralDBAccess dba = new GeneralDBAccess(App.db);
            int bookingId = dba.AddBooking(booking);

            foreach (DataGridViewRow row in dgv_BookingGuests.Rows)
            {
                if (row.IsNewRow || row.Cells["Forename"].Value == null || row.Cells["Forename"].Value.ToString() == "")
                {
                    continue;
                }

                GuestModel guest = new GuestModel()
                {
                    BookingId = bookingId,
                    Forename = row.Cells["Forename"].Value.ToString(),
                    Surname = row.Cells["Surname"].Value?.ToString(), // Handle possible null value for Surname
                    PodId = Convert.ToInt32(row.Cells["Pod"].Value?.ToString().Split(" ")[0] ?? "0") // Handle possible null value for PodId
                };

                dba.AddGuest(guest);
            }


            // Show a message based on the booking status
            if (isProvisional)
            {
                MessageBox.Show($"Provisional booking with ID {booking.BookingId} saved successfully.");
            }
            else
            {
                MessageBox.Show($"Full booking with ID {booking.BookingId} saved successfully.");
            }
        }

        private int ExtractClientIdFromComboBox()
        {
            string selectedClient = cmb_CustomerSelection.SelectedItem.ToString();
            string clientIdString = selectedClient.Split('/')[0];
            return int.Parse(clientIdString);
        }

        private int CalculateBookingLength()
        {
            return (int)(DateTime.ParseExact(cmb_EndDateSelect.SelectedItem.ToString(), "dd MMMM yyyy", CultureInfo.InvariantCulture) - dtp_StartDate.Value).TotalDays + 1;
        }

        private decimal CalculateBookingCost()
        {
            return 100.00M;
        }

        private decimal CalculateBalance(decimal totalCost)
        {
            return totalCost;
        }

        private void dtp_StartDate_ValueChanged(object sender, EventArgs e)
        {
            // Check if the selected start date is within the restricted period (20 Dec - 20 Jan)
            if (IsWithinRestrictedPeriod(dtp_StartDate.Value))
            {
                MessageBox.Show("Booking dates must be outside of 20 Dec and 20 Jan.");
                dtp_StartDate.Value = DateTime.Today; // Set a default start date, adjust as needed
            }

            // Update the available end dates when the start date changes
            PopulateEndDateComboBox();
        }

        private void PopulateEndDateComboBox()
        {
            // Clear existing items
            cmb_EndDateSelect.Items.Clear();

            // Get the selected start date
            DateTime startDate = dtp_StartDate.Value;

            // Calculate the maximum end date based on the selected start date
            DateTime maxEndDate = startDate.AddDays(14); // Assuming a maximum duration of 14 days

            // Populate the ComboBox with available end dates
            foreach (DateTime endDate in GetValidEndDates(startDate, maxEndDate))
            {
                cmb_EndDateSelect.Items.Add(endDate.ToString("dd MMMM yyyy", CultureInfo.InvariantCulture));
            }

            // Set default selection
            if (cmb_EndDateSelect.Items.Count > 0)
            {
                cmb_EndDateSelect.SelectedIndex = 0;
            }
        }

        private bool IsWithinRestrictedPeriod(DateTime date)
        {
            DateTime startRestricted = new DateTime(date.Year, 12, 20);
            DateTime endRestricted = new DateTime(date.Year + 1, 1, 20);

            if (endRestricted.Month == 1 && endRestricted.Year != date.Year + 1)
            {
                // If the end restricted date crosses into the next year, adjust the endRestricted year
                endRestricted = endRestricted.AddYears(-1);
            }

            return date >= startRestricted && date <= endRestricted;
        }


        private IEnumerable<DateTime> GetValidEndDates(DateTime startDate, DateTime maxEndDate)
        {
            List<DateTime> validEndDates = new List<DateTime>();

            // Iterate through possible end dates
            for (DateTime currentDate = startDate; currentDate <= maxEndDate; currentDate = currentDate.AddDays(1))
            {
                if (!IsWithinRestrictedPeriod(currentDate) && IsValidDuration(startDate, currentDate))
                {
                    validEndDates.Add(currentDate);
                }
            }

            return validEndDates;
        }

        private bool IsValidDuration(DateTime startDate, DateTime endDate)
        {
            // Check if the selected duration is valid (3 days, 5 days, 7 days, or 14 days)
            int selectedDuration = (int)(endDate - startDate).TotalDays + 1; // Include the end date
            return selectedDuration == 3 || selectedDuration == 5 || selectedDuration == 7 || selectedDuration == 14;
        }

        private void cmb_EndDateSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Handle the selected end date change if needed
            DateTime selectedEndDate = DateTime.ParseExact(cmb_EndDateSelect.SelectedItem.ToString(), "dd MMMM yyyy", CultureInfo.InvariantCulture);

            // Check if the selected end date is within the restricted period (20 Dec - 20 Jan)
            if (IsWithinRestrictedPeriod(selectedEndDate))
            {
                MessageBox.Show("Booking dates must be outside of 20 Dec and 20 Jan.");
                // You may choose to set a default duration or take other corrective actions
                PopulateEndDateComboBox(); // Refresh the ComboBox after the message box is displayed
            }
        }
    }
}
