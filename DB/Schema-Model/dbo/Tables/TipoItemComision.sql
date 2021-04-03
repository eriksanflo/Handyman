CREATE TABLE [dbo].[TipoItemComision]
(
	[IdTipoItemComision]	[int]				NOT NULL IDENTITY(1, 1),
	[IdTipoItem]			[int]				NOT NULL,
	[Desde]					[decimal](17, 2)	NOT NULL,
	[Hasta]					[decimal](17, 2)	NOT NULL,
	[TipoCalculo]			[nvarchar](8)		NOT NULL,
	[Valor]					[decimal] (17, 2)	NOT NULL,
	[Activo]				[bit]				NOT NULL
)
GO
ALTER TABLE [dbo].[TipoItemComision] ADD CONSTRAINT [IdTipoItemComision] PRIMARY KEY CLUSTERED  ([IdTipoItemComision])
GO
