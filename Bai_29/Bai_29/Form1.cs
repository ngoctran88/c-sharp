using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bai_29
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtTen, "");
            errorProvider1.SetError(txtTuoi, "");
            errorProvider1.SetError(dtpDate, "");
            if (txtTen.Text == "")
                errorProvider1.SetError(txtTen, "Bạn chưa nhập tên!");
            int tuoi = 0;
            if(int.TryParse(txtTuoi.Text,out tuoi)==false)
            {
                errorProvider1.SetError(txtTuoi, "Bạn nhập sai tuổi");
            }
            else
            {
                if (tuoi < 18)
                { 
                    errorProvider1.SetError(txtTuoi, "Nhập tuổi lớn hơn 17");
                    return;
                }
            }
            if(dtpDate.Value.DayOfWeek==DayOfWeek.Sunday)
            {
                errorProvider1.SetError(dtpDate, "Chủ nhật không thi");
                return;
            }
            MessageBox.Show("Bạn đã nhập thông tin hợp lệ và đăng ký thành công");
        }
    }
}
