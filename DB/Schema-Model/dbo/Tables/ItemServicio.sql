CREATE TABLE [dbo].[ItemServicio]
(
	[IdItem] [int] NOT NULL,
	[ImagenUrl] nvarchar(256) NULL,
)
GO
ALTER TABLE [dbo].[ItemServicio] ADD CONSTRAINT [IdItemServicio] PRIMARY KEY CLUSTERED  ([IdItem])
GO
