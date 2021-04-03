CREATE TABLE [dbo].[ItemPrecio]
(
	[IdItemPrecio]		[int]	NOT NULL IDENTITY(1, 1),
	[IdItemCotizacion]	[int]	NOT NULL,
	[IdItem]			[int]	NOT NULL,
	[Desde]				[decimal](17, 2)	NOT NULL,
	[Hasta]				[decimal](17, 2)	NOT NULL,
	[FechaInicial]		[datetime]	NULL,
	[FechaFinal]		[datetime]	NULL,
	[Precio]			[decimal] (17, 2) NULL,
	[Activo]			[bit] NOT NULL
)
GO
ALTER TABLE [dbo].[ItemPrecio] ADD CONSTRAINT [IdItemPrecio] PRIMARY KEY CLUSTERED  ([IdItemPrecio])
GO
