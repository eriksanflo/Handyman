CREATE TABLE [dbo].[ItemPrecio]
(
	[IdItemPrecio] [int] NOT NULL IDENTITY(1, 1),
	[IdItem] [int] NOT NULL,
	[FechaInicial] [date] NULL,
	[FechaFinal] [date] NULL,
	[HoraInicial] [time] NULL,
	[HoraFinal] [time] NULL,
	[Precio] [decimal] (17, 2) NULL,
	[Activo] [bit] NOT NULL
)
GO
ALTER TABLE [dbo].[ItemPrecio] ADD CONSTRAINT [IdItemPrecio] PRIMARY KEY CLUSTERED  ([IdItemPrecio])
GO
