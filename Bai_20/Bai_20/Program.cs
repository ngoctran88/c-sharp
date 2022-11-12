using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bai_20
{
    class Program
    {
        static void TestNhanVien()
        {
            NhanVienChinhThuc teo = new NhanVienChinhThuc();
            teo.Ma = 1;
            teo.Ten = "Trần Văn Tèo";
            Console.WriteLine("Lương của " + teo.Ten + "=");
            teo.TinhLuong();

            NhanVienThoiVu ty = new NhanVienThoiVu();
            ty.Ma = 2;
            ty.Ten = "Nguyễn văn Tý";
            Console.WriteLine("Lương của " + ty.Ten + "=");
            ty.TinhLuong();
        }
        static void TestNhanVien2()
        {
            NhanVienChinhThuc teo = new NhanVienChinhThuc();
            int luong = teo.TinhLuong(20);
            Console.WriteLine("Lương của Tèo= " + luong);
        }
        static void TestHinhHoc()
        {
            HinhHoc h;
            h = new HinhHoc();
            Console.WriteLine("Diện tích= " + h.TinhDienTich());

            h = new HinhTron();
            Console.WriteLine("Diện tích= " + h.TinhDienTich());
        }
        static void TestHinhChuNhatHinhVuong()
        {
            HinhChuNhat h1 = new HinhChuNhat(4, 10);

            Console.WriteLine("Chu vi= " + h1.ChuVi());
            Console.WriteLine("Diện tích= " + h1.DienTich());

            HinhChuNhat h2 = new HinhVuong(7);
            Console.WriteLine("Chu vi= " + h2.ChuVi());
            Console.WriteLine("Diện tích= " + h2.DienTich());

            HinhVuong h3 = new HinhVuong(6);
            Console.WriteLine("Chu vi= " + h3.ChuVi());
            Console.WriteLine("Diện tích= " + h3.DienTich());
        }
        static void TestInterface()
        {
            ILamViec teo = new NhanVien();
            Console.WriteLine(teo.LamViec("Báo cáo kinh doanh"));

            ILamViec ty = new SinhVien();
            Console.WriteLine(ty.LamViec("Đang học bài c#"));
        }
        static void TestHocAsVaIs()
        {
            List<ILamViec> ds = new List<ILamViec>();
            NhanVien teo = new NhanVien() { Ma = 1, Ten = "Tèo" };
            ds.Add(teo);
            SinhVien ty = new SinhVien() { MaSV = "sv1", TenSV = "Tý" };
            ds.Add(ty);
            ds.Add(new NhanVien() { Ma=2,Ten="Bin"});

            foreach(ILamViec i in ds)
            {
                if(i is NhanVien)
                {
                    NhanVien nv = i as NhanVien;
                    Console.WriteLine("==>Nhân viên " + nv.Ten);
                }
                else if(i is SinhVien)
                {
                    SinhVien sv = i as SinhVien;
                    Console.WriteLine("==>Sinh viên " + sv.TenSV);
                }
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //TestNhanVien();
            //TestNhanVien2();
            //TestHinhHoc();
            //TestHinhChuNhatHinhVuong();
            //TestInterface();
            TestHocAsVaIs();
            Console.ReadLine();
        }
    }
}
