CREATE TABLE [dbo].[VentaDetalleExtra]
(
	[IdVentaDetalleExtra]	[int] NOT NULL IDENTITY(1, 1),
	[IdVentaDetalle]		[int] NOT NULL,		
	[Descripcion]			[nvarchar] (256)
)
GO
ALTER TABLE [dbo].[VentaDetalleExtra] ADD CONSTRAINT [IdVentaDetalleExtra] PRIMARY KEY CLUSTERED  ([IdVentaDetalleExtra])
GO