use Handyman

/* Unidad Cotización */
SET IDENTITY_INSERT dbo.UnidadCotizacion ON
INSERT INTO dbo.UnidadCotizacion (IdUnidadCotizacion, Abreviatura, Nombre, Activo)
VALUES 
(1, 'M2', 'Metro Cuadrado', 1)
SET IDENTITY_INSERT dbo.UnidadCotizacion OFF
