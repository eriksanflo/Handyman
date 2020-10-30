CREATE TABLE [dbo].[Pago]
(
	[IdPago]					[int]				NOT NULL IDENTITY(1, 1),
	[Folio]						[nvarchar] (16)		NOT NULL,
	[IdTarjetaCliente]			[int]				NULL,
	[IdTransferencia]			[int]				NULL,	
	[IdCliente]					[uniqueidentifier]	NOT NULL,	
	[Importe]					[decimal] (17, 2)	NULL,
	[Estatus]					[char] (1)			NULL,
	[FechaRegistro]				datetimeoffset(2)	NULL,
	[Observaciones]				[nvarchar] (256)	NULL,
)
GO
ALTER TABLE [dbo].[Pago] ADD CONSTRAINT [IdPago] PRIMARY KEY CLUSTERED ([IdPago])
GO
