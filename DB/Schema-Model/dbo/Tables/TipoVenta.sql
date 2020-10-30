CREATE TABLE [dbo].[TipoVenta]
(
	[IdTipoVenta] [int] NOT NULL IDENTITY(1, 1),
	[Nombre] [nvarchar] (32) NULL,
	[Activo] [bit] NULL,
)
GO
ALTER TABLE [dbo].[TipoVenta] ADD CONSTRAINT [IdTipoVenta] PRIMARY KEY CLUSTERED  ([IdTipoVenta])
GO
