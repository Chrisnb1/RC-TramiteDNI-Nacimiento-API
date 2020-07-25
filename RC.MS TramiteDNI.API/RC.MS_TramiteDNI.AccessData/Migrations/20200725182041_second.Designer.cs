﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RC.MS_TramiteDNI.AccessData;

namespace RC.MS_TramiteDNI.AccessData.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20200725182041_second")]
    partial class second
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RC.MS_NacimientoDefuncion.Domain.Entities.RecienNacido", b =>
                {
                    b.Property<int>("RecienNacidoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .IsUnicode(true)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Genero")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("LugarNacimiento")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<int>("NumeroActa")
                        .HasColumnType("int");

                    b.Property<bool>("PartidaNacimiento")
                        .HasColumnType("bit");

                    b.Property<int>("Persona_1_Id")
                        .HasColumnType("int");

                    b.Property<int>("Persona_2_Id")
                        .HasColumnType("int");

                    b.Property<int>("TramiteNacimientoId")
                        .HasColumnType("int");

                    b.HasKey("RecienNacidoId");

                    b.HasIndex("TramiteNacimientoId")
                        .IsUnique();

                    b.ToTable("RecienNacidos");
                });

            modelBuilder.Entity("RC.MS_NacimientoDefuncion.Domain.Entities.TramiteNacimiento", b =>
                {
                    b.Property<int>("TramiteNacimientoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .IsUnicode(true)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("TramiteNacimientoId");

                    b.ToTable("TramiteNacimientos");
                });

            modelBuilder.Entity("RC.MS_TramiteDNI.Domain.Entities.Extranjero", b =>
                {
                    b.Property<int>("ExtranjeroId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .IsUnicode(true)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PaisOrigen")
                        .IsRequired()
                        .HasColumnType("nvarchar(45)")
                        .HasMaxLength(45);

                    b.Property<int>("TramiteDNIid")
                        .HasColumnType("int");

                    b.HasKey("ExtranjeroId");

                    b.HasIndex("TramiteDNIid")
                        .IsUnique();

                    b.ToTable("Extranjeros");
                });

            modelBuilder.Entity("RC.MS_TramiteDNI.Domain.Entities.Nacimiento", b =>
                {
                    b.Property<int>("NacimientoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .IsUnicode(true)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("TramiteDNIid")
                        .HasColumnType("int");

                    b.Property<int>("TramiteRecienNacidoId")
                        .HasColumnType("int");

                    b.HasKey("NacimientoId");

                    b.HasIndex("TramiteDNIid")
                        .IsUnique();

                    b.ToTable("Nacimientos");
                });

            modelBuilder.Entity("RC.MS_TramiteDNI.Domain.Entities.NuevoEjemplar", b =>
                {
                    b.Property<int>("NuevoEjemplarId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .IsUnicode(true)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(45)")
                        .HasMaxLength(45);

                    b.Property<int>("TramiteDNIid")
                        .HasColumnType("int");

                    b.HasKey("NuevoEjemplarId");

                    b.HasIndex("TramiteDNIid")
                        .IsUnique();

                    b.ToTable("NuevosEjemplares");
                });

            modelBuilder.Entity("RC.MS_TramiteDNI.Domain.Entities.TramiteDNI", b =>
                {
                    b.Property<int>("TramiteDNIid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .IsUnicode(true)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("TramiteDNIid");

                    b.ToTable("TramiteDNIs");
                });

            modelBuilder.Entity("RC.MS_NacimientoDefuncion.Domain.Entities.RecienNacido", b =>
                {
                    b.HasOne("RC.MS_NacimientoDefuncion.Domain.Entities.TramiteNacimiento", "TramiteNacimientoNavigator")
                        .WithOne("RecienNacidoNavigator")
                        .HasForeignKey("RC.MS_NacimientoDefuncion.Domain.Entities.RecienNacido", "TramiteNacimientoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RC.MS_TramiteDNI.Domain.Entities.Extranjero", b =>
                {
                    b.HasOne("RC.MS_TramiteDNI.Domain.Entities.TramiteDNI", "TramiteDNInavigator")
                        .WithOne("ExtranjeroNavigator")
                        .HasForeignKey("RC.MS_TramiteDNI.Domain.Entities.Extranjero", "TramiteDNIid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RC.MS_TramiteDNI.Domain.Entities.Nacimiento", b =>
                {
                    b.HasOne("RC.MS_TramiteDNI.Domain.Entities.TramiteDNI", "TramiteDNInavigator")
                        .WithOne("NacimientoNavigator")
                        .HasForeignKey("RC.MS_TramiteDNI.Domain.Entities.Nacimiento", "TramiteDNIid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RC.MS_TramiteDNI.Domain.Entities.NuevoEjemplar", b =>
                {
                    b.HasOne("RC.MS_TramiteDNI.Domain.Entities.TramiteDNI", "TramiteDNInavigator")
                        .WithOne("NuevosEjemplarNavigator")
                        .HasForeignKey("RC.MS_TramiteDNI.Domain.Entities.NuevoEjemplar", "TramiteDNIid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}