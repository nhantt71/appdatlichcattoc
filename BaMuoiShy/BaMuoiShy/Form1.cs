using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaMuoiShy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            FormDangNhap fdn = new FormDangNhap();
            fdn.ShowDialog();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            FormDangKy fdk = new FormDangKy();
            fdk.ShowDialog();
        }
    }
}
