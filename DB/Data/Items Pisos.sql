use handyman

/*
	REGISTRO DE ITEMS DE PISOS
*/

--SET IDENTITY_INSERT dbo.TipoItem ON
--INSERT INTO dbo.TipoItem (IdTipoItem, Nombre, Categoria, Activo, IdTipoItemPadre)
--VALUES(301, 'COLOCACIÓN DE CERÁMICA', 1, 1, 3)
--,(302, 'COLOCACIÓN DE PISO LAMINADO', 1, 1, 3)
--,(303, 'REPARACIÓN DE PISO', 1, 1, 3)
--SET IDENTITY_INSERT dbo.TipoItem OFF

--SET IDENTITY_INSERT dbo.Item ON
--INSERT INTO dbo.Item (IdItem, IdTipoItem, Codigo, Nombre, Activo)
--VALUES 
--	(3011, 301, '301', 'Piso', 1),
--	(3012, 301, '301', 'Piso Anterior', 1),
--	(3013, 301, '301', 'Concreto (Cemento)', 1),
--	(3014, 301, '301', 'Sin Superficie', 1),
--	(3015, 301, '301', 'Regular', 1),
--	(3016, 301, '301', 'Irregular', 1),
--	(3017, 301, '301', 'MIxta', 1),

--	(3021, 302, '302', 'Piso', 1),
--	(3022, 302, '302', 'Piso Anterior', 1),
--	(3023, 302, '302', 'Concreto (Cemento)', 1),
--	(3024, 302, '302', 'Sin Superficie', 1),
--	(3025, 302, '302', '1er Nivel', 1),
--	(3026, 302, '302', '2do Nivel', 1),
--	(3027, 302, '302', 'Niveles Superiores', 1),

--	(3031, 303, '303', 'Piso', 1),
--	(3032, 303, '303', 'Piso Anterior', 1),
--	(3033, 303, '303', 'Concreto (Cemento)', 1),
--	(3034, 303, '303', 'Sin Superficie', 1),
--	(3035, 303, '303', 'Interior', 1),
--	(3036, 303, '303', 'Exterior', 1),
--	(3037, 303, '303', 'Ambos', 1),
--	(3038, 303, '303', '1er Nivel', 1),
--	(3039, 303, '303', '2do Nivel', 1),
--	(30310, 303, '303', 'Niveles Superiores', 1)
--SET IDENTITY_INSERT dbo.Item OFF

--INSERT INTO dbo.ItemCotizacion (IdItem, IdUnidadCotizacion, FechaInicial)
--VALUES
--(3011, 1, '2021-01-26 22:00:00 +06:00'),
--(3012, 1, '2021-01-26 22:00:00 +06:00'),
--(3013, 1, '2021-01-26 22:00:00 +06:00'),
--(3014, 1, '2021-01-26 22:00:00 +06:00'),
--(3015, 1, '2021-01-26 22:00:00 +06:00'),
--(3016, 1, '2021-01-26 22:00:00 +06:00'),
--(3017, 1, '2021-01-26 22:00:00 +06:00'),

--(3021, 1, '2021-01-26 22:00:00 +06:00'),
--(3022, 1, '2021-01-26 22:00:00 +06:00'),
--(3023, 1, '2021-01-26 22:00:00 +06:00'),
--(3024, 1, '2021-01-26 22:00:00 +06:00'),
--(3025, 1, '2021-01-26 22:00:00 +06:00'),
--(3026, 1, '2021-01-26 22:00:00 +06:00'),
--(3027, 1, '2021-01-26 22:00:00 +06:00'),

--(3031, 1, '2021-01-26 22:00:00 +06:00'),
--(3032, 1, '2021-01-26 22:00:00 +06:00'),
--(3033, 1, '2021-01-26 22:00:00 +06:00'),
--(3034, 1, '2021-01-26 22:00:00 +06:00'),
--(3035, 1, '2021-01-26 22:00:00 +06:00'),
--(3036, 1, '2021-01-26 22:00:00 +06:00'),
--(3037, 1, '2021-01-26 22:00:00 +06:00'),
--(3038, 1, '2021-01-26 22:00:00 +06:00'),
--(3039, 1, '2021-01-26 22:00:00 +06:00'),
--(30310, 1, '2021-01-26 22:00:00 +06:00')

