using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bai_35
{
    public class DanhSachKhachHang
    {
        List<KhachHang> dsKH = new List<KhachHang>();
        public List<KhachHang>Khachs
        {
            get { return dsKH; }
        }
        public void Mua(KhachHang kh)
        {
            dsKH.Add(kh);
        }
        public int TongSoKhachHang
        {
            get
            {
                return dsKH.Count;
            }
        }
        public int TongSoKhachHangLaSinhVien
        {
            get
            {
                int sosv = 0;
                foreach (KhachHang kh in dsKH)
                    if (kh.LaSinhVien == true)
                        sosv++;
                return sosv;
            }
        }
        public double TongDoanhThu
        {
            get
            {
                double sum = 0;
                foreach (KhachHang kh in dsKH)
                    sum += kh.TinhTien;
                return sum;
            }
        }
    }
}
