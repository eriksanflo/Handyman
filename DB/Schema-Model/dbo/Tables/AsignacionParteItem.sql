CREATE TABLE [dbo].[AsignacionParteItem]
(
	[IdAsignacionParteItem]	[int]				NOT NULL IDENTITY(1, 1),
	[IdParte]				[uniqueidentifier]	NOT NULL,	
	[IdItem]				[int]				NOT NULL,
	[PuedeSerEmergente]		[bit]				NULL,
	[TipoEmergente]			[nvarchar] (8)		NULL,	
	[ImporteIncremento]		[decimal] (17, 2)	NULL,
	[FechaInicial]			datetimeoffset(2)	NULL,
	[FechaFinal]			datetimeoffset(2)	NULL,
)
GO
ALTER TABLE [dbo].[AsignacionParteItem] ADD CONSTRAINT [IdAsignacionParteItem] PRIMARY KEY CLUSTERED ([IdAsignacionParteItem])
GO
