CREATE TABLE [dbo].[VentaDetalleRole]
(
	[IdVentaDetalleRole] [int] NOT NULL IDENTITY(1, 1),
	[IdVentaDetalle] [int] NULL,
	[IdParteRole] [int] NULL,
	[IdTipoParteRole] [int] NULL,
	[FechaInicial] datetimeoffset(2) NULL,
	[FechaFinal] datetimeoffset(2) NULL,
)
GO
ALTER TABLE [dbo].[VentaDetalleRole] ADD CONSTRAINT [IdVentaDetalleRole] PRIMARY KEY CLUSTERED  ([IdVentaDetalleRole])
GO