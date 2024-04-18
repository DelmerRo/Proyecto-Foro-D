﻿// <auto-generated />
using System;
using FORO_D.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FORO_D.Migrations
{
    [DbContext(typeof(ForoContext))]
    [Migration("20211019030132_registrandoUnaReaccion")]
    partial class registrandoUnaReaccion
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FORO_D.Models.Categoria", b =>
                {
                    b.Property<int>("CategoriaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("CategoriaId");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("FORO_D.Models.Entrada", b =>
                {
                    b.Property<int>("EntradaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoriaId")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<int>("MiembroId")
                        .HasColumnType("int");

                    b.Property<bool>("Privada")
                        .HasColumnType("bit");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("EntradaId");

                    b.HasIndex("CategoriaId");

                    b.HasIndex("MiembroId");

                    b.ToTable("Entradas");
                });

            modelBuilder.Entity("FORO_D.Models.MiembrosHabilitados", b =>
                {
                    b.Property<int>("MiembroId")
                        .HasColumnType("int");

                    b.Property<int>("EntradaId")
                        .HasColumnType("int");

                    b.HasKey("MiembroId", "EntradaId");

                    b.HasIndex("EntradaId");

                    b.ToTable("MiembrosHabilitados");
                });

            modelBuilder.Entity("FORO_D.Models.Pregunta", b =>
                {
                    b.Property<int>("PreguntaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Activa")
                        .HasColumnType("bit");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("EntradaId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<int>("MiembroId")
                        .HasColumnType("int");

                    b.HasKey("PreguntaId");

                    b.HasIndex("EntradaId");

                    b.HasIndex("MiembroId");

                    b.ToTable("Preguntas");
                });

            modelBuilder.Entity("FORO_D.Models.Reaccion", b =>
                {
                    b.Property<int>("MiembroId")
                        .HasColumnType("int");

                    b.Property<int>("RespuestaId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<bool>("MeGusta")
                        .HasColumnType("bit");

                    b.HasKey("MiembroId", "RespuestaId");

                    b.HasIndex("RespuestaId");

                    b.ToTable("Reacciones");
                });

            modelBuilder.Entity("FORO_D.Models.Respuesta", b =>
                {
                    b.Property<int>("RespuestaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<int>("MiembroId")
                        .HasColumnType("int");

                    b.Property<int>("PreguntaId")
                        .HasColumnType("int");

                    b.HasKey("RespuestaId");

                    b.HasIndex("MiembroId");

                    b.HasIndex("PreguntaId");

                    b.ToTable("Respuestas");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("Roles");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityRole<int>");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("Usuarios");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser<int>");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UsuariosRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("FORO_D.Models.Rol", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityRole<int>");

                    b.HasDiscriminator().HasValue("Rol");
                });

            modelBuilder.Entity("FORO_D.Models.Usuario", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser<int>");

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<DateTime>("FechaAlta")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasDiscriminator().HasValue("Usuario");
                });

            modelBuilder.Entity("FORO_D.Models.Miembro", b =>
                {
                    b.HasBaseType("FORO_D.Models.Usuario");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasDiscriminator().HasValue("Miembro");
                });

            modelBuilder.Entity("FORO_D.Models.Entrada", b =>
                {
                    b.HasOne("FORO_D.Models.Categoria", "Categoria")
                        .WithMany("Entradas")
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FORO_D.Models.Miembro", "Miembro")
                        .WithMany()
                        .HasForeignKey("MiembroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");

                    b.Navigation("Miembro");
                });

            modelBuilder.Entity("FORO_D.Models.MiembrosHabilitados", b =>
                {
                    b.HasOne("FORO_D.Models.Entrada", "Entrada")
                        .WithMany("MiembrosHabibilitados")
                        .HasForeignKey("EntradaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FORO_D.Models.Miembro", "Miembro")
                        .WithMany("Entradas")
                        .HasForeignKey("MiembroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Entrada");

                    b.Navigation("Miembro");
                });

            modelBuilder.Entity("FORO_D.Models.Pregunta", b =>
                {
                    b.HasOne("FORO_D.Models.Entrada", "Entrada")
                        .WithMany("Preguntas")
                        .HasForeignKey("EntradaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FORO_D.Models.Miembro", "Miembro")
                        .WithMany("Preguntas")
                        .HasForeignKey("MiembroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Entrada");

                    b.Navigation("Miembro");
                });

            modelBuilder.Entity("FORO_D.Models.Reaccion", b =>
                {
                    b.HasOne("FORO_D.Models.Miembro", "Miembro")
                        .WithMany("PreguntasYRespuestasQueMeGustan")
                        .HasForeignKey("MiembroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FORO_D.Models.Respuesta", "Respuesta")
                        .WithMany("Reacciones")
                        .HasForeignKey("RespuestaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Miembro");

                    b.Navigation("Respuesta");
                });

            modelBuilder.Entity("FORO_D.Models.Respuesta", b =>
                {
                    b.HasOne("FORO_D.Models.Miembro", "Miembro")
                        .WithMany("Respuestas")
                        .HasForeignKey("MiembroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FORO_D.Models.Pregunta", "Pregunta")
                        .WithMany("Respuestas")
                        .HasForeignKey("PreguntaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Miembro");

                    b.Navigation("Pregunta");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<int>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser<int>", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser<int>", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<int>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser<int>", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser<int>", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FORO_D.Models.Categoria", b =>
                {
                    b.Navigation("Entradas");
                });

            modelBuilder.Entity("FORO_D.Models.Entrada", b =>
                {
                    b.Navigation("MiembrosHabibilitados");

                    b.Navigation("Preguntas");
                });

            modelBuilder.Entity("FORO_D.Models.Pregunta", b =>
                {
                    b.Navigation("Respuestas");
                });

            modelBuilder.Entity("FORO_D.Models.Respuesta", b =>
                {
                    b.Navigation("Reacciones");
                });

            modelBuilder.Entity("FORO_D.Models.Miembro", b =>
                {
                    b.Navigation("Entradas");

                    b.Navigation("Preguntas");

                    b.Navigation("PreguntasYRespuestasQueMeGustan");

                    b.Navigation("Respuestas");
                });
#pragma warning restore 612, 618
        }
    }
}
