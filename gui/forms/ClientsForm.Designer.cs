namespace Banbridge_Academy_SSD_Coursework.gui.list
{
    partial class ClientsForm
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
            lbl_SubTitleCard = new System.Windows.Forms.Label();
            btn_ChangeFormMode = new System.Windows.Forms.Button();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            lbl_TitleCard = new System.Windows.Forms.Label();
            navBarNew1 = new controls.NavBarNew();
            pic_Divider1 = new System.Windows.Forms.PictureBox();
            txt_ClientAddress = new System.Windows.Forms.TextBox();
            txt_ClientPostcode = new System.Windows.Forms.TextBox();
            txt_ClientPhoneNumber = new System.Windows.Forms.TextBox();
            txt_ClientEmail = new System.Windows.Forms.TextBox();
            txt_ClientSurname = new System.Windows.Forms.TextBox();
            txt_ClientForename = new System.Windows.Forms.TextBox();
            pnl_RegisterClient = new System.Windows.Forms.Panel();
            btn_CancelBooking = new System.Windows.Forms.Button();
            btn_BookInFull = new System.Windows.Forms.Button();
            txt_ClientCity = new System.Windows.Forms.TextBox();
            Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            Forename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            StreetAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Postcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            EmailAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_Divider1).BeginInit();
            pnl_RegisterClient.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_SubTitleCard
            // 
            lbl_SubTitleCard.AutoSize = true;
            lbl_SubTitleCard.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_SubTitleCard.ForeColor = System.Drawing.Color.Chocolate;
            lbl_SubTitleCard.Location = new System.Drawing.Point(12, 71);
            lbl_SubTitleCard.Name = "lbl_SubTitleCard";
            lbl_SubTitleCard.Size = new System.Drawing.Size(225, 32);
            lbl_SubTitleCard.TabIndex = 26;
            lbl_SubTitleCard.Text = "VIEWING CLIENTS";
            // 
            // btn_ChangeFormMode
            // 
            btn_ChangeFormMode.BackColor = System.Drawing.Color.White;
            btn_ChangeFormMode.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_ChangeFormMode.ForeColor = System.Drawing.Color.DarkOrange;
            btn_ChangeFormMode.Location = new System.Drawing.Point(12, 104);
            btn_ChangeFormMode.Name = "btn_ChangeFormMode";
            btn_ChangeFormMode.Size = new System.Drawing.Size(300, 40);
            btn_ChangeFormMode.TabIndex = 25;
            btn_ChangeFormMode.Text = "ADD ➕";
            btn_ChangeFormMode.UseVisualStyleBackColor = false;
            btn_ChangeFormMode.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = System.Drawing.Color.Bisque;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Delete, Edit, Forename, Surname, StreetAddress, Postcode, EmailAddress, PhoneNumber });
            dataGridView1.Location = new System.Drawing.Point(328, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new System.Drawing.Size(460, 317);
            dataGridView1.TabIndex = 24;
            // 
            // lbl_TitleCard
            // 
            lbl_TitleCard.AutoSize = true;
            lbl_TitleCard.Font = new System.Drawing.Font("Segoe UI Black", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_TitleCard.ForeColor = System.Drawing.Color.Chocolate;
            lbl_TitleCard.Location = new System.Drawing.Point(-2, -3);
            lbl_TitleCard.Name = "lbl_TitleCard";
            lbl_TitleCard.Size = new System.Drawing.Size(311, 89);
            lbl_TitleCard.TabIndex = 22;
            lbl_TitleCard.Text = "CLIENTS";
            lbl_TitleCard.Click += lbl_TitleCard_Click;
            // 
            // navBarNew1
            // 
            navBarNew1.BackColor = System.Drawing.Color.Chocolate;
            navBarNew1.Dock = System.Windows.Forms.DockStyle.Bottom;
            navBarNew1.Location = new System.Drawing.Point(0, 351);
            navBarNew1.Name = "navBarNew1";
            navBarNew1.Size = new System.Drawing.Size(800, 63);
            navBarNew1.TabIndex = 27;
            // 
            // pic_Divider1
            // 
            pic_Divider1.BackColor = System.Drawing.Color.Chocolate;
            pic_Divider1.Location = new System.Drawing.Point(328, 335);
            pic_Divider1.Name = "pic_Divider1";
            pic_Divider1.Size = new System.Drawing.Size(460, 10);
            pic_Divider1.TabIndex = 28;
            pic_Divider1.TabStop = false;
            // 
            // txt_ClientAddress
            // 
            txt_ClientAddress.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txt_ClientAddress.Location = new System.Drawing.Point(5, 46);
            txt_ClientAddress.Name = "txt_ClientAddress";
            txt_ClientAddress.PlaceholderText = "STREET ADDRESS";
            txt_ClientAddress.Size = new System.Drawing.Size(292, 35);
            txt_ClientAddress.TabIndex = 47;
            // 
            // txt_ClientPostcode
            // 
            txt_ClientPostcode.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txt_ClientPostcode.Location = new System.Drawing.Point(150, 87);
            txt_ClientPostcode.Name = "txt_ClientPostcode";
            txt_ClientPostcode.PlaceholderText = "POSTCODE";
            txt_ClientPostcode.Size = new System.Drawing.Size(147, 35);
            txt_ClientPostcode.TabIndex = 45;
            // 
            // txt_ClientPhoneNumber
            // 
            txt_ClientPhoneNumber.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txt_ClientPhoneNumber.Location = new System.Drawing.Point(5, 128);
            txt_ClientPhoneNumber.Name = "txt_ClientPhoneNumber";
            txt_ClientPhoneNumber.PlaceholderText = "PHONE";
            txt_ClientPhoneNumber.Size = new System.Drawing.Size(139, 35);
            txt_ClientPhoneNumber.TabIndex = 44;
            // 
            // txt_ClientEmail
            // 
            txt_ClientEmail.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txt_ClientEmail.Location = new System.Drawing.Point(150, 128);
            txt_ClientEmail.Name = "txt_ClientEmail";
            txt_ClientEmail.PlaceholderText = "EMAIL";
            txt_ClientEmail.Size = new System.Drawing.Size(147, 35);
            txt_ClientEmail.TabIndex = 43;
            // 
            // txt_ClientSurname
            // 
            txt_ClientSurname.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txt_ClientSurname.Location = new System.Drawing.Point(150, 5);
            txt_ClientSurname.Name = "txt_ClientSurname";
            txt_ClientSurname.PlaceholderText = "SURNAME";
            txt_ClientSurname.Size = new System.Drawing.Size(147, 35);
            txt_ClientSurname.TabIndex = 42;
            // 
            // txt_ClientForename
            // 
            txt_ClientForename.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txt_ClientForename.Location = new System.Drawing.Point(5, 5);
            txt_ClientForename.Name = "txt_ClientForename";
            txt_ClientForename.PlaceholderText = "FORENAME";
            txt_ClientForename.Size = new System.Drawing.Size(139, 35);
            txt_ClientForename.TabIndex = 41;
            // 
            // pnl_RegisterClient
            // 
            pnl_RegisterClient.Controls.Add(btn_CancelBooking);
            pnl_RegisterClient.Controls.Add(txt_ClientEmail);
            pnl_RegisterClient.Controls.Add(btn_BookInFull);
            pnl_RegisterClient.Controls.Add(txt_ClientAddress);
            pnl_RegisterClient.Controls.Add(txt_ClientForename);
            pnl_RegisterClient.Controls.Add(txt_ClientCity);
            pnl_RegisterClient.Controls.Add(txt_ClientSurname);
            pnl_RegisterClient.Controls.Add(txt_ClientPostcode);
            pnl_RegisterClient.Controls.Add(txt_ClientPhoneNumber);
            pnl_RegisterClient.Location = new System.Drawing.Point(12, 106);
            pnl_RegisterClient.Name = "pnl_RegisterClient";
            pnl_RegisterClient.Size = new System.Drawing.Size(300, 225);
            pnl_RegisterClient.TabIndex = 48;
            pnl_RegisterClient.Visible = false;
            // 
            // btn_CancelBooking
            // 
            btn_CancelBooking.BackColor = System.Drawing.Color.White;
            btn_CancelBooking.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_CancelBooking.ForeColor = System.Drawing.Color.OrangeRed;
            btn_CancelBooking.Location = new System.Drawing.Point(245, 169);
            btn_CancelBooking.Name = "btn_CancelBooking";
            btn_CancelBooking.Size = new System.Drawing.Size(52, 40);
            btn_CancelBooking.TabIndex = 50;
            btn_CancelBooking.Text = "X";
            btn_CancelBooking.UseVisualStyleBackColor = false;
            btn_CancelBooking.Click += btn_CancelBooking_Click;
            // 
            // btn_BookInFull
            // 
            btn_BookInFull.BackColor = System.Drawing.Color.White;
            btn_BookInFull.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_BookInFull.ForeColor = System.Drawing.Color.LightSeaGreen;
            btn_BookInFull.Location = new System.Drawing.Point(3, 169);
            btn_BookInFull.Name = "btn_BookInFull";
            btn_BookInFull.Size = new System.Drawing.Size(239, 40);
            btn_BookInFull.TabIndex = 49;
            btn_BookInFull.Text = "REGISTER ➕";
            btn_BookInFull.UseVisualStyleBackColor = false;
            btn_BookInFull.Click += btn_BookInFull_Click;
            // 
            // txt_ClientCity
            // 
            txt_ClientCity.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txt_ClientCity.Location = new System.Drawing.Point(5, 87);
            txt_ClientCity.Name = "txt_ClientCity";
            txt_ClientCity.PlaceholderText = "CITY";
            txt_ClientCity.Size = new System.Drawing.Size(139, 35);
            txt_ClientCity.TabIndex = 46;
            // 
            // Delete
            // 
            Delete.HeaderText = "X";
            Delete.Name = "Delete";
            Delete.Width = 35;
            // 
            // Edit
            // 
            Edit.HeaderText = "✏️";
            Edit.Name = "Edit";
            Edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            Edit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            Edit.Width = 35;
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
            // StreetAddress
            // 
            StreetAddress.HeaderText = "Address";
            StreetAddress.Name = "StreetAddress";
            // 
            // Postcode
            // 
            Postcode.HeaderText = "Postcode";
            Postcode.Name = "Postcode";
            Postcode.Width = 80;
            // 
            // EmailAddress
            // 
            EmailAddress.HeaderText = "Email";
            EmailAddress.Name = "EmailAddress";
            // 
            // PhoneNumber
            // 
            PhoneNumber.HeaderText = "Phone";
            PhoneNumber.Name = "PhoneNumber";
            // 
            // button5
            // 
            button5.BackColor = System.Drawing.Color.White;
            button5.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button5.ForeColor = System.Drawing.Color.DarkOrange;
            button5.Location = new System.Drawing.Point(236, 71);
            button5.Name = "button5";
            button5.Size = new System.Drawing.Size(53, 30);
            button5.TabIndex = 51;
            button5.Text = "🔃";
            button5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            button5.UseVisualStyleBackColor = false;
            // 
            // Clients
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.NavajoWhite;
            ClientSize = new System.Drawing.Size(800, 414);
            Controls.Add(button5);
            Controls.Add(pnl_RegisterClient);
            Controls.Add(btn_ChangeFormMode);
            Controls.Add(pic_Divider1);
            Controls.Add(navBarNew1);
            Controls.Add(lbl_SubTitleCard);
            Controls.Add(dataGridView1);
            Controls.Add(lbl_TitleCard);
            Name = "Clients";
            Text = "Clients";
            VisibleChanged += ListClients_VisibleChanged;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_Divider1).EndInit();
            pnl_RegisterClient.ResumeLayout(false);
            pnl_RegisterClient.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label lbl_SubTitleCard;
        private System.Windows.Forms.Button btn_ChangeFormMode;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_TitleCard;
        private controls.NavBarNew navBarNew1;
        private System.Windows.Forms.PictureBox pic_Divider1;
        private System.Windows.Forms.TextBox txt_ClientAddress;
        private System.Windows.Forms.TextBox txt_ClientPostcode;
        private System.Windows.Forms.TextBox txt_ClientPhoneNumber;
        private System.Windows.Forms.TextBox txt_ClientEmail;
        private System.Windows.Forms.TextBox txt_ClientSurname;
        private System.Windows.Forms.TextBox txt_ClientForename;
        private System.Windows.Forms.Panel pnl_RegisterClient;
        private System.Windows.Forms.TextBox txt_ClientCity;
        private System.Windows.Forms.Button btn_CancelBooking;
        private System.Windows.Forms.Button btn_BookInFull;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Forename;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn StreetAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn Postcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.Button button5;
    }
}