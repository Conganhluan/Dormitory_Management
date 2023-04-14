namespace DormitoryManagment
{
    partial class ModifyBuilding
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifyBuilding));
            this.Table = new System.Windows.Forms.DataGridView();
            this.Crucial = new System.Windows.Forms.Label();
            this.Information = new System.Windows.Forms.Label();
            this.HomePic = new System.Windows.Forms.PictureBox();
            this.LogOut = new System.Windows.Forms.LinkLabel();
            this.Background = new System.Windows.Forms.PictureBox();
            this.BigLogo = new System.Windows.Forms.PictureBox();
            this.AddUsers = new System.Windows.Forms.Button();
            this.RemoveUsers = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.AddBuilding = new System.Windows.Forms.Button();
            this.dataSet = new DormitoryManagment.DataSet();
            this.buildingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buildingsTableAdapter = new DormitoryManagment.DataSetTableAdapters.BuildingsTableAdapter();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.NameInput = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.UsernameInput = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Background)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BigLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buildingsBindingSource)).BeginInit();
            this.Gender.SuspendLayout();
            this.NameInput.SuspendLayout();
            this.SuspendLayout();
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
            this.Table.AutoGenerateColumns = false;
            this.Table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Table.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn});
            this.Table.DataSource = this.buildingsBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Table.DefaultCellStyle = dataGridViewCellStyle6;
            this.Table.Location = new System.Drawing.Point(372, 132);
            this.Table.Name = "Table";
            this.Table.ReadOnly = true;
            this.Table.RowHeadersVisible = false;
            this.Table.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Table.Size = new System.Drawing.Size(321, 414);
            this.Table.TabIndex = 0;
            // 
            // Crucial
            // 
            this.Crucial.AutoSize = true;
            this.Crucial.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Crucial.Location = new System.Drawing.Point(310, 594);
            this.Crucial.Name = "Crucial";
            this.Crucial.Size = new System.Drawing.Size(413, 58);
            this.Crucial.TabIndex = 37;
            this.Crucial.Text = "Ho Chi Minh University of Technology\r\nAdvanced Programming Assignment";
            this.Crucial.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Information
            // 
            this.Information.AutoSize = true;
            this.Information.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Information.Location = new System.Drawing.Point(68, 23);
            this.Information.Name = "Information";
            this.Information.Size = new System.Drawing.Size(579, 37);
            this.Information.TabIndex = 36;
            this.Information.Text = "Application Admin - Buildings Modifying";
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
            this.HomePic.TabIndex = 35;
            this.HomePic.TabStop = false;
            // 
            // LogOut
            // 
            this.LogOut.AutoSize = true;
            this.LogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOut.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.LogOut.Location = new System.Drawing.Point(879, 17);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(143, 42);
            this.LogOut.TabIndex = 34;
            this.LogOut.TabStop = true;
            this.LogOut.Text = "Log out";
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
            this.Background.TabIndex = 39;
            this.Background.TabStop = false;
            // 
            // BigLogo
            // 
            this.BigLogo.Image = ((System.Drawing.Image)(resources.GetObject("BigLogo.Image")));
            this.BigLogo.Location = new System.Drawing.Point(972, 599);
            this.BigLogo.Name = "BigLogo";
            this.BigLogo.Size = new System.Drawing.Size(50, 50);
            this.BigLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BigLogo.TabIndex = 38;
            this.BigLogo.TabStop = false;
            // 
            // AddUsers
            // 
            this.AddUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddUsers.Location = new System.Drawing.Point(12, 344);
            this.AddUsers.Name = "AddUsers";
            this.AddUsers.Size = new System.Drawing.Size(297, 98);
            this.AddUsers.TabIndex = 43;
            this.AddUsers.Text = "Add a list\r\nof users";
            this.AddUsers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddUsers.UseVisualStyleBackColor = true;
            // 
            // RemoveUsers
            // 
            this.RemoveUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveUsers.Location = new System.Drawing.Point(12, 448);
            this.RemoveUsers.Name = "RemoveUsers";
            this.RemoveUsers.Size = new System.Drawing.Size(297, 98);
            this.RemoveUsers.TabIndex = 42;
            this.RemoveUsers.Text = "Remove a \r\nlist of users";
            this.RemoveUsers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RemoveUsers.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(297, 98);
            this.button1.TabIndex = 41;
            this.button1.Text = "Modify\r\nbuildings";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // AddBuilding
            // 
            this.AddBuilding.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBuilding.Location = new System.Drawing.Point(12, 132);
            this.AddBuilding.Name = "AddBuilding";
            this.AddBuilding.Size = new System.Drawing.Size(297, 98);
            this.AddBuilding.TabIndex = 40;
            this.AddBuilding.Text = "Add a new \r\nbuilding";
            this.AddBuilding.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddBuilding.UseVisualStyleBackColor = true;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buildingsBindingSource
            // 
            this.buildingsBindingSource.DataMember = "Buildings";
            this.buildingsBindingSource.DataSource = this.dataSet;
            // 
            // buildingsTableAdapter
            // 
            this.buildingsTableAdapter.ClearBeforeFill = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 146;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.ReadOnly = true;
            this.genderDataGridViewTextBoxColumn.Width = 174;
            // 
            // Gender
            // 
            this.Gender.Controls.Add(this.button2);
            this.Gender.Controls.Add(this.comboBox1);
            this.Gender.Location = new System.Drawing.Point(719, 481);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(283, 65);
            this.Gender.TabIndex = 44;
            this.Gender.TabStop = false;
            this.Gender.Text = "Filter by Gender";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Male",
            "Female",
            "All"});
            this.comboBox1.Location = new System.Drawing.Point(6, 18);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(128, 41);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "All";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(152, 17);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 41);
            this.button2.TabIndex = 1;
            this.button2.Text = "Filter";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // NameInput
            // 
            this.NameInput.Controls.Add(this.UsernameInput);
            this.NameInput.Controls.Add(this.button3);
            this.NameInput.Location = new System.Drawing.Point(719, 410);
            this.NameInput.Name = "NameInput";
            this.NameInput.Size = new System.Drawing.Size(283, 65);
            this.NameInput.TabIndex = 45;
            this.NameInput.TabStop = false;
            this.NameInput.Text = "Find by Name";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(152, 17);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 41);
            this.button3.TabIndex = 1;
            this.button3.Text = "Find";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // UsernameInput
            // 
            this.UsernameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameInput.Location = new System.Drawing.Point(6, 19);
            this.UsernameInput.MaxLength = 15;
            this.UsernameInput.Multiline = false;
            this.UsernameInput.Name = "UsernameInput";
            this.UsernameInput.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.UsernameInput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.UsernameInput.Size = new System.Drawing.Size(128, 41);
            this.UsernameInput.TabIndex = 3;
            this.UsernameInput.Text = "A10";
            // 
            // ModifyBuilding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 661);
            this.Controls.Add(this.NameInput);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.AddUsers);
            this.Controls.Add(this.RemoveUsers);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AddBuilding);
            this.Controls.Add(this.BigLogo);
            this.Controls.Add(this.Crucial);
            this.Controls.Add(this.Information);
            this.Controls.Add(this.HomePic);
            this.Controls.Add(this.LogOut);
            this.Controls.Add(this.Table);
            this.Controls.Add(this.Background);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModifyBuilding";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dormitory Management";
            this.Load += new System.EventHandler(this.ModifyBuilding_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Background)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BigLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buildingsBindingSource)).EndInit();
            this.Gender.ResumeLayout(false);
            this.NameInput.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Table;
        private System.Windows.Forms.Label Crucial;
        private System.Windows.Forms.Label Information;
        private System.Windows.Forms.PictureBox HomePic;
        private System.Windows.Forms.LinkLabel LogOut;
        private System.Windows.Forms.PictureBox Background;
        private System.Windows.Forms.PictureBox BigLogo;
        private System.Windows.Forms.Button AddUsers;
        private System.Windows.Forms.Button RemoveUsers;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button AddBuilding;
        private DataSet dataSet;
        private System.Windows.Forms.BindingSource buildingsBindingSource;
        private DataSetTableAdapters.BuildingsTableAdapter buildingsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox Gender;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox NameInput;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RichTextBox UsernameInput;
    }
}