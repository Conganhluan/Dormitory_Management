namespace DormitoryManagment
{
    partial class FrmDanhsachtang
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
            this.txtTentang = new System.Windows.Forms.TextBox();
            this.txtTrangthai = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTang = new System.Windows.Forms.Label();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dgvTang = new System.Windows.Forms.DataGridView();
            this.t1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ql = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.st = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbQuanly = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTang)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTentang
            // 
            this.txtTentang.Location = new System.Drawing.Point(155, 153);
            this.txtTentang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTentang.Name = "txtTentang";
            this.txtTentang.Size = new System.Drawing.Size(163, 22);
            this.txtTentang.TabIndex = 22;
            // 
            // txtTrangthai
            // 
            this.txtTrangthai.Location = new System.Drawing.Point(155, 264);
            this.txtTrangthai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTrangthai.Name = "txtTrangthai";
            this.txtTrangthai.Size = new System.Drawing.Size(163, 22);
            this.txtTrangthai.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 32;
            this.label5.Text = "Quản lý";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 31;
            this.label4.Text = "Trạng thái";
            // 
            // lblTang
            // 
            this.lblTang.AutoSize = true;
            this.lblTang.Location = new System.Drawing.Point(48, 160);
            this.lblTang.Name = "lblTang";
            this.lblTang.Size = new System.Drawing.Size(60, 16);
            this.lblTang.TabIndex = 30;
            this.lblTang.Text = "Tên tầng";
            // 
            // btnUp
            // 
            this.btnUp.Image = global::DormitoryManagment.Properties.Resources._075_reload;
            this.btnUp.Location = new System.Drawing.Point(235, 335);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(83, 80);
            this.btnUp.TabIndex = 33;
            this.btnUp.Text = "Cập nhật";
            this.btnUp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::DormitoryManagment.Properties.Resources._017_clipboard;
            this.btnSave.Location = new System.Drawing.Point(77, 335);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(83, 80);
            this.btnSave.TabIndex = 34;
            this.btnSave.Text = "Sửa";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 30;
            this.label1.Text = "Tên tòa";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(155, 108);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(163, 22);
            this.textBox1.TabIndex = 22;
            // 
            // dgvTang
            // 
            this.dgvTang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.t1,
            this.t2,
            this.ql,
            this.st});
            this.dgvTang.Location = new System.Drawing.Point(356, 108);
            this.dgvTang.Name = "dgvTang";
            this.dgvTang.RowHeadersWidth = 51;
            this.dgvTang.RowTemplate.Height = 24;
            this.dgvTang.Size = new System.Drawing.Size(565, 250);
            this.dgvTang.TabIndex = 35;
            this.dgvTang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTang_CellClick);
            // 
            // t1
            // 
            this.t1.DataPropertyName = "IDTANG";
            this.t1.HeaderText = "Tên tầng";
            this.t1.MinimumWidth = 6;
            this.t1.Name = "t1";
            this.t1.Width = 125;
            // 
            // t2
            // 
            this.t2.DataPropertyName = "IDTOA";
            this.t2.HeaderText = "Tên tòa";
            this.t2.MinimumWidth = 6;
            this.t2.Name = "t2";
            this.t2.Width = 125;
            // 
            // ql
            // 
            this.ql.DataPropertyName = "MANAGER";
            this.ql.HeaderText = "Quản lý";
            this.ql.MinimumWidth = 6;
            this.ql.Name = "ql";
            this.ql.Width = 125;
            // 
            // st
            // 
            this.st.DataPropertyName = "STATUS";
            this.st.HeaderText = "Trạng thái";
            this.st.MinimumWidth = 6;
            this.st.Name = "st";
            this.st.Width = 125;
            // 
            // cbQuanly
            // 
            this.cbQuanly.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbQuanly.FormattingEnabled = true;
            this.cbQuanly.Items.AddRange(new object[] {
            "Nguyễn Minh Lộc"});
            this.cbQuanly.Location = new System.Drawing.Point(155, 204);
            this.cbQuanly.Name = "cbQuanly";
            this.cbQuanly.Size = new System.Drawing.Size(163, 28);
            this.cbQuanly.TabIndex = 36;
            // 
            // FrmDanhsachtang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 641);
            this.Controls.Add(this.cbQuanly);
            this.Controls.Add(this.dgvTang);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtTentang);
            this.Controls.Add(this.txtTrangthai);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTang);
            this.Name = "FrmDanhsachtang";
            this.Text = "FrmDanhsachday";
            this.Load += new System.EventHandler(this.FrmDanhsachtang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtTentang;
        private System.Windows.Forms.TextBox txtTrangthai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTang;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dgvTang;
        private System.Windows.Forms.DataGridViewTextBoxColumn t1;
        private System.Windows.Forms.DataGridViewTextBoxColumn t2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ql;
        private System.Windows.Forms.DataGridViewTextBoxColumn st;
        private System.Windows.Forms.ComboBox cbQuanly;
    }
}