# 💻 Hệ Thống Quản Lý Cửa Hàng Máy Tính

Dự án được xây dựng trong khuôn khổ môn học _Lập trình .NET_ nhằm phát triển một hệ thống quản lý cửa hàng máy tính chuyên nghiệp với giao diện WinForms, sử dụng kiến trúc 3 lớp, kết nối CSDL SQL Server và tích hợp thư viện giao diện Bunifu hiện đại.

---

## 🧰 Công Nghệ Sử Dụng

- 🖥️ **Ngôn ngữ:** C# (.NET Framework)
- 🗃️ **Cơ sở dữ liệu:** SQL Server
- 🔌 **Kết nối CSDL:** ADO.NET
- 🧱 **Kiến trúc phần mềm:** 3 lớp (`GUI` – `DTO` – `BLL` – `DAL`)
- 🎨 **Giao diện:** WinForms + Bunifu.UI.WinForms.dll
- 📊 **Báo cáo:** RDLC + DataSet (.xsd)
- 🔧 **IDE:** Visual Studio 2022

---

## 🎯 Các Chức Năng Chính

- Quản lý nhân viên, khách hàng, nhà cung cấp, nhà sản xuất
- Quản lý sản phẩm, loại sản phẩm
- Quản lý đơn đặt hàng, phiếu nhập, phiếu xuất
- Quản lý tài khoản, phân quyền đăng nhập
- Báo cáo – thống kê hoạt động bán hàng và kho
- Giao diện dễ sử dụng, trực quan, thân thiện với người dùng

---

## 👥 Thành Viên Nhóm

| Họ Tên              | GitHub        | Phụ Trách                                     |
| ------------------- | ------------- | --------------------------------------------- |
| Trần Văn Sơn        | `hwangseonit` | Giao diện chính, thống kê tổng hợp            |
| Nguyễn Đức Trí      | `Carousel666` | Phiếu xuất, đơn đặt hàng, thống kê phiếu xuất |
| Trần Minh Chiến     | `sharkg79`    | Phiếu nhập, nhà cung cấp, thống kê phiếu nhập |
| Đỗ Minh Quang       | `Dwangnt`     | Quản lý nhân sự, khách hàng, đăng nhập        |
| Nguyễn Sỹ Quang Huy | `Quanghuy299` | Sản phẩm, loại sản phẩm, nhà sản xuất         |

---

## 🚀 Hướng Dẫn Chạy Project

### 📥 1. Tải source code về

```bash
git clone https://github.com/hwangseonit/Project-Group-12.git
```

### 📂 2. Mở Project bằng Visual Studio

- Mở file `QuanLyCuaHangMayTinh.sln` bằng **Visual Studio 2022**
- Đảm bảo **đã cài .NET Framework 4.7.2 trở lên**

### 🔌 3. Kết nối cơ sở dữ liệu

- Khởi tạo SQL Server và database `QL_CuaHangMayTinh`
- Update chuỗi kết nối trong `App.config` hoặc trong `DAL/Database.cs`

```xml
<connectionStrings>
  <add name="cnstr" connectionString="Data Source=.;Initial Catalog=QL_CuaHangMayTinh;Integrated Security=True"/>
</connectionStrings>
```

### 📦 4. Khôi phục thư viện ngoài (Bunifu)

- Thêm `Bunifu.UI.WinForms.dll` vào Project:

  - Chuột phải `References` → `Add Reference` → `Browse` → Chọn `Bunifu.UI.WinForms.dll`

- Đảm bảo bạn đã cài:
  - `Microsoft.SqlServer.Types` (qua NuGet hoặc thủ công)
  - RDLC support nếu cần xem báo cáo (`ReportViewer`)

### ▶️ 5. Build & Run

- Nhấn `Ctrl + F5` hoặc `Start` để chạy chương trình
- Đăng nhập bằng tài khoản mặc định (nếu có sẵn trong DB)

---

## 📌 Ghi Chú

- Bạn cần SQL Server cài sẵn + có quyền tạo DB
- Báo cáo RDLC hoạt động khi có dữ liệu mẫu trong bảng
- File `.gitignore` đã loại trừ `bin/`, `obj/`, `.vs/`, `packages/`...

---

## 📬 Liên Hệ

- 📧 Email nhóm trưởng: **hoangsonvq1@gmail.com**
- 📍 Repo chính: [github.com/hwangseonit/Project-Group-12](https://github.com/hwangseonit/Project-Group-12)

---

> © 2024 - Project Nhóm Lập trình .NET - WinForms + SQL Server
