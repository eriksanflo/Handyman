CREATE TABLE [dbo].[RedTarjeta]
(
	[IdRedTarjeta] [int] NOT NULL IDENTITY(1, 1),
	[Nombre] [nvarchar] (16) NULL,
	[Activo] [bit] NULL
)
GO
ALTER TABLE [dbo].[RedTarjeta] ADD CONSTRAINT [IdRedTarjeta] PRIMARY KEY CLUSTERED  ([IdRedTarjeta])
GO
