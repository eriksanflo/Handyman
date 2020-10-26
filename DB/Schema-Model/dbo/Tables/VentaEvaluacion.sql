CREATE TABLE [dbo].[VentaEvaluacion]
(
	[IdVenta]		[int]				NOT NULL IDENTITY(1, 1),
	[Estrellas]		[decimal] (3,2)		NULL,
	[Comentarios]	[nvarchar] (255)	NULL,
	[Activo]		[bit]				NULL
)
GO
ALTER TABLE [dbo].[VentaEvaluacion] ADD CONSTRAINT [IdVentaEvaluacion] PRIMARY KEY CLUSTERED  ([IdVenta])
GO
