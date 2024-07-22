using CS_Bai7_QLMuonSach;

class Program
{
    static void Main(string[] args)
    {
        QuanLyThuVien qltv = new QuanLyThuVien();

        while (true)
        {
            Console.WriteLine("Chon chuc nang: ");
            Console.WriteLine("1. Nhap the muon");
            Console.WriteLine("2. Hien thi danh sach the muon");
            Console.WriteLine("3. In danh sach sinh vien tra sach cuoi thang");
            Console.WriteLine("4. Thoat");

            int choice = int.Parse(Console.ReadLine());

            switch(choice)
            {
                case 1:
                    qltv.NhapTheMuon();
                    break;

                case 2:
                    qltv.HienThiDanhSachTheMuon();
                    break;

                case 3:
                    qltv.InDanhSachSinhVienTraCuoiThang();
                    break;

                case 4:
                    return;

                default:
                    Console.WriteLine("Chon chuc nang khong hop le. Vui long thu lai");
                    break;
            }
        }
    }
}