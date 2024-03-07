using System;

namespace Banbridge_Academy_SSD_Coursework.gui.list
{
    partial class BookingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            lbl_TitleCard = new System.Windows.Forms.Label();
            dgv_BookingsView = new System.Windows.Forms.DataGridView();
            btn_ActivateCreateMode = new System.Windows.Forms.Button();
            lbl_SubTitleCard = new System.Windows.Forms.Label();
            navBarNew1 = new controls.NavBarNew();
            pic_Divider1 = new System.Windows.Forms.PictureBox();
            cmb_EndDateSelect = new System.Windows.Forms.ComboBox();
            dtp_StartDate = new System.Windows.Forms.DateTimePicker();
            btn_BookHold = new System.Windows.Forms.Button();
            btn_BookInFull = new System.Windows.Forms.Button();
            btn_CancelBooking = new System.Windows.Forms.Button();
            button5 = new System.Windows.Forms.Button();
            cmb_CustomerSelection = new System.Windows.Forms.ComboBox();
            cmb_ClientFilterSelect = new System.Windows.Forms.ComboBox();
            dgv_BookingGuests = new System.Windows.Forms.DataGridView();
            Forename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Pod = new System.Windows.Forms.DataGridViewComboBoxColumn();
            Spaces = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Remove = new System.Windows.Forms.DataGridViewButtonColumn();
            pnl_BookingFilterFields = new System.Windows.Forms.Panel();
            pnl_CreateBookingFields = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)dgv_BookingsView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_Divider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_BookingGuests).BeginInit();
            pnl_BookingFilterFields.SuspendLayout();
            pnl_CreateBookingFields.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_TitleCard
            // 
            lbl_TitleCard.AutoSize = true;
            lbl_TitleCard.Font = new System.Drawing.Font("Segoe UI Black", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_TitleCard.ForeColor = System.Drawing.Color.Chocolate;
            lbl_TitleCard.Location = new System.Drawing.Point(-2, -3);
            lbl_TitleCard.Name = "lbl_TitleCard";
            lbl_TitleCard.Size = new System.Drawing.Size(396, 89);
            lbl_TitleCard.TabIndex = 17;
            lbl_TitleCard.Text = "BOOKINGS";
            // 
            // dgv_BookingsView
            // 
            dgv_BookingsView.BackgroundColor = System.Drawing.Color.Bisque;
            dgv_BookingsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_BookingsView.ColumnHeadersVisible = false;
            dgv_BookingsView.Location = new System.Drawing.Point(389, 12);
            dgv_BookingsView.Name = "dgv_BookingsView";
            dgv_BookingsView.ReadOnly = true;
            dgv_BookingsView.RowTemplate.Height = 25;
            dgv_BookingsView.ShowEditingIcon = false;
            dgv_BookingsView.Size = new System.Drawing.Size(399, 317);
            dgv_BookingsView.TabIndex = 19;
            dgv_BookingsView.CellClick += dgv_BookingGrid_CellClick;
            // 
            // btn_ActivateCreateMode
            // 
            btn_ActivateCreateMode.BackColor = System.Drawing.Color.White;
            btn_ActivateCreateMode.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_ActivateCreateMode.ForeColor = System.Drawing.Color.DarkOrange;
            btn_ActivateCreateMode.Location = new System.Drawing.Point(0, 41);
            btn_ActivateCreateMode.Name = "btn_ActivateCreateMode";
            btn_ActivateCreateMode.Size = new System.Drawing.Size(357, 40);
            btn_ActivateCreateMode.TabIndex = 20;
            btn_ActivateCreateMode.Text = "ADD ➕";
            btn_ActivateCreateMode.UseVisualStyleBackColor = false;
            btn_ActivateCreateMode.Click += btn_ActivateCreateModeClick;
            // 
            // lbl_SubTitleCard
            // 
            lbl_SubTitleCard.AutoSize = true;
            lbl_SubTitleCard.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_SubTitleCard.ForeColor = System.Drawing.Color.Chocolate;
            lbl_SubTitleCard.Location = new System.Drawing.Point(12, 71);
            lbl_SubTitleCard.Name = "lbl_SubTitleCard";
            lbl_SubTitleCard.Size = new System.Drawing.Size(256, 32);
            lbl_SubTitleCard.TabIndex = 21;
            lbl_SubTitleCard.Text = "VIEWING BOOKINGS";
            // 
            // navBarNew1
            // 
            navBarNew1.BackColor = System.Drawing.Color.Chocolate;
            navBarNew1.Dock = System.Windows.Forms.DockStyle.Bottom;
            navBarNew1.Location = new System.Drawing.Point(0, 351);
            navBarNew1.Name = "navBarNew1";
            navBarNew1.Size = new System.Drawing.Size(800, 63);
            navBarNew1.TabIndex = 23;
            // 
            // pic_Divider1
            // 
            pic_Divider1.BackColor = System.Drawing.Color.Chocolate;
            pic_Divider1.Location = new System.Drawing.Point(389, 335);
            pic_Divider1.Name = "pic_Divider1";
            pic_Divider1.Size = new System.Drawing.Size(399, 10);
            pic_Divider1.TabIndex = 29;
            pic_Divider1.TabStop = false;
            // 
            // cmb_EndDateSelect
            // 
            cmb_EndDateSelect.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            cmb_EndDateSelect.FormattingEnabled = true;
            cmb_EndDateSelect.Location = new System.Drawing.Point(0, 83);
            cmb_EndDateSelect.Name = "cmb_EndDateSelect";
            cmb_EndDateSelect.Size = new System.Drawing.Size(357, 36);
            cmb_EndDateSelect.TabIndex = 32;
            cmb_EndDateSelect.SelectedIndexChanged += cmb_EndDateSelect_SelectedIndexChanged;
            // 
            // dtp_StartDate
            // 
            dtp_StartDate.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dtp_StartDate.Location = new System.Drawing.Point(0, 42);
            dtp_StartDate.Name = "dtp_StartDate";
            dtp_StartDate.Size = new System.Drawing.Size(357, 35);
            dtp_StartDate.TabIndex = 31;
            dtp_StartDate.ValueChanged += dtp_StartDate_ValueChanged;
            // 
            // btn_BookHold
            // 
            btn_BookHold.BackColor = System.Drawing.Color.White;
            btn_BookHold.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_BookHold.ForeColor = System.Drawing.Color.DarkOrange;
            btn_BookHold.Location = new System.Drawing.Point(152, 125);
            btn_BookHold.Name = "btn_BookHold";
            btn_BookHold.Size = new System.Drawing.Size(144, 40);
            btn_BookHold.TabIndex = 33;
            btn_BookHold.Text = "HOLD ⏸";
            btn_BookHold.UseVisualStyleBackColor = false;
            btn_BookHold.Click += btn_BookHoldClick;
            // 
            // btn_BookInFull
            // 
            btn_BookInFull.BackColor = System.Drawing.Color.White;
            btn_BookInFull.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_BookInFull.ForeColor = System.Drawing.Color.LightSeaGreen;
            btn_BookInFull.Location = new System.Drawing.Point(0, 125);
            btn_BookInFull.Name = "btn_BookInFull";
            btn_BookInFull.Size = new System.Drawing.Size(146, 40);
            btn_BookInFull.TabIndex = 34;
            btn_BookInFull.Text = "BOOK ✔";
            btn_BookInFull.UseVisualStyleBackColor = false;
            btn_BookInFull.Click += btn_BookFullClick;
            // 
            // btn_CancelBooking
            // 
            btn_CancelBooking.BackColor = System.Drawing.Color.White;
            btn_CancelBooking.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_CancelBooking.ForeColor = System.Drawing.Color.OrangeRed;
            btn_CancelBooking.Location = new System.Drawing.Point(302, 125);
            btn_CancelBooking.Name = "btn_CancelBooking";
            btn_CancelBooking.Size = new System.Drawing.Size(55, 40);
            btn_CancelBooking.TabIndex = 35;
            btn_CancelBooking.Text = "X";
            btn_CancelBooking.UseVisualStyleBackColor = false;
            btn_CancelBooking.Click += btn_CancelBookingClick;
            // 
            // button5
            // 
            button5.BackColor = System.Drawing.Color.White;
            button5.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button5.ForeColor = System.Drawing.Color.DarkOrange;
            button5.Location = new System.Drawing.Point(267, 73);
            button5.Name = "button5";
            button5.Size = new System.Drawing.Size(105, 30);
            button5.TabIndex = 36;
            button5.Text = "REFRESH";
            button5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // cmb_CustomerSelection
            // 
            cmb_CustomerSelection.BackColor = System.Drawing.Color.White;
            cmb_CustomerSelection.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cmb_CustomerSelection.ForeColor = System.Drawing.Color.Black;
            cmb_CustomerSelection.FormattingEnabled = true;
            cmb_CustomerSelection.Location = new System.Drawing.Point(0, 0);
            cmb_CustomerSelection.Name = "cmb_CustomerSelection";
            cmb_CustomerSelection.Size = new System.Drawing.Size(357, 36);
            cmb_CustomerSelection.TabIndex = 30;
            cmb_CustomerSelection.Text = "No Customer Selected";
            // 
            // cmb_ClientFilterSelect
            // 
            cmb_ClientFilterSelect.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cmb_ClientFilterSelect.FormattingEnabled = true;
            cmb_ClientFilterSelect.Location = new System.Drawing.Point(0, 2);
            cmb_ClientFilterSelect.Name = "cmb_ClientFilterSelect";
            cmb_ClientFilterSelect.Size = new System.Drawing.Size(357, 36);
            cmb_ClientFilterSelect.TabIndex = 22;
            cmb_ClientFilterSelect.Text = "Filter By Client 🔍";
            cmb_ClientFilterSelect.SelectedIndexChanged += cmb_ClientFilterSelect_SelectedIndexChanged;
            // 
            // dgv_BookingGuests
            // 
            dgv_BookingGuests.BackgroundColor = System.Drawing.Color.Bisque;
            dgv_BookingGuests.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgv_BookingGuests.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_BookingGuests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_BookingGuests.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Forename, Surname, Pod, Spaces, Remove });
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dgv_BookingGuests.DefaultCellStyle = dataGridViewCellStyle2;
            dgv_BookingGuests.Location = new System.Drawing.Point(389, 12);
            dgv_BookingGuests.Name = "dgv_BookingGuests";
            dgv_BookingGuests.RowHeadersVisible = false;
            dgv_BookingGuests.RowHeadersWidth = 82;
            dgv_BookingGuests.RowTemplate.Height = 41;
            dgv_BookingGuests.ShowEditingIcon = false;
            dgv_BookingGuests.Size = new System.Drawing.Size(399, 317);
            dgv_BookingGuests.TabIndex = 37;
            dgv_BookingGuests.Visible = false;
            dgv_BookingGuests.CellClick += dgv_BookingGuests_CellClick;
            // 
            // Forename
            // 
            Forename.HeaderText = "Forename";
            Forename.Name = "Forename";
            // 
            // Surname
            // 
            Surname.HeaderText = "Surname";
            Surname.Name = "Surname";
            // 
            // Pod
            // 
            Pod.HeaderText = "Pod";
            Pod.Name = "Pod";
            Pod.Width = 80;
            // 
            // Spaces
            // 
            Spaces.HeaderText = "Spaces";
            Spaces.Name = "Spaces";
            Spaces.ReadOnly = true;
            Spaces.Width = 80;
            // 
            // Remove
            // 
            Remove.HeaderText = "X";
            Remove.Name = "Remove";
            Remove.Width = 35;
            // 
            // pnl_BookingFilterFields
            // 
            pnl_BookingFilterFields.Controls.Add(btn_ActivateCreateMode);
            pnl_BookingFilterFields.Controls.Add(cmb_ClientFilterSelect);
            pnl_BookingFilterFields.Location = new System.Drawing.Point(15, 106);
            pnl_BookingFilterFields.Name = "pnl_BookingFilterFields";
            pnl_BookingFilterFields.Size = new System.Drawing.Size(357, 223);
            pnl_BookingFilterFields.TabIndex = 38;
            // 
            // pnl_CreateBookingFields
            // 
            pnl_CreateBookingFields.Controls.Add(btn_CancelBooking);
            pnl_CreateBookingFields.Controls.Add(dtp_StartDate);
            pnl_CreateBookingFields.Controls.Add(cmb_EndDateSelect);
            pnl_CreateBookingFields.Controls.Add(cmb_CustomerSelection);
            pnl_CreateBookingFields.Controls.Add(btn_BookHold);
            pnl_CreateBookingFields.Controls.Add(btn_BookInFull);
            pnl_CreateBookingFields.Location = new System.Drawing.Point(15, 106);
            pnl_CreateBookingFields.Name = "pnl_CreateBookingFields";
            pnl_CreateBookingFields.Size = new System.Drawing.Size(357, 223);
            pnl_CreateBookingFields.TabIndex = 39;
            pnl_CreateBookingFields.Visible = false;
            // 
            // Bookings
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.NavajoWhite;
            ClientSize = new System.Drawing.Size(800, 414);
            Controls.Add(pnl_BookingFilterFields);
            Controls.Add(pnl_CreateBookingFields);
            Controls.Add(dgv_BookingGuests);
            Controls.Add(button5);
            Controls.Add(pic_Divider1);
            Controls.Add(navBarNew1);
            Controls.Add(lbl_SubTitleCard);
            Controls.Add(dgv_BookingsView);
            Controls.Add(lbl_TitleCard);
            Name = "Bookings";
            Text = "Bookings";
            ((System.ComponentModel.ISupportInitialize)dgv_BookingsView).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_Divider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_BookingGuests).EndInit();
            pnl_BookingFilterFields.ResumeLayout(false);
            pnl_CreateBookingFields.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label lbl_TitleCard;
        private System.Windows.Forms.DataGridView dgv_BookingsView;
        private System.Windows.Forms.Button btn_ActivateCreateMode;
        private System.Windows.Forms.Label lbl_SubTitleCard;
        private controls.NavBarNew navBarNew1;
        private System.Windows.Forms.PictureBox pic_Divider1;
        private System.Windows.Forms.ComboBox cmb_EndDateSelect;
        private System.Windows.Forms.DateTimePicker dtp_StartDate;
        private System.Windows.Forms.Button btn_BookHold;
        private System.Windows.Forms.Button btn_BookInFull;
        private System.Windows.Forms.Button btn_CancelBooking;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox cmb_CustomerSelection;
        private System.Windows.Forms.ComboBox cmb_ClientFilterSelect;
        private System.Windows.Forms.DataGridView dgv_BookingGuests;
        private System.Windows.Forms.Panel pnl_BookingFilterFields;
        private System.Windows.Forms.Panel pnl_CreateBookingFields;
        private System.Windows.Forms.DataGridViewTextBoxColumn Forename;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.DataGridViewComboBoxColumn Pod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Spaces;
        private System.Windows.Forms.DataGridViewButtonColumn Remove;
    }
}