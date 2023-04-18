namespace DormitoryManagment
{
    partial class RemoveUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoveUsers));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.form = new System.Windows.Forms.Label();
            this.rmall = new System.Windows.Forms.LinkLabel();
            this.Title = new System.Windows.Forms.TextBox();
            this.RETURN = new System.Windows.Forms.LinkLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.crucialcmp = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.filepath = new System.Windows.Forms.TextBox();
            this.rmlsted = new System.Windows.Forms.LinkLabel();
            this.userdata = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userdata)).BeginInit();
            this.SuspendLayout();
            // 
            // form
            // 
            this.form.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.form.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.form.Location = new System.Drawing.Point(480, 217);
            this.form.Name = "form";
            this.form.Size = new System.Drawing.Size(412, 87);
            this.form.TabIndex = 11;
            this.form.Text = "The file needs to be a .csv file and\r\nhas to be formatted as: username_1,\r\nuserna" +
    "me_2, username_3, ...";
            // 
            // rmall
            // 
            this.rmall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rmall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rmall.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rmall.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.rmall.LinkColor = System.Drawing.Color.Black;
            this.rmall.Location = new System.Drawing.Point(542, 337);
            this.rmall.Name = "rmall";
            this.rmall.Size = new System.Drawing.Size(308, 39);
            this.rmall.TabIndex = 15;
            this.rmall.TabStop = true;
            this.rmall.Text = "Remove listed users";
            this.rmall.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rmall.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.rmall_LinkClicked);
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.SystemColors.Control;
            this.Title.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.Black;
            this.Title.Location = new System.Drawing.Point(20, 19);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(860, 46);
            this.Title.TabIndex = 14;
            this.Title.Text = "ADD NEW USERS FOR APPLICATION\r\n";
            this.Title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RETURN
            // 
            this.RETURN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RETURN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RETURN.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RETURN.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.RETURN.LinkColor = System.Drawing.Color.Black;
            this.RETURN.Location = new System.Drawing.Point(25, 540);
            this.RETURN.Name = "RETURN";
            this.RETURN.Size = new System.Drawing.Size(102, 39);
            this.RETURN.TabIndex = 13;
            this.RETURN.TabStop = true;
            this.RETURN.Text = "Return";
            this.RETURN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RETURN.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RETURN_LinkClicked);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(490, 128);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // crucialcmp
            // 
            this.crucialcmp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.crucialcmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crucialcmp.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.crucialcmp.Location = new System.Drawing.Point(328, 540);
            this.crucialcmp.Name = "crucialcmp";
            this.crucialcmp.Size = new System.Drawing.Size(244, 34);
            this.crucialcmp.TabIndex = 10;
            this.crucialcmp.Text = "Ho Chi Minh University of Technology\r\nAdvanced Programming Assignment";
            this.crucialcmp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(821, 532);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // filepath
            // 
            this.filepath.AcceptsTab = true;
            this.filepath.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.filepath.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.filepath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.filepath.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filepath.ForeColor = System.Drawing.SystemColors.GrayText;
            this.filepath.Location = new System.Drawing.Point(480, 129);
            this.filepath.Name = "filepath";
            this.filepath.Size = new System.Drawing.Size(391, 37);
            this.filepath.TabIndex = 11;
            this.filepath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.filepath.WordWrap = false;
            this.filepath.Enter += new System.EventHandler(this.filepath_Enter);
            this.filepath.Leave += new System.EventHandler(this.filepath_Leave);
            // 
            // rmlsted
            // 
            this.rmlsted.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rmlsted.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rmlsted.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rmlsted.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.rmlsted.LinkColor = System.Drawing.Color.Black;
            this.rmlsted.Location = new System.Drawing.Point(530, 406);
            this.rmlsted.Name = "rmlsted";
            this.rmlsted.Size = new System.Drawing.Size(319, 39);
            this.rmlsted.TabIndex = 16;
            this.rmlsted.TabStop = true;
            this.rmlsted.Text = "Remove chosen users";
            this.rmlsted.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userdata
            // 
            this.userdata.AllowUserToAddRows = false;
            this.userdata.AllowUserToDeleteRows = false;
            this.userdata.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.userdata.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.userdata.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.userdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userdata.Location = new System.Drawing.Point(16, 118);
            this.userdata.Name = "userdata";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.userdata.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.userdata.Size = new System.Drawing.Size(450, 360);
            this.userdata.TabIndex = 9;
            this.userdata.DataSource = DormitoryManagment.DataBase.GetDataSouce("SELECT Name,Username,Role FROM Users");
            // 
            // RemoveUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.userdata);
            this.Controls.Add(this.rmlsted);
            this.Controls.Add(this.form);
            this.Controls.Add(this.rmall);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.RETURN);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.crucialcmp);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.filepath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RemoveUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remove Users";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label form;
        private System.Windows.Forms.LinkLabel rmall;
        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.LinkLabel RETURN;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label crucialcmp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox filepath;
        private System.Windows.Forms.LinkLabel rmlsted;
        private System.Windows.Forms.DataGridView userdata;
    }
}