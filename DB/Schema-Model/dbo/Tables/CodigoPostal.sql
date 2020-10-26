CREATE TABLE [dbo].[CodigoPostal]
(
	[IdCodigoPostal]		[int]				NOT NULL IDENTITY(1, 1),
	[IdPais]				[int]				NOT NULL,
	[Pais]					[nvarchar] (32)		NOT NULL,
	[IdRegion1]				[int]				NOT NULL,
	[Region1]				[nvarchar] (64)		NOT NULL,
	[IdRegion2]				[int]				NOT NULL,
	[Region2]				[nvarchar] (128)	NOT NULL,
	[IdRegion3]				[int]				NULL,
	[Region3]				[nvarchar] (256)	NULL,
	[IdRegion4]				[int]				NULL,
	[Region4]				[nvarchar] (256)	NULL,
	[CodigoPostal]			[nvarchar] (16)		NOT NULL,
	[Activo]				[bit]				NOT NULL
)
GO
ALTER TABLE [dbo].[CodigoPostal] ADD CONSTRAINT [IdCodigoPostal] PRIMARY KEY CLUSTERED  ([IdCodigoPostal])
GO