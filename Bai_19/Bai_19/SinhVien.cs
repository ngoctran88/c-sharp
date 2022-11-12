using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bai_19//bấm chuột phải vào bai19-(solution) chọn class tạo lớp
{
    public class SinhVien
    {//gõ #region để gom nhóm
        #region Các biến lớp
        private int ma;
        private string ten;
        private DateTime namSinh;
        #endregion
        #region Các constructor
        public SinhVien()
        {
            this.ma = 1;
            this.ten = "Tên gì đó";
        }
        public SinhVien(int ma, string ten)
        {
            this.ma = ma;
            this.ten = ten;
        }
        #endregion
        #region Các Properties
        public int Ma
        {
            get
            {
                return this.ma;
            }
            set
            {
                this.ma = value;
            }
        }
        public string Ten
        {
            set
            {
                this.ten = value;
            }
            get
            {
                return this.ten;
            }
        }
        public DateTime NamSinh
        {
            get
            {
                return this.namSinh;
            }
            set
            {
                this.namSinh = value;
            }
        }
        #endregion
        #region Các Phương thức
        public override string ToString()//gõ override ToString() >Enter để tạo phương thức:
        {
            return this.ma+"\t"+this.ten ;
        }
        private bool KiemTraNamSinhHopLe()
        {
            return (DateTime.Now.Year - this.namSinh.Year >= 17);
        }
        public void XuatThongTin()
        {
            if (KiemTraNamSinhHopLe() == false)
                Console.WriteLine("Năm sinh không hợp lệ");
            else
            {
                Console.WriteLine(ToString());
            }
        }
        #endregion
    }
}
