using System;
using System.Text;

namespace Bai_13
{
    class Program
    {
        //Nhập vào 1 chuỗi,sau đó:
        //1.Đếm xem chuỗi có bao nhiêu in HOA,in thường,số
        //2.Đếm số khoảng trắng trong chuỗi.
        static void XuLyChuoi1()
        {
            Console.OutputEncoding = Encoding.UTF8;
            string s = "";
            Console.WriteLine("Mời bạn nhập vào 1 chuỗi:");
            s = Console.ReadLine();
            int demInHoa = 0, demInThuong = 0, demSo = 0, demKT = 0;
            char[] arr = s.ToCharArray();
            for (int i = 0;i < arr.Length;i++)
            {
                if (char.IsLower(arr[i]))
                    demInThuong++;
                if (char.IsUpper(arr[i]))
                    demInHoa++;
                if (char.IsDigit(arr[i]))
                    demSo++;
                if (char.IsWhiteSpace(arr[i]))
                    demKT++;
            }
            Console.WriteLine("Có {0} ký tự in thường", demInThuong);
            Console.WriteLine("Có {0} ký tự in HOA)", demInHoa);
            Console.WriteLine("Có {0} ký tự số", demSo);
            Console.WriteLine("Có {0} ký tự khoảng trắng", demKT);
            Console.ReadLine();
        }
        static void XuLyChuoi2()
        {
            Console.OutputEncoding = Encoding.UTF8;
            string s = "";
            Console.WriteLine("Mời bạn nhập vào 1 chuỗi:");
            s = Console.ReadLine();
            int demInHoa = 0, demInThuong = 0, demSo = 0, demKT = 0;
            for (int i = 0; i < s.Length; i++)
            {
                char kt = s[i];//lấy ký tự thứ i ra
                if (char.IsLower(kt))
                    demInThuong++;
                if (char.IsUpper(kt))
                    demInHoa++;
                if (char.IsDigit(kt))
                    demSo++;
                if (char.IsWhiteSpace(kt))
                    demKT++;
            }
            Console.WriteLine("Có {0} ký tự in thường", demInThuong);
            Console.WriteLine("Có {0} ký tự in HOA)", demInHoa);
            Console.WriteLine("Có {0} ký tự số", demSo);
            Console.WriteLine("Có {0} ký tự khoảng trắng", demKT);
            Console.ReadLine();
        }
        static void XuLyChuoi3()
        {
            Console.OutputEncoding = Encoding.UTF8;
            string s;
            Console.WriteLine("Mời bạn nhập vào 1 chuỗi:");
            s = Console.ReadLine();
            Console.WriteLine("Mời bạn nhập vào 1 chuỗi tiếp theo:");
            string s2 = Console.ReadLine();
            int kq = s.ToLower().CompareTo(s2.ToLower());//đưa về chung 1 định dạng
            if(kq==0)
            {
                Console.WriteLine("s và s2 giống nhau");
            }
            else if(kq<0)
            {
                Console.WriteLine("s < s2");
            }
            else
            {
                Console.WriteLine("s > s2");
            }
            Console.ReadLine();
        }
        static void XuLyChuoi4()
        {
            string s = string.Format("{0:dd/MM/yyyy HH:mm:ss}", DateTime.Now);
            Console.WriteLine(s);
            Console.ReadLine();
        }
        static void XuLyChuoi5()
        {
            Console.OutputEncoding = Encoding.UTF8;
            string s = "D:/baihat/nhacJimmii Nguyễn/Tình Và Đời.mp3";
            //hãy tìm vị trí đầu tiên của ký tự /
            int vt = s.IndexOf("/");
            Console.WriteLine("Tìm thấy ký tự / ở vị trí {0}", vt);
            //hãy tìm vị trí cuối cùng cảu ký tự /
            int vt2 = s.LastIndexOf("/");
            Console.WriteLine("tìm thấy ký tự / ở vị trí thứ {0}", vt2);

            Console.ReadLine();
        }
        static void XuLyChuoi6()
        {
            Console.OutputEncoding = Encoding.UTF8;
            string s = "D:/baihat/nhacJimmii Nguyễn/Tình Và Đời.mp3";
            int vt = s.LastIndexOf("/");
            string tenBh = s.Substring(vt + 1);
            Console.WriteLine(tenBh);
            int vt2 = tenBh.LastIndexOf(".");
            string tenBh2 = tenBh.Substring(0, vt2);
            Console.WriteLine(tenBh2);
            Console.ReadLine();
        }
        static void XuLyChuoi7()
        {
            Console.OutputEncoding = Encoding.UTF8;
            string line = "SV069;Trần Anh Ngọc;ngoc@gmail.com";
            string[] arr = line.Split(';');
            Console.WriteLine("Mã={0}", arr[0]);
            Console.WriteLine("Tên={0}", arr[1]);
            Console.WriteLine("Email={0}", arr[2]);
            Console.ReadLine();
        }
        //cho 1 chuỗi gốc,yêu cầu:
        //xóa các khoảng trắng dư thừa bên trái, phải chuỗi
        //các từ cách nhau bởi 1 khoảng trắng, ký tự đầu tiên viết HOA
        //ví dụ:
        //Nguyễn    Thị GIẢI thOÁT
        //sau khi tối ưu:
        //Nguyễn Thị Giải Thoát
        static void ToiUuChuoi()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Mời bạn nhập vào 1 tên:");
            string ten = Console.ReadLine();
            Console.WriteLine("Chuỗi gốc bạn nhập:");
            Console.WriteLine(ten);

            ten = ten.Trim();//xóa dư thừa bên trái bên phải

            string[] arr = ten.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            ten = "";
            for (int i=0;i<arr.Length;i++)
            {
                //lấy từng từ ra:
                string word = arr[i];
                word = word.ToLower();
                char[] arrWord = word.ToCharArray();
                arrWord[0] = char.ToUpper(arrWord[0]);
                string newWord = new string(arrWord);
                ten += newWord + " ";
            }
            //xóa dư thừa cuối cùng
            ten = ten.Trim();

            Console.WriteLine("Chuỗi sau khi tối ưu:");
            Console.WriteLine(ten);
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            //XuLyChuoi1();
            //XuLyChuoi2();
            //XuLyChuoi3();
            //XuLyChuoi4();
            //XuLyChuoi5();
            //XuLyChuoi6();
            //XuLyChuoi7();
            ToiUuChuoi();
        }
    }
}
