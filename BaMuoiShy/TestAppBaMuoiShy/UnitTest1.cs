using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BaMuoiShy;
using Rhino.Mocks;

namespace TestAppBaMuoiShy
{
    [TestClass]
    public class FormDangNhapTest
    {
        [TestMethod]
        public void TestCheckLoginSuccess()
        {
            // Tạo đối tượng FormDangNhap
            FormDangNhap form = new FormDangNhap();

            // Đặt tên đăng nhập và mật khẩu
            string tenDangNhap = "admin";
            string matKhau = "123456";

            // Gọi phương thức đăng nhập
            bool isLoginSuccess = form.CheckLogin(tenDangNhap, matKhau);

            // Kiểm tra kết quả
            Assert.IsTrue(isLoginSuccess);
        }

        
        [TestMethod]
        public void TestCheckLoginFailed()
        {
            // Tạo đối tượng FormDangNhap
            FormDangNhap form = new FormDangNhap();

            // Đặt tên đăng nhập và mật khẩu
            string tenDangNhap = "admin";
            string matKhau = "1111111111";

            // Gọi phương thức đăng nhập
            bool isLoginSuccess = form.CheckLogin(tenDangNhap, matKhau);

            // Kiểm tra kết quả
            Assert.IsTrue(isLoginSuccess, "Tài khoản và mật khẩu không đúng!");
        }

        [TestMethod]
        public void CheckLoginFailedByNoneUsername()
        {
            // Tạo đối tượng FormDangNhap
            FormDangNhap form = new FormDangNhap();

            // Đặt tên đăng nhập và mật khẩu
            string tenDangNhap = "admin123";
            string matKhau = "123456";

            // Gọi phương thức đăng nhập
            bool isLoginSuccess = form.CheckLogin(tenDangNhap, matKhau);

            // Kiểm tra kết quả
            Assert.IsTrue(isLoginSuccess, "Tài khoản không đúng!");
        }
    }

    [TestClass]
    public class FormDangKyTest
    {
        [TestMethod]
        public void TestCheckRegisterSuccess()
        {
            // Tạo đối tượng FormDangKy
            FormDangKy form = new FormDangKy();

            // Nhập đầy đủ thông tin đăng ký
            string tenDangNhap = "admindeptrailamluon";
            string matKhau = "123456";
            string ten = "adminne123";
            string sdt = "0912342551";

            // Gọi phương thức đăng nhập
            bool isRegisterSuccess = form.DangKy(ten, sdt, tenDangNhap, matKhau);

            // Kiểm tra kết quả
            Assert.IsTrue(isRegisterSuccess);
        }

        [TestMethod]
        public void TestCheckDuplicateUsername()
        {
            // Tạo đối tượng FormDangKy
            FormDangKy form = new FormDangKy();

            // Nhập đầy đủ thông tin đăng ký
            string tenDangNhap = "admin";

            // Gọi phương thức kiểm tra trùng username
            bool isDuplicateUsername = form.KiemTraTenDangNhapTrung(tenDangNhap);

            // Kiểm tra kết quả
            Assert.IsFalse(isDuplicateUsername);
        }

        [TestMethod]
        public void TestCheckRegisterFailedByMissingInfo()
        {
            // Tạo đối tượng FormDangKy
            FormDangKy form = new FormDangKy();

            // Nhập thiếu tenDangNhap
            string tenDangNhap = "";
            string matKhau = "123456";
            string ten = "adminne123";
            string sdt = "0912342551";

            // Gọi phương thức kiểm tra đủ thông tin
            bool isMissingInfo = form.KiemTraThongTinDangKy(ten, sdt, tenDangNhap, matKhau);

            // Kiểm tra kết quả
            Assert.IsFalse(isMissingInfo);
        }
    }

    [TestClass]
    public class FormDatLichTest
    {
        [TestMethod]
        public void TestDatLichThanhCong()
        {
            // Tạo đối tượng FormDatLich
            FormDatLich form = new FormDatLich();

            // 
            string ngay = "20/01/2024";
            string gio = "10:00";
            string diaDiem = "HA NOI";

            bool isDatLichThanhCong = form.DatLichCatToc(ngay, gio, diaDiem);

            // Kiểm tra kết quả
            Assert.IsFalse(isDatLichThanhCong);
        }
    }
}

