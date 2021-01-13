﻿// <auto-generated />
using System;
using DesafioJson.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DesafioJson.Migrations
{
    [DbContext(typeof(UnidadeGestoraContext))]
    [Migration("20210113141834_Teste")]
    partial class Teste
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("DesafioJson.Model.Contadores", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("Ativo")
                        .HasColumnType("BIT");

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("Date");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Numero")
                        .HasColumnType("Int");

                    b.Property<int?>("UnidadeGestoraCodigo")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UnidadeGestoraCodigo");

                    b.ToTable("Contadores", "Desafio");
                });

            modelBuilder.Entity("DesafioJson.Model.UnidadeGestora", b =>
                {
                    b.Property<int>("Codigo")
                        .HasColumnType("int");

                    b.Property<string>("Cnpj")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("DateTime");

                    b.Property<bool>("EmitePreEmpenhoIntegrado")
                        .HasColumnType("BIT");

                    b.Property<bool>("IntegracaoCompras")
                        .HasColumnType("BIT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("NomeReduzido")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Codigo");

                    b.ToTable("UnidadeGestora", "Desafio");
                });

            modelBuilder.Entity("DesafioJson.Model.UnidadeOrcamentaria", b =>
                {
                    b.Property<int>("Codigo")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataInclusaoRegistro")
                        .HasColumnType("Date");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("UnidadeGestoraCodigo")
                        .HasColumnType("int");

                    b.Property<string>("UsuarioInclusaoRegistro")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Codigo");

                    b.HasIndex("UnidadeGestoraCodigo")
                        .IsUnique();

                    b.ToTable("Orcamentaria", "Desafio");
                });

            modelBuilder.Entity("DesafioJson.Model.Contadores", b =>
                {
                    b.HasOne("DesafioJson.Model.UnidadeGestora", "UnidadeGestora")
                        .WithMany("Contadores")
                        .HasForeignKey("UnidadeGestoraCodigo");

                    b.Navigation("UnidadeGestora");
                });

            modelBuilder.Entity("DesafioJson.Model.UnidadeOrcamentaria", b =>
                {
                    b.HasOne("DesafioJson.Model.UnidadeGestora", "UnidadeGestora")
                        .WithOne("UnidadeOrcamentaria")
                        .HasForeignKey("DesafioJson.Model.UnidadeOrcamentaria", "UnidadeGestoraCodigo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UnidadeGestora");
                });

            modelBuilder.Entity("DesafioJson.Model.UnidadeGestora", b =>
                {
                    b.Navigation("Contadores");

                    b.Navigation("UnidadeOrcamentaria");
                });
#pragma warning restore 612, 618
        }
    }
}
