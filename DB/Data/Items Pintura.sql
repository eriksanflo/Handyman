use handyman

/*
	REGISTRO DE ITEMS DE PINTURA
*/
--SET IDENTITY_INSERT dbo.Item ON
--INSERT INTO dbo.Item (IdItem, IdTipoItem, Codigo, Nombre, Activo)
--VALUES 
--	(2011, 201, 'PIN', 'Pintado', 1),
--	(2012, 201, 'SRU', 'Superficie Rugosa', 1),
--	(2013, 201, 'SSL', 'Superficie Semilisa', 1),
--	(2014, 201, 'SLI', 'Superficie Lisa', 1),
--	(2015, 201, 'INT', 'Interior', 1),
--	(2016, 201, 'EXT', 'Exterior', 1),
--	(2017, 201, 'AMB', 'Ambos', 1),
--	(2018, 201, '1ER', '1er Piso', 1),
--	(2019, 201, '2DO', '2do Piso', 1),
--	(20110, 201, '3RO', 'M�s de 2do Piso', 1),
--  (20111, 201, 'MPI', 'Cliente pone su pintura', 1)

/* RETIRO DE HUMEDAD Y PINTADO */
	--(2021, 202, 'PIN', 'Pintado', 1),
	--(2022, 202, 'INT', 'Interior', 1),
	--(2023, 202, 'EXT', 'Exterior', 1),
	--(2024, 202, 'AMB', 'Ambos', 1),
	--(2025, 202, '1ER', '1er Piso', 1),
	--(2026, 202, '2DO', '2do Piso', 1),
	--(2027, 202, 'NS', 'Niveles Superiores', 1),
	--(2028, 202, 'MPI', 'La pone cliente', 1)

/* IMPERMEABILIZACION */
--	(2031, 203, 'PIN', 'Pintado', 1),
--	(2032, 203, 'SRU', 'Rugosa', 1),
--	(2033, 203, 'SSL', 'Semilisa', 1),
--	(2034, 203, 'SLI', 'Lisa', 1),
--	(2035, 203, 'INT', 'Tapete', 1),
--	(2036, 203, 'EXT', 'Caucho', 1),
--	(2037, 203, 'AMB', 'Pintura', 1),
--	(2038, 203, '1ER', '1er Piso', 1),
--	(2039, 203, '2DO', '2do Piso', 1),
--	(20310, 203, 'NS', 'Superiores', 1),
--	(20311, 203, 'MPI', 'La pone cliente', 1)

--SET IDENTITY_INSERT dbo.Item OFF

--INSERT INTO dbo.ItemCotizacion (IdItem, IdUnidadCotizacion, FechaInicial)
--VALUES
--	(2011, 1, '2021-01-26 22:00:00 +06:00'),
--	(2012, 1, '2021-01-26 22:00:00 +06:00'),
--	(2013, 1, '2021-01-26 22:00:00 +06:00'),
--	(2014, 1, '2021-01-26 22:00:00 +06:00'),
--	(2015, 1, '2021-01-26 22:00:00 +06:00'),
--	(2016, 1, '2021-01-26 22:00:00 +06:00'),
--	(2017, 1, '2021-01-26 22:00:00 +06:00'),
--	(2018, 1, '2021-01-26 22:00:00 +06:00'),
--	(2019, 1, '2021-01-26 22:00:00 +06:00'),
--	(20110, 1, '2021-01-26 22:00:00 +06:00'),
--	(20111, 1, '2021-01-26 22:00:00 +06:00')

--(2021, 1, '2021-01-26 22:00:00 +06:00'),
--(2022, 1, '2021-01-26 22:00:00 +06:00'),
--(2023, 1, '2021-01-26 22:00:00 +06:00'),
--(2024, 1, '2021-01-26 22:00:00 +06:00'),
--(2025, 1, '2021-01-26 22:00:00 +06:00'),
--(2026, 1, '2021-01-26 22:00:00 +06:00'),
--(2027, 1, '2021-01-26 22:00:00 +06:00'),
--(2028, 1, '2021-01-26 22:00:00 +06:00')

	--(2031, 1, '2021-01-26 22:00:00 +06:00'),
	--(2032, 1, '2021-01-26 22:00:00 +06:00'),
	--(2033, 1, '2021-01-26 22:00:00 +06:00'),
	--(2034, 1, '2021-01-26 22:00:00 +06:00'),
	--(2035, 1, '2021-01-26 22:00:00 +06:00'),
	--(2036, 1, '2021-01-26 22:00:00 +06:00'),
	--(2037, 1, '2021-01-26 22:00:00 +06:00'),
	--(2038, 1, '2021-01-26 22:00:00 +06:00'),
	--(2039, 1, '2021-01-26 22:00:00 +06:00'),
	--(20310, 1, '2021-01-26 22:00:00 +06:00'),
	--(20311, 1, '2021-01-26 22:00:00 +06:00')

