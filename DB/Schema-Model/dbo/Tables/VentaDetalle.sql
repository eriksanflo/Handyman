CREATE TABLE [dbo].[VentaDetalle]
(
	[IdVentaDetalle]	[int] NOT NULL IDENTITY(1, 1),
	[IdVenta]			[int] NOT NULL,	
	[IdItem]			[int] NOT NULL,
	[IdTipoItem]		[int] NOT NULL,
	[IdItemPrecio]		[int] NULL,
	[IdPago]			[int] NULL,
	[Cantidad]			[decimal] (17, 2) NULL,
	[Precio]			[decimal] (17, 2) NULL,
	[Importe]			[decimal] (17, 2) NULL,
	[ImportePagado]		[decimal] (17, 2) NULL,	
	[FechaCompromiso]	[Datetimeoffset](7) NULL,	
	[Secuencia]			[smallint] NULL,	
	[Observaciones]		[nvarchar] (256)
)
GO
ALTER TABLE [dbo].[VentaDetalle] ADD CONSTRAINT [IdVentaDetalle] PRIMARY KEY CLUSTERED  ([IdVentaDetalle])
GO