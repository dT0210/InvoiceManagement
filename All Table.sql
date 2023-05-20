USE [InvoiceProject]
GO

/****** Object:  Table [dbo].[Imported]    Script Date: 5/1/2023 10:57:41 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Imported](
	[ImportedID] [int] IDENTITY(1,1) NOT NULL,
	[ImportListID] [nvarchar](8) NOT NULL,
	[ProdID] [nvarchar](10) NOT NULL,
	[ProdName] [nvarchar](20) NOT NULL,
	[Unit] [nvarchar](15) NULL,
	[UnitPrice] [money] NOT NULL,
	[Quantity] [int] NOT NULL,
	[Discount] [decimal](3, 2) NULL,
 CONSTRAINT [PK_Imported] PRIMARY KEY CLUSTERED 
(
	[ImportedID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Imported]  WITH CHECK ADD  CONSTRAINT [FK_Imported_List] FOREIGN KEY([ImportListID])
REFERENCES [dbo].[ImportList] ([ImportListID])
GO

ALTER TABLE [dbo].[Imported] CHECK CONSTRAINT [FK_Imported_List]
GO

/****** Object:  Table [dbo].[ImportList]    Script Date: 5/1/2023 10:58:04 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ImportList](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ImportListID]  AS (isnull('IM'+right('000000'+CONVERT([nvarchar](6),[ID]),(6)),'X')) PERSISTED NOT NULL,
	[DateTime] [datetime] NULL,
 CONSTRAINT [PK_ImportList] PRIMARY KEY CLUSTERED 
(
	[ImportListID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[Invoice]    Script Date: 5/1/2023 10:58:44 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Invoice](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[InvID]  AS (isnull('I'+right('000000'+CONVERT([nvarchar](6),[ID]),(6)),'X')) PERSISTED NOT NULL,
	[DateTime] [datetime] NULL,
 CONSTRAINT [PK_Invoice] PRIMARY KEY CLUSTERED 
(
	[InvID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[Product]    Script Date: 5/1/2023 10:59:22 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Product](
	[ProdID] [nvarchar](10) NOT NULL,
	[ProdName] [nvarchar](20) NOT NULL,
	[Unit] [nvarchar](15) NULL,
	[UnitPrice] [money] NOT NULL,
	[Quantity] [int] NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[ProdID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Object:  Table [dbo].[Purchase]    Script Date: 5/1/2023 10:59:32 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Purchase](
	[PurchaseID] [int] IDENTITY(1,1) NOT NULL,
	[InvID] [nvarchar](7) NOT NULL,
	[ProdID] [nvarchar](10) NOT NULL,
	[ProdName] [nvarchar](20) NOT NULL,
	[Unit] [nvarchar](15) NULL,
	[UnitPrice] [money] NOT NULL,
	[Quantity] [int] NOT NULL,
	[Discount] [decimal](3, 2) NULL,
 CONSTRAINT [PK__Purchase__6B0A6BDE3EB510EB] PRIMARY KEY CLUSTERED 
(
	[PurchaseID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Purchase]  WITH CHECK ADD  CONSTRAINT [FK_Purchase_Invoice] FOREIGN KEY([InvID])
REFERENCES [dbo].[Invoice] ([InvID])
GO

ALTER TABLE [dbo].[Purchase] CHECK CONSTRAINT [FK_Purchase_Invoice]
GO