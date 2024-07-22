using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Bai7_QLMuonSach
{
    internal class QuanLyThuVien
    {
        private List<TheMuon> danhSachTheMuon = new List<TheMuon>();

        public void NhapTheMuon()
        {
            Console.WriteLine("Nhap so phieu muon: ");
            int soPhieuMuon = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhap ngay muon (dd/MM/yyyy): ");
            DateTime ngayMuon = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

            Console.WriteLine("Nhap han tra (dd/MM/yyyy): ");
            DateTime hanTra = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

            Console.WriteLine("Nhap so hieu sach: ");
            string soHieuSach = Console.ReadLine();

            Console.WriteLine("Nhap ho ten sinh vien: ");
            string hoTen = Console.ReadLine();

            Console.WriteLine("Nhap MSV: ");
            string mSV = Console.ReadLine();

            Console.WriteLine("Nhap ngay sinh (dd/MM/yyyy): ");
            DateTime ngaySinh = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

            Console.WriteLine("Nhap lop: ");
            string lop = Console.ReadLine();

            SinhVien sinhVien = new SinhVien(hoTen, mSV, ngaySinh, lop);
            TheMuon theMuon = new TheMuon(soPhieuMuon, ngayMuon, hanTra, soHieuSach, sinhVien);

            danhSachTheMuon.Add(theMuon);
            Console.WriteLine("Da them the muon thanh cong");
        }

        public void HienThiDanhSachTheMuon()
        {
            foreach (var theMuon in danhSachTheMuon)
            {
                Console.WriteLine(theMuon);
            }
        }

        public void InDanhSachSinhVienTraCuoiThang()
        {
            var danhSachCuoiThang = danhSachTheMuon.Where(tm => tm.HanTra.Month == DateTime.Now.Month && tm.HanTra == new DateTime(tm.HanTra.Year, tm.HanTra.Month, DateTime.DaysInMonth(tm.HanTra.Year, tm.HanTra.Month))).ToList();
            Console.WriteLine("Danh sach cac sinh vien can tra sach vao ngay cuoi thang: ");
            foreach (var theMuon in danhSachCuoiThang)
            {
                Console.WriteLine(theMuon);
            }
        }
    }
}
