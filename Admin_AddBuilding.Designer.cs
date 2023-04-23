﻿namespace DormitoryManagment
{
    partial class AddBuilding
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBuilding));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.HomePic = new System.Windows.Forms.PictureBox();
            this.Information = new System.Windows.Forms.Label();
            this.LogOut = new System.Windows.Forms.LinkLabel();
            this.AddUsers = new System.Windows.Forms.Button();
            this.RemoveUsers = new System.Windows.Forms.Button();
            this.ModifyBuilding = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Table = new System.Windows.Forms.DataGridView();
            this.NameBox = new System.Windows.Forms.GroupBox();
            this.FloorsInput = new System.Windows.Forms.NumericUpDown();
            this.Floors_ = new System.Windows.Forms.Label();
            this.GenderInput = new System.Windows.Forms.ComboBox();
            this.Gender_ = new System.Windows.Forms.Label();
            this.Name_ = new System.Windows.Forms.Label();
            this.NameInput = new System.Windows.Forms.RichTextBox();
            this.Background = new System.Windows.Forms.PictureBox();
            this.SaveNewBuilding = new System.Windows.Forms.Button();
            this.BuildingPic = new System.Windows.Forms.PictureBox();
            this.BuildingsPic = new System.Windows.Forms.PictureBox();
            this.AddUsersPic = new System.Windows.Forms.PictureBox();
            this.RemoveUserPic = new System.Windows.Forms.PictureBox();
            this.Crucial = new System.Windows.Forms.Label();
            this.BigLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.HomePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).BeginInit();
            this.NameBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FloorsInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Background)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BuildingPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BuildingsPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddUsersPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemoveUserPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BigLogo)).BeginInit();
            this.SuspendLayout();
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
            this.HomePic.TabIndex = 36;
            this.HomePic.TabStop = false;
            this.HomePic.Click += new System.EventHandler(this.HomePic_Click);
            // 
            // Information
            // 
            this.Information.AutoSize = true;
            this.Information.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Information.Location = new System.Drawing.Point(68, 23);
            this.Information.Name = "Information";
            this.Information.Size = new System.Drawing.Size(528, 37);
            this.Information.TabIndex = 37;
            this.Information.Text = "Application Admin - Building Adding";
            // 
            // LogOut
            // 
            this.LogOut.AutoSize = true;
            this.LogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOut.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.LogOut.Location = new System.Drawing.Point(879, 17);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(143, 42);
            this.LogOut.TabIndex = 38;
            this.LogOut.TabStop = true;
            this.LogOut.Text = "Log out";
            this.LogOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogOut_LinkClicked);
            // 
            // AddUsers
            // 
            this.AddUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddUsers.Location = new System.Drawing.Point(12, 344);
            this.AddUsers.Name = "AddUsers";
            this.AddUsers.Size = new System.Drawing.Size(297, 98);
            this.AddUsers.TabIndex = 47;
            this.AddUsers.Text = "Add a list\r\nof users";
            this.AddUsers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddUsers.UseVisualStyleBackColor = true;
            this.AddUsers.Click += new System.EventHandler(this.AddUsers_Click);
            // 
            // RemoveUsers
            // 
            this.RemoveUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveUsers.Location = new System.Drawing.Point(12, 448);
            this.RemoveUsers.Name = "RemoveUsers";
            this.RemoveUsers.Size = new System.Drawing.Size(297, 98);
            this.RemoveUsers.TabIndex = 46;
            this.RemoveUsers.Text = "Remove a \r\nlist of users";
            this.RemoveUsers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RemoveUsers.UseVisualStyleBackColor = true;
            this.RemoveUsers.Click += new System.EventHandler(this.RemoveUsers_Click);
            // 
            // ModifyBuilding
            // 
            this.ModifyBuilding.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyBuilding.Location = new System.Drawing.Point(12, 236);
            this.ModifyBuilding.Name = "ModifyBuilding";
            this.ModifyBuilding.Size = new System.Drawing.Size(297, 98);
            this.ModifyBuilding.TabIndex = 45;
            this.ModifyBuilding.Text = "Modify\r\nbuildings";
            this.ModifyBuilding.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ModifyBuilding.UseVisualStyleBackColor = true;
            this.ModifyBuilding.Click += new System.EventHandler(this.ModifyBuilding_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 132);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(297, 98);
            this.button2.TabIndex = 44;
            this.button2.Text = "Add a new \r\nbuilding";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Table
            // 
            this.Table.AllowUserToAddRows = false;
            this.Table.AllowUserToDeleteRows = false;
            this.Table.AllowUserToResizeColumns = false;
            this.Table.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Table.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Table.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Table.DefaultCellStyle = dataGridViewCellStyle3;
            this.Table.Location = new System.Drawing.Point(315, 178);
            this.Table.Name = "Table";
            this.Table.RowHeadersVisible = false;
            this.Table.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Table.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.Table.Size = new System.Drawing.Size(707, 335);
            this.Table.TabIndex = 49;
            this.Table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Table_CellContentClick);
            this.Table.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.Table_CellEndEdit);
            this.Table.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.Table_RowPostPaint);
            // 
            // NameBox
            // 
            this.NameBox.Controls.Add(this.FloorsInput);
            this.NameBox.Controls.Add(this.Floors_);
            this.NameBox.Controls.Add(this.GenderInput);
            this.NameBox.Controls.Add(this.Gender_);
            this.NameBox.Controls.Add(this.Name_);
            this.NameBox.Controls.Add(this.NameInput);
            this.NameBox.Location = new System.Drawing.Point(315, 95);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(707, 77);
            this.NameBox.TabIndex = 50;
            this.NameBox.TabStop = false;
            this.NameBox.Text = "New building\'s information";
            // 
            // FloorsInput
            // 
            this.FloorsInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FloorsInput.Location = new System.Drawing.Point(612, 19);
            this.FloorsInput.Name = "FloorsInput";
            this.FloorsInput.Size = new System.Drawing.Size(89, 40);
            this.FloorsInput.TabIndex = 58;
            this.FloorsInput.ValueChanged += new System.EventHandler(this.FloorsInput_ValueChanged);
            // 
            // Floors_
            // 
            this.Floors_.AutoSize = true;
            this.Floors_.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Floors_.Location = new System.Drawing.Point(490, 23);
            this.Floors_.Name = "Floors_";
            this.Floors_.Size = new System.Drawing.Size(116, 37);
            this.Floors_.TabIndex = 54;
            this.Floors_.Text = "Floors:";
            this.Floors_.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // GenderInput
            // 
            this.GenderInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenderInput.FormattingEnabled = true;
            this.GenderInput.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.GenderInput.Location = new System.Drawing.Point(359, 19);
            this.GenderInput.Name = "GenderInput";
            this.GenderInput.Size = new System.Drawing.Size(125, 41);
            this.GenderInput.TabIndex = 53;
            this.GenderInput.SelectedIndexChanged += new System.EventHandler(this.GenderInput_SelectedIndexChanged);
            // 
            // Gender_
            // 
            this.Gender_.AutoSize = true;
            this.Gender_.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gender_.Location = new System.Drawing.Point(221, 20);
            this.Gender_.Name = "Gender_";
            this.Gender_.Size = new System.Drawing.Size(132, 37);
            this.Gender_.TabIndex = 52;
            this.Gender_.Text = "Gender:";
            this.Gender_.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Gender_.Click += new System.EventHandler(this.Gender__Click);
            // 
            // Name_
            // 
            this.Name_.AutoSize = true;
            this.Name_.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_.Location = new System.Drawing.Point(6, 23);
            this.Name_.Name = "Name_";
            this.Name_.Size = new System.Drawing.Size(112, 37);
            this.Name_.TabIndex = 51;
            this.Name_.Text = "Name:";
            this.Name_.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NameInput
            // 
            this.NameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameInput.Location = new System.Drawing.Point(124, 19);
            this.NameInput.MaxLength = 15;
            this.NameInput.Multiline = false;
            this.NameInput.Name = "NameInput";
            this.NameInput.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NameInput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.NameInput.Size = new System.Drawing.Size(91, 41);
            this.NameInput.TabIndex = 3;
            this.NameInput.Text = "";
            // 
            // Background
            // 
            this.Background.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Background.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Background.ErrorImage = null;
            this.Background.InitialImage = null;
            this.Background.Location = new System.Drawing.Point(12, 82);
            this.Background.Name = "Background";
            this.Background.Size = new System.Drawing.Size(1010, 496);
            this.Background.TabIndex = 48;
            this.Background.TabStop = false;
            // 
            // SaveNewBuilding
            // 
            this.SaveNewBuilding.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveNewBuilding.Location = new System.Drawing.Point(498, 519);
            this.SaveNewBuilding.Name = "SaveNewBuilding";
            this.SaveNewBuilding.Size = new System.Drawing.Size(344, 45);
            this.SaveNewBuilding.TabIndex = 57;
            this.SaveNewBuilding.Text = "Save the new building";
            this.SaveNewBuilding.UseVisualStyleBackColor = true;
            this.SaveNewBuilding.Click += new System.EventHandler(this.SaveNewBuilding_Click);
            // 
            // BuildingPic
            // 
            this.BuildingPic.BackColor = System.Drawing.SystemColors.Control;
            this.BuildingPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BuildingPic.Image = ((System.Drawing.Image)(resources.GetObject("BuildingPic.Image")));
            this.BuildingPic.Location = new System.Drawing.Point(24, 146);
            this.BuildingPic.Name = "BuildingPic";
            this.BuildingPic.Size = new System.Drawing.Size(72, 72);
            this.BuildingPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BuildingPic.TabIndex = 58;
            this.BuildingPic.TabStop = false;
            // 
            // BuildingsPic
            // 
            this.BuildingsPic.BackColor = System.Drawing.SystemColors.Control;
            this.BuildingsPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BuildingsPic.Image = ((System.Drawing.Image)(resources.GetObject("BuildingsPic.Image")));
            this.BuildingsPic.Location = new System.Drawing.Point(24, 250);
            this.BuildingsPic.Name = "BuildingsPic";
            this.BuildingsPic.Size = new System.Drawing.Size(72, 72);
            this.BuildingsPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BuildingsPic.TabIndex = 59;
            this.BuildingsPic.TabStop = false;
            // 
            // AddUsersPic
            // 
            this.AddUsersPic.BackColor = System.Drawing.SystemColors.Control;
            this.AddUsersPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AddUsersPic.Image = ((System.Drawing.Image)(resources.GetObject("AddUsersPic.Image")));
            this.AddUsersPic.Location = new System.Drawing.Point(24, 359);
            this.AddUsersPic.Name = "AddUsersPic";
            this.AddUsersPic.Size = new System.Drawing.Size(72, 72);
            this.AddUsersPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AddUsersPic.TabIndex = 60;
            this.AddUsersPic.TabStop = false;
            // 
            // RemoveUserPic
            // 
            this.RemoveUserPic.BackColor = System.Drawing.SystemColors.Control;
            this.RemoveUserPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.RemoveUserPic.Image = ((System.Drawing.Image)(resources.GetObject("RemoveUserPic.Image")));
            this.RemoveUserPic.Location = new System.Drawing.Point(24, 462);
            this.RemoveUserPic.Name = "RemoveUserPic";
            this.RemoveUserPic.Size = new System.Drawing.Size(72, 72);
            this.RemoveUserPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RemoveUserPic.TabIndex = 61;
            this.RemoveUserPic.TabStop = false;
            // 
            // Crucial
            // 
            this.Crucial.AutoSize = true;
            this.Crucial.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Crucial.Location = new System.Drawing.Point(310, 594);
            this.Crucial.Name = "Crucial";
            this.Crucial.Size = new System.Drawing.Size(413, 58);
            this.Crucial.TabIndex = 62;
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
            this.BigLogo.TabIndex = 63;
            this.BigLogo.TabStop = false;
            // 
            // AddBuilding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 661);
            this.Controls.Add(this.BigLogo);
            this.Controls.Add(this.Crucial);
            this.Controls.Add(this.RemoveUserPic);
            this.Controls.Add(this.AddUsersPic);
            this.Controls.Add(this.BuildingsPic);
            this.Controls.Add(this.BuildingPic);
            this.Controls.Add(this.SaveNewBuilding);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.Table);
            this.Controls.Add(this.AddUsers);
            this.Controls.Add(this.RemoveUsers);
            this.Controls.Add(this.ModifyBuilding);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.LogOut);
            this.Controls.Add(this.Information);
            this.Controls.Add(this.HomePic);
            this.Controls.Add(this.Background);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddBuilding";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dormitory Management";
            ((System.ComponentModel.ISupportInitialize)(this.HomePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).EndInit();
            this.NameBox.ResumeLayout(false);
            this.NameBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FloorsInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Background)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BuildingPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BuildingsPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddUsersPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemoveUserPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BigLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox HomePic;
        private System.Windows.Forms.Label Information;
        private System.Windows.Forms.LinkLabel LogOut;
        private System.Windows.Forms.Button AddUsers;
        private System.Windows.Forms.Button RemoveUsers;
        private System.Windows.Forms.Button ModifyBuilding;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView Table;
        private System.Windows.Forms.GroupBox NameBox;
        private System.Windows.Forms.Label Gender_;
        private System.Windows.Forms.Label Name_;
        private System.Windows.Forms.RichTextBox NameInput;
        private System.Windows.Forms.PictureBox Background;
        private System.Windows.Forms.ComboBox GenderInput;
        private System.Windows.Forms.Button SaveNewBuilding;
        private System.Windows.Forms.NumericUpDown FloorsInput;
        private System.Windows.Forms.Label Floors_;
        private System.Windows.Forms.PictureBox BuildingPic;
        private System.Windows.Forms.PictureBox BuildingsPic;
        private System.Windows.Forms.PictureBox AddUsersPic;
        private System.Windows.Forms.PictureBox RemoveUserPic;
        private System.Windows.Forms.Label Crucial;
        private System.Windows.Forms.PictureBox BigLogo;
    }
}