use handyman

/*
	REGISTRO DE ITEMS DE PLOMERIA
*/

--SET IDENTITY_INSERT dbo.TipoItem ON
--INSERT INTO dbo.TipoItem(IdTipoItem, Nombre, Categoria, Activo, IdTipoItemPadre)
--VALUES 
--(701, 'COLOCACIÓN/MANTENIMIENTO DE BOMBA', 0, 1, 7), 
--(702, 'COLOCACIÓN/MANTENIMIENTO DE LAVABO', 0, 1, 7), 
--(703, 'COLOCACIÓN/MANTENIMIENTO DE TARJA', 0, 1, 7),
--(704, 'COLOCACIÓN/MANTENIMIENTO DE REGADERA', 0, 1, 7)
--SET IDENTITY_INSERT dbo.TipoItem OFF

--SET IDENTITY_INSERT dbo.Item ON
--INSERT INTO dbo.Item (IdItem, IdTipoItem, Codigo, Nombre, Activo)
--VALUES 
--	(7011, 701, 'BOM', 'COLOCACIÓN/MANTENIMIENTO DE BOMBA', 1),
--	(7021, 702, 'LAV', 'COLOCACIÓN/MANTENIMIENTO DE LAVABO', 1),
--	(7031, 703, 'TAR', 'COLOCACIÓN/MANTENIMIENTO DE TARJA', 1),
--	(7041, 704, 'REG', 'COLOCACIÓN/MANTENIMIENTO DE REGADERA', 1)
--SET IDENTITY_INSERT dbo.Item OFF

--INSERT INTO dbo.ItemCotizacion (IdItem, IdUnidadCotizacion, FechaInicial)
--VALUES
--(7011, 3, '2021-01-26 22:00:00 +06:00'),
--(7021, 3, '2021-01-26 22:00:00 +06:00'),
--(7031, 3, '2021-01-26 22:00:00 +06:00'),
--(7041, 3, '2021-01-26 22:00:00 +06:00')

--INSERT INTO dbo.ItemPrecio(IdItemCotizacion, IdItem, Desde, Hasta, FechaInicial, Precio)
--VALUES
--	(35, 7011, 0.0, 0.0, '2021-01-26 22:00', 250.0),
--	(36, 7021, 0.0, 0.0, '2021-01-26 22:00', 250.0),
--	(37, 7031, 0.0, 0.0, '2021-01-26 22:00', 250.0),
--	(38, 7041, 0.0, 0.0, '2021-01-26 22:00', 250.0)

--select * from  dbo.TipoItem
--select * from  dbo.Item
--select * from  dbo.ItemPrecio
--select * from  dbo.ItemCotizacion

--EXEC dbo.GetSubcategoryInfo 704, ''
SELECT * FROM VentaRole
SELECT * FROM VentaDetalle
SELECT * FROM Venta

