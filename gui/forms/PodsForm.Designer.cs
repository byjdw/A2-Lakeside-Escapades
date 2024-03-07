namespace Banbridge_Academy_SSD_Coursework.gui.list
{
    partial class PodsForm
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
            dataGridView1 = new System.Windows.Forms.DataGridView();
            lbl_TitleCard = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            navBarNew1 = new controls.NavBarNew();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbl_SubTitleCard
            // 
            lbl_SubTitleCard.AutoSize = true;
            lbl_SubTitleCard.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_SubTitleCard.ForeColor = System.Drawing.Color.Chocolate;
            lbl_SubTitleCard.Location = new System.Drawing.Point(12, 71);
            lbl_SubTitleCard.Name = "lbl_SubTitleCard";
            lbl_SubTitleCard.Size = new System.Drawing.Size(245, 32);
            lbl_SubTitleCard.TabIndex = 26;
            lbl_SubTitleCard.Text = "VIEWING ALL PODS";
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.White;
            button1.Font = new System.Drawing.Font("Segoe UI Black", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button1.ForeColor = System.Drawing.Color.DarkOrange;
            button1.Location = new System.Drawing.Point(12, 104);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(300, 40);
            button1.TabIndex = 25;
            button1.Text = "CREATE ➕";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = System.Drawing.Color.Bisque;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(328, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new System.Drawing.Size(460, 317);
            dataGridView1.TabIndex = 24;
            // 
            // lbl_TitleCard
            // 
            lbl_TitleCard.AutoSize = true;
            lbl_TitleCard.BackColor = System.Drawing.Color.NavajoWhite;
            lbl_TitleCard.Font = new System.Drawing.Font("Segoe UI Black", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_TitleCard.ForeColor = System.Drawing.Color.Chocolate;
            lbl_TitleCard.Location = new System.Drawing.Point(-2, -3);
            lbl_TitleCard.Name = "lbl_TitleCard";
            lbl_TitleCard.Size = new System.Drawing.Size(222, 89);
            lbl_TitleCard.TabIndex = 22;
            lbl_TitleCard.Text = "PODS";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.Color.Chocolate;
            pictureBox1.Location = new System.Drawing.Point(328, 335);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(460, 10);
            pictureBox1.TabIndex = 27;
            pictureBox1.TabStop = false;
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
            // Pods
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.NavajoWhite;
            ClientSize = new System.Drawing.Size(800, 414);
            Controls.Add(button1);
            Controls.Add(navBarNew1);
            Controls.Add(pictureBox1);
            Controls.Add(lbl_SubTitleCard);
            Controls.Add(dataGridView1);
            Controls.Add(lbl_TitleCard);
            Name = "Pods";
            Text = "  ";
            VisibleChanged += ListPodss_VisibleChanged;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label lbl_SubTitleCard;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_TitleCard;
        private System.Windows.Forms.PictureBox pictureBox1;
        private controls.NavBarNew navBarNew1;
    }
}