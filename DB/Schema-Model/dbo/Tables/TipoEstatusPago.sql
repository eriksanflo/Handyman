CREATE TABLE [dbo].[TipoEstatusPago]
(
[IdTipoEstatusPago] [int] NOT NULL IDENTITY(1, 1),
[Nombre] [nvarchar] (64) NULL,
[Activo] [bit] NULL
)
GO
ALTER TABLE [dbo].[TipoEstatusPago] ADD CONSTRAINT [IdTipoEstatusPago] PRIMARY KEY CLUSTERED  ([IdTipoEstatusPago])
GO
