using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AppEcommerce.Migrations
{
    public partial class bandotestedois : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: new Guid("18c2a2b4-7899-40ec-a135-541e345bc535"));

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: new Guid("3e176412-ea1b-4376-beea-bb29be032d05"));

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: new Guid("eb16ebef-7d96-4c5f-af02-644e065c413f"));

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("04389e08-b6df-45f6-b87d-2f84e4797f48"));

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("25b84849-fc5b-4aca-8255-979ef2b7013d"));

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("41ab73e4-54b2-4fec-b237-d514d15c1dee"));

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("72c632fc-63c0-4946-98f1-be4c7f498639"));

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("a0f2120c-2263-4f89-a522-2f12c931fcce"));

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("b9653d95-b45f-4717-b39b-2362a3c61ddf"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "683954fa-8a1a-443c-b9e2-f72ee5ba509e");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "cf9cf35d-b74c-43cb-a9e0-3f3554f11258");

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ab75d9c0-dbb8-4da9-9045-2bedae67c42e", "ab75d9c0-dbb8-4da9-9045-2bedae67c42e" });

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: new Guid("3f66be4a-3eb8-4e9e-b891-3f218e661c1c"));

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: new Guid("6adac617-5a9a-496d-afda-89cb20e7b1c1"));

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: new Guid("f68d9c80-2d61-4b0c-8d91-602a7b9d68bd"));

            migrationBuilder.DeleteData(
                table: "Marca",
                keyColumn: "Id",
                keyValue: new Guid("d863e863-046f-41f3-9fd9-2f47a3e8338c"));

            migrationBuilder.DeleteData(
                table: "Marca",
                keyColumn: "Id",
                keyValue: new Guid("ec18b8ef-29d7-4b27-b2a6-edf0f4e565cb"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "ab75d9c0-dbb8-4da9-9045-2bedae67c42e");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "ab75d9c0-dbb8-4da9-9045-2bedae67c42e");

            migrationBuilder.InsertData(
                table: "Categoria",
                columns: new[] { "Id", "Imagem", "Nome" },
                values: new object[,]
                {
                    { new Guid("604fa1d0-f864-4a38-8853-eb6a0f9710cb"), "~/img/Produtos/001.png", "Hardware" },
                    { new Guid("4e00ca88-bed5-4763-b1cf-3dfaa7400754"), "~/img/Produtos/002.png", "Celulares" },
                    { new Guid("cb92f36c-cf64-44e0-8baa-6883aa361ee1"), "~/img/Produtos/003.png", "Periféricos" },
                    { new Guid("7070ef30-5ac3-4128-88c8-bfabbc8ec3ce"), "~/img/Produtos/004.png", "Games" },
                    { new Guid("303b5b1f-2436-4561-8e6c-829798c94705"), "~/img/Produtos/005.png", "Cadeiras" },
                    { new Guid("818a64d9-5ed1-4afb-9efc-9a366ea38d0b"), "~/img/Produtos/006.png", "Conectividade" }
                });

            migrationBuilder.InsertData(
                table: "Marca",
                columns: new[] { "Id", "Nome" },
                values: new object[,]
                {
                    { new Guid("923b02bb-d677-4f5d-8b44-bc74b290f65b"), "Nvidia" },
                    { new Guid("cd068031-c240-4fb3-bbf5-8a4e846b31d9"), "Logitech" }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8a4580ab-4341-479a-89de-defa79637619", "ae2cb51f-e0b1-4c66-b1f7-6736e03ff032", "Administrador", "ADMINISTRADOR" },
                    { "afa9da49-a70a-4341-8ee9-ee39ff00a6ca", "f5396a2a-5799-4d1b-84dc-79369203f415", "Moderador", "MODERADOR" },
                    { "ce10e1d9-b27b-47a6-bb7d-31575e34270e", "7c6a18a5-5dba-4ef0-82e2-befba85e3a69", "Usuario", "USUARIO" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NomeCompleto", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "8a4580ab-4341-479a-89de-defa79637619", 0, "0369ee72-cdb9-4f24-aba4-6b9604431192", "admin@ecommerce.com.br", true, false, null, "Igor Oliveira de Lima", "ADMIN@ECOMMERCE.COM.BR", "ADMIN", "AQAAAAEAACcQAAAAELnyCXoMtRhdzsVIKbeQnjldtip0bK43T9Se7Xx0lco1V1/es2lmXl5dwVNwtaKMwA==", null, false, "44539515", false, "Admin" });

            migrationBuilder.InsertData(
                table: "Produto",
                columns: new[] { "Id", "Descricao", "Estoque", "IdCategoria", "IdMarca", "Imagem", "Nome", "Valor" },
                values: new object[,]
                {
                    { new Guid("5d20a61b-5bc1-4060-9b9e-b03012fd68fa"), "A Placa Gráfica Nvidia Quadro P400 combina a mais recente arquitetura NVIDIA Quadro Pascal GPU com 2GB de ultra-rápido de memória on-board para entregar ótimo desempenho para uma gama de aplicações profissionais. Um fator de forma de baixo perfil e slot único torna-o compatível até com o chassi com mais espaço e com menor consumo de energia. O suporte para três monitores 4K (4096 x 2160 a 60Hz) com cores HDR oferece um amplo espaço de trabalho visual para visualizar seu trabalho em resolução extremamente alta.", 8u, new Guid("604fa1d0-f864-4a38-8853-eb6a0f9710cb"), new Guid("923b02bb-d677-4f5d-8b44-bc74b290f65b"), "~/img/Produtos/1.jpg", "Placa Gráfica Nvidia Quadro P400 2gb Gddr5 64bits - Pny Vcqp400v2-pb", 1223.99m },
                    { new Guid("1e561ba8-27be-49c5-841c-19ae959f80e4"), "O novíssimo GALAX Serious Gaming Edition está equipado com 1-Clip Booster, que pode ser instalado na placa traseira e é a precisão e qualidade que ganham. Quando o ventilador está na parte de trás, a placa de circuito impresso é na verdade muito mais curta do que o cooler e a chave é permitir que o ar flua o mais facilmente possível, portanto, o GALAX construiu orifícios maiores que permitem que o ar flua para cumprir o primeiro requisito. Além disso, a vantagem de adicionar uma ventoinha na placa traseira, o design da ventoinha auxiliar de 1 clipe suga o ar em vez de soprar o ar para dentro, criando efeitos de resfriamento push-pull tecnicamente corretos. Quando esta ventoinha adicional é usada, ela pode obter um melhor desempenho como se uma GPU funcionasse com uma placa traseira normal.", 10u, new Guid("604fa1d0-f864-4a38-8853-eb6a0f9710cb"), new Guid("923b02bb-d677-4f5d-8b44-bc74b290f65b"), "~/img/Produtos/2.jpg", "Placa De Vídeo Galax GeForce RTX 3070 Ti SG 1-Click 8gb GDRR6X 256bits 37ISM6MD4BSG", 7936m },
                    { new Guid("0659ec4a-517d-4c3b-b35b-fa73ea9f0a12"), "Potência e desempenho em uma Solução Compacta. A NVIDIA T1000, desenvolvida com base na arquitetura de GPU NVIDIA Turing, é uma solução poderosa e discreta que oferece excelentes recursos e desempenho exigidos por intensos aplicativos profissionais em uma placa gráfica de formato compacto. Com 896 CUDA Cores e 4 GB de memória GDDR6, a T1000 permite que os profissionais lidem com vários fluxos de trabalho, desde a modelagem 3D até a edição de vídeo.", 0u, new Guid("604fa1d0-f864-4a38-8853-eb6a0f9710cb"), new Guid("923b02bb-d677-4f5d-8b44-bc74b290f65b"), "~/img/Produtos/6.jpg", "Pny Quadro Workstation Server Placa De Video Pny Vcnt1000-pb T1000 4GB DDR6 128bit Dp", 2743.98m },
                    { new Guid("2a461a85-336f-4ccb-b819-e5c0ef028b4b"), "O G403 HERO tem a versatilidade e o desempenho para atender todos os tipos de jogos e jogadores. Um mouse gamer leve, ergonômico e totalmente projetado para oferecer a precisão que você exige para jogar em alto nível, agora com o SENSOR HERO 25K de última geração.", 16u, new Guid("cb92f36c-cf64-44e0-8baa-6883aa361ee1"), new Guid("cd068031-c240-4fb3-bbf5-8a4e846b31d9"), "~/img/Produtos/3.jpg", "Mouse Gamer Logitech G403 HERO com RGB LIGHTSYNC, 6 Botões Programáveis, Ajuste de Peso e Sensor HERO 25K - 910-005631", 209m },
                    { new Guid("66c293a0-d781-49e9-893d-f7bbe2ad23e8"), "xperimente chamadas de voz, Skype, webinars e muito mais com clareza usando uma conexão USB plug-and-play simples com o headset H390. O microfone rígido do lado esquerdo pode ser colocado na posição mais adequada para capturar melhor sua voz e é móvel podendo ser recolhido para não atrapalhar quando não estiver sendo usado. Os controles integrados no fio do headset permitem controlar o volume ou colocar chamadas em silêncio com facilidade. O arco de cabeça ajustável com fones acolchoados giratórios de couro sintético oferece horas de conforto. E também é fácil de limpar.", 20u, new Guid("cb92f36c-cf64-44e0-8baa-6883aa361ee1"), new Guid("cd068031-c240-4fb3-bbf5-8a4e846b31d9"), "~/img/Produtos/4.jpg", "Headset com fio USB Logitech H390 com Almofadas em Couro, Controles de Áudio Integrado e Microfone com Redução de Ruído - 981-000014", 179.99m },
                    { new Guid("002f382b-2626-41e1-92e7-955d19c4cedc"), "O G305 apresenta o sensor HERO de última geração com sensibilidade de 200 a 12.000 DPI para precisão de nível de competição. A tecnologia sem fio LIGHTSPEED oferece desempenho super rápido de 1ms. Com incrível eficiência de energia, o G305 permanece ligado e pronto para jogar por até 250 horas com uma única pilha AA inclusa.", 1u, new Guid("cb92f36c-cf64-44e0-8baa-6883aa361ee1"), new Guid("cd068031-c240-4fb3-bbf5-8a4e846b31d9"), "~/img/Produtos/5.jpg", "Mouse Gamer Sem Fio Logitech G305 Lightspeed, 12.000 DPI, 6 Botões Programáveis, Branco - 910-005290", 349.9m }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "8a4580ab-4341-479a-89de-defa79637619", "8a4580ab-4341-479a-89de-defa79637619" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: new Guid("303b5b1f-2436-4561-8e6c-829798c94705"));

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: new Guid("4e00ca88-bed5-4763-b1cf-3dfaa7400754"));

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: new Guid("7070ef30-5ac3-4128-88c8-bfabbc8ec3ce"));

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: new Guid("818a64d9-5ed1-4afb-9efc-9a366ea38d0b"));

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("002f382b-2626-41e1-92e7-955d19c4cedc"));

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("0659ec4a-517d-4c3b-b35b-fa73ea9f0a12"));

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("1e561ba8-27be-49c5-841c-19ae959f80e4"));

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("2a461a85-336f-4ccb-b819-e5c0ef028b4b"));

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("5d20a61b-5bc1-4060-9b9e-b03012fd68fa"));

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("66c293a0-d781-49e9-893d-f7bbe2ad23e8"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "afa9da49-a70a-4341-8ee9-ee39ff00a6ca");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "ce10e1d9-b27b-47a6-bb7d-31575e34270e");

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8a4580ab-4341-479a-89de-defa79637619", "8a4580ab-4341-479a-89de-defa79637619" });

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: new Guid("604fa1d0-f864-4a38-8853-eb6a0f9710cb"));

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: new Guid("cb92f36c-cf64-44e0-8baa-6883aa361ee1"));

            migrationBuilder.DeleteData(
                table: "Marca",
                keyColumn: "Id",
                keyValue: new Guid("923b02bb-d677-4f5d-8b44-bc74b290f65b"));

            migrationBuilder.DeleteData(
                table: "Marca",
                keyColumn: "Id",
                keyValue: new Guid("cd068031-c240-4fb3-bbf5-8a4e846b31d9"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "8a4580ab-4341-479a-89de-defa79637619");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "8a4580ab-4341-479a-89de-defa79637619");

            migrationBuilder.InsertData(
                table: "Categoria",
                columns: new[] { "Id", "Imagem", "Nome" },
                values: new object[,]
                {
                    { new Guid("3f66be4a-3eb8-4e9e-b891-3f218e661c1c"), "~/img/Produtos/001.png", "Hardware" },
                    { new Guid("f68d9c80-2d61-4b0c-8d91-602a7b9d68bd"), "~/img/Produtos/002.png", "Celulares" },
                    { new Guid("6adac617-5a9a-496d-afda-89cb20e7b1c1"), "~/img/Produtos/003.png", "Periféricos" },
                    { new Guid("18c2a2b4-7899-40ec-a135-541e345bc535"), "~/img/Produtos/004.png", "Games" },
                    { new Guid("eb16ebef-7d96-4c5f-af02-644e065c413f"), "~/img/Produtos/005.png", "Cadeiras" },
                    { new Guid("3e176412-ea1b-4376-beea-bb29be032d05"), "~/img/Produtos/006.png", "Conectividade" }
                });

            migrationBuilder.InsertData(
                table: "Marca",
                columns: new[] { "Id", "Nome" },
                values: new object[,]
                {
                    { new Guid("d863e863-046f-41f3-9fd9-2f47a3e8338c"), "Nvidia" },
                    { new Guid("ec18b8ef-29d7-4b27-b2a6-edf0f4e565cb"), "Logitech" }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ab75d9c0-dbb8-4da9-9045-2bedae67c42e", "200c39de-355e-404b-965d-419875131f35", "Administrador", "ADMINISTRADOR" },
                    { "cf9cf35d-b74c-43cb-a9e0-3f3554f11258", "795f24a2-c899-40d1-9d69-57a25ca4361c", "Moderador", "MODERADOR" },
                    { "683954fa-8a1a-443c-b9e2-f72ee5ba509e", "5bd44eea-7ed4-4be2-a1bc-459be54175de", "Usuario", "USUARIO" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NomeCompleto", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "ab75d9c0-dbb8-4da9-9045-2bedae67c42e", 0, "9e875be0-86d3-4c9e-a3e9-b0c7f45695f2", "admin@ecommerce.com.br", true, false, null, "Igor Oliveira de Lima", "ADMIN@ECOMMERCE.COM.BR", "ADMIN", "AQAAAAEAACcQAAAAEO+SoFbnz9/q5a1ekEJQvKiMbpSqgQAVTLqcH7CXjc4faWkuAxUjPEorzi/3bZaIYQ==", null, false, "44539515", false, "Admin" });

            migrationBuilder.InsertData(
                table: "Produto",
                columns: new[] { "Id", "Descricao", "Estoque", "IdCategoria", "IdMarca", "Imagem", "Nome", "Valor" },
                values: new object[,]
                {
                    { new Guid("41ab73e4-54b2-4fec-b237-d514d15c1dee"), "A Placa Gráfica Nvidia Quadro P400 combina a mais recente arquitetura NVIDIA Quadro Pascal GPU com 2GB de ultra-rápido de memória on-board para entregar ótimo desempenho para uma gama de aplicações profissionais. Um fator de forma de baixo perfil e slot único torna-o compatível até com o chassi com mais espaço e com menor consumo de energia. O suporte para três monitores 4K (4096 x 2160 a 60Hz) com cores HDR oferece um amplo espaço de trabalho visual para visualizar seu trabalho em resolução extremamente alta.", 8u, new Guid("3f66be4a-3eb8-4e9e-b891-3f218e661c1c"), new Guid("d863e863-046f-41f3-9fd9-2f47a3e8338c"), "~/img/Produtos/1.jpg", "Placa Gráfica Nvidia Quadro P400 2gb Gddr5 64bits - Pny Vcqp400v2-pb", 1223.99m },
                    { new Guid("b9653d95-b45f-4717-b39b-2362a3c61ddf"), "O novíssimo GALAX Serious Gaming Edition está equipado com 1-Clip Booster, que pode ser instalado na placa traseira e é a precisão e qualidade que ganham. Quando o ventilador está na parte de trás, a placa de circuito impresso é na verdade muito mais curta do que o cooler e a chave é permitir que o ar flua o mais facilmente possível, portanto, o GALAX construiu orifícios maiores que permitem que o ar flua para cumprir o primeiro requisito. Além disso, a vantagem de adicionar uma ventoinha na placa traseira, o design da ventoinha auxiliar de 1 clipe suga o ar em vez de soprar o ar para dentro, criando efeitos de resfriamento push-pull tecnicamente corretos. Quando esta ventoinha adicional é usada, ela pode obter um melhor desempenho como se uma GPU funcionasse com uma placa traseira normal.", 10u, new Guid("3f66be4a-3eb8-4e9e-b891-3f218e661c1c"), new Guid("d863e863-046f-41f3-9fd9-2f47a3e8338c"), "~/img/Produtos/2.jpg", "Placa De Vídeo Galax GeForce RTX 3070 Ti SG 1-Click 8gb GDRR6X 256bits 37ISM6MD4BSG", 7936m },
                    { new Guid("25b84849-fc5b-4aca-8255-979ef2b7013d"), "Potência e desempenho em uma Solução Compacta. A NVIDIA T1000, desenvolvida com base na arquitetura de GPU NVIDIA Turing, é uma solução poderosa e discreta que oferece excelentes recursos e desempenho exigidos por intensos aplicativos profissionais em uma placa gráfica de formato compacto. Com 896 CUDA Cores e 4 GB de memória GDDR6, a T1000 permite que os profissionais lidem com vários fluxos de trabalho, desde a modelagem 3D até a edição de vídeo.", 0u, new Guid("f68d9c80-2d61-4b0c-8d91-602a7b9d68bd"), new Guid("d863e863-046f-41f3-9fd9-2f47a3e8338c"), "~/img/Produtos/6.jpg", "Pny Quadro Workstation Server Placa De Video Pny Vcnt1000-pb T1000 4GB DDR6 128bit Dp", 2743.98m },
                    { new Guid("04389e08-b6df-45f6-b87d-2f84e4797f48"), "O G403 HERO tem a versatilidade e o desempenho para atender todos os tipos de jogos e jogadores. Um mouse gamer leve, ergonômico e totalmente projetado para oferecer a precisão que você exige para jogar em alto nível, agora com o SENSOR HERO 25K de última geração.", 16u, new Guid("6adac617-5a9a-496d-afda-89cb20e7b1c1"), new Guid("ec18b8ef-29d7-4b27-b2a6-edf0f4e565cb"), "~/img/Produtos/3.jpg", "Mouse Gamer Logitech G403 HERO com RGB LIGHTSYNC, 6 Botões Programáveis, Ajuste de Peso e Sensor HERO 25K - 910-005631", 209m },
                    { new Guid("72c632fc-63c0-4946-98f1-be4c7f498639"), "xperimente chamadas de voz, Skype, webinars e muito mais com clareza usando uma conexão USB plug-and-play simples com o headset H390. O microfone rígido do lado esquerdo pode ser colocado na posição mais adequada para capturar melhor sua voz e é móvel podendo ser recolhido para não atrapalhar quando não estiver sendo usado. Os controles integrados no fio do headset permitem controlar o volume ou colocar chamadas em silêncio com facilidade. O arco de cabeça ajustável com fones acolchoados giratórios de couro sintético oferece horas de conforto. E também é fácil de limpar.", 20u, new Guid("6adac617-5a9a-496d-afda-89cb20e7b1c1"), new Guid("ec18b8ef-29d7-4b27-b2a6-edf0f4e565cb"), "~/img/Produtos/4.jpg", "Headset com fio USB Logitech H390 com Almofadas em Couro, Controles de Áudio Integrado e Microfone com Redução de Ruído - 981-000014", 179.99m },
                    { new Guid("a0f2120c-2263-4f89-a522-2f12c931fcce"), "O G305 apresenta o sensor HERO de última geração com sensibilidade de 200 a 12.000 DPI para precisão de nível de competição. A tecnologia sem fio LIGHTSPEED oferece desempenho super rápido de 1ms. Com incrível eficiência de energia, o G305 permanece ligado e pronto para jogar por até 250 horas com uma única pilha AA inclusa.", 1u, new Guid("6adac617-5a9a-496d-afda-89cb20e7b1c1"), new Guid("ec18b8ef-29d7-4b27-b2a6-edf0f4e565cb"), "~/img/Produtos/5.jpg", "Mouse Gamer Sem Fio Logitech G305 Lightspeed, 12.000 DPI, 6 Botões Programáveis, Branco - 910-005290", 349.9m }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ab75d9c0-dbb8-4da9-9045-2bedae67c42e", "ab75d9c0-dbb8-4da9-9045-2bedae67c42e" });
        }
    }
}
