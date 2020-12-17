using Handyman.Domain.Models;
using Handyman.Service.Handler.ContextInterface;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Handyman.Persistence
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public virtual DbSet<AccesoProvider> AccesoProvider { get; set; }
        public virtual DbSet<Accesos> Accesos { get; set; }
        public virtual DbSet<AsignacionParteItem> AsignacionParteItem { get; set; }
        public virtual DbSet<Banco> Banco { get; set; }
        public virtual DbSet<CodigoPostal> CodigoPostal { get; set; }
        public virtual DbSet<CuentaBancaria> CuentaBancaria { get; set; }
        public virtual DbSet<DireccionPostalParte> DireccionPostalParte { get; set; }
        public virtual DbSet<EstatusPago> EstatusPago { get; set; }
        public virtual DbSet<EstatusPersona> EstatusPersona { get; set; }
        public virtual DbSet<EstatusVenta> EstatusVenta { get; set; }
        public virtual DbSet<Item> Item { get; set; }
        public virtual DbSet<ItemCotizacion> ItemCotizacion { get; set; }
        public virtual DbSet<ItemPrecio> ItemPrecio { get; set; }
        public virtual DbSet<ItemServicio> ItemServicio { get; set; }
        public virtual DbSet<MedioContactoParte> MedioContactoParte { get; set; }
        public virtual DbSet<MetodoPago> MetodoPago { get; set; }
        public virtual DbSet<Organizacion> Organizacion { get; set; }
        public virtual DbSet<Pago> Pago { get; set; }
        public virtual DbSet<PagoEstatus> PagoEstatus { get; set; }
        public virtual DbSet<PagoRole> PagoRole { get; set; }
        public virtual DbSet<Parte> Parte { get; set; }
        public virtual DbSet<ParteRole> ParteRole { get; set; }
        public virtual DbSet<Persona> Persona { get; set; }
        public virtual DbSet<PropositoContacto> PropositoContacto { get; set; }
        public virtual DbSet<RedTarjeta> RedTarjeta { get; set; }
        public virtual DbSet<TarjetaCliente> TarjetaCliente { get; set; }
        public virtual DbSet<TipoItem> TipoItem { get; set; }
        public virtual DbSet<TipoParteRole> TipoParteRole { get; set; }
        public virtual DbSet<TipoPropositoContacto> TipoPropositoContacto { get; set; }
        public virtual DbSet<TipoTarjeta> TipoTarjeta { get; set; }
        public virtual DbSet<TipoTarjetaCredito> TipoTarjetaCredito { get; set; }
        public virtual DbSet<TipoVenta> TipoVenta { get; set; }
        public virtual DbSet<Transferencia> Transferencia { get; set; }
        public virtual DbSet<UnidadCotizacion> UnidadCotizacion { get; set; }
        public virtual DbSet<Venta> Venta { get; set; }
        public virtual DbSet<VentaDetalle> VentaDetalle { get; set; }
        public virtual DbSet<VentaDetalleExtra> VentaDetalleExtra { get; set; }
        public virtual DbSet<VentaDetalleImagen> VentaDetalleImagen { get; set; }
        public virtual DbSet<VentaDetalleRole> VentaDetalleRole { get; set; }
        public virtual DbSet<VentaEstatus> VentaEstatus { get; set; }
        public virtual DbSet<VentaEvaluacion> VentaEvaluacion { get; set; }
        public virtual DbSet<VentaRole> VentaRole { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccesoProvider>(entity =>
            {
                entity.HasKey(e => e.IdAcceso)
                    .HasName("IdAccesoProvider");

                entity.Property(e => e.IdAcceso).ValueGeneratedOnAdd();

                entity.Property(e => e.AccessToken).HasMaxLength(128);

                entity.Property(e => e.AppSecret).HasMaxLength(128);

                entity.Property(e => e.ApplicationId)
                    .HasColumnName("ApplicationID")
                    .HasMaxLength(128);

                entity.Property(e => e.Provider)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.HasOne(d => d.IdAccesoNavigation)
                    .WithOne(p => p.AccesoProvider)
                    .HasForeignKey<AccesoProvider>(d => d.IdAcceso)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_AccesoProvider_Accesos_1");
            });

            modelBuilder.Entity<Accesos>(entity =>
            {
                entity.HasKey(e => e.IdAcceso)
                    .HasName("IdAcceso");

                entity.Property(e => e.Password).HasMaxLength(64);

                entity.Property(e => e.Usuario).HasMaxLength(16);

                entity.HasOne(d => d.IdParteNavigation)
                    .WithMany(p => p.Accesos)
                    .HasForeignKey(d => d.IdParte)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Accesos_Parte_1");
            });

            modelBuilder.Entity<AsignacionParteItem>(entity =>
            {
                entity.HasKey(e => e.IdAsignacionParteItem)
                    .HasName("IdAsignacionParteItem");

                entity.Property(e => e.FechaFinal).HasColumnType("datetimeoffset(2)");

                entity.Property(e => e.FechaInicial).HasColumnType("datetimeoffset(2)");

                entity.Property(e => e.ImporteIncremento).HasColumnType("decimal(17, 2)");

                entity.Property(e => e.TipoEmergente).HasMaxLength(8);

                entity.HasOne(d => d.IdItemNavigation)
                    .WithMany(p => p.AsignacionParteItem)
                    .HasForeignKey(d => d.IdItem)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_AsignacionParteItem_Item_1");

                entity.HasOne(d => d.IdParteNavigation)
                    .WithMany(p => p.AsignacionParteItem)
                    .HasForeignKey(d => d.IdParte)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_AsignacionParteItem_Parte_1");
            });

            modelBuilder.Entity<Banco>(entity =>
            {
                entity.HasKey(e => e.IdBanco)
                    .HasName("IdBanco");

                entity.Property(e => e.Codigo).HasMaxLength(16);

                entity.Property(e => e.Nombre).HasMaxLength(255);
            });

            modelBuilder.Entity<CodigoPostal>(entity =>
            {
                entity.HasKey(e => e.IdCodigoPostal)
                    .HasName("IdCodigoPostal");

                entity.Property(e => e.CodigoPostal1)
                    .IsRequired()
                    .HasColumnName("CodigoPostal")
                    .HasMaxLength(16);

                entity.Property(e => e.Pais)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.Property(e => e.Region1)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.Property(e => e.Region2)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Region3).HasMaxLength(256);

                entity.Property(e => e.Region4).HasMaxLength(256);
            });

            modelBuilder.Entity<CuentaBancaria>(entity =>
            {
                entity.HasKey(e => e.IdCuentaBancaria)
                    .HasName("IdCuentaBancaria");

                entity.Property(e => e.Clabe)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.Numero)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.HasOne(d => d.IdBancoNavigation)
                    .WithMany(p => p.CuentaBancaria)
                    .HasForeignKey(d => d.IdBanco)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_CuentaBancaria_Banco_1");

                entity.HasOne(d => d.IdParteNavigation)
                    .WithMany(p => p.CuentaBancaria)
                    .HasForeignKey(d => d.IdParte)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_CuentaBancaria_Parte_1");
            });

            modelBuilder.Entity<DireccionPostalParte>(entity =>
            {
                entity.HasKey(e => e.IdDireccionPostalParte)
                    .HasName("IdDireccionPostalParte");

                entity.Property(e => e.Calle)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.EntreCalle).HasMaxLength(128);

                entity.Property(e => e.NumeroExterior)
                    .IsRequired()
                    .HasMaxLength(32);

                entity.Property(e => e.NumeroInterior).HasMaxLength(32);

                entity.Property(e => e.Referencia).HasMaxLength(128);

                entity.Property(e => e.Ycalle)
                    .HasColumnName("YCalle")
                    .HasMaxLength(128);

                entity.HasOne(d => d.IdCodigoPostalNavigation)
                    .WithMany(p => p.DireccionPostalParte)
                    .HasForeignKey(d => d.IdCodigoPostal)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_DireccionPostalParte_CodigoPostal_1");

                entity.HasOne(d => d.IdParteNavigation)
                    .WithMany(p => p.DireccionPostalParte)
                    .HasForeignKey(d => d.IdParte)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_DireccionPostalParte_Parte_1");

                entity.HasOne(d => d.IdPropositoContactoNavigation)
                    .WithMany(p => p.DireccionPostalParte)
                    .HasForeignKey(d => d.IdPropositoContacto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_DireccionPostalParte_PropositoContacto_1");

                entity.HasOne(d => d.IdTipoPropositoContactoNavigation)
                    .WithMany(p => p.DireccionPostalParte)
                    .HasForeignKey(d => d.IdTipoPropositoContacto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_DireccionPostalParte_TipoPropositoContacto_1");
            });

            modelBuilder.Entity<EstatusPago>(entity =>
            {
                entity.HasKey(e => e.IdEstatusPago)
                    .HasName("IdEstatusPago");

                entity.Property(e => e.Nombre).HasMaxLength(64);

                entity.Property(e => e.TipoEstatus).HasMaxLength(16);
            });

            modelBuilder.Entity<EstatusPersona>(entity =>
            {
                entity.HasKey(e => e.IdEstatusPersona)
                    .HasName("IdEstatusPersona");

                entity.Property(e => e.Codigo).HasMaxLength(8);

                entity.Property(e => e.Nombre).HasMaxLength(128);
            });

            modelBuilder.Entity<EstatusVenta>(entity =>
            {
                entity.HasKey(e => e.IdEstatusVenta)
                    .HasName("IdEstatusVenta");

                entity.Property(e => e.Nombre).HasMaxLength(64);

                entity.Property(e => e.TipoEstatus).HasMaxLength(16);
            });

            modelBuilder.Entity<Item>(entity =>
            {
                entity.HasKey(e => e.IdItem)
                    .HasName("IdItem");

                entity.Property(e => e.Codigo).HasMaxLength(16);

                entity.Property(e => e.Nombre).HasMaxLength(255);

                entity.HasOne(d => d.IdTipoItemNavigation)
                    .WithMany(p => p.Item)
                    .HasForeignKey(d => d.IdTipoItem)
                    .HasConstraintName("fk_Item_TipoItem_1");
            });

            modelBuilder.Entity<ItemCotizacion>(entity =>
            {
                entity.HasKey(e => e.IdItemCotizacion)
                    .HasName("IdItemCotizacion");

                entity.HasOne(d => d.IdItemNavigation)
                    .WithMany(p => p.ItemCotizacion)
                    .HasForeignKey(d => d.IdItem)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ItemCotizacion_Item_1");

                entity.HasOne(d => d.IdUnidadCotizacionNavigation)
                    .WithMany(p => p.ItemCotizacion)
                    .HasForeignKey(d => d.IdUnidadCotizacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ItemCotizacion_UnidadCotizacion_1");
            });

            modelBuilder.Entity<ItemPrecio>(entity =>
            {
                entity.HasKey(e => e.IdItemPrecio)
                    .HasName("IdItemPrecio");

                entity.Property(e => e.FechaFinal).HasColumnType("datetime");

                entity.Property(e => e.FechaInicial).HasColumnType("datetime");

                entity.Property(e => e.Precio).HasColumnType("decimal(17, 2)");

                entity.HasOne(d => d.IdItemNavigation)
                    .WithMany(p => p.ItemPrecio)
                    .HasForeignKey(d => d.IdItem)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ItemPrecio_Item_1");

                entity.HasOne(d => d.IdItemCotizacionNavigation)
                    .WithMany(p => p.ItemPrecio)
                    .HasForeignKey(d => d.IdItemCotizacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ItemPrecio_ItemCotizacion_1");
            });

            modelBuilder.Entity<ItemServicio>(entity =>
            {
                entity.HasKey(e => e.IdItem)
                    .HasName("IdItemServicio");

                entity.Property(e => e.IdItem).ValueGeneratedNever();

                entity.Property(e => e.ImagenUrl).HasMaxLength(256);

                entity.HasOne(d => d.IdItemNavigation)
                    .WithOne(p => p.ItemServicio)
                    .HasForeignKey<ItemServicio>(d => d.IdItem)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ItemServicio_Item_1");
            });

            modelBuilder.Entity<MedioContactoParte>(entity =>
            {
                entity.HasKey(e => e.IdMedioContactoParte)
                    .HasName("IdMedioContactoParte");

                entity.Property(e => e.Contacto)
                    .IsRequired()
                    .HasMaxLength(64);

                entity.HasOne(d => d.IdParteNavigation)
                    .WithMany(p => p.MedioContactoParte)
                    .HasForeignKey(d => d.IdParte)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_MedioContactoParte_Parte_1");

                entity.HasOne(d => d.IdPropositoContactoNavigation)
                    .WithMany(p => p.MedioContactoParte)
                    .HasForeignKey(d => d.IdPropositoContacto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_MedioContactoParte_PropositoContacto_1");
            });

            modelBuilder.Entity<MetodoPago>(entity =>
            {
                entity.HasKey(e => e.IdMetodoPago)
                    .HasName("IdMetodoPago");

                entity.Property(e => e.Activo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Descripcion).HasMaxLength(256);

                entity.Property(e => e.Nombre).HasMaxLength(64);
            });

            modelBuilder.Entity<Organizacion>(entity =>
            {
                entity.HasKey(e => e.IdParte)
                    .HasName("IdOrganizacion");

                entity.Property(e => e.IdParte).ValueGeneratedNever();

                entity.Property(e => e.Nombre).HasMaxLength(255);

                entity.HasOne(d => d.IdParteNavigation)
                    .WithOne(p => p.Organizacion)
                    .HasForeignKey<Organizacion>(d => d.IdParte)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Organizacion_Parte_1");
            });

            modelBuilder.Entity<Pago>(entity =>
            {
                entity.HasKey(e => e.IdPago)
                    .HasName("IdPago");

                entity.Property(e => e.Estatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaRegistro).HasColumnType("datetimeoffset(2)");

                entity.Property(e => e.Folio)
                    .IsRequired()
                    .HasMaxLength(16);

                entity.Property(e => e.Importe).HasColumnType("decimal(17, 2)");

                entity.Property(e => e.Observaciones).HasMaxLength(256);

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.Pago)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Pago_Parte_1");

                entity.HasOne(d => d.IdTarjetaClienteNavigation)
                    .WithMany(p => p.Pago)
                    .HasForeignKey(d => d.IdTarjetaCliente)
                    .HasConstraintName("fk_Pago_TarjetaCliente_1");

                entity.HasOne(d => d.IdTransferenciaNavigation)
                    .WithMany(p => p.Pago)
                    .HasForeignKey(d => d.IdTransferencia)
                    .HasConstraintName("fk_Pago_Transferencia_1");
            });

            modelBuilder.Entity<PagoEstatus>(entity =>
            {
                entity.HasKey(e => e.IdPagoEstatus)
                    .HasName("IdPagoEstatus");

                entity.Property(e => e.FechaRegistro).HasColumnType("datetimeoffset(2)");

                entity.HasOne(d => d.IdEstatusPagoNavigation)
                    .WithMany(p => p.PagoEstatus)
                    .HasForeignKey(d => d.IdEstatusPago)
                    .HasConstraintName("fk_PagoEstatus_EstatusPago_1");

                entity.HasOne(d => d.IdPagoNavigation)
                    .WithMany(p => p.PagoEstatus)
                    .HasForeignKey(d => d.IdPago)
                    .HasConstraintName("fk_PagoEstatus_Pago_1");

                entity.HasOne(d => d.IdParteRoleNavigation)
                    .WithMany(p => p.PagoEstatus)
                    .HasForeignKey(d => d.IdParteRole)
                    .HasConstraintName("fk_PagoEstatus_ParteRole_1");
            });

            modelBuilder.Entity<PagoRole>(entity =>
            {
                entity.HasKey(e => e.IdPagoRole)
                    .HasName("IdPagoRole");

                entity.Property(e => e.FechaFinal).HasColumnType("date");

                entity.Property(e => e.FechaInicial).HasColumnType("date");

                entity.Property(e => e.FechaRegistro).HasColumnType("datetimeoffset(2)");

                entity.HasOne(d => d.IdPagoNavigation)
                    .WithMany(p => p.PagoRole)
                    .HasForeignKey(d => d.IdPago)
                    .HasConstraintName("fk_PagoRole_Pago_1");

                entity.HasOne(d => d.IdParteRoleNavigation)
                    .WithMany(p => p.PagoRole)
                    .HasForeignKey(d => d.IdParteRole)
                    .HasConstraintName("fk_PagoRole_ParteRole_1");

                entity.HasOne(d => d.IdTipoParteRoleNavigation)
                    .WithMany(p => p.PagoRole)
                    .HasForeignKey(d => d.IdTipoParteRole)
                    .HasConstraintName("fk_PagoRole_TipoParteRole_1");
            });

            modelBuilder.Entity<Parte>(entity =>
            {
                entity.HasKey(e => e.IdParte)
                    .HasName("IdParte");

                entity.Property(e => e.IdParte).ValueGeneratedNever();
            });

            modelBuilder.Entity<ParteRole>(entity =>
            {
                entity.HasKey(e => e.IdParteRole)
                    .HasName("IdParteRole");

                entity.Property(e => e.FechaFinal).HasColumnType("date");

                entity.Property(e => e.FechaInicial).HasColumnType("date");

                entity.HasOne(d => d.IdParteNavigation)
                    .WithMany(p => p.ParteRole)
                    .HasForeignKey(d => d.IdParte)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ParteRole_Parte_1");

                entity.HasOne(d => d.IdTipoParteRoleNavigation)
                    .WithMany(p => p.ParteRole)
                    .HasForeignKey(d => d.IdTipoParteRole)
                    .HasConstraintName("fk_ParteRole_TipoParteRole_1");
            });

            modelBuilder.Entity<Persona>(entity =>
            {
                entity.HasKey(e => e.IdParte)
                    .HasName("IdPersona");

                entity.Property(e => e.IdParte).ValueGeneratedNever();

                entity.Property(e => e.Codigo).HasMaxLength(8);

                entity.Property(e => e.Estatura).HasColumnType("decimal(17, 2)");

                entity.Property(e => e.FechaCreacion).HasColumnType("datetimeoffset(2)");

                entity.Property(e => e.FechaModificacion).HasColumnType("datetimeoffset(2)");

                entity.Property(e => e.FechaNacimiento).HasColumnType("date");

                entity.Property(e => e.Genero)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LugarNacimiento).HasMaxLength(128);

                entity.Property(e => e.Materno).HasMaxLength(64);

                entity.Property(e => e.NombrePrimario).HasMaxLength(96);

                entity.Property(e => e.NombreSecundario).HasMaxLength(64);

                entity.Property(e => e.Paterno).HasMaxLength(64);

                entity.Property(e => e.Peso).HasColumnType("decimal(17, 2)");

                entity.Property(e => e.TituloActual).HasMaxLength(32);

                entity.HasOne(d => d.IdParteNavigation)
                    .WithOne(p => p.Persona)
                    .HasForeignKey<Persona>(d => d.IdParte)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Persona_Parte_1");
            });

            modelBuilder.Entity<PropositoContacto>(entity =>
            {
                entity.HasKey(e => e.IdPropositoContacto)
                    .HasName("IdPropositoContacto");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(16);

                entity.HasOne(d => d.IdTipoPropositoContactoNavigation)
                    .WithMany(p => p.PropositoContacto)
                    .HasForeignKey(d => d.IdTipoPropositoContacto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_PropositoContacto_TipoPropositoContacto_1");
            });

            modelBuilder.Entity<RedTarjeta>(entity =>
            {
                entity.HasKey(e => e.IdRedTarjeta)
                    .HasName("IdRedTarjeta");

                entity.Property(e => e.Nombre).HasMaxLength(16);
            });

            modelBuilder.Entity<TarjetaCliente>(entity =>
            {
                entity.HasKey(e => e.IdTarjetaCliente)
                    .HasName("IdTarjetaCliente");

                entity.Property(e => e.Cvv)
                    .IsRequired()
                    .HasColumnName("CVV")
                    .HasMaxLength(256);

                entity.Property(e => e.Expiracion)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.IsAmex).HasColumnName("IsAMEX");

                entity.Property(e => e.Numero)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.Titular).HasMaxLength(256);

                entity.HasOne(d => d.IdBancoNavigation)
                    .WithMany(p => p.TarjetaCliente)
                    .HasForeignKey(d => d.IdBanco)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_TarjetaCliente_Banco_1");

                entity.HasOne(d => d.IdParteNavigation)
                    .WithMany(p => p.TarjetaCliente)
                    .HasForeignKey(d => d.IdParte)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_TarjetaCliente_Parte_1");

                entity.HasOne(d => d.IdRedTarjetaNavigation)
                    .WithMany(p => p.TarjetaCliente)
                    .HasForeignKey(d => d.IdRedTarjeta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_TarjetaCliente_RedTarjeta_1");

                entity.HasOne(d => d.IdTipoTarjetaNavigation)
                    .WithMany(p => p.TarjetaCliente)
                    .HasForeignKey(d => d.IdTipoTarjeta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_TarjetaCliente_TipoTarjeta_1");
            });

            modelBuilder.Entity<TipoItem>(entity =>
            {
                entity.HasKey(e => e.IdTipoItem)
                    .HasName("IdTipoItem");

                entity.Property(e => e.ImagenUrl)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.Nombre).HasMaxLength(16);
            });

            modelBuilder.Entity<TipoParteRole>(entity =>
            {
                entity.HasKey(e => e.IdTipoParteRole)
                    .HasName("IdTipoParteRole");

                entity.Property(e => e.Nombre).HasMaxLength(128);
            });

            modelBuilder.Entity<TipoPropositoContacto>(entity =>
            {
                entity.HasKey(e => e.IdTipoPropositoContacto)
                    .HasName("IdTipoPropositoContacto");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(16);
            });

            modelBuilder.Entity<TipoTarjeta>(entity =>
            {
                entity.HasKey(e => e.IdTipoTarjeta)
                    .HasName("IdTipoTarjeta");

                entity.Property(e => e.IdTipoTarjeta).ValueGeneratedNever();

                entity.Property(e => e.Nombre).HasMaxLength(64);
            });

            modelBuilder.Entity<TipoTarjetaCredito>(entity =>
            {
                entity.HasKey(e => e.IdTipoTarjetaCredito)
                    .HasName("IdTipoTarjetaCredito");

                entity.Property(e => e.Nombre).HasMaxLength(32);
            });

            modelBuilder.Entity<TipoVenta>(entity =>
            {
                entity.HasKey(e => e.IdTipoVenta)
                    .HasName("IdTipoVenta");

                entity.Property(e => e.Nombre).HasMaxLength(32);
            });

            modelBuilder.Entity<Transferencia>(entity =>
            {
                entity.HasKey(e => e.IdTransferencia)
                    .HasName("IdTransferencia");

                entity.Property(e => e.Folio).HasMaxLength(20);

                entity.Property(e => e.NumeroAutorizacion).HasMaxLength(20);

                entity.Property(e => e.UrlComprobante).HasMaxLength(256);
            });

            modelBuilder.Entity<UnidadCotizacion>(entity =>
            {
                entity.HasKey(e => e.IdUnidadCotizacion)
                    .HasName("IdUnidadCotizacion");

                entity.Property(e => e.Abreviatura)
                    .IsRequired()
                    .HasMaxLength(16);

                entity.Property(e => e.Nombre).HasMaxLength(128);
            });

            modelBuilder.Entity<Venta>(entity =>
            {
                entity.HasKey(e => e.IdVenta)
                    .HasName("IdVenta");

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.FechaRegistro).HasColumnType("datetimeoffset(2)");

                entity.Property(e => e.Folio).HasMaxLength(16);
            });

            modelBuilder.Entity<VentaDetalle>(entity =>
            {
                entity.HasKey(e => e.IdVentaDetalle)
                    .HasName("IdVentaDetalle");

                entity.Property(e => e.Cantidad).HasColumnType("decimal(17, 2)");

                entity.Property(e => e.Importe).HasColumnType("decimal(17, 2)");

                entity.Property(e => e.ImportePagado).HasColumnType("decimal(17, 2)");

                entity.Property(e => e.Observaciones).HasMaxLength(256);

                entity.Property(e => e.Precio).HasColumnType("decimal(17, 2)");

                entity.HasOne(d => d.IdItemNavigation)
                    .WithMany(p => p.VentaDetalle)
                    .HasForeignKey(d => d.IdItem)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_VentaDetalle_Item_1");

                entity.HasOne(d => d.IdItemPrecioNavigation)
                    .WithMany(p => p.VentaDetalle)
                    .HasForeignKey(d => d.IdItemPrecio)
                    .HasConstraintName("fk_VentaDetalle_ItemPrecio_1");

                entity.HasOne(d => d.IdPagoNavigation)
                    .WithMany(p => p.VentaDetalle)
                    .HasForeignKey(d => d.IdPago)
                    .HasConstraintName("fk_VentaDetalle_Pago_1");

                entity.HasOne(d => d.IdTipoItemNavigation)
                    .WithMany(p => p.VentaDetalle)
                    .HasForeignKey(d => d.IdTipoItem)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_VentaDetalle_TipoItem_1");

                entity.HasOne(d => d.IdVentaNavigation)
                    .WithMany(p => p.VentaDetalle)
                    .HasForeignKey(d => d.IdVenta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_VentaDetalle_Venta_1");
            });

            modelBuilder.Entity<VentaDetalleExtra>(entity =>
            {
                entity.HasKey(e => e.IdVentaDetalleExtra)
                    .HasName("IdVentaDetalleExtra");

                entity.Property(e => e.Descripcion).HasMaxLength(256);

                entity.HasOne(d => d.IdVentaDetalleNavigation)
                    .WithMany(p => p.VentaDetalleExtra)
                    .HasForeignKey(d => d.IdVentaDetalle)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_VentaDetalleExtra_VentaDetalle_1");
            });

            modelBuilder.Entity<VentaDetalleImagen>(entity =>
            {
                entity.HasKey(e => e.IdVentaDetalleImagen)
                    .HasName("IdVentaDetalleImagen");

                entity.Property(e => e.ImagenUrl).HasMaxLength(256);

                entity.HasOne(d => d.IdVentaDetalleNavigation)
                    .WithMany(p => p.VentaDetalleImagen)
                    .HasForeignKey(d => d.IdVentaDetalle)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_VentaDetalleImagen_VentaDetalle_1");
            });

            modelBuilder.Entity<VentaDetalleRole>(entity =>
            {
                entity.HasKey(e => e.IdVentaDetalleRole)
                    .HasName("IdVentaDetalleRole");

                entity.Property(e => e.FechaFinal).HasColumnType("datetimeoffset(2)");

                entity.Property(e => e.FechaInicial).HasColumnType("datetimeoffset(2)");
            });

            modelBuilder.Entity<VentaEstatus>(entity =>
            {
                entity.HasKey(e => e.IdVentaEstatus)
                    .HasName("IdVentaEstatus");

                entity.HasOne(d => d.IdEstatusVentaNavigation)
                    .WithMany(p => p.VentaEstatus)
                    .HasForeignKey(d => d.IdEstatusVenta)
                    .HasConstraintName("fk_VentaEstatus_EstatusVenta_1");

                entity.HasOne(d => d.IdParteRoleNavigation)
                    .WithMany(p => p.VentaEstatus)
                    .HasForeignKey(d => d.IdParteRole)
                    .HasConstraintName("fk_VentaEstatus_ParteRole_1");

                entity.HasOne(d => d.IdVentaNavigation)
                    .WithMany(p => p.VentaEstatus)
                    .HasForeignKey(d => d.IdVenta)
                    .HasConstraintName("fk_VentaEstatus_Venta_1");

                entity.HasOne(d => d.IdVentaDetalleNavigation)
                    .WithMany(p => p.VentaEstatus)
                    .HasForeignKey(d => d.IdVentaDetalle)
                    .HasConstraintName("fk_VentaEstatus_VentaDetalle_1");
            });

            modelBuilder.Entity<VentaEvaluacion>(entity =>
            {
                entity.HasKey(e => e.IdVenta)
                    .HasName("IdVentaEvaluacion");

                entity.Property(e => e.IdVenta).ValueGeneratedOnAdd();

                entity.Property(e => e.Comentarios).HasMaxLength(255);

                entity.Property(e => e.Estrellas).HasColumnType("decimal(3, 2)");

                entity.HasOne(d => d.IdVentaNavigation)
                    .WithOne(p => p.VentaEvaluacion)
                    .HasForeignKey<VentaEvaluacion>(d => d.IdVenta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_VentaEvaluacion_Venta_1");
            });

            modelBuilder.Entity<VentaRole>(entity =>
            {
                entity.HasKey(e => e.IdVentaRole)
                    .HasName("IdVentaRole");

                entity.Property(e => e.FechaFinal).HasColumnType("datetimeoffset(2)");

                entity.Property(e => e.FechaInicial).HasColumnType("datetimeoffset(2)");

                entity.HasOne(d => d.IdParteRoleNavigation)
                    .WithMany(p => p.VentaRole)
                    .HasForeignKey(d => d.IdParteRole)
                    .HasConstraintName("fk_VentaRole_ParteRole_1");

                entity.HasOne(d => d.IdTipoParteRoleNavigation)
                    .WithMany(p => p.VentaRole)
                    .HasForeignKey(d => d.IdTipoParteRole)
                    .HasConstraintName("fk_VentaRole_TipoParteRole_1");

                entity.HasOne(d => d.IdVentaNavigation)
                    .WithMany(p => p.VentaRole)
                    .HasForeignKey(d => d.IdVenta)
                    .HasConstraintName("fk_VentaRole_Venta_1");
            });

        }
        public async Task<int> SaveChangesAsync()
        {
            return await base.SaveChangesAsync();
        }
    }
}
