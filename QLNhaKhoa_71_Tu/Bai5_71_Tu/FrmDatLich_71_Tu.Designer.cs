namespace Bai5_71_Tu
{
    partial class FrmDatLich_71_Tu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDatLich_71_Tu));
            this.btnThoat_71_Tu = new System.Windows.Forms.Button();
            this.lblName_71_Tu = new System.Windows.Forms.Label();
            this.lblNgayKham_71_Tu = new System.Windows.Forms.Label();
            this.lblCaKham_71_Tu = new System.Windows.Forms.Label();
            this.txtName_71_Tu = new System.Windows.Forms.TextBox();
            this.dtpNgayKham_71_Tu = new System.Windows.Forms.DateTimePicker();
            this.cboCaKham_71_Tu = new System.Windows.Forms.ComboBox();
            this.btnDatLich_71_Tu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnThoat_71_Tu
            // 
            this.btnThoat_71_Tu.AutoSize = true;
            this.btnThoat_71_Tu.BackColor = System.Drawing.Color.Silver;
            this.btnThoat_71_Tu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat_71_Tu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat_71_Tu.ForeColor = System.Drawing.Color.Black;
            this.btnThoat_71_Tu.Location = new System.Drawing.Point(607, 339);
            this.btnThoat_71_Tu.Name = "btnThoat_71_Tu";
            this.btnThoat_71_Tu.Size = new System.Drawing.Size(162, 51);
            this.btnThoat_71_Tu.TabIndex = 4;
            this.btnThoat_71_Tu.Text = "Thoát";
            this.btnThoat_71_Tu.UseVisualStyleBackColor = false;
            this.btnThoat_71_Tu.Click += new System.EventHandler(this.btnThoat_71_Tu_Click);
            // 
            // lblName_71_Tu
            // 
            this.lblName_71_Tu.AutoSize = true;
            this.lblName_71_Tu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName_71_Tu.Location = new System.Drawing.Point(44, 57);
            this.lblName_71_Tu.Name = "lblName_71_Tu";
            this.lblName_71_Tu.Size = new System.Drawing.Size(261, 39);
            this.lblName_71_Tu.TabIndex = 5;
            this.lblName_71_Tu.Text = "Tên khách hàng";
            // 
            // lblNgayKham_71_Tu
            // 
            this.lblNgayKham_71_Tu.AutoSize = true;
            this.lblNgayKham_71_Tu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayKham_71_Tu.Location = new System.Drawing.Point(44, 153);
            this.lblNgayKham_71_Tu.Name = "lblNgayKham_71_Tu";
            this.lblNgayKham_71_Tu.Size = new System.Drawing.Size(189, 39);
            this.lblNgayKham_71_Tu.TabIndex = 7;
            this.lblNgayKham_71_Tu.Text = "Ngày khám";
            // 
            // lblCaKham_71_Tu
            // 
            this.lblCaKham_71_Tu.AutoSize = true;
            this.lblCaKham_71_Tu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaKham_71_Tu.Location = new System.Drawing.Point(44, 248);
            this.lblCaKham_71_Tu.Name = "lblCaKham_71_Tu";
            this.lblCaKham_71_Tu.Size = new System.Drawing.Size(153, 39);
            this.lblCaKham_71_Tu.TabIndex = 8;
            this.lblCaKham_71_Tu.Text = "Ca khám";
            // 
            // txtName_71_Tu
            // 
            this.txtName_71_Tu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName_71_Tu.Location = new System.Drawing.Point(321, 57);
            this.txtName_71_Tu.Name = "txtName_71_Tu";
            this.txtName_71_Tu.Size = new System.Drawing.Size(448, 45);
            this.txtName_71_Tu.TabIndex = 6;
            // 
            // dtpNgayKham_71_Tu
            // 
            this.dtpNgayKham_71_Tu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayKham_71_Tu.Location = new System.Drawing.Point(321, 153);
            this.dtpNgayKham_71_Tu.Name = "dtpNgayKham_71_Tu";
            this.dtpNgayKham_71_Tu.Size = new System.Drawing.Size(448, 36);
            this.dtpNgayKham_71_Tu.TabIndex = 11;
            this.dtpNgayKham_71_Tu.ValueChanged += new System.EventHandler(this.dtpNgayKham_71_Tu_ValueChanged);
            // 
            // cboCaKham_71_Tu
            // 
            this.cboCaKham_71_Tu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCaKham_71_Tu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCaKham_71_Tu.FormattingEnabled = true;
            this.cboCaKham_71_Tu.Items.AddRange(new object[] {
            "Ca1 (7h30 - 10h30)",
            "Ca 2 (13h30 - 16h30)",
            "Ca 3 (17h30 -  20h30)"});
            this.cboCaKham_71_Tu.Location = new System.Drawing.Point(321, 248);
            this.cboCaKham_71_Tu.Name = "cboCaKham_71_Tu";
            this.cboCaKham_71_Tu.Size = new System.Drawing.Size(448, 37);
            this.cboCaKham_71_Tu.TabIndex = 12;
            // 
            // btnDatLich_71_Tu
            // 
            this.btnDatLich_71_Tu.AutoSize = true;
            this.btnDatLich_71_Tu.BackColor = System.Drawing.Color.Silver;
            this.btnDatLich_71_Tu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatLich_71_Tu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatLich_71_Tu.ForeColor = System.Drawing.Color.Black;
            this.btnDatLich_71_Tu.Location = new System.Drawing.Point(51, 339);
            this.btnDatLich_71_Tu.Name = "btnDatLich_71_Tu";
            this.btnDatLich_71_Tu.Size = new System.Drawing.Size(162, 51);
            this.btnDatLich_71_Tu.TabIndex = 13;
            this.btnDatLich_71_Tu.Text = "Đặt lịch";
            this.btnDatLich_71_Tu.UseVisualStyleBackColor = false;
            this.btnDatLich_71_Tu.Click += new System.EventHandler(this.btnDatLich_71_Tu_Click);
            // 
            // FrmDatLich_71_Tu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDatLich_71_Tu);
            this.Controls.Add(this.cboCaKham_71_Tu);
            this.Controls.Add(this.dtpNgayKham_71_Tu);
            this.Controls.Add(this.lblCaKham_71_Tu);
            this.Controls.Add(this.lblNgayKham_71_Tu);
            this.Controls.Add(this.txtName_71_Tu);
            this.Controls.Add(this.lblName_71_Tu);
            this.Controls.Add(this.btnThoat_71_Tu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmDatLich_71_Tu";
            this.Text = "Đặt lịch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThoat_71_Tu;
        private System.Windows.Forms.Label lblName_71_Tu;
        private System.Windows.Forms.Label lblNgayKham_71_Tu;
        private System.Windows.Forms.Label lblCaKham_71_Tu;
        private System.Windows.Forms.TextBox txtName_71_Tu;
        private System.Windows.Forms.DateTimePicker dtpNgayKham_71_Tu;
        private System.Windows.Forms.ComboBox cboCaKham_71_Tu;
        private System.Windows.Forms.Button btnDatLich_71_Tu;
    }
}