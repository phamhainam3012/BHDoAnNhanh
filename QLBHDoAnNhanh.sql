USE [QLQCOFE2]
GO
/****** Object:  Table [dbo].[BAN]    Script Date: 21/10/2020 2:26:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BAN](
	[IDBAN] [nvarchar](100) NOT NULL,
	[TENBAN] [nvarchar](100) NOT NULL,
	[TRANGTHAIBAN] [nvarchar](100) NOT NULL,
 CONSTRAINT [pk_ban] PRIMARY KEY CLUSTERED 
(
	[IDBAN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DANHMUC]    Script Date: 21/10/2020 2:26:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DANHMUC](
	[IDDANHMUC] [nvarchar](100) NOT NULL,
	[TENDANHMUC] [nvarchar](100) NOT NULL,
 CONSTRAINT [pk_DANHMUC] PRIMARY KEY CLUSTERED 
(
	[IDDANHMUC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HOADON]    Script Date: 21/10/2020 2:26:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOADON](
	[IDHOADON] [nvarchar](100) NOT NULL,
	[IDBAN] [nvarchar](100) NOT NULL,
	[THOIGIANTOI] [date] NULL,
	[THOIGIANDI] [date] NULL,
 CONSTRAINT [pk_hoadon] PRIMARY KEY CLUSTERED 
(
	[IDHOADON] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MONAN]    Script Date: 21/10/2020 2:26:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MONAN](
	[IDMON] [nvarchar](100) NOT NULL,
	[TENMON] [nvarchar](100) NOT NULL,
	[GIATIEN] [money] NULL,
	[ANH] [image] NULL,
 CONSTRAINT [pk_monan] PRIMARY KEY CLUSTERED 
(
	[IDMON] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [FK_HOADON_BAN] FOREIGN KEY([IDBAN])
REFERENCES [dbo].[BAN] ([IDBAN])
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [FK_HOADON_BAN]
GO
/****** Object:  StoredProcedure [dbo].[DeleteBAN]    Script Date: 21/10/2020 2:26:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DeleteBAN]
@IDBAN NVARCHAR(100) ,
@TENBAN NVARCHAR(100) ,
@TRANGTHAIBAN NVARCHAR(100)
as
begin 
delete dbo.BAN
where  IDBAN=@IDBAN;
end

GO
/****** Object:  StoredProcedure [dbo].[DeleteDANHMUC]    Script Date: 21/10/2020 2:26:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DeleteDANHMUC]
@IDDANHMUC NVARCHAR(100) ,
@TENDANHMUC NVARCHAR(100) 
as
begin 
delete dbo.DANHMUC
where  IDDANHMUC=@IDDANHMUC;
end


GO
/****** Object:  StoredProcedure [dbo].[DeleteHOADON]    Script Date: 21/10/2020 2:26:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DeleteHOADON]
@IDHOADON NVARCHAR(100)
as
begin 
delete dbo.HOADON
where IDHOADON=@IDHOADON;
end

GO
/****** Object:  StoredProcedure [dbo].[DeleteMONAN]    Script Date: 21/10/2020 2:26:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DeleteMONAN]
@IDMON NVARCHAR(100)
as
begin 
delete dbo.MONAN
where IDMON=@IDMON;
end


GO
/****** Object:  StoredProcedure [dbo].[GetBAN]    Script Date: 21/10/2020 2:26:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GetBAN]
AS
BEGIN
SELECT IDBAN N'Mã Bàn', TENBAN N'Tên Bàn', TRANGTHAIBAN N'Trạng Thái Bàn' from dbo.BAN
END

GO
/****** Object:  StoredProcedure [dbo].[GetDANHMUC]    Script Date: 21/10/2020 2:26:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GetDANHMUC]
AS
BEGIN 
SELECT IDDANHMUC N'Mã Danh Mục', TENDANHMUC N'Tên Danh Mục' from dbo.DANHMUC
END

GO
/****** Object:  StoredProcedure [dbo].[GetHOADON]    Script Date: 21/10/2020 2:26:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GetHOADON]
AS
BEGIN
SELECT IDHOADON N'Mã Hóa Đơn', IDBAN N'Mã BÀN', THOIGIANTOI N'Thời Gian Tới', THOIGIANDI N'Thời Gian Đi' from dbo.HOADON
END
GO
/****** Object:  StoredProcedure [dbo].[GetMONAN]    Script Date: 21/10/2020 2:26:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[GetMONAN]
AS
BEGIN
SELECT IDMON N'Mã Món', TENMON N'Tên Món', GIATIEN N'Giá Tiền', ANH N'Ảnh'from dbo.MONAN
END

GO
/****** Object:  StoredProcedure [dbo].[InserDANHMUC]    Script Date: 21/10/2020 2:26:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[InserDANHMUC]
@IDDANHMUC Nvarchar(100) ,
@TENDANHMUC Nvarchar(100) 
as
begin 
insert dbo.DANHMUC
(IDDANHMUC,TENDANHMUC)
values (@IDDANHMUC, @TENDANHMUC)
end

GO
/****** Object:  StoredProcedure [dbo].[InsertBAN]    Script Date: 21/10/2020 2:26:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[InsertBAN]
@IDBAN Nvarchar(100) ,
@TENBAN Nvarchar(100) ,
@TRANGTHAIBAN Nvarchar(100)
as
begin 
insert dbo.BAN
(IDBAN,TENBAN,TRANGTHAIBAN)
values (@IDBAN, @TENBAN, @TRANGTHAIBAN)
end

GO
/****** Object:  StoredProcedure [dbo].[InsertHOADON]    Script Date: 21/10/2020 2:26:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[InsertHOADON]
@IDHOADON Nvarchar(100) ,
@IDBAN Nvarchar(100) ,
@THOIGIANTOI DATE  ,
@THOIGIANDI DATE 

as
begin 
insert dbo.HOADON
(IDHOADON,IDBAN,THOIGIANTOI,THOIGIANDI)
values (@IDHOADON, @IDBAN, @THOIGIANTOI, @THOIGIANDI) 
end

GO
/****** Object:  StoredProcedure [dbo].[InsertMONAN]    Script Date: 21/10/2020 2:26:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[InsertMONAN]
@IDMON Nvarchar(100) ,
@TENMON Nvarchar(100) ,
@GIATIEN money,
@ANH image
as
begin 
insert dbo.MONAN
(IDMON,TENMON,GIATIEN,ANH)
values (@IDMON, @TENMON, @GIATIEN, @ANH)
end

GO
/****** Object:  StoredProcedure [dbo].[SearchMONAN]    Script Date: 21/10/2020 2:26:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SearchMONAN]
	@IDMON NVARCHAR (100)
AS
BEGIN
	select IDMON N'ID Món' ,
	       TENMON N'Tên Món',
		    GIATIEN N'Giá Tiền' ,
			 ANH N'Ảnh'
			 from MONAN where IDMON like  @IDMON
END

GO
/****** Object:  StoredProcedure [dbo].[UpdateBAN]    Script Date: 21/10/2020 2:26:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[UpdateBAN]
@IDBAN NVARCHAR(100) ,
@TENBAN NVARCHAR(100) ,
@TRANGTHAIBAN NVARCHAR(100)
as
begin 
update dbo.BAN set TENBAN=@TENBAN, TRANGTHAIBAN=@TRANGTHAIBAN where IDBAN=@IDBAN;
END

GO
/****** Object:  StoredProcedure [dbo].[UpdateDANHMUC]    Script Date: 21/10/2020 2:26:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[UpdateDANHMUC]
@IDDANHMUC NVARCHAR(100) ,
@TENDANHMUC NVARCHAR(100) 
as
begin 
update dbo.DANHMUC set TENDANHMUC=@TENDANHMUC where IDDANHMUC=@IDDANHMUC;
END

GO
/****** Object:  StoredProcedure [dbo].[UpdateHOADON]    Script Date: 21/10/2020 2:26:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[UpdateHOADON]
@IDHOADON NVARCHAR(100) ,
@IDBAN NVARCHAR(100) ,
@THOIGIANTOI DATE ,
@THOIGIANDI DATE 

as
begin 
update dbo.HOADON set IDBAN=@IDBAN, THOIGIANTOI=@THOIGIANTOI, THOIGIANDI=@THOIGIANDI 
where IDHOADON=@IDHOADON;
END

GO
/****** Object:  StoredProcedure [dbo].[UpdateMONAN]    Script Date: 21/10/2020 2:26:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[UpdateMONAN]
@IDMON NVARCHAR(100) ,
@TENMON NVARCHAR(100) ,
@GIATIEN money,
@ANH image
as
begin 
update dbo.MONAN set TENMON=@TENMON, GIATIEN=@GIATIEN , ANH=@ANH where IDMON=@IDMON;
END

GO
