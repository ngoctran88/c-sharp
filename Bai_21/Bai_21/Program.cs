using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bai_21
{
    class Program
    {
        static List<PhongBan> dsPB = new List<PhongBan>();
        static void TestQLNV()
        {
            PhongBan pNS = new PhongBan();
            pNS.MaPhongBan = 1;
            pNS.TenPhongBan = "Phòng nhân sự";
            dsPB.Add(pNS);

            NhanVien teo = new NhanVien();
            teo.MaNhanVien = 1;
            teo.TenNhanVien = "Tèo";
            teo.ChucVu = LoaiChucVu.TRUONG_PHONG;
            pNS.ThemNhanVien(teo);

            NhanVien ty = new NhanVien();
            ty.MaNhanVien = 2;
            ty.TenNhanVien = "Tý";
            ty.ChucVu = LoaiChucVu.NHAN_VIEN;
            pNS.ThemNhanVien(ty);

            NhanVien ngoc = new NhanVien();
            ngoc.MaNhanVien = 3;
            ngoc.TenNhanVien = "Ngọc";
            ngoc.ChucVu = LoaiChucVu.GIAM_DOC;
            pNS.ThemNhanVien(ngoc);

            PhongBan pkt = new PhongBan();
            pkt.MaPhongBan = 2;
            pkt.TenPhongBan = "Phòng kế toán";
            dsPB.Add(pkt);
            NhanVien bin = new NhanVien();
            bin.MaNhanVien = 4;
            bin.TenNhanVien = "Trần thị bin";
            bin.ChucVu = LoaiChucVu.PHO_PHONG;
            pkt.ThemNhanVien(bin);

            Console.WriteLine("Danh sách toàn bộ nhân viên trong công ty:");

            foreach(PhongBan pb in dsPB)
            {
                Console.WriteLine(pb.TenPhongBan);
                pb.XuatToanBoNhanVien();
            }

            NhanVien old = pkt.TimNhanVien(4);
            if(old!=null)
            {
                old.TenNhanVien = "Trần bin bin";
            }
            Console.WriteLine("Danh sách toàn bộ nhân viên trong công ty sau khi sửa:");
            foreach(PhongBan pb in dsPB)
            {
                Console.WriteLine(pb.TenPhongBan);
                pb.XuatToanBoNhanVien();
            }

            pNS.XoaNhanVien(2);
            Console.WriteLine("Danh sách toàn bộ nhân viên trong công ty sau khi xóa:");
            foreach(PhongBan pb in dsPB)
            {
                Console.WriteLine(pb.TenPhongBan);
                pb.XuatToanBoNhanVien();
            }
            Console.WriteLine("Danh sách nhân viên thuộc phòng nhân sự:");
            pNS.XuatToanBoNhanVien();
            pNS.SapXep();
            Console.WriteLine("Danh sách nhân viên thuộc phòng nhân sự sau khi sắp xếp:");
            pNS.XuatToanBoNhanVien();

            long sum = 0;
            foreach (PhongBan pb in dsPB)
                sum += pb.TongLuong();
            Console.WriteLine("Tổng lương phải thanh toán cho 1 tháng={0}", sum);
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            TestQLNV();
            Console.ReadLine();
        }
    }
}
