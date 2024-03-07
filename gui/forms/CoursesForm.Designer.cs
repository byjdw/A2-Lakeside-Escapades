namespace Banbridge_Academy_SSD_Coursework.gui.modify
{
    partial class CoursesForm
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
            button1 = new System.Windows.Forms.Button();
            pic_Divider1 = new System.Windows.Forms.PictureBox();
            lbl_TitleCard = new System.Windows.Forms.Label();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            button2 = new System.Windows.Forms.Button();
            navBarNew1 = new controls.NavBarNew();
            ((System.ComponentModel.ISupportInitialize)pic_Divider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lbl_SubTitleCard
            // 
            lbl_SubTitleCard.AutoSize = true;
            lbl_SubTitleCard.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_SubTitleCard.ForeColor = System.Drawing.Color.Chocolate;
            lbl_SubTitleCard.Location = new System.Drawing.Point(12, 71);
            lbl_SubTitleCard.Name = "lbl_SubTitleCard";
            lbl_SubTitleCard.Size = new System.Drawing.Size(236, 32);
            lbl_SubTitleCard.TabIndex = 25;
            lbl_SubTitleCard.Text = "VIEWING COURSES";
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.White;
            button1.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button1.ForeColor = System.Drawing.Color.DarkOrange;
            button1.Location = new System.Drawing.Point(12, 104);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(300, 40);
            button1.TabIndex = 24;
            button1.Text = "CREATE ➕";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pic_Divider1
            // 
            pic_Divider1.BackColor = System.Drawing.Color.Chocolate;
            pic_Divider1.Location = new System.Drawing.Point(332, 335);
            pic_Divider1.Name = "pic_Divider1";
            pic_Divider1.Size = new System.Drawing.Size(460, 10);
            pic_Divider1.TabIndex = 23;
            pic_Divider1.TabStop = false;
            // 
            // lbl_TitleCard
            // 
            lbl_TitleCard.AutoSize = true;
            lbl_TitleCard.Font = new System.Drawing.Font("Segoe UI Black", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_TitleCard.ForeColor = System.Drawing.Color.Chocolate;
            lbl_TitleCard.Location = new System.Drawing.Point(-2, -3);
            lbl_TitleCard.Name = "lbl_TitleCard";
            lbl_TitleCard.Size = new System.Drawing.Size(340, 89);
            lbl_TitleCard.TabIndex = 22;
            lbl_TitleCard.Text = "COURSES";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = System.Drawing.Color.Bisque;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(332, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new System.Drawing.Size(457, 317);
            dataGridView1.TabIndex = 26;
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.Color.White;
            button2.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button2.ForeColor = System.Drawing.Color.DarkOrange;
            button2.Location = new System.Drawing.Point(12, 150);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(300, 40);
            button2.TabIndex = 27;
            button2.Text = "SCHEDULE ⏰";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // navBarNew1
            // 
            navBarNew1.BackColor = System.Drawing.Color.Chocolate;
            navBarNew1.Dock = System.Windows.Forms.DockStyle.Bottom;
            navBarNew1.Location = new System.Drawing.Point(0, 351);
            navBarNew1.Name = "navBarNew1";
            navBarNew1.Size = new System.Drawing.Size(800, 63);
            navBarNew1.TabIndex = 28;
            // 
            // Courses
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.NavajoWhite;
            ClientSize = new System.Drawing.Size(800, 414);
            Controls.Add(button1);
            Controls.Add(navBarNew1);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(lbl_SubTitleCard);
            Controls.Add(pic_Divider1);
            Controls.Add(lbl_TitleCard);
            Name = "Courses";
            Text = "Courses";
            ((System.ComponentModel.ISupportInitialize)pic_Divider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label lbl_SubTitleCard;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pic_Divider1;
        private System.Windows.Forms.Label lbl_TitleCard;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private controls.NavBarNew navBarNew1;
    }
}