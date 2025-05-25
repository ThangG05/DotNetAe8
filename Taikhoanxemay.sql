GO
/****** Object:  Table [dbo].[Acc]    Script Date: 02/05/2025 14:27:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Acc](
	[Ten] [char](30) NOT NULL,
	[Mk] [char](30) NULL,
	[Email] [char](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[Ten] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[Acc] ([Ten], [Mk], [Email]) VALUES (N'12314                         ', N'211                           ', N'khongco@gmail.com             ')
INSERT [dbo].[Acc] ([Ten], [Mk], [Email]) VALUES (N'Khiem                         ', N'123                           ', N'khiemhg0709@gmail.com         ')
INSERT [dbo].[Acc] ([Ten], [Mk], [Email]) VALUES (N'NguyenThang                   ', N'1221                          ', N'nguyenmanhthang2k5@gmail.com  ')
INSERT [dbo].[Acc] ([Ten], [Mk], [Email]) VALUES (N'quangduy                      ', N'1111                          ', N'nquangduy2005@gmail.com       ')
INSERT [dbo].[Acc] ([Ten], [Mk], [Email]) VALUES (N'Thang                         ', N'123312414                     ', N'thang@hvnh@gamil.com          ')
INSERT [dbo].[Acc] ([Ten], [Mk], [Email]) VALUES (N'ThangHimas                    ', N'1121                          ', N'26a4041668@hvnh.edu.vn        ')
INSERT [dbo].[Acc] ([Ten], [Mk], [Email]) VALUES (N'ThangNguyen                   ', N'1234                          ', N'khiemhg0709@gmail.com         ')

