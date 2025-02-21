1. Clone và Mở Dự Án
- Clone dự án về máy bằng Git.  
- Mở Visual Studio và mở file `.sln` của dự án.  

2. Thiết Lập Kết Nối Cơ Sở Dữ Liệu 
- Xác định tệp cấu hình kết nối (có thể là `App.config` hoặc `appsettings.json`).  
- Cập nhật thông tin kết nối theo cơ sở dữ liệu bạn sử dụng (SQL Server, MySQL, v.v.).  

3. Cấu Hình Dữ Liệu Mẫu
- Nếu dữ liệu nằm trong database: Mở công cụ quản lý cơ sở dữ liệu (SSMS) và nhập dữ liệu cần thiết.  
- Nếu dữ liệu nằm trong file (`json`, `xml`, `txt`), chỉnh sửa nội dung của file theo yêu cầu.  

4. Chạy Dự Án
- Kiểm tra lại các thư viện (NuGet Packages) và cài đặt nếu thiếu.  
- Nhấn *F5* hoặc chọn *Start Debugging* trong Visual Studio để chạy chương trình.  

5. Xử Lý Lỗi (Nếu Có)
- Nếu lỗi kết nối CSDL, kiểm tra lại chuỗi kết nối.  
- Nếu thiếu thư viện, cài đặt lại bằng *Manage NuGet Packages*.  
- Xem thông báo lỗi trong *Output* hoặc *Error List* để tìm nguyên nhân.
