CREATE TABLE [dbo].[TipoPropositoContacto]
(
	[IdTipoPropositoContacto]	[int]				NOT NULL IDENTITY(1, 1),
	[Nombre]					[nvarchar] (16)		NOT NULL,
	[Activo]					[bit]				NOT NULL
)
GO
ALTER TABLE [dbo].[TipoPropositoContacto] ADD CONSTRAINT [IdTipoPropositoContacto] PRIMARY KEY CLUSTERED  ([IdTipoPropositoContacto])
GO