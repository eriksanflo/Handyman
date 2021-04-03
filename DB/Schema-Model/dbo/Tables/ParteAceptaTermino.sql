CREATE TABLE [dbo].[ParteAceptaTermino]
(
	[IdParte]			[uniqueidentifier] NOT NULL,
	[AceptaTerminos]	[bit] NOT NULL,
	[Fecha]				[datetime]  NOT NULL,
)
GO
ALTER TABLE [dbo].[ParteAceptaTermino] ADD CONSTRAINT [IdParteAceptaTermino] PRIMARY KEY CLUSTERED  ([IdParte])
GO
