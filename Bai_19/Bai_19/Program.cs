using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bai_19
{
    class Program
    {
        static void TestLop()
        {
            Console.OutputEncoding = Encoding.UTF8;

            SinhVien teo = new SinhVien();//constructor ko đối số
            teo.Ten = "Nguyễn Văn Tèo";
            teo.Ma = 113;
            Console.WriteLine(teo);

            string s = teo.Ten;

            SinhVien ngoc = new SinhVien(114, "Trần Anh Ngọc");//constructor có đối số
            Console.WriteLine(ngoc);

            SinhVien an = new SinhVien();
            an.Ma = 2;
            an.Ten = "Nguyễn Công An";
            an.NamSinh = new DateTime(1988, 1, 1);
            an.XuatThongTin();

            Console.ReadLine();
        }
        static void TestParams()
        {
            ClassTestParam test = new ClassTestParam();
            Console.WriteLine(test.Sum(1, 2, 3, 4, 5, 6, 7));
            Console.WriteLine(test.Sum());
            Console.WriteLine(test.Sum(-4,2,5,4,-100));
        }
        static void TestKhachHang()
        {
            List<KhachHang> dsKH = new List<KhachHang>();
            dsKH.Add(new KhachHang() { Ma = 1, Ten = "Ông Tèo", Phone = "09847726344" });

            KhachHang OngTy = new KhachHang();
            OngTy.Ma = 2;
            OngTy.Ten = "Ông Tý";
            OngTy.Phone = "09933323";
            dsKH.Add(OngTy);

            dsKH.Add(new KhachHang()
                {
                    Ma = 3,
                    Ten="Bin",
                    Phone="09212536"
                
                }
            );
            foreach(KhachHang kh in dsKH)
            {
                Console.WriteLine(kh.Ma + "\t" + kh.Ten + "\t" + kh.Phone);
            }
        }
        static void TestAliaGomRac()
        {
            KhachHang teo = new KhachHang() { Ma = 1, Ten = "Tèo", Phone = "0988887" };
            KhachHang ty = new KhachHang() { Ma = 2, Ten = "Tý", Phone = "09122222" };
            teo = ty;
            Console.WriteLine("Tên của Tèo là [{0}]", teo.Ten);
            //như vậy lúc này ô nhớ mà tèo đang trỏ trc lúc gán teo=ty bị thu hồi
            //và lúc này ô nhớ tý đang trỏ có thêm tèo trỏ vào nữa
            //==>tèo hoặc tý đổi thì cũng làm cho cả tèo và tý đổi:
            teo.Ten = "OBAMA";
            Console.WriteLine("Tên của tý là [{0}]", ty.Ten);

            KhachHang an = new KhachHang() { Ma = 3, Ten = "An" };
            KhachHang binh = an.copy();
            //lúc này theo MemberwiseClone thì nó sao chép toàn bộ thông tin của an
            //ra 1 ô nhớ mới hoàn toàn độc lập, ô nhớ này do bình quản lý
            //==>an và bình quản lý hai ô nhớ khác nhau
            //==>an đổi không ảnh hưởng gì tới bình và ngược lại
            binh.Ten = "BÌNH BÍNH BOONG";
            Console.WriteLine("Tên của An là [{0}]", an.Ten);
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //TestParams();
            //TestKhachHang();
            TestAliaGomRac();
            Console.ReadLine();
        }
    }
}
