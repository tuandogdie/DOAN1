﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangXeMay
{
    public partial class frmQuanLyNhanVien : Form
    {
        public frmQuanLyNhanVien()
        {
            InitializeComponent();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DialogResult dlrThoat = MessageBox.Show("Bạn Có Chắc Muốn Thoát Khỏi Chương Trình?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (dlrThoat == DialogResult.Yes)
                Application.Exit();
        }

        private void btNhapLai_Click(object sender, EventArgs e)
        {
            tbCMND.Text = "";
            tbDiaChi.Text = "";
            tbMaNV.Text = "";
            tbMatKhau.Text = "";
            tbSDT.Text = "";
            tbTaiKhoan.Text = "";
            tbTenNV.Text = "";
        }
    }
}