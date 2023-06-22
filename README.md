# DOAN_NMLT_KHTN
#
![Doan](https://gifdb.com/images/high/computer-system-coding-j3szfjv9fwb5at9x.gif)

Đồ án Nhập môn lập trình_ hệ DTTX
.NET mấy cũng được, MS Studio code bản nào cũng được, cứ hiện có hoặc cũ 1 vài version, đừng xem clip r xài như thời tiền xử, mới nhất càng tốt.
*!!! Chỉ sử dụng kiến thức trong phạm vi môn học:*
Không sử dụng **class**, tự định nghĩa các kiểu dữ liệu **(struct)**, không sử dụng các thư viện, hàm có sẵn. (trừ hàm DateTime)
Không ràng buộc về logic chương trình nhưng code cần phải chạy và đảm bảo đủ các yêu cầu.

[Bài viết gốc](https://howkteam.vn/course/khoa-hoc-lap-trinh-c-can-ban/struct-trong-lap-trinh-c-can-ban-1221)
*Struct là một kiểu dữ liệu có cấu trúc, được kết hợp từ các kiểu dữ liệu nguyên thuỷ do người lập trình định nghĩa để thuận tiện trong việc quản lý dữ liệu và lập trình.*
**Đặc điểm của struct:**
Là một kiểu dữ liệu tham trị (int, float, char, string, ..)
Dùng để đóng gói các trường dữ liệu khác nhau nhưng có liên quan đến nhau.
Bên trong struct ngoài các biến có kiểu dữ liệu cơ bản còn có các phương thức, các struct khác.
Muốn sử dụng phải khởi tạo cấp phát vùng nhớ cho đối tượng thông qua toán tử new.
Struct không được phép kế thừa (sẽ học trong môn OOP).

ví dụ: Khai báo struct 
```
struct MatHang
{
public int Ma;
public string Ten;
}

struct SinhVien
        {
            public int MaSo;
            public string HoTen;
        }

        static void NhapThongTinSinhVien(out SinhVien SV)
        {
            Console.Write(" Ma so: ");
            SV.MaSo = int.Parse(Console.ReadLine());
            Console.Write(" Ho ten: ");
            SV.HoTen = Console.ReadLine();
            Console.Write(" Diem toan: ");
            SV.DiemToan = Double.Parse(Console.ReadLine());
            Console.Write(" Diem ly: ");
            SV.DiemLy = Double.Parse(Console.ReadLine());
            Console.Write(" Diem van: ");
            SV.DiemVan = Double.Parse(Console.ReadLine());
        }
        
        static double DiemTBSinhVien(SinhVien SV)
        {
            return (SV.DiemToan + SV.DiemLy + SV.DiemVan) / 3;
        }

        static void Main(string[] args)
        {
            /*
             * Khai báo 1 kiểu dữ liệu SinhVien với các trường thông tin như đề bài.
             * Khai báo và khởi tạo 1 đối tượng SV1 kiểu SinhVien.
             */
            SinhVien SV1 = new SinhVien();
            Console.WriteLine(" Nhap thong tin sinh vien: ");
            NhapThongTinSinhVien(out SV1);
            Console.WriteLine("*********");
            Console.WriteLine(" Thong tin sinh vien vua nhap la: ");
            XuatThongTinSinhVien(SV1);
            Console.WriteLine(" Diem TB cua sinh vien la: " + DiemTBSinhVien(SV1));

            Console.ReadLine();
        }
        
        

 static void NhapThongTinMatHang(out MatHang Mh)
        {
            Console.Write("Ma: ");
            Mh.MaSo = int.Parse(Console.ReadLine());
            Console.Write("tten: ");
            SV.HoTen = Console.ReadLine();
            Console.Write(" Diem toan: ");
            SV.DiemToan = Double.Parse(Console.ReadLine());
            Console.Write(" Diem ly: ");
            SV.DiemLy = Double.Parse(Console.ReadLine());
            Console.Write(" Diem van: ");
            SV.DiemVan = Double.Parse(Console.ReadLine())
```

 Lưu ý: bên trong vẫn còn 2 khai báo chưa được nhắc đến đó là:

Constructor (hàm khởi tạo).
Các phương thức mà mình muốn cung cấp để hỗ trợ người dùng khi thao tác với dữ liệu bên trong struct.
Hai phần này sẽ được trình bày trong bài CLASS TRONG C#. Còn trong bài học này ta chỉ tìm hiểu cú pháp cơ bản của struct thôi.
