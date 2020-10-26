CREATE TABLE [dbo].[Parte]
(
	[IdParte] [uniqueidentifier] NOT NULL
)
GO
ALTER TABLE [dbo].[Parte] ADD CONSTRAINT [IdParte] PRIMARY KEY CLUSTERED  ([IdParte])
GO
