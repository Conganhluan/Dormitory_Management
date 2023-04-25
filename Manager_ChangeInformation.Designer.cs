namespace DormitoryManagment
{
    partial class ChangeInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeInformation));
            this.Return = new System.Windows.Forms.LinkLabel();
            this.Crucial = new System.Windows.Forms.Label();
            this.Information = new System.Windows.Forms.Label();
            this.HomePic = new System.Windows.Forms.PictureBox();
            this.LogOut = new System.Windows.Forms.LinkLabel();
            this.Send = new System.Windows.Forms.Button();
            this.EmailInput = new System.Windows.Forms.RichTextBox();
            this.NameInput = new System.Windows.Forms.RichTextBox();
            this.BigLogo = new System.Windows.Forms.PictureBox();
            this.Fields = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.HomePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BigLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // Return
            // 
            this.Return.AutoSize = true;
            this.Return.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Return.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.Return.Location = new System.Drawing.Point(16, 751);
            this.Return.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(170, 54);
            this.Return.TabIndex = 49;
            this.Return.TabStop = true;
            this.Return.Text = "Return";
            this.Return.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Return_LinkClicked);
            // 
            // Crucial
            // 
            this.Crucial.AutoSize = true;
            this.Crucial.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Crucial.Location = new System.Drawing.Point(413, 731);
            this.Crucial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Crucial.Name = "Crucial";
            this.Crucial.Size = new System.Drawing.Size(517, 72);
            this.Crucial.TabIndex = 46;
            this.Crucial.Text = "Ho Chi Minh University of Technology\r\nAdvanced Programming Assignment";
            this.Crucial.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Information
            // 
            this.Information.AutoSize = true;
            this.Information.BackColor = System.Drawing.Color.Turquoise;
            this.Information.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Information.Location = new System.Drawing.Point(91, 28);
            this.Information.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Information.Name = "Information";
            this.Information.Size = new System.Drawing.Size(565, 46);
            this.Information.TabIndex = 45;
            this.Information.Text = "Change Personal Information";
            // 
            // HomePic
            // 
            this.HomePic.BackColor = System.Drawing.Color.Turquoise;
            this.HomePic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.HomePic.Image = ((System.Drawing.Image)(resources.GetObject("HomePic.Image")));
            this.HomePic.Location = new System.Drawing.Point(16, 11);
            this.HomePic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HomePic.Name = "HomePic";
            this.HomePic.Size = new System.Drawing.Size(67, 62);
            this.HomePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HomePic.TabIndex = 44;
            this.HomePic.TabStop = false;
            // 
            // LogOut
            // 
            this.LogOut.AutoSize = true;
            this.LogOut.BackColor = System.Drawing.Color.Turquoise;
            this.LogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOut.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.LogOut.Location = new System.Drawing.Point(1172, 21);
            this.LogOut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(185, 54);
            this.LogOut.TabIndex = 43;
            this.LogOut.TabStop = true;
            this.LogOut.Text = "Log out";
            this.LogOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogOut_LinkClicked);
            // 
            // Send
            // 
            this.Send.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Send.Location = new System.Drawing.Point(351, 622);
            this.Send.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(663, 66);
            this.Send.TabIndex = 55;
            this.Send.Text = "Change the information";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // EmailInput
            // 
            this.EmailInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailInput.Location = new System.Drawing.Point(525, 494);
            this.EmailInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EmailInput.MaxLength = 50;
            this.EmailInput.Multiline = false;
            this.EmailInput.Name = "EmailInput";
            this.EmailInput.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.EmailInput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.EmailInput.Size = new System.Drawing.Size(724, 61);
            this.EmailInput.TabIndex = 54;
            this.EmailInput.Text = "adfads";
            // 
            // NameInput
            // 
            this.NameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameInput.Location = new System.Drawing.Point(525, 402);
            this.NameInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NameInput.MaxLength = 50;
            this.NameInput.Multiline = false;
            this.NameInput.Name = "NameInput";
            this.NameInput.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NameInput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.NameInput.Size = new System.Drawing.Size(724, 61);
            this.NameInput.TabIndex = 53;
            this.NameInput.Text = "adfads";
            // 
            // BigLogo
            // 
            this.BigLogo.Image = ((System.Drawing.Image)(resources.GetObject("BigLogo.Image")));
            this.BigLogo.Location = new System.Drawing.Point(547, 123);
            this.BigLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BigLogo.Name = "BigLogo";
            this.BigLogo.Size = new System.Drawing.Size(240, 222);
            this.BigLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BigLogo.TabIndex = 56;
            this.BigLogo.TabStop = false;
            // 
            // Fields
            // 
            this.Fields.AutoSize = true;
            this.Fields.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fields.Location = new System.Drawing.Point(285, 414);
            this.Fields.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Fields.Name = "Fields";
            this.Fields.Size = new System.Drawing.Size(205, 138);
            this.Fields.TabIndex = 57;
            this.Fields.Text = "Full name:\r\n\r\nEmail:";
            this.Fields.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Turquoise;
            this.panel2.Location = new System.Drawing.Point(-15, -10);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1405, 103);
            this.panel2.TabIndex = 91;
            // 
            // ChangeInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1379, 814);
            this.Controls.Add(this.Fields);
            this.Controls.Add(this.BigLogo);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.EmailInput);
            this.Controls.Add(this.NameInput);
            this.Controls.Add(this.Return);
            this.Controls.Add(this.Crucial);
            this.Controls.Add(this.Information);
            this.Controls.Add(this.HomePic);
            this.Controls.Add(this.LogOut);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ChangeInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dormitory Management";
            ((System.ComponentModel.ISupportInitialize)(this.HomePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BigLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel Return;
        private System.Windows.Forms.Label Crucial;
        private System.Windows.Forms.Label Information;
        private System.Windows.Forms.PictureBox HomePic;
        private System.Windows.Forms.LinkLabel LogOut;
        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.RichTextBox EmailInput;
        private System.Windows.Forms.RichTextBox NameInput;
        private System.Windows.Forms.PictureBox BigLogo;
        private System.Windows.Forms.Label Fields;
        private System.Windows.Forms.Panel panel2;
    }
}