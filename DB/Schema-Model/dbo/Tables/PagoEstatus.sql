CREATE TABLE [dbo].[PagoEstatus]
(
	[IdPagoEstatus] [int] NOT NULL IDENTITY(1, 1),
	[IdParteRole] [int] NULL,
	[IdEstatusPago] [int] NULL,
	[IdPago] [int] NULL,
	[FechaRegistro] datetimeoffset(2) NULL
)
GO
ALTER TABLE [dbo].[PagoEstatus] ADD CONSTRAINT [IdPagoEstatus] PRIMARY KEY CLUSTERED  ([IdPagoEstatus])
GO

