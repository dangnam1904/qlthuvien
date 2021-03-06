USE [thuvien]
GO
/****** Object:  Table [dbo].[LoaiSach]    Script Date: 2/12/2022 11:36:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiSach](
	[MaLoaiSach] [nchar](10) NOT NULL,
	[TenLoai] [nvarchar](100) NULL,
	[KieuSach] [nchar](10) NULL,
 CONSTRAINT [PK_LoaiSach] PRIMARY KEY CLUSTERED 
(
	[MaLoaiSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MuonSach]    Script Date: 2/12/2022 11:36:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MuonSach](
	[MaMuon] [nchar](10) NOT NULL,
	[MaDG] [nchar](10) NULL,
	[MaSach] [nchar](10) NULL,
	[SoLuongMuon] [int] NULL,
	[NgayMuon] [date] NULL,
	[NgayHenTra] [date] NULL,
 CONSTRAINT [PK_Muónach] PRIMARY KEY CLUSTERED 
(
	[MaMuon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NguoiMuon]    Script Date: 2/12/2022 11:36:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NguoiMuon](
	[MaDG] [nchar](10) NOT NULL,
	[TenDG] [nvarchar](40) NULL,
	[NgaySinh] [date] NULL,
	[GioiTinh] [nvarchar](7) NULL,
	[Sdt] [nchar](15) NULL,
	[DiaChi] [nvarchar](200) NULL,
 CONSTRAINT [PK_NguoiMuon] PRIMARY KEY CLUSTERED 
(
	[MaDG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sach]    Script Date: 2/12/2022 11:36:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sach](
	[MaSach] [nchar](10) NOT NULL,
	[TenSach] [nvarchar](255) NULL,
	[Mota] [text] NULL,
	[MaLoaiSach] [nchar](10) NULL,
	[SoLuong] [int] NULL,
	[SoLuongChoMuon] [int] NULL,
	[MaTG] [nchar](10) NULL,
 CONSTRAINT [PK_Sach] PRIMARY KEY CLUSTERED 
(
	[MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TacGia]    Script Date: 2/12/2022 11:36:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TacGia](
	[MaTG] [nchar](10) NOT NULL,
	[TenTG] [nvarchar](50) NULL,
	[TomTatThongTin] [ntext] NULL,
 CONSTRAINT [PK_TacGia] PRIMARY KEY CLUSTERED 
(
	[MaTG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TraSach]    Script Date: 2/12/2022 11:36:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TraSach](
	[MaTraSach] [nchar](10) NOT NULL,
	[MaDG] [nchar](10) NULL,
	[MaSach] [nchar](10) NULL,
	[SoLuongTra] [int] NULL,
	[NgayTra] [date] NULL,
	[MaMuon] [nchar](10) NULL,
 CONSTRAINT [PK_Trấch] PRIMARY KEY CLUSTERED 
(
	[MaTraSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[MuonSach]  WITH CHECK ADD  CONSTRAINT [FK_MuonSach_NguoiMuon] FOREIGN KEY([MaDG])
REFERENCES [dbo].[NguoiMuon] ([MaDG])
GO
ALTER TABLE [dbo].[MuonSach] CHECK CONSTRAINT [FK_MuonSach_NguoiMuon]
GO
ALTER TABLE [dbo].[MuonSach]  WITH CHECK ADD  CONSTRAINT [FK_MuonSach_Sach] FOREIGN KEY([MaSach])
REFERENCES [dbo].[Sach] ([MaSach])
GO
ALTER TABLE [dbo].[MuonSach] CHECK CONSTRAINT [FK_MuonSach_Sach]
GO
ALTER TABLE [dbo].[Sach]  WITH CHECK ADD  CONSTRAINT [FK_Sach_LoaiSach] FOREIGN KEY([MaLoaiSach])
REFERENCES [dbo].[LoaiSach] ([MaLoaiSach])
GO
ALTER TABLE [dbo].[Sach] CHECK CONSTRAINT [FK_Sach_LoaiSach]
GO
ALTER TABLE [dbo].[Sach]  WITH CHECK ADD  CONSTRAINT [FK_Sach_TacGia] FOREIGN KEY([MaTG])
REFERENCES [dbo].[TacGia] ([MaTG])
GO
ALTER TABLE [dbo].[Sach] CHECK CONSTRAINT [FK_Sach_TacGia]
GO
ALTER TABLE [dbo].[TraSach]  WITH CHECK ADD  CONSTRAINT [FK_TraSach_MuonSach] FOREIGN KEY([MaMuon])
REFERENCES [dbo].[MuonSach] ([MaMuon])
GO
ALTER TABLE [dbo].[TraSach] CHECK CONSTRAINT [FK_TraSach_MuonSach]
GO
ALTER TABLE [dbo].[TraSach]  WITH CHECK ADD  CONSTRAINT [FK_TraSach_NguoiMuon] FOREIGN KEY([MaDG])
REFERENCES [dbo].[NguoiMuon] ([MaDG])
GO
ALTER TABLE [dbo].[TraSach] CHECK CONSTRAINT [FK_TraSach_NguoiMuon]
GO
ALTER TABLE [dbo].[TraSach]  WITH CHECK ADD  CONSTRAINT [FK_TraSach_Sach] FOREIGN KEY([MaSach])
REFERENCES [dbo].[Sach] ([MaSach])
GO
ALTER TABLE [dbo].[TraSach] CHECK CONSTRAINT [FK_TraSach_Sach]
GO
