﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bai_20
{
    public class NhanVienThoiVu:NhanVien
    {
        public new void TinhLuong()
        {
            Console.WriteLine("Đây là phương thức tính lương của NhanVienThoiVu");
        }
    }
}
