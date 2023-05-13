using System;

namespace _21880291
{
    struct MatHang
    {
        public int Ma;
        public string Ten;
        public DateTime HanSuDung;
        public int NamSX;
        public string CongTySanXuat;
        public LoaiMatHang LoaiHang;
    }
    struct LoaiMatHang
    {
        // public int MaLoai;
        public string TenLoai;
    }

    internal class Program
    {      
        static void NhapThongTinMatHang(out MatHang MH)
        {
            Console.Write("Ma mat hang: ");
            MH.Ma = int.Parse(Console.ReadLine());
            Console.Write("Ten mat hang: ");
            MH.Ten = Console.ReadLine();
            Console.Write("Nhap Han su dung (yyyy-mm-dd): ");
            MH.HanSuDung = DateTime.Parse(Console.ReadLine());
            Console.Write("Nhap nam san xuat: ");
            MH.NamSX = int.Parse(Console.ReadLine());
            Console.Write("Nhap cong ty san xuat: ");
            MH.CongTySanXuat = Console.ReadLine();

            // neu khong nhap loai hang, mat hang se co loai mac dinh
            MH.LoaiHang = new LoaiMatHang();
            Console.Write("Nhap loai hang: ");
            MH.LoaiHang.TenLoai = Console.ReadLine();
            if (string.IsNullOrWhiteSpace (MH.LoaiHang.TenLoai))
            {
                MH.LoaiHang.TenLoai = "Chua phan loai";
            }
        }       
    
        // Hien thi cac thong tin cua mat hang
        static void HienThiThongTinMatHang(MatHang MH)
        {
            Console.WriteLine("Ma mat hang: {0}", MH.Ma);
            Console.WriteLine("Ten mat hang: {0}", MH.Ten);
            Console.WriteLine("Han su dung: {0}", MH.HanSuDung);
            Console.WriteLine("Nam san xuat: {0}", MH.NamSX);
            Console.WriteLine("Cong ty san xuat: {0}", MH.CongTySanXuat);
            Console.WriteLine("Loai mat hang: {0}", MH.LoaiHang.TenLoai);
        }

        // Hien thi cac thong tin cua mat hang
        static void HienThiThongTinLoaiHang(LoaiMatHang lMH)
        {
            //Console.WriteLine("Ma mat hang: {0}", lMH.MaLoai);
            Console.WriteLine("Ten loai hang: {0}", lMH.TenLoai);
        }

        //them mat hang moi
        static void ThemMatHang(ref MatHang[] danhSachMatHang, LoaiMatHang[] danhSachLoaiHang)
        {
            Console.WriteLine("Nhap thong tin mat hang moi:");

            // Tao mat hang moi 
            MatHang mh = new MatHang();
            NhapThongTinMatHang(out mh);
            danhSachMatHang[danhSachMatHang.Length - 1] = mh;

            LoaiMatHang lmh = new LoaiMatHang();
            lmh.TenLoai = mh.LoaiHang.TenLoai;
            danhSachLoaiHang[danhSachLoaiHang.Length - 1] = lmh;

            Console.WriteLine("Mat hang da duoc them vao danh sach.");
        }

        // Xoa mat hang
        static void XoaMatHang(ref MatHang[] danhsachMatHang)
        {
            Console.Write("Nhap ma mat hang can xoa: ");
            int maXoa = int.Parse(Console.ReadLine());
            bool timThay = false;
            for (int i = 0; i < danhsachMatHang.Length; i++)
            {
                if (danhsachMatHang[i].Ma == maXoa)
                {
                    danhsachMatHang[i] = danhsachMatHang[danhsachMatHang.Length - 1];
                    Array.Resize(ref danhsachMatHang, danhsachMatHang.Length - 1);
                    Console.WriteLine("Da xoa mat hang");
                    timThay = true;
                    break;
                }
            }
            if (timThay)
            {
                Console.WriteLine("Khong tim thay mat hang co ma {O}", maXoa);
            }
        }

