CREATE TABLE [dbo].[UnidadCotizacion]
(
	[IdUnidadCotizacion] [int] NOT NULL IDENTITY(1, 1),
	[Abreviatura] nvarchar(16) NOT NULL,
	[Nombre] nvarchar(128) NULL,
	[Activo] [bit] NULL,
)
GO
ALTER TABLE [dbo].[UnidadCotizacion] ADD CONSTRAINT [IdUnidadCotizacion] PRIMARY KEY CLUSTERED  ([IdUnidadCotizacion])
GO
