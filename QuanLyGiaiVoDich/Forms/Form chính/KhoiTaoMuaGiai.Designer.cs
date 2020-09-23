namespace QuanLyGiaiVoDich
{
    partial class KhoiTaoMuaGiai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KhoiTaoMuaGiai));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tenMuaGiaTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.khoiTaoMuaGiaiButton = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::QuanLyGiaiVoDich.Properties.Resources.paper_pencil_24pt;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(94, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Location = new System.Drawing.Point(130, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "KHỞI TẠO MÙA GIẢI";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(388, 40);
            this.panel1.TabIndex = 7;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackgroundImage = global::QuanLyGiaiVoDich.Properties.Resources.arrow;
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox7.Location = new System.Drawing.Point(9, 2);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(34, 33);
            this.pictureBox7.TabIndex = 8;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tenMuaGiaTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox1.Location = new System.Drawing.Point(6, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 107);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin mùa giải";
            // 
            // tenMuaGiaTextBox
            // 
            this.tenMuaGiaTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.tenMuaGiaTextBox.Font = new System.Drawing.Font("Arial", 12F);
            this.tenMuaGiaTextBox.Location = new System.Drawing.Point(130, 20);
            this.tenMuaGiaTextBox.Name = "tenMuaGiaTextBox";
            this.tenMuaGiaTextBox.Size = new System.Drawing.Size(248, 26);
            this.tenMuaGiaTextBox.TabIndex = 1;
            this.tenMuaGiaTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TenMuaGiaTextBox_KeyDown);
            this.tenMuaGiaTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.TenMuaGiaTextBox_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Mùa Giải";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.khoiTaoMuaGiaiButton);
            this.panel2.Location = new System.Drawing.Point(6, 165);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(388, 40);
            this.panel2.TabIndex = 0;
            // 
            // khoiTaoMuaGiaiButton
            // 
            this.khoiTaoMuaGiaiButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.khoiTaoMuaGiaiButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.khoiTaoMuaGiaiButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.khoiTaoMuaGiaiButton.Location = new System.Drawing.Point(130, 5);
            this.khoiTaoMuaGiaiButton.Name = "khoiTaoMuaGiaiButton";
            this.khoiTaoMuaGiaiButton.Size = new System.Drawing.Size(148, 30);
            this.khoiTaoMuaGiaiButton.TabIndex = 9;
            this.khoiTaoMuaGiaiButton.Text = "Khởi tạo";
            this.khoiTaoMuaGiaiButton.UseVisualStyleBackColor = false;
            this.khoiTaoMuaGiaiButton.Click += new System.EventHandler(this.KhoiTaoMuaGiaiButton_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // KhoiTaoMuaGiai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(405, 214);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KhoiTaoMuaGiai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm Quản Lý Giải Vô Địch Bóng Đá Quốc Gia - Khởi Tạo Mùa Giải";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.KhoiTaoMuaGiai_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button khoiTaoMuaGiaiButton;
        private System.Windows.Forms.TextBox tenMuaGiaTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.PictureBox pictureBox7;
    }
}