# DOAN_NMLT_KHTN_DTTX
Đồ án Nhập môn lập trình_ hệ DTTX
*Chỉ sử dụng kiến thức trong phạm vi môn học:*
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
struct MatHang
{
public int Ma;
public string Ten;
}

 Lưu ý: bên trong vẫn còn 2 khai báo chưa được nhắc đến đó là:

Constructor (hàm khởi tạo).
Các phương thức mà mình muốn cung cấp để hỗ trợ người dùng khi thao tác với dữ liệu bên trong struct.
Hai phần này sẽ được trình bày trong bài CLASS TRONG C#. Còn trong bài học này ta chỉ tìm hiểu cú pháp cơ bản của struct thôi.
