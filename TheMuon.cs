using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Bai7_QLMuonSach
{
    internal class TheMuon
    {
        public int SoPhieuMuon { get; set; }
        public DateTime NgayMuon { get; set; }
        public DateTime HanTra {  get; set; }
        public string SoHieuSach { get; set; }
        public SinhVien SinhVien { get; set; }

        public TheMuon(int soPhieuMuon, DateTime ngayMuon, DateTime hanTra, string soHieuSach, SinhVien sinhVien)
        {
            SoPhieuMuon = soPhieuMuon;
            NgayMuon = ngayMuon;
            HanTra = hanTra;
            SoHieuSach = soHieuSach;
            SinhVien = sinhVien;
        }

        public override string ToString()
        {
            return $"So Phieu Muon: {SoPhieuMuon}, Ngay Muon: {NgayMuon}, Han Tra: {HanTra}, So Hieu Sach: {SoHieuSach}, {SinhVien}";
        }
    }
}
