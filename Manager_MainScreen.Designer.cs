namespace DormitoryManagment
{
    partial class ManagerMainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerMainScreen));
            this.LogOut = new System.Windows.Forms.LinkLabel();
            this.Information = new System.Windows.Forms.Label();
            this.HomePic = new System.Windows.Forms.PictureBox();
            this.Crucial = new System.Windows.Forms.Label();
            this.BigLogo = new System.Windows.Forms.PictureBox();
            this.Background = new System.Windows.Forms.PictureBox();
            this.AddBills = new System.Windows.Forms.Button();
            this.ReviewRequests = new System.Windows.Forms.Button();
            this.ManageStudents = new System.Windows.Forms.Button();
            this.AddStudents = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.RemoveUserPic = new System.Windows.Forms.PictureBox();
            this.AddUsersPic = new System.Windows.Forms.PictureBox();
            this.BuildingsPic = new System.Windows.Forms.PictureBox();
            this.BuildingPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.HomePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BigLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Background)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemoveUserPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddUsersPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BuildingsPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BuildingPic)).BeginInit();
            this.SuspendLayout();
            // 
            // LogOut
            // 
            this.LogOut.AutoSize = true;
            this.LogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOut.Location = new System.Drawing.Point(1172, 21);
            this.LogOut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(178, 54);
            this.LogOut.TabIndex = 26;
            this.LogOut.TabStop = true;
            this.LogOut.Text = "Log out";
            this.LogOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogOut_LinkClicked);
            // 
            // Information
            // 
            this.Information.AutoSize = true;
            this.Information.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Information.Location = new System.Drawing.Point(91, 28);
            this.Information.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Information.Name = "Information";
            this.Information.Size = new System.Drawing.Size(339, 46);
            this.Information.TabIndex = 25;
            this.Information.Text = "Welcome back ....";
            // 
            // HomePic
            // 
            this.HomePic.BackColor = System.Drawing.SystemColors.Window;
            this.HomePic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.HomePic.Image = ((System.Drawing.Image)(resources.GetObject("HomePic.Image")));
            this.HomePic.Location = new System.Drawing.Point(16, 11);
            this.HomePic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HomePic.Name = "HomePic";
            this.HomePic.Size = new System.Drawing.Size(67, 62);
            this.HomePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HomePic.TabIndex = 24;
            this.HomePic.TabStop = false;
            this.HomePic.Click += new System.EventHandler(this.HomePic_Click);
            // 
            // Crucial
            // 
            this.Crucial.AutoSize = true;
            this.Crucial.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Crucial.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Crucial.Location = new System.Drawing.Point(413, 731);
            this.Crucial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Crucial.Name = "Crucial";
            this.Crucial.Size = new System.Drawing.Size(517, 72);
            this.Crucial.TabIndex = 31;
            this.Crucial.Text = "Ho Chi Minh University of Technology\r\nAdvanced Programming Assignment";
            this.Crucial.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BigLogo
            // 
            this.BigLogo.Image = ((System.Drawing.Image)(resources.GetObject("BigLogo.Image")));
            this.BigLogo.Location = new System.Drawing.Point(1296, 737);
            this.BigLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BigLogo.Name = "BigLogo";
            this.BigLogo.Size = new System.Drawing.Size(67, 62);
            this.BigLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BigLogo.TabIndex = 32;
            this.BigLogo.TabStop = false;
            // 
            // Background
            // 
            this.Background.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Background.Image = ((System.Drawing.Image)(resources.GetObject("Background.Image")));
            this.Background.Location = new System.Drawing.Point(420, 188);
            this.Background.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Background.Name = "Background";
            this.Background.Size = new System.Drawing.Size(943, 458);
            this.Background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Background.TabIndex = 53;
            this.Background.TabStop = false;
            // 
            // AddBills
            // 
            this.AddBills.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBills.Location = new System.Drawing.Point(16, 422);
            this.AddBills.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddBills.Name = "AddBills";
            this.AddBills.Size = new System.Drawing.Size(396, 121);
            this.AddBills.TabIndex = 57;
            this.AddBills.Text = "Add a list\r\nof new bills";
            this.AddBills.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddBills.UseVisualStyleBackColor = true;
            this.AddBills.Click += new System.EventHandler(this.AddBills_Click);
            // 
            // ReviewRequests
            // 
            this.ReviewRequests.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReviewRequests.Location = new System.Drawing.Point(16, 550);
            this.ReviewRequests.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ReviewRequests.Name = "ReviewRequests";
            this.ReviewRequests.Size = new System.Drawing.Size(396, 121);
            this.ReviewRequests.TabIndex = 56;
            this.ReviewRequests.Text = "Review pay\r\nrequests";
            this.ReviewRequests.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ReviewRequests.UseVisualStyleBackColor = true;
            this.ReviewRequests.Click += new System.EventHandler(this.ReviewRequests_Click);
            // 
            // ManageStudents
            // 
            this.ManageStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageStudents.Location = new System.Drawing.Point(16, 289);
            this.ManageStudents.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ManageStudents.Name = "ManageStudents";
            this.ManageStudents.Size = new System.Drawing.Size(396, 121);
            this.ManageStudents.TabIndex = 55;
            this.ManageStudents.Text = "Students\r\nManage";
            this.ManageStudents.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ManageStudents.UseVisualStyleBackColor = true;
            this.ManageStudents.Click += new System.EventHandler(this.ManageStudents_Click);
            // 
            // AddStudents
            // 
            this.AddStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddStudents.Location = new System.Drawing.Point(16, 161);
            this.AddStudents.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddStudents.Name = "AddStudents";
            this.AddStudents.Size = new System.Drawing.Size(396, 121);
            this.AddStudents.TabIndex = 54;
            this.AddStudents.Text = "Add a list\r\nof students";
            this.AddStudents.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddStudents.UseVisualStyleBackColor = true;
            this.AddStudents.Click += new System.EventHandler(this.AddBuilding_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Info;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(16, 101);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1347, 610);
            this.pictureBox1.TabIndex = 58;
            this.pictureBox1.TabStop = false;
            // 
            // RemoveUserPic
            // 
            this.RemoveUserPic.BackColor = System.Drawing.SystemColors.Window;
            this.RemoveUserPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.RemoveUserPic.Image = ((System.Drawing.Image)(resources.GetObject("RemoveUserPic.Image")));
            this.RemoveUserPic.Location = new System.Drawing.Point(32, 569);
            this.RemoveUserPic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RemoveUserPic.Name = "RemoveUserPic";
            this.RemoveUserPic.Size = new System.Drawing.Size(96, 89);
            this.RemoveUserPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RemoveUserPic.TabIndex = 69;
            this.RemoveUserPic.TabStop = false;
            // 
            // AddUsersPic
            // 
            this.AddUsersPic.BackColor = System.Drawing.SystemColors.Window;
            this.AddUsersPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AddUsersPic.Image = ((System.Drawing.Image)(resources.GetObject("AddUsersPic.Image")));
            this.AddUsersPic.Location = new System.Drawing.Point(32, 442);
            this.AddUsersPic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddUsersPic.Name = "AddUsersPic";
            this.AddUsersPic.Size = new System.Drawing.Size(96, 89);
            this.AddUsersPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AddUsersPic.TabIndex = 68;
            this.AddUsersPic.TabStop = false;
            // 
            // BuildingsPic
            // 
            this.BuildingsPic.BackColor = System.Drawing.SystemColors.Window;
            this.BuildingsPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BuildingsPic.Image = ((System.Drawing.Image)(resources.GetObject("BuildingsPic.Image")));
            this.BuildingsPic.Location = new System.Drawing.Point(32, 308);
            this.BuildingsPic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BuildingsPic.Name = "BuildingsPic";
            this.BuildingsPic.Size = new System.Drawing.Size(96, 89);
            this.BuildingsPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BuildingsPic.TabIndex = 67;
            this.BuildingsPic.TabStop = false;
            // 
            // BuildingPic
            // 
            this.BuildingPic.BackColor = System.Drawing.SystemColors.Window;
            this.BuildingPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BuildingPic.Image = ((System.Drawing.Image)(resources.GetObject("BuildingPic.Image")));
            this.BuildingPic.Location = new System.Drawing.Point(32, 180);
            this.BuildingPic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BuildingPic.Name = "BuildingPic";
            this.BuildingPic.Size = new System.Drawing.Size(96, 89);
            this.BuildingPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BuildingPic.TabIndex = 66;
            this.BuildingPic.TabStop = false;
            // 
            // ManagerMainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1379, 814);
            this.Controls.Add(this.RemoveUserPic);
            this.Controls.Add(this.AddUsersPic);
            this.Controls.Add(this.BuildingsPic);
            this.Controls.Add(this.BuildingPic);
            this.Controls.Add(this.Background);
            this.Controls.Add(this.AddBills);
            this.Controls.Add(this.ReviewRequests);
            this.Controls.Add(this.ManageStudents);
            this.Controls.Add(this.AddStudents);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BigLogo);
            this.Controls.Add(this.Crucial);
            this.Controls.Add(this.LogOut);
            this.Controls.Add(this.Information);
            this.Controls.Add(this.HomePic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ManagerMainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dormitory Management";
            ((System.ComponentModel.ISupportInitialize)(this.HomePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BigLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Background)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemoveUserPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddUsersPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BuildingsPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BuildingPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel LogOut;
        private System.Windows.Forms.Label Information;
        private System.Windows.Forms.PictureBox HomePic;
        private System.Windows.Forms.Label Crucial;
        private System.Windows.Forms.PictureBox BigLogo;
        private System.Windows.Forms.PictureBox Background;
        private System.Windows.Forms.Button AddBills;
        private System.Windows.Forms.Button ReviewRequests;
        private System.Windows.Forms.Button ManageStudents;
        private System.Windows.Forms.Button AddStudents;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox RemoveUserPic;
        private System.Windows.Forms.PictureBox AddUsersPic;
        private System.Windows.Forms.PictureBox BuildingsPic;
        private System.Windows.Forms.PictureBox BuildingPic;
    }
}