CREATE TABLE [dbo].[TipoTarjeta]
(
[IdTipoTarjeta] [int] NOT NULL,
[Nombre] [nvarchar] (64) NULL,
[Activo] [bit] NULL
)
GO
ALTER TABLE [dbo].[TipoTarjeta] ADD CONSTRAINT [IdTipoTarjeta] PRIMARY KEY CLUSTERED  ([IdTipoTarjeta])
GO
