CREATE TABLE [dbo].[PropositoContacto]
(
	[IdPropositoContacto]		[int]			NOT NULL IDENTITY(1, 1),
	[IdTipoPropositoContacto]	[int]			NOT NULL,
	[Nombre]					[nvarchar] (16)	NOT NULL,
	[Activo]					[bit]			NOT NULL
)
GO
ALTER TABLE [dbo].[PropositoContacto] ADD CONSTRAINT [IdPropositoContacto] PRIMARY KEY CLUSTERED  ([IdPropositoContacto])
GO