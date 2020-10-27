use Handyman

/* Categorias */
SET IDENTITY_INSERT dbo.TipoItem ON

INSERT INTO dbo.TipoItem (IdTipoItem, Nombre, Categoria, ImagenUrl, Activo)
VALUES 
(1, 'Carpintero', 1, '', 1),
(2, 'Cerrajero', 1, '', 1),
(3, 'Mecánico', 1, '', 1),
(4, 'Albañil', 1, '', 1),
(5, 'Fontanero', 1, '', 1),
(6, 'Carpintero', 1, '', 1),
(7, 'Pintor', 1, '', 1),
(8, 'Sastre', 1, '', 1),
(9, 'Exterminador', 1, '', 1)

SET IDENTITY_INSERT dbo.TipoItem OFF
