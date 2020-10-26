CREATE TABLE [dbo].[Pago]
(
	[IdPago]					[int]				NOT NULL IDENTITY(1, 1),
	[IdTarjetaCliente]			[int]				NOT NULL,
	[Folio]						[nvarchar] (16)		NULL,
	[IdParteCliente]			[uniqueidentifier]	NULL,
	[NumeroAutorizacion]		[nvarchar] (20)		NULL,
	[Importe]					[decimal] (17, 2)	NULL,
	[ImporteRecibido]			[decimal] (17, 2)	NULL,
	[Estatus]					[char] (1)			NULL,
	[FechaRegistro]				datetimeoffset(2)	NULL,
	[Observaciones]				[nvarchar] (256)	NULL,
)
GO
ALTER TABLE [dbo].[Pago] ADD CONSTRAINT [IdPago] PRIMARY KEY CLUSTERED ([IdPago])
GO
