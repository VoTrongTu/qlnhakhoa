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
    public partial class datten_b5_224_71_Tu : Form
    {
        string tenFile_71_Tu = "dulieu_71_Tu.txt";
        public datten_b5_224_71_Tu()
        {
            InitializeComponent();
        }

        private void btnCale_71_Tu_Click(object sender, EventArgs e)
        {
            //lấy dl từ label
            int cleanCost_71_Tu = int.Parse(lblCleanCost_71_Tu.Text.
                Replace("$", "").Replace(".", ""));

            int whiteningCost_71_Tu = int.Parse(lblWhiteningCost_71_Tu.Text.
                Replace("$", "").Replace(".", ""));

            int XPayCost_71_Tu = int.Parse(lblXRayCost_71_Tu.Text.
                Replace("$", "").Replace(".", ""));

            int fillingCost_71_Tu = int.Parse(lblFillCost_71_Tu.Text.
                Replace("$", "").Replace(".", "").Replace("/cái", ""));

            // thông báo nếu chx có tên khách hàng
            if (this.txtName_71_Tu.Text == "")
            {
                MessageBox.Show("CHưa nhập tên khách hàng!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int tongTien_71_Tu = 0;
                // Cạo voi
                if (chkClean_71_Tu.Checked)
                    tongTien_71_Tu += cleanCost_71_Tu;
                // Tẩy trắng
                if (chkWhitening_71_Tu.Checked)
                    tongTien_71_Tu += whiteningCost_71_Tu;
                // chụp hình
                if (chkXRay_71_Tu.Checked)
                    tongTien_71_Tu += XPayCost_71_Tu;
                // trám
                tongTien_71_Tu += fillingCost_71_Tu * (int)numFilling_71_Tu.Value;
                //hiển thị tổng tiền
                this.txtTotal_71_Tu.Text = string.Format("${0:N0}", tongTien_71_Tu);


                
            }
        }

        private void btnThoat_71_Tu_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSaveFile_71_Tu_Click(object sender, EventArgs e)
        {
            // chưa nhaaoj tên không cho lưu file
            if(txtName_71_Tu.Text == "")
            {
                MessageBox.Show("Chưa chọn dữ liệu!", "Thông báo!");
                return;
            }

            //Hiển thị thông tin trên listBox

            string ngayKham_71_TU = string.Format("{0}/{1}/{2}",
                         dtpNgayKham_71_Tu.Value.Day, dtpNgayKham_71_Tu.Value.Month
                        , dtpNgayKham_71_Tu.Value.Year);

            lstSaveInfor_71_Tu.Items.Add(string.Format("Tên khách hàng: {0}",txtName_71_Tu.Text));
            lstSaveInfor_71_Tu.Items.Add(string.Format("Ca khám: {0}", cboCaKham_71_Tu.Text));
            lstSaveInfor_71_Tu.Items.Add(string.Format("Ngày khám: {0}", ngayKham_71_TU));
            if (txtTotal_71_Tu.Text == "")
            {
                MessageBox.Show("Bạn chưa tính tiền!", "Thông báo");
                return;
            }
            else lstSaveInfor_71_Tu.Items.Add(string.Format("Thành tiền: {0}", txtTotal_71_Tu.Text));

            string dichVu_71_Tu="";
            if (chkClean_71_Tu.Checked) dichVu_71_Tu += " 'Cạo voi'";
            if (chkWhitening_71_Tu.Checked) dichVu_71_Tu += " 'tẩy trắng'";
            if (chkXRay_71_Tu.Checked) dichVu_71_Tu += " 'Chụp hình răng'";
            if ((int)numFilling_71_Tu.Value > 0) dichVu_71_Tu += " 'trám răng'";

            lstSaveInfor_71_Tu.Items.Add(string.Format("Dịch vụ: {0}", dichVu_71_Tu));
            lstSaveInfor_71_Tu.Items.Add("-");

            
            //khai báo ds kiur string
            List<string> lines = new List<string>();

            foreach (var item in lstSaveInfor_71_Tu.Items)
            {
                lines.Add(item.ToString());
            }

            // ghi toàn bộ vào file
            File.WriteAllLines(tenFile_71_Tu, lines, Encoding.UTF8);
            
        }

        private void dtpNgayKham_71_Tu_ValueChanged(object sender, EventArgs e)
        {
            // chuyển đổi ngày về dạng số thập phân
            int ngayHienTai_71_Tu = int.Parse(DateTime.Now.ToString("yyyyMMdd"));
            int ngayDatLich_71_Tu = int.Parse(dtpNgayKham_71_Tu.Value.ToString("yyyyMMdd"));

            //kiểm tra ngày đặt lịch nếu sau hiển thị thông báo chọn sai
            if (ngayDatLich_71_Tu - ngayHienTai_71_Tu < 0)
            {
                MessageBox.Show("Chọn ngày không đúng!", "Thông báo");
                dtpNgayKham_71_Tu.ResetText();
                return;
            }
        }

        private void btnTongDoangThu_71_Tu_Click(object sender, EventArgs e)
        {
            
            int tong_71_Tu = 0;
            // nêu mở đc file
            if (File.Exists(tenFile_71_Tu))
            {
                // đọc file vào mảng
                string[] lines_71_Tu = File.ReadAllLines(tenFile_71_Tu, Encoding.UTF8);

                foreach (string line_71_Tu in lines_71_Tu)
                {
                    if (line_71_Tu.Contains("Thành tiền"))
                    {
                        // lấy phần sau dấu :
                        string tien_71_Tu = line_71_Tu.Split(':')[1].Trim();

                        // bỏ ký tự $, dấu phẩy
                        tien_71_Tu = tien_71_Tu.Replace("$", "").Replace(",", "");

                        int soTien_71_Tu = int.Parse(tien_71_Tu);

                        tong_71_Tu += soTien_71_Tu;
                    }
                }
            }
            // hiển thị thông báo tổng doanh thu
            MessageBox.Show("Tổng tiền: " + string.Format("${0:N0}", tong_71_Tu));
        }
    }
}