        // Chinh sua mat hang 
        static void SuaMatHang(ref MatHang[] danhsachMatHang)
        {
            Console.Write("Nhap ma mat hang can sua: ");
            int maSua = int.Parse(Console.ReadLine());
            bool timThay = false;
            for (int i = 0; i < danhsachMatHang.Length; i++)
            {
                if (danhsachMatHang [i].Ma == maSua)
                {
                    NhapThongTinMatHang(out danhsachMatHang[i]);
                    Console.WriteLine("Da sua thong tin mat hang co ma {O}",maSua);
                    timThay = true;
                    break;
                }
            }
            if (!timThay)
            {
                Console.WriteLine("Khong tim thay mat hang co ma {O}",maSua);
            }
        }

        // Tim kiem mat hang 
        static void TimKiemMatHang(MatHang[] danhSachMatHang)
        {
            Console.Write("Nhap ma mat hang can tim kiem: ");
            int maTim = int.Parse(Console.ReadLine());
            MatHang matHangCanTim = default (MatHang);

            foreach (MatHang matHang in danhSachMatHang)
            {
                if (matHang.Ma == maTim)
                {
                    matHangCanTim = matHang;
                    break;
                }
            }

            if (matHangCanTim.Ma != 0)
            {
                Console.WriteLine("Mat hang co ma {0} co thong tin nhu sau:", maTim);
                HienThiThongTinMatHang(matHangCanTim);
            }
            else
            {
                Console.WriteLine("Khong tim thay mat hang co ma {0}", maTim);
            }
        }

        // them loai hang
        static void ThemLoaiMatHang(ref LoaiMatHang[] danhSachLoaiMatHang)
        {
            Console.Write("Nhap loai mat hang moi: ");
            string loaiHangMoi = Console.ReadLine();
            bool timThay = false;
            for (int i = 0; i < danhSachLoaiMatHang.Length; i++)
            {
                if (danhSachLoaiMatHang[i].TenLoai == loaiHangMoi)
                {
                    Console.WriteLine("Da co loai mat hang {0}", loaiHangMoi);
                    timThay = true;
                    break;
                }
            }
            if (!timThay)
            {
                Array.Resize(ref danhSachLoaiMatHang, danhSachLoaiMatHang.Length + 1);
                LoaiMatHang loaiMatHangMoi = new LoaiMatHang();
                loaiMatHangMoi.TenLoai = loaiHangMoi;
                danhSachLoaiMatHang[danhSachLoaiMatHang.Length - 1] = loaiMatHangMoi;
                Console.WriteLine("Da them loai mat hang {0}", loaiHangMoi);
            }
        }
        // Xoa loai hang
        static void XoaLoaiHang(ref LoaiMatHang[] danhSachLoaiMatHang)
        {
            Console.Write("Nhap loai mat hang can xoa: ");
            string loaiHangXoa = Console.ReadLine();
            bool timThay = false;
            for (int i = 0; i < danhSachLoaiMatHang.Length; i++)
            {
                if (danhSachLoaiMatHang[i].TenLoai == loaiHangXoa)
                {
                    danhSachLoaiMatHang[i] = danhSachLoaiMatHang[danhSachLoaiMatHang.Length - 1];
                    Array.Resize(ref danhSachLoaiMatHang, danhSachLoaiMatHang.Length - 1);
                    i--;
                    timThay = true;
                }
            }
            if (timThay)
            {
                Console.WriteLine("Da xoa loai mat hang {0}", loaiHangXoa);
            }
            else
            {
                Console.WriteLine("Khong tim thay loai hang {0}", loaiHangXoa);
            }
        }
        // Sua loai hang
        static void SuaLoaiHang(ref LoaiMatHang[] danhSachLoaiMatHang)
        {
            Console.Write("Nhap ten loai mat hang can sua: ");
            //int maLoaiSua;
            string tenLoaiSua = Console.ReadLine(); 

            int LoaiSua = -1;
            for (int i = 0; i < danhSachLoaiMatHang.Length; i++)
            {
                if (danhSachLoaiMatHang[i].TenLoai == tenLoaiSua)
                {
                    LoaiSua = i;
                    break;
                }
            }

            if (LoaiSua == -1)
            {
                Console.WriteLine("Loai mat hang {0} khong ton tai trong danh sach.", tenLoaiSua);
                return;
            }

            Console.Write("Nhap ten moi cua loai mat hang: ");
            string tenLoaiMoi = Console.ReadLine();

            danhSachLoaiMatHang[LoaiSua].TenLoai = tenLoaiMoi;
            Console.WriteLine("Da sua loai mat hang co ten: {0} thanh: {1}.", tenLoaiSua, tenLoaiMoi);
        }
        // tim kiem loai hang
        static void TimKiemLoai(LoaiMatHang[] danhSachLoaiHang)
        {
            Console.Write("Nhap ten loai hang can tim kiem: ");
            string tenTim = Console.ReadLine();
            LoaiMatHang loaiHangTim = default(LoaiMatHang);

            foreach (LoaiMatHang loaiHang in danhSachLoaiHang)
            {
                if (loaiHang.TenLoai == tenTim)
                {
                    loaiHangTim = loaiHang;
                    break;
                }
            }

            if (loaiHangTim.TenLoai == tenTim)
            {
                Console.WriteLine("Loai hang ten {0} co thong tin nhu sau:", tenTim);
                HienThiThongTinLoaiHang(loaiHangTim);
            }
            else
            {
                Console.WriteLine("Khong tim thay loai hang co ten {0}", tenTim);
            }
        }

