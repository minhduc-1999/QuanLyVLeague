using QuanLyGiaiVoDich.DTO_Class.Class;
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
    public partial class themThongTin : Form
    {
        public themThongTin()
        {
            InitializeComponent();
        }

        public string message;
        public string Message
        {
            get { return message; }
            set { message = value; }
        }

        private string cacLoaiCheckBox;
        public string CacLoaiCheckBox
        {
            get { return cacLoaiCheckBox; }
            set { cacLoaiCheckBox = value; }
        }

        // Tạo biến delegate để lưu giá trị sau khi nhập, rồi truyền vào form ThayDoiQuyDinh.cs
        public delegate void getData(string value); 
        public getData myData;

        private void ThemButton_Click(object sender, EventArgs e)
        {
            //myData(textBox.Text);
            //textBox.Text = "";

            //check for label text to determine where should the form submit its data
            if (themDanhSachGroupBox.Text.Equals("Thêm Loại Bàn Thắng"))
            {
                try
                {
                    LOAIBANTHANG loaibt = new LOAIBANTHANG()
                    {
                        MaMuaGiai = GlobalState.selectedSeasonId,
                        TenLoaiBanThang = textBox.Text,
                        TinhBanChoCauThu = checkBox.Checked
                    };
                    Database.LoaiBanThang_DAO.createLoaiBanThang(loaibt);
                    MessageBox.Show("Thêm thành công", "Thông báo");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi xảy ra");
                }
            }
            else if (themDanhSachGroupBox.Text.Equals("Thêm Loại Cầu Thủ"))
            {
                try
                {
                    LOAICAUTHU loaict = new LOAICAUTHU()
                    {
                        MaMuaGiai = GlobalState.selectedSeasonId,
                        TenLoaiCauThu = textBox.Text,
                        CauThuNuocNgoai = checkBox.Checked
                    };
                    Database.LoaiCauThu_DAO.createLoaiCauThu(loaict);
                    MessageBox.Show("Thêm thành công", "Thông báo");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi xảy ra");
                }
            }
        }

        private void ThemThongTin_Load(object sender, EventArgs e)
        {
            themDanhSachGroupBox.Text = Message;
            checkBox.Text = CacLoaiCheckBox;
        }
    }
}
