CREATE TABLE [dbo].[EstatusPago]
(
[IdEstatusPago] [int] NOT NULL IDENTITY(1, 1),
[IdTipoEstatusPago] [int] NULL,
[Nombre] [nvarchar] (64) NULL,
[Activo] [bit] NULL
)
GO
ALTER TABLE [dbo].[EstatusPago] ADD CONSTRAINT [IdEstatusPago] PRIMARY KEY CLUSTERED  ([IdEstatusPago])
GO

