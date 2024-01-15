using Newtonsoft.Json;
using Newtonsoft.Json.Bson;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BaMuoiShy.FormDangKy;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace BaMuoiShy
{
    public partial class FormDatLich : Form
    {
        // Khai báo biến toàn cục
        int idKhachHang1;
        double total_amount;
        public FormDatLich()
        {
            InitializeComponent();
        }

        public void DataBinding(FormDangNhap formDangNhap, string idKhachHang)
        {
            // Gán giá trị cho biến toàn cục
            idKhachHang1 = int.Parse(idKhachHang);
        }

        private bool KiemTraNgayDatLich()
        {
            DateTime today = DateTime.Now;

            // Kiểm tra ngày đặt lịch
            if (ngay.Value.CompareTo(today) <= 0)
            {
                return false;
            }

            return true;
        }

        private bool KiemTraDichVu()
        {
            // Kiểm tra xem ít nhất 1 dịch vụ đã được chọn hay chưa
            if (!catTocNam.Checked && !catTocNu.Checked && !uToc.Checked && !nhuomToc.Checked)
            {
                return false;
            }

            return true;
        }

        private bool KiemTraGio()
        {
            // Kiểm tra xem giờ đã được chọn hay chưa
            if (gio.SelectedIndex == -1)
            {
                return false;
            }

            return true;
        }

        private bool KiemTraDiaDiem()
        {
            // Kiểm tra xem địa điểm đã được chọn hay chưa
            if (diaDiem.SelectedIndex == -1)
            {
                return false;
            }

            return true;
        }

        // Khởi tạo list dịch vụ
        List<string> dichVu = new List<string>();

        private double TinhTongTien()
        {
            // Khởi tạo tổng tiền thanh toán
            double total_amount = 0;

            // Lấy giá trị của các checkbox dịch vụ
            if (catTocNam.Checked)
            {
                dichVu.Add(catTocNam.Text);
                total_amount += 100000;
            }

            if (catTocNu.Checked)
            {
                dichVu.Add(catTocNu.Text);
                total_amount += 120000;
            }

            if (uToc.Checked)
            {
                dichVu.Add(uToc.Text);
                total_amount += 300000;
            }

            if (nhuomToc.Checked)
            {
                dichVu.Add(nhuomToc.Text);
                total_amount += 350000;
            }

            return total_amount;
        }

        public bool DatLichCatToc(string ngay1, string gio1, string diaDiem1)
        {
            // Kiểm tra ngày đặt lịch
            if (!KiemTraNgayDatLich())
            {
                MessageBox.Show("Vui lòng chọn ngày khác!");
                return false;
            }

            // Kiểm tra các lựa chọn dịch vụ
            if (!KiemTraDichVu())
            {
                MessageBox.Show("Vui lòng chọn ít nhất 1 dịch vụ!");
                return false;
            }

            // Kiểm tra giờ đặt lịch
            if (!KiemTraGio())
            {
                MessageBox.Show("Vui lòng chọn giờ!");
                return false;
            }

            // Kiểm tra địa điểm đặt lịch
            if (!KiemTraDiaDiem())
            {
                MessageBox.Show("Vui lòng chọn địa điểm!");
                return false;
            }

            // Tính tổng tiền thanh toán
            total_amount = TinhTongTien();

            // Mở file JSON
            string jsonData = File.ReadAllText(@"D:\\Workspace\\demo_KTPM\\demo_KTPM\\BaMuoiShy\\BaMuoiShy\\data\\lichcattoc.json");

            List<DatLich> dl = JsonConvert.DeserializeObject<List<DatLich>>(jsonData);

            
            // Sử dụng biến toàn cục
            int idKhachHang = idKhachHang1;
            // Lấy id account đặt lịch
            int idKhachHang2 = idKhachHang;

            // Thêm id của lịch đặt
            List<JObject> ld = JsonConvert.DeserializeObject<List<JObject>>(jsonData);
            int id = ld.Count + 1;

            DatLich dl1 = new DatLich(id, idKhachHang2, dichVu, ngay1, gio1, diaDiem1, total_amount);
            dl.Add(dl1);

            // Lưu dữ liệu lịch đặt vào file JSON
            jsonData = JsonConvert.SerializeObject(dl);
            File.WriteAllText(@"D:\\Workspace\\demo_KTPM\\demo_KTPM\\BaMuoiShy\\BaMuoiShy\\data\\lichcattoc.json", jsonData);

            return true;
        }

        private void btnDatLich_Click(object sender, EventArgs e)
        {
            if (DatLichCatToc(ngay.Text, gio.Text, diaDiem.Text))
            {
                // Thông báo đăng ký thành công
                MessageBox.Show("Đặt Lịch Thành Công!");
                // Chuyển sang form thanh toán
                FormThanhToan ftt = new FormThanhToan();
                this.Close();
                ftt.DataBinding(this, total_amount);
                ftt.ShowDialog();
            }

        }
        public class DatLich
        {
            public int id { get; set; }
            public int idKhachHang { get; set; }
            public List<string> dichVu { get; set; }
            public string ngay { get; set; }
            public string gio { get; set; }
            public string diaDiem { get; set; }
            public double total_amount {  get; set; }

            public DatLich(int id, int idKhachHang, List<string> dichVu, string ngay, string gio, string diaDiem, double total_amount)
            {
                this.id = id;
                this.idKhachHang = idKhachHang;
                this.dichVu = dichVu;
                this.ngay = ngay;
                this.gio = gio;
                this.diaDiem = diaDiem;
                this.total_amount = total_amount;
            }
        }
    }
}
