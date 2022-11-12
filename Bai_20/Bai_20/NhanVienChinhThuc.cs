using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bai_20
{
    public class NhanVienChinhThuc:NhanVien
    {
        public new void TinhLuong()
        {
            base.TinhLuong();
            Console.WriteLine("Đây là phương thức tính lương của NhanVienChinhThuc");
        }
        // ghi override (TinhLuong) để hiện phương thức kế thừa lớp cha
        public override int TinhLuong(int ngayCong)
        {
            if (ngayCong == 20)
                return 10000000;
            return base.TinhLuong(ngayCong);
        }
    }
}
