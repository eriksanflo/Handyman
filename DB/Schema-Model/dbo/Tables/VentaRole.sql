CREATE TABLE [dbo].[VentaRole]
(
	[IdVentaRole] [int] NOT NULL IDENTITY(1, 1),
	[IdVenta] [int] NULL,
	[IdParteRole] [int] NULL,
	[IdTipoParteRole] [int] NULL,
	[FechaInicial] datetimeoffset(2) NULL,
	[FechaFinal] datetimeoffset(2) NULL,
)
GO
ALTER TABLE [dbo].[VentaRole] ADD CONSTRAINT [IdVentaRole] PRIMARY KEY CLUSTERED  ([IdVentaRole])
GO