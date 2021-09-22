using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySanPham
{
    public class DanhMuc
    {
        public string maDM { get; set; }
        public string tenDM { get; set; }
        private Dictionary<string, SanPham> dsSP = new Dictionary<string, SanPham>();
        public void themSanPham(SanPham sp)
        {
            if (this.dsSP.ContainsKey(sp.maSP) == false)
            {
                dsSP.Add(sp.maSP, sp);
                sp.nhom = this;
            }
            
        }
        public Dictionary<string,SanPham> dsSanPhams
        {
            get { return this.dsSP; }
            set { this.dsSP = value; }
        }
        public override string ToString()
        {
            return this.tenDM;
        }
    }
}
