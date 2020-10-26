CREATE TABLE [dbo].[VentaEstatus]
(
	[IdVentaEstatus] [int] NOT NULL IDENTITY(1, 1),
	[IdVenta] [int] NULL,
	[IdVentaDetalle] [int] NULL,
	[IdEstatusVenta] [int] NULL,
	[IdParteRole] [int] NULL,
	[FechaRegistro] datetimeoffset(7) NULL
)
GO
ALTER TABLE [dbo].[VentaEstatus] ADD CONSTRAINT [IdVentaEstatus] PRIMARY KEY CLUSTERED  ([IdVentaEstatus])
GO