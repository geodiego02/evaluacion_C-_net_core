// <auto-generated />
using System;
using ENA_Rodrigo_Vera_3600.Modell;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ENA_Rodrigo_Vera_3600.Migrations
{
    [DbContext(typeof(ConexionDbContext))]
    partial class ConexionDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ENA_Rodrigo_Vera_3600.Modell.Cliente", b =>
                {
                    b.Property<int>("ClienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Fono")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rut")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClienteId");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("ENA_Rodrigo_Vera_3600.Modell.ControlMascotas", b =>
                {
                    b.Property<int>("ControlMascotasId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Detalle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaAtencion")
                        .HasColumnType("datetime2");

                    b.Property<string>("NombreCliente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreMascota")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProgramaVacuna")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RazaMascota")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Servicio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipoMascota")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Total")
                        .HasColumnType("int");

                    b.HasKey("ControlMascotasId");

                    b.ToTable("ControlMascotas");
                });

            modelBuilder.Entity("ENA_Rodrigo_Vera_3600.Modell.Mascota", b =>
                {
                    b.Property<int>("MascotaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ClienteId")
                        .HasColumnType("int");

                    b.Property<string>("ColorMascota")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EdadMascota")
                        .HasColumnType("int");

                    b.Property<string>("NombreMascota")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RazaMascota")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SexoMascota")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipoMascota")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VacunasMascota")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MascotaId");

                    b.HasIndex("ClienteId");

                    b.ToTable("Mascota");
                });

            modelBuilder.Entity("ENA_Rodrigo_Vera_3600.Modell.TablaIntermedia", b =>
                {
                    b.Property<int?>("ClienteId")
                        .HasColumnType("int");

                    b.Property<int?>("ControlMascotasId")
                        .HasColumnType("int");

                    b.HasKey("ClienteId", "ControlMascotasId");

                    b.HasIndex("ControlMascotasId");

                    b.ToTable("TablaIntermedia");
                });

            modelBuilder.Entity("ENA_Rodrigo_Vera_3600.Modell.Usuario", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cargo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contraseña")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreUsuario")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UsuarioId");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("ENA_Rodrigo_Vera_3600.Modell.Mascota", b =>
                {
                    b.HasOne("ENA_Rodrigo_Vera_3600.Modell.Cliente", "Cliente")
                        .WithMany("Mascotas")
                        .HasForeignKey("ClienteId");
                });

            modelBuilder.Entity("ENA_Rodrigo_Vera_3600.Modell.TablaIntermedia", b =>
                {
                    b.HasOne("ENA_Rodrigo_Vera_3600.Modell.Cliente", "Cliente")
                        .WithMany("TablaIntermedias")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ENA_Rodrigo_Vera_3600.Modell.ControlMascotas", "ControlMascotas")
                        .WithMany("TablaIntermedias")
                        .HasForeignKey("ControlMascotasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
