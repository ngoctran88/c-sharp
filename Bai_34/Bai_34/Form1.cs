using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bai_34
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        Button lasted = null;
        private void btnThem_Click(object sender, EventArgs e)
        {
            Button btn = new Button();
            Random rd = new Random();
            btn.Text = rd.Next(102) + "";
            btn.Width = 100;
            btn.Height = 30;
            btn.BackColor = Color.Yellow;
            pnButton.Controls.Add(btn);
            btn.Click += Btn_Click;
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            if(lasted!=null)//trước đó đã chọn rồi
            {
                lasted.BackColor = Color.Yellow;
            }
            Button btn = sender as Button;
            btn.BackColor = Color.Red;
            lasted = btn;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(lasted!=null)
            {
                pnButton.Controls.Remove(lasted);
            }
        }
    }
}
