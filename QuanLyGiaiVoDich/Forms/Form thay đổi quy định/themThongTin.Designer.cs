namespace QuanLyGiaiVoDich
{
    partial class themThongTin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(themThongTin));
            this.themDanhSachGroupBox = new System.Windows.Forms.GroupBox();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.themButton = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.themDanhSachGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // themDanhSachGroupBox
            // 
            this.themDanhSachGroupBox.Controls.Add(this.checkBox);
            this.themDanhSachGroupBox.Controls.Add(this.themButton);
            this.themDanhSachGroupBox.Controls.Add(this.textBox);
            this.themDanhSachGroupBox.Location = new System.Drawing.Point(3, 3);
            this.themDanhSachGroupBox.Name = "themDanhSachGroupBox";
            this.themDanhSachGroupBox.Size = new System.Drawing.Size(514, 147);
            this.themDanhSachGroupBox.TabIndex = 0;
            this.themDanhSachGroupBox.TabStop = false;
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox.Location = new System.Drawing.Point(10, 87);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(104, 22);
            this.checkBox.TabIndex = 2;
            this.checkBox.Text = "checkBox1";
            this.checkBox.UseVisualStyleBackColor = true;
            // 
            // themButton
            // 
            this.themButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.themButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.themButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.themButton.Location = new System.Drawing.Point(332, 37);
            this.themButton.Name = "themButton";
            this.themButton.Size = new System.Drawing.Size(176, 29);
            this.themButton.TabIndex = 1;
            this.themButton.Text = "Thêm ";
            this.themButton.UseVisualStyleBackColor = false;
            this.themButton.Click += new System.EventHandler(this.ThemButton_Click);
            // 
            // textBox
            // 
            this.textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(252)))));
            this.textBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.Location = new System.Drawing.Point(9, 39);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(281, 26);
            this.textBox.TabIndex = 0;
            // 
            // themThongTin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(521, 162);
            this.Controls.Add(this.themDanhSachGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(537, 201);
            this.MinimumSize = new System.Drawing.Size(537, 201);
            this.Name = "themThongTin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm Quản Lý Giải Vô Địch Bóng Đá Quốc Gia - Thêm Mới";
            this.Load += new System.EventHandler(this.ThemThongTin_Load);
            this.themDanhSachGroupBox.ResumeLayout(false);
            this.themDanhSachGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox themDanhSachGroupBox;
        private System.Windows.Forms.Button themButton;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.CheckBox checkBox;
    }
}