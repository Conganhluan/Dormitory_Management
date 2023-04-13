namespace DormitoryManagment
{
    partial class StartScreen
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
            System.Windows.Forms.Label Title;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartScreen));
            this.BigLogo = new System.Windows.Forms.PictureBox();
            this.UsernameInput = new System.Windows.Forms.RichTextBox();
            this.PasswordInput = new System.Windows.Forms.RichTextBox();
            this.UsernamePic = new System.Windows.Forms.PictureBox();
            this.PasswordPic = new System.Windows.Forms.PictureBox();
            this.Submit = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.Crucial = new System.Windows.Forms.Label();
            Title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BigLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsernamePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Submit)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            Title.Dock = System.Windows.Forms.DockStyle.Top;
            Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Title.Location = new System.Drawing.Point(0, 0);
            Title.Name = "Title";
            Title.Size = new System.Drawing.Size(1034, 73);
            Title.TabIndex = 0;
            Title.Text = "DORMITORY MANAGEMENT";
            Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            Title.Click += new System.EventHandler(this.label1_Click);
            // 
            // BigLogo
            // 
            this.BigLogo.Image = ((System.Drawing.Image)(resources.GetObject("BigLogo.Image")));
            this.BigLogo.Location = new System.Drawing.Point(410, 100);
            this.BigLogo.Name = "BigLogo";
            this.BigLogo.Size = new System.Drawing.Size(180, 180);
            this.BigLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BigLogo.TabIndex = 1;
            this.BigLogo.TabStop = false;
            // 
            // UsernameInput
            // 
            this.UsernameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameInput.Location = new System.Drawing.Point(262, 320);
            this.UsernameInput.Multiline = false;
            this.UsernameInput.Name = "UsernameInput";
            this.UsernameInput.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.UsernameInput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.UsernameInput.Size = new System.Drawing.Size(544, 50);
            this.UsernameInput.TabIndex = 2;
            this.UsernameInput.Text = "";
            this.UsernameInput.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // PasswordInput
            // 
            this.PasswordInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordInput.Location = new System.Drawing.Point(262, 408);
            this.PasswordInput.Multiline = false;
            this.PasswordInput.Name = "PasswordInput";
            this.PasswordInput.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PasswordInput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.PasswordInput.Size = new System.Drawing.Size(544, 50);
            this.PasswordInput.TabIndex = 3;
            this.PasswordInput.Text = "";
            // 
            // UsernamePic
            // 
            this.UsernamePic.BackColor = System.Drawing.SystemColors.Control;
            this.UsernamePic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.UsernamePic.Image = ((System.Drawing.Image)(resources.GetObject("UsernamePic.Image")));
            this.UsernamePic.Location = new System.Drawing.Point(206, 320);
            this.UsernamePic.Name = "UsernamePic";
            this.UsernamePic.Size = new System.Drawing.Size(50, 50);
            this.UsernamePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UsernamePic.TabIndex = 4;
            this.UsernamePic.TabStop = false;
            // 
            // PasswordPic
            // 
            this.PasswordPic.BackColor = System.Drawing.SystemColors.Control;
            this.PasswordPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PasswordPic.Image = ((System.Drawing.Image)(resources.GetObject("PasswordPic.Image")));
            this.PasswordPic.Location = new System.Drawing.Point(206, 408);
            this.PasswordPic.Name = "PasswordPic";
            this.PasswordPic.Size = new System.Drawing.Size(50, 50);
            this.PasswordPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PasswordPic.TabIndex = 5;
            this.PasswordPic.TabStop = false;
            // 
            // Submit
            // 
            this.Submit.Image = ((System.Drawing.Image)(resources.GetObject("Submit.Image")));
            this.Submit.Location = new System.Drawing.Point(829, 350);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(70, 70);
            this.Submit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Submit.TabIndex = 6;
            this.Submit.TabStop = false;
            this.Submit.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(325, 478);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(401, 42);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Forget your password?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Crucial
            // 
            this.Crucial.AutoSize = true;
            this.Crucial.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Crucial.Location = new System.Drawing.Point(310, 594);
            this.Crucial.Name = "Crucial";
            this.Crucial.Size = new System.Drawing.Size(413, 58);
            this.Crucial.TabIndex = 8;
            this.Crucial.Text = "Ho Chi Minh University of Technology\r\nAdvanced Programming Assignment";
            this.Crucial.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Crucial.Click += new System.EventHandler(this.Crucial_Click);
            // 
            // StartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1034, 661);
            this.Controls.Add(this.Crucial);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.PasswordPic);
            this.Controls.Add(this.UsernamePic);
            this.Controls.Add(this.PasswordInput);
            this.Controls.Add(this.UsernameInput);
            this.Controls.Add(this.BigLogo);
            this.Controls.Add(Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StartScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dormitory Management";
            this.Load += new System.EventHandler(this.StartScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BigLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsernamePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Submit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox BigLogo;
        private System.Windows.Forms.RichTextBox UsernameInput;
        private System.Windows.Forms.RichTextBox PasswordInput;
        private System.Windows.Forms.PictureBox UsernamePic;
        private System.Windows.Forms.PictureBox PasswordPic;
        private System.Windows.Forms.PictureBox Submit;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label Crucial;
    }
}