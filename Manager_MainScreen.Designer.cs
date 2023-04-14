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
            this.Students = new System.Windows.Forms.Button();
            this.Rooms = new System.Windows.Forms.Button();
            this.Background = new System.Windows.Forms.PictureBox();
            this.Crucial = new System.Windows.Forms.Label();
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
            this.LogOut.TabIndex = 26;
            this.LogOut.TabStop = true;
            this.LogOut.Text = "Log out";
            this.LogOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogOut_LinkClicked);
            // 
            // Information
            // 
            this.Information.AutoSize = true;
            this.Information.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Information.Location = new System.Drawing.Point(68, 23);
            this.Information.Name = "Information";
            this.Information.Size = new System.Drawing.Size(272, 37);
            this.Information.TabIndex = 25;
            this.Information.Text = "Welcome back ....";
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
            this.HomePic.TabIndex = 24;
            this.HomePic.TabStop = false;
            this.HomePic.Click += new System.EventHandler(this.HomePic_Click);
            // 
            // Students
            // 
            this.Students.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Students.Location = new System.Drawing.Point(12, 105);
            this.Students.Name = "Students";
            this.Students.Size = new System.Drawing.Size(141, 223);
            this.Students.TabIndex = 27;
            this.Students.Text = "Students\r\nmanage";
            this.Students.UseVisualStyleBackColor = true;
            this.Students.Click += new System.EventHandler(this.Students_Click);
            // 
            // Rooms
            // 
            this.Rooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rooms.Location = new System.Drawing.Point(12, 335);
            this.Rooms.Name = "Rooms";
            this.Rooms.Size = new System.Drawing.Size(141, 223);
            this.Rooms.TabIndex = 28;
            this.Rooms.Text = "Bills\r\nmanage";
            this.Rooms.UseVisualStyleBackColor = true;
            this.Rooms.Click += new System.EventHandler(this.Rooms_Click);
            // 
            // Background
            // 
            this.Background.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Background.Image = ((System.Drawing.Image)(resources.GetObject("Background.Image")));
            this.Background.Location = new System.Drawing.Point(159, 105);
            this.Background.Name = "Background";
            this.Background.Size = new System.Drawing.Size(863, 453);
            this.Background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Background.TabIndex = 30;
            this.Background.TabStop = false;
            // 
            // Crucial
            // 
            this.Crucial.AutoSize = true;
            this.Crucial.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Crucial.Location = new System.Drawing.Point(310, 594);
            this.Crucial.Name = "Crucial";
            this.Crucial.Size = new System.Drawing.Size(413, 58);
            this.Crucial.TabIndex = 31;
            this.Crucial.Text = "Ho Chi Minh University of Technology\r\nAdvanced Programming Assignment";
            this.Crucial.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BigLogo
            // 
            this.BigLogo.Image = ((System.Drawing.Image)(resources.GetObject("BigLogo.Image")));
            this.BigLogo.Location = new System.Drawing.Point(972, 599);
            this.BigLogo.Name = "BigLogo";
            this.BigLogo.Size = new System.Drawing.Size(50, 50);
            this.BigLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BigLogo.TabIndex = 32;
            this.BigLogo.TabStop = false;
            // 
            // ManagerMainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 661);
            this.Controls.Add(this.BigLogo);
            this.Controls.Add(this.Crucial);
            this.Controls.Add(this.Background);
            this.Controls.Add(this.Rooms);
            this.Controls.Add(this.Students);
            this.Controls.Add(this.LogOut);
            this.Controls.Add(this.Information);
            this.Controls.Add(this.HomePic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ManagerMainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dormitory Management";
            ((System.ComponentModel.ISupportInitialize)(this.HomePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Background)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BigLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel LogOut;
        private System.Windows.Forms.Label Information;
        private System.Windows.Forms.PictureBox HomePic;
        private System.Windows.Forms.Button Students;
        private System.Windows.Forms.Button Rooms;
        private System.Windows.Forms.PictureBox Background;
        private System.Windows.Forms.Label Crucial;
        private System.Windows.Forms.PictureBox BigLogo;
    }
}