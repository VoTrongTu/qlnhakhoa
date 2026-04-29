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
    public partial class FrmDanhSach_71_Tu : Form
    {
        //khai báo biến toàn cục tenFile
        string tenFile_71_Tu;
        public FrmDanhSach_71_Tu()
        {
            InitializeComponent();
        }

        private void btnDSThanhToan_71_Tu_Click(object sender, EventArgs e)
        {
            FrmTinhTien_71_Tu f_71_Tu = new FrmTinhTien_71_Tu();
            tenFile_71_Tu = f_71_Tu.fileName_71_Tu;
            LoadFile_71_Tu();
            lstHienThiDS_71_Tu.Items.Clear();
            

            // kiểm tra file có tồn tại không
            if (!File.Exists(tenFile_71_Tu))
            {
                MessageBox.Show("File không tồn tại!", "Thông báo");
                return;
            }

            //đọc file ra listBox
            try
            {
                using (StreamReader sr_71_Tu  = new StreamReader(f_71_Tu.fileName_71_Tu))
                {
                    string line_71_Tu  ;
                    //lstHienThiDS_71_Tu.Items.Add("LỊCH SỬ THANH TOÁN\n\r");
                    while ((line_71_Tu = sr_71_Tu.ReadLine ())!= null)
                    {
                        lstHienThiDS_71_Tu.Items.Add(line_71_Tu);
                    }
                }
            }
            catch(IOException)
            {
                MessageBox.Show("Không đọc được file!");
            }
        }

        private void btnExit_71_Tu_Click(object sender, EventArgs e)
        {
                this.Hide();
                Form chinh_71_Tu = new FrmChinh_71_Tu();
                chinh_71_Tu.Show();
        }

        //Hiển thị danh sánh khách hàng đã đặt lịch khám
        private void btnDSDatTRuoc_71_Tu_Click(object sender, EventArgs e)
        {
            //lấy tên file đặt lịch
            FrmDatLich_71_Tu f_71_Tu = new FrmDatLich_71_Tu();
            tenFile_71_Tu = f_71_Tu.fileDatLich_71_Tu;
            LoadFile_71_Tu();

            // kiểm tra file có tồn tại không
            if (!File.Exists(tenFile_71_Tu))
            {
                MessageBox.Show("File không tồn tại!", "Thông báo");
                return;
            }
            //đọc file
            try
            {
                lstHienThiDS_71_Tu.Items.Clear();
                using (StreamReader sr_71_Tu = new StreamReader(tenFile_71_Tu))
                {
                    string line_71_Tu;
                    while ( (line_71_Tu = sr_71_Tu.ReadLine())!= null)
                    {
                        lstHienThiDS_71_Tu.Items.Add(line_71_Tu);
                    }
                }
            }
            catch (IOException)
            {
                MessageBox.Show("Không đọc được file!");
            }
        }

        //cập nhập lại khi xóa
        void LoadFile_71_Tu()
        {
            lstHienThiDS_71_Tu.Items.Clear();

            if (File.Exists(tenFile_71_Tu))
            {
                using (StreamReader sr = new StreamReader(tenFile_71_Tu))
                {
                    string line_71_Tu;
                    while ((line_71_Tu = sr.ReadLine()) != null)
                    {
                        lstHienThiDS_71_Tu.Items.Add(line_71_Tu);
                    }
                }
            }
        }
        
        //Xóa ptu cần xóa
        private void btnXoa_71_Tu_Click(object sender, EventArgs e)
        {
            //nếu chưa chọn hiện thông báo
            if (lstHienThiDS_71_Tu.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn!", "Thông báo");
                return;
            }
            int n_71_Tu = lstHienThiDS_71_Tu.SelectedItems.Count;
            DialogResult traLoi_71_Tu;
            // xóa phần tử đã chọn
            for (int i = n_71_Tu - 1; i >= 0; i--) { 
                traLoi_71_Tu = MessageBox.Show("Bạn chác chứ!", "Tra lời",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (traLoi_71_Tu == DialogResult.OK)
                    lstHienThiDS_71_Tu.Items.Remove(lstHienThiDS_71_Tu.SelectedItems[i].ToString());
            }

            try { 
            //cập nhật dl trong file
            using (StreamWriter sw = new StreamWriter(tenFile_71_Tu))
            {
                foreach (var item in lstHienThiDS_71_Tu.Items)
                {
                    sw.WriteLine(item.ToString());
                }
            }
            }
            catch (IOException)
            {
                MessageBox.Show("Không thể mởi file!", "Thông báo");
            }
        }
    }
    }

