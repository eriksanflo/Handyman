CREATE TABLE [dbo].[EstatusPersona]
(
	[IdEstatusPersona] [int] NOT NULL IDENTITY(1, 1),
	[Codigo] [nvarchar] (8) NULL,
	[Nombre] [nvarchar] (128) NULL,
	[Activo] [bit] NULL
)
GO
ALTER TABLE [dbo].[EstatusPersona] ADD CONSTRAINT [IdEstatusPersona] PRIMARY KEY CLUSTERED  ([IdEstatusPersona])
GO
