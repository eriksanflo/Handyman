ALTER TABLE [dbo].[Accesos] ADD CONSTRAINT [fk_Accesos_Parte_1] FOREIGN KEY ([IdParte]) REFERENCES [dbo].[Parte]([IdParte]) ON UPDATE NO ACTION ON DELETE NO ACTION;
ALTER TABLE [dbo].[AccesoProvider] ADD CONSTRAINT [fk_AccesoProvider_Accesos_1] FOREIGN KEY ([IdAcceso]) REFERENCES [dbo].[Accesos]([IdAcceso]) ON UPDATE NO ACTION ON DELETE NO ACTION;

ALTER TABLE [dbo].[DireccionPostalParte] ADD CONSTRAINT [fk_DireccionPostalParte_TipoPropositoContacto_1] FOREIGN KEY ([IdTipoPropositoContacto]) REFERENCES [dbo].[TipoPropositoContacto]([IdTipoPropositoContacto]) ON UPDATE NO ACTION ON DELETE NO ACTION;
ALTER TABLE [dbo].[DireccionPostalParte] ADD CONSTRAINT [fk_DireccionPostalParte_PropositoContacto_1] FOREIGN KEY ([IdPropositoContacto]) REFERENCES [dbo].[PropositoContacto]([IdPropositoContacto]) ON UPDATE NO ACTION ON DELETE NO ACTION;
ALTER TABLE [dbo].[DireccionPostalParte] ADD CONSTRAINT [fk_DireccionPostalParte_CodigoPostal_1] FOREIGN KEY ([IdCodigoPostal]) REFERENCES [dbo].[CodigoPostal]([IdCodigoPostal]) ON UPDATE NO ACTION ON DELETE NO ACTION;
ALTER TABLE [dbo].[DireccionPostalParte] ADD CONSTRAINT [fk_DireccionPostalParte_Parte_1] FOREIGN KEY ([IdParte]) REFERENCES [dbo].[Parte]([IdParte]) ON UPDATE NO ACTION ON DELETE NO ACTION;

ALTER TABLE [dbo].[Item] ADD CONSTRAINT [fk_Item_TipoItem_1] FOREIGN KEY ([IdTipoItem]) REFERENCES [dbo].[TipoItem]([IdTipoItem]) ON UPDATE NO ACTION ON DELETE NO ACTION;
ALTER TABLE [dbo].[ItemCotizacion] ADD CONSTRAINT [fk_ItemCotizacion_Item_1] FOREIGN KEY ([IdItem]) REFERENCES [dbo].[Item]([IdItem]) ON UPDATE NO ACTION ON DELETE NO ACTION;
ALTER TABLE [dbo].[ItemCotizacion] ADD CONSTRAINT [fk_ItemCotizacion_UnidadCotizacion_1] FOREIGN KEY ([IdUnidadCotizacion]) REFERENCES [dbo].[UnidadCotizacion]([IdUnidadCotizacion]) ON UPDATE NO ACTION ON DELETE NO ACTION;
ALTER TABLE [dbo].[ItemPrecio] ADD CONSTRAINT [fk_ItemPrecio_Item_1] FOREIGN KEY ([IdItem]) REFERENCES [dbo].[Item]([IdItem]) ON UPDATE NO ACTION ON DELETE NO ACTION;
ALTER TABLE [dbo].[ItemPrecio] ADD CONSTRAINT [fk_ItemPrecio_ItemCotizacion_1] FOREIGN KEY ([IdItemCotizacion]) REFERENCES [dbo].[ItemCotizacion]([IdItemCotizacion]) ON UPDATE NO ACTION ON DELETE NO ACTION;
ALTER TABLE [dbo].[ItemServicio] ADD CONSTRAINT [fk_ItemServicio_Item_1] FOREIGN KEY ([IdItem]) REFERENCES [dbo].[Item]([IdItem]) ON UPDATE NO ACTION ON DELETE NO ACTION;

