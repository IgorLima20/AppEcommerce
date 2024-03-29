﻿using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AppEcommerce.Migrations
{
    public partial class criarbanco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Imagem = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Contato",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(160)", maxLength: 160, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Assunto = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Mensagem = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataEnviada = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contato", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ImagensSite",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Ordem = table.Column<uint>(type: "int unsigned", nullable: false),
                    Img = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Carrosel = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Secundaria = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImagensSite", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Marca",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Imagem = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ExibirHome = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marca", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LastName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Address = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    City = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    State = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PostalCode = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Country = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Phone = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Total = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NomeCompleto = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedUserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedEmail = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmailConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    PasswordHash = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SecurityStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumber = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumberConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Produto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NomeDescricao = table.Column<string>(type: "varchar(400)", maxLength: 400, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Valor = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Estoque = table.Column<uint>(type: "int unsigned", nullable: false),
                    Descricao = table.Column<string>(type: "varchar(800)", maxLength: 800, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdCategoria = table.Column<int>(type: "int", nullable: false),
                    IdMarca = table.Column<int>(type: "int", nullable: false),
                    ImagemPrincipal = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ExibirHome = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Produto_Categoria_IdCategoria",
                        column: x => x.IdCategoria,
                        principalTable: "Categoria",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Produto_Marca_IdMarca",
                        column: x => x.IdMarca,
                        principalTable: "Marca",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "RoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoleClaims_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "UserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserClaims_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "UserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderKey = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderDisplayName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_UserLogins_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RoleId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_UserRoles_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "UserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LoginProvider = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Value = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_UserTokens_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Imagens",
                columns: table => new
                {
                    IdImagem = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Img = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdProduto = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Imagens", x => x.IdImagem);
                    table.ForeignKey(
                        name: "FK_Imagens_Produto_IdProduto",
                        column: x => x.IdProduto,
                        principalTable: "Produto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    OrderDetailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    ProdutoId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(65,30)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.OrderDetailId);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Produto_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ShoppingCartItems",
                columns: table => new
                {
                    ShoppingCartItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ProdutoId = table.Column<int>(type: "int", nullable: true),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    ShoppingCartId = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCartItems", x => x.ShoppingCartItemId);
                    table.ForeignKey(
                        name: "FK_ShoppingCartItems_Produto_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Categoria",
                columns: new[] { "Id", "Imagem", "Nome" },
                values: new object[,]
                {
                    { 1, "\\img\\categorias\\001.png", "Hardware" },
                    { 11, "\\img\\categorias\\011.png", "Serviços Digitais e Softwares" },
                    { 10, "\\img\\categorias\\010.png", "Câmeras Digitais" },
                    { 9, "\\img\\categorias\\009.png", "Segurança" },
                    { 8, "\\img\\categorias\\008.png", "Áudio" },
                    { 7, "\\img\\categorias\\007.png", "TV" },
                    { 12, "\\img\\categorias\\012.png", "Automotivo" },
                    { 5, "\\img\\categorias\\005.png", "Cadeiras" },
                    { 4, "\\img\\categorias\\004.png", "Games" },
                    { 3, "\\img\\categorias\\003.png", "Periféricos" },
                    { 2, "\\img\\categorias\\002.png", "Celulares" },
                    { 6, "\\img\\categorias\\006.png", "Conectividade" }
                });

            migrationBuilder.InsertData(
                table: "ImagensSite",
                columns: new[] { "Id", "Carrosel", "Img", "Ordem", "Secundaria" },
                values: new object[,]
                {
                    { 3, false, "\\img\\carrosel\\04.png", 2u, true },
                    { 4, false, "\\img\\carrosel\\05.png", 2u, true },
                    { 1, true, "\\img\\carrosel\\01.jpg", 1u, false },
                    { 2, true, "\\img\\carrosel\\02.jpg", 2u, false }
                });

            migrationBuilder.InsertData(
                table: "Marca",
                columns: new[] { "Id", "ExibirHome", "Imagem", "Nome" },
                values: new object[,]
                {
                    { 10, true, "\\img\\marcas\\hp.png", "Hp" },
                    { 16, false, null, "LG" },
                    { 15, false, null, "K-WHEEL" },
                    { 14, true, "\\img\\marcas\\sony.png", "Sony" },
                    { 13, true, "\\img\\marcas\\positivo.png", "Positivo" },
                    { 12, true, "\\img\\marcas\\lenovo.png", "Lenovo" },
                    { 11, true, "\\img\\marcas\\multilaser.png", "Multilaser" },
                    { 9, true, "\\img\\marcas\\dell.png", "Dell" },
                    { 2, false, null, "Logitech" },
                    { 7, false, null, "Razer" },
                    { 6, true, "\\img\\marcas\\acer.png", "Acer" },
                    { 5, true, "\\img\\marcas\\asus.png", "Asus" },
                    { 4, false, null, "D-Link" },
                    { 3, false, null, "Motorola" },
                    { 1, false, null, "Nvidia" },
                    { 8, true, "\\img\\marcas\\apple.png", "Apple" }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ccf1de4f-faf2-4780-b185-fc1654df652d", "48963720-2b13-4308-a206-810df12d7716", "Moderador", "MODERADOR" },
                    { "e8404eb5-efdc-4fcf-a078-d1e58813cef1", "6723ac03-00ef-4270-af57-4594b3463140", "Administrador", "ADMINISTRADOR" },
                    { "de1f1438-21c9-411c-86c5-58e71a31b1dd", "3cb3a025-81fc-4041-8d31-f87e25e57191", "Usuario", "USUARIO" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NomeCompleto", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e8404eb5-efdc-4fcf-a078-d1e58813cef1", 0, "ddf1e5f5-18f0-418e-af22-41f51e412eaf", "igorsax258@gmail.com", true, false, null, "Igor Oliveira de Lima", "IGORSAX258@GMAIL.COM", "ADMIN", "AQAAAAEAACcQAAAAEJ8jZwf/7/N8s5O98wz9Sq8zKYVMrVLU1Q/ZMn+EqwIWXmpuGKKJqislZOD5Wq6msw==", null, false, "24757801", false, "Admin" });

            migrationBuilder.InsertData(
                table: "Produto",
                columns: new[] { "Id", "Descricao", "Estoque", "ExibirHome", "IdCategoria", "IdMarca", "ImagemPrincipal", "Nome", "NomeDescricao", "Valor" },
                values: new object[,]
                {
                    { 1, "A Placa Gráfica Nvidia Quadro P400 combina a mais recente arquitetura NVIDIA Quadro Pascal GPU com 2GB de ultra-rápido de memória on-board para entregar ótimo desempenho para uma gama de aplicações profissionais. Um fator de forma de baixo perfil e slot único torna-o compatível até com o chassi com mais espaço e com menor consumo de energia. O suporte para três monitores 4K (4096 x 2160 a 60Hz) com cores HDR oferece um amplo espaço de trabalho visual para visualizar seu trabalho em resolução extremamente alta.", 8u, true, 1, 1, "\\img\\produtos\\1.jpg", "Placa Gráfica Nvidia Quadro P400", "Placa Gráfica Nvidia Quadro P400 2gb Gddr5 64bits - Pny Vcqp400v2-pb", 1223m },
                    { 24, "Otimize a sua experiência de corrida com uma ação de mudança de marcha realista. O câmbio Driving Force da Logitech é o melhor câmbio de simulação do mercado, projetado para os volantes de corrida Driving Force G29, G920 e G923. Com sólidos eixos de engrenagem de aço e couro costurado à mão de alta qualidade, o Driving Force foi construído para corridas de precisão e confiabilidade duradoura.", 3u, false, 4, 15, "\\img\\produtos\\25.jpg", "Câmbio Logitech G Driving Force", "Câmbio Logitech G Driving Force, Compatível com Volantes Logitech G923, G29 e G920 para PS5, PS4, Xbox Series X|S, Xbox One, PC - 941-000119", 389m },
                    { 23, "K-Wheel é um volante e conjunto de pedais otimizado para todos os tipos de jogos de corrida, que surgiu para oferecer-lhe máxima segurança e controlo, mesmo nas manobras mais extremas. Experimente a adrenalina dos pilotos de corrida a partir do seu ecrã graças a esta configuração de condução completa.", 2u, false, 4, 15, "\\img\\produtos\\24.jpg", "Volante de Jogos NOX Krom K-Wheel", "Volante de Jogos NOX Krom K-Wheel para PS4, PS3, Xbox One, PC - NXKROMKWHL", 349m },
                    { 26, "Conheça a linha de TVs Smart e Durável da Sony! A KDL-43W665F foi cuidadosamente desenvolvida para oferecer maior segurança e durabilidade. Graças à tecnologia X-Protection PRO sua TV traz mais proteção contra poeira, umidade, raios e surtos de tensão. Com a função SmartTV você tem acesso aos melhores conteúdos da Internet, e o melhor, você decide quando quer assistir.", 2u, false, 7, 14, "\\img\\produtos\\27.jpg", "Smart TV LED 43 Full HD Sony", "Smart TV LG 43 4K UHD 43UP7500, com WiFi e Bluetooth, HDR, ThinQAI Compatível com Inteligência Artificial - 43UP7500PSF", 2800m },
                    { 21, "Tenha um smartphone diferenciado em suas mãos! O Positivo Twist 3 Pro S533 produz fotos com ótima qualidade, pois oferece uma câmera de 8MP na traseira, permitindo que você capte as melhores fotografias. Faça fotos criativas e compartilhe nas redes sociais, através da câmera de selfie de 8MP com flash LED. Sua tela de 5,7 IPS e resolução HD+ oferecem a melhor experiência para você ver seus conteúdos de maneira mais imersiva e com visual impressionante. Com 64GB de armazenamento interno, ele é ideal para guardar suas fotos, músicas ou vídeos!", 12u, false, 2, 13, "\\img\\produtos\\22.jpg", "Smartphone Positivo Twist 3 Pro S533", "Smartphone Positivo Twist 3 Pro S533, 64GB, Grafite, 3G, Quad-Core, 1GB RAM, 5.7?, Câm. 8MP + Selfie 8MP", 699m },
                    { 20, "O iPhone 13 Pro foi feito para pouca luz. A câmera Wide adiciona uma abertura mais ampla e nosso maior sensor - e aproveita o Scanner LiDAR para retratos no modo Noturno, além da telefoto também capturar imagens com baixa insidencia de luz e contar com zoom ótico 3x ótimo para retratos clássicos ou tirar fotos e vídeos mais nítidos de longe. Ultra Wide obtém uma abertura mais ampla, um sensor mais rápido e um foco automático totalmente novo, ela captura 92% mais luz para melhores fotos e vídeos. .", 1u, false, 2, 8, "\\img\\produtos\\21.jpg", "iPhone 13 Pro 128GB Dourado, 5G, Tela de 6.1", "iPhone 13 Pro 128GB Dourado, 5G, Tela de 6.1, Câmera Tripla 12MP - MLVC3BZ/A", 7499m },
                    { 19, "IPhone 11 Apple Tudo na medida certa. Novo sistema de câmera dupla. Bateria que dura o dia todo'. O vidro mais resistente em um smartphone. E o chip mais rápido da Apple. Grave vídeos 4K, faça belos retratos e capture paisagens inteiras com o novo sistema de câmera dupla. Deixe seu dia mais bonito. Impressionante tela Liquid Retina LCD de 6,1 polegadas sem bordas. Bateria para o dia todo. Chip A13 Bionic, o mais rápido em um smartphone. E recarga rápida com carregador de 18W.", 4u, false, 2, 8, "\\img\\produtos\\20.jpg", "iPhone 11 64GB Preto, 4G, Tela de 6.1", "iPhone 11 64GB Preto, 4G, Tela de 6.1, Câmera Dupla 12MP + Selfie 12MP - MHDA3BR/A", 3989m },
                    { 18, "Cabo Apple Lightning para USB 2M Descrição do Produto: O Cabo Apple Lightning serve para conectar seu iPhone, iPad ou iPod com conector Lightning à porta USB do seu computador. Com ele você sincroniza o dispositivo e carrega a bateria.", 10u, false, 3, 8, "\\img\\produtos\\19.jpg", "Cabo Apple Lightning", "Cabo Apple Lightning Para Usb 2m", 339m },
                    { 17, "Agora disponível em cinza-espacial. O Magic Mouse 2 pode ser recarregado e dispensa o uso de pilhas. Ele está mais leve e tem menos peças móveis, graças à bateria interna. A parte inferior com design otimizado e em peça única facilita o controle e os movimentos pela mesa. Além disso, a superfície Multi-Touch permite que você faça movimentos simples como deslizar pelas páginas da web e percorrer documentos. O Magic Mouse 2 já vem pronto para usar e é emparelhado automaticamente com seu Mac.", 1u, false, 3, 8, "\\img\\produtos\\18.jpg", "Mouse Apple Magic 2 Space Gray", "Mouse Apple Magic 2 Space Gray -mrme2ll/a", 1233m },
                    { 16, "Estes fones intra-auriculares sem fio têm uma latência de entrada extremamente baixa de 60 ms, o que significa que o áudio permanece sincronizado com seu dispositivo sem nunca falhar, oferecendo uma vantagem competitiva de jogo e uma experiência mais imersiva para vídeos e música. A verdadeira liberdade sem fio Ouça sem limites e leve os seus lugares de áudio a novos patamares com Razer Hammerhead True Wireless Earbuds e seu desempenho de som perfeito que você pode curtir em qualquer qualidade.", 5u, false, 3, 7, "\\img\\produtos\\17.jpg", "Fone de Ouvido Bluetooth Razer Hammerhead True Wireless", "Fone de Ouvido Bluetooth Razer Hammerhead True Wireless, Recarregável, Resistente a Água - RZ12-02970100-R3U1", 749m },
                    { 15, "Um grande som pode estar contido em uma pequena embalagem. Conheça o Razer Seiren Mini, um microfone condensador ultracompacto perfeito para um áudio de nível profissional com qualquer setup de videochamada ou transmissão. Como este microfone condensador compacto está afinado com um ângulo de captação mais estreito, ele pode focar na sua voz e apresentar uma melhor redução de ruído ambiente, assegurando que os sons de fundo, como o barulho das teclas ou os cliques do mouse, sejam minimizados.", 2u, false, 3, 7, "\\img\\produtos\\16.jpg", "Microfone Razer Seiren Mini", "Microfone Razer Seiren Mini, USB, Black - RZ19-03450100-R3U1", 399m },
                    { 14, "Quem se importa com o que os outros dizem? Defenda seu próprio estilo de jogo com o Razer Basilisk V2. Ajuste, alterne e afine seu desempenho com este mouse gamer altamente personalizável, para criar seu próprio modo de domínio e deixar sua marca no campo de batalha. 11 BOTÕES PROGRAMÁVEIS: Tenha um maior arsenal de comandos na ponta dos seus dedos mapeando suas macros e funções secundárias favoritas com o Razer Synapse 3. Como seu predecessor, o Razer Basilisk V2 inclui a característica palheta multifuncional. RAZER HYPERSHIFT: Extraia o máximo deste mouse programável mapeando seus 11 botões com o Razer Hypershift, um recurso avançado do Razer Synapse 3 que efetivamente duplica os comandos do seu mouse.", 6u, false, 3, 7, "\\img\\produtos\\15.jpg", "Mouse Gamer Razer Basilisk V2", "Mouse Gamer Razer Basilisk V2, Chroma, Optical Switch, 11 Botões, 20000DPI - RZ01-03160100-R3U1", 399m },
                    { 25, "Real TV LG 4K UHD Imersão Surreal A Smart TVs LG UHD sempre superam as expectativas. Experimente qualidade de imagem realista e cores vivas com quatro vezes mais precisão de pixels do que em Full HD. Desempenho arrasador garantido. Leve o cinema para casa. FILMMAKER MODE, HDR proporcionam uma experiência de visualização mais imersiva. Fique conectado com sua plataforma de streaming preferida para acessar o conteúdo que você adora. Todos os seus apps favoritos em um só lugar Acesse Netflix, Disney+, aplicativo Apple TV e Amazon prime video. Escolha entre os mais recentes filmes, programas de TV, documentários e esportes ao vivo e encontre todos eles em um só lugar, na sua Smart TV LG.", 1u, false, 7, 16, "\\img\\produtos\\26.jpg", "Smart TV LG 43 4K UHD 43UP7500", "Smart TV LG 43 4K UHD 43UP7500, com WiFi e Bluetooth, HDR, ThinQAI Compatível com Inteligência Artificial - 43UP7500PSF", 2149m },
                    { 13, "O tecido do Razer Goliathus V2 Speed Edition é esticado para criar uma superfície lisa e uniforme, permitindo que o seu mouse de jogo deslize rapidamente e sem dificuldade. O tecido também proporciona uma sensação confortável para o pulso e a mão, minimizando a fadiga durante partidas prolongadas.", 20u, false, 3, 7, "\\img\\produtos\\14.jpg", "Mousepad Gamer Razer Goliathus Terra", "Mousepad Gamer Razer Goliathus Terra, Speed, Médio (355x254mm) - RZ02-01070200-R3M2", 249m },
                    { 11, "Fones de ouvido intra-auriculares para jogos ROG Cetra II Core com drivers de borracha de silicone líquido (LSR) e um conector de 3,5 mm compatível com PCs, laptops, telefones celulares, ROG Phone 5, PlayStation 5, Xbox Series X / S e Nintendo Switch. Drivers inovadores de borracha de silicone líquido (LSR) fornecem desempenho de alto-falante estável, graves incrivelmente fortes e áudio de jogo otimizado. O conector de cabo de 90 ° oferece maior conforto para jogos portáteis. A carcaça de metal leve oferece uma aparência marcante e resistência a arranhões, elevando a estética e a durabilidade do exterior. O design ergonômico com pontas e barbatanas LSR ultrasoft proporcionam um ajuste perfeitamente confortável.", 8u, false, 3, 5, "\\img\\produtos\\12.jpg", "Fone de Ouvido Gamer Asus ROG Cetra II Core Compativel com PCs", "Fone de Ouvido Gamer Asus ROG Cetra II Core Compativel com PCs, Mobile, PlayStation 5, Xbox Series X/S e Nintendo Switch - 90YH02V0-B2UA00", 359m },
                    { 10, "Cada recurso foi projetado conscientemente com o usuário em mente para maximizar a utilidade, flexibilidade e conectividade. O design de inclinação de 11 ° patenteado fornece fluxo de ar otimizado e dissipação de calor para criar uma solução inovadora que maximiza o desempenho térmico com hardware exigente - como uma fonte de alimentação ATX ou uma placa de vídeo de 3 slots sem um cabo riser. Para ventiladores de refrigeração a água, o Z11 oferece amplo espaço e a opção de um circuito de refrigeração líquido personalizado.", 1u, false, 3, 5, "\\img\\produtos\\11.jpg", "Gabinete Gamer Asus GR101, Mini Tower", "Gabinete Gamer Asus GR101, Mini Tower, Lateral e Frente em Vidro Temperado, Preto - ROG Z11 CASE/BLK", 2199m },
                    { 9, "Desfrute de streaming de vídeo mais nítido e suave e áudio cristalino com ASUS Webcam. Fornecendo vídeo FHD (1920 x 1080) nítido e detalhado em um formato widescreen, a ASUS Webcam pode ser conectada via USB e colocada em qualquer lugar em sua mesa ou em cima de seu monitor. Um mecanismo de rotação de 360 ??° garante flexibilidade para qualquer ângulo de câmera, e uma matriz de microfone beamforming integrado garante áudio alto e claro. Desfrute de chamadas de vídeo de alta resolução 1080p e streams em 30 quadros por segundo suaves. A lente grande angular captura mais, tornando a ASUS Webcam perfeita para conferências, teletrabalho ou bate-papos com duas ou mais pessoas sentadas lado a lado.", 6u, false, 3, 5, "\\img\\produtos\\10.jpg", "WebCam Asus C3, Full HD 1080p, 30fps", "WebCam Asus C3, Full HD 1080p, 30fps, Rotação 360 Graus - 90YH0340-B2UA00", 229m },
                    { 22, "O Wi-Fi 6 traz a tecnologia Wi-Fi de última geração para sua casa, oferecendo o salto quântico em capacidade, velocidade e alcance necessários para lidar com todas as suas demandas de Wi-Fi. Perfeito para casas inteligentes de alto desempenho e densas para dispositivos. Experimente velocidades de até AX1800, enquanto o 1024-QAM aumenta a taxa de transferência para dispositivos em até 25% e a largura de canal contígua de 80 MHz fornece ainda mais largura de banda. Até 4 fluxos simultâneos permitem que você desfrute de streaming 4K mais rápido e agradável, jogos on-line e muito mais, e se precisar deles - 4 portas LAN Gigabit e 1 porta WAN Gigabit oferecem conectividade com fio mais rápida sempre que desejar.", 6u, false, 6, 4, "\\img\\produtos\\23.jpg", "Roteador Wireless D-Link WiFi 6 EXO AX1800", "Roteador Wireless D-Link WiFi 6 EXO AX1800, 2.4Ghz/5Ghz, Suporte a Google Assistant e Alexa, Preto - DIR-X1860", 494m },
                    { 8, "Com recursos de ponta como TR-069 e interface web amigável que possibilita a criação de uma firmware personalizável, o DIR-842 é perfeito para provedores de internet que desejam implementar uma solução Wi-Fi de alta qualidade com a possibilidade de personalizar diversos dispositivos ao mesmo tempo. ", 10u, true, 6, 4, "\\img\\produtos\\8.jpg", "Roteador Wireless D-Link Gigabit-Ethernet AC 1200Mbps", "Roteador Wireless D-Link Gigabit-Ethernet AC 1200Mbps, Dual Band, 4 Antenas - DIR-842", 164m },
                    { 7, "O Smartphone Moto E7 conta com sensor de câmera de 48MP que deixam as fotos sempre claras e nítidas, em qualquer iluminação. A tecnologia que o acompanha, Quad Pixel, proporciona 4 vezes mais sensibilidade a luz, para que os resultados fiquem ótimos em qualquer ambiente.", 20u, true, 2, 3, "\\img\\produtos\\7.jpg", "Smartphone Motorola Moto E7, 64GB, RAM 4GB", "Smartphone Motorola Moto E7, 64GB, RAM 4GB, Octa-Core, Câmera 48MP, 4000mAh, Cinza Metálico - PALV0031BR", 892m },
                    { 5, "O G305 apresenta o sensor HERO de última geração com sensibilidade de 200 a 12.000 DPI para precisão de nível de competição. A tecnologia sem fio LIGHTSPEED oferece desempenho super rápido de 1ms. Com incrível eficiência de energia, o G305 permanece ligado e pronto para jogar por até 250 horas com uma única pilha AA inclusa.", 1u, true, 3, 2, "\\img\\produtos\\5.jpg", "Mouse Gamer Sem Fio Logitech G305 Lightspeed, 12.000 DPI", "Mouse Gamer Sem Fio Logitech G305 Lightspeed, 12.000 DPI, 6 Botões Programáveis, Branco - 910-005290", 349m },
                    { 4, "xperimente chamadas de voz, Skype, webinars e muito mais com clareza usando uma conexão USB plug-and-play simples com o headset H390. O microfone rígido do lado esquerdo pode ser colocado na posição mais adequada para capturar melhor sua voz e é móvel podendo ser recolhido para não atrapalhar quando não estiver sendo usado. Os controles integrados no fio do headset permitem controlar o volume ou colocar chamadas em silêncio com facilidade. O arco de cabeça ajustável com fones acolchoados giratórios de couro sintético oferece horas de conforto. E também é fácil de limpar.", 20u, true, 3, 2, "\\img\\produtos\\4.jpg", "Headset com fio USB Logitech H390 com Almofadas em Couro", "Headset com fio USB Logitech H390 com Almofadas em Couro, Controles de Áudio Integrado e Microfone com Redução de Ruído - 981-000014", 179m },
                    { 3, "O G403 HERO tem a versatilidade e o desempenho para atender todos os tipos de jogos e jogadores. Um mouse gamer leve, ergonômico e totalmente projetado para oferecer a precisão que você exige para jogar em alto nível, agora com o SENSOR HERO 25K de última geração.", 16u, true, 3, 2, "\\img\\produtos\\3.jpg", "Mouse Gamer Logitech G403 HERO com RGB LIGHTSYNC", "Mouse Gamer Logitech G403 HERO com RGB LIGHTSYNC, 6 Botões Programáveis, Ajuste de Peso e Sensor HERO 25K - 910-005631", 209m },
                    { 6, "Potência e desempenho em uma Solução Compacta. A NVIDIA T1000, desenvolvida com base na arquitetura de GPU NVIDIA Turing, é uma solução poderosa e discreta que oferece excelentes recursos e desempenho exigidos por intensos aplicativos profissionais em uma placa gráfica de formato compacto. Com 896 CUDA Cores e 4 GB de memória GDDR6, a T1000 permite que os profissionais lidem com vários fluxos de trabalho, desde a modelagem 3D até a edição de vídeo.", 0u, true, 1, 1, "\\img\\produtos\\6.jpg", "Pny Quadro Workstation Server Placa De Video Pny Vcnt1000-pb", "Pny Quadro Workstation Server Placa De Video Pny Vcnt1000-pb T1000 4GB DDR6 128bit Dp", 2743m },
                    { 2, "O novíssimo GALAX Serious Gaming Edition está equipado com 1-Clip Booster, que pode ser instalado na placa traseira e é a precisão e qualidade que ganham. Quando o ventilador está na parte de trás, a placa de circuito impresso é na verdade muito mais curta do que o cooler e a chave é permitir que o ar flua o mais facilmente possível, portanto, o GALAX construiu orifícios maiores que permitem que o ar flua para cumprir o primeiro requisito. Além disso, a vantagem de adicionar uma ventoinha na placa traseira, o design da ventoinha auxiliar de 1 clipe suga o ar em vez de soprar o ar para dentro, criando efeitos de resfriamento push-pull tecnicamente corretos. Quando esta ventoinha adicional é usada, ela pode obter um melhor desempenho como se uma GPU funcionasse com uma placa traseira normal.", 10u, true, 1, 1, "\\img\\produtos\\2.jpg", "Placa De Vídeo Galax GeForce RTX 3070", "Placa De Vídeo Galax GeForce RTX 3070 Ti SG 1-Click 8gb GDRR6X 256bits 37ISM6MD4BSG", 7936m },
                    { 12, "O Teclado Nitro TKL te dá espaço suficiente para se movimentar durante os jogos. Bater a mão no teclado nunca mais. MOVIMENTE-SE o Nitro TKL tem menos bordas, o que significa mais espaço na mesa. Faça movimentos bruscos com o mouse sem bater no teclado. E, ainda: aproveite o design compacto para levá-lo para onde quiser. LUZ, CÂMERA, AÇÃO com LED retroiluminado de 3 zonas, quatro níveis de brilho e três modos de iluminação predefinidos, este teclado permite que o player adicione mais luzes e cores para a arena.", 4u, false, 3, 6, "\\img\\produtos\\13.jpg", "Teclado Gamer Acer Nitro Tkl Rgb Membrana", "Teclado Gamer Acer Nitro Tkl Rgb Membrana Abnt2 Usb - Nkw120", 155m }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "e8404eb5-efdc-4fcf-a078-d1e58813cef1", "e8404eb5-efdc-4fcf-a078-d1e58813cef1" });

            migrationBuilder.CreateIndex(
                name: "IX_Imagens_IdProduto",
                table: "Imagens",
                column: "IdProduto");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetails",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ProdutoId",
                table: "OrderDetails",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_Produto_IdCategoria",
                table: "Produto",
                column: "IdCategoria");

            migrationBuilder.CreateIndex(
                name: "IX_Produto_IdMarca",
                table: "Produto",
                column: "IdMarca");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "Role",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RoleClaims_RoleId",
                table: "RoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartItems_ProdutoId",
                table: "ShoppingCartItems",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "User",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "User",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserClaims_UserId",
                table: "UserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserLogins_UserId",
                table: "UserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                table: "UserRoles",
                column: "RoleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contato");

            migrationBuilder.DropTable(
                name: "Imagens");

            migrationBuilder.DropTable(
                name: "ImagensSite");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "RoleClaims");

            migrationBuilder.DropTable(
                name: "ShoppingCartItems");

            migrationBuilder.DropTable(
                name: "UserClaims");

            migrationBuilder.DropTable(
                name: "UserLogins");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "UserTokens");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Produto");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Categoria");

            migrationBuilder.DropTable(
                name: "Marca");
        }
    }
}
