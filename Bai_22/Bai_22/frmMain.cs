using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bai_22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
            this.WindowState = FormWindowState.Normal;
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
            this.Text = "Tui đã đen thui";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Bạn chọn đóng cửa sổ");
        }
    }
}
