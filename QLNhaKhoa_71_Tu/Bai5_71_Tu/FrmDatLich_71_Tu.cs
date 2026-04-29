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
using System.Xml.Linq;

namespace Bai5_71_Tu
{
    public partial class FrmDatLich_71_Tu : Form
    {
        // tên file đặt lịch
        public string fileDatLich_71_Tu = "datlich_71_Tu.txt";
        
        public FrmDatLich_71_Tu()
        {
            InitializeComponent();
        }

        //gọi form chính
        private void btnThoat_71_Tu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form chinh_71_Tu = new FrmChinh_71_Tu();
            chinh_71_Tu.Show();
        }

    // đặt lịch và lưu vào file
    private void btnDatLich_71_Tu_Click(object sender, EventArgs e)
        {
            // kiểm tra nhập liệu
            if (txtName_71_Tu.Text == "" || cboCaKham_71_Tu.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin!", "Thông báo");
                return;
            }

            //Lưu vào danh sách
            try {
                using (StreamWriter sw_71_Tu = new StreamWriter(fileDatLich_71_Tu, true))
                {
                    sw_71_Tu.WriteLine(string.Format("{0} - {1}/{2}/{3} - {4}",
                        txtName_71_Tu.Text, dtpNgayKham_71_Tu.Value.Day,dtpNgayKham_71_Tu.Value.Month
                        ,dtpNgayKham_71_Tu.Value.Year, cboCaKham_71_Tu.Text));
                }

                // hiện thị thông báo dặt lịch thành công và hiển thị lại thông tin
                MessageBox.Show("Đặt lịch thành công!\n"
                    + string.Format(string.Format("Tên khách hàng: {0}\nNgày khám: {1} - {2} - {3}\nCa khám: {4}",
                        txtName_71_Tu.Text, dtpNgayKham_71_Tu.Value.Day, dtpNgayKham_71_Tu.Value.Month
                        , dtpNgayKham_71_Tu.Value.Year, cboCaKham_71_Tu.Text)));

                //xóa thông tin sau khi lưu
                txtName_71_Tu.Text = "";
                cboCaKham_71_Tu.Text = "";
                dtpNgayKham_71_Tu.ResetText();
            }
            catch(IOException)
            {
                MessageBox.Show("Không thể mở file!", "Thông báo");
            }
            
        }

        //Quản lý lựa chọn ngày
        private void dtpNgayKham_71_Tu_ValueChanged(object sender, EventArgs e)
        {
            // chuyển đổi ngày về dạng số thập phân
            int ngayHienTai_71_Tu = int.Parse(DateTime.Now.ToString("yyyyMMdd"));
            int ngayDatLich_71_Tu = int.Parse(dtpNgayKham_71_Tu.Value.ToString("yyyyMMdd"));

            //kiểm tra ngày đặt lịch nếu sau hiển thị thông báo chọn sai
            if (ngayDatLich_71_Tu - ngayHienTai_71_Tu   < 0)
            {
                MessageBox.Show("Chọn ngày không đúng!", "Thông báo");
                dtpNgayKham_71_Tu.ResetText();
                return;
            }
        }
    }
}
