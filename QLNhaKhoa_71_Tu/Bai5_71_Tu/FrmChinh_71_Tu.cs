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
 
    public partial class FrmChinh_71_Tu : Form
    {
        public FrmChinh_71_Tu()
        {
            InitializeComponent();
        }

        // gọi form tính tiền
        private void btnTinhTien_71_Tu_Click(object sender, EventArgs e)
        {
            // đổi màu khi nhay chuột
            btnTinhTien_71_Tu.BackColor = Color.Blue; 
            // chuyển qua form tính tiền
            this.Hide();
            Form tinhTien_71_Tu = new FrmTinhTien_71_Tu();
            tinhTien_71_Tu.ShowDialog();
        }

        //gọi form danh sách
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f_71_Tu = new FrmDanhSach_71_Tu();
            f_71_Tu.Show();
        }


        // gọi form đặt lịch khám
        private void btnDatLich_71_Tu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f_71_Tu = new FrmDatLich_71_Tu();
            f_71_Tu.Show();
        }

        private void btnHieuChinhGia_71_Tu_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmHieuChinh_71_Tu f_71_Tu = new FrmHieuChinh_71_Tu();
            f_71_Tu.Show();
        }

        // thoát chương trình
        private void btnThoat_71_Tu_Click(object sender, EventArgs e)
        {
            DialogResult traLoi_71_Tu;
            traLoi_71_Tu = MessageBox.Show("Chắc không!", "Trả Lời",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traLoi_71_Tu == DialogResult.OK) Application.Exit();
        }
    }
}
