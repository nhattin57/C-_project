using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySanPham
{
    

    public partial class frmDanhMuc : Form
    {
        public static bool coThayDoi = false;
        public frmDanhMuc()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DanhMuc dm = new DanhMuc();
            dm.maDM = txtMaDM.Text;
            dm.tenDM = txtTenDM.Text;
            frmSanPham.danhSachDanhMuc.Add(dm);
            HienThiDanhMucLenListBox();

            txtMaDM.Text = "";
            txtTenDM.Text = "";
            txtMaDM.Focus();
            coThayDoi = true;
        }
        void HienThiDanhMucLenListBox()
        {
            lstDanhMuc.Items.Clear();
            foreach( DanhMuc dm in frmSanPham.danhSachDanhMuc)
            {
                lstDanhMuc.Items.Add(dm);
            }
        }
        private void frmDanhMuc_Load(object sender, EventArgs e)
        {
            HienThiDanhMucLenListBox();
        }

        private void lstDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstDanhMuc.SelectedIndex != -1)
            {
                DanhMuc dm = lstDanhMuc.SelectedItem as DanhMuc;
                txtMaDM.Text = dm.maDM;
                txtTenDM.Text = dm.tenDM;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lstDanhMuc.SelectedIndex != -1)
            {
                DanhMuc dm = lstDanhMuc.SelectedItem as DanhMuc;
                lstDanhMuc.Items.Remove(dm);
                coThayDoi = true;
            }
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (coThayDoi == true)
                DialogResult = DialogResult.OK;
            else
                DialogResult = DialogResult.Cancel;
        }
    }
}
