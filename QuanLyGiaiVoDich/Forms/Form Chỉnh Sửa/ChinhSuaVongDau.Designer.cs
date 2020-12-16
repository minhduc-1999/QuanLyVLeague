using DAO_QLBongDa;

namespace QuanLyGiaiVoDich
{
    partial class ChinhSuaVongDau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChinhSuaVongDau));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.xoaButton = new System.Windows.Forms.Button();
            this.capNhatButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.muaGiaiComboBox = new System.Windows.Forms.ComboBox();
            this.muaGiaiAllowNullBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyGiaiVoDichDataSet = new DAO_QLBongDa.QuanLyGiaiVoDichDataSet();
            this.tenVongTextBox = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.muaGiaiAllowNullTableAdapter = new DAO_QLBongDa.QuanLyGiaiVoDichDataSetTableAdapters.MuaGiaiAllowNullTableAdapter();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.muaGiaiAllowNullBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyGiaiVoDichDataSet)).BeginInit();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 41);
            this.panel1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackgroundImage = global::QuanLyGiaiVoDich.Properties.Resources.paper_pencil_24pt;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(96, 5);
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
            this.label5.Location = new System.Drawing.Point(138, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(238, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "CHỈNH SỬA VÒNG ĐẤU";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.xoaButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.capNhatButton, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 145);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(466, 41);
            this.tableLayoutPanel2.TabIndex = 21;
            // 
            // xoaButton
            // 
            this.xoaButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.xoaButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xoaButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xoaButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.xoaButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.xoaButton.Location = new System.Drawing.Point(236, 3);
            this.xoaButton.Name = "xoaButton";
            this.xoaButton.Size = new System.Drawing.Size(227, 35);
            this.xoaButton.TabIndex = 8;
            this.xoaButton.Text = "Xóa";
            this.xoaButton.UseVisualStyleBackColor = false;
            this.xoaButton.Click += new System.EventHandler(this.xoaButton_Click);
            // 
            // capNhatButton
            // 
            this.capNhatButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.capNhatButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.capNhatButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.capNhatButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.capNhatButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.capNhatButton.Location = new System.Drawing.Point(3, 3);
            this.capNhatButton.Name = "capNhatButton";
            this.capNhatButton.Size = new System.Drawing.Size(227, 35);
            this.capNhatButton.TabIndex = 7;
            this.capNhatButton.Text = "Cập Nhật";
            this.capNhatButton.UseVisualStyleBackColor = false;
            this.capNhatButton.Click += new System.EventHandler(this.capNhatButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 18);
            this.label1.TabIndex = 22;
            this.label1.Text = "Tên Vòng Đấu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(6, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 18);
            this.label2.TabIndex = 23;
            this.label2.Text = "Mùa Giải";
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
            this.muaGiaiComboBox.Size = new System.Drawing.Size(321, 27);
            this.muaGiaiComboBox.TabIndex = 24;
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
            // tenVongTextBox
            // 
            this.tenVongTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.tenVongTextBox.Font = new System.Drawing.Font("Arial", 12F);
            this.tenVongTextBox.Location = new System.Drawing.Point(151, 20);
            this.tenVongTextBox.Name = "tenVongTextBox";
            this.tenVongTextBox.Size = new System.Drawing.Size(321, 26);
            this.tenVongTextBox.TabIndex = 25;
            this.tenVongTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TenVongTextBox_KeyDown);
            this.tenVongTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.TenVongTextBox_Validating);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.tenVongTextBox);
            this.groupBox7.Controls.Add(this.muaGiaiComboBox);
            this.groupBox7.Controls.Add(this.label2);
            this.groupBox7.Controls.Add(this.label1);
            this.groupBox7.Controls.Add(this.tableLayoutPanel2);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox7.Location = new System.Drawing.Point(0, 41);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(484, 190);
            this.groupBox7.TabIndex = 10;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Thông tin chỉnh sửa";
            // 
            // muaGiaiAllowNullTableAdapter
            // 
            this.muaGiaiAllowNullTableAdapter.ClearBeforeFill = true;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // ChinhSuaVongDau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(484, 231);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 270);
            this.MinimumSize = new System.Drawing.Size(500, 270);
            this.Name = "ChinhSuaVongDau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm Quản Lý Giải Vô Địch Bóng Đá Quốc Gia - Chỉnh Sửa Vòng Đấu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChinhSuaVongDau_FormClosing);
            this.Load += new System.EventHandler(this.ChinhSuaVongDau_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.muaGiaiAllowNullBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyGiaiVoDichDataSet)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button capNhatButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tenVongTextBox;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button xoaButton;
        private System.Windows.Forms.ComboBox muaGiaiComboBox;
        private QuanLyGiaiVoDichDataSet quanLyGiaiVoDichDataSet;
        private System.Windows.Forms.BindingSource muaGiaiAllowNullBindingSource;
        private DAO_QLBongDa.QuanLyGiaiVoDichDataSetTableAdapters.MuaGiaiAllowNullTableAdapter muaGiaiAllowNullTableAdapter;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}