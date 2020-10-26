CREATE TABLE [dbo].[DireccionPostalParte]
(
	[IdDireccionPostalParte]	[int]				NOT NULL IDENTITY(1, 1),
	[IdParte]					[uniqueidentifier]	NOT NULL,
	[IdTipoPropositoContacto]	[int]				NOT NULL,
	[IdPropositoContacto]		[int]				NOT NULL,
	[IdCodigoPostal]			[int]				NOT NULL,
	[Calle]						[nvarchar] (128)	NOT NULL,
	[EntreCalle]				[nvarchar] (128)	NULL,
	[YCalle]					[nvarchar] (128)	NULL,
	[NumeroExterior]			[nvarchar] (32)		NOT NULL,
	[NumeroInterior]			[nvarchar] (32)		NULL,
	[Referencia]				[nvarchar] (128)	NULL,
	[Principal]					[bit]				NULL,
	[FechaInicial]				[datetimeoffset]	NOT NULL,
	[FechaFinal]				[datetimeoffset]	NULL,
)
GO
ALTER TABLE [dbo].[DireccionPostalParte] ADD CONSTRAINT [IdDireccionPostalParte] PRIMARY KEY CLUSTERED  ([IdDireccionPostalParte])
GO