using DAO_QLBongDa;

namespace QuanLyGiaiVoDich.Forms.Form_khai_báo
{
    partial class DanhSachTranDau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DanhSachTranDau));
            this.danhSachTranDauData = new System.Windows.Forms.DataGridView();
            this.maTranDauDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenVongDauDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDoiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDoi2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayThiDauDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioThiDauDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSanThiDauDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lichThiDauExtBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyGiaiVoDichDataSet = new DAO_QLBongDa.QuanLyGiaiVoDichDataSet();
            this.lichThiDauExtTableAdapter = new DAO_QLBongDa.QuanLyGiaiVoDichDataSetTableAdapters.LichThiDauExtTableAdapter();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tieuDeForm = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.danhSachTranDauData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lichThiDauExtBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyGiaiVoDichDataSet)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // danhSachTranDauData
            // 
            this.danhSachTranDauData.AllowUserToAddRows = false;
            this.danhSachTranDauData.AllowUserToDeleteRows = false;
            this.danhSachTranDauData.AutoGenerateColumns = false;
            this.danhSachTranDauData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.danhSachTranDauData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.danhSachTranDauData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maTranDauDataGridViewTextBoxColumn,
            this.tenVongDauDataGridViewTextBoxColumn,
            this.tenDoiDataGridViewTextBoxColumn,
            this.tenDoi2DataGridViewTextBoxColumn,
            this.ngayThiDauDataGridViewTextBoxColumn,
            this.gioThiDauDataGridViewTextBoxColumn,
            this.tenSanThiDauDataGridViewTextBoxColumn});
            this.danhSachTranDauData.DataSource = this.lichThiDauExtBindingSource;
            this.danhSachTranDauData.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.danhSachTranDauData.Location = new System.Drawing.Point(0, 52);
            this.danhSachTranDauData.MinimumSize = new System.Drawing.Size(800, 398);
            this.danhSachTranDauData.Name = "danhSachTranDauData";
            this.danhSachTranDauData.Size = new System.Drawing.Size(800, 398);
            this.danhSachTranDauData.TabIndex = 0;
            this.danhSachTranDauData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.danhSachTranDauData_CellClick);
            // 
            // maTranDauDataGridViewTextBoxColumn
            // 
            this.maTranDauDataGridViewTextBoxColumn.DataPropertyName = "MaTranDau";
            this.maTranDauDataGridViewTextBoxColumn.HeaderText = "Mã Trận Đấu";
            this.maTranDauDataGridViewTextBoxColumn.Name = "maTranDauDataGridViewTextBoxColumn";
            // 
            // tenVongDauDataGridViewTextBoxColumn
            // 
            this.tenVongDauDataGridViewTextBoxColumn.DataPropertyName = "TenVongDau";
            this.tenVongDauDataGridViewTextBoxColumn.HeaderText = "Vòng Đấu";
            this.tenVongDauDataGridViewTextBoxColumn.Name = "tenVongDauDataGridViewTextBoxColumn";
            // 
            // tenDoiDataGridViewTextBoxColumn
            // 
            this.tenDoiDataGridViewTextBoxColumn.DataPropertyName = "TenDoi";
            this.tenDoiDataGridViewTextBoxColumn.HeaderText = "Đội Nhà";
            this.tenDoiDataGridViewTextBoxColumn.Name = "tenDoiDataGridViewTextBoxColumn";
            // 
            // tenDoi2DataGridViewTextBoxColumn
            // 
            this.tenDoi2DataGridViewTextBoxColumn.DataPropertyName = "TenDoi2";
            this.tenDoi2DataGridViewTextBoxColumn.HeaderText = "Đội Khách";
            this.tenDoi2DataGridViewTextBoxColumn.Name = "tenDoi2DataGridViewTextBoxColumn";
            // 
            // ngayThiDauDataGridViewTextBoxColumn
            // 
            this.ngayThiDauDataGridViewTextBoxColumn.DataPropertyName = "NgayThiDau";
            this.ngayThiDauDataGridViewTextBoxColumn.HeaderText = "Ngày Thi Đấu";
            this.ngayThiDauDataGridViewTextBoxColumn.Name = "ngayThiDauDataGridViewTextBoxColumn";
            // 
            // gioThiDauDataGridViewTextBoxColumn
            // 
            this.gioThiDauDataGridViewTextBoxColumn.DataPropertyName = "GioThiDau";
            this.gioThiDauDataGridViewTextBoxColumn.HeaderText = "Giờ Thi Đấu";
            this.gioThiDauDataGridViewTextBoxColumn.Name = "gioThiDauDataGridViewTextBoxColumn";
            // 
            // tenSanThiDauDataGridViewTextBoxColumn
            // 
            this.tenSanThiDauDataGridViewTextBoxColumn.DataPropertyName = "TenSanThiDau";
            this.tenSanThiDauDataGridViewTextBoxColumn.HeaderText = "Sân Thi Đấu";
            this.tenSanThiDauDataGridViewTextBoxColumn.Name = "tenSanThiDauDataGridViewTextBoxColumn";
            // 
            // lichThiDauExtBindingSource
            // 
            this.lichThiDauExtBindingSource.DataMember = "LichThiDauExt";
            this.lichThiDauExtBindingSource.DataSource = this.quanLyGiaiVoDichDataSet;
            // 
            // quanLyGiaiVoDichDataSet
            // 
            this.quanLyGiaiVoDichDataSet.DataSetName = "QuanLyGiaiVoDichDataSet";
            this.quanLyGiaiVoDichDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lichThiDauExtTableAdapter
            // 
            this.lichThiDauExtTableAdapter.ClearBeforeFill = true;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Controls.Add(this.tieuDeForm);
            this.panel5.Location = new System.Drawing.Point(6, 6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(788, 40);
            this.panel5.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackgroundImage = global::QuanLyGiaiVoDich.Properties.Resources.mega_ball_24pt;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(181, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // tieuDeForm
            // 
            this.tieuDeForm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tieuDeForm.AutoSize = true;
            this.tieuDeForm.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tieuDeForm.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.tieuDeForm.Location = new System.Drawing.Point(217, 10);
            this.tieuDeForm.Name = "tieuDeForm";
            this.tieuDeForm.Size = new System.Drawing.Size(442, 24);
            this.tieuDeForm.TabIndex = 1;
            this.tieuDeForm.Text = "CHỌN TRẬN ĐẤU LẬP KẾT QUẢ TRẬN ĐẤU";
            // 
            // DanhSachTranDau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.danhSachTranDauData);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DanhSachTranDau";
            this.Text = "Phần mềm Quản Lý Giải Vô Địch Bóng Đá Quốc Gia - Chọn Trận Đấu";
            this.Load += new System.EventHandler(this.DanhSachTranDau_Load);
            ((System.ComponentModel.ISupportInitialize)(this.danhSachTranDauData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lichThiDauExtBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyGiaiVoDichDataSet)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView danhSachTranDauData;
        private QuanLyGiaiVoDichDataSet quanLyGiaiVoDichDataSet;
        private System.Windows.Forms.BindingSource lichThiDauExtBindingSource;
        private DAO_QLBongDa.QuanLyGiaiVoDichDataSetTableAdapters.LichThiDauExtTableAdapter lichThiDauExtTableAdapter;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label tieuDeForm;
        private System.Windows.Forms.DataGridViewTextBoxColumn maTranDauDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenVongDauDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDoiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDoi2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayThiDauDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioThiDauDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSanThiDauDataGridViewTextBoxColumn;
    }
}