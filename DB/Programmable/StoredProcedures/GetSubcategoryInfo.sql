CREATE OR ALTER PROCEDURE dbo.GetSubcategoryInfo
(
	 @IdSubcategory INT
	,@LocationDate DATETIMEOFFSET(2)
)
AS
BEGIN
SET NOCOUNT ON; 

	SELECT 
		 I.IdTipoItem
		,I.IdItem
		,I.Nombre
		,_IC.IdItemCotizacion
		,_IC.IdUnidadCotizacion
		,_IP.IdItemPrecio
		,_IP.Desde
		,_IP.Hasta
		,_IP.Precio
	FROM
		dbo.Item AS I
		CROSS APPLY 
		(
			SELECT 
				 IC.IdItemCotizacion
				,IC.IdUnidadCotizacion
			FROM
				dbo.ItemCotizacion AS IC
			WHERE
				IC.IdItem = I.IdItem
				AND IC.FechaFinal IS NULL
		) _IC
		CROSS APPLY 
		(
			SELECT 
				 P.IdItemPrecio
				,P.Desde
				,P.Hasta
				,P.Precio
			FROM
				dbo.ItemPrecio AS P
			WHERE
				P.IdItem = I.IdItem
				AND P.IdItemCotizacion = _IC.IdItemCotizacion
				AND P.FechaFinal IS NULL
		) _IP
	WHERE
		I.IdTipoItem = IIF (@IdSubcategory = 0, I.IdTipoItem, @IdSubcategory)
		AND I.Activo = 1

SET NOCOUNT OFF; 
END
GO