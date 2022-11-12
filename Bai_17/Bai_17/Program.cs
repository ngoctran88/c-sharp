using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bai_17
{
    class Program
    {
        static Dictionary<string, string> dic = new Dictionary<string, string>();

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            while (true)
            {
                menu();

                Console.WriteLine("Bạn có tiếp tục sử dụng từ điển không?(c/k):");
                string s = Console.ReadLine();
                if (s == "k")
                    break;
            }
            Console.WriteLine("Bye Bye!");
            Console.ReadLine();
        }

        private static void menu()
        {
            Console.WriteLine("1.Tạo từ mới");
            Console.WriteLine("2.Sửa từ");
            Console.WriteLine("3.Tra cứu từ");
            Console.WriteLine("4.Xóa từ");
            Console.WriteLine("Bạn chọn chức năng nào?");
            try
            {
                int cn = int.Parse(Console.ReadLine());
                switch (cn)
                {
                    case 1:
                        TaoTuMoi();
                        break;
                    case 2:
                        SuaTu();
                        break;
                    case 3:
                        TraCuu();
                        break;
                    case 4:
                        XoaTu();
                        break;
                    default:
                        Console.WriteLine("Bạn chon sai chức năng rồi!");
                        break;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Lỗi gì đó: " + ex.Message);
            }
        }

        private static void XoaTu()
        {
            Console.WriteLine("Mời bạn nhập vào từ muốn xóa:");
            string ta = Console.ReadLine();
            if(dic.ContainsKey(ta))
            {
                dic.Remove(ta);
                Console.WriteLine("Xóa thành công từ [{0}]", ta);
            }
            else
            {
                Console.WriteLine("Không tìm thấy từ [{0}] để xóa", ta);
            }
        }

        private static void TraCuu()
        {
            Console.WriteLine("Mời bạn nhập vào từ tiếng anh:");
            string ta = Console.ReadLine();
            if(dic.ContainsKey(ta))
            {
                string tv = dic[ta];
                Console.WriteLine("Nghĩa của [{0}] là [{1}]", ta, tv);
            }
            else
            {
                Console.WriteLine("Từ điển chưa cập nhật từ {0}", ta);
            }
        }

        private static void SuaTu()
        {
            Console.WriteLine("Nhập vào tiếng anh để sửa lại nghĩa:");
            string ta = Console.ReadLine();
            if(dic.ContainsKey(ta)==false)
            {
                Console.WriteLine("Không tìm thấy [{0}] để sửa", ta);
            }
            else
            {
                Console.WriteLine("Mời bạn nhập lại nghĩa tiếng việt:");
                string tv = Console.ReadLine();
                dic[ta] = tv;
            }
        }

        private static void TaoTuMoi()
        {
            Console.WriteLine("Mời bạn nhập vào từ tiếng anh:");
            string ta = Console.ReadLine();
            if(dic.ContainsKey(ta))
            {
                Console.WriteLine("Từ {0} đã tồn tại rồi", ta);
            }
            else
            {
                Console.WriteLine("Mời bạn nhập vào nghĩa tiếng việt:");
                string tv = Console.ReadLine();
                dic.Add(ta, tv);
            }
        }
    }
}
