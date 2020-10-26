CREATE TABLE [dbo].[PagoRole]
(
	[IdPagoRole] [int] NOT NULL IDENTITY(1, 1),
	[IdPago] [int] NULL,
	[IdParteRole] [int] NULL,
	[IdTipoParteRole] [int] NULL,
	[FechaInicial] [date] NULL,
	[FechaFinal] [date] NULL,
	[FechaRegistro] datetimeoffset(2) NULL
)
GO
ALTER TABLE [dbo].[PagoRole] ADD CONSTRAINT [IdPagoRole] PRIMARY KEY CLUSTERED  ([IdPagoRole])
GO

