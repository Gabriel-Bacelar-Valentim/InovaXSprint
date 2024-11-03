﻿// <auto-generated />
using System;
using InovaXSprint.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oracle.EntityFrameworkCore.Metadata;

#nullable disable

namespace InovaX.Database.Migrations
{
    [DbContext(typeof(FIAPDbContext))]
    partial class FIAPDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            OracleModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DistribuidorProduto", b =>
                {
                    b.Property<int>("DistribuidoresId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<int>("ProdutosIdProduto")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("DistribuidoresId", "ProdutosIdProduto");

                    b.HasIndex("ProdutosIdProduto");

                    b.ToTable("DistribuidorProduto");
                });

            modelBuilder.Entity("DistribuidorServico", b =>
                {
                    b.Property<int>("DistribuidoresId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<int>("ServicosIdServico")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("DistribuidoresId", "ServicosIdServico");

                    b.HasIndex("ServicosIdServico");

                    b.ToTable("DistribuidorServico");
                });

            modelBuilder.Entity("Endereco", b =>
                {
                    b.Property<int>("IdEndereco")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdEndereco"));

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Complemento")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Rua")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("IdEndereco");

                    b.ToTable("InovaX_Tb_Endereco", (string)null);
                });

            modelBuilder.Entity("InovaXSprint.Models.Avaliacao", b =>
                {
                    b.Property<int>("IdAvaliacao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdAvaliacao"));

                    b.Property<DateTime>("DataAvaliacao")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<int>("IdProduto")
                        .HasColumnType("NUMBER(10)");

                    b.Property<int>("IdServico")
                        .HasColumnType("NUMBER(10)");

                    b.Property<int?>("ProdutoIdProduto")
                        .HasColumnType("NUMBER(10)");

                    b.Property<int?>("ServicoIdServico")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("Texto")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("IdAvaliacao");

                    b.HasIndex("ProdutoIdProduto");

                    b.HasIndex("ServicoIdServico");

                    b.ToTable("InovaX_Tb_Avaliacao", (string)null);
                });

            modelBuilder.Entity("InovaXSprint.Models.Produto", b =>
                {
                    b.Property<int>("IdProduto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdProduto"));

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Preco")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Quantidade")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("IdProduto");

                    b.ToTable("InovaX_Tb_Produto", (string)null);
                });

            modelBuilder.Entity("InovaXSprint.Models.Servico", b =>
                {
                    b.Property<int>("IdServico")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdServico"));

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Preco")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("IdServico");

                    b.ToTable("InovaX_Tb_Servico", (string)null);
                });

            modelBuilder.Entity("InovaXSprint.Models.Telefone", b =>
                {
                    b.Property<int>("TelefoneId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TelefoneId"));

                    b.Property<string>("DDD")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("DDI")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("TelefoneId");

                    b.ToTable("InovaX_Tb_Telefone", (string)null);
                });

            modelBuilder.Entity("InovaXSprint.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("InovaXSprint.Models.Distribuidor", b =>
                {
                    b.HasBaseType("InovaXSprint.Models.Usuario");

                    b.Property<int?>("EnderecoId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<int?>("TelefoneId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasIndex("EnderecoId");

                    b.HasIndex("TelefoneId");

                    b.ToTable("InovaX_Tb_Distribuidor", (string)null);
                });

            modelBuilder.Entity("InovaXSprint.Models.PessoaFisica", b =>
                {
                    b.HasBaseType("InovaXSprint.Models.Usuario");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<int?>("EnderecoId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<int>("RG")
                        .HasColumnType("NUMBER(10)");

                    b.Property<int?>("TelefoneId")
                        .HasColumnType("NUMBER(10)");

                    b.HasIndex("EnderecoId");

                    b.HasIndex("TelefoneId");

                    b.ToTable("InovaX_Tb_PessoaFisica", (string)null);
                });

            modelBuilder.Entity("InovaXSprint.Models.PessoaJuridica", b =>
                {
                    b.HasBaseType("InovaXSprint.Models.Usuario");

                    b.Property<string>("CNPJ")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<int?>("EnderecoId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("NaturezaJuridica")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("NomeFantasia")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Situacao")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<int?>("TelefoneId")
                        .HasColumnType("NUMBER(10)");

                    b.HasIndex("EnderecoId");

                    b.HasIndex("TelefoneId");

                    b.ToTable("InovaX_Tb_PessoaJuridica", (string)null);
                });

            modelBuilder.Entity("DistribuidorProduto", b =>
                {
                    b.HasOne("InovaXSprint.Models.Distribuidor", null)
                        .WithMany()
                        .HasForeignKey("DistribuidoresId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InovaXSprint.Models.Produto", null)
                        .WithMany()
                        .HasForeignKey("ProdutosIdProduto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DistribuidorServico", b =>
                {
                    b.HasOne("InovaXSprint.Models.Distribuidor", null)
                        .WithMany()
                        .HasForeignKey("DistribuidoresId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InovaXSprint.Models.Servico", null)
                        .WithMany()
                        .HasForeignKey("ServicosIdServico")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("InovaXSprint.Models.Avaliacao", b =>
                {
                    b.HasOne("InovaXSprint.Models.Produto", "Produto")
                        .WithMany()
                        .HasForeignKey("ProdutoIdProduto");

                    b.HasOne("InovaXSprint.Models.Servico", "Servico")
                        .WithMany()
                        .HasForeignKey("ServicoIdServico");

                    b.Navigation("Produto");

                    b.Navigation("Servico");
                });

            modelBuilder.Entity("InovaXSprint.Models.Distribuidor", b =>
                {
                    b.HasOne("Endereco", "Endereco")
                        .WithMany()
                        .HasForeignKey("EnderecoId");

                    b.HasOne("InovaXSprint.Models.Usuario", null)
                        .WithOne()
                        .HasForeignKey("InovaXSprint.Models.Distribuidor", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InovaXSprint.Models.Telefone", "Telefone")
                        .WithMany()
                        .HasForeignKey("TelefoneId");

                    b.Navigation("Endereco");

                    b.Navigation("Telefone");
                });

            modelBuilder.Entity("InovaXSprint.Models.PessoaFisica", b =>
                {
                    b.HasOne("Endereco", "Endereco")
                        .WithMany()
                        .HasForeignKey("EnderecoId");

                    b.HasOne("InovaXSprint.Models.Usuario", null)
                        .WithOne()
                        .HasForeignKey("InovaXSprint.Models.PessoaFisica", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InovaXSprint.Models.Telefone", "Telefone")
                        .WithMany()
                        .HasForeignKey("TelefoneId");

                    b.Navigation("Endereco");

                    b.Navigation("Telefone");
                });

            modelBuilder.Entity("InovaXSprint.Models.PessoaJuridica", b =>
                {
                    b.HasOne("Endereco", "Endereco")
                        .WithMany()
                        .HasForeignKey("EnderecoId");

                    b.HasOne("InovaXSprint.Models.Usuario", null)
                        .WithOne()
                        .HasForeignKey("InovaXSprint.Models.PessoaJuridica", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InovaXSprint.Models.Telefone", "Telefone")
                        .WithMany()
                        .HasForeignKey("TelefoneId");

                    b.Navigation("Endereco");

                    b.Navigation("Telefone");
                });
#pragma warning restore 612, 618
        }
    }
}
