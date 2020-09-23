namespace QuanLyGiaiVoDich
{
    partial class KhoiTaoVongDau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KhoiTaoVongDau));
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tenVongDauTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.xoaVongDau = new System.Windows.Forms.Button();
            this.themVongDau = new System.Windows.Forms.Button();
            this.muaGiaiComboBox = new System.Windows.Forms.ComboBox();
            this.muaGiaiAllowNullBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyGiaiVoDichDataSet = new QuanLyGiaiVoDich.QuanLyGiaiVoDichDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.danhSachVongDauData = new System.Windows.Forms.DataGridView();
            this.maVongDauDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenVongDauDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vongDauBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vongDauTableAdapter = new QuanLyGiaiVoDich.QuanLyGiaiVoDichDataSetTableAdapters.VongDauTableAdapter();
            this.muaGiaiAllowNullTableAdapter = new QuanLyGiaiVoDich.QuanLyGiaiVoDichDataSetTableAdapters.MuaGiaiAllowNullTableAdapter();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.importButton = new System.Windows.Forms.Button();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.muaGiaiAllowNullBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyGiaiVoDichDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.danhSachVongDauData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vongDauBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Controls.Add(this.label17);
            this.panel5.Location = new System.Drawing.Point(6, 6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(788, 40);
            this.panel5.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackgroundImage = global::QuanLyGiaiVoDich.Properties.Resources.tournament_24pt;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(250, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label17.Location = new System.Drawing.Point(286, 10);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(225, 24);
            this.label17.TabIndex = 1;
            this.label17.Text = "KHỎI TẠO VÒNG ĐẤU";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.tenVongDauTextBox);
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Controls.Add(this.muaGiaiComboBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox1.Location = new System.Drawing.Point(6, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 386);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin vòng đấu";
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // tenVongDauTextBox
            // 
            this.tenVongDauTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.tenVongDauTextBox.Font = new System.Drawing.Font("Arial", 12F);
            this.tenVongDauTextBox.Location = new System.Drawing.Point(151, 20);
            this.tenVongDauTextBox.Name = "tenVongDauTextBox";
            this.tenVongDauTextBox.Size = new System.Drawing.Size(184, 26);
            this.tenVongDauTextBox.TabIndex = 23;
            this.tenVongDauTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TenVongDauTextBox_KeyDown);
            this.tenVongDauTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.TenVongDauTextBox_Validating);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.xoaVongDau, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.themVongDau, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.importButton, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 340);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(329, 40);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // xoaVongDau
            // 
            this.xoaVongDau.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.xoaVongDau.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xoaVongDau.Enabled = false;
            this.xoaVongDau.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xoaVongDau.ForeColor = System.Drawing.SystemColors.Highlight;
            this.xoaVongDau.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.xoaVongDau.Location = new System.Drawing.Point(112, 3);
            this.xoaVongDau.Name = "xoaVongDau";
            this.xoaVongDau.Size = new System.Drawing.Size(103, 34);
            this.xoaVongDau.TabIndex = 6;
            this.xoaVongDau.Text = "Xóa";
            this.xoaVongDau.UseVisualStyleBackColor = false;
            this.xoaVongDau.Click += new System.EventHandler(this.xoaVongDau_Click);
            // 
            // themVongDau
            // 
            this.themVongDau.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.themVongDau.Dock = System.Windows.Forms.DockStyle.Fill;
            this.themVongDau.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.themVongDau.ForeColor = System.Drawing.SystemColors.Highlight;
            this.themVongDau.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.themVongDau.Location = new System.Drawing.Point(3, 3);
            this.themVongDau.Name = "themVongDau";
            this.themVongDau.Size = new System.Drawing.Size(103, 34);
            this.themVongDau.TabIndex = 7;
            this.themVongDau.Text = "Thêm";
            this.themVongDau.UseVisualStyleBackColor = false;
            this.themVongDau.Click += new System.EventHandler(this.themVongDau_Click);
            // 
            // muaGiaiComboBox
            // 
            this.muaGiaiComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(252)))));
            this.muaGiaiComboBox.DataSource = this.muaGiaiAllowNullBindingSource;
            this.muaGiaiComboBox.DisplayMember = "TenMuaGiai";
            this.muaGiaiComboBox.Enabled = false;
            this.muaGiaiComboBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.muaGiaiComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(156)))), ((int)(((byte)(217)))));
            this.muaGiaiComboBox.FormattingEnabled = true;
            this.muaGiaiComboBox.Location = new System.Drawing.Point(151, 70);
            this.muaGiaiComboBox.Name = "muaGiaiComboBox";
            this.muaGiaiComboBox.Size = new System.Drawing.Size(184, 27);
            this.muaGiaiComboBox.TabIndex = 3;
            this.muaGiaiComboBox.ValueMember = "MaMuaGiai";
            // 
            // muaGiaiAllowNullBindingSource
            // 
            this.muaGiaiAllowNullBindingSource.DataMember = "MuaGiaiAllowNull";
            this.muaGiaiAllowNullBindingSource.DataSource = this.quanLyGiaiVoDichDataSet;
            // 
            // quanLyGiaiVoDichDataSet
            // 
            this.quanLyGiaiVoDichDataSet.DataSetName = "QuanLyGiaiVoDichDataSet";
            this.quanLyGiaiVoDichDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(6, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mùa Giải";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Vòng Đấu";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.danhSachVongDauData);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox2.Location = new System.Drawing.Point(356, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(438, 386);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Vòng Đấu";
            // 
            // danhSachVongDauData
            // 
            this.danhSachVongDauData.AllowUserToAddRows = false;
            this.danhSachVongDauData.AllowUserToDeleteRows = false;
            this.danhSachVongDauData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.danhSachVongDauData.AutoGenerateColumns = false;
            this.danhSachVongDauData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.danhSachVongDauData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.danhSachVongDauData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.danhSachVongDauData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maVongDauDataGridViewTextBoxColumn,
            this.tenVongDauDataGridViewTextBoxColumn});
            this.danhSachVongDauData.DataSource = this.vongDauBindingSource;
            this.danhSachVongDauData.Location = new System.Drawing.Point(6, 20);
            this.danhSachVongDauData.Name = "danhSachVongDauData";
            this.danhSachVongDauData.RowHeadersWidth = 51;
            this.danhSachVongDauData.Size = new System.Drawing.Size(426, 355);
            this.danhSachVongDauData.TabIndex = 0;
            this.danhSachVongDauData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.danhSachVongDauData_CellClick);
            this.danhSachVongDauData.Leave += new System.EventHandler(this.danhSachVongDauData_Leave);
            // 
            // maVongDauDataGridViewTextBoxColumn
            // 
            this.maVongDauDataGridViewTextBoxColumn.DataPropertyName = "MaVongDau";
            this.maVongDauDataGridViewTextBoxColumn.HeaderText = "Mã Vòng Đấu";
            this.maVongDauDataGridViewTextBoxColumn.Name = "maVongDauDataGridViewTextBoxColumn";
            // 
            // tenVongDauDataGridViewTextBoxColumn
            // 
            this.tenVongDauDataGridViewTextBoxColumn.DataPropertyName = "TenVongDau";
            this.tenVongDauDataGridViewTextBoxColumn.HeaderText = "Tên Vòng Đấu";
            this.tenVongDauDataGridViewTextBoxColumn.Name = "tenVongDauDataGridViewTextBoxColumn";
            // 
            // vongDauBindingSource
            // 
            this.vongDauBindingSource.DataMember = "VongDau";
            this.vongDauBindingSource.DataSource = this.quanLyGiaiVoDichDataSet;
            // 
            // vongDauTableAdapter
            // 
            this.vongDauTableAdapter.ClearBeforeFill = true;
            // 
            // muaGiaiAllowNullTableAdapter
            // 
            this.muaGiaiAllowNullTableAdapter.ClearBeforeFill = true;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // importButton
            // 
            this.importButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.importButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importButton.Location = new System.Drawing.Point(221, 3);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(105, 34);
            this.importButton.TabIndex = 8;
            this.importButton.Text = "Nhập từ file";
            this.importButton.UseVisualStyleBackColor = true;
            this.importButton.Click += new System.EventHandler(this.importButton_Click);
            // 
            // KhoiTaoVongDau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "KhoiTaoVongDau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm Quản Lý Giải Vô Địch Bóng Đá Quốc Gia - Khởi Tạo Vòng Đấu";
            this.Load += new System.EventHandler(this.KhoiTaoVongDau_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.muaGiaiAllowNullBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyGiaiVoDichDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.danhSachVongDauData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vongDauBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox muaGiaiComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView danhSachVongDauData;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button xoaVongDau;
        private System.Windows.Forms.Button themVongDau;
        private System.Windows.Forms.TextBox tenVongDauTextBox;
        private QuanLyGiaiVoDichDataSet quanLyGiaiVoDichDataSet;
        private System.Windows.Forms.BindingSource vongDauBindingSource;
        private QuanLyGiaiVoDichDataSetTableAdapters.VongDauTableAdapter vongDauTableAdapter;
        private System.Windows.Forms.BindingSource muaGiaiAllowNullBindingSource;
        private QuanLyGiaiVoDichDataSetTableAdapters.MuaGiaiAllowNullTableAdapter muaGiaiAllowNullTableAdapter;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.DataGridViewTextBoxColumn maVongDauDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenVongDauDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button importButton;
    }
}