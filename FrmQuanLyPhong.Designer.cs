namespace DormitoryManagment
{
    partial class FrmQuanLyPhong
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
            this.lblName = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.lblStyle = new System.Windows.Forms.Label();
            this.lblNumSV = new System.Windows.Forms.Label();
            this.textNumReal = new System.Windows.Forms.TextBox();
            this.lblTang = new System.Windows.Forms.Label();
            this.lblNumRoom = new System.Windows.Forms.Label();
            this.textNumRoom = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.textStatus = new System.Windows.Forms.TextBox();
            this.cmbStyle = new System.Windows.Forms.ComboBox();
            this.btnUp = new System.Windows.Forms.Button();
            this.dtGVPhong = new System.Windows.Forms.DataGridView();
            this.grFind = new System.Windows.Forms.GroupBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textFind = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.textStBill = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBill = new System.Windows.Forms.TextBox();
            this.cmbTang = new System.Windows.Forms.ComboBox();
            this.NameRoom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameTang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numreal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumRoom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Style = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtGVPhong)).BeginInit();
            this.grFind.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblName.Location = new System.Drawing.Point(27, 40);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(87, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Tên phòng";
            // 
            // textName
            // 
            this.textName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textName.Location = new System.Drawing.Point(192, 37);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(177, 26);
            this.textName.TabIndex = 1;
            // 
            // lblStyle
            // 
            this.lblStyle.AutoSize = true;
            this.lblStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblStyle.Location = new System.Drawing.Point(426, 40);
            this.lblStyle.Name = "lblStyle";
            this.lblStyle.Size = new System.Drawing.Size(91, 20);
            this.lblStyle.TabIndex = 0;
            this.lblStyle.Text = "Loại phòng";
            // 
            // lblNumSV
            // 
            this.lblNumSV.AutoSize = true;
            this.lblNumSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNumSV.Location = new System.Drawing.Point(27, 91);
            this.lblNumSV.Name = "lblNumSV";
            this.lblNumSV.Size = new System.Drawing.Size(159, 20);
            this.lblNumSV.TabIndex = 0;
            this.lblNumSV.Text = "Số sinh viên hiện tại";
            // 
            // textNumReal
            // 
            this.textNumReal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textNumReal.Location = new System.Drawing.Point(192, 88);
            this.textNumReal.Name = "textNumReal";
            this.textNumReal.Size = new System.Drawing.Size(177, 26);
            this.textNumReal.TabIndex = 1;
            // 
            // lblTang
            // 
            this.lblTang.AutoSize = true;
            this.lblTang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTang.Location = new System.Drawing.Point(426, 91);
            this.lblTang.Name = "lblTang";
            this.lblTang.Size = new System.Drawing.Size(74, 20);
            this.lblTang.TabIndex = 0;
            this.lblTang.Text = "Tên tầng";
            // 
            // lblNumRoom
            // 
            this.lblNumRoom.AutoSize = true;
            this.lblNumRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNumRoom.Location = new System.Drawing.Point(27, 143);
            this.lblNumRoom.Name = "lblNumRoom";
            this.lblNumRoom.Size = new System.Drawing.Size(146, 20);
            this.lblNumRoom.TabIndex = 0;
            this.lblNumRoom.Text = "Số sinh viên tối đa";
            // 
            // textNumRoom
            // 
            this.textNumRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textNumRoom.Location = new System.Drawing.Point(192, 140);
            this.textNumRoom.Name = "textNumRoom";
            this.textNumRoom.Size = new System.Drawing.Size(177, 26);
            this.textNumRoom.TabIndex = 1;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblStatus.Location = new System.Drawing.Point(426, 146);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(84, 20);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Trạng thái";
            // 
            // textStatus
            // 
            this.textStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textStatus.Location = new System.Drawing.Point(526, 140);
            this.textStatus.Name = "textStatus";
            this.textStatus.Size = new System.Drawing.Size(177, 26);
            this.textStatus.TabIndex = 1;
            // 
            // cmbStyle
            // 
            this.cmbStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbStyle.FormattingEnabled = true;
            this.cmbStyle.Items.AddRange(new object[] {
            "Phòng 4 người",
            "Phòng 6 người",
            "Phòng 8 người"});
            this.cmbStyle.Location = new System.Drawing.Point(523, 40);
            this.cmbStyle.Name = "cmbStyle";
            this.cmbStyle.Size = new System.Drawing.Size(180, 28);
            this.cmbStyle.TabIndex = 2;
            // 
            // btnUp
            // 
            this.btnUp.Image = global::DormitoryManagment.Properties.Resources._075_reload;
            this.btnUp.Location = new System.Drawing.Point(741, 320);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(83, 80);
            this.btnUp.TabIndex = 6;
            this.btnUp.Text = "Reset";
            this.btnUp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // dtGVPhong
            // 
            this.dtGVPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGVPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameRoom,
            this.NameTang,
            this.Numreal,
            this.NumRoom,
            this.Style,
            this.Status,
            this.BillMoney,
            this.Column1});
            this.dtGVPhong.Location = new System.Drawing.Point(31, 251);
            this.dtGVPhong.Name = "dtGVPhong";
            this.dtGVPhong.RowHeadersWidth = 51;
            this.dtGVPhong.RowTemplate.Height = 24;
            this.dtGVPhong.Size = new System.Drawing.Size(672, 322);
            this.dtGVPhong.TabIndex = 10;
            this.dtGVPhong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGVPhong_CellClick);
            // 
            // grFind
            // 
            this.grFind.Controls.Add(this.btnFind);
            this.grFind.Controls.Add(this.label1);
            this.grFind.Controls.Add(this.textFind);
            this.grFind.Controls.Add(this.checkBox1);
            this.grFind.Controls.Add(this.rb2);
            this.grFind.Controls.Add(this.rb1);
            this.grFind.Location = new System.Drawing.Point(741, 43);
            this.grFind.Name = "grFind";
            this.grFind.Size = new System.Drawing.Size(196, 271);
            this.grFind.TabIndex = 11;
            this.grFind.TabStop = false;
            this.grFind.Text = "Tìm kiếm";
            // 
            // btnFind
            // 
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnFind.Location = new System.Drawing.Point(21, 197);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(139, 36);
            this.btnFind.TabIndex = 4;
            this.btnFind.Text = "Tìm kiếm";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nhập thông tin tìm kiếm";
            // 
            // textFind
            // 
            this.textFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textFind.Location = new System.Drawing.Point(18, 153);
            this.textFind.Name = "textFind";
            this.textFind.Size = new System.Drawing.Size(143, 26);
            this.textFind.TabIndex = 2;
            this.textFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(19, 100);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(126, 20);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Phòng còn trống";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Location = new System.Drawing.Point(18, 62);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(146, 20);
            this.rb2.TabIndex = 0;
            this.rb2.TabStop = true;
            this.rb2.Text = "Tìm theo loại phòng";
            this.rb2.UseVisualStyleBackColor = true;
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Location = new System.Drawing.Point(18, 36);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(142, 20);
            this.rb1.TabIndex = 0;
            this.rb1.TabStop = true;
            this.rb1.Text = "Tìm theo tên phòng";
            this.rb1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(404, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Trạng thái Bill";
            // 
            // textStBill
            // 
            this.textStBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textStBill.Location = new System.Drawing.Point(526, 200);
            this.textStBill.Name = "textStBill";
            this.textStBill.Size = new System.Drawing.Size(177, 26);
            this.textStBill.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(27, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tiền Bill";
            // 
            // txtBill
            // 
            this.txtBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBill.Location = new System.Drawing.Point(192, 200);
            this.txtBill.Name = "txtBill";
            this.txtBill.Size = new System.Drawing.Size(177, 26);
            this.txtBill.TabIndex = 1;
            // 
            // cmbTang
            // 
            this.cmbTang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbTang.FormattingEnabled = true;
            this.cmbTang.Location = new System.Drawing.Point(523, 91);
            this.cmbTang.Name = "cmbTang";
            this.cmbTang.Size = new System.Drawing.Size(180, 28);
            this.cmbTang.TabIndex = 2;
            // 
            // NameRoom
            // 
            this.NameRoom.DataPropertyName = "IDROOM";
            this.NameRoom.HeaderText = "Tên phòng";
            this.NameRoom.MinimumWidth = 6;
            this.NameRoom.Name = "NameRoom";
            this.NameRoom.Width = 125;
            // 
            // NameTang
            // 
            this.NameTang.DataPropertyName = "FLOOR";
            this.NameTang.HeaderText = "Tên tầng";
            this.NameTang.MinimumWidth = 6;
            this.NameTang.Name = "NameTang";
            this.NameTang.Width = 125;
            // 
            // Numreal
            // 
            this.Numreal.DataPropertyName = "NUMST";
            this.Numreal.HeaderText = "Số sinh viên hiện tại";
            this.Numreal.MinimumWidth = 6;
            this.Numreal.Name = "Numreal";
            this.Numreal.Width = 125;
            // 
            // NumRoom
            // 
            this.NumRoom.DataPropertyName = "NUMSTMAX";
            this.NumRoom.HeaderText = "Số sinh viên tối đa";
            this.NumRoom.MinimumWidth = 6;
            this.NumRoom.Name = "NumRoom";
            this.NumRoom.Width = 125;
            // 
            // Style
            // 
            this.Style.DataPropertyName = "STYLE";
            this.Style.HeaderText = "Loại Phòng";
            this.Style.MinimumWidth = 6;
            this.Style.Name = "Style";
            this.Style.Width = 125;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "STATUS";
            this.Status.HeaderText = "Trạng thái";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.Width = 125;
            // 
            // BillMoney
            // 
            this.BillMoney.DataPropertyName = "MONEYBILL";
            this.BillMoney.HeaderText = "Tiền Bill";
            this.BillMoney.MinimumWidth = 6;
            this.BillMoney.Name = "BillMoney";
            this.BillMoney.Width = 125;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "STATUSBILL";
            this.Column1.HeaderText = "Trạng thái Bill";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // FrmQuanLyPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 614);
            this.Controls.Add(this.grFind);
            this.Controls.Add(this.dtGVPhong);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.cmbTang);
            this.Controls.Add(this.cmbStyle);
            this.Controls.Add(this.lblTang);
            this.Controls.Add(this.textStBill);
            this.Controls.Add(this.textStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textNumReal);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblStyle);
            this.Controls.Add(this.textNumRoom);
            this.Controls.Add(this.lblNumSV);
            this.Controls.Add(this.lblNumRoom);
            this.Controls.Add(this.txtBill);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.lblName);
            this.Name = "FrmQuanLyPhong";
            this.Text = "FrmQuanLyPhong";
            this.Load += new System.EventHandler(this.FrmQuanLyPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGVPhong)).EndInit();
            this.grFind.ResumeLayout(false);
            this.grFind.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label lblStyle;
        private System.Windows.Forms.Label lblNumSV;
        private System.Windows.Forms.TextBox textNumReal;
        private System.Windows.Forms.Label lblTang;
        private System.Windows.Forms.Label lblNumRoom;
        private System.Windows.Forms.TextBox textNumRoom;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox textStatus;
        private System.Windows.Forms.ComboBox cmbStyle;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.DataGridView dtGVPhong;
        private System.Windows.Forms.GroupBox grFind;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textFind;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textStBill;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBill;
        private System.Windows.Forms.ComboBox cmbTang;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameTang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numreal;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Style;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}