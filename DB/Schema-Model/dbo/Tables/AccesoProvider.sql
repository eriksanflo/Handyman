CREATE TABLE [dbo].[AccesoProvider]
(
	[IdAcceso]		[int]				NOT NULL IDENTITY(1, 1),
	[Provider]		[nvarchar] (64)		NOT NULL,
	[ApplicationID]	[nvarchar] (128)	NULL,
	[AppSecret]		[nvarchar] (128)	NULL,
	[AccessToken]	[nvarchar] (128)	NULL,
)
GO
ALTER TABLE [dbo].[AccesoProvider] ADD CONSTRAINT [IdAccesoProvider] PRIMARY KEY CLUSTERED ([IdAcceso])
GO