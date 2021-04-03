CREATE TABLE [dbo].[Configuracion]
(
	[IdConfiguracion]	[int]			NOT NULL IDENTITY(1, 1),
	[Nombre]			[nvarchar] (64)	NULL,
	[ActualizacionCode]	[nvarchar] (32)	NULL,
)
GO
ALTER TABLE [dbo].[Configuracion] ADD CONSTRAINT [IdConfiguracion] PRIMARY KEY CLUSTERED ([IdConfiguracion])
GO
