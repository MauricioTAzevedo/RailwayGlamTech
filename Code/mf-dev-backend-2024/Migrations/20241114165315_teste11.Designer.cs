﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using mf_dev_backend_2024.Models;

#nullable disable

namespace mf_dev_backend_2024.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241114165315_teste11")]
    partial class teste11
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("mf_dev_backend_2024.Models.Agendamento", b =>
                {
                    b.Property<int>("IdAgendamento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdAgendamento"));

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("IdAgendamento");

                    b.ToTable("Agendamentos");
                });

            modelBuilder.Entity("mf_dev_backend_2024.Models.Avaliacao", b =>
                {
                    b.Property<int>("IdAvaliacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdAvaliacao"));

                    b.Property<string>("Comentario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Nota")
                        .HasColumnType("int");

                    b.Property<int>("idAgendamentos")
                        .HasColumnType("int");

                    b.HasKey("IdAvaliacao");

                    b.HasIndex("idAgendamentos");

                    b.ToTable("Avaliacoes");
                });

            modelBuilder.Entity("mf_dev_backend_2024.Models.Cliente", b =>
                {
                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Telefone")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("mf_dev_backend_2024.Models.Estoque", b =>
                {
                    b.Property<int>("EstoqueId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EstoqueId"));

                    b.Property<string>("Produto")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.HasKey("EstoqueId");

                    b.ToTable("Estoques");
                });

            modelBuilder.Entity("mf_dev_backend_2024.Models.Historico", b =>
                {
                    b.Property<int>("IdHistorico")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdHistorico"));

                    b.Property<string>("Comentario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StatusFinal")
                        .HasColumnType("int");

                    b.Property<int>("idAgendamentos")
                        .HasColumnType("int");

                    b.HasKey("IdHistorico");

                    b.HasIndex("idAgendamentos");

                    b.ToTable("Historico");
                });

            modelBuilder.Entity("mf_dev_backend_2024.Models.Notificacao", b =>
                {
                    b.Property<int>("NotificacaoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NotificacaoId"));

                    b.Property<string>("Mensagem")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NotificacaoId");

                    b.ToTable("Notificacoes");
                });

            modelBuilder.Entity("mf_dev_backend_2024.Models.Pagamento", b =>
                {
                    b.Property<int>("PagamentoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PagamentoId"));

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("PagamentoId");

                    b.ToTable("Pagamentos");
                });

            modelBuilder.Entity("mf_dev_backend_2024.Models.Profissional", b =>
                {
                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Especialidade")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.ToTable("Profissionais");
                });

            modelBuilder.Entity("mf_dev_backend_2024.Models.Servicos", b =>
                {
                    b.Property<int>("idServicos")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idServicos"));

                    b.Property<string>("Descrição")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Preço")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("idServicos");

                    b.ToTable("Servicos");
                });

            modelBuilder.Entity("mf_dev_backend_2024.Models.ServicosAgendados", b =>
                {
                    b.Property<int>("idAgendamentos")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idAgendamentos"));

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<TimeSpan>("Hora")
                        .HasColumnType("time");

                    b.Property<string>("nomecliente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idAgendamentos");

                    b.ToTable("ServicosAgendados");
                });

            modelBuilder.Entity("mf_dev_backend_2024.Models.Avaliacao", b =>
                {
                    b.HasOne("mf_dev_backend_2024.Models.Agendamento", "Agendamento")
                        .WithMany()
                        .HasForeignKey("idAgendamentos")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Agendamento");
                });

            modelBuilder.Entity("mf_dev_backend_2024.Models.Historico", b =>
                {
                    b.HasOne("mf_dev_backend_2024.Models.Agendamento", "Agendamento")
                        .WithMany()
                        .HasForeignKey("idAgendamentos")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Agendamento");
                });
#pragma warning restore 612, 618
        }
    }
}
