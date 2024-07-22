using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Bai7_QLMuonSach
{
    internal class SinhVien
    {
        public string HoTen { get; set; }
        public string MSV {  get; set; }
        public DateTime NgaySinh { get; set; }
        public string Lop {  get; set; }

        public SinhVien(string hoTen, string mSV, DateTime ngaySinh, string lop)
        {
            HoTen = hoTen;
            MSV = mSV;
            NgaySinh = ngaySinh;
            Lop = lop;
        }

        public override string ToString()
        {
            return $"Ho Ten: {HoTen}, MSV: {MSV}, Ngay Sinh: {NgaySinh}, Lop: {Lop}";
        }
    }
}
