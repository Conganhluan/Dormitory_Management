namespace DormitoryManagment
{
    partial class AddUsers
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
            System.Windows.Forms.Label classing;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUsers));
            this.crucialcmp = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.RETURN = new System.Windows.Forms.LinkLabel();
            this.filepath = new System.Windows.Forms.TextBox();
            this.Title = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.LinkLabel();
            this.form = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.studentrb = new System.Windows.Forms.RadioButton();
            this.managerrb = new System.Windows.Forms.RadioButton();
            classing = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // classing
            // 
            classing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            classing.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            classing.Location = new System.Drawing.Point(70, 404);
            classing.Name = "classing";
            classing.Size = new System.Drawing.Size(150, 39);
            classing.TabIndex = 6;
            classing.Text = "These are:";
            classing.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // crucialcmp
            // 
            this.crucialcmp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.crucialcmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crucialcmp.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.crucialcmp.Location = new System.Drawing.Point(328, 544);
            this.crucialcmp.Name = "crucialcmp";
            this.crucialcmp.Size = new System.Drawing.Size(244, 34);
            this.crucialcmp.TabIndex = 1;
            this.crucialcmp.Text = "Ho Chi Minh University of Technology\r\nAdvanced Programming Assignment";
            this.crucialcmp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(821, 536);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(70, 145);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // RETURN
            // 
            this.RETURN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RETURN.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RETURN.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.RETURN.LinkColor = System.Drawing.Color.Black;
            this.RETURN.Location = new System.Drawing.Point(25, 544);
            this.RETURN.Name = "RETURN";
            this.RETURN.Size = new System.Drawing.Size(102, 39);
            this.RETURN.TabIndex = 3;
            this.RETURN.TabStop = true;
            this.RETURN.Text = "Return";
            this.RETURN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RETURN.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RETURN_LinkClicked);
            // 
            // filepath
            // 
            this.filepath.AcceptsTab = true;
            this.filepath.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.filepath.BackColor = System.Drawing.SystemColors.Menu;
            this.filepath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.filepath.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filepath.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.filepath.Location = new System.Drawing.Point(50, 139);
            this.filepath.Name = "filepath";
            this.filepath.Size = new System.Drawing.Size(800, 50);
            this.filepath.TabIndex = 0;
            this.filepath.Text = "Path/to/file.csv";
            this.filepath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.filepath.WordWrap = false;
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Title.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.Black;
            this.Title.Location = new System.Drawing.Point(20, 23);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(860, 46);
            this.Title.TabIndex = 4;
            this.Title.Text = "ADD NEW USERS FOR APPLICATION\r\n";
            this.Title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // save
            // 
            this.save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.save.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.save.LinkColor = System.Drawing.Color.Black;
            this.save.Location = new System.Drawing.Point(289, 485);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(321, 39);
            this.save.TabIndex = 5;
            this.save.TabStop = true;
            this.save.Text = "SAVE THE CHANGES\r\n";
            this.save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.save.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.save_LinkClicked);
            // 
            // form
            // 
            this.form.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.form.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.form.Location = new System.Drawing.Point(76, 216);
            this.form.Name = "form";
            this.form.Size = new System.Drawing.Size(642, 156);
            this.form.TabIndex = 2;
            this.form.Text = "The file\'s format must be:\n            username_1, name_1, email_1,\n            u" +
    "sername_2, name_2, email_2,\n            username_3, name_3, email_3,...";
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.studentrb);
            this.panel1.Controls.Add(this.managerrb);
            this.panel1.Location = new System.Drawing.Point(218, 404);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(513, 72);
            this.panel1.TabIndex = 7;
            // 
            // studentrb
            // 
            this.studentrb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.studentrb.AutoSize = true;
            this.studentrb.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.studentrb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentrb.Location = new System.Drawing.Point(305, 2);
            this.studentrb.Name = "studentrb";
            this.studentrb.Size = new System.Drawing.Size(140, 35);
            this.studentrb.TabIndex = 3;
            this.studentrb.Text = "Students";
            this.studentrb.UseVisualStyleBackColor = true;
            // 
            // managerrb
            // 
            this.managerrb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.managerrb.AutoSize = true;
            this.managerrb.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.managerrb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managerrb.Location = new System.Drawing.Point(58, 2);
            this.managerrb.Name = "managerrb";
            this.managerrb.Size = new System.Drawing.Size(152, 35);
            this.managerrb.TabIndex = 2;
            this.managerrb.Text = "Managers";
            this.managerrb.UseVisualStyleBackColor = true;
            // 
            // AddUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.panel1);
            this.Controls.Add(classing);
            this.Controls.Add(this.form);
            this.Controls.Add(this.save);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.RETURN);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.crucialcmp);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.filepath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddUsers";
            this.Text = "Dormitory Management";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label crucialcmp;
        private System.Windows.Forms.LinkLabel RETURN;
        private System.Windows.Forms.TextBox filepath;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.LinkLabel save;
        private System.Windows.Forms.Label form;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton managerrb;
        private System.Windows.Forms.RadioButton studentrb;
    }
}