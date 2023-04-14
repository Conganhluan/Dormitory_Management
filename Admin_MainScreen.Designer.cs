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
            this.AddBuilding = new System.Windows.Forms.Button();
            this.ModifyBuilding = new System.Windows.Forms.Button();
            this.RemoveUsers = new System.Windows.Forms.Button();
            this.AddUsers = new System.Windows.Forms.Button();
            this.Crucial = new System.Windows.Forms.Label();
            this.Background = new System.Windows.Forms.PictureBox();
            this.BigLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.HomePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Background)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BigLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // LogOut
            // 
            this.LogOut.AutoSize = true;
            this.LogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOut.Location = new System.Drawing.Point(879, 17);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(143, 42);
            this.LogOut.TabIndex = 19;
            this.LogOut.TabStop = true;
            this.LogOut.Text = "Log out";
            this.LogOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogOut_LinkClicked);
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
            this.HomePic.TabIndex = 20;
            this.HomePic.TabStop = false;
            this.HomePic.Click += new System.EventHandler(this.HomePic_Click);
            // 
            // Information
            // 
            this.Information.AutoSize = true;
            this.Information.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Information.Location = new System.Drawing.Point(68, 23);
            this.Information.Name = "Information";
            this.Information.Size = new System.Drawing.Size(504, 37);
            this.Information.TabIndex = 21;
            this.Information.Text = "Welcome back Application Admin!";
            // 
            // AddBuilding
            // 
            this.AddBuilding.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBuilding.Location = new System.Drawing.Point(12, 131);
            this.AddBuilding.Name = "AddBuilding";
            this.AddBuilding.Size = new System.Drawing.Size(217, 98);
            this.AddBuilding.TabIndex = 22;
            this.AddBuilding.Text = "Add a new \r\nbuilding";
            this.AddBuilding.UseVisualStyleBackColor = true;
            this.AddBuilding.Click += new System.EventHandler(this.AddBuilding_Click);
            // 
            // ModifyBuilding
            // 
            this.ModifyBuilding.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyBuilding.Location = new System.Drawing.Point(12, 235);
            this.ModifyBuilding.Name = "ModifyBuilding";
            this.ModifyBuilding.Size = new System.Drawing.Size(217, 98);
            this.ModifyBuilding.TabIndex = 23;
            this.ModifyBuilding.Text = "Modify\r\nbuildings";
            this.ModifyBuilding.UseVisualStyleBackColor = true;
            this.ModifyBuilding.Click += new System.EventHandler(this.ModifyBuilding_Click);
            // 
            // RemoveUsers
            // 
            this.RemoveUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveUsers.Location = new System.Drawing.Point(12, 447);
            this.RemoveUsers.Name = "RemoveUsers";
            this.RemoveUsers.Size = new System.Drawing.Size(217, 98);
            this.RemoveUsers.TabIndex = 24;
            this.RemoveUsers.Text = "Remove a \r\nlist of users";
            this.RemoveUsers.UseVisualStyleBackColor = true;
            this.RemoveUsers.Click += new System.EventHandler(this.RemoveUsers_Click);
            // 
            // AddUsers
            // 
            this.AddUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddUsers.Location = new System.Drawing.Point(12, 343);
            this.AddUsers.Name = "AddUsers";
            this.AddUsers.Size = new System.Drawing.Size(217, 98);
            this.AddUsers.TabIndex = 25;
            this.AddUsers.Text = "Add a list\r\nof users";
            this.AddUsers.UseVisualStyleBackColor = true;
            this.AddUsers.Click += new System.EventHandler(this.AddUsers_Click);
            // 
            // Crucial
            // 
            this.Crucial.AutoSize = true;
            this.Crucial.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.Background.Location = new System.Drawing.Point(235, 131);
            this.Background.Name = "Background";
            this.Background.Size = new System.Drawing.Size(787, 414);
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
            // AdminMainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 661);
            this.Controls.Add(this.BigLogo);
            this.Controls.Add(this.Background);
            this.Controls.Add(this.Crucial);
            this.Controls.Add(this.AddUsers);
            this.Controls.Add(this.RemoveUsers);
            this.Controls.Add(this.ModifyBuilding);
            this.Controls.Add(this.AddBuilding);
            this.Controls.Add(this.Information);
            this.Controls.Add(this.HomePic);
            this.Controls.Add(this.LogOut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminMainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dormitory Management";
            this.Load += new System.EventHandler(this.AdminMainScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HomePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Background)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BigLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel LogOut;
        private System.Windows.Forms.PictureBox HomePic;
        private System.Windows.Forms.Label Information;
        private System.Windows.Forms.Button AddBuilding;
        private System.Windows.Forms.Button ModifyBuilding;
        private System.Windows.Forms.Button RemoveUsers;
        private System.Windows.Forms.Button AddUsers;
        private System.Windows.Forms.Label Crucial;
        private System.Windows.Forms.PictureBox Background;
        private System.Windows.Forms.PictureBox BigLogo;
    }
}