namespace Bai5_71_Tu
{
    partial class FrmChinh_71_Tu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChinh_71_Tu));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grbDanhDichVu_71_Tu = new System.Windows.Forms.GroupBox();
            this.btnHieuChinhGia_71_Tu = new System.Windows.Forms.Button();
            this.btnDatLich_71_Tu = new System.Windows.Forms.Button();
            this.btnThoat_71_Tu = new System.Windows.Forms.Button();
            this.btnShow_71_Tu = new System.Windows.Forms.Button();
            this.btnTinhTien_71_Tu = new System.Windows.Forms.Button();
            this.lblTittle_71_Tu = new System.Windows.Forms.Label();
            this.grbDanhDichVu_71_Tu.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbDanhDichVu_71_Tu
            // 
            this.grbDanhDichVu_71_Tu.BackgroundImage = global::Bai5_71_Tu.Properties.Resources.NhaKhoa;
            this.grbDanhDichVu_71_Tu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grbDanhDichVu_71_Tu.Controls.Add(this.btnHieuChinhGia_71_Tu);
            this.grbDanhDichVu_71_Tu.Controls.Add(this.btnDatLich_71_Tu);
            this.grbDanhDichVu_71_Tu.Controls.Add(this.btnThoat_71_Tu);
            this.grbDanhDichVu_71_Tu.Controls.Add(this.btnShow_71_Tu);
            this.grbDanhDichVu_71_Tu.Controls.Add(this.btnTinhTien_71_Tu);
            this.grbDanhDichVu_71_Tu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grbDanhDichVu_71_Tu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDanhDichVu_71_Tu.ForeColor = System.Drawing.Color.Blue;
            this.grbDanhDichVu_71_Tu.Location = new System.Drawing.Point(0, 166);
            this.grbDanhDichVu_71_Tu.Name = "grbDanhDichVu_71_Tu";
            this.grbDanhDichVu_71_Tu.Size = new System.Drawing.Size(959, 485);
            this.grbDanhDichVu_71_Tu.TabIndex = 4;
            this.grbDanhDichVu_71_Tu.TabStop = false;
            this.grbDanhDichVu_71_Tu.Text = "Danh sách dịch vụ";
            // 
            // btnHieuChinhGia_71_Tu
            // 
            this.btnHieuChinhGia_71_Tu.AutoSize = true;
            this.btnHieuChinhGia_71_Tu.BackColor = System.Drawing.Color.Silver;
            this.btnHieuChinhGia_71_Tu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHieuChinhGia_71_Tu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHieuChinhGia_71_Tu.ForeColor = System.Drawing.Color.Black;
            this.btnHieuChinhGia_71_Tu.Location = new System.Drawing.Point(157, 230);
            this.btnHieuChinhGia_71_Tu.Name = "btnHieuChinhGia_71_Tu";
            this.btnHieuChinhGia_71_Tu.Size = new System.Drawing.Size(312, 51);
            this.btnHieuChinhGia_71_Tu.TabIndex = 7;
            this.btnHieuChinhGia_71_Tu.Text = "Hiệu chỉnh đơn giá";
            this.btnHieuChinhGia_71_Tu.UseVisualStyleBackColor = false;
            this.btnHieuChinhGia_71_Tu.Click += new System.EventHandler(this.btnHieuChinhGia_71_Tu_Click);
            // 
            // btnDatLich_71_Tu
            // 
            this.btnDatLich_71_Tu.AutoSize = true;
            this.btnDatLich_71_Tu.BackColor = System.Drawing.Color.Silver;
            this.btnDatLich_71_Tu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatLich_71_Tu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatLich_71_Tu.ForeColor = System.Drawing.Color.Black;
            this.btnDatLich_71_Tu.Location = new System.Drawing.Point(661, 80);
            this.btnDatLich_71_Tu.Name = "btnDatLich_71_Tu";
            this.btnDatLich_71_Tu.Size = new System.Drawing.Size(240, 51);
            this.btnDatLich_71_Tu.TabIndex = 6;
            this.btnDatLich_71_Tu.Text = "Đặt lịch";
            this.btnDatLich_71_Tu.UseVisualStyleBackColor = false;
            this.btnDatLich_71_Tu.Click += new System.EventHandler(this.btnDatLich_71_Tu_Click);
            // 
            // btnThoat_71_Tu
            // 
            this.btnThoat_71_Tu.AutoSize = true;
            this.btnThoat_71_Tu.BackColor = System.Drawing.Color.Silver;
            this.btnThoat_71_Tu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat_71_Tu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat_71_Tu.ForeColor = System.Drawing.Color.Black;
            this.btnThoat_71_Tu.Location = new System.Drawing.Point(562, 230);
            this.btnThoat_71_Tu.Name = "btnThoat_71_Tu";
            this.btnThoat_71_Tu.Size = new System.Drawing.Size(158, 51);
            this.btnThoat_71_Tu.TabIndex = 5;
            this.btnThoat_71_Tu.Text = "Thoát";
            this.btnThoat_71_Tu.UseVisualStyleBackColor = false;
            this.btnThoat_71_Tu.Click += new System.EventHandler(this.btnThoat_71_Tu_Click);
            // 
            // btnShow_71_Tu
            // 
            this.btnShow_71_Tu.AutoSize = true;
            this.btnShow_71_Tu.BackColor = System.Drawing.Color.Silver;
            this.btnShow_71_Tu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow_71_Tu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow_71_Tu.ForeColor = System.Drawing.Color.Black;
            this.btnShow_71_Tu.Location = new System.Drawing.Point(344, 80);
            this.btnShow_71_Tu.Name = "btnShow_71_Tu";
            this.btnShow_71_Tu.Size = new System.Drawing.Size(240, 51);
            this.btnShow_71_Tu.TabIndex = 4;
            this.btnShow_71_Tu.Text = "Xem thông tin";
            this.btnShow_71_Tu.UseVisualStyleBackColor = false;
            this.btnShow_71_Tu.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTinhTien_71_Tu
            // 
            this.btnTinhTien_71_Tu.AutoSize = true;
            this.btnTinhTien_71_Tu.BackColor = System.Drawing.Color.Silver;
            this.btnTinhTien_71_Tu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTinhTien_71_Tu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinhTien_71_Tu.ForeColor = System.Drawing.Color.Black;
            this.btnTinhTien_71_Tu.Location = new System.Drawing.Point(69, 80);
            this.btnTinhTien_71_Tu.Name = "btnTinhTien_71_Tu";
            this.btnTinhTien_71_Tu.Size = new System.Drawing.Size(209, 51);
            this.btnTinhTien_71_Tu.TabIndex = 3;
            this.btnTinhTien_71_Tu.Text = "Tính tiền";
            this.btnTinhTien_71_Tu.UseVisualStyleBackColor = false;
            this.btnTinhTien_71_Tu.Click += new System.EventHandler(this.btnTinhTien_71_Tu_Click);
            // 
            // lblTittle_71_Tu
            // 
            this.lblTittle_71_Tu.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTittle_71_Tu.Font = new System.Drawing.Font("Modern No. 20", 37F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittle_71_Tu.ForeColor = System.Drawing.Color.Blue;
            this.lblTittle_71_Tu.Image = global::Bai5_71_Tu.Properties.Resources.NhaKhoa;
            this.lblTittle_71_Tu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTittle_71_Tu.Location = new System.Drawing.Point(0, 0);
            this.lblTittle_71_Tu.Name = "lblTittle_71_Tu";
            this.lblTittle_71_Tu.Size = new System.Drawing.Size(959, 163);
            this.lblTittle_71_Tu.TabIndex = 0;
            this.lblTittle_71_Tu.Text = "Starlight Dental Clinic";
            this.lblTittle_71_Tu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmChinh_71_Tu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(959, 651);
            this.Controls.Add(this.grbDanhDichVu_71_Tu);
            this.Controls.Add(this.lblTittle_71_Tu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmChinh_71_Tu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Starlight Dental Clinic";
            this.grbDanhDichVu_71_Tu.ResumeLayout(false);
            this.grbDanhDichVu_71_Tu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTittle_71_Tu;
        private System.Windows.Forms.GroupBox grbDanhDichVu_71_Tu;
        private System.Windows.Forms.Button btnShow_71_Tu;
        private System.Windows.Forms.Button btnTinhTien_71_Tu;
        private System.Windows.Forms.Button btnThoat_71_Tu;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnDatLich_71_Tu;
        private System.Windows.Forms.Button btnHieuChinhGia_71_Tu;
    }
}