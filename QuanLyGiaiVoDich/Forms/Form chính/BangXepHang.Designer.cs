namespace QuanLyGiaiVoDich
{
    partial class BangXepHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BangXepHang));
            this.bangXepHangData = new System.Windows.Forms.DataGridView();
            this.bangXepHangExtBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyGiaiVoDichDataSet = new QuanLyGiaiVoDich.QuanLyGiaiVoDichDataSet();
            this.thongTinPanel = new System.Windows.Forms.Panel();
            this.thoiGianPicker = new System.Windows.Forms.DateTimePicker();
            this.muaGiaiComboBox = new System.Windows.Forms.ComboBox();
            this.muaGiaiAllowNullBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.muaGiaiLabel = new System.Windows.Forms.Label();
            this.thoiGianLabel = new System.Windows.Forms.Label();
            this.bxhPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bangXepHangLabel = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.bangXepHangExtTableAdapter = new QuanLyGiaiVoDich.QuanLyGiaiVoDichDataSetTableAdapters.BangXepHangExtTableAdapter();
            this.muaGiaiAllowNullTableAdapter = new QuanLyGiaiVoDich.QuanLyGiaiVoDichDataSetTableAdapters.MuaGiaiAllowNullTableAdapter();
            this.xuatBXH = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.xepHangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDoiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thuaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hieuSoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soBanThangSanKhachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bangXepHangData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangXepHangExtBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyGiaiVoDichDataSet)).BeginInit();
            this.thongTinPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.muaGiaiAllowNullBindingSource)).BeginInit();
            this.bxhPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bangXepHangData
            // 
            this.bangXepHangData.AllowUserToAddRows = false;
            this.bangXepHangData.AllowUserToDeleteRows = false;
            this.bangXepHangData.AutoGenerateColumns = false;
            this.bangXepHangData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bangXepHangData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.bangXepHangData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bangXepHangData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xepHangDataGridViewTextBoxColumn,
            this.tenDoiDataGridViewTextBoxColumn,
            this.thangDataGridViewTextBoxColumn,
            this.hoaDataGridViewTextBoxColumn,
            this.thuaDataGridViewTextBoxColumn,
            this.diemDataGridViewTextBoxColumn,
            this.hieuSoDataGridViewTextBoxColumn,
            this.soBanThangSanKhachDataGridViewTextBoxColumn,
            this.MaDoi});
            this.bangXepHangData.DataSource = this.bangXepHangExtBindingSource;
            this.bangXepHangData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bangXepHangData.Location = new System.Drawing.Point(0, 165);
            this.bangXepHangData.Name = "bangXepHangData";
            this.bangXepHangData.Size = new System.Drawing.Size(1028, 444);
            this.bangXepHangData.TabIndex = 7;
            // 
            // bangXepHangExtBindingSource
            // 
            this.bangXepHangExtBindingSource.DataMember = "BangXepHangExt";
            this.bangXepHangExtBindingSource.DataSource = this.quanLyGiaiVoDichDataSet;
            // 
            // quanLyGiaiVoDichDataSet
            // 
            this.quanLyGiaiVoDichDataSet.DataSetName = "QuanLyGiaiVoDichDataSet";
            this.quanLyGiaiVoDichDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // thongTinPanel
            // 
            this.thongTinPanel.BackColor = System.Drawing.Color.Transparent;
            this.thongTinPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.thongTinPanel.Controls.Add(this.thoiGianPicker);
            this.thongTinPanel.Controls.Add(this.muaGiaiComboBox);
            this.thongTinPanel.Controls.Add(this.muaGiaiLabel);
            this.thongTinPanel.Controls.Add(this.thoiGianLabel);
            this.thongTinPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.thongTinPanel.Location = new System.Drawing.Point(0, 40);
            this.thongTinPanel.Name = "thongTinPanel";
            this.thongTinPanel.Size = new System.Drawing.Size(1028, 125);
            this.thongTinPanel.TabIndex = 6;
            // 
            // thoiGianPicker
            // 
            this.thoiGianPicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.thoiGianPicker.CalendarFont = new System.Drawing.Font("Arial", 12F);
            this.thoiGianPicker.Location = new System.Drawing.Point(497, 30);
            this.thoiGianPicker.Name = "thoiGianPicker";
            this.thoiGianPicker.Size = new System.Drawing.Size(200, 20);
            this.thoiGianPicker.TabIndex = 6;
            this.thoiGianPicker.ValueChanged += new System.EventHandler(this.thoiGianPicker_ValueChanged);
            // 
            // muaGiaiComboBox
            // 
            this.muaGiaiComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.muaGiaiComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(252)))));
            this.muaGiaiComboBox.DataSource = this.muaGiaiAllowNullBindingSource;
            this.muaGiaiComboBox.DisplayMember = "TenMuaGiai";
            this.muaGiaiComboBox.Enabled = false;
            this.muaGiaiComboBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.muaGiaiComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(156)))), ((int)(((byte)(217)))));
            this.muaGiaiComboBox.FormattingEnabled = true;
            this.muaGiaiComboBox.Location = new System.Drawing.Point(497, 69);
            this.muaGiaiComboBox.Name = "muaGiaiComboBox";
            this.muaGiaiComboBox.Size = new System.Drawing.Size(200, 27);
            this.muaGiaiComboBox.TabIndex = 5;
            this.muaGiaiComboBox.ValueMember = "MaMuaGiai";
            // 
            // muaGiaiAllowNullBindingSource
            // 
            this.muaGiaiAllowNullBindingSource.DataMember = "MuaGiaiAllowNull";
            this.muaGiaiAllowNullBindingSource.DataSource = this.quanLyGiaiVoDichDataSet;
            // 
            // muaGiaiLabel
            // 
            this.muaGiaiLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.muaGiaiLabel.AutoSize = true;
            this.muaGiaiLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.muaGiaiLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.muaGiaiLabel.Location = new System.Drawing.Point(409, 75);
            this.muaGiaiLabel.Name = "muaGiaiLabel";
            this.muaGiaiLabel.Size = new System.Drawing.Size(71, 18);
            this.muaGiaiLabel.TabIndex = 4;
            this.muaGiaiLabel.Text = "Mùa Giải";
            // 
            // thoiGianLabel
            // 
            this.thoiGianLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.thoiGianLabel.AutoSize = true;
            this.thoiGianLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thoiGianLabel.Location = new System.Drawing.Point(409, 31);
            this.thoiGianLabel.Name = "thoiGianLabel";
            this.thoiGianLabel.Size = new System.Drawing.Size(74, 18);
            this.thoiGianLabel.TabIndex = 2;
            this.thoiGianLabel.Text = "Thời gian";
            // 
            // bxhPanel
            // 
            this.bxhPanel.Controls.Add(this.pictureBox1);
            this.bxhPanel.Controls.Add(this.bangXepHangLabel);
            this.bxhPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.bxhPanel.Location = new System.Drawing.Point(0, 0);
            this.bxhPanel.Name = "bxhPanel";
            this.bxhPanel.Size = new System.Drawing.Size(1028, 40);
            this.bxhPanel.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackgroundImage = global::QuanLyGiaiVoDich.Properties.Resources.rank;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(409, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // bangXepHangLabel
            // 
            this.bangXepHangLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bangXepHangLabel.AutoSize = true;
            this.bangXepHangLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bangXepHangLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.bangXepHangLabel.Location = new System.Drawing.Point(445, 10);
            this.bangXepHangLabel.Name = "bangXepHangLabel";
            this.bangXepHangLabel.Size = new System.Drawing.Size(183, 24);
            this.bangXepHangLabel.TabIndex = 1;
            this.bangXepHangLabel.Text = "BẢNG XẾP HẠNG";
            // 
            // panel9
            // 
            this.panel9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel9.Location = new System.Drawing.Point(6, 676);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1028, 40);
            this.panel9.TabIndex = 8;
            // 
            // bangXepHangExtTableAdapter
            // 
            this.bangXepHangExtTableAdapter.ClearBeforeFill = true;
            // 
            // muaGiaiAllowNullTableAdapter
            // 
            this.muaGiaiAllowNullTableAdapter.ClearBeforeFill = true;
            // 
            // xuatBXH
            // 
            this.xuatBXH.Dock = System.Windows.Forms.DockStyle.Right;
            this.xuatBXH.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuatBXH.ForeColor = System.Drawing.SystemColors.Highlight;
            this.xuatBXH.Location = new System.Drawing.Point(865, 0);
            this.xuatBXH.Name = "xuatBXH";
            this.xuatBXH.Size = new System.Drawing.Size(163, 40);
            this.xuatBXH.TabIndex = 9;
            this.xuatBXH.Text = "Xuất ra tập tin";
            this.xuatBXH.UseVisualStyleBackColor = true;
            this.xuatBXH.Click += new System.EventHandler(this.xuatBXH_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.xuatBXH);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 569);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1028, 40);
            this.panel1.TabIndex = 10;
            // 
            // xepHangDataGridViewTextBoxColumn
            // 
            this.xepHangDataGridViewTextBoxColumn.DataPropertyName = "XepHang";
            this.xepHangDataGridViewTextBoxColumn.FillWeight = 40F;
            this.xepHangDataGridViewTextBoxColumn.HeaderText = "Xếp Hạng";
            this.xepHangDataGridViewTextBoxColumn.Name = "xepHangDataGridViewTextBoxColumn";
            // 
            // tenDoiDataGridViewTextBoxColumn
            // 
            this.tenDoiDataGridViewTextBoxColumn.DataPropertyName = "TenDoi";
            this.tenDoiDataGridViewTextBoxColumn.FillWeight = 109.6447F;
            this.tenDoiDataGridViewTextBoxColumn.HeaderText = "Tên Đội";
            this.tenDoiDataGridViewTextBoxColumn.Name = "tenDoiDataGridViewTextBoxColumn";
            // 
            // thangDataGridViewTextBoxColumn
            // 
            this.thangDataGridViewTextBoxColumn.DataPropertyName = "Thang";
            this.thangDataGridViewTextBoxColumn.FillWeight = 50F;
            this.thangDataGridViewTextBoxColumn.HeaderText = "Thắng";
            this.thangDataGridViewTextBoxColumn.Name = "thangDataGridViewTextBoxColumn";
            // 
            // hoaDataGridViewTextBoxColumn
            // 
            this.hoaDataGridViewTextBoxColumn.DataPropertyName = "Hoa";
            this.hoaDataGridViewTextBoxColumn.FillWeight = 40F;
            this.hoaDataGridViewTextBoxColumn.HeaderText = "Hòa";
            this.hoaDataGridViewTextBoxColumn.Name = "hoaDataGridViewTextBoxColumn";
            // 
            // thuaDataGridViewTextBoxColumn
            // 
            this.thuaDataGridViewTextBoxColumn.DataPropertyName = "Thua";
            this.thuaDataGridViewTextBoxColumn.FillWeight = 40F;
            this.thuaDataGridViewTextBoxColumn.HeaderText = "Thua";
            this.thuaDataGridViewTextBoxColumn.Name = "thuaDataGridViewTextBoxColumn";
            // 
            // diemDataGridViewTextBoxColumn
            // 
            this.diemDataGridViewTextBoxColumn.DataPropertyName = "Diem";
            this.diemDataGridViewTextBoxColumn.FillWeight = 70F;
            this.diemDataGridViewTextBoxColumn.HeaderText = "Điểm";
            this.diemDataGridViewTextBoxColumn.Name = "diemDataGridViewTextBoxColumn";
            // 
            // hieuSoDataGridViewTextBoxColumn
            // 
            this.hieuSoDataGridViewTextBoxColumn.DataPropertyName = "HieuSo";
            this.hieuSoDataGridViewTextBoxColumn.FillWeight = 70F;
            this.hieuSoDataGridViewTextBoxColumn.HeaderText = "Hiệu Số";
            this.hieuSoDataGridViewTextBoxColumn.Name = "hieuSoDataGridViewTextBoxColumn";
            // 
            // soBanThangSanKhachDataGridViewTextBoxColumn
            // 
            this.soBanThangSanKhachDataGridViewTextBoxColumn.DataPropertyName = "SoBanThangSanKhach";
            this.soBanThangSanKhachDataGridViewTextBoxColumn.FillWeight = 70F;
            this.soBanThangSanKhachDataGridViewTextBoxColumn.HeaderText = "Số Bàn Sân Khách";
            this.soBanThangSanKhachDataGridViewTextBoxColumn.Name = "soBanThangSanKhachDataGridViewTextBoxColumn";
            // 
            // MaDoi
            // 
            this.MaDoi.DataPropertyName = "MaDoi";
            this.MaDoi.FillWeight = 5F;
            this.MaDoi.HeaderText = "Mã Đội";
            this.MaDoi.Name = "MaDoi";
            this.MaDoi.Visible = false;
            // 
            // BangXepHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1028, 609);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.bangXepHangData);
            this.Controls.Add(this.thongTinPanel);
            this.Controls.Add(this.bxhPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1027, 605);
            this.Name = "BangXepHang";
            this.Text = "Phần mềm Quản Lý Giải Vô Địch Bóng Đá Quốc Gia - Kết Xuất Bảng Xếp Hạng";
            this.Load += new System.EventHandler(this.BangXepHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bangXepHangData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangXepHangExtBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyGiaiVoDichDataSet)).EndInit();
            this.thongTinPanel.ResumeLayout(false);
            this.thongTinPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.muaGiaiAllowNullBindingSource)).EndInit();
            this.bxhPanel.ResumeLayout(false);
            this.bxhPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView bangXepHangData;
        private System.Windows.Forms.Panel thongTinPanel;
        private System.Windows.Forms.Label thoiGianLabel;
        private System.Windows.Forms.Panel bxhPanel;
        private System.Windows.Forms.Label bangXepHangLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.ComboBox muaGiaiComboBox;
        private System.Windows.Forms.Label muaGiaiLabel;
        private System.Windows.Forms.DateTimePicker thoiGianPicker;
        private QuanLyGiaiVoDichDataSet quanLyGiaiVoDichDataSet;
        private System.Windows.Forms.BindingSource bangXepHangExtBindingSource;
        private QuanLyGiaiVoDichDataSetTableAdapters.BangXepHangExtTableAdapter bangXepHangExtTableAdapter;
        private System.Windows.Forms.BindingSource muaGiaiAllowNullBindingSource;
        private QuanLyGiaiVoDichDataSetTableAdapters.MuaGiaiAllowNullTableAdapter muaGiaiAllowNullTableAdapter;
        private System.Windows.Forms.Button xuatBXH;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn xepHangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDoiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thuaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hieuSoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soBanThangSanKhachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDoi;
    }
}