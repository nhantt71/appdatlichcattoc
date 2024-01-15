using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.Json;
using static BaMuoiShy.FormDangKy;

namespace BaMuoiShy
{
    public partial class FormDangKy : Form
    {
        public FormDangKy()
        {
            InitializeComponent();
        }

        public bool KiemTraThongTinDangKy(string ten, string sdt1, string tenDangNhap, string matKhau)
        {
            if (ten == "" || sdt1 == "" || tenDangNhap == "" || matKhau == "")
            {
                return false;
            }

            return true;
        }

        public bool KiemTraTenDangNhapTrung(string tenDangNhap) 
        {
            // Mở file JSON
            string jsonData = File.ReadAllText(@"D:\\Workspace\\demo_KTPM\\demo_KTPM\\BaMuoiShy\\BaMuoiShy\\data\\account.json");

            List<User> users = JsonConvert.DeserializeObject<List<User>>(jsonData);

            // Lấy danh sách các tên đăng nhập
            List<string> tenDangNhaps = JArray.Parse(jsonData).Select(x => x["tenDangNhap"].ToString()).Distinct().ToList();

            if (tenDangNhaps.Contains(tenDangNhap))
            {
                return false;
            }

            return true;
        }

        public bool KiemTraTenDangKy(string tenDangNhap)
        {
            // Kiểm tra khoảng trắng
            if (tenDangNhap.Contains(" "))
            {
                return false;
            }

            // Kiểm tra ký tự đặc biệt
            foreach (char c in tenDangNhap)
            {
                if (!Char.IsLetterOrDigit(c) && c != '_' && c != '-')
                {
                    return false;
                }
            }

            return true;
        }


        public bool DangKy(string ten, string sdt1, string tenDangNhap, string matKhau)
        {
            // Kiểm tra thông tin đăng ký
            if (!KiemTraThongTinDangKy(ten, sdt1, tenDangNhap, matKhau))
            {
                MessageBox.Show("Bạn phải nhập đủ thông tin!");
                return false;
            }

            // Kiểm tra tên đăng nhập đã được sử dụng
            if (!KiemTraTenDangNhapTrung(tenDangNhap))
            {
                MessageBox.Show("Tên đăng nhập này đã được sử dụng!");
                return false;
            }

            // Kiểm tra tên đăng nhập
            if (!KiemTraTenDangKy(tenDangNhap))
            {
                MessageBox.Show("Tên đăng nhập không được chứa khoảng trắng hoặc ký tự đặc biệt!");
                return false;
            }

            // Mở file JSON
            string jsonData = File.ReadAllText(@"D:\\Workspace\\demo_KTPM\\demo_KTPM\\BaMuoiShy\\BaMuoiShy\\data\\account.json");

            List<User> users = JsonConvert.DeserializeObject<List<User>>(jsonData);

            // Thêm người dùng mới
            int id = users.Count + 1;
            User user = new User(id, ten, sdt1, tenDangNhap, matKhau);
            users.Add(user);

            // Ghi lại danh sách người dùng vào file JSON
            jsonData = JsonConvert.SerializeObject(users);
            File.WriteAllText(@"D:\\Workspace\\demo_KTPM\\demo_KTPM\\BaMuoiShy\\BaMuoiShy\\data\\account.json", jsonData);

            return true;
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (DangKy(fullname.Text, sdt.Text, tenDangKy.Text, matKhauDangKy.Text))
            {
                MessageBox.Show("Đăng ký thành công!");
                this.Close();
                FormDangNhap fdn = new FormDangNhap();
                fdn.ShowDialog();
            }
            else
            {
                // Giữ lại trạng thái đăng ký
                fullname.Text = fullname.Text;
                sdt.Text = sdt.Text;
                tenDangKy.Text = tenDangKy.Text;
                matKhauDangKy.Text = matKhauDangKy.Text;
            }
        }
        public class User
        {
            public int id { get; set; }
            public string ten { get; set; }
            public string sdt { get; set; }
            public string tenDangNhap { get; set; }
            public string matKhau { get; set; }

            public User(int id, string ten, string sdt, string tenDangNhap, string matKhau)
            {
                this.id = id;
                this.ten = ten;
                this.sdt = sdt;
                this.tenDangNhap = tenDangNhap;
                this.matKhau = matKhau;
            }
        }
    }
}
