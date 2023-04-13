namespace DormitoryManagment
{
    partial class ChangePass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePass));
            this.OldPassword = new System.Windows.Forms.RichTextBox();
            this.BigLogo = new System.Windows.Forms.PictureBox();
            this.NewPassword = new System.Windows.Forms.RichTextBox();
            this.ConfirmPassword = new System.Windows.Forms.RichTextBox();
            this.Crucial = new System.Windows.Forms.Label();
            this.Return = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Confirm = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.BigLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // OldPassword
            // 
            this.OldPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OldPassword.Location = new System.Drawing.Point(410, 266);
            this.OldPassword.MaxLength = 20;
            this.OldPassword.Multiline = false;
            this.OldPassword.Name = "OldPassword";
            this.OldPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.OldPassword.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.OldPassword.Size = new System.Drawing.Size(544, 50);
            this.OldPassword.TabIndex = 3;
            this.OldPassword.Text = "";
            // 
            // BigLogo
            // 
            this.BigLogo.Image = ((System.Drawing.Image)(resources.GetObject("BigLogo.Image")));
            this.BigLogo.Location = new System.Drawing.Point(410, 40);
            this.BigLogo.Name = "BigLogo";
            this.BigLogo.Size = new System.Drawing.Size(180, 180);
            this.BigLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BigLogo.TabIndex = 4;
            this.BigLogo.TabStop = false;
            // 
            // NewPassword
            // 
            this.NewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewPassword.Location = new System.Drawing.Point(410, 350);
            this.NewPassword.MaxLength = 20;
            this.NewPassword.Multiline = false;
            this.NewPassword.Name = "NewPassword";
            this.NewPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NewPassword.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.NewPassword.Size = new System.Drawing.Size(544, 50);
            this.NewPassword.TabIndex = 5;
            this.NewPassword.Text = "";
            // 
            // ConfirmPassword
            // 
            this.ConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmPassword.Location = new System.Drawing.Point(410, 426);
            this.ConfirmPassword.MaxLength = 20;
            this.ConfirmPassword.Multiline = false;
            this.ConfirmPassword.Name = "ConfirmPassword";
            this.ConfirmPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ConfirmPassword.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.ConfirmPassword.Size = new System.Drawing.Size(544, 50);
            this.ConfirmPassword.TabIndex = 6;
            this.ConfirmPassword.Text = "";
            // 
            // Crucial
            // 
            this.Crucial.AutoSize = true;
            this.Crucial.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Crucial.Location = new System.Drawing.Point(310, 594);
            this.Crucial.Name = "Crucial";
            this.Crucial.Size = new System.Drawing.Size(413, 58);
            this.Crucial.TabIndex = 10;
            this.Crucial.Text = "Ho Chi Minh University of Technology\r\nAdvanced Programming Assignment";
            this.Crucial.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Return
            // 
            this.Return.AutoSize = true;
            this.Return.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Return.Location = new System.Drawing.Point(12, 610);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(130, 42);
            this.Return.TabIndex = 19;
            this.Return.TabStop = true;
            this.Return.Text = "Return";
            this.Return.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Return_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(110, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 37);
            this.label1.TabIndex = 20;
            this.label1.Text = "Your old password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(95, 359);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(309, 37);
            this.label2.TabIndex = 21;
            this.label2.Text = "Your new password:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 435);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(353, 37);
            this.label3.TabIndex = 22;
            this.label3.Text = "Confirm new password:";
            // 
            // Confirm
            // 
            this.Confirm.AutoSize = true;
            this.Confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Confirm.Location = new System.Drawing.Point(262, 509);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(493, 42);
            this.Confirm.TabIndex = 23;
            this.Confirm.TabStop = true;
            this.Confirm.Text = "Confirm to change password";
            this.Confirm.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Confirm_LinkClicked);
            // 
            // ChangePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 661);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Return);
            this.Controls.Add(this.Crucial);
            this.Controls.Add(this.ConfirmPassword);
            this.Controls.Add(this.NewPassword);
            this.Controls.Add(this.BigLogo);
            this.Controls.Add(this.OldPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChangePass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dormitory Management";
            ((System.ComponentModel.ISupportInitialize)(this.BigLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox OldPassword;
        private System.Windows.Forms.PictureBox BigLogo;
        private System.Windows.Forms.RichTextBox NewPassword;
        private System.Windows.Forms.RichTextBox ConfirmPassword;
        private System.Windows.Forms.Label Crucial;
        private System.Windows.Forms.LinkLabel Return;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel Confirm;
    }
}