        static void Main(string[] args)
        {
            MatHang [] matHangs = new MatHang [10];
            LoaiMatHang[] loaiHangs = new LoaiMatHang[10];

            MatHang mH = new MatHang();
            int LuaChon = 0;
            do 
            {
                Console.WriteLine("1. Them mat hang");
                Console.WriteLine("2. Xoa mat hang");
                Console.WriteLine("3. Chinh sua mat hang");
                Console.WriteLine("4. Tim kiem mat hang");
                Console.WriteLine("***********");
                Console.WriteLine("5. Them loai hang");
                Console.WriteLine("6. Xoa loai hang");
                Console.WriteLine("7. Chinh sua loai hang");
                Console.WriteLine("8. Tim kiem loai hang");
                Console.WriteLine("0. Thoat");
           
                Console.Write("Nhap lua chon: ");
                int.TryParse(Console.ReadLine(), out LuaChon);

                if (LuaChon == 1)
                {
                    ThemMatHang(ref matHangs, loaiHangs);
                }
                else if (LuaChon == 2)
                {
                    XoaMatHang(ref matHangs);
                }
                else if (LuaChon == 3)
                {
                    SuaMatHang(ref matHangs);
                }
                else if (LuaChon == 4)
                {
                    TimKiemMatHang(matHangs);
                }
                else if (LuaChon == 5)
                {
                    ThemLoaiMatHang(ref loaiHangs);
                }
                else if (LuaChon == 6)
                {
                    XoaLoaiHang(ref loaiHangs);
                }
                else if (LuaChon == 7)
                {
                    SuaLoaiHang(ref loaiHangs);
                }              
                else if (LuaChon == 8)
                {
                    TimKiemLoai(loaiHangs);
                }
                else if (LuaChon == 0)
                {
                    Console.WriteLine("Cam on ban da su dung");
                }
                else
                {
                    Console.WriteLine("Lua chon khong hop le. Vui long chon lai.");
                }

                Console.WriteLine("Nhan phim bat ky de tiep tuc...");
                Console.ReadKey();
                //Console.Clear();
            } while (LuaChon != 0) ;
                    
        }
    }
}
