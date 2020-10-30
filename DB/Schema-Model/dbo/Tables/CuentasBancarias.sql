CREATE TABLE [dbo].[CuentaBancaria]
(
	[IdCuentaBancaria]	[int]				NOT NULL	IDENTITY(1, 1),
	[IdParte]			[Uniqueidentifier]	NOT NULL,
	[IdBanco]			[int]				NOT NULL,
	[Numero]			[nvarchar] (20)		NOT NULL,
	[Clabe]				[nvarchar] (256)	NOT NULL,
	[Activo]			[bit]				NOT NULL,
)
GO
ALTER TABLE [dbo].[CuentaBancaria] ADD CONSTRAINT [IdCuentaBancaria] PRIMARY KEY CLUSTERED ([IdCuentaBancaria])
GO