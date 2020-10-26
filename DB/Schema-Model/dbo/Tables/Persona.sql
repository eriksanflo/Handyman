CREATE TABLE [dbo].[Persona]
(
	[IdParte] [uniqueidentifier] NOT NULL,
	[Codigo] [nvarchar] (8) NULL,
	[Paterno] [nvarchar] (64) NULL,
	[Materno] [nvarchar] (64) NULL,
	[NombrePrimario] [nvarchar] (96) NULL,
	[NombreSecundario] [nvarchar] (64) NULL,
	[FechaNacimiento] [date] NULL,
	[LugarNacimiento] [nvarchar] (128) NULL,
	[FechaCreacion] datetimeoffset(2) NULL,
	[FechaModificacion] datetimeoffset(2) NULL,
	[TituloActual] [nvarchar] (32) NULL,
	[Genero] [char] (1) NULL,
	[Estatura] [decimal] (17, 2) NULL,
	[Peso] [decimal] (17, 2) NULL,
	[Activo] [bit] NULL,
)
GO
ALTER TABLE [dbo].[Persona] ADD CONSTRAINT [IdPersona] PRIMARY KEY CLUSTERED  ([IdParte])
GO
GO
