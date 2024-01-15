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
    public partial class FormThanhToan : Form
    {
        double total_amount1;
        public FormThanhToan()
        {
            InitializeComponent();
        }

        public void DataBinding(FormDatLich formDatLich, double total_amount)
        {
            // Gán giá trị cho biến toàn cục
            total_amount1 = total_amount;
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanh Toán Thành Công!");
            this.Close();
        }

        private void FormThanhToan_Load(object sender, EventArgs e)
        {
            lbTien.Text = total_amount1.ToString() + "VNĐ";
        }
    }
}
