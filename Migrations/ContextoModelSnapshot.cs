﻿// <auto-generated />
using System;
using AppEcommerce.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AppEcommerce.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                            Id = new Guid("b4e01979-6fcf-4feb-b1cb-c172ad44b8f4"),
                            Imagem = "~/img/Produtos/001.png",
                            Nome = "Hardware"
                        },
                        new
                        {
                            Id = new Guid("715fec1d-0cf6-4f44-adec-2d2ccb7d35d0"),
                            Imagem = "~/img/Produtos/002.png",
                            Nome = "Celulares"
                        },
                        new
                        {
                            Id = new Guid("613a6739-52cb-49eb-af65-d701f4ddf895"),
                            Imagem = "~/img/Produtos/003.png",
                            Nome = "Periféricos"
                        },
                        new
                        {
                            Id = new Guid("e1da9e97-7a9b-4956-8a01-042439ed752b"),
                            Imagem = "~/img/Produtos/004.png",
                            Nome = "Games"
                        },
                        new
                        {
                            Id = new Guid("fd15c5ef-e57a-4ab7-9ca3-22467f93eab7"),
                            Imagem = "~/img/Produtos/005.png",
                            Nome = "Cadeiras"
                        },
                        new
                        {
                            Id = new Guid("0ab2f94b-42b6-4d57-bf86-c96e16b1aa6c"),
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
                            Id = new Guid("05e05427-6f80-4f02-9b83-3d39f2355011"),
                            Nome = "Nvidia"
                        },
                        new
                        {
                            Id = new Guid("85486af8-07ba-455c-8e16-245721253aa2"),
                            Nome = "Logitech"
                        },
                        new
                        {
                            Id = new Guid("b71ed344-64df-4479-bda4-c7f277026b91"),
                            Nome = "Motorola"
                        },
                        new
                        {
                            Id = new Guid("c08f9f34-0427-4c68-b456-4fa8e7c5309c"),
                            Nome = "D-Link"
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
                            Id = new Guid("12bcc7ee-5a79-4d94-8f7b-25349d21e7d0"),
                            Descricao = "A Placa Gráfica Nvidia Quadro P400 combina a mais recente arquitetura NVIDIA Quadro Pascal GPU com 2GB de ultra-rápido de memória on-board para entregar ótimo desempenho para uma gama de aplicações profissionais. Um fator de forma de baixo perfil e slot único torna-o compatível até com o chassi com mais espaço e com menor consumo de energia. O suporte para três monitores 4K (4096 x 2160 a 60Hz) com cores HDR oferece um amplo espaço de trabalho visual para visualizar seu trabalho em resolução extremamente alta.",
                            Estoque = 8u,
                            IdCategoria = new Guid("b4e01979-6fcf-4feb-b1cb-c172ad44b8f4"),
                            IdMarca = new Guid("05e05427-6f80-4f02-9b83-3d39f2355011"),
                            Imagem = "~/img/Produtos/1.jpg",
                            Nome = "Placa Gráfica Nvidia Quadro P400 2gb Gddr5 64bits - Pny Vcqp400v2-pb",
                            Valor = 1223.99m
                        },
                        new
                        {
                            Id = new Guid("d20fed84-1f98-4465-b7b6-e70993fa413f"),
                            Descricao = "O novíssimo GALAX Serious Gaming Edition está equipado com 1-Clip Booster, que pode ser instalado na placa traseira e é a precisão e qualidade que ganham. Quando o ventilador está na parte de trás, a placa de circuito impresso é na verdade muito mais curta do que o cooler e a chave é permitir que o ar flua o mais facilmente possível, portanto, o GALAX construiu orifícios maiores que permitem que o ar flua para cumprir o primeiro requisito. Além disso, a vantagem de adicionar uma ventoinha na placa traseira, o design da ventoinha auxiliar de 1 clipe suga o ar em vez de soprar o ar para dentro, criando efeitos de resfriamento push-pull tecnicamente corretos. Quando esta ventoinha adicional é usada, ela pode obter um melhor desempenho como se uma GPU funcionasse com uma placa traseira normal.",
                            Estoque = 10u,
                            IdCategoria = new Guid("b4e01979-6fcf-4feb-b1cb-c172ad44b8f4"),
                            IdMarca = new Guid("05e05427-6f80-4f02-9b83-3d39f2355011"),
                            Imagem = "~/img/Produtos/2.jpg",
                            Nome = "Placa De Vídeo Galax GeForce RTX 3070 Ti SG 1-Click 8gb GDRR6X 256bits 37ISM6MD4BSG",
                            Valor = 7936m
                        },
                        new
                        {
                            Id = new Guid("9468ac4d-88e6-4594-b356-626d19769f28"),
                            Descricao = "O G403 HERO tem a versatilidade e o desempenho para atender todos os tipos de jogos e jogadores. Um mouse gamer leve, ergonômico e totalmente projetado para oferecer a precisão que você exige para jogar em alto nível, agora com o SENSOR HERO 25K de última geração.",
                            Estoque = 16u,
                            IdCategoria = new Guid("613a6739-52cb-49eb-af65-d701f4ddf895"),
                            IdMarca = new Guid("85486af8-07ba-455c-8e16-245721253aa2"),
                            Imagem = "~/img/Produtos/3.jpg",
                            Nome = "Mouse Gamer Logitech G403 HERO com RGB LIGHTSYNC, 6 Botões Programáveis, Ajuste de Peso e Sensor HERO 25K - 910-005631",
                            Valor = 209m
                        },
                        new
                        {
                            Id = new Guid("e27803dc-40c5-41d9-9c28-366a4f3ec057"),
                            Descricao = "xperimente chamadas de voz, Skype, webinars e muito mais com clareza usando uma conexão USB plug-and-play simples com o headset H390. O microfone rígido do lado esquerdo pode ser colocado na posição mais adequada para capturar melhor sua voz e é móvel podendo ser recolhido para não atrapalhar quando não estiver sendo usado. Os controles integrados no fio do headset permitem controlar o volume ou colocar chamadas em silêncio com facilidade. O arco de cabeça ajustável com fones acolchoados giratórios de couro sintético oferece horas de conforto. E também é fácil de limpar.",
                            Estoque = 20u,
                            IdCategoria = new Guid("613a6739-52cb-49eb-af65-d701f4ddf895"),
                            IdMarca = new Guid("85486af8-07ba-455c-8e16-245721253aa2"),
                            Imagem = "~/img/Produtos/4.jpg",
                            Nome = "Headset com fio USB Logitech H390 com Almofadas em Couro, Controles de Áudio Integrado e Microfone com Redução de Ruído - 981-000014",
                            Valor = 179.99m
                        },
                        new
                        {
                            Id = new Guid("3f8c6847-e4d0-4db0-9e43-7181c20463c3"),
                            Descricao = "O G305 apresenta o sensor HERO de última geração com sensibilidade de 200 a 12.000 DPI para precisão de nível de competição. A tecnologia sem fio LIGHTSPEED oferece desempenho super rápido de 1ms. Com incrível eficiência de energia, o G305 permanece ligado e pronto para jogar por até 250 horas com uma única pilha AA inclusa.",
                            Estoque = 1u,
                            IdCategoria = new Guid("613a6739-52cb-49eb-af65-d701f4ddf895"),
                            IdMarca = new Guid("85486af8-07ba-455c-8e16-245721253aa2"),
                            Imagem = "~/img/Produtos/5.jpg",
                            Nome = "Mouse Gamer Sem Fio Logitech G305 Lightspeed, 12.000 DPI, 6 Botões Programáveis, Branco - 910-005290",
                            Valor = 349.9m
                        },
                        new
                        {
                            Id = new Guid("3fcab97b-3dc8-4ee3-8132-16cba77af00a"),
                            Descricao = "Potência e desempenho em uma Solução Compacta. A NVIDIA T1000, desenvolvida com base na arquitetura de GPU NVIDIA Turing, é uma solução poderosa e discreta que oferece excelentes recursos e desempenho exigidos por intensos aplicativos profissionais em uma placa gráfica de formato compacto. Com 896 CUDA Cores e 4 GB de memória GDDR6, a T1000 permite que os profissionais lidem com vários fluxos de trabalho, desde a modelagem 3D até a edição de vídeo.",
                            Estoque = 0u,
                            IdCategoria = new Guid("b4e01979-6fcf-4feb-b1cb-c172ad44b8f4"),
                            IdMarca = new Guid("05e05427-6f80-4f02-9b83-3d39f2355011"),
                            Imagem = "~/img/Produtos/6.jpg",
                            Nome = "Pny Quadro Workstation Server Placa De Video Pny Vcnt1000-pb T1000 4GB DDR6 128bit Dp",
                            Valor = 2743.98m
                        },
                        new
                        {
                            Id = new Guid("e4a42b4b-bfb6-4b5c-aecd-685aec028829"),
                            Descricao = "O Smartphone Moto E7 conta com sensor de câmera de 48MP que deixam as fotos sempre claras e nítidas, em qualquer iluminação. A tecnologia que o acompanha, Quad Pixel, proporciona 4 vezes mais sensibilidade a luz, para que os resultados fiquem ótimos em qualquer ambiente.",
                            Estoque = 20u,
                            IdCategoria = new Guid("715fec1d-0cf6-4f44-adec-2d2ccb7d35d0"),
                            IdMarca = new Guid("b71ed344-64df-4479-bda4-c7f277026b91"),
                            Imagem = "~/img/Produtos/7.jpg",
                            Nome = "Smartphone Motorola Moto E7, 64GB, RAM 4GB, Octa-Core, Câmera 48MP, 4000mAh, Cinza Metálico - PALV0031BR",
                            Valor = 892.05m
                        },
                        new
                        {
                            Id = new Guid("024aaa9f-fdbf-4adc-8055-a3325df5c125"),
                            Descricao = "Com recursos de ponta como TR-069 e interface web amigável que possibilita a criação de uma firmware personalizável, o DIR-842 é perfeito para provedores de internet que desejam implementar uma solução Wi-Fi de alta qualidade com a possibilidade de personalizar diversos dispositivos ao mesmo tempo. ",
                            Estoque = 10u,
                            IdCategoria = new Guid("0ab2f94b-42b6-4d57-bf86-c96e16b1aa6c"),
                            IdMarca = new Guid("c08f9f34-0427-4c68-b456-4fa8e7c5309c"),
                            Imagem = "~/img/Produtos/8.jpg",
                            Nome = "Roteador Wireless D-Link Gigabit-Ethernet AC 1200Mbps, Dual Band, 4 Antenas - DIR-842",
                            Valor = 164.9m
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
                            Id = "dd3c4e7f-9385-4a9b-927b-97ff0550f2c2",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "7e61b1a4-e220-4338-a0f1-178436d44cc5",
                            Email = "admin@ecommerce.com.br",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NomeCompleto = "Igor Oliveira de Lima",
                            NormalizedEmail = "ADMIN@ECOMMERCE.COM.BR",
                            NormalizedUserName = "ADMIN",
                            PasswordHash = "AQAAAAEAACcQAAAAEKGbJ1uA41Fzg2bl2S+lIYVLupEPaonWOKNzX5CfGGKmHrE/CXwz702m7xo4frPOkw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "44539515",
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
                            Id = "dd3c4e7f-9385-4a9b-927b-97ff0550f2c2",
                            ConcurrencyStamp = "7604ce93-acf4-4cb4-b1a9-4ab8cf8f4e16",
                            Name = "Administrador",
                            NormalizedName = "ADMINISTRADOR"
                        },
                        new
                        {
                            Id = "b1107611-9c23-4f96-a8ba-99cc697546dd",
                            ConcurrencyStamp = "25dbeae9-3c48-4b70-a9aa-5612fbfdc406",
                            Name = "Moderador",
                            NormalizedName = "MODERADOR"
                        },
                        new
                        {
                            Id = "364d87df-97c5-4b87-ae80-3ffac118b4d7",
                            ConcurrencyStamp = "1cded357-6c5e-4306-9142-861b7320eff7",
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
                            UserId = "dd3c4e7f-9385-4a9b-927b-97ff0550f2c2",
                            RoleId = "dd3c4e7f-9385-4a9b-927b-97ff0550f2c2"
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
