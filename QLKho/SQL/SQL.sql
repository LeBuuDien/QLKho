USE [QL_Kho]
GO
/****** Object:  Table [dbo].[DonHang]    Script Date: 7/28/2022 1:49:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DonHang](
	[MaVanDon] [nchar](20) NOT NULL,
	[TenNguoiGui] [nvarchar](50) NULL,
	[DiaChiGui] [nvarchar](160) NOT NULL,
	[DiaChiNhan] [nvarchar](160) NOT NULL,
	[TrongLuong] [float] NOT NULL,
	[ChieuDai] [int] NULL,
	[ChieuRong] [int] NULL,
	[ChieuCao] [int] NULL,
 CONSTRAINT [PK_DonHang] PRIMARY KEY CLUSTERED 
(
	[MaVanDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[DonHang] ([MaVanDon], [TenNguoiGui], [DiaChiGui], [DiaChiNhan], [TrongLuong], [ChieuDai], [ChieuRong], [ChieuCao]) VALUES (N'IOUHSDF             ', N'Người nhận 2', N'Địa chỉ gửi 1', N'Địa chỉ nhận 1', 2, 1, 4, 6)
INSERT [dbo].[DonHang] ([MaVanDon], [TenNguoiGui], [DiaChiGui], [DiaChiNhan], [TrongLuong], [ChieuDai], [ChieuRong], [ChieuCao]) VALUES (N'KLJGFSDKLF          ', N'Người nhận 1', N'Địa chỉ 1', N'Địa chỉ 2', 2, 2, 2, 1)
GO