--INSERT INTO dbo.ItemPrecio(IdItemCotizacion, IdItem, Desde, Hasta, FechaInicial, Precio)
--VALUES
--	(1, 2011, 0.0, 14.0, '2021-01-26 22:00', 100.0),
--	(1, 2011, 14.1, 72.0, '2021-01-26 22:00', 75.0),
--	(1, 2011, 72.1, 1000.0, '2021-01-26 22:00', 70.0),
--	(2, 2012, 0.0, 0.0, '2021-01-26 22:00', 10.0),
--	(3, 2013, 0.0, 0.0, '2021-01-26 22:00', 3.0),
--	(4, 2014, 0.0, 0.0, '2021-01-26 22:00', 0.0),
--	(5, 2015, 0.0, 0.0, '2021-01-26 22:00', 0.0),
--	(6, 2016, 0.0, 0.0, '2021-01-26 22:00', 5.0),
--	(7, 2017, 0.0, 0.0, '2021-01-26 22:00', 3.0),
--	(8, 2018, 0.0, 0.0, '2021-01-26 22:00', 0.0),
--	(9, 2019, 0.0, 0.0, '2021-01-26 22:00', 5.0),
--	(10, 20110, 0.0, 0.0, '2021-01-26 22:00', 10.0),
	--(11, 20111, 0.0, 0.0, '2021-01-26 22:00', 25.0)

	--(12, 2021, 0.0, 14.0, '2021-01-26 22:00', 100.0),
	--(12, 2021, 14.1, 72.0, '2021-01-26 22:00', 75.0),
	--(12, 2021, 72.1, 1000.0, '2021-01-26 22:00', 70.0),
	--(13, 2022, 0.0, 0.0, '2021-01-26 22:00', 0.0),
	--(14, 2023, 0.0, 0.0, '2021-01-26 22:00', 5.0),
	--(15, 2024, 0.0, 0.0, '2021-01-26 22:00', 3.0),
	--(16, 2025, 0.0, 0.0, '2021-01-26 22:00', 0.0),
	--(17, 2026, 0.0, 0.0, '2021-01-26 22:00', 5.0),
	--(18, 2027, 0.0, 0.0, '2021-01-26 22:00', 10.0),
	--(19, 2028, 0.0, 0.0, '2021-01-26 22:00', 25.0)

	--(20, 2031, 0.0, 14.0, '2021-01-26 22:00', 100.0),
	--(20, 2031, 14.1, 72.0, '2021-01-26 22:00', 75.0),
	--(20, 2031, 72.1, 1000.0, '2021-01-26 22:00', 70.0),
	--(21, 2032, 0.0, 0.0, '2021-01-26 22:00', 10.0),
	--(22, 2033, 0.0, 0.0, '2021-01-26 22:00', 3.0),
	--(23, 2034, 0.0, 0.0, '2021-01-26 22:00', 0.0),
	--(24, 2035, 0.0, 0.0, '2021-01-26 22:00', 0.0),
	--(25, 2036, 0.0, 0.0, '2021-01-26 22:00', 5.0),
	--(26, 2037, 0.0, 0.0, '2021-01-26 22:00', 3.0),
	--(27, 2038, 0.0, 0.0, '2021-01-26 22:00', 0.0),
	--(28, 2039, 0.0, 0.0, '2021-01-26 22:00', 5.0),
	--(29, 20310, 0.0, 0.0, '2021-01-26 22:00', 10.0),
	--(30, 20311, 0.0, 0.0, '2021-01-26 22:00', 25.0)

--SELECT * FROM dbo.TipoItem
--SELECT * FROM dbo.Item
--SELECT * FROM dbo.ItemCotizacion
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

EXEC dbo.GetSubcategoryInfo 1101, ''