namespace QuanLyGiaiVoDich
{
    partial class DanhSachGhiBan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DanhSachGhiBan));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.danhSachGhiBanData = new System.Windows.Forms.DataGridView();
            this.cauThuExtBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyGiaiVoDichDataSet = new QuanLyGiaiVoDich.QuanLyGiaiVoDichDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.muaGiaiComboBox = new System.Windows.Forms.ComboBox();
            this.muaGiaiAllowNullBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.xuatDanhSachGhiBan = new System.Windows.Forms.Button();
            this.cauThuExtTableAdapter = new QuanLyGiaiVoDich.QuanLyGiaiVoDichDataSetTableAdapters.CauThuExtTableAdapter();
            this.muaGiaiAllowNullTableAdapter = new QuanLyGiaiVoDich.QuanLyGiaiVoDichDataSetTableAdapters.MuaGiaiAllowNullTableAdapter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.xuatGhiBan = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.SoThuTu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoAo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenCauThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoaiCauThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoBanThang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhSachGhiBanData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cauThuExtBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyGiaiVoDichDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.muaGiaiAllowNullBindingSource)).BeginInit();
            this.panel9.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1028, 40);
            this.panel2.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackgroundImage = global::QuanLyGiaiVoDich.Properties.Resources.list;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(408, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label15.Location = new System.Drawing.Point(444, 10);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(320, 24);
            this.label15.TabIndex = 1;
            this.label15.Text = "DANH SÁCH CẦU THỦ GHI BÀN";
            // 
            // danhSachGhiBanData
            // 
            this.danhSachGhiBanData.AllowUserToAddRows = false;
            this.danhSachGhiBanData.AllowUserToDeleteRows = false;
            this.danhSachGhiBanData.AutoGenerateColumns = false;
            this.danhSachGhiBanData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.danhSachGhiBanData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.danhSachGhiBanData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.danhSachGhiBanData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SoThuTu,
            this.SoAo,
            this.TenCauThu,
            this.NgaySinh,
            this.TenDoi,
            this.TenLoaiCauThu,
            this.SoBanThang});
            this.danhSachGhiBanData.DataSource = this.cauThuExtBindingSource;
            this.danhSachGhiBanData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.danhSachGhiBanData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.danhSachGhiBanData.Location = new System.Drawing.Point(0, 0);
            this.danhSachGhiBanData.Name = "danhSachGhiBanData";
            this.danhSachGhiBanData.Size = new System.Drawing.Size(1028, 450);
            this.danhSachGhiBanData.TabIndex = 4;
            // 
            // cauThuExtBindingSource
            // 
            this.cauThuExtBindingSource.DataMember = "CauThuExt";
            this.cauThuExtBindingSource.DataSource = this.quanLyGiaiVoDichDataSet;
            // 
            // quanLyGiaiVoDichDataSet
            // 
            this.quanLyGiaiVoDichDataSet.DataSetName = "QuanLyGiaiVoDichDataSet";
            this.quanLyGiaiVoDichDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.muaGiaiComboBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1028, 119);
            this.panel1.TabIndex = 7;
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
            this.muaGiaiComboBox.Location = new System.Drawing.Point(497, 21);
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
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(404, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mùa Giải";
            // 
            // panel9
            // 
            this.panel9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel9.BackColor = System.Drawing.Color.Transparent;
            this.panel9.Controls.Add(this.xuatDanhSachGhiBan);
            this.panel9.Location = new System.Drawing.Point(6, 676);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1030, 40);
            this.panel9.TabIndex = 9;
            // 
            // xuatDanhSachGhiBan
            // 
            this.xuatDanhSachGhiBan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.xuatDanhSachGhiBan.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.xuatDanhSachGhiBan.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuatDanhSachGhiBan.ForeColor = System.Drawing.SystemColors.Highlight;
            this.xuatDanhSachGhiBan.Location = new System.Drawing.Point(872, 5);
            this.xuatDanhSachGhiBan.Name = "xuatDanhSachGhiBan";
            this.xuatDanhSachGhiBan.Size = new System.Drawing.Size(150, 30);
            this.xuatDanhSachGhiBan.TabIndex = 12;
            this.xuatDanhSachGhiBan.Text = "Xuất Danh Sách";
            this.xuatDanhSachGhiBan.UseVisualStyleBackColor = false;
            // 
            // cauThuExtTableAdapter
            // 
            this.cauThuExtTableAdapter.ClearBeforeFill = true;
            // 
            // muaGiaiAllowNullTableAdapter
            // 
            this.muaGiaiAllowNullTableAdapter.ClearBeforeFill = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.danhSachGhiBanData);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 159);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1028, 450);
            this.panel3.TabIndex = 10;
            // 
            // xuatGhiBan
            // 
            this.xuatGhiBan.Dock = System.Windows.Forms.DockStyle.Right;
            this.xuatGhiBan.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuatGhiBan.ForeColor = System.Drawing.SystemColors.Highlight;
            this.xuatGhiBan.Location = new System.Drawing.Point(862, 0);
            this.xuatGhiBan.Name = "xuatGhiBan";
            this.xuatGhiBan.Size = new System.Drawing.Size(166, 39);
            this.xuatGhiBan.TabIndex = 11;
            this.xuatGhiBan.Text = "Xuất ra tập tin";
            this.xuatGhiBan.UseVisualStyleBackColor = true;
            this.xuatGhiBan.Click += new System.EventHandler(this.xuatGhiBan_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.xuatGhiBan);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 570);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1028, 39);
            this.panel4.TabIndex = 12;
            // 
            // SoThuTu
            // 
            this.SoThuTu.FillWeight = 40F;
            this.SoThuTu.HeaderText = "STT";
            this.SoThuTu.Name = "SoThuTu";
            // 
            // SoAo
            // 
            this.SoAo.DataPropertyName = "SoAo";
            this.SoAo.FillWeight = 40F;
            this.SoAo.HeaderText = "Số Áo";
            this.SoAo.Name = "SoAo";
            // 
            // TenCauThu
            // 
            this.TenCauThu.DataPropertyName = "TenCauThu";
            this.TenCauThu.HeaderText = "Tên Cầu Thủ";
            this.TenCauThu.Name = "TenCauThu";
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.FillWeight = 80F;
            this.NgaySinh.HeaderText = "Ngày Sinh";
            this.NgaySinh.Name = "NgaySinh";
            // 
            // TenDoi
            // 
            this.TenDoi.DataPropertyName = "TenDoi";
            this.TenDoi.HeaderText = "Đội Bóng";
            this.TenDoi.Name = "TenDoi";
            // 
            // TenLoaiCauThu
            // 
            this.TenLoaiCauThu.DataPropertyName = "TenLoaiCauThu";
            this.TenLoaiCauThu.FillWeight = 80F;
            this.TenLoaiCauThu.HeaderText = "Loại Cầu Thủ";
            this.TenLoaiCauThu.Name = "TenLoaiCauThu";
            // 
            // SoBanThang
            // 
            this.SoBanThang.DataPropertyName = "SoBanThang";
            this.SoBanThang.FillWeight = 80F;
            this.SoBanThang.HeaderText = "Số Bàn Thắng";
            this.SoBanThang.Name = "SoBanThang";
            // 
            // DanhSachGhiBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1028, 609);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1027, 605);
            this.Name = "DanhSachGhiBan";
            this.Text = "Phần mềm Quản Lý Giải Vô Địch Bóng Đá Quốc Gia - Danh Sách Cầu Thủ Ghi Bàn";
            this.Load += new System.EventHandler(this.DanhSachGhiBan_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.danhSachGhiBanData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cauThuExtBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyGiaiVoDichDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.muaGiaiAllowNullBindingSource)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView danhSachGhiBanData;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox muaGiaiComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button xuatDanhSachGhiBan;
        private System.Windows.Forms.PictureBox pictureBox1;
        private QuanLyGiaiVoDichDataSet quanLyGiaiVoDichDataSet;
        private System.Windows.Forms.BindingSource cauThuExtBindingSource;
        private QuanLyGiaiVoDichDataSetTableAdapters.CauThuExtTableAdapter cauThuExtTableAdapter;
        private System.Windows.Forms.BindingSource muaGiaiAllowNullBindingSource;
        private QuanLyGiaiVoDichDataSetTableAdapters.MuaGiaiAllowNullTableAdapter muaGiaiAllowNullTableAdapter;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button xuatGhiBan;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoThuTu;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoAo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenCauThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoaiCauThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoBanThang;
    }
}