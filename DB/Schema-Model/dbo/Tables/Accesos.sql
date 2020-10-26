CREATE TABLE [dbo].[Accesos]
(
	[IdAcceso]		[int]				NOT NULL IDENTITY(1, 1),
	[IdParte]		[uniqueidentifier]	NOT NULL,
	[Usuario]		[nvarchar] (16)		NULL,
	[Password]		[nvarchar] (64)		NULL,
	[Activo]		[bit]				NULL,
)
GO
ALTER TABLE [dbo].[Accesos] ADD CONSTRAINT [IdAcceso] PRIMARY KEY CLUSTERED ([IdAcceso])
GO
