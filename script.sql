USE [Kütüphane Otomasyonu]
GO
/****** Object:  Table [dbo].[Kayıtlar]    Script Date: 31.10.2021 20:33:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kayıtlar](
	[kayit_id] [int] IDENTITY(1,1) NOT NULL,
	[kullanici_id] [int] NOT NULL,
	[kitap_id] [int] NOT NULL,
	[alis_tarihi] [datetime] NOT NULL,
	[son_teslim_tarihi] [datetime] NOT NULL,
	[durum] [bit] NOT NULL,
 CONSTRAINT [PK_Kayıtlar] PRIMARY KEY CLUSTERED 
(
	[kayit_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Kaynaklar]    Script Date: 31.10.2021 20:33:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kaynaklar](
	[kaynak_id] [int] IDENTITY(1,1) NOT NULL,
	[kaynak_ad] [nvarchar](50) NOT NULL,
	[kaynak_yazar] [nvarchar](50) NULL,
	[kaynak_yayinci] [nvarchar](50) NULL,
	[kaynak_sayfasayisi] [int] NULL,
	[kaynak_basimtarihi] [datetime] NULL,
 CONSTRAINT [PK_Kaynaklar] PRIMARY KEY CLUSTERED 
(
	[kaynak_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Kullanıcılar]    Script Date: 31.10.2021 20:33:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kullanıcılar](
	[kullanici_id] [int] IDENTITY(1,1) NOT NULL,
	[kullanici_ad] [nvarchar](30) NOT NULL,
	[kullanici_soyad] [nvarchar](30) NOT NULL,
	[kullanici_tc] [nvarchar](11) NOT NULL,
	[kullanici_mail] [nvarchar](50) NULL,
	[kullanici_tel] [nvarchar](11) NULL,
 CONSTRAINT [PK_Kullanıcılar] PRIMARY KEY CLUSTERED 
(
	[kullanici_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Personeller]    Script Date: 31.10.2021 20:33:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Personeller](
	[personel_id] [int] IDENTITY(1,1) NOT NULL,
	[personel_ad] [nvarchar](30) NOT NULL,
	[personel_soyad] [nvarchar](30) NOT NULL,
	[personel_tc] [nvarchar](11) NOT NULL,
	[personel_tel] [nvarchar](11) NULL,
	[personel_mail] [nvarchar](50) NULL,
	[personel_kullaniciad] [nvarchar](50) NOT NULL,
	[personel_sifre] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Personeller] PRIMARY KEY CLUSTERED 
(
	[personel_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Kayıtlar] ON 

INSERT [dbo].[Kayıtlar] ([kayit_id], [kullanici_id], [kitap_id], [alis_tarihi], [son_teslim_tarihi], [durum]) VALUES (1, 1, 1, CAST(N'2021-10-09 00:00:00.000' AS DateTime), CAST(N'2021-10-10 00:00:00.000' AS DateTime), 0)
INSERT [dbo].[Kayıtlar] ([kayit_id], [kullanici_id], [kitap_id], [alis_tarihi], [son_teslim_tarihi], [durum]) VALUES (24, 8, 5, CAST(N'2021-10-31 00:00:00.000' AS DateTime), CAST(N'2021-11-20 00:00:00.000' AS DateTime), 0)
INSERT [dbo].[Kayıtlar] ([kayit_id], [kullanici_id], [kitap_id], [alis_tarihi], [son_teslim_tarihi], [durum]) VALUES (25, 23, 20, CAST(N'2021-10-31 00:00:00.000' AS DateTime), CAST(N'2021-11-20 00:00:00.000' AS DateTime), 0)
INSERT [dbo].[Kayıtlar] ([kayit_id], [kullanici_id], [kitap_id], [alis_tarihi], [son_teslim_tarihi], [durum]) VALUES (26, 7, 4, CAST(N'2021-10-31 00:00:00.000' AS DateTime), CAST(N'2021-11-20 00:00:00.000' AS DateTime), 0)
SET IDENTITY_INSERT [dbo].[Kayıtlar] OFF
SET IDENTITY_INSERT [dbo].[Kaynaklar] ON 

INSERT [dbo].[Kaynaklar] ([kaynak_id], [kaynak_ad], [kaynak_yazar], [kaynak_yayinci], [kaynak_sayfasayisi], [kaynak_basimtarihi]) VALUES (1, N'Hayvan Çiftliği', N'George Orwell', N'Alfa Yayınları', 112, CAST(N'1945-09-17 12:23:46.000' AS DateTime))
INSERT [dbo].[Kaynaklar] ([kaynak_id], [kaynak_ad], [kaynak_yazar], [kaynak_yayinci], [kaynak_sayfasayisi], [kaynak_basimtarihi]) VALUES (3, N'Beyaz Diş', N'Jack London', N'Favori Yayınları', 175, CAST(N'1906-05-18 12:23:46.000' AS DateTime))
INSERT [dbo].[Kaynaklar] ([kaynak_id], [kaynak_ad], [kaynak_yazar], [kaynak_yayinci], [kaynak_sayfasayisi], [kaynak_basimtarihi]) VALUES (4, N'Homo Deus', N'Yuval Noah Harari', N'Nesil Yayınları', 448, CAST(N'2015-03-22 12:23:46.000' AS DateTime))
INSERT [dbo].[Kaynaklar] ([kaynak_id], [kaynak_ad], [kaynak_yazar], [kaynak_yayinci], [kaynak_sayfasayisi], [kaynak_basimtarihi]) VALUES (5, N'Bilinmeyen Bir Kadının Mektubu', N'Stefan Zweig', N'Islık Yayınları', 68, CAST(N'1922-10-15 12:23:46.000' AS DateTime))
INSERT [dbo].[Kaynaklar] ([kaynak_id], [kaynak_ad], [kaynak_yazar], [kaynak_yayinci], [kaynak_sayfasayisi], [kaynak_basimtarihi]) VALUES (11, N'Yabancı', N'Stephen King', N'Dorlion Yayınevi', 560, CAST(N'2018-05-28 18:31:04.000' AS DateTime))
INSERT [dbo].[Kaynaklar] ([kaynak_id], [kaynak_ad], [kaynak_yazar], [kaynak_yayinci], [kaynak_sayfasayisi], [kaynak_basimtarihi]) VALUES (13, N'Çalıkuşu', N'Reşat Nuri Güntekin', N'Fecr Yayınları', 409, CAST(N'1922-01-08 00:00:00.000' AS DateTime))
INSERT [dbo].[Kaynaklar] ([kaynak_id], [kaynak_ad], [kaynak_yazar], [kaynak_yayinci], [kaynak_sayfasayisi], [kaynak_basimtarihi]) VALUES (14, N'Dede Korkut Kitabı', N'Anonim', N'Doğan Kitap', 238, CAST(N'1974-04-12 00:00:00.000' AS DateTime))
INSERT [dbo].[Kaynaklar] ([kaynak_id], [kaynak_ad], [kaynak_yazar], [kaynak_yayinci], [kaynak_sayfasayisi], [kaynak_basimtarihi]) VALUES (15, N'Araba Sevdası', N'Recaizade Mahmud Ekrem', N'Altın Kitaplar', 272, CAST(N'1898-11-20 00:00:00.000' AS DateTime))
INSERT [dbo].[Kaynaklar] ([kaynak_id], [kaynak_ad], [kaynak_yazar], [kaynak_yayinci], [kaynak_sayfasayisi], [kaynak_basimtarihi]) VALUES (16, N'Kiralık Konak', N'Yakup Kadri Karaosmanoğlu', N'Akademisyen Kitap', 232, CAST(N'1922-06-16 00:00:00.000' AS DateTime))
INSERT [dbo].[Kaynaklar] ([kaynak_id], [kaynak_ad], [kaynak_yazar], [kaynak_yayinci], [kaynak_sayfasayisi], [kaynak_basimtarihi]) VALUES (17, N'İntibah', N'Namık Kemal', N'Beyan Yayınları', 175, CAST(N'1874-05-23 00:00:00.000' AS DateTime))
INSERT [dbo].[Kaynaklar] ([kaynak_id], [kaynak_ad], [kaynak_yazar], [kaynak_yayinci], [kaynak_sayfasayisi], [kaynak_basimtarihi]) VALUES (18, N'Puslu Kıtalar Atlası', N'İhsan Oktay Anar', N'Can Yayınları', 238, CAST(N'1995-01-24 00:00:00.000' AS DateTime))
INSERT [dbo].[Kaynaklar] ([kaynak_id], [kaynak_ad], [kaynak_yazar], [kaynak_yayinci], [kaynak_sayfasayisi], [kaynak_basimtarihi]) VALUES (20, N'Nutuk', N'Mustafa Kemal Atatürk', N'Çilek Kitaplar', 599, CAST(N'1927-03-12 00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[Kaynaklar] OFF
SET IDENTITY_INSERT [dbo].[Kullanıcılar] ON 

INSERT [dbo].[Kullanıcılar] ([kullanici_id], [kullanici_ad], [kullanici_soyad], [kullanici_tc], [kullanici_mail], [kullanici_tel]) VALUES (1, N'Ahmet', N'Çakmak', N'12345678910', N'ahmetcakmak@gmail.com', N'59876532145')
INSERT [dbo].[Kullanıcılar] ([kullanici_id], [kullanici_ad], [kullanici_soyad], [kullanici_tc], [kullanici_mail], [kullanici_tel]) VALUES (5, N'Deniz', N'Taş', N'26441387263', N'deniztas@gmail.com', N'58836104796')
INSERT [dbo].[Kullanıcılar] ([kullanici_id], [kullanici_ad], [kullanici_soyad], [kullanici_tc], [kullanici_mail], [kullanici_tel]) VALUES (7, N'Beytullah', N'Toprak', N'27963458899', N'beyto@gmail.com', N'56896387596')
INSERT [dbo].[Kullanıcılar] ([kullanici_id], [kullanici_ad], [kullanici_soyad], [kullanici_tc], [kullanici_mail], [kullanici_tel]) VALUES (8, N'Ubeyt', N'Bütün', N'123', N'ubeytbutun@gmail.com', N'56679334598')
INSERT [dbo].[Kullanıcılar] ([kullanici_id], [kullanici_ad], [kullanici_soyad], [kullanici_tc], [kullanici_mail], [kullanici_tel]) VALUES (10, N'Ali', N'Veli', N'15687965235', N'aliveli@gmail.com', N'58769332568')
INSERT [dbo].[Kullanıcılar] ([kullanici_id], [kullanici_ad], [kullanici_soyad], [kullanici_tc], [kullanici_mail], [kullanici_tel]) VALUES (11, N'Ayşe', N'Demir', N'38996344289', N'aysedemir@gmail.com', N'52299625876')
INSERT [dbo].[Kullanıcılar] ([kullanici_id], [kullanici_ad], [kullanici_soyad], [kullanici_tc], [kullanici_mail], [kullanici_tel]) VALUES (12, N'Mehmet', N'Kaya', N'24496344289', N'mehmetkaya@gmail.com', N'59799625876')
INSERT [dbo].[Kullanıcılar] ([kullanici_id], [kullanici_ad], [kullanici_soyad], [kullanici_tc], [kullanici_mail], [kullanici_tel]) VALUES (13, N'Zeynep', N'Yapı', N'25796346621', N'zeynepyapi@gmail.com', N'56099625822')
INSERT [dbo].[Kullanıcılar] ([kullanici_id], [kullanici_ad], [kullanici_soyad], [kullanici_tc], [kullanici_mail], [kullanici_tel]) VALUES (14, N'Elif', N'Kapıcı', N'25887331025', N'elifkapici@gmail.com', N'53267900158')
INSERT [dbo].[Kullanıcılar] ([kullanici_id], [kullanici_ad], [kullanici_soyad], [kullanici_tc], [kullanici_mail], [kullanici_tel]) VALUES (15, N'Ömer', N'Mert', N'16875206934', N'omermert@gmail.com', N'56974033658')
INSERT [dbo].[Kullanıcılar] ([kullanici_id], [kullanici_ad], [kullanici_soyad], [kullanici_tc], [kullanici_mail], [kullanici_tel]) VALUES (16, N'Aslı', N'Atıl', N'35967426983', N'asliatil@gmail.com', N'55299625876')
INSERT [dbo].[Kullanıcılar] ([kullanici_id], [kullanici_ad], [kullanici_soyad], [kullanici_tc], [kullanici_mail], [kullanici_tel]) VALUES (17, N'Nur', N'Kale', N'33696344289', N'nurkale@gmail.com', N'51299625876')
INSERT [dbo].[Kullanıcılar] ([kullanici_id], [kullanici_ad], [kullanici_soyad], [kullanici_tc], [kullanici_mail], [kullanici_tel]) VALUES (18, N'Umut', N'Yandaş', N'25796349966', N'umutyandas@gmail.com', N'52399625876')
INSERT [dbo].[Kullanıcılar] ([kullanici_id], [kullanici_ad], [kullanici_soyad], [kullanici_tc], [kullanici_mail], [kullanici_tel]) VALUES (19, N'Yağmur', N'Kara', N'37596344289', N'yagmurkara@gmail.com', N'56239625876')
INSERT [dbo].[Kullanıcılar] ([kullanici_id], [kullanici_ad], [kullanici_soyad], [kullanici_tc], [kullanici_mail], [kullanici_tel]) VALUES (20, N'Fatma', N'Duru', N'16986344289', N'fatmaduru@gmail.com', N'59639625876')
INSERT [dbo].[Kullanıcılar] ([kullanici_id], [kullanici_ad], [kullanici_soyad], [kullanici_tc], [kullanici_mail], [kullanici_tel]) VALUES (21, N'İrfan', N'Dil', N'22366344289', N'irfandil@gmail.com', N'58669625876')
INSERT [dbo].[Kullanıcılar] ([kullanici_id], [kullanici_ad], [kullanici_soyad], [kullanici_tc], [kullanici_mail], [kullanici_tel]) VALUES (22, N'Yusuf', N'Dertsiz', N'26844344289', N'yusufdertsiz@gmail.com', N'53029625876')
INSERT [dbo].[Kullanıcılar] ([kullanici_id], [kullanici_ad], [kullanici_soyad], [kullanici_tc], [kullanici_mail], [kullanici_tel]) VALUES (23, N'Dilara', N'Aslan', N'24496344281', N'dilaraaslan@gmail.com', N'51698625876')
INSERT [dbo].[Kullanıcılar] ([kullanici_id], [kullanici_ad], [kullanici_soyad], [kullanici_tc], [kullanici_mail], [kullanici_tel]) VALUES (24, N'Emirhan', N'Uç', N'35586344289', N'emirhanuc@gmail.com', N'52799625866')
SET IDENTITY_INSERT [dbo].[Kullanıcılar] OFF
SET IDENTITY_INSERT [dbo].[Personeller] ON 

INSERT [dbo].[Personeller] ([personel_id], [personel_ad], [personel_soyad], [personel_tc], [personel_tel], [personel_mail], [personel_kullaniciad], [personel_sifre]) VALUES (1, N'Admin', N'Admin', N'11111111111', N'11111111111', N'admin@gmail.com', N'admin', N'123')
INSERT [dbo].[Personeller] ([personel_id], [personel_ad], [personel_soyad], [personel_tc], [personel_tel], [personel_mail], [personel_kullaniciad], [personel_sifre]) VALUES (3, N'Ömer', N'Mert', N'22222222222', N'22222222222', N'omer@gmail.com', N'ömer', N'123')
INSERT [dbo].[Personeller] ([personel_id], [personel_ad], [personel_soyad], [personel_tc], [personel_tel], [personel_mail], [personel_kullaniciad], [personel_sifre]) VALUES (4, N'İbrahim', N'Özcan', N'33333333333', N'33333333333', N'ibrahim@gmail.com', N'ibrahim', N'321')
SET IDENTITY_INSERT [dbo].[Personeller] OFF
ALTER TABLE [dbo].[Kayıtlar]  WITH CHECK ADD  CONSTRAINT [FK_Kayıtlar_Kaynaklar] FOREIGN KEY([kitap_id])
REFERENCES [dbo].[Kaynaklar] ([kaynak_id])
GO
ALTER TABLE [dbo].[Kayıtlar] CHECK CONSTRAINT [FK_Kayıtlar_Kaynaklar]
GO
ALTER TABLE [dbo].[Kayıtlar]  WITH CHECK ADD  CONSTRAINT [FK_Kayıtlar_Kullanıcılar] FOREIGN KEY([kullanici_id])
REFERENCES [dbo].[Kullanıcılar] ([kullanici_id])
GO
ALTER TABLE [dbo].[Kayıtlar] CHECK CONSTRAINT [FK_Kayıtlar_Kullanıcılar]
GO
