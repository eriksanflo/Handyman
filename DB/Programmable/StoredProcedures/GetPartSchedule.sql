CREATE OR ALTER PROCEDURE dbo.GetPartSchedule
(
	 @IdParte NVARCHAR(120)
)
AS
BEGIN
SET NOCOUNT ON; 

--declare @IdParte NVARCHAR(120) = N'0B84BF7B-6A1E-4C56-A39D-4B31132613DF'

	SELECT 
		PR.IdParte
		,PR.IdParteRole
		,_VR.IdVenta
		,_V.IdTipoVenta
		,_V.Folio
		,_VD.IdTipoItem
		,_TI.TipoItem
		,_VD.IdItem
		,_I.Item
		,_VD.IdItemPrecio
		,_VD.Cantidad
		,_VD.Precio
		,_VD.Importe
		,_VD.FechaCompromiso
		,_VD.Observaciones
	FROM 
		dbo.ParteRole AS PR
		CROSS APPLY 
		(
			SELECT 
				VR.IdVenta
			FROM
				dbo.VentaRole AS VR
			WHERE
				VR.IdParteRole = PR.IdParteRole
				AND VR.FechaFinal IS NULL
		) _VR
		CROSS APPLY 
		(
			SELECT 
				 V.IdTipoVenta
				,V.Folio
			FROM 
				dbo.Venta AS V
			WHERE
				V.IdVenta = _VR.IdVenta
		) AS _V
		CROSS APPLY
		(
			SELECT 
				 VD.IdItem
				,VD.IdTipoItem
				,VD.IdItemPrecio
				,VD.Cantidad
				,VD.Precio
				,VD.Importe
				,VD.FechaCompromiso
				,VD.Observaciones
			FROM
				dbo.VentaDetalle AS VD
			WHERE
				VD.IdVenta = _VR.IdVenta
		) AS _VD
		CROSS APPLY 
		(
			SELECT 
				TI.Nombre AS TipoItem
			FROM 
				dbo.TipoItem AS TI
			WHERE
				TI.IdTipoItem = _VD.IdTipoItem
		) _TI
		CROSS APPLY 
		(
			SELECT 
				I.Nombre AS Item
			FROM 
				dbo.Item AS I
			WHERE
				I.IdItem = _VD.IdItem
		) _I
	WHERE
		PR.IdParte = @IdParte
		AND PR.IdTipoParteRole IN (2, 3)
		AND PR.FechaFinal IS NULL
	
SET NOCOUNT OFF; 
END
GO