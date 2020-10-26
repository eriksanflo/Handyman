CREATE TABLE [dbo].[EstatusVenta]
(
	[IdEstatusVenta] [int] NOT NULL IDENTITY(1, 1),
	[IdTipoEstatusVenta] [int] NULL,
	[Nombre] [nvarchar] (64) NULL,
	[Activo] [bit] NULL
)
GO
ALTER TABLE [dbo].[EstatusVenta] ADD CONSTRAINT [IdEstatusVenta] PRIMARY KEY CLUSTERED  ([IdEstatusVenta])
GO
