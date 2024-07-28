﻿// <auto-generated />
using System;
using BE.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BE.Migrations
{
    [DbContext(typeof(EventosContext))]
    [Migration("20240727170446_tareavoluntariov2")]
    partial class tareavoluntariov2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BE.Models.Categoria", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("EdadFin")
                        .HasColumnType("int");

                    b.Property<int>("EdadInicio")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("BE.Models.Comentario", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Contenido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CorredorID")
                        .HasColumnType("int");

                    b.Property<int>("EventoID")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaHora")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("CorredorID");

                    b.HasIndex("EventoID");

                    b.ToTable("Comentarios");
                });

            modelBuilder.Entity("BE.Models.Distancia", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("KM")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Distancias");
                });

            modelBuilder.Entity("BE.Models.Evento", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<string>("Imagen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lugar")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TipoID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("TipoID");

                    b.ToTable("Eventos");
                });

            modelBuilder.Entity("BE.Models.EventoDistancia", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("DistanciaID")
                        .HasColumnType("int");

                    b.Property<int>("EventoID")
                        .HasColumnType("int");

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ID");

                    b.HasIndex("DistanciaID");

                    b.HasIndex("EventoID");

                    b.ToTable("EventoDistancia");
                });

            modelBuilder.Entity("BE.Models.Inscripcion", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<bool>("Acreditado")
                        .HasColumnType("bit");

                    b.Property<int>("CategoriaID")
                        .HasColumnType("int");

                    b.Property<int>("DistanciaID")
                        .HasColumnType("int");

                    b.Property<int>("Dorsal")
                        .HasColumnType("int");

                    b.Property<string>("EstadoPago")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EventoID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<string>("FormaPago")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PosicionCategoria")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PosicionGeneral")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Remera")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Tiempo")
                        .HasColumnType("int");

                    b.Property<int>("UsuarioID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("DistanciaID");

                    b.HasIndex("EventoID");

                    b.HasIndex("UsuarioID");

                    b.ToTable("Inscripciones");
                });

            modelBuilder.Entity("BE.Models.Rol", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("BE.Models.Tarea", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EventoID")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaHora")
                        .HasColumnType("datetime2");

                    b.Property<string>("Ubicacion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("EventoID");

                    b.ToTable("Tareas");
                });

            modelBuilder.Entity("BE.Models.TareaVoluntario", b =>
                {
                    b.Property<int>("TareaID")
                        .HasColumnType("int");

                    b.Property<int>("VoluntarioID")
                        .HasColumnType("int");

                    b.Property<string>("Comentario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TareaID", "VoluntarioID");

                    b.HasIndex("VoluntarioID");

                    b.ToTable("TareaVoluntario");
                });

            modelBuilder.Entity("BE.Models.TipoEvento", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("TiposEventos");
                });

            modelBuilder.Entity("BE.Models.Usuario", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Imagen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RolID")
                        .HasColumnType("int");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("RolID");

                    b.ToTable("Usuarios");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Usuario");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("CategoriaEvento", b =>
                {
                    b.Property<int>("CategoriasID")
                        .HasColumnType("int");

                    b.Property<int>("EventosID")
                        .HasColumnType("int");

                    b.HasKey("CategoriasID", "EventosID");

                    b.HasIndex("EventosID");

                    b.ToTable("CategoriaEvento");
                });

            modelBuilder.Entity("BE.Models.Corredor", b =>
                {
                    b.HasBaseType("BE.Models.Usuario");

                    b.Property<string>("Dni")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Genero")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Localidad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ObraSocial")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Corredor");
                });

            modelBuilder.Entity("BE.Models.Voluntario", b =>
                {
                    b.HasBaseType("BE.Models.Usuario");

                    b.HasDiscriminator().HasValue("Voluntario");
                });

            modelBuilder.Entity("BE.Models.Comentario", b =>
                {
                    b.HasOne("BE.Models.Usuario", "Corredor")
                        .WithMany()
                        .HasForeignKey("CorredorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BE.Models.Evento", "Evento")
                        .WithMany("Comentarios")
                        .HasForeignKey("EventoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Corredor");

                    b.Navigation("Evento");
                });

            modelBuilder.Entity("BE.Models.Evento", b =>
                {
                    b.HasOne("BE.Models.TipoEvento", "Tipo")
                        .WithMany("Eventos")
                        .HasForeignKey("TipoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tipo");
                });

            modelBuilder.Entity("BE.Models.EventoDistancia", b =>
                {
                    b.HasOne("BE.Models.Distancia", "Distancia")
                        .WithMany("EventoDistancias")
                        .HasForeignKey("DistanciaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BE.Models.Evento", null)
                        .WithMany("EventoDistancias")
                        .HasForeignKey("EventoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Distancia");
                });

            modelBuilder.Entity("BE.Models.Inscripcion", b =>
                {
                    b.HasOne("BE.Models.Distancia", "Distancia")
                        .WithMany("Inscripciones")
                        .HasForeignKey("DistanciaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BE.Models.Evento", "Evento")
                        .WithMany("Inscripciones")
                        .HasForeignKey("EventoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BE.Models.Corredor", "Corredor")
                        .WithMany("Inscripciones")
                        .HasForeignKey("UsuarioID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Corredor");

                    b.Navigation("Distancia");

                    b.Navigation("Evento");
                });

            modelBuilder.Entity("BE.Models.Tarea", b =>
                {
                    b.HasOne("BE.Models.Evento", "Evento")
                        .WithMany()
                        .HasForeignKey("EventoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Evento");
                });

            modelBuilder.Entity("BE.Models.TareaVoluntario", b =>
                {
                    b.HasOne("BE.Models.Tarea", null)
                        .WithMany("TareaVoluntarios")
                        .HasForeignKey("TareaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BE.Models.Voluntario", "Voluntario")
                        .WithMany("TareaVoluntarios")
                        .HasForeignKey("VoluntarioID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Voluntario");
                });

            modelBuilder.Entity("BE.Models.Usuario", b =>
                {
                    b.HasOne("BE.Models.Rol", "Rol")
                        .WithMany()
                        .HasForeignKey("RolID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Rol");
                });

            modelBuilder.Entity("CategoriaEvento", b =>
                {
                    b.HasOne("BE.Models.Categoria", null)
                        .WithMany()
                        .HasForeignKey("CategoriasID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BE.Models.Evento", null)
                        .WithMany()
                        .HasForeignKey("EventosID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BE.Models.Distancia", b =>
                {
                    b.Navigation("EventoDistancias");

                    b.Navigation("Inscripciones");
                });

            modelBuilder.Entity("BE.Models.Evento", b =>
                {
                    b.Navigation("Comentarios");

                    b.Navigation("EventoDistancias");

                    b.Navigation("Inscripciones");
                });

            modelBuilder.Entity("BE.Models.Tarea", b =>
                {
                    b.Navigation("TareaVoluntarios");
                });

            modelBuilder.Entity("BE.Models.TipoEvento", b =>
                {
                    b.Navigation("Eventos");
                });

            modelBuilder.Entity("BE.Models.Corredor", b =>
                {
                    b.Navigation("Inscripciones");
                });

            modelBuilder.Entity("BE.Models.Voluntario", b =>
                {
                    b.Navigation("TareaVoluntarios");
                });
#pragma warning restore 612, 618
        }
    }
}
