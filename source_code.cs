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
        public string LoaiMatHang;
    }
    struct LoaiMatHang
    {
        public int MaLoai;
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
            Console.Write("Nhap loai hang: ");
            MH.LoaiMatHang = Console.ReadLine();
        }

        static void HienThiThongTinMatHang(MatHang MH)
        {
            Console.WriteLine("Ma mat hang: {0}", MH.Ma);
            Console.WriteLine("Ten mat hang: {0}", MH.Ten);
            Console.WriteLine("Han su dung: {0}", MH.HanSuDung);
            Console.WriteLine("Nam san xuat: {0}", MH.NamSX);
            Console.WriteLine("Cong ty san xuat: {0}", MH.CongTySanXuat);
            Console.WriteLine("Loai mat hang: {0}", MH.LoaiMatHang);
        }

        /*
        static void ThemMatHang(ref MatHang[] danhsachMatHang, LoaiMatHang[] danhsachLoaiHang)
        {
            MatHang mHs = new MatHang();
            NhapThongTinMatHang(out mHs);
            Array.Resize(ref danhsachMatHang, danhsachMatHang.Length + 1);
            danhsachMatHang[danhsachMatHang.Length - 1] = mHs;
            Console.WriteLine("Da them mat hang moi: ");
        }
        */

        static void ThemMatHang(ref MatHang[] danhSachMatHang, LoaiMatHang[] danhSachLoaiHang)
        {
            Console.WriteLine("Nhap thong tin mat hang moi:");

            // Get the name of the new item
            //Console.Write("Ten mat hang: ");
            //string tenMatHangMoi = Console.ReadLine();

            // Get the type of the new item
            Console.Write("Loai mat hang: ");
            string loaiMatHangMoi = Console.ReadLine();

            // Find the matching LoaiMatHang struct
            LoaiMatHang loaiMatHang = new LoaiMatHang();
            bool timThayLoaiMatHang = false;
            foreach (LoaiMatHang lmh in danhSachLoaiHang)
            {
                if (lmh.TenLoai == loaiMatHangMoi)
                {
                    loaiMatHang = lmh;                  
                    timThayLoaiMatHang = true;
                    break;
                }
            }

            // If the type doesn't exist, prompt the user to create it first
            if (!timThayLoaiMatHang)
            {
                Console.WriteLine("Loai mat hang {0} chua ton tai. Vui long them loai mat hang truoc.", loaiMatHangMoi);
                ThemLoaiMatHang(ref danhSachLoaiHang);
            }

            // Create the new item and add it to the danhSachMatHang array
            MatHang mHs = new MatHang();
            //mHs.Ten = tenMatHangMoi;
            mHs.LoaiMatHang = loaiMatHang.TenLoai;
            NhapThongTinMatHang(out mHs);
            Array.Resize(ref danhSachMatHang, danhSachMatHang.Length + 1);
            danhSachMatHang[danhSachMatHang.Length - 1] = mHs;
            //Console.WriteLine("Da them mat hang co ten {0} va loai mat hang {1}", tenMatHangMoi, loaiMatHangMoi);
        }


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
                    Console.WriteLine("Da xoa mat hang co ma {O}", maXoa);
                    timThay = true;
                    break;
                }
            }
            if (timThay)
            {
                Console.WriteLine("Khong tim thay mat hang co ma {O}", maXoa);
            }
        }

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
                    Console.WriteLine("Da sua thong tin mat hang co ma {O}");
                    timThay = true;
                    break;
                }
            }
            if (!timThay)
            {
                Console.WriteLine("Khong tim thay mat hang co ma {O}");
            }
        }
       
        static void TimKiemMatHang(MatHang[] danhSachMatHang)
        {
            Console.Write("Nhap ma mat hang can tim kiem: ");
            int maMatHangCanTim;
            while (!int.TryParse(Console.ReadLine(), out maMatHangCanTim))
            {
                Console.Write("Ma mat hang khong hop le. Vui long nhap lai: ");
            }

            MatHang matHangCanTim = default(MatHang);
            foreach (MatHang mh in danhSachMatHang)
            {
                if (mh.Ma == maMatHangCanTim)
                {
                    matHangCanTim = mh;
                    break;
                }
            }

            if (matHangCanTim.Ma != 0)
            {
                Console.WriteLine("Mat hang co ma {0} co thong tin nhu sau:", maMatHangCanTim);
                HienThiThongTinMatHang(matHangCanTim);
            }
            else
            {
                Console.WriteLine("Khong tim thay mat hang co ma {0}", maMatHangCanTim);
            }
        }

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
                Console.WriteLine("Da xoa mat hang co loai mat hang {0}", loaiHangXoa);
            }
            else
            {
                Console.WriteLine("Khong tim thay mat hang co loai mat hang {0}", loaiHangXoa);
            }
        }

        static void SuaLoaiHang(ref LoaiMatHang[] danhSachLoaiMatHang)
        {
            Console.Write("Nhap ma loai mat hang can sua: ");
            int maLoaiHangSua;
            while (!int.TryParse(Console.ReadLine(), out maLoaiHangSua))
            {
                Console.Write("Ma loai mat hang khong hop le. Vui long nhap lai: ");
            }

            int loaiHangSua = -1;
            for (int i = 0; i < danhSachLoaiMatHang.Length; i++)
            {
                if (danhSachLoaiMatHang[i].MaLoai == maLoaiHangSua)
                {                  
                    loaiHangSua = i;
                    break;
                }
            }

            if (loaiHangSua != -1)
            {
                Console.WriteLine("Nhap thong tin moi cho loai hang co ma {O}",maLoaiHangSua);
                
                Console.WriteLine("Nhap thong tin moi cho loai mat hang: ");
                Console.Write("Nhap ten moi cho loai mat hang: ");
                string tenloaiMoi = Console.ReadLine();

                danhSachLoaiMatHang[maLoaiHangSua].TenLoai = tenloaiMoi;            
                Console.WriteLine("Da sua thong tin cho loai mat hang co ma {0}", maLoaiHangSua);
            }
            else
            {
                Console.WriteLine("Khong tim thay loai mat hang co ma {0}", maLoaiHangSua);
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
                Console.WriteLine("1.Them mat hang");
                Console.WriteLine("2. Xoa mat hang");
                Console.WriteLine("3. Chinh sua mat hang");
                Console.WriteLine("4. Tim kiem mat hang");
                // *********
                Console.WriteLine("5. Them loai hang");
                Console.WriteLine("6. Sua thong tin loai hang");
                Console.WriteLine("7. Xoa loai hang");
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
                    SuaLoaiHang(ref loaiHangs);
                }
                else if (LuaChon == 7)
                {
                    XoaLoaiHang(ref loaiHangs);
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
