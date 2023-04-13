namespace DormitoryManagment
{
    partial class StudentMainScreen
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
            this.welcome = new System.Windows.Forms.Label();
            this.logout = new System.Windows.Forms.LinkLabel();
            this.paybill = new System.Windows.Forms.LinkLabel();
            this.crucialcpn = new System.Windows.Forms.Label();
            this.dormicon = new System.Windows.Forms.PictureBox();
            this.usericon = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dormicon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usericon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // welcome
            // 
            this.welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome.Location = new System.Drawing.Point(79, 33);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(443, 29);
            this.welcome.TabIndex = 1;
            this.welcome.Text = "Welcome back "  + "!";
            // 
            // logout
            // 
            this.logout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.logout.LinkColor = System.Drawing.Color.Black;
            this.logout.Location = new System.Drawing.Point(729, 28);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(144, 39);
            this.logout.TabIndex = 2;
            this.logout.TabStop = true;
            this.logout.Text = "LOG OUT";
            this.logout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.logout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.logout_LinkClicked);
            // 
            // paybill
            // 
            this.paybill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.paybill.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.paybill.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paybill.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.paybill.LinkColor = System.Drawing.Color.Black;
            this.paybill.Location = new System.Drawing.Point(729, 547);
            this.paybill.Name = "paybill";
            this.paybill.Size = new System.Drawing.Size(135, 39);
            this.paybill.TabIndex = 3;
            this.paybill.TabStop = true;
            this.paybill.Text = "PAY BILL";
            this.paybill.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.paybill.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.paybill_LinkClicked);
            // 
            // crucialcpn
            // 
            this.crucialcpn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crucialcpn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.crucialcpn.Location = new System.Drawing.Point(328, 544);
            this.crucialcpn.Name = "crucialcpn";
            this.crucialcpn.Size = new System.Drawing.Size(244, 34);
            this.crucialcpn.TabIndex = 4;
            this.crucialcpn.Text = "Ho Chi Minh University of Technology\nAdvanced Programming Assignment";
            this.crucialcpn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dormicon
            // 
            this.dormicon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.dormicon.Image = global::DormitoryManagment.Properties.Resources.dorm;
            this.dormicon.Location = new System.Drawing.Point(360, 96);
            this.dormicon.Name = "dormicon";
            this.dormicon.Size = new System.Drawing.Size(180, 180);
            this.dormicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dormicon.TabIndex = 5;
            this.dormicon.TabStop = false;
            // 
            // usericon
            // 
            this.usericon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.usericon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.usericon.Image = global::DormitoryManagment.Properties.Resources.usericon;
            this.usericon.Location = new System.Drawing.Point(22, 22);
            this.usericon.Name = "usericon";
            this.usericon.Size = new System.Drawing.Size(40, 40);
            this.usericon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.usericon.TabIndex = 0;
            this.usericon.TabStop = false;
            this.usericon.Click += new System.EventHandler(this.usericon_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 39);
            this.label1.TabIndex = 6;
            this.label1.Text = "Staying room status:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(106, 345);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(698, 156);
            this.label2.TabIndex = 7;
            this.label2.Text = "Room for" + "- Room Building \nUnpaid electricity and water bill: \nBill late time: \nPe" +
    "nalty fee: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // StudentMainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dormicon);
            this.Controls.Add(this.crucialcpn);
            this.Controls.Add(this.paybill);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.welcome);
            this.Controls.Add(this.usericon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "StudentMainScreen";
            this.Text = "Student";
            ((System.ComponentModel.ISupportInitialize)(this.dormicon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usericon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox usericon;
        private System.Windows.Forms.Label welcome;
        private System.Windows.Forms.LinkLabel logout;
        private System.Windows.Forms.LinkLabel paybill;
        private System.Windows.Forms.Label crucialcpn;
        private System.Windows.Forms.PictureBox dormicon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}