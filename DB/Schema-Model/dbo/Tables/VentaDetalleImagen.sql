CREATE TABLE [dbo].[VentaDetalleImagen]
(
	[IdVentaDetalleImagen]	[int] NOT NULL IDENTITY(1, 1),
	[IdVentaDetalle]		[int] NOT NULL,		
	[ImagenUrl]				[nvarchar] (256)
)
GO
ALTER TABLE [dbo].[VentaDetalleImagen] ADD CONSTRAINT [IdVentaDetalleImagen] PRIMARY KEY CLUSTERED  ([IdVentaDetalleImagen])
GO