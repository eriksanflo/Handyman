CREATE TABLE [dbo].[Transferencia]
(
	[IdTransferencia]		[int]					NOT NULL	IDENTITY(1, 1),
	[IdParte]				[Uniqueidentifier]		NOT NULL,
	[NumeroAutorizacion]	[nvarchar] (20)			NULL,
	[Folio]					[nvarchar] (20)			NULL,
	[UrlComprobante]		[nvarchar] (256)		NULL,
)
GO
ALTER TABLE [dbo].[Transferencia] ADD CONSTRAINT [IdTransferencia] PRIMARY KEY CLUSTERED ([IdTransferencia])
GO