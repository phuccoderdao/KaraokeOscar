
namespace WF_KARAOKEOSCAR
{
    partial class frmChiTietPhong
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbTamTinh = new System.Windows.Forms.Label();
            this.lbGio = new System.Windows.Forms.Label();
            this.lbBatdau = new System.Windows.Forms.Label();
            this.lbmaHD = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbTienDV = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvSdDichVu = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.nmQuantity = new System.Windows.Forms.NumericUpDown();
            this.cmbdv = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSdDichVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lbTamTinh);
            this.groupBox1.Controls.Add(this.lbGio);
            this.groupBox1.Controls.Add(this.lbBatdau);
            this.groupBox1.Controls.Add(this.lbmaHD);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(32, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(499, 321);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Hóa Đơn";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(344, 226);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 24);
            this.label7.TabIndex = 9;
            this.label7.Text = "VNĐ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(344, 165);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 24);
            this.label6.TabIndex = 8;
            this.label6.Text = "Giờ";
            // 
            // lbTamTinh
            // 
            this.lbTamTinh.AutoSize = true;
            this.lbTamTinh.Location = new System.Drawing.Point(195, 226);
            this.lbTamTinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTamTinh.Name = "lbTamTinh";
            this.lbTamTinh.Size = new System.Drawing.Size(78, 25);
            this.lbTamTinh.TabIndex = 7;
            this.lbTamTinh.Text = "234800";
            this.lbTamTinh.Click += new System.EventHandler(this.lbTamTinh_Click);
            // 
            // lbGio
            // 
            this.lbGio.AutoSize = true;
            this.lbGio.Location = new System.Drawing.Point(195, 165);
            this.lbGio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbGio.Name = "lbGio";
            this.lbGio.Size = new System.Drawing.Size(34, 25);
            this.lbGio.TabIndex = 6;
            this.lbGio.Text = "00";
            // 
            // lbBatdau
            // 
            this.lbBatdau.AutoSize = true;
            this.lbBatdau.Location = new System.Drawing.Point(195, 111);
            this.lbBatdau.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbBatdau.Name = "lbBatdau";
            this.lbBatdau.Size = new System.Drawing.Size(114, 25);
            this.lbBatdau.TabIndex = 5;
            this.lbBatdau.Text = "2022-19-18";
            this.lbBatdau.Click += new System.EventHandler(this.lbBatdau_Click);
            // 
            // lbmaHD
            // 
            this.lbmaHD.AutoSize = true;
            this.lbmaHD.Location = new System.Drawing.Point(195, 62);
            this.lbmaHD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbmaHD.Name = "lbmaHD";
            this.lbmaHD.Size = new System.Drawing.Size(34, 25);
            this.lbmaHD.TabIndex = 4;
            this.lbmaHD.Text = "00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 226);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tạm Tính:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 165);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số giờ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Giờ vào:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Hóa Đơn:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbTienDV);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.dgvSdDichVu);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.nmQuantity);
            this.groupBox2.Controls.Add(this.cmbdv);
            this.groupBox2.Location = new System.Drawing.Point(565, 18);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(542, 603);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sử Dụng Dịch Vụ";
            // 
            // lbTienDV
            // 
            this.lbTienDV.AutoSize = true;
            this.lbTienDV.Location = new System.Drawing.Point(406, 556);
            this.lbTienDV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTienDV.Name = "lbTienDV";
            this.lbTienDV.Size = new System.Drawing.Size(130, 25);
            this.lbTienDV.TabIndex = 7;
            this.lbTienDV.Text = "275.000 VNĐ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(314, 556);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tổng:";
            // 
            // dgvSdDichVu
            // 
            this.dgvSdDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSdDichVu.Location = new System.Drawing.Point(8, 165);
            this.dgvSdDichVu.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSdDichVu.Name = "dgvSdDichVu";
            this.dgvSdDichVu.RowHeadersWidth = 51;
            this.dgvSdDichVu.RowTemplate.Height = 24;
            this.dgvSdDichVu.Size = new System.Drawing.Size(525, 350);
            this.dgvSdDichVu.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Blue;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(352, 57);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 80);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // nmQuantity
            // 
            this.nmQuantity.Location = new System.Drawing.Point(246, 104);
            this.nmQuantity.Margin = new System.Windows.Forms.Padding(6);
            this.nmQuantity.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nmQuantity.Name = "nmQuantity";
            this.nmQuantity.Size = new System.Drawing.Size(72, 29);
            this.nmQuantity.TabIndex = 5;
            this.nmQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cmbdv
            // 
            this.cmbdv.FormattingEnabled = true;
            this.cmbdv.Location = new System.Drawing.Point(52, 57);
            this.cmbdv.Margin = new System.Windows.Forms.Padding(4);
            this.cmbdv.Name = "cmbdv";
            this.cmbdv.Size = new System.Drawing.Size(264, 32);
            this.cmbdv.TabIndex = 0;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BackColor = System.Drawing.Color.Blue;
            this.btnCheckOut.FlatAppearance.BorderSize = 0;
            this.btnCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.ForeColor = System.Drawing.Color.White;
            this.btnCheckOut.Location = new System.Drawing.Point(78, 368);
            this.btnCheckOut.Margin = new System.Windows.Forms.Padding(4);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(136, 66);
            this.btnCheckOut.TabIndex = 2;
            this.btnCheckOut.Text = "Thanh Toán";
            this.btnCheckOut.UseVisualStyleBackColor = false;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Blue;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(344, 368);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(136, 66);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmChiTietPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1144, 633);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmChiTietPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmChiTietPhong";
            this.Load += new System.EventHandler(this.frmChiTietPhong_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSdDichVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmQuantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvSdDichVu;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.NumericUpDown nmQuantity;
        private System.Windows.Forms.ComboBox cmbdv;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTienDV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbTamTinh;
        private System.Windows.Forms.Label lbGio;
        private System.Windows.Forms.Label lbBatdau;
        private System.Windows.Forms.Label lbmaHD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}