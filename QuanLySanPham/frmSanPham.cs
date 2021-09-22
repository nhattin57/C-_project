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
    public partial class frmSanPham : Form
    {
        public static List<DanhMuc> danhSachDanhMuc = new List<DanhMuc>();
        List<SanPham> dsSP = new List<SanPham>();
        public frmSanPham()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnQLDM_Click(object sender, EventArgs e)
        {
            frmDanhMuc frmDM = new frmDanhMuc();
            frmDanhMuc.coThayDoi = false;
            if (frmDM.ShowDialog() == DialogResult.OK)
            {
                HienThiDanhMucLenCombobox();
            }
        }
        private void HienThiDanhMucLenCombobox()
        {
            cboDanhMuc.Items.Clear();
            foreach(DanhMuc dm in danhSachDanhMuc)
            {
                cboDanhMuc.Items.Add(dm);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (cboDanhMuc.SelectedIndex == -1)
            {
                MessageBox.Show("Bạn chưa chọn danh mục");
                return;
            }
            DanhMuc dm = cboDanhMuc.SelectedItem as DanhMuc;
            SanPham sp = new SanPham();
            sp.maSP = txtMaSP.Text;
            sp.tenSP = txtTenSP.Text;
            sp.donGia = double.Parse(txtDonGia.Text);
            sp.xuatXu = txtXuatXu.Text;
            sp.hanDung = dtpHanDung.Value;
            dm.themSanPham(sp);
            dsSP.Add(sp);
            hienThiSanPhamLenListBox();

            xoaTrangchitietSanPham();
        }
        void xoaTrangchitietSanPham()
        {
            txtMaSP.Text = "";
            txtTenSP.Text = "";
            txtDonGia.Text = "";
            txtXuatXu.Text = "";
            txtMaSP.Focus();
        }
        void hienThiSanPhamLenListBox()
        {
            lstSanPham.Items.Clear();
            foreach (SanPham sp in dsSP)
                lstSanPham.Items.Add(sp);
        }

        private void lstSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstSanPham.SelectedIndex == -1)
                return;
            SanPham sp = lstSanPham.SelectedItem as SanPham;
            cboDanhMuc.Text= sp.nhom.tenDM;
            txtMaSP.Text = sp.maSP;
            txtTenSP.Text = sp.tenSP;
            txtDonGia.Text = sp.donGia+"";
            txtXuatXu.Text = sp.xuatXu;
            dtpHanDung.Value = sp.hanDung;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lstSanPham.SelectedIndex == -1)
                MessageBox.Show("Bạn chưa chọn sản phẩm xóa");
            SanPham sp = lstSanPham.SelectedItem as SanPham;
            DialogResult ret= MessageBox.Show("Bạn có muốn xóa " + sp.tenSP+" không?",
                            "Thông báo",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);
            if(ret==DialogResult.Yes)
            {
                dsSP.Remove(sp);
                hienThiSanPhamLenListBox();
            }
        }
    }
}
