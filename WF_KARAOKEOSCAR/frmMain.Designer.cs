
namespace WF_KARAOKEOSCAR
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trangChủToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dịchVụToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.plmain = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTaoMoiPhong = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.raNotNull = new System.Windows.Forms.RadioButton();
            this.raAll = new System.Windows.Forms.RadioButton();
            this.raNull = new System.Windows.Forms.RadioButton();
            this.listphong = new System.Windows.Forms.FlowLayoutPanel();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.menuStrip1.SuspendLayout();
            this.plmain.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.quảnLýToolStripMenuItem,
            this.thốngKêToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1350, 45);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "Hệ Thống";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngNhậpToolStripMenuItem,
            this.trangChủToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hệThốngToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(134, 39);
            this.hệThốngToolStripMenuItem.Text = "Hệ Thống";
            // 
            // đăngNhậpToolStripMenuItem
            // 
            this.đăngNhậpToolStripMenuItem.Name = "đăngNhậpToolStripMenuItem";
            this.đăngNhậpToolStripMenuItem.Size = new System.Drawing.Size(245, 40);
            this.đăngNhậpToolStripMenuItem.Text = "Đăng Xuất";
            this.đăngNhậpToolStripMenuItem.Click += new System.EventHandler(this.đăngNhậpToolStripMenuItem_Click);
            // 
            // trangChủToolStripMenuItem
            // 
            this.trangChủToolStripMenuItem.Name = "trangChủToolStripMenuItem";
            this.trangChủToolStripMenuItem.Size = new System.Drawing.Size(245, 40);
            this.trangChủToolStripMenuItem.Text = "Trang Chủ";
            this.trangChủToolStripMenuItem.Click += new System.EventHandler(this.trangChủToolStripMenuItem_Click);
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dịchVụToolStripMenuItem,
            this.phòngToolStripMenuItem});
            this.quảnLýToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quảnLýToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(119, 39);
            this.quảnLýToolStripMenuItem.Text = "Quản Lý";
            // 
            // dịchVụToolStripMenuItem
            // 
            this.dịchVụToolStripMenuItem.Name = "dịchVụToolStripMenuItem";
            this.dịchVụToolStripMenuItem.Size = new System.Drawing.Size(251, 40);
            this.dịchVụToolStripMenuItem.Text = "Dịch Vụ";
            this.dịchVụToolStripMenuItem.Click += new System.EventHandler(this.dịchVụToolStripMenuItem_Click);
            // 
            // phòngToolStripMenuItem
            // 
            this.phòngToolStripMenuItem.Name = "phòngToolStripMenuItem";
            this.phòngToolStripMenuItem.Size = new System.Drawing.Size(251, 40);
            this.phòngToolStripMenuItem.Text = "Loại Phòng";
            this.phòngToolStripMenuItem.Click += new System.EventHandler(this.phòngToolStripMenuItem_Click);
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thốngKêToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(139, 39);
            this.thốngKêToolStripMenuItem.Text = "Thống Kê";
            this.thốngKêToolStripMenuItem.Click += new System.EventHandler(this.thốngKêToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // plmain
            // 
            this.plmain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.plmain.Controls.Add(this.label1);
            this.plmain.Controls.Add(this.btnTaoMoiPhong);
            this.plmain.Controls.Add(this.groupBox1);
            this.plmain.Controls.Add(this.listphong);
            this.plmain.Location = new System.Drawing.Point(0, 46);
            this.plmain.Margin = new System.Windows.Forms.Padding(4);
            this.plmain.Name = "plmain";
            this.plmain.Padding = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.plmain.Size = new System.Drawing.Size(1350, 928);
            this.plmain.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(987, 170);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "(Thêm Phòng Mới)";
            // 
            // btnTaoMoiPhong
            // 
            this.btnTaoMoiPhong.BackColor = System.Drawing.Color.Blue;
            this.btnTaoMoiPhong.BackgroundImage = global::WF_KARAOKEOSCAR.Properties.Resources.Add;
            this.btnTaoMoiPhong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTaoMoiPhong.FlatAppearance.BorderSize = 0;
            this.btnTaoMoiPhong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaoMoiPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoMoiPhong.ForeColor = System.Drawing.Color.White;
            this.btnTaoMoiPhong.Location = new System.Drawing.Point(1090, 92);
            this.btnTaoMoiPhong.Margin = new System.Windows.Forms.Padding(4);
            this.btnTaoMoiPhong.Name = "btnTaoMoiPhong";
            this.btnTaoMoiPhong.Size = new System.Drawing.Size(80, 70);
            this.btnTaoMoiPhong.TabIndex = 6;
            this.btnTaoMoiPhong.UseVisualStyleBackColor = false;
            this.btnTaoMoiPhong.Click += new System.EventHandler(this.btnTaoMoiPhong_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.raNotNull);
            this.groupBox1.Controls.Add(this.raAll);
            this.groupBox1.Controls.Add(this.raNull);
            this.groupBox1.Location = new System.Drawing.Point(139, 76);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(793, 120);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Phòng Theo Trạng Thái";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // raNotNull
            // 
            this.raNotNull.AutoSize = true;
            this.raNotNull.Location = new System.Drawing.Point(562, 57);
            this.raNotNull.Margin = new System.Windows.Forms.Padding(4);
            this.raNotNull.Name = "raNotNull";
            this.raNotNull.Size = new System.Drawing.Size(163, 29);
            this.raNotNull.TabIndex = 4;
            this.raNotNull.Text = "Đang có người";
            this.raNotNull.UseVisualStyleBackColor = true;
            this.raNotNull.CheckedChanged += new System.EventHandler(this.raNotNull_CheckedChanged);
            // 
            // raAll
            // 
            this.raAll.AutoSize = true;
            this.raAll.Checked = true;
            this.raAll.Location = new System.Drawing.Point(40, 57);
            this.raAll.Margin = new System.Windows.Forms.Padding(4);
            this.raAll.Name = "raAll";
            this.raAll.Size = new System.Drawing.Size(97, 29);
            this.raAll.TabIndex = 2;
            this.raAll.TabStop = true;
            this.raAll.Text = "Tất Cả";
            this.raAll.UseVisualStyleBackColor = true;
            this.raAll.CheckedChanged += new System.EventHandler(this.raAll_CheckedChanged);
            // 
            // raNull
            // 
            this.raNull.AutoSize = true;
            this.raNull.Location = new System.Drawing.Point(258, 57);
            this.raNull.Margin = new System.Windows.Forms.Padding(4);
            this.raNull.Name = "raNull";
            this.raNull.Size = new System.Drawing.Size(151, 29);
            this.raNull.TabIndex = 3;
            this.raNull.Text = "Phòng Trống";
            this.raNull.UseVisualStyleBackColor = true;
            this.raNull.CheckedChanged += new System.EventHandler(this.raNull_CheckedChanged);
            // 
            // listphong
            // 
            this.listphong.AutoScroll = true;
            this.listphong.BackColor = System.Drawing.Color.White;
            this.listphong.Location = new System.Drawing.Point(139, 204);
            this.listphong.Margin = new System.Windows.Forms.Padding(4);
            this.listphong.Name = "listphong";
            this.listphong.Padding = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.listphong.Size = new System.Drawing.Size(1031, 624);
            this.listphong.TabIndex = 1;
            this.listphong.Paint += new System.Windows.Forms.PaintEventHandler(this.listphong_Paint);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 980);
            this.Controls.Add(this.plmain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.plmain.ResumeLayout(false);
            this.plmain.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngNhậpToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dịchVụToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phòngToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel listphong;
        private System.Windows.Forms.RadioButton raAll;
        private System.Windows.Forms.RadioButton raNull;
        private System.Windows.Forms.RadioButton raNotNull;
        private System.Windows.Forms.Panel plmain;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trangChủToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTaoMoiPhong;
        private System.Windows.Forms.Label label1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}

