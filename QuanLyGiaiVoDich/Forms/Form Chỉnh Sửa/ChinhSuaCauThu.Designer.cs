using DAO_QLBongDa;

namespace QuanLyGiaiVoDich
{
    partial class ChinhSuaCauThu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChinhSuaCauThu));
            this.label11 = new System.Windows.Forms.Label();
            this.ngaySinhLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ngaySinhPicker = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.loaiCauThuComboBox = new System.Windows.Forms.ComboBox();
            this.loaiCauThuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyGiaiVoDichDataSet = new DAO_QLBongDa.QuanLyGiaiVoDichDataSet();
            this.hoTenTextBox = new System.Windows.Forms.TextBox();
            this.doiBongComboBox = new System.Windows.Forms.ComboBox();
            this.doiBongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loaiCauThuLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.maCauThuTextBox = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.doiBongLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.xoaButton = new System.Windows.Forms.Button();
            this.capNhatButton = new System.Windows.Forms.Button();
            this.label29 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.maCauThuLabel = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ghiChuBox = new System.Windows.Forms.GroupBox();
            this.ghiChuEditBox = new System.Windows.Forms.TextBox();
            this.soAoLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.soBanThangLabel = new System.Windows.Forms.Label();
            this.tenCauThuLabel = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.chonSoAo = new System.Windows.Forms.NumericUpDown();
            this.chonSoAoLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.doiBongTableAdapter = new DAO_QLBongDa.QuanLyGiaiVoDichDataSetTableAdapters.DoiBongTableAdapter();
            this.loaiCauThuTableAdapter = new DAO_QLBongDa.QuanLyGiaiVoDichDataSetTableAdapters.LoaiCauThuTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.loaiCauThuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyGiaiVoDichDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doiBongBindingSource)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.ghiChuBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chonSoAo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(249, 278);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 19);
            this.label11.TabIndex = 28;
            this.label11.Text = "Số Bàn Thắng";
            // 
            // ngaySinhLabel
            // 
            this.ngaySinhLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ngaySinhLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngaySinhLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ngaySinhLabel.Location = new System.Drawing.Point(421, 224);
            this.ngaySinhLabel.Name = "ngaySinhLabel";
            this.ngaySinhLabel.Size = new System.Drawing.Size(201, 18);
            this.ngaySinhLabel.TabIndex = 26;
            this.ngaySinhLabel.Text = "6/17/2020";
            this.ngaySinhLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(249, 226);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 19);
            this.label8.TabIndex = 25;
            this.label8.Text = "Ngày Sinh";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(252, 206);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(370, 1);
            this.panel2.TabIndex = 24;
            // 
            // ngaySinhPicker
            // 
            this.ngaySinhPicker.Font = new System.Drawing.Font("Arial", 12F);
            this.ngaySinhPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ngaySinhPicker.Location = new System.Drawing.Point(152, 263);
            this.ngaySinhPicker.Name = "ngaySinhPicker";
            this.ngaySinhPicker.Size = new System.Drawing.Size(182, 26);
            this.ngaySinhPicker.TabIndex = 39;
            this.ngaySinhPicker.Validating += new System.ComponentModel.CancelEventHandler(this.NgaySinhPicker_Validating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(6, 269);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 18);
            this.label9.TabIndex = 37;
            this.label9.Text = "Ngày Sinh";
            // 
            // loaiCauThuComboBox
            // 
            this.loaiCauThuComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.loaiCauThuComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.loaiCauThuComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(252)))));
            this.loaiCauThuComboBox.DataSource = this.loaiCauThuBindingSource;
            this.loaiCauThuComboBox.DisplayMember = "TenLoaiCauThu";
            this.loaiCauThuComboBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loaiCauThuComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(156)))), ((int)(((byte)(217)))));
            this.loaiCauThuComboBox.FormattingEnabled = true;
            this.loaiCauThuComboBox.ImeMode = System.Windows.Forms.ImeMode.HangulFull;
            this.loaiCauThuComboBox.Location = new System.Drawing.Point(151, 215);
            this.loaiCauThuComboBox.Name = "loaiCauThuComboBox";
            this.loaiCauThuComboBox.Size = new System.Drawing.Size(182, 27);
            this.loaiCauThuComboBox.TabIndex = 30;
            this.loaiCauThuComboBox.ValueMember = "MaLoaiCauThu";
            // 
            // loaiCauThuBindingSource
            // 
            this.loaiCauThuBindingSource.DataMember = "LoaiCauThu";
            this.loaiCauThuBindingSource.DataSource = this.quanLyGiaiVoDichDataSet;
            // 
            // quanLyGiaiVoDichDataSet
            // 
            this.quanLyGiaiVoDichDataSet.DataSetName = "QuanLyGiaiVoDichDataSet";
            this.quanLyGiaiVoDichDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hoTenTextBox
            // 
            this.hoTenTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.hoTenTextBox.Font = new System.Drawing.Font("Arial", 12F);
            this.hoTenTextBox.Location = new System.Drawing.Point(151, 70);
            this.hoTenTextBox.Name = "hoTenTextBox";
            this.hoTenTextBox.Size = new System.Drawing.Size(182, 26);
            this.hoTenTextBox.TabIndex = 29;
            this.hoTenTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.HoTenTextBox_Validating);
            // 
            // doiBongComboBox
            // 
            this.doiBongComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.doiBongComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.doiBongComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(252)))));
            this.doiBongComboBox.DataSource = this.doiBongBindingSource;
            this.doiBongComboBox.DisplayMember = "TenDoi";
            this.doiBongComboBox.Enabled = false;
            this.doiBongComboBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doiBongComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(156)))), ((int)(((byte)(217)))));
            this.doiBongComboBox.FormattingEnabled = true;
            this.doiBongComboBox.ImeMode = System.Windows.Forms.ImeMode.HangulFull;
            this.doiBongComboBox.Location = new System.Drawing.Point(152, 170);
            this.doiBongComboBox.Name = "doiBongComboBox";
            this.doiBongComboBox.Size = new System.Drawing.Size(182, 27);
            this.doiBongComboBox.TabIndex = 28;
            this.doiBongComboBox.ValueMember = "MaDoi";
            // 
            // doiBongBindingSource
            // 
            this.doiBongBindingSource.DataMember = "DoiBong";
            this.doiBongBindingSource.DataSource = this.quanLyGiaiVoDichDataSet;
            // 
            // loaiCauThuLabel
            // 
            this.loaiCauThuLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.loaiCauThuLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loaiCauThuLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.loaiCauThuLabel.Location = new System.Drawing.Point(418, 174);
            this.loaiCauThuLabel.Name = "loaiCauThuLabel";
            this.loaiCauThuLabel.Size = new System.Drawing.Size(207, 18);
            this.loaiCauThuLabel.TabIndex = 23;
            this.loaiCauThuLabel.Text = "Nước Ngoài";
            this.loaiCauThuLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(249, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 19);
            this.label6.TabIndex = 22;
            this.label6.Text = "Loại Cầu Thủ";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Arial", 12F);
            this.label21.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label21.Location = new System.Drawing.Point(6, 222);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(101, 18);
            this.label21.TabIndex = 22;
            this.label21.Text = "Loại Cầu Thủ";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Arial", 12F);
            this.label23.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label23.Location = new System.Drawing.Point(6, 175);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(74, 18);
            this.label23.TabIndex = 18;
            this.label23.Text = "Đội Bóng";
            // 
            // maCauThuTextBox
            // 
            this.maCauThuTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.maCauThuTextBox.Enabled = false;
            this.maCauThuTextBox.Font = new System.Drawing.Font("Arial", 12F);
            this.maCauThuTextBox.Location = new System.Drawing.Point(151, 20);
            this.maCauThuTextBox.Name = "maCauThuTextBox";
            this.maCauThuTextBox.Size = new System.Drawing.Size(182, 26);
            this.maCauThuTextBox.TabIndex = 16;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Arial", 12F);
            this.label28.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label28.Location = new System.Drawing.Point(6, 74);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(58, 18);
            this.label28.TabIndex = 17;
            this.label28.Text = "Họ Tên";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(252, 258);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(370, 1);
            this.panel4.TabIndex = 27;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(252, 154);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(370, 1);
            this.panel3.TabIndex = 21;
            // 
            // doiBongLabel
            // 
            this.doiBongLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.doiBongLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doiBongLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.doiBongLabel.Location = new System.Drawing.Point(415, 122);
            this.doiBongLabel.Name = "doiBongLabel";
            this.doiBongLabel.Size = new System.Drawing.Size(207, 18);
            this.doiBongLabel.TabIndex = 20;
            this.doiBongLabel.Text = "Real Marid";
            this.doiBongLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(249, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 19);
            this.label2.TabIndex = 19;
            this.label2.Text = "Đội Bóng";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.xoaButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.capNhatButton, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 396);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(328, 41);
            this.tableLayoutPanel2.TabIndex = 21;
            // 
            // xoaButton
            // 
            this.xoaButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.xoaButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.xoaButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xoaButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.xoaButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.xoaButton.Location = new System.Drawing.Point(167, 5);
            this.xoaButton.Name = "xoaButton";
            this.xoaButton.Size = new System.Drawing.Size(158, 30);
            this.xoaButton.TabIndex = 8;
            this.xoaButton.Text = "Rời khỏi đội bóng";
            this.xoaButton.UseVisualStyleBackColor = false;
            this.xoaButton.Click += new System.EventHandler(this.xoaButton_Click);
            // 
            // capNhatButton
            // 
            this.capNhatButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.capNhatButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.capNhatButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.capNhatButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.capNhatButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.capNhatButton.Location = new System.Drawing.Point(3, 5);
            this.capNhatButton.Name = "capNhatButton";
            this.capNhatButton.Size = new System.Drawing.Size(158, 30);
            this.capNhatButton.TabIndex = 7;
            this.capNhatButton.Text = "Cập Nhật Thông Tin";
            this.capNhatButton.UseVisualStyleBackColor = false;
            this.capNhatButton.Click += new System.EventHandler(this.CapNhatButton_Click);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Arial", 12F);
            this.label29.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label29.Location = new System.Drawing.Point(6, 24);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(92, 18);
            this.label29.TabIndex = 0;
            this.label29.Text = "Mã Cầu Thủ";
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Location = new System.Drawing.Point(252, 102);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(370, 1);
            this.panel6.TabIndex = 33;
            // 
            // maCauThuLabel
            // 
            this.maCauThuLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.maCauThuLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maCauThuLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.maCauThuLabel.Location = new System.Drawing.Point(412, 70);
            this.maCauThuLabel.Name = "maCauThuLabel";
            this.maCauThuLabel.Size = new System.Drawing.Size(210, 18);
            this.maCauThuLabel.TabIndex = 32;
            this.maCauThuLabel.Text = "RA10";
            this.maCauThuLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label13.Location = new System.Drawing.Point(249, 70);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 19);
            this.label13.TabIndex = 31;
            this.label13.Text = "Mã Cầu Thủ";
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Location = new System.Drawing.Point(252, 310);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(370, 1);
            this.panel5.TabIndex = 30;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.ghiChuBox);
            this.groupBox1.Controls.Add(this.soAoLabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.panel7);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.panel6);
            this.groupBox1.Controls.Add(this.maCauThuLabel);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.panel5);
            this.groupBox1.Controls.Add(this.soBanThangLabel);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.ngaySinhLabel);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.loaiCauThuLabel);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.doiBongLabel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tenCauThuLabel);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox1.Location = new System.Drawing.Point(357, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(642, 441);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hồ sơ cầu thủ ";
            // 
            // ghiChuBox
            // 
            this.ghiChuBox.Controls.Add(this.ghiChuEditBox);
            this.ghiChuBox.Location = new System.Drawing.Point(14, 215);
            this.ghiChuBox.Name = "ghiChuBox";
            this.ghiChuBox.Size = new System.Drawing.Size(213, 146);
            this.ghiChuBox.TabIndex = 37;
            this.ghiChuBox.TabStop = false;
            this.ghiChuBox.Text = "Ghi Chú";
            // 
            // ghiChuEditBox
            // 
            this.ghiChuEditBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ghiChuEditBox.Location = new System.Drawing.Point(3, 17);
            this.ghiChuEditBox.Multiline = true;
            this.ghiChuEditBox.Name = "ghiChuEditBox";
            this.ghiChuEditBox.Size = new System.Drawing.Size(207, 126);
            this.ghiChuEditBox.TabIndex = 0;
            // 
            // soAoLabel
            // 
            this.soAoLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.soAoLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soAoLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.soAoLabel.Location = new System.Drawing.Point(424, 328);
            this.soAoLabel.Name = "soAoLabel";
            this.soAoLabel.Size = new System.Drawing.Size(198, 18);
            this.soAoLabel.TabIndex = 36;
            this.soAoLabel.Text = "10";
            this.soAoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(250, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 19);
            this.label1.TabIndex = 35;
            this.label1.Text = "Số Áo";
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Location = new System.Drawing.Point(252, 360);
            this.panel7.Margin = new System.Windows.Forms.Padding(2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(370, 1);
            this.panel7.TabIndex = 25;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::QuanLyGiaiVoDich.Properties.Resources.soccer_profile;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(14, 20);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(213, 180);
            this.pictureBox2.TabIndex = 34;
            this.pictureBox2.TabStop = false;
            // 
            // soBanThangLabel
            // 
            this.soBanThangLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.soBanThangLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soBanThangLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.soBanThangLabel.Location = new System.Drawing.Point(424, 278);
            this.soBanThangLabel.Name = "soBanThangLabel";
            this.soBanThangLabel.Size = new System.Drawing.Size(198, 18);
            this.soBanThangLabel.TabIndex = 29;
            this.soBanThangLabel.Text = "10";
            this.soBanThangLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tenCauThuLabel
            // 
            this.tenCauThuLabel.AutoSize = true;
            this.tenCauThuLabel.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenCauThuLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tenCauThuLabel.Location = new System.Drawing.Point(249, 20);
            this.tenCauThuLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tenCauThuLabel.Name = "tenCauThuLabel";
            this.tenCauThuLabel.Size = new System.Drawing.Size(220, 26);
            this.tenCauThuLabel.TabIndex = 1;
            this.tenCauThuLabel.Text = "Nguyễn Thành Long";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.chonSoAo);
            this.groupBox7.Controls.Add(this.chonSoAoLabel);
            this.groupBox7.Controls.Add(this.ngaySinhPicker);
            this.groupBox7.Controls.Add(this.label9);
            this.groupBox7.Controls.Add(this.loaiCauThuComboBox);
            this.groupBox7.Controls.Add(this.hoTenTextBox);
            this.groupBox7.Controls.Add(this.doiBongComboBox);
            this.groupBox7.Controls.Add(this.label21);
            this.groupBox7.Controls.Add(this.tableLayoutPanel2);
            this.groupBox7.Controls.Add(this.label23);
            this.groupBox7.Controls.Add(this.maCauThuTextBox);
            this.groupBox7.Controls.Add(this.label28);
            this.groupBox7.Controls.Add(this.label29);
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox7.Location = new System.Drawing.Point(9, 56);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(340, 441);
            this.groupBox7.TabIndex = 9;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Thông tin cầu thủ";
            // 
            // chonSoAo
            // 
            this.chonSoAo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chonSoAo.Location = new System.Drawing.Point(151, 120);
            this.chonSoAo.Name = "chonSoAo";
            this.chonSoAo.Size = new System.Drawing.Size(183, 26);
            this.chonSoAo.TabIndex = 41;
            // 
            // chonSoAoLabel
            // 
            this.chonSoAoLabel.AutoSize = true;
            this.chonSoAoLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chonSoAoLabel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.chonSoAoLabel.Location = new System.Drawing.Point(6, 128);
            this.chonSoAoLabel.Name = "chonSoAoLabel";
            this.chonSoAoLabel.Size = new System.Drawing.Size(52, 18);
            this.chonSoAoLabel.TabIndex = 40;
            this.chonSoAoLabel.Text = "Số Áo";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackgroundImage = global::QuanLyGiaiVoDich.Properties.Resources.paper_pencil_24pt;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(349, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Location = new System.Drawing.Point(391, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(337, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "CHỈNH SỬA THÔNG TIN CẦU THỦ";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(9, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(991, 41);
            this.panel1.TabIndex = 8;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // doiBongTableAdapter
            // 
            this.doiBongTableAdapter.ClearBeforeFill = true;
            // 
            // loaiCauThuTableAdapter
            // 
            this.loaiCauThuTableAdapter.ClearBeforeFill = true;
            // 
            // ChinhSuaCauThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1012, 508);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1028, 547);
            this.MinimumSize = new System.Drawing.Size(1028, 547);
            this.Name = "ChinhSuaCauThu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm Quản Lý Giải Vô Địch Bóng Đá Quốc Gia - Chỉnh Sửa Thông Tin Cầu Thủ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChinhSuaCauThu_FormClosing);
            this.Load += new System.EventHandler(this.ChinhSuaCauThu_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ChinhSuaCauThu_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.loaiCauThuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyGiaiVoDichDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doiBongBindingSource)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ghiChuBox.ResumeLayout(false);
            this.ghiChuBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chonSoAo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label ngaySinhLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker ngaySinhPicker;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox loaiCauThuComboBox;
        private System.Windows.Forms.TextBox hoTenTextBox;
        private System.Windows.Forms.ComboBox doiBongComboBox;
        private System.Windows.Forms.Label loaiCauThuLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox maCauThuTextBox;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label doiBongLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button capNhatButton;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label maCauThuLabel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label soBanThangLabel;
        private System.Windows.Forms.Label tenCauThuLabel;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button xoaButton;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private QuanLyGiaiVoDichDataSet quanLyGiaiVoDichDataSet;
        private System.Windows.Forms.BindingSource doiBongBindingSource;
        private DAO_QLBongDa.QuanLyGiaiVoDichDataSetTableAdapters.DoiBongTableAdapter doiBongTableAdapter;
        private System.Windows.Forms.BindingSource loaiCauThuBindingSource;
        private DAO_QLBongDa.QuanLyGiaiVoDichDataSetTableAdapters.LoaiCauThuTableAdapter loaiCauThuTableAdapter;
        private System.Windows.Forms.Label soAoLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.NumericUpDown chonSoAo;
        private System.Windows.Forms.Label chonSoAoLabel;
        private System.Windows.Forms.GroupBox ghiChuBox;
        private System.Windows.Forms.TextBox ghiChuEditBox;
    }
}