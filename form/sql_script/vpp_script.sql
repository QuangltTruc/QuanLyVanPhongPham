USE [master]
GO
/****** Object:  Database [QUANLY_VPP]    Script Date: 07/06/2022 7:49:20 PM ******/
CREATE DATABASE [QUANLY_VPP]
 CONTAINMENT = NONE
GO
ALTER DATABASE [QUANLY_VPP] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QUANLY_VPP].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QUANLY_VPP] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QUANLY_VPP] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QUANLY_VPP] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QUANLY_VPP] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QUANLY_VPP] SET ARITHABORT OFF 
GO
ALTER DATABASE [QUANLY_VPP] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QUANLY_VPP] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QUANLY_VPP] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QUANLY_VPP] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QUANLY_VPP] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QUANLY_VPP] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QUANLY_VPP] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QUANLY_VPP] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QUANLY_VPP] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QUANLY_VPP] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QUANLY_VPP] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QUANLY_VPP] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QUANLY_VPP] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QUANLY_VPP] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QUANLY_VPP] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QUANLY_VPP] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QUANLY_VPP] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QUANLY_VPP] SET RECOVERY FULL 
GO
ALTER DATABASE [QUANLY_VPP] SET  MULTI_USER 
GO
ALTER DATABASE [QUANLY_VPP] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QUANLY_VPP] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QUANLY_VPP] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QUANLY_VPP] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QUANLY_VPP] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'QUANLY_VPP', N'ON'
GO
ALTER DATABASE [QUANLY_VPP] SET QUERY_STORE = OFF
GO
USE [QUANLY_VPP]
GO
/****** Object:  Table [dbo].[CHITIETHD]    Script Date: 07/06/2022 7:49:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIETHD](
	[MACTHD] [int] IDENTITY(1,1) NOT NULL,
	[MAHD] [int] NULL,
	[MASP] [int] NULL,
	[SOLUONG] [int] NULL,
	[THANHTIEN] [money] NULL,
 CONSTRAINT [PK_CHITIETHD] PRIMARY KEY CLUSTERED 
(
	[MACTHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CHITIETPHIEUNHAP]    Script Date: 07/06/2022 7:49:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHITIETPHIEUNHAP](
	[MACTPN] [int] IDENTITY(1,1) NOT NULL,
	[MAPN] [int] NULL,
	[MASP] [int] NULL,
	[SOLUONG] [int] NULL,
	[THANHTIEN] [money] NULL,
 CONSTRAINT [PK_CTPHIEUNHAP] PRIMARY KEY CLUSTERED 
(
	[MACTPN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HOADON]    Script Date: 07/06/2022 7:49:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOADON](
	[MAHD] [int] IDENTITY(1,1) NOT NULL,
	[MAKH] [int] NULL,
	[MANV] [int] NULL,
	[NGAYLAP] [date] NULL,
	[GIAMGIA] [money] NULL,
	[TONGTIEN] [money] NULL,
 CONSTRAINT [PK_HD] PRIMARY KEY CLUSTERED 
(
	[MAHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 07/06/2022 7:49:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHACHHANG](
	[MAKH] [int] IDENTITY(1,1) NOT NULL,
	[TENKH] [nvarchar](100) NULL,
	[SDT] [varchar](20) NULL,
	[GIOITINH] [nvarchar](10) NULL,
 CONSTRAINT [PK_KH] PRIMARY KEY CLUSTERED 
(
	[MAKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LOAISP]    Script Date: 07/06/2022 7:49:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAISP](
	[MALOAISP] [int] IDENTITY(1,1) NOT NULL,
	[TENLOAISP] [nvarchar](200) NULL,
 CONSTRAINT [PK_LOAISP] PRIMARY KEY CLUSTERED 
(
	[MALOAISP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHACUNGCAP]    Script Date: 07/06/2022 7:49:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHACUNGCAP](
	[MANCC] [int] IDENTITY(1,1) NOT NULL,
	[TENNCC] [nvarchar](200) NULL,
	[SDT] [varchar](20) NULL,
	[EMAIL] [varchar](100) NULL,
	[DIACHI] [nvarchar](300) NULL,
 CONSTRAINT [PK_NCC] PRIMARY KEY CLUSTERED 
(
	[MANCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 07/06/2022 7:49:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[MANV] [int] IDENTITY(1,1) NOT NULL,
	[TENNV] [nvarchar](100) NULL,
	[GIOITINH] [nvarchar](10) NULL,
	[DIACHI] [nvarchar](200) NULL,
	[SDT] [varchar](20) NULL,
	[CHUCVU] [int] NULL,
	[TENDN] [varchar](50) NULL,
	[MK] [varchar](50) NULL,
 CONSTRAINT [PK_NV] PRIMARY KEY CLUSTERED 
(
	[MANV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHIEUNHAP]    Script Date: 07/06/2022 7:49:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUNHAP](
	[MAPN] [int] IDENTITY(1,1) NOT NULL,
	[MANCC] [int] NULL,
	[MANV] [int] NULL,
	[NGAYLAP] [date] NULL,
	[TONGTIEN] [money] NULL,
 CONSTRAINT [PK_PHIEUNHAP] PRIMARY KEY CLUSTERED 
(
	[MAPN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SANPHAM]    Script Date: 07/06/2022 7:49:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SANPHAM](
	[MASP] [int] IDENTITY(1,1) NOT NULL,
	[TENSP] [nvarchar](200) NULL,
	[MALOAI] [int] NULL,
	[DONGIA] [money] NULL,
	[SOLUONGTON] [int] NULL,
	[HINHANH] [nvarchar](500) NULL,
 CONSTRAINT [PK_SP] PRIMARY KEY CLUSTERED 
(
	[MASP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[CHITIETHD] ON 
GO
INSERT [dbo].[CHITIETHD] ([MACTHD], [MAHD], [MASP], [SOLUONG], [THANHTIEN]) VALUES (1, 1, 20, 4, 480000.0000)
GO
INSERT [dbo].[CHITIETHD] ([MACTHD], [MAHD], [MASP], [SOLUONG], [THANHTIEN]) VALUES (2, 2, 27, 3, 1650000.0000)
GO
INSERT [dbo].[CHITIETHD] ([MACTHD], [MAHD], [MASP], [SOLUONG], [THANHTIEN]) VALUES (3, 2, 20, 2, 240000.0000)
GO
INSERT [dbo].[CHITIETHD] ([MACTHD], [MAHD], [MASP], [SOLUONG], [THANHTIEN]) VALUES (4, 2, 14, 6, 420000.0000)
GO
INSERT [dbo].[CHITIETHD] ([MACTHD], [MAHD], [MASP], [SOLUONG], [THANHTIEN]) VALUES (5, 3, 14, 4, 280000.0000)
GO
INSERT [dbo].[CHITIETHD] ([MACTHD], [MAHD], [MASP], [SOLUONG], [THANHTIEN]) VALUES (6, 3, 11, 3, 30000.0000)
GO
INSERT [dbo].[CHITIETHD] ([MACTHD], [MAHD], [MASP], [SOLUONG], [THANHTIEN]) VALUES (7, 3, 34, 2, 28000.0000)
GO
INSERT [dbo].[CHITIETHD] ([MACTHD], [MAHD], [MASP], [SOLUONG], [THANHTIEN]) VALUES (8, 4, 14, 5, 350000.0000)
GO
INSERT [dbo].[CHITIETHD] ([MACTHD], [MAHD], [MASP], [SOLUONG], [THANHTIEN]) VALUES (9, 4, 15, 1, 38000.0000)
GO
INSERT [dbo].[CHITIETHD] ([MACTHD], [MAHD], [MASP], [SOLUONG], [THANHTIEN]) VALUES (10, 4, 25, 3, 36000.0000)
GO
SET IDENTITY_INSERT [dbo].[CHITIETHD] OFF
GO
SET IDENTITY_INSERT [dbo].[CHITIETPHIEUNHAP] ON 
GO
INSERT [dbo].[CHITIETPHIEUNHAP] ([MACTPN], [MAPN], [MASP], [SOLUONG], [THANHTIEN]) VALUES (1, 1, 42, 50, 0.0000)
GO
INSERT [dbo].[CHITIETPHIEUNHAP] ([MACTPN], [MAPN], [MASP], [SOLUONG], [THANHTIEN]) VALUES (2, 2, 10, 50, 0.0000)
GO
INSERT [dbo].[CHITIETPHIEUNHAP] ([MACTPN], [MAPN], [MASP], [SOLUONG], [THANHTIEN]) VALUES (3, 2, 12, 100, 0.0000)
GO
INSERT [dbo].[CHITIETPHIEUNHAP] ([MACTPN], [MAPN], [MASP], [SOLUONG], [THANHTIEN]) VALUES (4, 2, 13, 100, 0.0000)
GO
INSERT [dbo].[CHITIETPHIEUNHAP] ([MACTPN], [MAPN], [MASP], [SOLUONG], [THANHTIEN]) VALUES (5, 2, 11, 100, 0.0000)
GO
INSERT [dbo].[CHITIETPHIEUNHAP] ([MACTPN], [MAPN], [MASP], [SOLUONG], [THANHTIEN]) VALUES (6, 2, 21, 100, 0.0000)
GO
INSERT [dbo].[CHITIETPHIEUNHAP] ([MACTPN], [MAPN], [MASP], [SOLUONG], [THANHTIEN]) VALUES (7, 2, 22, 50, 0.0000)
GO
SET IDENTITY_INSERT [dbo].[CHITIETPHIEUNHAP] OFF
GO
SET IDENTITY_INSERT [dbo].[HOADON] ON 
GO
INSERT [dbo].[HOADON] ([MAHD], [MAKH], [MANV], [NGAYLAP], [GIAMGIA], [TONGTIEN]) VALUES (1, 1, 1, CAST(N'2022-06-07' AS Date), 20000.0000, 480000.0000)
GO
INSERT [dbo].[HOADON] ([MAHD], [MAKH], [MANV], [NGAYLAP], [GIAMGIA], [TONGTIEN]) VALUES (2, 8, 2, CAST(N'2022-06-07' AS Date), 20000.0000, 2310000.0000)
GO
INSERT [dbo].[HOADON] ([MAHD], [MAKH], [MANV], [NGAYLAP], [GIAMGIA], [TONGTIEN]) VALUES (3, 2, 2, CAST(N'2022-06-07' AS Date), 15000.0000, 338000.0000)
GO
INSERT [dbo].[HOADON] ([MAHD], [MAKH], [MANV], [NGAYLAP], [GIAMGIA], [TONGTIEN]) VALUES (4, 5, 2, CAST(N'2022-06-07' AS Date), 20000.0000, 424000.0000)
GO
SET IDENTITY_INSERT [dbo].[HOADON] OFF
GO
SET IDENTITY_INSERT [dbo].[KHACHHANG] ON 
GO
INSERT [dbo].[KHACHHANG] ([MAKH], [TENKH], [SDT], [GIOITINH]) VALUES (1, N'Nguyễn Trọng Nghĩa', N'0911422428', N'Nam')
GO
INSERT [dbo].[KHACHHANG] ([MAKH], [TENKH], [SDT], [GIOITINH]) VALUES (2, N'Huỳnh Anh Triệu', N'0931748456', N'Nam')
GO
INSERT [dbo].[KHACHHANG] ([MAKH], [TENKH], [SDT], [GIOITINH]) VALUES (3, N'Huỳnh Tấn Kiệt', N'0343592659', N'Nam')
GO
INSERT [dbo].[KHACHHANG] ([MAKH], [TENKH], [SDT], [GIOITINH]) VALUES (4, N'Nguyễn Nhật Hào', N'0385120406', N'Nam')
GO
INSERT [dbo].[KHACHHANG] ([MAKH], [TENKH], [SDT], [GIOITINH]) VALUES (5, N'Nguyễn Thị Thu Ngân', N'0396219444', N'Nữ')
GO
INSERT [dbo].[KHACHHANG] ([MAKH], [TENKH], [SDT], [GIOITINH]) VALUES (6, N'Đỗ Thị Hải Yến', N'0707796677', N'Nữ')
GO
INSERT [dbo].[KHACHHANG] ([MAKH], [TENKH], [SDT], [GIOITINH]) VALUES (7, N'Nguyễn Thị Quỳnh Như', N'0783536600', N'Nữ')
GO
INSERT [dbo].[KHACHHANG] ([MAKH], [TENKH], [SDT], [GIOITINH]) VALUES (8, N'Nguyễn Quốc Trung', N'0793453322', N'Nam')
GO
INSERT [dbo].[KHACHHANG] ([MAKH], [TENKH], [SDT], [GIOITINH]) VALUES (9, N'Nguyễn Nhật Trường', N'078990077', N'Nam')
GO
INSERT [dbo].[KHACHHANG] ([MAKH], [TENKH], [SDT], [GIOITINH]) VALUES (10, N'Nguyễn Đình Khả', N'0703227711', N'Nam')
GO
SET IDENTITY_INSERT [dbo].[KHACHHANG] OFF
GO
SET IDENTITY_INSERT [dbo].[LOAISP] ON 
GO
INSERT [dbo].[LOAISP] ([MALOAISP], [TENLOAISP]) VALUES (1, N'Bút viết')
GO
INSERT [dbo].[LOAISP] ([MALOAISP], [TENLOAISP]) VALUES (2, N'Tập - sổ')
GO
INSERT [dbo].[LOAISP] ([MALOAISP], [TENLOAISP]) VALUES (3, N'Máy tính')
GO
INSERT [dbo].[LOAISP] ([MALOAISP], [TENLOAISP]) VALUES (4, N'Bảng')
GO
INSERT [dbo].[LOAISP] ([MALOAISP], [TENLOAISP]) VALUES (5, N'Phấn')
GO
INSERT [dbo].[LOAISP] ([MALOAISP], [TENLOAISP]) VALUES (6, N'Lau bảng')
GO
INSERT [dbo].[LOAISP] ([MALOAISP], [TENLOAISP]) VALUES (7, N'Bấm kim')
GO
INSERT [dbo].[LOAISP] ([MALOAISP], [TENLOAISP]) VALUES (8, N'Thước')
GO
INSERT [dbo].[LOAISP] ([MALOAISP], [TENLOAISP]) VALUES (9, N'Dao kéo cắt giấy')
GO
INSERT [dbo].[LOAISP] ([MALOAISP], [TENLOAISP]) VALUES (10, N'Bìa hồ sơ')
GO
SET IDENTITY_INSERT [dbo].[LOAISP] OFF
GO
SET IDENTITY_INSERT [dbo].[NHACUNGCAP] ON 
GO
INSERT [dbo].[NHACUNGCAP] ([MANCC], [TENNCC], [SDT], [EMAIL], [DIACHI]) VALUES (1, N'VĂN PHÒNG PHẨM KHANG MINH', N'0944697678', N'tbvpkhangminh@gmail.com', N'70/16 Hiệp Nhất, Phường 4, Quận Tân Bình, TP. Hồ Chí Minh')
GO
INSERT [dbo].[NHACUNGCAP] ([MANCC], [TENNCC], [SDT], [EMAIL], [DIACHI]) VALUES (2, N'VĂN PHÒNG PHẨM ANH ĐỨC', N' 0983481825', N'nguyenanhtuanhcmvn@gmail.com', N'490/41 Lê Văn Sỹ, Phường 14, Quận 3, TP Hồ Chí Minh')
GO
INSERT [dbo].[NHACUNGCAP] ([MANCC], [TENNCC], [SDT], [EMAIL], [DIACHI]) VALUES (3, N'VĂN PHÒNG PHẨM 24', N'0985180684', N' minhanh@vanphongpham24.com', N'Số 218 Lô C5 Khu Đô Thị Đại Kim, Quận Hoàng Mai, TP Hà Nội')
GO
INSERT [dbo].[NHACUNGCAP] ([MANCC], [TENNCC], [SDT], [EMAIL], [DIACHI]) VALUES (4, N'VĂN PHÒNG PHẨM HÙNG THUẬN PHÁT', N'0908150636', N'htp@hungthuanphat.vn', N'104/3 Mai Thị Lựu, Phường Đa Kao, Quận 1, TP Hồ Chí Minh')
GO
INSERT [dbo].[NHACUNGCAP] ([MANCC], [TENNCC], [SDT], [EMAIL], [DIACHI]) VALUES (5, N'VĂN PHÒNG PHẨM KHANG LÊ', N'0935508693', N'vppkhangle@gmail.com', N'Số 60A, Đường Tam Đông 21, Xã Thới Tam Thôn, Huyện Hóc Môn, Tp Hồ Chí Minh')
GO
SET IDENTITY_INSERT [dbo].[NHACUNGCAP] OFF
GO
SET IDENTITY_INSERT [dbo].[NHANVIEN] ON 
GO
INSERT [dbo].[NHANVIEN] ([MANV], [TENNV], [GIOITINH], [DIACHI], [SDT], [CHUCVU], [TENDN], [MK]) VALUES (1, N'Nguyễn Thành Văn', N'Nam', N'TP.HCM', N'0383633081', 1, N'admin', N'123')
GO
INSERT [dbo].[NHANVIEN] ([MANV], [TENNV], [GIOITINH], [DIACHI], [SDT], [CHUCVU], [TENDN], [MK]) VALUES (2, N'Lư Quang Trực', N'Nam', N'TP.HCM', N'0123321223', 1, N'lqt', N'456')
GO
INSERT [dbo].[NHANVIEN] ([MANV], [TENNV], [GIOITINH], [DIACHI], [SDT], [CHUCVU], [TENDN], [MK]) VALUES (3, N'Nguyễn Hứa Hiền Vinh', N'Nam', N'TP.HCM', N'0883311233', 0, N'vinh', N'123')
GO
INSERT [dbo].[NHANVIEN] ([MANV], [TENNV], [GIOITINH], [DIACHI], [SDT], [CHUCVU], [TENDN], [MK]) VALUES (4, N'Trương Đình Văn', N'Nam', N'TP.HCM', N'0798889992', 0, N'uservan', N'123')
GO
INSERT [dbo].[NHANVIEN] ([MANV], [TENNV], [GIOITINH], [DIACHI], [SDT], [CHUCVU], [TENDN], [MK]) VALUES (5, N'Nguyễn Tuấn Kiệt', N'Nam', N'TP.HCM', N'0789632456', 0, N'userkiet', N'123')
GO
INSERT [dbo].[NHANVIEN] ([MANV], [TENNV], [GIOITINH], [DIACHI], [SDT], [CHUCVU], [TENDN], [MK]) VALUES (6, N'Lê Quang Tuấn', N'Nam', N'TPHCM', N'0792666144', 0, N'usertuan', N'123')
GO
INSERT [dbo].[NHANVIEN] ([MANV], [TENNV], [GIOITINH], [DIACHI], [SDT], [CHUCVU], [TENDN], [MK]) VALUES (7, N'Trần Khánh Ngọc', N'Nữ', N'TPHCM', N'0785568156', 0, N'userngoc', N'123')
GO
INSERT [dbo].[NHANVIEN] ([MANV], [TENNV], [GIOITINH], [DIACHI], [SDT], [CHUCVU], [TENDN], [MK]) VALUES (8, N'Nguyễn Nhật My', N'Nữ', N'TPHCM', N'0125325635', 0, N'usermy', N'123')
GO
INSERT [dbo].[NHANVIEN] ([MANV], [TENNV], [GIOITINH], [DIACHI], [SDT], [CHUCVU], [TENDN], [MK]) VALUES (9, N'Nguyễn Huỳnh Ngọc Thư ', N'Nữ', N'TPHCM', N'0987656565', 0, N'userthu', N'123')
GO
INSERT [dbo].[NHANVIEN] ([MANV], [TENNV], [GIOITINH], [DIACHI], [SDT], [CHUCVU], [TENDN], [MK]) VALUES (10, N'Bùi Thị Thu Linh', N'Nữ', N'TPHCM', N'0123876598', 0, N'userlinh', N'123')
GO
SET IDENTITY_INSERT [dbo].[NHANVIEN] OFF
GO
SET IDENTITY_INSERT [dbo].[PHIEUNHAP] ON 
GO
INSERT [dbo].[PHIEUNHAP] ([MAPN], [MANCC], [MANV], [NGAYLAP], [TONGTIEN]) VALUES (1, 4, 2, CAST(N'2022-06-07' AS Date), 0.0000)
GO
INSERT [dbo].[PHIEUNHAP] ([MAPN], [MANCC], [MANV], [NGAYLAP], [TONGTIEN]) VALUES (2, 3, 2, CAST(N'2022-06-07' AS Date), 0.0000)
GO
SET IDENTITY_INSERT [dbo].[PHIEUNHAP] OFF
GO
SET IDENTITY_INSERT [dbo].[SANPHAM] ON 
GO
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MALOAI], [DONGIA], [SOLUONGTON], [HINHANH]) VALUES (1, N'Bút chì bấm Pentel 05mm', 1, 55000.0000, 9, N'butchikimbam05mm.jpg')
GO
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MALOAI], [DONGIA], [SOLUONGTON], [HINHANH]) VALUES (2, N'Bút chì 24 màu', 1, 55000.0000, 12, N'butchi24mau.jpg')
GO
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MALOAI], [DONGIA], [SOLUONGTON], [HINHANH]) VALUES (3, N'Bút chì sáp 12 màu', 1, 75000.0000, 10, N'butchisap12mau.jpg')
GO
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MALOAI], [DONGIA], [SOLUONGTON], [HINHANH]) VALUES (4, N'Bút chì Koh I Noor 2B', 1, 8000.0000, 28, N'butchikohinoor2b.jpg')
GO
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MALOAI], [DONGIA], [SOLUONGTON], [HINHANH]) VALUES (5, N'Bút chì 12 màu', 1, 30000.0000, 12, N'butchi12mau.jpg')
GO
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MALOAI], [DONGIA], [SOLUONGTON], [HINHANH]) VALUES (6, N'Bút bi TL xanh', 1, 3500.0000, 50, N'butbitlxanh.jpg')
GO
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MALOAI], [DONGIA], [SOLUONGTON], [HINHANH]) VALUES (7, N'Bút bi TL đen', 1, 3500.0000, 50, N'butbitlden.jpg')
GO
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MALOAI], [DONGIA], [SOLUONGTON], [HINHANH]) VALUES (8, N'Bút bi Ấn Độ xanh', 1, 3000.0000, 50, N'butbiandoxanh.jpg')
GO
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MALOAI], [DONGIA], [SOLUONGTON], [HINHANH]) VALUES (9, N'Bút bi Ấn Độ đen', 1, 3000.0000, 50, N'butbiandoden.jpg')
GO
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MALOAI], [DONGIA], [SOLUONGTON], [HINHANH]) VALUES (10, N'Bút bi Uniball Laknock đỏ', 2, 25000.0000, 80, N'butbiuniballlaknockdo.jpg')
GO
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MALOAI], [DONGIA], [SOLUONGTON], [HINHANH]) VALUES (11, N'Tập Thuận Tiến 100 trang', 2, 10000.0000, 197, N'tapthuantien100trang.jpg')
GO
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MALOAI], [DONGIA], [SOLUONGTON], [HINHANH]) VALUES (12, N'Vinabook 100 trang', 2, 10000.0000, 220, N'vinabook100trang.jpg')
GO
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MALOAI], [DONGIA], [SOLUONGTON], [HINHANH]) VALUES (13, N'Vinabook 200 trang', 2, 15000.0000, 250, N'vinabook200trang.jpg')
GO
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MALOAI], [DONGIA], [SOLUONGTON], [HINHANH]) VALUES (14, N'Sổ da Viaone', 2, 70000.0000, 65, N'sodaviaone.jpg')
GO
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MALOAI], [DONGIA], [SOLUONGTON], [HINHANH]) VALUES (15, N'Sổ lò xo Lax A4', 2, 38000.0000, 109, N'soloxolaxa4.jpg')
GO
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MALOAI], [DONGIA], [SOLUONGTON], [HINHANH]) VALUES (16, N'Casio FX-570VN', 3, 485000.0000, 65, N'casiofx570vn.jpg')
GO
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MALOAI], [DONGIA], [SOLUONGTON], [HINHANH]) VALUES (17, N'Casio FX-500MS', 3, 280000.0000, 48, N'casiofx500ms.jpg')
GO
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MALOAI], [DONGIA], [SOLUONGTON], [HINHANH]) VALUES (18, N'Vinacal 570-ESPlus', 3, 420000.0000, 32, N'vinacal570esplus.jpg')
GO
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MALOAI], [DONGIA], [SOLUONGTON], [HINHANH]) VALUES (19, N'Bảng trắng 0.6x0.4', 4, 70000.0000, 25, N'bangtran06x04.jpg')
GO
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MALOAI], [DONGIA], [SOLUONGTON], [HINHANH]) VALUES (20, N'Bảng nhung 0.6x0.4', 4, 120000.0000, 19, N'bangnhung06x04.jpg')
GO
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MALOAI], [DONGIA], [SOLUONGTON], [HINHANH]) VALUES (21, N'Phấn trắng', 5, 7000.0000, 180, N'phantrang.jpg')
GO
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MALOAI], [DONGIA], [SOLUONGTON], [HINHANH]) VALUES (22, N'Phấn màu', 5, 7000.0000, 130, N'phanmau.jpg')
GO
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MALOAI], [DONGIA], [SOLUONGTON], [HINHANH]) VALUES (23, N'Khăn lau bảng', 6, 7000.0000, 100, N'khanlaubang.jpg')
GO
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MALOAI], [DONGIA], [SOLUONGTON], [HINHANH]) VALUES (24, N'Mút xốp lau bảng', 6, 5000.0000, 100, N'mutxoplaubang.jpg')
GO
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MALOAI], [DONGIA], [SOLUONGTON], [HINHANH]) VALUES (25, N'Lau bảng xukiva', 6, 12000.0000, 97, N'laubangxukiva.jpg')
GO
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MALOAI], [DONGIA], [SOLUONGTON], [HINHANH]) VALUES (26, N'Bấm kim Kanex HD10 - 10 tờ', 7, 20000.0000, 32, N'bamkim10to.jpg')
GO
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MALOAI], [DONGIA], [SOLUONGTON], [HINHANH]) VALUES (27, N'Bấm kim Kwtrio 5003 - 240 tờ', 7, 550000.0000, 12, N'bamkim240to.jpg')
GO
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MALOAI], [DONGIA], [SOLUONGTON], [HINHANH]) VALUES (28, N'Thước dẻo WinQ 30cm', 8, 5000.0000, 95, N'thuocdeo30cm.jpg')
GO
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MALOAI], [DONGIA], [SOLUONGTON], [HINHANH]) VALUES (29, N'Thước êke', 8, 5000.0000, 88, N'thuoceke.jpg')
GO
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MALOAI], [DONGIA], [SOLUONGTON], [HINHANH]) VALUES (30, N'Thước đo độ', 8, 5000.0000, 56, N'thuocdodo.jpg')
GO
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MALOAI], [DONGIA], [SOLUONGTON], [HINHANH]) VALUES (31, N'Thước Parabol WinQ QL-01', 8, 4000.0000, 120, N'thuocparabol.jpg')
GO
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MALOAI], [DONGIA], [SOLUONGTON], [HINHANH]) VALUES (32, N'Thước vẽ kỹ thuật, Template Ruler C-2007', 8, 27000.0000, 100, N'thuocvekythuat.jpg')
GO
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MALOAI], [DONGIA], [SOLUONGTON], [HINHANH]) VALUES (33, N'Kéo văn phòng Stacom F102 - 180mm', 9, 25000.0000, 220, N'keovanphong.jpg')
GO
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MALOAI], [DONGIA], [SOLUONGTON], [HINHANH]) VALUES (34, N'Dao rọc giấy mini M&G 2243 hình củ cà rốt', 9, 14000.0000, 188, N'daorocgiaycarot.jpg')
GO
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MALOAI], [DONGIA], [SOLUONGTON], [HINHANH]) VALUES (35, N'Dao rọc giấy mini M&G 2281', 9, 12000.0000, 90, N'daorocmini.jpg')
GO
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MALOAI], [DONGIA], [SOLUONGTON], [HINHANH]) VALUES (36, N'Kéo nhỏ M&G 2229', 9, 12000.0000, 70, N'keonho_mg2229.jpg')
GO
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MALOAI], [DONGIA], [SOLUONGTON], [HINHANH]) VALUES (37, N'Bìa còng KING JIM khổ F4 - 7F', 10, 50000.0000, 40, N'biacongkingjimf4_7f.jpg')
GO
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MALOAI], [DONGIA], [SOLUONGTON], [HINHANH]) VALUES (38, N'Bìa cây A4 gáy lớn', 10, 6000.0000, 100, N'biacaya4gaylon.jpg')
GO
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MALOAI], [DONGIA], [SOLUONGTON], [HINHANH]) VALUES (39, N'Bìa cây A4 gáy nhỏ', 10, 4000.0000, 100, N'biacaya4gaynho.jpg')
GO
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MALOAI], [DONGIA], [SOLUONGTON], [HINHANH]) VALUES (40, N'Bìa nút khổ A5 không chữ', 10, 2500.0000, 200, N'bianutkhoa5khongchu.jpg')
GO
INSERT [dbo].[SANPHAM] ([MASP], [TENSP], [MALOAI], [DONGIA], [SOLUONGTON], [HINHANH]) VALUES (42, N'Viết Xóa', 1, 0.0000, 50, N'NULL')
GO
SET IDENTITY_INSERT [dbo].[SANPHAM] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__NHANVIEN__A58D7781C9EC203E]    Script Date: 07/06/2022 7:49:20 PM ******/
ALTER TABLE [dbo].[NHANVIEN] ADD UNIQUE NONCLUSTERED 
(
	[TENDN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CHITIETHD]  WITH CHECK ADD  CONSTRAINT [FK_CHIIETHD_HOADON] FOREIGN KEY([MAHD])
REFERENCES [dbo].[HOADON] ([MAHD])
GO
ALTER TABLE [dbo].[CHITIETHD] CHECK CONSTRAINT [FK_CHIIETHD_HOADON]
GO
ALTER TABLE [dbo].[CHITIETHD]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETHD_SANPHAM] FOREIGN KEY([MASP])
REFERENCES [dbo].[SANPHAM] ([MASP])
GO
ALTER TABLE [dbo].[CHITIETHD] CHECK CONSTRAINT [FK_CHITIETHD_SANPHAM]
GO
ALTER TABLE [dbo].[CHITIETPHIEUNHAP]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUNHAP_CTPN] FOREIGN KEY([MAPN])
REFERENCES [dbo].[PHIEUNHAP] ([MAPN])
GO
ALTER TABLE [dbo].[CHITIETPHIEUNHAP] CHECK CONSTRAINT [FK_PHIEUNHAP_CTPN]
GO
ALTER TABLE [dbo].[CHITIETPHIEUNHAP]  WITH CHECK ADD  CONSTRAINT [FK_SP_CTPN] FOREIGN KEY([MASP])
REFERENCES [dbo].[SANPHAM] ([MASP])
GO
ALTER TABLE [dbo].[CHITIETPHIEUNHAP] CHECK CONSTRAINT [FK_SP_CTPN]
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [FK_HOADON_KHACHHANG] FOREIGN KEY([MAKH])
REFERENCES [dbo].[KHACHHANG] ([MAKH])
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [FK_HOADON_KHACHHANG]
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [FK_HOADON_NHANVIEN] FOREIGN KEY([MANV])
REFERENCES [dbo].[NHANVIEN] ([MANV])
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [FK_HOADON_NHANVIEN]
GO
ALTER TABLE [dbo].[PHIEUNHAP]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUNHAP_NHACUNGCAP] FOREIGN KEY([MANCC])
REFERENCES [dbo].[NHACUNGCAP] ([MANCC])
GO
ALTER TABLE [dbo].[PHIEUNHAP] CHECK CONSTRAINT [FK_PHIEUNHAP_NHACUNGCAP]
GO
ALTER TABLE [dbo].[PHIEUNHAP]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUNHAP_NHANVIEN] FOREIGN KEY([MANV])
REFERENCES [dbo].[NHANVIEN] ([MANV])
GO
ALTER TABLE [dbo].[PHIEUNHAP] CHECK CONSTRAINT [FK_PHIEUNHAP_NHANVIEN]
GO
ALTER TABLE [dbo].[SANPHAM]  WITH CHECK ADD  CONSTRAINT [FK_LOAI_SANPHAM] FOREIGN KEY([MALOAI])
REFERENCES [dbo].[LOAISP] ([MALOAISP])
GO
ALTER TABLE [dbo].[SANPHAM] CHECK CONSTRAINT [FK_LOAI_SANPHAM]
GO
USE [master]
GO
ALTER DATABASE [QUANLY_VPP] SET  READ_WRITE 
GO