ALTER TABLE [dbo].[MedioContactoParte] ADD CONSTRAINT [fk_MedioContactoParte_Parte_1] FOREIGN KEY ([IdParte]) REFERENCES [dbo].[Parte]([IdParte]) ON UPDATE NO ACTION ON DELETE NO ACTION;
ALTER TABLE [dbo].[MedioContactoParte] ADD CONSTRAINT [fk_MedioContactoParte_PropositoContacto_1] FOREIGN KEY ([IdPropositoContacto]) REFERENCES [dbo].[PropositoContacto]([IdPropositoContacto]) ON UPDATE NO ACTION ON DELETE NO ACTION;

ALTER TABLE [dbo].[Organizacion] ADD CONSTRAINT [fk_Organizacion_Parte_1] FOREIGN KEY ([IdParte]) REFERENCES [dbo].[Parte]([IdParte]) ON UPDATE NO ACTION ON DELETE NO ACTION;

ALTER TABLE [dbo].[Pago] ADD CONSTRAINT [fk_Pago_TarjetaCliente_1] FOREIGN KEY ([IdTarjetaCliente]) REFERENCES [dbo].[TarjetaCliente]([IdTarjetaCliente]) ON UPDATE NO ACTION ON DELETE NO ACTION;
ALTER TABLE [dbo].[Pago] ADD CONSTRAINT [fk_Pago_Parte_1] FOREIGN KEY ([IdCliente]) REFERENCES [dbo].[Parte]([IdParte]) ON UPDATE NO ACTION ON DELETE NO ACTION;
ALTER TABLE [dbo].[Pago] ADD CONSTRAINT [fk_Pago_Transferencia_1] FOREIGN KEY ([IdTransferencia]) REFERENCES [dbo].[Transferencia]([IdTransferencia]) ON UPDATE NO ACTION ON DELETE NO ACTION;

ALTER TABLE [dbo].[PagoEstatus] ADD CONSTRAINT [fk_PagoEstatus_ParteRole_1] FOREIGN KEY ([IdParteRole]) REFERENCES [dbo].[ParteRole]([IdParteRole]) ON UPDATE NO ACTION ON DELETE NO ACTION;
ALTER TABLE [dbo].[PagoEstatus] ADD CONSTRAINT [fk_PagoEstatus_EstatusPago_1] FOREIGN KEY ([IdEstatusPago]) REFERENCES [dbo].[EstatusPago]([IdEstatusPago]) ON UPDATE NO ACTION ON DELETE NO ACTION;
ALTER TABLE [dbo].[PagoEstatus] ADD CONSTRAINT [fk_PagoEstatus_Pago_1] FOREIGN KEY ([IdPago]) REFERENCES [dbo].[Pago]([IdPago]) ON UPDATE NO ACTION ON DELETE NO ACTION;

ALTER TABLE [dbo].[PagoRole] ADD CONSTRAINT [fk_PagoRole_Pago_1] FOREIGN KEY ([IdPago]) REFERENCES [dbo].[Pago]([IdPago]) ON UPDATE NO ACTION ON DELETE NO ACTION;
ALTER TABLE [dbo].[PagoRole] ADD CONSTRAINT [fk_PagoRole_ParteRole_1] FOREIGN KEY ([IdParteRole]) REFERENCES [dbo].[ParteRole]([IdParteRole]) ON UPDATE NO ACTION ON DELETE NO ACTION;
ALTER TABLE [dbo].[PagoRole] ADD CONSTRAINT [fk_PagoRole_TipoParteRole_1] FOREIGN KEY ([IdTipoParteRole]) REFERENCES [dbo].[TipoParteRole]([IdTipoParteRole]) ON UPDATE NO ACTION ON DELETE NO ACTION;

ALTER TABLE [dbo].[ParteRole] ADD CONSTRAINT [fk_ParteRole_Parte_1] FOREIGN KEY ([IdParte]) REFERENCES [dbo].[Parte]([IdParte]) ON UPDATE NO ACTION ON DELETE NO ACTION;
ALTER TABLE [dbo].[ParteRole] ADD CONSTRAINT [fk_ParteRole_TipoParteRole_1] FOREIGN KEY ([IdTipoParteRole]) REFERENCES [dbo].[TipoParteRole]([IdTipoParteRole]) ON UPDATE NO ACTION ON DELETE NO ACTION;

