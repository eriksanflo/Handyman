CREATE TABLE [dbo].[TipoTarjetaCredito]
(
[IdTipoTarjetaCredito] [int] NOT NULL IDENTITY(1, 1),
[Nombre] [nvarchar] (32) NULL,
[Activo] [bit] NULL
)
GO
ALTER TABLE [dbo].[TipoTarjetaCredito] ADD CONSTRAINT [IdTipoTarjetaCredito] PRIMARY KEY CLUSTERED  ([IdTipoTarjetaCredito])
GO
