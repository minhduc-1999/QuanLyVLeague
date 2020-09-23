using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyGiaiVoDich
{
    public partial class FirstScreen : Form
    {

        public FirstScreen()
        {
            InitializeComponent();

        }

        private void Label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            KhoiTaoMuaGiai form = new KhoiTaoMuaGiai();
            form.ShowDialog();
            this.Close();

        }

        private void ChonMuaGiaiComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Home form = new Home();
            string menu_result = (string)(((ComboBox)sender).SelectedValue);
            if (menu_result == null || menu_result.Equals("0"))
            {
                return;
            }
            this.Hide();
            //Console.WriteLine("change");
            GlobalState.selectedSeasonId = (string)(((ComboBox)sender).SelectedValue);
            Console.WriteLine(GlobalState.selectedSeasonId);
            form.ShowDialog();
            this.Close();
        }

        private void FirstScreen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyGiaiVoDichDataSet.MuaGiaiAllowNull' table. You can move, or remove it, as needed.
            this.muaGiaiAllowNullTableAdapter.Fill(this.quanLyGiaiVoDichDataSet.MuaGiaiAllowNull);
            
        }
    }
}
