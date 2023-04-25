namespace DormitoryManagment
{
    partial class AdminMainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMainScreen));
            this.LogOut = new System.Windows.Forms.LinkLabel();
            this.HomePic = new System.Windows.Forms.PictureBox();
            this.Information = new System.Windows.Forms.Label();
            this.Crucial = new System.Windows.Forms.Label();
            this.Background = new System.Windows.Forms.PictureBox();
            this.BigLogo = new System.Windows.Forms.PictureBox();
            this.AddUsers = new System.Windows.Forms.Button();
            this.RemoveUsers = new System.Windows.Forms.Button();
            this.ModifyBuilding = new System.Windows.Forms.Button();
            this.AddBuilding = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.RemoveUserPic = new System.Windows.Forms.PictureBox();
            this.AddUsersPic = new System.Windows.Forms.PictureBox();
            this.BuildingsPic = new System.Windows.Forms.PictureBox();
            this.BuildingPic = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.HomePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Background)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BigLogo)).BeginInit();
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
            this.LogOut.DisabledLinkColor = System.Drawing.Color.White;
            this.LogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOut.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.LogOut.LinkColor = System.Drawing.Color.Black;
            this.LogOut.Location = new System.Drawing.Point(879, 17);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(152, 44);
            this.LogOut.TabIndex = 19;
            this.LogOut.TabStop = true;
            this.LogOut.Text = "Log out";
            this.LogOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogOut_LinkClicked);
            // 
            // HomePic
            // 
            this.HomePic.BackColor = System.Drawing.SystemColors.Window;
            this.HomePic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.HomePic.Image = ((System.Drawing.Image)(resources.GetObject("HomePic.Image")));
            this.HomePic.Location = new System.Drawing.Point(12, 9);
            this.HomePic.Name = "HomePic";
            this.HomePic.Size = new System.Drawing.Size(50, 50);
            this.HomePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HomePic.TabIndex = 20;
            this.HomePic.TabStop = false;
            this.HomePic.Click += new System.EventHandler(this.HomePic_Click);
            // 
            // Information
            // 
            this.Information.AutoSize = true;
            this.Information.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Information.Location = new System.Drawing.Point(68, 23);
            this.Information.Name = "Information";
            this.Information.Size = new System.Drawing.Size(535, 37);
            this.Information.TabIndex = 21;
            this.Information.Text = "Welcome back Application Admin!";
            // 
            // Crucial
            // 
            this.Crucial.AutoSize = true;
            this.Crucial.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Crucial.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Crucial.Location = new System.Drawing.Point(310, 594);
            this.Crucial.Name = "Crucial";
            this.Crucial.Size = new System.Drawing.Size(413, 58);
            this.Crucial.TabIndex = 26;
            this.Crucial.Text = "Ho Chi Minh University of Technology\r\nAdvanced Programming Assignment";
            this.Crucial.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Background
            // 
            this.Background.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Background.Image = ((System.Drawing.Image)(resources.GetObject("Background.Image")));
            this.Background.Location = new System.Drawing.Point(315, 153);
            this.Background.Name = "Background";
            this.Background.Size = new System.Drawing.Size(707, 372);
            this.Background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Background.TabIndex = 31;
            this.Background.TabStop = false;
            // 
            // BigLogo
            // 
            this.BigLogo.Image = ((System.Drawing.Image)(resources.GetObject("BigLogo.Image")));
            this.BigLogo.Location = new System.Drawing.Point(972, 599);
            this.BigLogo.Name = "BigLogo";
            this.BigLogo.Size = new System.Drawing.Size(50, 50);
            this.BigLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BigLogo.TabIndex = 33;
            this.BigLogo.TabStop = false;
            // 
            // AddUsers
            // 
            this.AddUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddUsers.Location = new System.Drawing.Point(12, 343);
            this.AddUsers.Name = "AddUsers";
            this.AddUsers.Size = new System.Drawing.Size(297, 98);
            this.AddUsers.TabIndex = 51;
            this.AddUsers.Text = "Add a list\r\nof users";
            this.AddUsers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddUsers.UseVisualStyleBackColor = true;
            this.AddUsers.Click += new System.EventHandler(this.AddUsers_Click_1);
            // 
            // RemoveUsers
            // 
            this.RemoveUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveUsers.Location = new System.Drawing.Point(12, 447);
            this.RemoveUsers.Name = "RemoveUsers";
            this.RemoveUsers.Size = new System.Drawing.Size(297, 98);
            this.RemoveUsers.TabIndex = 50;
            this.RemoveUsers.Text = "Remove a \r\nlist of users";
            this.RemoveUsers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RemoveUsers.UseVisualStyleBackColor = true;
            this.RemoveUsers.Click += new System.EventHandler(this.RemoveUsers_Click_1);
            // 
            // ModifyBuilding
            // 
            this.ModifyBuilding.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyBuilding.Location = new System.Drawing.Point(12, 235);
            this.ModifyBuilding.Name = "ModifyBuilding";
            this.ModifyBuilding.Size = new System.Drawing.Size(297, 98);
            this.ModifyBuilding.TabIndex = 49;
            this.ModifyBuilding.Text = "Modify\r\nbuildings";
            this.ModifyBuilding.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ModifyBuilding.UseVisualStyleBackColor = true;
            this.ModifyBuilding.Click += new System.EventHandler(this.ModifyBuilding_Click_1);
            // 
            // AddBuilding
            // 
            this.AddBuilding.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBuilding.Location = new System.Drawing.Point(12, 131);
            this.AddBuilding.Name = "AddBuilding";
            this.AddBuilding.Size = new System.Drawing.Size(297, 98);
            this.AddBuilding.TabIndex = 48;
            this.AddBuilding.Text = "Add a new \r\nbuilding";
            this.AddBuilding.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddBuilding.UseVisualStyleBackColor = true;
            this.AddBuilding.Click += new System.EventHandler(this.AddBuilding_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Info;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(12, 82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1010, 496);
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            // 
            // RemoveUserPic
            // 
            this.RemoveUserPic.BackColor = System.Drawing.SystemColors.Window;
            this.RemoveUserPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.RemoveUserPic.Image = ((System.Drawing.Image)(resources.GetObject("RemoveUserPic.Image")));
            this.RemoveUserPic.Location = new System.Drawing.Point(24, 462);
            this.RemoveUserPic.Name = "RemoveUserPic";
            this.RemoveUserPic.Size = new System.Drawing.Size(72, 72);
            this.RemoveUserPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RemoveUserPic.TabIndex = 65;
            this.RemoveUserPic.TabStop = false;
            // 
            // AddUsersPic
            // 
            this.AddUsersPic.BackColor = System.Drawing.SystemColors.Window;
            this.AddUsersPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AddUsersPic.Image = ((System.Drawing.Image)(resources.GetObject("AddUsersPic.Image")));
            this.AddUsersPic.Location = new System.Drawing.Point(24, 359);
            this.AddUsersPic.Name = "AddUsersPic";
            this.AddUsersPic.Size = new System.Drawing.Size(72, 72);
            this.AddUsersPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AddUsersPic.TabIndex = 64;
            this.AddUsersPic.TabStop = false;
            // 
            // BuildingsPic
            // 
            this.BuildingsPic.BackColor = System.Drawing.SystemColors.Window;
            this.BuildingsPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BuildingsPic.Image = ((System.Drawing.Image)(resources.GetObject("BuildingsPic.Image")));
            this.BuildingsPic.Location = new System.Drawing.Point(24, 250);
            this.BuildingsPic.Name = "BuildingsPic";
            this.BuildingsPic.Size = new System.Drawing.Size(72, 72);
            this.BuildingsPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BuildingsPic.TabIndex = 63;
            this.BuildingsPic.TabStop = false;
            // 
            // BuildingPic
            // 
            this.BuildingPic.BackColor = System.Drawing.SystemColors.Window;
            this.BuildingPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BuildingPic.Image = ((System.Drawing.Image)(resources.GetObject("BuildingPic.Image")));
            this.BuildingPic.Location = new System.Drawing.Point(24, 146);
            this.BuildingPic.Name = "BuildingPic";
            this.BuildingPic.Size = new System.Drawing.Size(72, 72);
            this.BuildingPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BuildingPic.TabIndex = 62;
            this.BuildingPic.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Location = new System.Drawing.Point(-52, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1139, 77);
            this.panel2.TabIndex = 73;
            // 
            // AdminMainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1034, 661);
            this.Controls.Add(this.RemoveUserPic);
            this.Controls.Add(this.AddUsersPic);
            this.Controls.Add(this.BuildingsPic);
            this.Controls.Add(this.BuildingPic);
            this.Controls.Add(this.BigLogo);
            this.Controls.Add(this.Background);
            this.Controls.Add(this.Crucial);
            this.Controls.Add(this.Information);
            this.Controls.Add(this.HomePic);
            this.Controls.Add(this.LogOut);
            this.Controls.Add(this.AddUsers);
            this.Controls.Add(this.RemoveUsers);
            this.Controls.Add(this.ModifyBuilding);
            this.Controls.Add(this.AddBuilding);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminMainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dormitory Management";
            this.Load += new System.EventHandler(this.AdminMainScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HomePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Background)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BigLogo)).EndInit();
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
        private System.Windows.Forms.PictureBox HomePic;
        private System.Windows.Forms.Label Information;
        private System.Windows.Forms.Label Crucial;
        private System.Windows.Forms.PictureBox Background;
        private System.Windows.Forms.PictureBox BigLogo;
        private System.Windows.Forms.Button AddUsers;
        private System.Windows.Forms.Button RemoveUsers;
        private System.Windows.Forms.Button ModifyBuilding;
        private System.Windows.Forms.Button AddBuilding;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox RemoveUserPic;
        private System.Windows.Forms.PictureBox AddUsersPic;
        private System.Windows.Forms.PictureBox BuildingsPic;
        private System.Windows.Forms.PictureBox BuildingPic;
        private System.Windows.Forms.Panel panel2;
    }
}