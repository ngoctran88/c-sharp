using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bai_28
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if(picOn.Visible==false)
            { 
                btnTurnOnorTurnOff.Text = txtName.Text + ". Turn on the light, please!";
            }
            else
            {
                btnTurnOnorTurnOff.Text = txtName.Text + ". Turn off the light, please!";
            }
        }

        private void btnTurnOnorTurnOff_Click(object sender, EventArgs e)
        {
            if(picOn.Visible==true)
            {
                picOn.Visible = false;
                picOff.Visible = true;
                btnTurnOnorTurnOff.Text = btnTurnOnorTurnOff.Text.Replace("on", "off");
            }
            else
            {
                picOn.Visible = true;
                picOff.Visible = false;
                btnTurnOnorTurnOff.Text = btnTurnOnorTurnOff.Text.Replace("off", "on");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn muốn thoát không?", "Hỏi thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Error);
            if (ret == DialogResult.Yes)
                Close();
        }
    }
}
