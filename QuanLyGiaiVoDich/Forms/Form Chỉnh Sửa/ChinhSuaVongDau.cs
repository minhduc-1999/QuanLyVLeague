﻿using QuanLyGiaiVoDich.DTO_Class.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyGiaiVoDich
{
    public partial class ChinhSuaVongDau : Form
    {
        private string selectedRoundId;
        private bool surpressDiscardPrompt = false;

        public ChinhSuaVongDau(string v)
        {
            InitializeComponent();
            selectedRoundId = v;
        }

        private void capNhatButton_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                try
                {
                    VONGDAU vongdau = new VONGDAU()
                    {
                        MaVongDau= selectedRoundId,
                        TenVongDau= tenVongTextBox.Text,
                        MaMuaGiai= muaGiaiComboBox.SelectedValue.ToString(),
                    };
                    Database.VongDau_DAO.updateVongDau(vongdau);
                    MessageBox.Show("Cập nhật thông tin thành công", "Thông báo");
                    surpressDiscardPrompt = true;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi xảy ra");
                }
            }
        }

        private void xoaButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn sẽ xóa dữ liệu vòng đấu này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    Database.VongDau_DAO.removeVongDau(selectedRoundId);
                    MessageBox.Show("Xóa thành công", "Thông báo");
                    surpressDiscardPrompt = true;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi xảy ra");
                }
            }
        }

        private void ChinhSuaVongDau_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyGiaiVoDichDataSet.MuaGiaiAllowNull' table. You can move, or remove it, as needed.
            this.muaGiaiAllowNullTableAdapter.Fill(this.quanLyGiaiVoDichDataSet.MuaGiaiAllowNull);
            VONGDAU vongdau;
            Database.VongDau_DAO.selectVongDau(selectedRoundId, out vongdau);
            tenVongTextBox.Text = vongdau.TenVongDau;
            muaGiaiComboBox.SelectedValue = vongdau.MaMuaGiai;
        }

        private void ChinhSuaVongDau_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (surpressDiscardPrompt) return;
            var result = MessageBox.Show("Thay đổi này sẽ không được lưu nếu bạn thoát?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        // Validate textBox
        private void TenVongTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tenVongTextBox.Text))
            {
                e.Cancel = true;
                errorProvider.SetIconAlignment(tenVongTextBox, ErrorIconAlignment.MiddleLeft);
                errorProvider.SetError(tenVongTextBox, "Hãy nhập đầy đủ thông tin");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(tenVongTextBox, null);
            }

        }

        private void TenVongTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Enter == e.KeyCode)
            {
                capNhatButton_Click(this, new EventArgs());
            }
        }
    }
}
