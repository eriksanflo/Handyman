CREATE TABLE [dbo].[ParteRole]
(
	[IdParteRole] [int] NOT NULL IDENTITY(1, 1),
	[IdParte] [uniqueidentifier] NOT NULL,
	[IdTipoParteRole] [int] NULL,
	[FechaInicial] [date] NULL,
	[FechaFinal] [date] NULL
)
GO
ALTER TABLE [dbo].[ParteRole] ADD CONSTRAINT [IdParteRole] PRIMARY KEY CLUSTERED  ([IdParteRole])
GO
