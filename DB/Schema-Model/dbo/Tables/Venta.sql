CREATE TABLE [dbo].[Venta]
(
	[IdVenta] [int] NOT NULL IDENTITY(1, 1),
	[IdTipoVenta] [int] NOT NULL,
	[Folio] [nvarchar] (16) NULL,
	[Fecha] [date] NULL,
	[FechaRegistro] datetimeoffset(2) NULL,
)
GO
ALTER TABLE [dbo].[Venta] ADD CONSTRAINT [IdVenta] PRIMARY KEY CLUSTERED  ([IdVenta])
GO
