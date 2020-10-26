CREATE TABLE [dbo].[Banco]
(
	[IdBanco]	[int] NOT NULL IDENTITY(1, 1),
	[Codigo]	[nvarchar] (16) NULL,
	[Nombre]	[nvarchar] (255) NULL,
	[Activo]	[bit] NULL
)
GO
ALTER TABLE [dbo].[Banco] ADD CONSTRAINT [IdBanco] PRIMARY KEY CLUSTERED  ([IdBanco])
GO
