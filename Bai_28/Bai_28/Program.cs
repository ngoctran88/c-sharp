using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Bai_28
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmLogin frm = new frmLogin();
            if(frm.ShowDialog()==DialogResult.OK)
            {
                Application.Run(new Form1());
            }
            
        }
    }
}
