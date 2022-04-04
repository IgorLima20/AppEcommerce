﻿// <auto-generated />
using System;
using AppEcommerce.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AppEcommerce.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20220402025328_criar-segundo")]
    partial class criarsegundo
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.15");

            modelBuilder.Entity("AppEcommerce.Models.Categoria", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Imagem")
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Categoria");

                    b.HasData(
                        new
                        {
                            Id = new Guid("5e7d0963-0f25-4898-b61a-193622b32222"),
                            Imagem = "~/img/Produtos/001.png",
                            Nome = "Computadores"
                        },
                        new
                        {
                            Id = new Guid("710cbc38-b210-42e4-8376-b983589aa81a"),
                            Imagem = "~/img/Produtos/002.png",
                            Nome = "Celulares"
                        },
                        new
                        {
                            Id = new Guid("89cba3de-3c51-4e58-8bc2-b7058656190f"),
                            Imagem = "~/img/Produtos/003.png",
                            Nome = "Periféricos"
                        },
                        new
                        {
                            Id = new Guid("c975c21f-f560-4ec1-846c-80c503e8498a"),
                            Imagem = "~/img/Produtos/004.png",
                            Nome = "Games"
                        },
                        new
                        {
                            Id = new Guid("736dbd51-139c-478b-abac-a40edf495247"),
                            Imagem = "~/img/Produtos/005.png",
                            Nome = "Cadeiras"
                        },
                        new
                        {
                            Id = new Guid("b47a8499-1732-49c7-8082-ad2fc2f1ca57"),
                            Imagem = "~/img/Produtos/006.png",
                            Nome = "Conectividade"
                        });
                });

            modelBuilder.Entity("AppEcommerce.Models.Endereco", b =>
                {
                    b.Property<Guid>("IdEndereco")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("varchar(60)");

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasMaxLength(9)
                        .HasColumnType("varchar(9)");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("varchar(60)");

                    b.Property<string>("ClienteId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Complemento")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("varchar(2)");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Referencia")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("Selecionado")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("IdEndereco");

                    b.HasIndex("ClienteId");

                    b.ToTable("Endereco");
                });

            modelBuilder.Entity("AppEcommerce.Models.ItemPedido", b =>
                {
                    b.Property<Guid>("IdPedido")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("IdProduto")
                        .HasColumnType("char(36)");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.Property<double>("ValorUnitario")
                        .HasColumnType("double");

                    b.HasKey("IdPedido", "IdProduto");

                    b.HasIndex("IdProduto");

                    b.ToTable("ItemPedidos");
                });

            modelBuilder.Entity("AppEcommerce.Models.Marca", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Marca");

                    b.HasData(
                        new
                        {
                            Id = new Guid("ba9c684b-ec5b-4c0d-850c-352efd82b52a"),
                            Nome = "Nvidia"
                        },
                        new
                        {
                            Id = new Guid("42961b69-fb9f-41f5-adf5-85665e264aab"),
                            Nome = "Logitech"
                        });
                });

            modelBuilder.Entity("AppEcommerce.Models.Pedido", b =>
                {
                    b.Property<Guid>("IdPedido")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("DataEntrega")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataPedido")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("IdCliente")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<Guid>("IdEndereco")
                        .HasColumnType("char(36)");

                    b.Property<decimal>("ValorTotal")
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("IdPedido");

                    b.HasIndex("IdCliente");

                    b.HasIndex("IdEndereco");

                    b.ToTable("Pedido");
                });

            modelBuilder.Entity("AppEcommerce.Models.Produto", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Descricao")
                        .HasMaxLength(800)
                        .HasColumnType("varchar(800)");

                    b.Property<uint>("Estoque")
                        .HasColumnType("int unsigned");

                    b.Property<Guid>("IdCategoria")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("IdMarca")
                        .HasColumnType("char(36)");

                    b.Property<string>("Imagem")
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(400)
                        .HasColumnType("varchar(400)");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("Id");

                    b.HasIndex("IdCategoria");

                    b.HasIndex("IdMarca");

                    b.ToTable("Produto");

                    b.HasData(
                        new
                        {
                            Id = new Guid("b3df51e7-6cea-4cef-a1f0-5bc5b1035796"),
                            Descricao = "A Placa Gráfica Nvidia Quadro P400 combina a mais recente arquitetura NVIDIA Quadro Pascal GPU com 2GB de ultra-rápido de memória on-board para entregar ótimo desempenho para uma gama de aplicações profissionais. Um fator de forma de baixo perfil e slot único torna-o compatível até com o chassi com mais espaço e com menor consumo de energia. O suporte para três monitores 4K (4096 x 2160 a 60Hz) com cores HDR oferece um amplo espaço de trabalho visual para visualizar seu trabalho em resolução extremamente alta.",
                            Estoque = 8u,
                            IdCategoria = new Guid("5e7d0963-0f25-4898-b61a-193622b32222"),
                            IdMarca = new Guid("ba9c684b-ec5b-4c0d-850c-352efd82b52a"),
                            Imagem = "~/img/Produtos/1.jpg",
                            Nome = "Placa Gráfica Nvidia Quadro P400 2gb Gddr5 64bits - Pny Vcqp400v2-pb",
                            Valor = 1223.99m
                        },
                        new
                        {
                            Id = new Guid("d66bd7f4-e61a-49ef-aadb-762cb49e7c43"),
                            Descricao = "O novíssimo GALAX Serious Gaming Edition está equipado com 1-Clip Booster, que pode ser instalado na placa traseira e é a precisão e qualidade que ganham. Quando o ventilador está na parte de trás, a placa de circuito impresso é na verdade muito mais curta do que o cooler e a chave é permitir que o ar flua o mais facilmente possível, portanto, o GALAX construiu orifícios maiores que permitem que o ar flua para cumprir o primeiro requisito. Além disso, a vantagem de adicionar uma ventoinha na placa traseira, o design da ventoinha auxiliar de 1 clipe suga o ar em vez de soprar o ar para dentro, criando efeitos de resfriamento push-pull tecnicamente corretos. Quando esta ventoinha adicional é usada, ela pode obter um melhor desempenho como se uma GPU funcionasse com uma placa traseira normal.",
                            Estoque = 10u,
                            IdCategoria = new Guid("5e7d0963-0f25-4898-b61a-193622b32222"),
                            IdMarca = new Guid("ba9c684b-ec5b-4c0d-850c-352efd82b52a"),
                            Imagem = "~/img/Produtos/2.jpg",
                            Nome = "Placa De Vídeo Galax GeForce RTX 3070 Ti SG 1-Click 8gb GDRR6X 256bits 37ISM6MD4BSG",
                            Valor = 7936m
                        },
                        new
                        {
                            Id = new Guid("647df8c8-770a-420b-b0b1-ee9862c9d31e"),
                            Descricao = "O G403 HERO tem a versatilidade e o desempenho para atender todos os tipos de jogos e jogadores. Um mouse gamer leve, ergonômico e totalmente projetado para oferecer a precisão que você exige para jogar em alto nível, agora com o SENSOR HERO 25K de última geração.",
                            Estoque = 16u,
                            IdCategoria = new Guid("89cba3de-3c51-4e58-8bc2-b7058656190f"),
                            IdMarca = new Guid("42961b69-fb9f-41f5-adf5-85665e264aab"),
                            Imagem = "~/img/Produtos/3.jpg",
                            Nome = "Mouse Gamer Logitech G403 HERO com RGB LIGHTSYNC, 6 Botões Programáveis, Ajuste de Peso e Sensor HERO 25K - 910-005631",
                            Valor = 209m
                        },
                        new
                        {
                            Id = new Guid("40955cac-7f3d-4099-9a2c-88f65f4da47c"),
                            Descricao = "xperimente chamadas de voz, Skype, webinars e muito mais com clareza usando uma conexão USB plug-and-play simples com o headset H390. O microfone rígido do lado esquerdo pode ser colocado na posição mais adequada para capturar melhor sua voz e é móvel podendo ser recolhido para não atrapalhar quando não estiver sendo usado. Os controles integrados no fio do headset permitem controlar o volume ou colocar chamadas em silêncio com facilidade. O arco de cabeça ajustável com fones acolchoados giratórios de couro sintético oferece horas de conforto. E também é fácil de limpar.",
                            Estoque = 20u,
                            IdCategoria = new Guid("89cba3de-3c51-4e58-8bc2-b7058656190f"),
                            IdMarca = new Guid("42961b69-fb9f-41f5-adf5-85665e264aab"),
                            Imagem = "~/img/Produtos/4.jpg",
                            Nome = "Headset com fio USB Logitech H390 com Almofadas em Couro, Controles de Áudio Integrado e Microfone com Redução de Ruído - 981-000014",
                            Valor = 179.99m
                        });
                });

            modelBuilder.Entity("AppEcommerce.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NomeCompleto")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            Id = "1902f2ee-cd2a-4a09-9fe4-29629ba3887e",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "ec622d29-faf6-4c6d-a32c-768ad6f694cf",
                            Email = "admin@ecommerce.com.br",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NomeCompleto = "Igor Oliveira de Lima",
                            NormalizedEmail = "ADMIN@ECOMMERCE.COM.BR",
                            NormalizedUserName = "ADMIN",
                            PasswordHash = "AQAAAAEAACcQAAAAEAUYENyKtY2zvnw4Ie0DBL6ajagYrwNgTeh9eQpORwU6gMOqyPSvftRradybOujmbg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "12405375",
                            TwoFactorEnabled = false,
                            UserName = "Admin"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("Role");

                    b.HasData(
                        new
                        {
                            Id = "1902f2ee-cd2a-4a09-9fe4-29629ba3887e",
                            ConcurrencyStamp = "9c9bc30a-4aa7-4de2-a9c0-158653fbd5fb",
                            Name = "Administrador",
                            NormalizedName = "ADMINISTRADOR"
                        },
                        new
                        {
                            Id = "eee44020-2dea-4147-a7f6-7a33e21707ea",
                            ConcurrencyStamp = "561d6884-4fee-47cf-af96-bc97aba31e61",
                            Name = "Moderador",
                            NormalizedName = "MODERADOR"
                        },
                        new
                        {
                            Id = "6cfa3d77-8ab3-45ca-afce-2537ba224605",
                            ConcurrencyStamp = "e19dd368-e76c-4326-8495-24161365c6dc",
                            Name = "Usuario",
                            NormalizedName = "USUARIO"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("RoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("UserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("RoleId")
                        .HasColumnType("varchar(255)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRoles");

                    b.HasData(
                        new
                        {
                            UserId = "1902f2ee-cd2a-4a09-9fe4-29629ba3887e",
                            RoleId = "1902f2ee-cd2a-4a09-9fe4-29629ba3887e"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Value")
                        .HasColumnType("longtext");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("UserTokens");
                });

            modelBuilder.Entity("AppEcommerce.Models.Cliente", b =>
                {
                    b.HasBaseType("AppEcommerce.Models.User");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("varchar(11)");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("RG")
                        .IsRequired()
                        .HasMaxLength(9)
                        .HasColumnType("varchar(9)");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("AppEcommerce.Models.Endereco", b =>
                {
                    b.HasOne("AppEcommerce.Models.Cliente", null)
                        .WithMany("Endereco")
                        .HasForeignKey("ClienteId");
                });

            modelBuilder.Entity("AppEcommerce.Models.ItemPedido", b =>
                {
                    b.HasOne("AppEcommerce.Models.Pedido", "Pedido")
                        .WithMany("ItensPedido")
                        .HasForeignKey("IdPedido")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AppEcommerce.Models.Produto", "Produto")
                        .WithMany("ProdutosItens")
                        .HasForeignKey("IdProduto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pedido");

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("AppEcommerce.Models.Pedido", b =>
                {
                    b.HasOne("AppEcommerce.Models.Cliente", "Cliente")
                        .WithMany("Pedido")
                        .HasForeignKey("IdCliente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AppEcommerce.Models.Endereco", "EnderecoEntrega")
                        .WithMany()
                        .HasForeignKey("IdEndereco")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("EnderecoEntrega");
                });

            modelBuilder.Entity("AppEcommerce.Models.Produto", b =>
                {
                    b.HasOne("AppEcommerce.Models.Categoria", "Categoria")
                        .WithMany()
                        .HasForeignKey("IdCategoria")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AppEcommerce.Models.Marca", "Marca")
                        .WithMany()
                        .HasForeignKey("IdMarca")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");

                    b.Navigation("Marca");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("AppEcommerce.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("AppEcommerce.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AppEcommerce.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("AppEcommerce.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AppEcommerce.Models.Cliente", b =>
                {
                    b.HasOne("AppEcommerce.Models.User", null)
                        .WithOne()
                        .HasForeignKey("AppEcommerce.Models.Cliente", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AppEcommerce.Models.Pedido", b =>
                {
                    b.Navigation("ItensPedido");
                });

            modelBuilder.Entity("AppEcommerce.Models.Produto", b =>
                {
                    b.Navigation("ProdutosItens");
                });

            modelBuilder.Entity("AppEcommerce.Models.Cliente", b =>
                {
                    b.Navigation("Endereco");

                    b.Navigation("Pedido");
                });
#pragma warning restore 612, 618
        }
    }
}