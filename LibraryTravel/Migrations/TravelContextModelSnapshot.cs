﻿// <auto-generated />
using System;
using LibraryTravel.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LibraryTravel.Migrations
{
    [DbContext(typeof(TravelContext))]
    partial class TravelContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.14")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LibraryTravel.Models.Autores", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Apellidos")
                        .HasMaxLength(45)
                        .IsUnicode(false)
                        .HasColumnType("varchar(45)");

                    b.Property<string>("Nombre")
                        .HasMaxLength(45)
                        .IsUnicode(false)
                        .HasColumnType("varchar(45)");

                    b.HasKey("Id");

                    b.ToTable("Autores");
                });

            modelBuilder.Entity("LibraryTravel.Models.AutoresHasLibro", b =>
                {
                    b.Property<int>("AutoresId")
                        .HasColumnType("int")
                        .HasColumnName("autores_id");

                    b.Property<int>("LibrosIsbn")
                        .HasColumnType("int")
                        .HasColumnName("libros_ISBN");

                    b.HasKey("AutoresId", "LibrosIsbn");

                    b.HasIndex("LibrosIsbn");

                    b.ToTable("autores_has_libros");
                });

            modelBuilder.Entity("LibraryTravel.Models.Editoriales", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasMaxLength(45)
                        .IsUnicode(false)
                        .HasColumnType("varchar(45)")
                        .HasColumnName("nombre");

                    b.Property<string>("Sede")
                        .HasMaxLength(45)
                        .IsUnicode(false)
                        .HasColumnType("varchar(45)")
                        .HasColumnName("sede");

                    b.HasKey("Id");

                    b.ToTable("Editoriales");
                });

            modelBuilder.Entity("LibraryTravel.Models.Libros", b =>
                {
                    b.Property<int>("Isbn")
                        .HasColumnType("int")
                        .HasColumnName("ISBN");

                    b.Property<int?>("EditorialesId")
                        .HasColumnType("int")
                        .HasColumnName("editoriales_id");

                    b.Property<string>("NPaginas")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("n_paginas");

                    b.Property<string>("Sinopsis")
                        .HasColumnType("text")
                        .HasColumnName("sinopsis");

                    b.Property<string>("Titulo")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("titulo");

                    b.HasKey("Isbn");

                    b.HasIndex("EditorialesId");

                    b.ToTable("Libros");
                });

            modelBuilder.Entity("LibraryTravel.Models.AutoresHasLibro", b =>
                {
                    b.HasOne("LibraryTravel.Models.Autores", "Autores")
                        .WithMany("AutoresHasLibros")
                        .HasForeignKey("AutoresId")
                        .HasConstraintName("FK_autores_has_libros_autores")
                        .IsRequired();

                    b.HasOne("LibraryTravel.Models.Libros", "LibrosIsbnNavigation")
                        .WithMany("AutoresHasLibros")
                        .HasForeignKey("LibrosIsbn")
                        .HasConstraintName("FK_autores_has_libros_libros")
                        .IsRequired();

                    b.Navigation("Autores");

                    b.Navigation("LibrosIsbnNavigation");
                });

            modelBuilder.Entity("LibraryTravel.Models.Libros", b =>
                {
                    b.HasOne("LibraryTravel.Models.Editoriales", "Editoriales")
                        .WithMany("Libros")
                        .HasForeignKey("EditorialesId")
                        .HasConstraintName("FK_libros_editoriales");

                    b.Navigation("Editoriales");
                });

            modelBuilder.Entity("LibraryTravel.Models.Autores", b =>
                {
                    b.Navigation("AutoresHasLibros");
                });

            modelBuilder.Entity("LibraryTravel.Models.Editoriales", b =>
                {
                    b.Navigation("Libros");
                });

            modelBuilder.Entity("LibraryTravel.Models.Libros", b =>
                {
                    b.Navigation("AutoresHasLibros");
                });
#pragma warning restore 612, 618
        }
    }
}
