using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai5_71_Tu
{
    public partial class FrmTinhTien_71_Tu : Form
    {
        //tên file luu thông tin
        public string fileName_71_Tu = "thanhtoan_71_Tu.txt";
        public FrmTinhTien_71_Tu()
        {
            InitializeComponent();

            //cập nhật đơn giá từ file donGia_71_Tu
            FrmHieuChinh_71_Tu f_71_Tu = new FrmHieuChinh_71_Tu();
            using (StreamReader  sr_71_Tu = new StreamReader(f_71_Tu.donGia_71_Tu))
            {
                string line_71_Tu;
                while ((line_71_Tu = sr_71_Tu.ReadLine()) != null)
                {
                    //xử lý dl lấy từ file
                    string[] item_71_Tu = line_71_Tu.Split(':');
                    int gia_71_Tu = int.Parse(item_71_Tu[1].Trim());
                    string t_71_Tu = item_71_Tu[0].Trim();
                    //gán giá vừa lấy
                    if (t_71_Tu == "Cạo voi")
                        lblCleanCost_71_Tu.Text = string.Format("${0:N0}", gia_71_Tu);
                    else if(t_71_Tu == "Tẩy trắng")
                        lblWhiteningCost_71_Tu.Text = string.Format("${0:N0}", gia_71_Tu);
                    else if (t_71_Tu == "Chụp XPay")
                        lblXRayCost_71_Tu.Text = string.Format("${0:N0}", gia_71_Tu);
                    else lblFillCost_71_Tu.Text = string.Format("${0:N0}/cái", gia_71_Tu);
                }
            }
        }

        //Quay lại trang chủ
        private void btnExit_71_Tu_Click(object sender, EventArgs e)
        {
                this.Hide();
                Form chinh_71_Tu = new FrmChinh_71_Tu();
                chinh_71_Tu.Show();
        }

        //tính tiền
        private void btnCale_71_Tu_Click(object sender, EventArgs e)
        {
            //lấy dl từ label
            int cleanCost_71_Tu = int.Parse(lblCleanCost_71_Tu.Text.
                Replace("$", "").Replace(",", ""));

            int whiteningCost_71_Tu = int.Parse(lblWhiteningCost_71_Tu.Text.
                Replace("$", "").Replace(",", ""));

            int XPayCost_71_Tu = int.Parse(lblXRayCost_71_Tu.Text.
                Replace("$", "").Replace(",", ""));

            int fillingCost_71_Tu = int.Parse(lblFillCost_71_Tu.Text.
                Replace("$", "").Replace(",", "").Replace("/cái",""));
            
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
                this.txtTotal_71_Tu.Text = string.Format("${0:N0}",tongTien_71_Tu);
            

                // Lọc danh sách trùng
                //đặt biến cờ giá trị mặc định là false
                bool found_71_Tu = false;

                for(int i = 0; i < lstSaveInfor_71_Tu.Items.Count; i++)
                {
                    string item_71_Tu = lstSaveInfor_71_Tu.Items[i].ToString();
                    // danh sánh đã tách tên-giá tiền
                    string[] parts_71_Tu = item_71_Tu.Split('-');
                    // bỏ qua dòng lỗi
                    if (parts_71_Tu.Length < 2)
                        continue; 
                    // cắt dấu space thừa
                    string oldName_71_Tu = parts_71_Tu[0].Trim();
                    int oldTotal_71_Tu = int.Parse(parts_71_Tu[1].Replace("$","").Replace(",", "").Trim());
                 
                    //nếu tên trùng
                    if(oldName_71_Tu == txtName_71_Tu.Text.Trim())
                    {
                        //cộng dồn đơn giá
                        int newTotal_71_Tu = oldTotal_71_Tu + 
                            int.Parse(txtTotal_71_Tu.Text.Replace("$","").Replace(",","").Trim());
                        //hiển thị ra listBox
                        lstSaveInfor_71_Tu.Items[i] = oldName_71_Tu + " - " +string.Format("${0:N0}",newTotal_71_Tu);
                        found_71_Tu = true;
                        break;
                    }
                }
                //nếu không tìm thấy hiển thị bình thường
                if (!found_71_Tu)
                {
                    lstSaveInfor_71_Tu.Items.Add(txtName_71_Tu.Text+" - "+ txtTotal_71_Tu.Text);
                }
            }
        }

        //Lưu danh sách vào file
        private void btnSaveFile_71_Tu_Click(object sender, EventArgs e)
        {
            // kiểm tra ds rỗng
            if (lstSaveInfor_71_Tu.Items.Count == 0)
            {
                MessageBox.Show("Danh sách rỗng!");
                return;
            }
            //lưu danh sách vào file
            try
            {
                //Mở file để ghi, ghi vào cuối file
                using (StreamWriter sw_71_Tu = new StreamWriter(fileName_71_Tu,true))
                {
                    DialogResult traLoi_71_Tu;
                    traLoi_71_Tu = MessageBox.Show("Dữ liệu trên ListBox sẽ bị xóa", "Thông báo",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    if (traLoi_71_Tu == DialogResult.OK)
                    {
                        foreach (var item_71_Tu in lstSaveInfor_71_Tu.Items)
                        {
                            sw_71_Tu.WriteLine(item_71_Tu);
                        }
                        MessageBox.Show("Lưu thông tin thành công!", "Thông báo");
                        lstSaveInfor_71_Tu.Items.Clear();
                    }
                }
            }
            catch (IOException)
            {
                MessageBox.Show("Mở file thất bại!", "Thông báo");
            }
        }
        
        //Tính tổng doanh thu
        private void btnTongDoanhThu_71_Tu_Click(object sender, EventArgs e)
        {
            lstSaveInfor_71_Tu.Items.Clear();
            int tongDoanhThu_71_Tu = 0;
            // kiểm tra file có tồn tại không
            if (!File.Exists(fileName_71_Tu))
            {
                MessageBox.Show("File không tồn tại!", "Thông báo");
                return;
            }
            //đọc file
            try
            {
                using (StreamReader sr_71_Tu = new StreamReader(fileName_71_Tu))
                {
                    string line_71_Tu;
                    //lstHienThiDS_71_Tu.Items.Add("LỊCH SỬ THANH TOÁN\n\r");
                    while ((line_71_Tu = sr_71_Tu.ReadLine()) != null)
                    {
                        string[] parts_71_Tu = line_71_Tu.Trim().Split('-');
                        int tienThanhToan_71_Tu = int.Parse(parts_71_Tu[1].Replace("$", "").Replace(",", "").Trim());
                        tongDoanhThu_71_Tu += tienThanhToan_71_Tu;
                    }
                }

                // hiển thị tổng doanh thu
                int d_71_Tu = DateTime.Now.Day;
                int m_71_Tu = DateTime.Now.Month;
                int y_71_Tu = DateTime.Now.Year;
                lstSaveInfor_71_Tu.Items.Add(string.Format(
                    "Tính đến ngày {0}/{1}/{2}", d_71_Tu, m_71_Tu, y_71_Tu));
                lstSaveInfor_71_Tu.Items.Add(string.Format("Tổng = ${0:N0}", tongDoanhThu_71_Tu));
            }
            catch (IOException)
            {
                MessageBox.Show("Không đọc được file!");
            }
        }
    }
}
