using System.Drawing;
using System.Windows.Forms;

namespace Banbridge_Academy_SSD_Coursework
{
    partial class OverviewForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            pictureBox2 = new PictureBox();
            navBarNew1 = new gui.controls.NavBarNew();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Chocolate;
            label1.Location = new Point(263, 85);
            label1.Name = "label1";
            label1.Size = new Size(366, 135);
            label1.TabIndex = 4;
            label1.Text = "LAKESIDE ESCAPADES\r\nMANAGEMENT\r\nPORTAL";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.logo_darkorange;
            pictureBox2.Location = new Point(77, 74);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(161, 159);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 31;
            pictureBox2.TabStop = false;
            // 
            // navBarNew1
            // 
            navBarNew1.BackColor = Color.Chocolate;
            navBarNew1.Dock = DockStyle.Bottom;
            navBarNew1.Location = new Point(0, 315);
            navBarNew1.Name = "navBarNew1";
            navBarNew1.Size = new Size(712, 63);
            navBarNew1.TabIndex = 33;
            // 
            // Overview
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BlanchedAlmond;
            ClientSize = new Size(712, 378);
            ControlBox = false;
            Controls.Add(navBarNew1);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Margin = new Padding(2, 1, 2, 1);
            Name = "Overview";
            Text = "Overview";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox2;
        private gui.controls.NavBarNew navBarNew1;
    }
}