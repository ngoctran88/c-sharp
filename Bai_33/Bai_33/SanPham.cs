using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bai_33
{
    public class SanPham
    {
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public double DonGia { get; set; }
        public string XuatXu { get; set; }
        public DateTime HanDung { get; set; }
        public DanhMuc Nhom { get; set; }
        public override string ToString()
        {
            return this.TenSP;
        }
    }
}
