using DAO_QLBongDa;

namespace QuanLyGiaiVoDich
{
    partial class FirstScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirstScreen));
            this.khoiTaoMuaGiaiLabel = new System.Windows.Forms.Label();
            this.chonMuaGiaiComboBox = new System.Windows.Forms.ComboBox();
            this.muaGiaiAllowNullBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyGiaiVoDichDataSet = new DAO_QLBongDa.QuanLyGiaiVoDichDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.muaGiaiAllowNullTableAdapter = new DAO_QLBongDa.QuanLyGiaiVoDichDataSetTableAdapters.MuaGiaiAllowNullTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.muaGiaiAllowNullBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyGiaiVoDichDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // khoiTaoMuaGiaiLabel
            // 
            this.khoiTaoMuaGiaiLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.khoiTaoMuaGiaiLabel.AutoSize = true;
            this.khoiTaoMuaGiaiLabel.BackColor = System.Drawing.Color.Transparent;
            this.khoiTaoMuaGiaiLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.khoiTaoMuaGiaiLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.khoiTaoMuaGiaiLabel.Location = new System.Drawing.Point(501, 235);
            this.khoiTaoMuaGiaiLabel.Name = "khoiTaoMuaGiaiLabel";
            this.khoiTaoMuaGiaiLabel.Size = new System.Drawing.Size(110, 15);
            this.khoiTaoMuaGiaiLabel.TabIndex = 5;
            this.khoiTaoMuaGiaiLabel.Text = "Khởi tạo mùa giải?";
            this.khoiTaoMuaGiaiLabel.Click += new System.EventHandler(this.Label2_Click);
            // 
            // chonMuaGiaiComboBox
            // 
            this.chonMuaGiaiComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chonMuaGiaiComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.chonMuaGiaiComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.chonMuaGiaiComboBox.DataSource = this.muaGiaiAllowNullBindingSource;
            this.chonMuaGiaiComboBox.DisplayMember = "TenMuaGiai";
            this.chonMuaGiaiComboBox.Font = new System.Drawing.Font("Arial", 12F);
            this.chonMuaGiaiComboBox.FormattingEnabled = true;
            this.chonMuaGiaiComboBox.Location = new System.Drawing.Point(409, 207);
            this.chonMuaGiaiComboBox.Name = "chonMuaGiaiComboBox";
            this.chonMuaGiaiComboBox.Size = new System.Drawing.Size(202, 26);
            this.chonMuaGiaiComboBox.TabIndex = 4;
            this.chonMuaGiaiComboBox.ValueMember = "MaMuaGiai";
            this.chonMuaGiaiComboBox.SelectedIndexChanged += new System.EventHandler(this.ChonMuaGiaiComboBox_SelectedIndexChanged);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(274, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Chọn Mùa Giải";
            // 
            // muaGiaiAllowNullTableAdapter
            // 
            this.muaGiaiAllowNullTableAdapter.ClearBeforeFill = true;
            // 
            // FirstScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyGiaiVoDich.Properties.Resources.BackGround;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.khoiTaoMuaGiaiLabel);
            this.Controls.Add(this.chonMuaGiaiComboBox);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(900, 500);
            this.MinimumSize = new System.Drawing.Size(900, 500);
            this.Name = "FirstScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm Quản Lý Giải Vô Địch Bóng Đá Quốc Gia - Chọn Mùa Giải";
            this.Load += new System.EventHandler(this.FirstScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.muaGiaiAllowNullBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyGiaiVoDichDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label khoiTaoMuaGiaiLabel;
        private System.Windows.Forms.ComboBox chonMuaGiaiComboBox;
        private System.Windows.Forms.Label label1;
        private QuanLyGiaiVoDichDataSet quanLyGiaiVoDichDataSet;
        private System.Windows.Forms.BindingSource muaGiaiAllowNullBindingSource;
        private DAO_QLBongDa.QuanLyGiaiVoDichDataSetTableAdapters.MuaGiaiAllowNullTableAdapter muaGiaiAllowNullTableAdapter;
    }
}