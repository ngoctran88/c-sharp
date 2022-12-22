using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bai_38
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] M;
        Random rd = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        void HienThiMangLenTexBox(int []M,TextBox txt)
        {
            txt.Text = "";
            foreach (int x in M)
                txt.Text += x + " ";
        }

        private void btnXuatMangNgauNhien_Click(object sender, EventArgs e)
        {
            M = new int[10];
            for (int i = 0; i < M.Length; i++)
                M[i] = rd.Next(100);
            HienThiMangLenTexBox(M, txtMangGoc);
        }

        private void btnTinhTongGiaTriMang_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < M.Length; i++)
                sum += M[i];
            txtKetQua.Text = "Tổng mảng = " + sum + "";
        }

        private void btnDemSoPhanTuLe_Click(object sender, EventArgs e)
        {
            int dem = 0;
            foreach (int x in M)
                if (x % 2 != 0)
                    dem++;
            txtKetQua.Text = "Có " + dem + " Số lẻ";
        }

        private void btnTongGiaTriPhanTuLe_Click(object sender, EventArgs e)
        {
            int sum = 0;
            foreach (int x in M)
                if (x % 2 != 0)
                    sum += x;
            txtKetQua.Text = "Tổng lẻ = " + sum;
        }

        private void btnTimPhanTuNhoNhat_Click(object sender, EventArgs e)
        {
            int min = M[0];
            for(int i=1;i<M.Length;i++)
            {
                if (min > M[i])
                    min = M[i];
            }
            txtKetQua.Text = "Số nhỏ nhất = " + min;
        }

        private void btnTangMoiPhanTuLen2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < M.Length; i++)
                M[i] = M[i] + 2;
            HienThiMangLenTexBox(M, txtKetQua);
        }

        private void btnSapMangTang_Click(object sender, EventArgs e)
        {
            Array.Sort(M);
            HienThiMangLenTexBox(M, txtKetQua);
        }

        private void btnSapMangGiam_Click(object sender, EventArgs e)
        {
            Array.Sort(M);
            Array.Reverse(M);
            HienThiMangLenTexBox(M, txtKetQua);
        }
    }
}
