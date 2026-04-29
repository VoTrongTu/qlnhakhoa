using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai5_71_Tu
{
    public partial class FrmHieuChinh_71_Tu : Form
    {
        //tên file đơn giá
        public string donGia_71_Tu = "dongia_71_Tu.txt";
        public FrmHieuChinh_71_Tu()
        {
            InitializeComponent();
        }

        //Hiệu chỉnh đơn giá
        private void btnHieuChinh_71_Tu_Click(object sender, EventArgs e)
        {
            //Kiểm tra nhập liệu
            if(txtClean_71_Tu.Text==""|| txtFilling_71_Tu.Text==""
                || txtWhiteming_71_Tu.Text == "" || txtXPay_71_Tu.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ đơn giá!", "Thông báo");
                return;
            }
            // kiểm tra file có tồn tại không
            if (!File.Exists(donGia_71_Tu))
            {
                MessageBox.Show("File không tồn tại!", "Thông báo");
                return;
            }

            //khởi tạo các biến lưu thông tin vừa hiệu chỉnh
            string cleanCost_71_Tu = "Cạo voi: "+txtClean_71_Tu.Text;
            string whitening_71_Ti = "Tẩy trắng: "+txtWhiteming_71_Tu.Text;
            string xPayCost_71_Tu = "Chụp XPay: "+txtXPay_71_Tu.Text;
            string fillingCost_71_Tu ="Trám răng: "+ txtFilling_71_Tu.Text;

            //cập nhập giá vào file đơn giá
            try {
                using (StreamWriter sw_71_Tu = new StreamWriter(donGia_71_Tu))
                {
                    sw_71_Tu.WriteLine(cleanCost_71_Tu);
                    sw_71_Tu.WriteLine(whitening_71_Ti);
                    sw_71_Tu.WriteLine(xPayCost_71_Tu);
                    sw_71_Tu.WriteLine(fillingCost_71_Tu);
                }
                MessageBox.Show("Hiệu chỉnh thành công!");

            }
            catch (IOException)
            {
                MessageBox.Show("Không thể mở file!");
            }
        }

        //quay lại form chính
        private void btnThoat_71_Tu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form chinh_71_Tu = new FrmChinh_71_Tu();
            chinh_71_Tu.Show();
        }
    }
}
