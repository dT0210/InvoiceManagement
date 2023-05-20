USE [InvoiceProject]
GO

/****** Object:  StoredProcedure [dbo].[deleteImport]    Script Date: 4/30/2023 11:28:45 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[deleteImport] @id nvarchar(10)
as
begin
	delete from Imported where ImportListID = @id;
	delete from ImportList where ImportListID = @id;
end
GO

/****** Object:  StoredProcedure [dbo].[deleteInvoice]    Script Date: 4/30/2023 11:29:07 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[deleteInvoice] @id nvarchar(10)
as
begin
	delete from Purchase where InvID = @id;
	delete from Invoice where InvID = @id;
end
GO

/****** Object:  StoredProcedure [dbo].[getAllInvoice]    Script Date: 4/30/2023 11:29:32 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[getAllInvoice]
as
begin
	select i.InvID as 'Invoice ID', i.DateTime as 'Date and time', cast(sum(p.Quantity*p.UnitPrice*(1-p.Discount)) as decimal(16, 2)) as 'Total'
	from Invoice as i inner join Purchase as p on i.InvID = p.InvID
	group by i.InvID, i.DateTime
end
GO

/****** Object:  StoredProcedure [dbo].[getImport]    Script Date: 4/30/2023 11:29:44 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[getImport] @id nvarchar(10)
as
begin
	select i.ProdID as 'Product ID', i.ProdName as 'Product Name', i.Unit, cast(i.UnitPrice as decimal(16, 2)) as 'Unit Price', i.Quantity, i.Discount, cast(i.Quantity*i.UnitPrice*(1-i.Discount) as decimal(16, 2)) as 'Amount'
	from ImportList as il inner join Imported as i on il.ImportListID = i.ImportListID
	where il.ImportListID = @id
end
GO

/****** Object:  StoredProcedure [dbo].[getImportHistory]    Script Date: 4/30/2023 11:29:57 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[getImportHistory]
as
begin
	select il.ImportListID as 'Import ID', il.DateTime as 'Date and time', cast(sum(i.Quantity*i.UnitPrice*(1-i.Discount)) as decimal(16, 2)) as 'Total' 
	from Imported as i inner join ImportList as il on i.ImportListID = il.ImportListID
	group by il.ImportListID, il.DateTime
end
GO

/****** Object:  StoredProcedure [dbo].[getInvoice]    Script Date: 4/30/2023 11:30:22 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[getInvoice] @id nvarchar(10)
as
begin
	select p.ProdID as 'Product ID', p.ProdName as 'Product Name', p.Unit, cast(p.UnitPrice as decimal(16, 2)) as 'Unit Price', p.Quantity, p.Discount, cast(p.Quantity*p.UnitPrice*(1-p.Discount) as decimal(16, 2)) as 'Amount'
	from Invoice as i inner join Purchase as p on i.InvID = p.InvID
	where i.InvID = @id
end
GO

/****** Object:  StoredProcedure [dbo].[getProductData]    Script Date: 4/30/2023 11:30:36 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[getProductData]
as 
begin
	SELECT TOP (1000) 
		[ProdID] as 'Product ID'
      ,[ProdName] as 'Product Name'
      ,[Unit] 
      ,cast([UnitPrice] as decimal(16,2)) as 'Unit Price'
      ,[Quantity]
	FROM [InvoiceProject].[dbo].[Product]
end
GO

/****** Object:  StoredProcedure [dbo].[getProductImport]    Script Date: 4/30/2023 11:30:46 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[getProductImport] @id nvarchar(10)
as
begin
	select il.ImportListID as 'Import ID', il.DateTime as 'Date and time', cast(i.UnitPrice as decimal(16, 2)) as 'Unit Price', i.Quantity, i.Discount, cast(i.Quantity*i.UnitPrice*(1-i.Discount) as decimal(16, 2)) as 'Amount'
	from ImportList as il inner join Imported as i on il.ImportListID = i.ImportListID
	where i.ProdID = @id
end
GO