--INSERT INTO dbo.ItemPrecio(IdItemCotizacion, IdItem, Desde, Hasta, FechaInicial, Precio)
--VALUES
--(39, 3011, 0.0, 3.0, '2021-01-26 22:00', 400.0),
--(39, 3011, 3.1, 1000.0, '2021-01-26 22:00', 200.0),
--(40, 3012, 0.0, 0.0, '2021-01-26 22:00', 40.0),
--(41, 3013, 0.0, 0.0, '2021-01-26 22:00', 290.0),
--(42, 3014, 0.0, 0.0, '2021-01-26 22:00', 290.0),
--(43, 3015, 0.0, 0.0, '2021-01-26 22:00', 0.0),
--(44, 3016, 0.0, 0.0, '2021-01-26 22:00', 15.0),
--(45, 3017, 0.0, 0.0, '2021-01-26 22:00', 10.0),

--(46, 3021, 0.0, 3.0, '2021-01-26 22:00', 250.0),
--(46, 3021, 3.1, 1000.0, '2021-01-26 22:00', 130.0),
--(47, 3022, 0.0, 0.0, '2021-01-26 22:00', 10.0),
--(48, 3023, 0.0, 0.0, '2021-01-26 22:00', 0.0),
--(49, 3024, 0.0, 0.0, '2021-01-26 22:00', 290.0),
--(50, 3025, 0.0, 0.0, '2021-01-26 22:00', 0.0),
--(51, 3026, 0.0, 0.0, '2021-01-26 22:00', 5.0),
--(52, 3027, 0.0, 0.0, '2021-01-26 22:00', 10.0),

--(53, 3031, 0.0, 1000.0, '2021-01-26 22:00', 700.0),
--(54, 3032, 0.0, 0.0, '2021-01-26 22:00', 60.0),
--(55, 3033, 0.0, 0.0, '2021-01-26 22:00', 300.0),
--(56, 3034, 0.0, 0.0, '2021-01-26 22:00', 290.0),
--(57, 3035, 0.0, 0.0, '2021-01-26 22:00', 0.0),
--(58, 3036, 0.0, 0.0, '2021-01-26 22:00', 5.0),
--(59, 3037, 0.0, 0.0, '2021-01-26 22:00', 3.0),
--(60, 3038, 0.0, 0.0, '2021-01-26 22:00', 0.0),
--(61, 3039, 0.0, 0.0, '2021-01-26 22:00', 5.0),
--(62, 30310, 0.0, 0.0, '2021-01-26 22:00', 10.0)

--SELECT * FROM dbo.TipoItem
--SELECT * FROM dbo.Item where IdTipoItem IN (301, 302, 303)
--SELECT * FROM dbo.ItemCotizacion where IdItemCotizacion >= 39
--SELECT * FROM dbo.ItemPrecio

--SET IDENTITY_INSERT dbo.TipoItem ON
--INSERT INTO dbo.TipoItem (IdTipoItem, Nombre, Categoria, Activo)
--VALUES(11, 'Otros', 1, 1)
--SET IDENTITY_INSERT dbo.TipoItem OFF

--SET IDENTITY_INSERT dbo.TipoItem ON
--INSERT INTO dbo.TipoItem (IdTipoItem, Nombre, Categoria, Activo, IdTipoItemPadre)
--VALUES(1101, 'OTROS', 0, 1, 11)
--SET IDENTITY_INSERT dbo.TipoItem OFF

--SET IDENTITY_INSERT dbo.Item ON
--INSERT INTO dbo.Item (IdItem, IdTipoItem, Codigo, Nombre, Activo)
--VALUES (11011, 1101, 'OTR', 'Otro', 1)
--SET IDENTITY_INSERT dbo.Item OFF

--INSERT INTO dbo.ItemCotizacion (IdItem, IdUnidadCotizacion, FechaInicial)
--VALUES
--	(11011, 2, '2021-01-26 22:00:00 +06:00')

--INSERT INTO dbo.ItemPrecio(IdItemCotizacion, IdItem, Desde, Hasta, FechaInicial, Precio)
--VALUES
--	(31, 11011, 1.0, 1.0, '2021-01-26 22:00', 0.0)

--EXEC dbo.GetSubcategoryInfo 301, ''
--select * from configuracion

--update configuracion set ActualizacionCode = '07032021234459'

--DELETE dbo.VentaRole
--DELETE dbo.VentaDetalle
--DELETE dbo.Venta

select * from dbo.VentaDetalle
