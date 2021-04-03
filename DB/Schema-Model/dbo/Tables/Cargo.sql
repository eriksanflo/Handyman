CREATE TABLE [dbo].[Cargo]
(
	[IdCargo] [nvarchar] (250)	NOT NULL,
	[IdVenta] [int]				NOT NULL,
	[Importe] [decimal]	(17, 2)	NOT NULL,
	[Reembolsado] [decimal]	(17, 2) NULL,
)
GO
ALTER TABLE [dbo].[Cargo] ADD CONSTRAINT [IdCargo] PRIMARY KEY CLUSTERED  ([IdCargo])
GO
