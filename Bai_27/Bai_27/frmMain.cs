using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bai_27
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radRed.Checked = true;
            txtNhapTen.Focus();//chỉ định con trỏ
        }

        private void txtNhapTen_TextChanged(object sender, EventArgs e)
        {
            lblLapTrinh.Text = txtNhapTen.Text;
        }

        private void radRed_CheckedChanged(object sender, EventArgs e)
        {
            if (radRed.Checked == true)
                lblLapTrinh.ForeColor = radRed.ForeColor;
        }

        private void radGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (radGreen.Checked == true)
                lblLapTrinh.ForeColor = radGreen.ForeColor;
        }

        private void radBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (radBlue.Checked == true)
                lblLapTrinh.ForeColor = radBlue.ForeColor;
        }

        private void radBlack_CheckedChanged(object sender, EventArgs e)
        {
            if (radBlack.Checked == true)
                lblLapTrinh.ForeColor = radBlack.ForeColor;
        }

        private void chkInDam_CheckedChanged(object sender, EventArgs e)
        {
            lblLapTrinh.Font = new Font(lblLapTrinh.Font.Name,
                lblLapTrinh.Font.Size,
                lblLapTrinh.Font.Style ^ FontStyle.Bold);
        }

        private void chkInNghieng_CheckedChanged(object sender, EventArgs e)
        {
            lblLapTrinh.Font = new Font(lblLapTrinh.Font.Name,
                lblLapTrinh.Font.Size,
                lblLapTrinh.Font.Style ^ FontStyle.Italic);
        }

        private void chkGachChan_CheckedChanged(object sender, EventArgs e)
        {
            lblLapTrinh.Font = new Font(lblLapTrinh.Font.Name,
                lblLapTrinh.Font.Size,
                lblLapTrinh.Font.Style ^ FontStyle.Underline);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn muốn thoát không?", "Hỏi thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Error);
            if(ret==DialogResult.Yes)
                Close();
        }
    }
}
