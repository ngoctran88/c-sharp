using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bai_06
{
    class Program
    {
        static void Main(string[] args)
        {
            /*//if,if.else:
            Console.OutputEncoding = Encoding.UTF8;
            double diem;
            Console.WriteLine("Mời bạn nhập vào 1 điểm:");
            diem = double.Parse(Console.ReadLine());
            //"5.5"==>5.5
            if (diem >= 5)
            {
                Console.WriteLine("Điểm ={0}==>Đậu", diem);
            }
            else
            {
                Console.WriteLine("Điểm ={0}==>Rớt", diem);
            }*/

            //toán tử 3 ngôi:
            /*Console.OutputEncoding = Encoding.UTF8;
            double diem;
            Console.WriteLine("Mời bạn nhập vào 1 điểm:");
            diem = double.Parse(Console.ReadLine());
            string ketqua = diem >= 5 ? "Đậu" : "Rớt";
            Console.WriteLine("Điểm ={0}==>{1}", diem, ketqua);*/

            //cấu trúc switch:
            Console.OutputEncoding = Encoding.UTF8;
            int a, b;
            char kt;
            Console.WriteLine("Nhập a:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập b:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập phép toán(+,-,*,/):");
            kt = Console.ReadLine()[0];
            switch (kt)
            {
                case '+':
                    Console.WriteLine("{0}+{1}={2}", a, b, a + b);
                    break;
                case '-':
                    Console.WriteLine("{0}-{1}={2}", a, b, a - b);
                    break;
                case '*':
                    Console.WriteLine("{0}*{1}={2}", a, b, a * b);
                    break;
                case '/':
                    Console.WriteLine("{0}/{1}={2}", a, b, a / b);
                    break;
            }

            Console.ReadLine();
        }
    }
}
