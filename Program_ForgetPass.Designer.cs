namespace DormitoryManagment
{
    partial class ForgetPass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgetPass));
            this.Crucial = new System.Windows.Forms.Label();
            this.BigLogo = new System.Windows.Forms.PictureBox();
            this.EmailPic = new System.Windows.Forms.PictureBox();
            this.EmailInput = new System.Windows.Forms.RichTextBox();
            this.Information = new System.Windows.Forms.Label();
            this.Send = new System.Windows.Forms.Button();
            this.Sent = new System.Windows.Forms.Label();
            this.NotFound = new System.Windows.Forms.Label();
            this.Return = new System.Windows.Forms.LinkLabel();
            Title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BigLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailPic)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            Title.Dock = System.Windows.Forms.DockStyle.Top;
            Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Title.Location = new System.Drawing.Point(0, 0);
            Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            Title.Name = "Title";
            Title.Size = new System.Drawing.Size(1379, 90);
            Title.TabIndex = 9;
            Title.Text = "PASSWORD RECOVERY";
            Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Crucial
            // 
            this.Crucial.AutoSize = true;
            this.Crucial.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Crucial.Location = new System.Drawing.Point(413, 731);
            this.Crucial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Crucial.Name = "Crucial";
            this.Crucial.Size = new System.Drawing.Size(517, 72);
            this.Crucial.TabIndex = 11;
            this.Crucial.Text = "Ho Chi Minh University of Technology\r\nAdvanced Programming Assignment";
            this.Crucial.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BigLogo
            // 
            this.BigLogo.Image = ((System.Drawing.Image)(resources.GetObject("BigLogo.Image")));
            this.BigLogo.Location = new System.Drawing.Point(547, 123);
            this.BigLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BigLogo.Name = "BigLogo";
            this.BigLogo.Size = new System.Drawing.Size(240, 222);
            this.BigLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BigLogo.TabIndex = 10;
            this.BigLogo.TabStop = false;
            // 
            // EmailPic
            // 
            this.EmailPic.BackColor = System.Drawing.SystemColors.Window;
            this.EmailPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.EmailPic.Image = ((System.Drawing.Image)(resources.GetObject("EmailPic.Image")));
            this.EmailPic.Location = new System.Drawing.Point(289, 396);
            this.EmailPic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EmailPic.Name = "EmailPic";
            this.EmailPic.Size = new System.Drawing.Size(67, 62);
            this.EmailPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EmailPic.TabIndex = 13;
            this.EmailPic.TabStop = false;
            // 
            // EmailInput
            // 
            this.EmailInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailInput.Location = new System.Drawing.Point(364, 396);
            this.EmailInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EmailInput.MaxLength = 50;
            this.EmailInput.Multiline = false;
            this.EmailInput.Name = "EmailInput";
            this.EmailInput.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.EmailInput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.EmailInput.Size = new System.Drawing.Size(724, 61);
            this.EmailInput.TabIndex = 12;
            this.EmailInput.Text = "";
            // 
            // Information
            // 
            this.Information.AutoSize = true;
            this.Information.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Information.Location = new System.Drawing.Point(183, 496);
            this.Information.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Information.Name = "Information";
            this.Information.Size = new System.Drawing.Size(965, 92);
            this.Information.TabIndex = 14;
            this.Information.Text = "- We will send you an email to recover your password\r\n- If you don’t see it, rese" +
    "nd it and check your Spams!";
            this.Information.Click += new System.EventHandler(this.Information_Click);
            // 
            // Send
            // 
            this.Send.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Send.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Send.ForeColor = System.Drawing.SystemColors.Window;
            this.Send.Location = new System.Drawing.Point(584, 620);
            this.Send.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(187, 66);
            this.Send.TabIndex = 15;
            this.Send.Text = "SEND";
            this.Send.UseVisualStyleBackColor = false;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // Sent
            // 
            this.Sent.AutoSize = true;
            this.Sent.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sent.Location = new System.Drawing.Point(1099, 407);
            this.Sent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Sent.Name = "Sent";
            this.Sent.Size = new System.Drawing.Size(185, 39);
            this.Sent.TabIndex = 16;
            this.Sent.Text = "Email sent!";
            this.Sent.Visible = false;
            this.Sent.Click += new System.EventHandler(this.label1_Click);
            // 
            // NotFound
            // 
            this.NotFound.AutoSize = true;
            this.NotFound.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotFound.Location = new System.Drawing.Point(1099, 411);
            this.NotFound.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NotFound.Name = "NotFound";
            this.NotFound.Size = new System.Drawing.Size(253, 39);
            this.NotFound.TabIndex = 17;
            this.NotFound.Text = "Email not found";
            this.NotFound.Visible = false;
            // 
            // Return
            // 
            this.Return.AutoSize = true;
            this.Return.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Return.LinkColor = System.Drawing.SystemColors.MenuHighlight;
            this.Return.Location = new System.Drawing.Point(16, 751);
            this.Return.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(164, 54);
            this.Return.TabIndex = 18;
            this.Return.TabStop = true;
            this.Return.Text = "Return";
            this.Return.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Return_LinkClicked);
            // 
            // ForgetPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1379, 814);
            this.Controls.Add(this.Return);
            this.Controls.Add(this.NotFound);
            this.Controls.Add(this.Sent);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.Information);
            this.Controls.Add(this.EmailPic);
            this.Controls.Add(this.EmailInput);
            this.Controls.Add(this.Crucial);
            this.Controls.Add(this.BigLogo);
            this.Controls.Add(Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ForgetPass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dormitory Management";
            ((System.ComponentModel.ISupportInitialize)(this.BigLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmailPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Crucial;
        private System.Windows.Forms.PictureBox BigLogo;
        private System.Windows.Forms.PictureBox EmailPic;
        private System.Windows.Forms.RichTextBox EmailInput;
        private System.Windows.Forms.Label Information;
        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.Label Sent;
        private System.Windows.Forms.Label NotFound;
        private System.Windows.Forms.LinkLabel Return;
    }
}