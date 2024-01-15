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
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using static BaMuoiShy.FormDangKy;

namespace BaMuoiShy
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        // Hàm kiểm tra đăng nhập
        public bool CheckLogin(string tenDangNhap, string matKhau)
        {
            // Kiểm tra thông tin đăng nhập
            if (tenDangNhap == "" || matKhau == "")
            {
                return false;
            }

            // Mở file JSON
            string jsonData = File.ReadAllText(@"D:\\Workspace\\demo_KTPM\\demo_KTPM\\BaMuoiShy\\BaMuoiShy\\data\\account.json");

            // Tạo đối tượng JSONReader
            using (var jsonReader = new JsonTextReader(new StringReader(jsonData)))
            {
                // Duyệt qua các đối tượng JSON trong file
                while (jsonReader.Read())
                {
                    if (jsonReader.TokenType == JsonToken.StartObject)
                    {
                        // Đọc đối tượng JSON
                        JObject user = JObject.Load(jsonReader);

                        // So sánh thông tin đăng nhập với thông tin trong file JSON
                        if (user["tenDangNhap"].Value<string>() == tenDangNhap && user["matKhau"].Value<string>() == matKhau)
                        {
                            return true;
                        }
                    }
                }
            }

            // Đăng nhập thất bại
            return false;
        }

        // Hàm load user
        private JObject LoadUser(string tenDangNhap, string matKhau)
        {
            // Mở file JSON
            string jsonData = File.ReadAllText(@"D:\\Workspace\\demo_KTPM\\demo_KTPM\\BaMuoiShy\\BaMuoiShy\\data\\account.json");

            // Tạo đối tượng JSONReader
            using (var jsonReader = new JsonTextReader(new StringReader(jsonData)))
            {
                // Duyệt qua các đối tượng JSON trong file
                while (jsonReader.Read())
                {
                    if (jsonReader.TokenType == JsonToken.StartObject)
                    {
                        // Đọc đối tượng JSON
                        JObject user = JObject.Load(jsonReader);

                        // So sánh thông tin đăng nhập với thông tin trong file JSON
                        if (user["tenDangNhap"].Value<string>() == tenDangNhap && user["matKhau"].Value<string>() == matKhau)
                        {
                            return user;
                        }
                    }
                }
            }

            // Không tìm thấy user
            return null;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            // Khai báo biến user
            JObject user = null;

            if (CheckLogin(tenDangNhap.Text, matKhau.Text))
            {
                // Đăng nhập thành công
                MessageBox.Show("Đăng nhập thành công!");
                this.Close();
                // Lấy id khách hàng
                user = LoadUser(tenDangNhap.Text, matKhau.Text);

                FormDatLich fdl = new FormDatLich();
                fdl.DataBinding(this, user["id"].ToString());
                fdl.ShowDialog();
            }
            else
            {
                // Đăng nhập thất bại
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!");
                return;
            }
        }
    }
}
