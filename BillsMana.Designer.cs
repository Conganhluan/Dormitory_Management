namespace DormitoryManagment
{
    partial class BillsMana
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillsMana));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbBuilding = new System.Windows.Forms.Label();
            this.cbBuilding = new System.Windows.Forms.ComboBox();
            this.lbBill = new System.Windows.Forms.Label();
            this.lbRoom = new System.Windows.Forms.Label();
            this.cbRoom = new System.Windows.Forms.ComboBox();
            this.textBill = new System.Windows.Forms.TextBox();
            this.lbStatus = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbDate = new System.Windows.Forms.Label();
            this.dtbills = new System.Windows.Forms.DateTimePicker();
            this.dataRequest = new System.Windows.Forms.DataGridView();
            this.dataBill = new System.Windows.Forms.DataGridView();
            this.gbFind = new System.Windows.Forms.GroupBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.build = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.room = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbRequest = new System.Windows.Forms.Label();
            this.buildre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.request = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAcpt = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataRequest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBill)).BeginInit();
            this.gbFind.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 581);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 72);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(363, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Advanced Programming Assignment";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(353, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ho Chi Minh University of Technology";
            // 
            // btnHome
            // 
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(83, 72);
            this.btnHome.TabIndex = 0;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(982, 77);
            this.panel2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label3.Location = new System.Drawing.Point(375, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "BILLS MANAGMENT";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Window;
            this.panel3.Controls.Add(this.btnAcpt);
            this.panel3.Controls.Add(this.lbRequest);
            this.panel3.Controls.Add(this.gbFind);
            this.panel3.Controls.Add(this.btnReload);
            this.panel3.Controls.Add(this.btnUpdate);
            this.panel3.Controls.Add(this.btnAdd);
            this.panel3.Controls.Add(this.dataBill);
            this.panel3.Controls.Add(this.dataRequest);
            this.panel3.Controls.Add(this.dtbills);
            this.panel3.Controls.Add(this.textBill);
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.lbStatus);
            this.panel3.Controls.Add(this.lbDate);
            this.panel3.Controls.Add(this.cbRoom);
            this.panel3.Controls.Add(this.lbRoom);
            this.panel3.Controls.Add(this.lbBill);
            this.panel3.Controls.Add(this.cbBuilding);
            this.panel3.Controls.Add(this.lbBuilding);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 77);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(982, 504);
            this.panel3.TabIndex = 3;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // lbBuilding
            // 
            this.lbBuilding.AutoSize = true;
            this.lbBuilding.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbBuilding.Location = new System.Drawing.Point(49, 39);
            this.lbBuilding.Name = "lbBuilding";
            this.lbBuilding.Size = new System.Drawing.Size(69, 20);
            this.lbBuilding.TabIndex = 0;
            this.lbBuilding.Text = "Building";
            // 
            // cbBuilding
            // 
            this.cbBuilding.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbBuilding.FormattingEnabled = true;
            this.cbBuilding.Location = new System.Drawing.Point(166, 36);
            this.cbBuilding.Name = "cbBuilding";
            this.cbBuilding.Size = new System.Drawing.Size(151, 28);
            this.cbBuilding.TabIndex = 1;
            // 
            // lbBill
            // 
            this.lbBill.AutoSize = true;
            this.lbBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbBill.Location = new System.Drawing.Point(362, 38);
            this.lbBill.Name = "lbBill";
            this.lbBill.Size = new System.Drawing.Size(42, 20);
            this.lbBill.TabIndex = 0;
            this.lbBill.Text = "Bills";
            // 
            // lbRoom
            // 
            this.lbRoom.AutoSize = true;
            this.lbRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbRoom.Location = new System.Drawing.Point(49, 91);
            this.lbRoom.Name = "lbRoom";
            this.lbRoom.Size = new System.Drawing.Size(99, 20);
            this.lbRoom.TabIndex = 0;
            this.lbRoom.Text = "Room name";
            // 
            // cbRoom
            // 
            this.cbRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbRoom.FormattingEnabled = true;
            this.cbRoom.Location = new System.Drawing.Point(166, 88);
            this.cbRoom.Name = "cbRoom";
            this.cbRoom.Size = new System.Drawing.Size(151, 28);
            this.cbRoom.TabIndex = 1;
            // 
            // textBill
            // 
            this.textBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBill.Location = new System.Drawing.Point(476, 35);
            this.textBill.Name = "textBill";
            this.textBill.Size = new System.Drawing.Size(155, 26);
            this.textBill.TabIndex = 2;
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbStatus.Location = new System.Drawing.Point(359, 88);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(57, 20);
            this.lbStatus.TabIndex = 0;
            this.lbStatus.Text = "Status";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(476, 85);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 1;
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbDate.Location = new System.Drawing.Point(49, 146);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(80, 20);
            this.lbDate.TabIndex = 0;
            this.lbDate.Text = "Date bills";
            // 
            // dtbills
            // 
            this.dtbills.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtbills.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtbills.Location = new System.Drawing.Point(166, 144);
            this.dtbills.Name = "dtbills";
            this.dtbills.Size = new System.Drawing.Size(151, 26);
            this.dtbills.TabIndex = 3;
            // 
            // dataRequest
            // 
            this.dataRequest.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataRequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataRequest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.buildre,
            this.roomname,
            this.request});
            this.dataRequest.Location = new System.Drawing.Point(664, 39);
            this.dataRequest.Name = "dataRequest";
            this.dataRequest.RowHeadersWidth = 51;
            this.dataRequest.RowTemplate.Height = 24;
            this.dataRequest.Size = new System.Drawing.Size(289, 150);
            this.dataRequest.TabIndex = 4;
            // 
            // dataBill
            // 
            this.dataBill.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.build,
            this.room,
            this.date,
            this.Bill,
            this.status});
            this.dataBill.Location = new System.Drawing.Point(53, 252);
            this.dataBill.Name = "dataBill";
            this.dataBill.RowHeadersWidth = 51;
            this.dataBill.RowTemplate.Height = 24;
            this.dataBill.Size = new System.Drawing.Size(578, 231);
            this.dataBill.TabIndex = 4;
            // 
            // gbFind
            // 
            this.gbFind.Controls.Add(this.btnFind);
            this.gbFind.Controls.Add(this.textBox1);
            this.gbFind.Location = new System.Drawing.Point(725, 374);
            this.gbFind.Name = "gbFind";
            this.gbFind.Size = new System.Drawing.Size(176, 109);
            this.gbFind.TabIndex = 11;
            this.gbFind.TabStop = false;
            this.gbFind.Text = "Find";
            // 
            // btnFind
            // 
            this.btnFind.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnFind.Location = new System.Drawing.Point(19, 53);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(133, 29);
            this.btnFind.TabIndex = 1;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(10, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(152, 22);
            this.textBox1.TabIndex = 0;
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.SystemColors.Window;
            this.btnReload.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnReload.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.Image")));
            this.btnReload.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReload.Location = new System.Drawing.Point(561, 144);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(70, 70);
            this.btnReload.TabIndex = 7;
            this.btnReload.Text = "Reload";
            this.btnReload.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReload.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.Window;
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUpdate.Location = new System.Drawing.Point(458, 144);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(70, 70);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.Window;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdd.Location = new System.Drawing.Point(351, 144);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(70, 70);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // build
            // 
            this.build.HeaderText = "Building";
            this.build.MinimumWidth = 6;
            this.build.Name = "build";
            this.build.Width = 125;
            // 
            // room
            // 
            this.room.HeaderText = "Room name";
            this.room.MinimumWidth = 6;
            this.room.Name = "room";
            this.room.Width = 125;
            // 
            // date
            // 
            this.date.HeaderText = "Date bills";
            this.date.MinimumWidth = 6;
            this.date.Name = "date";
            this.date.Width = 125;
            // 
            // Bill
            // 
            this.Bill.HeaderText = "Bills";
            this.Bill.MinimumWidth = 6;
            this.Bill.Name = "Bill";
            this.Bill.Width = 125;
            // 
            // status
            // 
            this.status.HeaderText = "Status";
            this.status.MinimumWidth = 6;
            this.status.Name = "status";
            this.status.Width = 125;
            // 
            // lbRequest
            // 
            this.lbRequest.AutoSize = true;
            this.lbRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRequest.Location = new System.Drawing.Point(660, 16);
            this.lbRequest.Name = "lbRequest";
            this.lbRequest.Size = new System.Drawing.Size(78, 20);
            this.lbRequest.TabIndex = 12;
            this.lbRequest.Text = "Request";
            // 
            // buildre
            // 
            this.buildre.HeaderText = "Building";
            this.buildre.MinimumWidth = 6;
            this.buildre.Name = "buildre";
            this.buildre.Width = 125;
            // 
            // roomname
            // 
            this.roomname.HeaderText = "Room name";
            this.roomname.MinimumWidth = 6;
            this.roomname.Name = "roomname";
            this.roomname.Width = 125;
            // 
            // request
            // 
            this.request.HeaderText = "Request";
            this.request.MinimumWidth = 6;
            this.request.Name = "request";
            this.request.Width = 125;
            // 
            // btnAcpt
            // 
            this.btnAcpt.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnAcpt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcpt.Location = new System.Drawing.Point(725, 208);
            this.btnAcpt.Name = "btnAcpt";
            this.btnAcpt.Size = new System.Drawing.Size(203, 41);
            this.btnAcpt.TabIndex = 13;
            this.btnAcpt.Text = "Accept";
            this.btnAcpt.UseVisualStyleBackColor = false;
            // 
            // BillsMana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "BillsMana";
            this.Text = "BillsMana";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataRequest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBill)).EndInit();
            this.gbFind.ResumeLayout(false);
            this.gbFind.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbBuilding;
        private System.Windows.Forms.DataGridView dataBill;
        private System.Windows.Forms.DataGridView dataRequest;
        private System.Windows.Forms.DateTimePicker dtbills;
        private System.Windows.Forms.TextBox textBill;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.ComboBox cbRoom;
        private System.Windows.Forms.Label lbRoom;
        private System.Windows.Forms.Label lbBill;
        private System.Windows.Forms.ComboBox cbBuilding;
        private System.Windows.Forms.GroupBox gbFind;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lbRequest;
        private System.Windows.Forms.DataGridViewTextBoxColumn build;
        private System.Windows.Forms.DataGridViewTextBoxColumn room;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bill;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.Button btnAcpt;
        private System.Windows.Forms.DataGridViewTextBoxColumn buildre;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomname;
        private System.Windows.Forms.DataGridViewTextBoxColumn request;
    }
}