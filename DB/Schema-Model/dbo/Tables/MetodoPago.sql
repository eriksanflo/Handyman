CREATE TABLE [dbo].[MetodoPago]
(
	[IdMetodoPago]	[int]	NOT NULL	IDENTITY(1, 1),
	[Nombre] [nvarchar] (64) NULL,
	[Descripcion] [nvarchar] (256) NULL,
	[Activo] [char] (1) NULL,
)
GO
ALTER TABLE [dbo].[MetodoPago] ADD CONSTRAINT [IdMetodoPago] PRIMARY KEY CLUSTERED ([IdMetodoPago])
GO