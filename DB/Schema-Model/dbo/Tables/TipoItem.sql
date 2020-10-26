CREATE TABLE [dbo].[TipoItem]
(
	[IdTipoItem]	[int] NOT NULL IDENTITY(1, 1),
	[Nombre]		[nvarchar] (16) NULL,
	[Categoria]		[bit] NOT NULL,
	[ImagenUrl]		[nvarchar] (128) NOT NULL,
	[Activo]		[bit] NULL
)
GO
ALTER TABLE [dbo].[TipoItem] ADD CONSTRAINT [IdTipoItem] PRIMARY KEY CLUSTERED  ([IdTipoItem])
GO
