CREATE TABLE [dbo].[ItemCotizacion]
(
	[IdItemCotizacion] [int] NOT NULL IDENTITY(1, 1),
	[IdItem] [int] NOT NULL,
	[IdUnidadCotizacion] [int] NOT NULL,
	[FechaInicial] [datetimeoffset] NULL,
	[FechaFinal] [datetimeoffset] NULL,
)
GO
ALTER TABLE [dbo].[ItemCotizacion] ADD CONSTRAINT [IdItemCotizacion] PRIMARY KEY CLUSTERED  ([IdItemCotizacion])
GO