ALTER TABLE [dbo].[Persona] ADD CONSTRAINT [fk_Persona_Parte_1] FOREIGN KEY ([IdParte]) REFERENCES [dbo].[Parte]([IdParte]) ON UPDATE NO ACTION ON DELETE NO ACTION;

ALTER TABLE [dbo].[PropositoContacto] ADD CONSTRAINT [fk_PropositoContacto_TipoPropositoContacto_1] FOREIGN KEY ([IdTipoPropositoContacto]) REFERENCES [dbo].[TipoPropositoContacto]([IdTipoPropositoContacto]) ON UPDATE NO ACTION ON DELETE NO ACTION;

ALTER TABLE [dbo].[TarjetaCliente] ADD CONSTRAINT [fk_TarjetaCliente_Parte_1] FOREIGN KEY ([IdParte]) REFERENCES [dbo].[Parte]([IdParte]) ON UPDATE NO ACTION ON DELETE NO ACTION;
ALTER TABLE [dbo].[TarjetaCliente] ADD CONSTRAINT [fk_TarjetaCliente_TipoTarjeta_1] FOREIGN KEY ([IdTipoTarjeta]) REFERENCES [dbo].[TipoTarjeta]([IdTipoTarjeta]) ON UPDATE NO ACTION ON DELETE NO ACTION;
ALTER TABLE [dbo].[TarjetaCliente] ADD CONSTRAINT [fk_TarjetaCliente_RedTarjeta_1] FOREIGN KEY ([IdRedTarjeta]) REFERENCES [dbo].[RedTarjeta]([IdRedTarjeta]) ON UPDATE NO ACTION ON DELETE NO ACTION;
ALTER TABLE [dbo].[TarjetaCliente] ADD CONSTRAINT [fk_TarjetaCliente_Banco_1] FOREIGN KEY ([IdBanco]) REFERENCES [dbo].[Banco]([IdBanco]) ON UPDATE NO ACTION ON DELETE NO ACTION;

ALTER TABLE [dbo].[VentaDetalle] ADD CONSTRAINT [fk_VentaDetalle_Venta_1] FOREIGN KEY ([IdVenta]) REFERENCES [dbo].[Venta]([IdVenta]) ON UPDATE NO ACTION ON DELETE NO ACTION;
ALTER TABLE [dbo].[VentaDetalle] ADD CONSTRAINT [fk_VentaDetalle_Item_1] FOREIGN KEY ([IdItem]) REFERENCES [dbo].[Item]([IdItem]) ON UPDATE NO ACTION ON DELETE NO ACTION;
ALTER TABLE [dbo].[VentaDetalle] ADD CONSTRAINT [fk_VentaDetalle_TipoItem_1] FOREIGN KEY ([IdTipoItem]) REFERENCES [dbo].[TipoItem]([IdTipoItem]) ON UPDATE NO ACTION ON DELETE NO ACTION;
ALTER TABLE [dbo].[VentaDetalle] ADD CONSTRAINT [fk_VentaDetalle_ItemPrecio_1] FOREIGN KEY ([IdItemPrecio]) REFERENCES [dbo].[ItemPrecio]([IdItemPrecio]) ON UPDATE NO ACTION ON DELETE NO ACTION;
ALTER TABLE [dbo].[VentaDetalle] ADD CONSTRAINT [fk_VentaDetalle_Pago_1] FOREIGN KEY ([IdPago]) REFERENCES [dbo].[Pago]([IdPago]) ON UPDATE NO ACTION ON DELETE NO ACTION;

