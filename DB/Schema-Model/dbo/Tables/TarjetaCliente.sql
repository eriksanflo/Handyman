CREATE TABLE [dbo].[TarjetaCliente]
(
	[IdTarjetaCliente]	[int]					NOT NULL	IDENTITY(1, 1),
	[IdParte]			[Uniqueidentifier]		NOT NULL,
	[IdTipoTarjeta]		[int]					NOT NULL,
	[IdRedTarjeta]		[int]					NOT NULL,
	[IdBanco]			[int]					NOT NULL,
	[Titular]			[nvarchar] (256)		NULL,
	[Numero]			[nvarchar] (256)		NOT NULL,
	[Expiracion]		[nvarchar] (256)		NOT NULL,
	[CVV]				[nvarchar] (256)		NOT NULL,
	[IsAMEX]			[bit]					NULL,
	[IsDefault]			[bit]					NOT NULL,
	[FechaInicio]		[datetimeoffset](7)		NOT NULL,
	[FechaFin]			[datetimeoffset](7)		NULL,
)
GO
ALTER TABLE [dbo].[TarjetaCliente] ADD CONSTRAINT [IdTarjetaCliente] PRIMARY KEY CLUSTERED ([IdTarjetaCliente])
GO