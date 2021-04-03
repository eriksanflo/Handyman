CREATE TABLE [dbo].[VentaImagen]
(
	[IdVentaImagen]	[int]				NOT NULL IDENTITY(1, 1),
	[IdVenta]		[int]				NOT NULL,
	[Nombre]		[nvarchar] (250)	NULL,
	[Extension]		[nvarchar] (16)		NULL,
	[Imagen]		[varbinary](max)	NULL,
)
GO
ALTER TABLE [dbo].[VentaImagen] ADD CONSTRAINT [IdVentaImagen] PRIMARY KEY CLUSTERED  ([IdVentaImagen])
GO
