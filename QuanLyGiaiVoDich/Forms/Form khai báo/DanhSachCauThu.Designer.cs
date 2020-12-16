using DAO_QLBongDa;

namespace QuanLyGiaiVoDich
{
    partial class DanhSachCauThu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DanhSachCauThu));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.danhSachCauThuList = new System.Windows.Forms.ListBox();
            this.cauThuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyGiaiVoDichDataSet = new DAO_QLBongDa.QuanLyGiaiVoDichDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.themCauThu = new System.Windows.Forms.Button();
            this.cauThuTableAdapter = new DAO_QLBongDa.QuanLyGiaiVoDichDataSetTableAdapters.CauThuTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cauThuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyGiaiVoDichDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.danhSachCauThuList);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(576, 385);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Cầu Thủ";
            // 
            // danhSachCauThuList
            // 
            this.danhSachCauThuList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.danhSachCauThuList.DataSource = this.cauThuBindingSource;
            this.danhSachCauThuList.DisplayMember = "cauThuSoAo";
            this.danhSachCauThuList.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.danhSachCauThuList.FormattingEnabled = true;
            this.danhSachCauThuList.ItemHeight = 18;
            this.danhSachCauThuList.Location = new System.Drawing.Point(6, 20);
            this.danhSachCauThuList.Name = "danhSachCauThuList";
            this.danhSachCauThuList.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.danhSachCauThuList.Size = new System.Drawing.Size(564, 346);
            this.danhSachCauThuList.TabIndex = 0;
            this.danhSachCauThuList.ValueMember = "MaCauThu";
            // 
            // cauThuBindingSource
            // 
            this.cauThuBindingSource.DataMember = "CauThu";
            this.cauThuBindingSource.DataSource = this.quanLyGiaiVoDichDataSet;
            // 
            // quanLyGiaiVoDichDataSet
            // 
            this.quanLyGiaiVoDichDataSet.DataSetName = "QuanLyGiaiVoDichDataSet";
            this.quanLyGiaiVoDichDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.themCauThu);
            this.panel1.Location = new System.Drawing.Point(13, 405);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(576, 41);
            this.panel1.TabIndex = 1;
            // 
            // themCauThu
            // 
            this.themCauThu.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.themCauThu.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.themCauThu.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.themCauThu.ForeColor = System.Drawing.SystemColors.Highlight;
            this.themCauThu.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.themCauThu.Location = new System.Drawing.Point(471, 5);
            this.themCauThu.Name = "themCauThu";
            this.themCauThu.Size = new System.Drawing.Size(99, 30);
            this.themCauThu.TabIndex = 5;
            this.themCauThu.Text = "Thêm";
            this.themCauThu.UseVisualStyleBackColor = false;
            this.themCauThu.Click += new System.EventHandler(this.themCauThu_Click);
            // 
            // cauThuTableAdapter
            // 
            this.cauThuTableAdapter.ClearBeforeFill = true;
            // 
            // DanhSachCauThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(601, 456);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(617, 495);
            this.MinimumSize = new System.Drawing.Size(617, 495);
            this.Name = "DanhSachCauThu";
            this.Text = "Phần mềm Quản Lý Giải Vô Địch Bóng Đá Quốc Gia - Chọn Cầu Thủ";
            this.Load += new System.EventHandler(this.DanhSachCauThu_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cauThuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyGiaiVoDichDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox danhSachCauThuList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button themCauThu;
        private QuanLyGiaiVoDichDataSet quanLyGiaiVoDichDataSet;
        private System.Windows.Forms.BindingSource cauThuBindingSource;
        private DAO_QLBongDa.QuanLyGiaiVoDichDataSetTableAdapters.CauThuTableAdapter cauThuTableAdapter;
    }
}