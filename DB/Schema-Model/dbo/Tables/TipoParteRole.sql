CREATE TABLE [dbo].[TipoParteRole]
(
	[IdTipoParteRole] [int] NOT NULL IDENTITY(1, 1),
	[Nombre] [nvarchar] (128) NULL,
	[Usuario] [bit] NULL,
	[Activo] [bit] NULL
)
GO
ALTER TABLE [dbo].[TipoParteRole] ADD CONSTRAINT [IdTipoParteRole] PRIMARY KEY CLUSTERED  ([IdTipoParteRole])
GO
