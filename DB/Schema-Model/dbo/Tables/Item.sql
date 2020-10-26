CREATE TABLE [dbo].[Item]
(
	[IdItem] [int] NOT NULL IDENTITY(1, 1),
	[IdTipoItem] [int] NULL,
	[Codigo] [nvarchar] (16) NULL,
	[Nombre] [nvarchar] (255) NULL,
	[Activo] [bit] NULL
)
GO
ALTER TABLE [dbo].[Item] ADD CONSTRAINT [IdItem] PRIMARY KEY CLUSTERED  ([IdItem])
GO