ALTER TABLE [dbo].[VentaEstatus] ADD CONSTRAINT [fk_VentaEstatus_Venta_1] FOREIGN KEY ([IdVenta]) REFERENCES [dbo].[Venta]([IdVenta]) ON UPDATE NO ACTION ON DELETE NO ACTION;
ALTER TABLE [dbo].[VentaEstatus] ADD CONSTRAINT [fk_VentaEstatus_VentaDetalle_1] FOREIGN KEY ([IdVentaDetalle]) REFERENCES [dbo].[VentaDetalle]([IdVentaDetalle]) ON UPDATE NO ACTION ON DELETE NO ACTION;
ALTER TABLE [dbo].[VentaEstatus] ADD CONSTRAINT [fk_VentaEstatus_EstatusVenta_1] FOREIGN KEY ([IdEstatusVenta]) REFERENCES [dbo].[EstatusVenta]([IdEstatusVenta]) ON UPDATE NO ACTION ON DELETE NO ACTION;
ALTER TABLE [dbo].[VentaEstatus] ADD CONSTRAINT [fk_VentaEstatus_ParteRole_1] FOREIGN KEY ([IdParteRole]) REFERENCES [dbo].[ParteRole]([IdParteRole]) ON UPDATE NO ACTION ON DELETE NO ACTION;

ALTER TABLE [dbo].[VentaEvaluacion] ADD CONSTRAINT [fk_VentaEvaluacion_Venta_1] FOREIGN KEY ([IdVenta]) REFERENCES [dbo].[Venta]([IdVenta]) ON UPDATE NO ACTION ON DELETE NO ACTION;

ALTER TABLE [dbo].[VentaDetalleExtra] ADD CONSTRAINT [fk_VentaDetalleExtra_VentaDetalle_1] FOREIGN KEY ([IdVentaDetalle]) REFERENCES [dbo].[VentaDetalle]([IdVentaDetalle]) ON UPDATE NO ACTION ON DELETE NO ACTION;

ALTER TABLE [dbo].[VentaDetalleImagen] ADD CONSTRAINT [fk_VentaDetalleImagen_VentaDetalle_1] FOREIGN KEY ([IdVentaDetalle]) REFERENCES [dbo].[VentaDetalle]([IdVentaDetalle]) ON UPDATE NO ACTION ON DELETE NO ACTION;

ALTER TABLE [dbo].[VentaRole] ADD CONSTRAINT [fk_VentaRole_Venta_1] FOREIGN KEY ([IdVenta]) REFERENCES [dbo].[Venta]([IdVenta]) ON UPDATE NO ACTION ON DELETE NO ACTION;
ALTER TABLE [dbo].[VentaRole] ADD CONSTRAINT [fk_VentaRole_ParteRole_1] FOREIGN KEY ([IdParteRole]) REFERENCES [dbo].[ParteRole]([IdParteRole]) ON UPDATE NO ACTION ON DELETE NO ACTION;
ALTER TABLE [dbo].[VentaRole] ADD CONSTRAINT [fk_VentaRole_TipoParteRole_1] FOREIGN KEY ([IdTipoParteRole]) REFERENCES [dbo].[TipoParteRole]([IdTipoParteRole]) ON UPDATE NO ACTION ON DELETE NO ACTION;

ALTER TABLE [dbo].[CuentaBancaria] ADD CONSTRAINT [fk_CuentaBancaria_Parte_1] FOREIGN KEY ([IdParte]) REFERENCES [dbo].[Parte]([IdParte]) ON UPDATE NO ACTION ON DELETE NO ACTION;
ALTER TABLE [dbo].[CuentaBancaria] ADD CONSTRAINT [fk_CuentaBancaria_Banco_1] FOREIGN KEY ([IdBanco]) REFERENCES [dbo].[Banco]([IdBanco]) ON UPDATE NO ACTION ON DELETE NO ACTION;

ALTER TABLE [dbo].[AsignacionParteItem] ADD CONSTRAINT [fk_AsignacionParteItem_Parte_1] FOREIGN KEY ([IdParte]) REFERENCES [dbo].[Parte]([IdParte]) ON UPDATE NO ACTION ON DELETE NO ACTION;
ALTER TABLE [dbo].[AsignacionParteItem] ADD CONSTRAINT [fk_AsignacionParteItem_Item_1] FOREIGN KEY ([IdItem]) REFERENCES [dbo].[Item]([IdItem]) ON UPDATE NO ACTION ON DELETE NO ACTION;
