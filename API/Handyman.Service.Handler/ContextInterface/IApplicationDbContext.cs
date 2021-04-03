using Handyman.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Handyman.Service.Handler.ContextInterface
{
    public interface IApplicationDbContext
    {
        DbSet<Configuracion> Configuracion { get; set; }
        DbSet<AccesoProvider> AccesoProvider { get; set; }
        DbSet<Accesos> Accesos { get; set; }
        DbSet<AsignacionParteItem> AsignacionParteItem { get; set; }
        DbSet<Banco> Banco { get; set; }
        DbSet<CodigoPostal> CodigoPostal { get; set; }
        DbSet<CuentaBancaria> CuentaBancaria { get; set; }
        DbSet<DireccionPostalParte> DireccionPostalParte { get; set; }
        DbSet<EstatusPago> EstatusPago { get; set; }
        DbSet<EstatusPersona> EstatusPersona { get; set; }
        DbSet<EstatusVenta> EstatusVenta { get; set; }
        DbSet<Item> Item { get; set; }
        DbSet<ItemCotizacion> ItemCotizacion { get; set; }
        DbSet<ItemPrecio> ItemPrecio { get; set; }
        DbSet<ItemServicio> ItemServicio { get; set; }
        DbSet<MedioContactoParte> MedioContactoParte { get; set; }
        DbSet<MetodoPago> MetodoPago { get; set; }
        DbSet<Organizacion> Organizacion { get; set; }
        DbSet<Pago> Pago { get; set; }
        DbSet<PagoEstatus> PagoEstatus { get; set; }
        DbSet<PagoRole> PagoRole { get; set; }
        DbSet<Parte> Parte { get; set; }
        DbSet<ParteRole> ParteRole { get; set; }
        DbSet<Persona> Persona { get; set; }
        DbSet<PropositoContacto> PropositoContacto { get; set; }
        DbSet<RedTarjeta> RedTarjeta { get; set; }
        DbSet<TarjetaCliente> TarjetaCliente { get; set; }
        DbSet<TipoItem> TipoItem { get; set; }
        DbSet<TipoParteRole> TipoParteRole { get; set; }
        DbSet<TipoPropositoContacto> TipoPropositoContacto { get; set; }
        DbSet<TipoTarjeta> TipoTarjeta { get; set; }
        DbSet<TipoTarjetaCredito> TipoTarjetaCredito { get; set; }
        DbSet<TipoVenta> TipoVenta { get; set; }
        DbSet<Transferencia> Transferencia { get; set; }
        DbSet<UnidadCotizacion> UnidadCotizacion { get; set; }
        DbSet<Venta> Venta { get; set; }
        DbSet<VentaDetalle> VentaDetalle { get; set; }
        DbSet<VentaDetalleExtra> VentaDetalleExtra { get; set; }
        DbSet<VentaDetalleImagen> VentaDetalleImagen { get; set; }
        DbSet<VentaDetalleRole> VentaDetalleRole { get; set; }
        DbSet<VentaEstatus> VentaEstatus { get; set; }
        DbSet<VentaEvaluacion> VentaEvaluacion { get; set; }
        DbSet<VentaRole> VentaRole { get; set; }
        DbSet<Cargo> Cargo { get; set; }
        DbSet<TipoItemComision> TipoItemComision { get; set; }
        DbSet<VentaImagen> VentaImagen { get; set; }
        DbSet<ParteAceptaTermino> ParteAceptaTermino { get; set; }

        Task<int> SaveChangesAsync();
    }
}
