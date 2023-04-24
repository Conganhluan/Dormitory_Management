﻿namespace DormitoryManagment
{
    partial class ViewInfoManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewInfoManager));
            this.Return = new System.Windows.Forms.LinkLabel();
            this.Crucial = new System.Windows.Forms.Label();
            this.Information = new System.Windows.Forms.Label();
            this.HomePic = new System.Windows.Forms.PictureBox();
            this.LogOut = new System.Windows.Forms.LinkLabel();
            this.Fields = new System.Windows.Forms.Label();
            this.ChangePass = new System.Windows.Forms.LinkLabel();
            this.SendReport = new System.Windows.Forms.LinkLabel();
            this.BigLogo = new System.Windows.Forms.PictureBox();
            this.Values = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.HomePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BigLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // Return
            // 
            this.Return.AutoSize = true;
            this.Return.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Return.Location = new System.Drawing.Point(12, 610);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(130, 42);
            this.Return.TabIndex = 48;
            this.Return.TabStop = true;
            this.Return.Text = "Return";
            this.Return.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Return_LinkClicked);
            // 
            // Crucial
            // 
            this.Crucial.AutoSize = true;
            this.Crucial.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Crucial.Location = new System.Drawing.Point(310, 594);
            this.Crucial.Name = "Crucial";
            this.Crucial.Size = new System.Drawing.Size(413, 58);
            this.Crucial.TabIndex = 46;
            this.Crucial.Text = "Ho Chi Minh University of Technology\r\nAdvanced Programming Assignment";
            this.Crucial.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Information
            // 
            this.Information.AutoSize = true;
            this.Information.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Information.Location = new System.Drawing.Point(68, 23);
            this.Information.Name = "Information";
            this.Information.Size = new System.Drawing.Size(313, 37);
            this.Information.TabIndex = 45;
            this.Information.Text = "Personal Information";
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
            this.HomePic.TabIndex = 44;
            this.HomePic.TabStop = false;
            // 
            // LogOut
            // 
            this.LogOut.AutoSize = true;
            this.LogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOut.Location = new System.Drawing.Point(879, 17);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(143, 42);
            this.LogOut.TabIndex = 43;
            this.LogOut.TabStop = true;
            this.LogOut.Text = "Log out";
            this.LogOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogOut_LinkClicked);
            // 
            // Fields
            // 
            this.Fields.AutoSize = true;
            this.Fields.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fields.Location = new System.Drawing.Point(214, 336);
            this.Fields.Name = "Fields";
            this.Fields.Size = new System.Drawing.Size(167, 111);
            this.Fields.TabIndex = 49;
            this.Fields.Text = "Full name:\r\n\r\nEmail:";
            this.Fields.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ChangePass
            // 
            this.ChangePass.AutoSize = true;
            this.ChangePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangePass.Location = new System.Drawing.Point(576, 518);
            this.ChangePass.Name = "ChangePass";
            this.ChangePass.Size = new System.Drawing.Size(321, 42);
            this.ChangePass.TabIndex = 51;
            this.ChangePass.TabStop = true;
            this.ChangePass.Text = "Change password";
            this.ChangePass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ChangePass_LinkClicked);
            // 
            // SendReport
            // 
            this.SendReport.AutoSize = true;
            this.SendReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendReport.Location = new System.Drawing.Point(121, 518);
            this.SendReport.Name = "SendReport";
            this.SendReport.Size = new System.Drawing.Size(343, 42);
            this.SendReport.TabIndex = 50;
            this.SendReport.TabStop = true;
            this.SendReport.Text = "Change information";
            this.SendReport.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SendReport_LinkClicked);
            // 
            // BigLogo
            // 
            this.BigLogo.Image = ((System.Drawing.Image)(resources.GetObject("BigLogo.Image")));
            this.BigLogo.Location = new System.Drawing.Point(410, 100);
            this.BigLogo.Name = "BigLogo";
            this.BigLogo.Size = new System.Drawing.Size(180, 180);
            this.BigLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BigLogo.TabIndex = 52;
            this.BigLogo.TabStop = false;
            // 
            // Values
            // 
            this.Values.AutoSize = true;
            this.Values.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Values.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Values.Location = new System.Drawing.Point(403, 336);
            this.Values.Name = "Values";
            this.Values.Size = new System.Drawing.Size(167, 111);
            this.Values.TabIndex = 53;
            this.Values.Text = "Full name:\r\n\r\nEmail:";
            this.Values.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ViewInfoManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 661);
            this.Controls.Add(this.Values);
            this.Controls.Add(this.BigLogo);
            this.Controls.Add(this.ChangePass);
            this.Controls.Add(this.SendReport);
            this.Controls.Add(this.Fields);
            this.Controls.Add(this.Return);
            this.Controls.Add(this.Crucial);
            this.Controls.Add(this.Information);
            this.Controls.Add(this.HomePic);
            this.Controls.Add(this.LogOut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewInfoManager";
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
        private System.Windows.Forms.Label Fields;
        private System.Windows.Forms.LinkLabel ChangePass;
        private System.Windows.Forms.LinkLabel SendReport;
        private System.Windows.Forms.PictureBox BigLogo;
        private System.Windows.Forms.Label Values;
    }
}