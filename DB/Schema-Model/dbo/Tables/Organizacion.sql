CREATE TABLE [dbo].[Organizacion]
(
	[IdParte] [uniqueidentifier] NOT NULL,
	[Nombre] [nvarchar] (255) NULL
)
GO
ALTER TABLE [dbo].[Organizacion] ADD CONSTRAINT [IdOrganizacion] PRIMARY KEY CLUSTERED  ([IdParte])
GO
