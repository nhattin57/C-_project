using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanPham
{
    public class SanPham
    {
        public string maSP { get; set; }
        public string tenSP { get; set; }
        public double donGia { get; set; }
        public string xuatXu { get; set; }
        public DateTime hanDung { get; set; }
        public DanhMuc nhom { get; set; }
        public override string ToString()
        {
            return this.tenSP;
        }
    }
}
