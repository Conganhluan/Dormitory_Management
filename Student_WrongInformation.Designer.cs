namespace DormitoryManagment
{
    partial class WrongInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WrongInformation));
            this.Return = new System.Windows.Forms.LinkLabel();
            this.Fields = new System.Windows.Forms.Label();
            this.BigLogo = new System.Windows.Forms.PictureBox();
            this.Crucial = new System.Windows.Forms.Label();
            this.Information = new System.Windows.Forms.Label();
            this.HomePic = new System.Windows.Forms.PictureBox();
            this.LogOut = new System.Windows.Forms.LinkLabel();
            this.CitizenIDInput = new System.Windows.Forms.RichTextBox();
            this.PhoneInput = new System.Windows.Forms.RichTextBox();
            this.VehicleInput = new System.Windows.Forms.RichTextBox();
            this.HomeAddressInput = new System.Windows.Forms.RichTextBox();
            this.Send = new System.Windows.Forms.Button();
            this.BirthdateInput = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.BigLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomePic)).BeginInit();
            this.SuspendLayout();
            // 
            // Return
            // 
            this.Return.AutoSize = true;
            this.Return.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Return.Location = new System.Drawing.Point(16, 751);
            this.Return.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(164, 54);
            this.Return.TabIndex = 49;
            this.Return.TabStop = true;
            this.Return.Text = "Return";
            this.Return.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Return_LinkClicked);
            // 
            // Fields
            // 
            this.Fields.AutoSize = true;
            this.Fields.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fields.Location = new System.Drawing.Point(16, 112);
            this.Fields.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Fields.Name = "Fields";
            this.Fields.Size = new System.Drawing.Size(473, 486);
            this.Fields.TabIndex = 48;
            this.Fields.Text = "Date of birth:\r\n\r\nCitizen ID:\r\n\r\nPhone number:\r\n\r\nVehicle plate number:\r\n\r\nHome a" +
    "ddress:\r\n";
            this.Fields.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BigLogo
            // 
            this.BigLogo.Image = ((System.Drawing.Image)(resources.GetObject("BigLogo.Image")));
            this.BigLogo.Location = new System.Drawing.Point(1296, 737);
            this.BigLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BigLogo.Name = "BigLogo";
            this.BigLogo.Size = new System.Drawing.Size(67, 62);
            this.BigLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BigLogo.TabIndex = 47;
            this.BigLogo.TabStop = false;
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
            this.Information.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Information.Location = new System.Drawing.Point(91, 28);
            this.Information.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Information.Name = "Information";
            this.Information.Size = new System.Drawing.Size(538, 46);
            this.Information.TabIndex = 45;
            this.Information.Text = "Change Personal Information";
            // 
            // HomePic
            // 
            this.HomePic.BackColor = System.Drawing.SystemColors.Window;
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
            this.LogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOut.Location = new System.Drawing.Point(1172, 21);
            this.LogOut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(178, 54);
            this.LogOut.TabIndex = 43;
            this.LogOut.TabStop = true;
            this.LogOut.Text = "Log out";
            this.LogOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogOut_LinkClicked);
            // 
            // CitizenIDInput
            // 
            this.CitizenIDInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CitizenIDInput.Location = new System.Drawing.Point(528, 212);
            this.CitizenIDInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CitizenIDInput.MaxLength = 15;
            this.CitizenIDInput.Multiline = false;
            this.CitizenIDInput.Name = "CitizenIDInput";
            this.CitizenIDInput.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CitizenIDInput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.CitizenIDInput.Size = new System.Drawing.Size(724, 61);
            this.CitizenIDInput.TabIndex = 51;
            this.CitizenIDInput.Text = "adfads";
            // 
            // PhoneInput
            // 
            this.PhoneInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneInput.Location = new System.Drawing.Point(528, 315);
            this.PhoneInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PhoneInput.MaxLength = 15;
            this.PhoneInput.Multiline = false;
            this.PhoneInput.Name = "PhoneInput";
            this.PhoneInput.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PhoneInput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.PhoneInput.Size = new System.Drawing.Size(724, 61);
            this.PhoneInput.TabIndex = 52;
            this.PhoneInput.Text = "adfads";
            // 
            // VehicleInput
            // 
            this.VehicleInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VehicleInput.Location = new System.Drawing.Point(528, 418);
            this.VehicleInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.VehicleInput.MaxLength = 15;
            this.VehicleInput.Multiline = false;
            this.VehicleInput.Name = "VehicleInput";
            this.VehicleInput.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.VehicleInput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.VehicleInput.Size = new System.Drawing.Size(724, 61);
            this.VehicleInput.TabIndex = 53;
            this.VehicleInput.Text = "adfads";
            // 
            // HomeAddressInput
            // 
            this.HomeAddressInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeAddressInput.Location = new System.Drawing.Point(528, 524);
            this.HomeAddressInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.HomeAddressInput.MaxLength = 15;
            this.HomeAddressInput.Multiline = false;
            this.HomeAddressInput.Name = "HomeAddressInput";
            this.HomeAddressInput.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.HomeAddressInput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.HomeAddressInput.Size = new System.Drawing.Size(724, 61);
            this.HomeAddressInput.TabIndex = 54;
            this.HomeAddressInput.Text = "adfads";
            // 
            // Send
            // 
            this.Send.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Send.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Send.ForeColor = System.Drawing.SystemColors.Window;
            this.Send.Location = new System.Drawing.Point(351, 622);
            this.Send.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(663, 66);
            this.Send.TabIndex = 55;
            this.Send.Text = "Change the information";
            this.Send.UseVisualStyleBackColor = false;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // BirthdateInput
            // 
            this.BirthdateInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BirthdateInput.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.BirthdateInput.Location = new System.Drawing.Point(528, 108);
            this.BirthdateInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BirthdateInput.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.BirthdateInput.Name = "BirthdateInput";
            this.BirthdateInput.Size = new System.Drawing.Size(305, 60);
            this.BirthdateInput.TabIndex = 56;
            this.BirthdateInput.ValueChanged += new System.EventHandler(this.BirthdateInput_ValueChanged);
            // 
            // WrongInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1379, 814);
            this.Controls.Add(this.BirthdateInput);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.HomeAddressInput);
            this.Controls.Add(this.VehicleInput);
            this.Controls.Add(this.PhoneInput);
            this.Controls.Add(this.CitizenIDInput);
            this.Controls.Add(this.Return);
            this.Controls.Add(this.Fields);
            this.Controls.Add(this.BigLogo);
            this.Controls.Add(this.Crucial);
            this.Controls.Add(this.Information);
            this.Controls.Add(this.HomePic);
            this.Controls.Add(this.LogOut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "WrongInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dormitory Management";
            ((System.ComponentModel.ISupportInitialize)(this.BigLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel Return;
        private System.Windows.Forms.Label Fields;
        private System.Windows.Forms.PictureBox BigLogo;
        private System.Windows.Forms.Label Crucial;
        private System.Windows.Forms.Label Information;
        private System.Windows.Forms.PictureBox HomePic;
        private System.Windows.Forms.LinkLabel LogOut;
        private System.Windows.Forms.RichTextBox CitizenIDInput;
        private System.Windows.Forms.RichTextBox PhoneInput;
        private System.Windows.Forms.RichTextBox VehicleInput;
        private System.Windows.Forms.RichTextBox HomeAddressInput;
        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.DateTimePicker BirthdateInput;
    }
}