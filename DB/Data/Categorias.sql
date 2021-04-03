use handyman

--ALTER TABLE TipoItem
--ALTER COLUMN Nombre NVARCHAR(64)

--SET IDENTITY_INSERT dbo.TipoItem ON
--INSERT INTO dbo.TipoItem(IdTipoItem, Nombre, Categoria, Activo)
--VALUES
--(1, 'Canceler�a', 1, 1)
--,(2, 'Pintura', 1, 1)
--,(3, 'Pisos', 1, 1)
--,(4, 'Cisterna', 1, 1)
--,(5, 'Electrodom�stico', 1, 1)
--,(6, 'Sanitizaci�n', 1, 1)
--,(7, 'Plomer�a', 1, 1)
--,(8, 'Cerrajer�a', 1, 1)
--,(9, 'Proyectos Nuevos', 1,, 1)
--,(10, 'Fumigaci�n', 1, 1)
--SET IDENTITY_INSERT dbo.TipoItem OFF

/*
	Subcaterias de Pintura
*/
--SET IDENTITY_INSERT dbo.TipoItem ON
--INSERT INTO dbo.TipoItem(IdTipoItem, Nombre, Categoria, Activo, IdTipoItemPadre)
--VALUES
--(201, 'PINTURA', 0, 1, 2),
--(202, 'RETIRO DE HUMEDAD Y PINTADO', 0, 1, 2),
--(203, 'IMPERMEABILIZACI�N', 0, 1, 2)
--,(204, 'OTROS', 0, 1, 2)
--SET IDENTITY_INSERT dbo.TipoItem OFF
SELECT * FROM dbo.TipoItem


