CREATE TABLE [dbo].[TipoEstatusVenta]
(
	[IdTipoEstatusVenta] [int] NOT NULL IDENTITY(1, 1),
	[Nombre] [nvarchar] (16) NULL,
	[Activo] [bit] NULL
)
GO
ALTER TABLE [dbo].[TipoEstatusVenta] ADD CONSTRAINT [IdTipoEstatusVenta] PRIMARY KEY CLUSTERED  ([IdTipoEstatusVenta])
GO
