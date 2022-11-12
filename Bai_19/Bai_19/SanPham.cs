using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bai_19
{
    public class SanPham //Overloading Method
    {
        private int ma;
        private string ten;
        private int donGia;
        public SanPham()
        {
            this.ma = 1;
            this.ten = "";
            this.donGia = 1;
        }
        public SanPham(int ma)
        {
            this.ma = ma;
        }
        public SanPham(int ma,string ten,int donGia)
        {
            this.ma = ma;
            this.ten = ten;
            this.donGia = donGia;
        }
        public void XuatHang(int x)
        {

        }
        public void XuatHang(float x)
        {

        }
        public string Hamx()
        {
            return "";
        }
    }
}
