CREATE TABLE [dbo].[MedioContactoParte]
(
	[IdMedioContactoParte]		[int]				NOT NULL IDENTITY(1, 1),
	[IdTipoPropositoContacto]	[int]				NOT NULL,
	[IdPropositoContacto]		[int]				NOT NULL,
	[IdParte]					[uniqueidentifier]	NOT NULL,
	[Contacto]					[nvarchar] (64)		NOT NULL,
	[Principal]					[bit]				NOT NULL,
	[FechaInicial]				[datetimeoffset]	NOT NULL,
	[FechaFinal]				[datetimeoffset]	NULL,
)
GO
ALTER TABLE [dbo].[MedioContactoParte] ADD CONSTRAINT [IdMedioContactoParte] PRIMARY KEY CLUSTERED  ([IdMedioContactoParte])
GO

