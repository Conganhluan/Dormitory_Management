namespace DormitoryManagment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.HomePic.BackColor = System.Drawing.Color.RoyalBlue;
            this.HomePic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.HomePic.Image = ((System.Drawing.Image)(resources.GetObject("HomePic.Image")));
            this.HomePic.Location = new System.Drawing.Point(16, 11);
            this.HomePic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HomePic.Name = "HomePic";
            this.HomePic.Size = new System.Drawing.Size(67, 62);
            this.HomePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HomePic.TabIndex = 36;
            this.HomePic.TabStop = false;
            this.HomePic.Click += new System.EventHandler(this.HomePic_Click);
            // 
            // Information
            // 
            this.Information.AutoSize = true;
            this.Information.BackColor = System.Drawing.Color.RoyalBlue;
            this.Information.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Information.ForeColor = System.Drawing.SystemColors.Window;
            this.Information.Location = new System.Drawing.Point(91, 28);
            this.Information.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Information.Name = "Information";
            this.Information.Size = new System.Drawing.Size(688, 46);
            this.Information.TabIndex = 37;
            this.Information.Text = "Application Admin - Building Adding";
            // 
            // LogOut
            // 
            this.LogOut.ActiveLinkColor = System.Drawing.Color.White;
            this.LogOut.AutoSize = true;
            this.LogOut.BackColor = System.Drawing.Color.RoyalBlue;
            this.LogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOut.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.LogOut.LinkColor = System.Drawing.Color.White;
            this.LogOut.Location = new System.Drawing.Point(1172, 21);
            this.LogOut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(185, 54);
            this.LogOut.TabIndex = 38;
            this.LogOut.TabStop = true;
            this.LogOut.Text = "Log out";
            this.LogOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogOut_LinkClicked);
            // 
            // AddUsers
            // 
            this.AddUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddUsers.Location = new System.Drawing.Point(16, 423);
            this.AddUsers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddUsers.Name = "AddUsers";
            this.AddUsers.Size = new System.Drawing.Size(396, 121);
            this.AddUsers.TabIndex = 47;
            this.AddUsers.Text = "Add a list\r\nof users";
            this.AddUsers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddUsers.UseVisualStyleBackColor = true;
            this.AddUsers.Click += new System.EventHandler(this.AddUsers_Click);
            // 
            // RemoveUsers
            // 
            this.RemoveUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveUsers.Location = new System.Drawing.Point(16, 551);
            this.RemoveUsers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RemoveUsers.Name = "RemoveUsers";
            this.RemoveUsers.Size = new System.Drawing.Size(396, 121);
            this.RemoveUsers.TabIndex = 46;
            this.RemoveUsers.Text = "Remove a \r\nlist of users";
            this.RemoveUsers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RemoveUsers.UseVisualStyleBackColor = true;
            this.RemoveUsers.Click += new System.EventHandler(this.RemoveUsers_Click);
            // 
            // ModifyBuilding
            // 
            this.ModifyBuilding.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyBuilding.Location = new System.Drawing.Point(16, 290);
            this.ModifyBuilding.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ModifyBuilding.Name = "ModifyBuilding";
            this.ModifyBuilding.Size = new System.Drawing.Size(396, 121);
            this.ModifyBuilding.TabIndex = 45;
            this.ModifyBuilding.Text = "Modify\r\nbuildings";
            this.ModifyBuilding.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ModifyBuilding.UseVisualStyleBackColor = true;
            this.ModifyBuilding.Click += new System.EventHandler(this.ModifyBuilding_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(16, 162);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(396, 121);
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Table.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.Table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Table.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Table.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Table.DefaultCellStyle = dataGridViewCellStyle6;
            this.Table.Location = new System.Drawing.Point(420, 219);
            this.Table.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Table.Name = "Table";
            this.Table.RowHeadersVisible = false;
            this.Table.RowHeadersWidth = 51;
            this.Table.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Table.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.Table.Size = new System.Drawing.Size(943, 412);
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
            this.NameBox.Location = new System.Drawing.Point(420, 117);
            this.NameBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NameBox.Name = "NameBox";
            this.NameBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NameBox.Size = new System.Drawing.Size(943, 95);
            this.NameBox.TabIndex = 50;
            this.NameBox.TabStop = false;
            this.NameBox.Text = "New building\'s information";
            // 
            // FloorsInput
            // 
            this.FloorsInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FloorsInput.Location = new System.Drawing.Point(816, 23);
            this.FloorsInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FloorsInput.Name = "FloorsInput";
            this.FloorsInput.Size = new System.Drawing.Size(119, 49);
            this.FloorsInput.TabIndex = 58;
            this.FloorsInput.ValueChanged += new System.EventHandler(this.FloorsInput_ValueChanged);
            // 
            // Floors_
            // 
            this.Floors_.AutoSize = true;
            this.Floors_.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Floors_.Location = new System.Drawing.Point(653, 28);
            this.Floors_.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Floors_.Name = "Floors_";
            this.Floors_.Size = new System.Drawing.Size(143, 46);
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
            this.GenderInput.Location = new System.Drawing.Point(479, 23);
            this.GenderInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GenderInput.Name = "GenderInput";
            this.GenderInput.Size = new System.Drawing.Size(165, 48);
            this.GenderInput.TabIndex = 53;
            this.GenderInput.SelectedIndexChanged += new System.EventHandler(this.GenderInput_SelectedIndexChanged);
            // 
            // Gender_
            // 
            this.Gender_.AutoSize = true;
            this.Gender_.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gender_.Location = new System.Drawing.Point(295, 25);
            this.Gender_.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Gender_.Name = "Gender_";
            this.Gender_.Size = new System.Drawing.Size(163, 46);
            this.Gender_.TabIndex = 52;
            this.Gender_.Text = "Gender:";
            this.Gender_.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Gender_.Click += new System.EventHandler(this.Gender__Click);
            // 
            // Name_
            // 
            this.Name_.AutoSize = true;
            this.Name_.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_.Location = new System.Drawing.Point(8, 28);
            this.Name_.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Name_.Name = "Name_";
            this.Name_.Size = new System.Drawing.Size(137, 46);
            this.Name_.TabIndex = 51;
            this.Name_.Text = "Name:";
            this.Name_.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NameInput
            // 
            this.NameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameInput.Location = new System.Drawing.Point(165, 23);
            this.NameInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NameInput.MaxLength = 15;
            this.NameInput.Multiline = false;
            this.NameInput.Name = "NameInput";
            this.NameInput.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NameInput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.NameInput.Size = new System.Drawing.Size(120, 50);
            this.NameInput.TabIndex = 3;
            this.NameInput.Text = "";
            // 
            // Background
            // 
            this.Background.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.Background.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Background.ErrorImage = null;
            this.Background.InitialImage = null;
            this.Background.Location = new System.Drawing.Point(16, 101);
            this.Background.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Background.Name = "Background";
            this.Background.Size = new System.Drawing.Size(1347, 610);
            this.Background.TabIndex = 48;
            this.Background.TabStop = false;
            // 
            // SaveNewBuilding
            // 
            this.SaveNewBuilding.BackColor = System.Drawing.Color.Aquamarine;
            this.SaveNewBuilding.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveNewBuilding.Location = new System.Drawing.Point(664, 639);
            this.SaveNewBuilding.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SaveNewBuilding.Name = "SaveNewBuilding";
            this.SaveNewBuilding.Size = new System.Drawing.Size(459, 55);
            this.SaveNewBuilding.TabIndex = 57;
            this.SaveNewBuilding.Text = "Save the new building";
            this.SaveNewBuilding.UseVisualStyleBackColor = false;
            this.SaveNewBuilding.Click += new System.EventHandler(this.SaveNewBuilding_Click);
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
            this.BuildingPic.TabIndex = 58;
            this.BuildingPic.TabStop = false;
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
            this.BuildingsPic.TabIndex = 59;
            this.BuildingsPic.TabStop = false;
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
            this.AddUsersPic.TabIndex = 60;
            this.AddUsersPic.TabStop = false;
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
            this.RemoveUserPic.TabIndex = 61;
            this.RemoveUserPic.TabStop = false;
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
            this.Crucial.TabIndex = 62;
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
            this.BigLogo.TabIndex = 63;
            this.BigLogo.TabStop = false;
            this.BigLogo.Click += new System.EventHandler(this.BigLogo_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Location = new System.Drawing.Point(-36, -54);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1429, 148);
            this.panel1.TabIndex = 64;
            // 
            // AddBuilding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1379, 814);
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
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddBuilding";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dormitory Management";
            this.Load += new System.EventHandler(this.AddBuilding_Load);
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
        private System.Windows.Forms.Panel panel1;
    }
}