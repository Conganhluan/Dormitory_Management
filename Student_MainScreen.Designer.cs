﻿namespace DormitoryManagment
{
    partial class StudentMainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentMainScreen));
            this.Crucial = new System.Windows.Forms.Label();
            this.HomePic = new System.Windows.Forms.PictureBox();
            this.Information = new System.Windows.Forms.Label();
            this.LogOut = new System.Windows.Forms.LinkLabel();
            this.BigLogo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Type = new System.Windows.Forms.Label();
            this.Number = new System.Windows.Forms.Label();
            this.BuildingName = new System.Windows.Forms.Label();
            this.Bill = new System.Windows.Forms.Label();
            this.Late = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Penalty = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.HomePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BigLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // Crucial
            // 
            this.Crucial.AutoSize = true;
            this.Crucial.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Crucial.Location = new System.Drawing.Point(310, 594);
            this.Crucial.Name = "Crucial";
            this.Crucial.Size = new System.Drawing.Size(413, 58);
            this.Crucial.TabIndex = 9;
            this.Crucial.Text = "Ho Chi Minh University of Technology\r\nAdvanced Programming Assignment";
            this.Crucial.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // HomePic
            // 
            this.HomePic.BackColor = System.Drawing.SystemColors.Control;
            this.HomePic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.HomePic.Image = ((System.Drawing.Image)(resources.GetObject("HomePic.Image")));
            this.HomePic.Location = new System.Drawing.Point(12, 9);
            this.HomePic.Name = "HomePic";
            this.HomePic.Size = new System.Drawing.Size(50, 50);
            this.HomePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HomePic.TabIndex = 21;
            this.HomePic.TabStop = false;
            this.HomePic.Click += new System.EventHandler(this.HomePic_Click);
            // 
            // Information
            // 
            this.Information.AutoSize = true;
            this.Information.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Information.Location = new System.Drawing.Point(68, 23);
            this.Information.Name = "Information";
            this.Information.Size = new System.Drawing.Size(272, 37);
            this.Information.TabIndex = 22;
            this.Information.Text = "Welcome back ....";
            // 
            // LogOut
            // 
            this.LogOut.AutoSize = true;
            this.LogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOut.Location = new System.Drawing.Point(879, 17);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(143, 42);
            this.LogOut.TabIndex = 23;
            this.LogOut.TabStop = true;
            this.LogOut.Text = "Log out";
            this.LogOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogOut_LinkClicked);
            // 
            // BigLogo
            // 
            this.BigLogo.Image = ((System.Drawing.Image)(resources.GetObject("BigLogo.Image")));
            this.BigLogo.Location = new System.Drawing.Point(410, 100);
            this.BigLogo.Name = "BigLogo";
            this.BigLogo.Size = new System.Drawing.Size(180, 180);
            this.BigLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BigLogo.TabIndex = 24;
            this.BigLogo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(466, 259);
            this.label1.TabIndex = 25;
            this.label1.Text = "Your staying room status:\r\n\r\nRoom for:\r\n\r\nUnpaid electricity and water bill:\r\n\r\nB" +
    "ill late time:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(884, 594);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(138, 42);
            this.linkLabel1.TabIndex = 26;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Pay bill";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(361, 378);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 37);
            this.label2.TabIndex = 27;
            this.label2.Text = "Room number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(707, 378);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 37);
            this.label3.TabIndex = 28;
            this.label3.Text = "Building name:";
            // 
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Type.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Type.Location = new System.Drawing.Point(181, 378);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(147, 37);
            this.Type.TabIndex = 29;
            this.Type.Text = "4 people";
            // 
            // Number
            // 
            this.Number.AutoSize = true;
            this.Number.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Number.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Number.Location = new System.Drawing.Point(571, 378);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(91, 37);
            this.Number.TabIndex = 30;
            this.Number.Text = "1235";
            // 
            // BuildingName
            // 
            this.BuildingName.AutoSize = true;
            this.BuildingName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuildingName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.BuildingName.Location = new System.Drawing.Point(923, 378);
            this.BuildingName.Name = "BuildingName";
            this.BuildingName.Size = new System.Drawing.Size(76, 37);
            this.BuildingName.TabIndex = 31;
            this.BuildingName.Text = "A10";
            // 
            // Bill
            // 
            this.Bill.AutoSize = true;
            this.Bill.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bill.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Bill.Location = new System.Drawing.Point(489, 452);
            this.Bill.Name = "Bill";
            this.Bill.Size = new System.Drawing.Size(221, 37);
            this.Bill.TabIndex = 32;
            this.Bill.Text = "325.231 VNĐ";
            // 
            // Late
            // 
            this.Late.AutoSize = true;
            this.Late.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Late.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Late.Location = new System.Drawing.Point(220, 526);
            this.Late.Name = "Late";
            this.Late.Size = new System.Drawing.Size(134, 37);
            this.Late.TabIndex = 33;
            this.Late.Text = "12 days";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(527, 526);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(183, 37);
            this.label9.TabIndex = 34;
            this.label9.Text = "Penalty fee:";
            // 
            // Penalty
            // 
            this.Penalty.AutoSize = true;
            this.Penalty.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Penalty.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Penalty.Location = new System.Drawing.Point(698, 526);
            this.Penalty.Name = "Penalty";
            this.Penalty.Size = new System.Drawing.Size(219, 37);
            this.Penalty.TabIndex = 35;
            this.Penalty.Text = "123.231 VNĐ";
            // 
            // StudentMainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 661);
            this.Controls.Add(this.Penalty);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Late);
            this.Controls.Add(this.Bill);
            this.Controls.Add(this.BuildingName);
            this.Controls.Add(this.Number);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BigLogo);
            this.Controls.Add(this.LogOut);
            this.Controls.Add(this.Information);
            this.Controls.Add(this.HomePic);
            this.Controls.Add(this.Crucial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StudentMainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dormitory Management";
            this.Load += new System.EventHandler(this.StudentMainScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HomePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BigLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Crucial;
        private System.Windows.Forms.PictureBox HomePic;
        private System.Windows.Forms.Label Information;
        private System.Windows.Forms.LinkLabel LogOut;
        private System.Windows.Forms.PictureBox BigLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Type;
        private System.Windows.Forms.Label Number;
        private System.Windows.Forms.Label BuildingName;
        private System.Windows.Forms.Label Bill;
        private System.Windows.Forms.Label Late;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label Penalty;
    }
}