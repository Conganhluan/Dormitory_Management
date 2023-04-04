namespace DormitoryManagment
{
    partial class FrmMenu
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
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlHome = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lbHome = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnDienNuoc = new System.Windows.Forms.Button();
            this.btnToa = new System.Windows.Forms.Button();
            this.btnOut = new System.Windows.Forms.Button();
            this.btnPhong = new System.Windows.Forms.Button();
            this.btnTang = new System.Windows.Forms.Button();
            this.btnSinhVien = new System.Windows.Forms.Button();
            this.pnlMenu.SuspendLayout();
            this.pnlHome.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.btnDienNuoc);
            this.pnlMenu.Controls.Add(this.btnToa);
            this.pnlMenu.Controls.Add(this.btnOut);
            this.pnlMenu.Controls.Add(this.panel1);
            this.pnlMenu.Controls.Add(this.btnSinhVien);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(313, 699);
            this.pnlMenu.TabIndex = 0;
            // 
            // pnlHome
            // 
            this.pnlHome.BackColor = System.Drawing.Color.SkyBlue;
            this.pnlHome.Controls.Add(this.lbHome);
            this.pnlHome.Controls.Add(this.button1);
            this.pnlHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHome.Location = new System.Drawing.Point(313, 0);
            this.pnlHome.Name = "pnlHome";
            this.pnlHome.Size = new System.Drawing.Size(1041, 68);
            this.pnlHome.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SkyBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 68);
            this.button1.TabIndex = 1;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbHome
            // 
            this.lbHome.AutoSize = true;
            this.lbHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHome.ForeColor = System.Drawing.SystemColors.Window;
            this.lbHome.Location = new System.Drawing.Point(429, 15);
            this.lbHome.Name = "lbHome";
            this.lbHome.Size = new System.Drawing.Size(123, 39);
            this.lbHome.TabIndex = 2;
            this.lbHome.Text = "HOME";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPhong);
            this.panel1.Controls.Add(this.btnTang);
            this.panel1.Location = new System.Drawing.Point(3, 206);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 147);
            this.panel1.TabIndex = 3;
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlMain.BackgroundImage = global::DormitoryManagment.Properties.Resources.bg;
            this.pnlMain.Location = new System.Drawing.Point(313, 70);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1041, 629);
            this.pnlMain.TabIndex = 2;
            // 
            // btnDienNuoc
            // 
            this.btnDienNuoc.BackColor = System.Drawing.SystemColors.Window;
            this.btnDienNuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDienNuoc.Image = global::DormitoryManagment.Properties.Resources.bolt;
            this.btnDienNuoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDienNuoc.Location = new System.Drawing.Point(0, 354);
            this.btnDienNuoc.Name = "btnDienNuoc";
            this.btnDienNuoc.Size = new System.Drawing.Size(313, 72);
            this.btnDienNuoc.TabIndex = 2;
            this.btnDienNuoc.Text = "Quản lý hóa đơn";
            this.btnDienNuoc.UseVisualStyleBackColor = false;
            this.btnDienNuoc.Click += new System.EventHandler(this.btnDienNuoc_Click);
            // 
            // btnToa
            // 
            this.btnToa.BackColor = System.Drawing.SystemColors.Window;
            this.btnToa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToa.Image = global::DormitoryManagment.Properties.Resources.hotel;
            this.btnToa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnToa.Location = new System.Drawing.Point(0, 148);
            this.btnToa.Name = "btnToa";
            this.btnToa.Size = new System.Drawing.Size(313, 72);
            this.btnToa.TabIndex = 2;
            this.btnToa.Text = "Quản lý Tòa";
            this.btnToa.UseVisualStyleBackColor = false;
            this.btnToa.Click += new System.EventHandler(this.btnToa_Click);
            // 
            // btnOut
            // 
            this.btnOut.BackColor = System.Drawing.SystemColors.Window;
            this.btnOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOut.Image = global::DormitoryManagment.Properties.Resources.logout;
            this.btnOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOut.Location = new System.Drawing.Point(0, 627);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(313, 72);
            this.btnOut.TabIndex = 2;
            this.btnOut.Text = "Đăng Xuất";
            this.btnOut.UseVisualStyleBackColor = false;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // btnPhong
            // 
            this.btnPhong.BackColor = System.Drawing.SystemColors.Window;
            this.btnPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhong.Image = global::DormitoryManagment.Properties.Resources.open_door;
            this.btnPhong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPhong.Location = new System.Drawing.Point(-3, 70);
            this.btnPhong.Name = "btnPhong";
            this.btnPhong.Size = new System.Drawing.Size(313, 72);
            this.btnPhong.TabIndex = 2;
            this.btnPhong.Text = "Danh sách phòng";
            this.btnPhong.UseVisualStyleBackColor = false;
            this.btnPhong.Click += new System.EventHandler(this.btnPhong_Click);
            // 
            // btnTang
            // 
            this.btnTang.BackColor = System.Drawing.SystemColors.Window;
            this.btnTang.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTang.Image = global::DormitoryManagment.Properties.Resources.stairs;
            this.btnTang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTang.Location = new System.Drawing.Point(-3, 4);
            this.btnTang.Name = "btnTang";
            this.btnTang.Size = new System.Drawing.Size(313, 72);
            this.btnTang.TabIndex = 2;
            this.btnTang.Text = "Danh sách tầng";
            this.btnTang.UseVisualStyleBackColor = false;
            this.btnTang.Click += new System.EventHandler(this.btnTang_Click);
            // 
            // btnSinhVien
            // 
            this.btnSinhVien.BackColor = System.Drawing.SystemColors.Window;
            this.btnSinhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSinhVien.Image = global::DormitoryManagment.Properties.Resources.cap;
            this.btnSinhVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSinhVien.Location = new System.Drawing.Point(0, 70);
            this.btnSinhVien.Name = "btnSinhVien";
            this.btnSinhVien.Size = new System.Drawing.Size(313, 72);
            this.btnSinhVien.TabIndex = 2;
            this.btnSinhVien.Text = "Quản lý sinh viên";
            this.btnSinhVien.UseVisualStyleBackColor = false;
            this.btnSinhVien.Click += new System.EventHandler(this.btnSinhVien_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 699);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlHome);
            this.Controls.Add(this.pnlMenu);
            this.Name = "FrmMenu";
            this.Text = "FrmMenu";
            this.pnlMenu.ResumeLayout(false);
            this.pnlHome.ResumeLayout(false);
            this.pnlHome.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnSinhVien;
        private System.Windows.Forms.Panel pnlHome;
        private System.Windows.Forms.Label lbHome;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnPhong;
        private System.Windows.Forms.Button btnTang;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDienNuoc;
        private System.Windows.Forms.Button btnToa;
        private System.Windows.Forms.Panel pnlMain;
    }
}