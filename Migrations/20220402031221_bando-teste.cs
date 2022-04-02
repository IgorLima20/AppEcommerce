using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AppEcommerce.Migrations
{
    public partial class bandoteste : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: new Guid("46312f94-16e1-4aaf-87d9-6422b5aee132"));

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: new Guid("4eb62a6e-aea4-47f1-b8be-b193342af69a"));

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: new Guid("729b7a61-d510-4e0e-84ea-f04834985be8"));

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: new Guid("da0f2b32-7b30-4a97-a4e9-e840f67d10a1"));

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("1b062e50-51d6-4f09-bcba-7f759cfde51f"));

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("40b5b57a-cf37-4f35-a6d6-037f07a84767"));

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("6cd4e1bd-2748-4ae6-bf4a-4d7e5386a2c4"));

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("86d0e1b1-d52a-4abd-94b7-8fa70f95ade6"));

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("f9cbf58c-654d-41de-b979-d1d6fa389499"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "50a82da4-56b3-4667-a521-060e8e2f0302");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "c72efc1f-f94e-47e2-bac3-5418d38dcb9a");

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "49de2cb0-e822-4837-b3e3-f91206f20c66", "49de2cb0-e822-4837-b3e3-f91206f20c66" });

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: new Guid("71783cda-2812-4deb-ad3e-9be1c501e462"));

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: new Guid("aca3b6fe-b9ff-4638-8858-37264d665106"));

            migrationBuilder.DeleteData(
                table: "Marca",
                keyColumn: "Id",
                keyValue: new Guid("446fdddc-07eb-4141-8224-133679aa55ed"));

            migrationBuilder.DeleteData(
                table: "Marca",
                keyColumn: "Id",
                keyValue: new Guid("5ef94e77-90af-4da9-91f9-77120ff3fd5a"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "49de2cb0-e822-4837-b3e3-f91206f20c66");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "49de2cb0-e822-4837-b3e3-f91206f20c66");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("71783cda-2812-4deb-ad3e-9be1c501e462"), "~/img/Produtos/001.png", "Computadores" },
                    { new Guid("da0f2b32-7b30-4a97-a4e9-e840f67d10a1"), "~/img/Produtos/002.png", "Celulares" },
                    { new Guid("aca3b6fe-b9ff-4638-8858-37264d665106"), "~/img/Produtos/003.png", "Periféricos" },
                    { new Guid("729b7a61-d510-4e0e-84ea-f04834985be8"), "~/img/Produtos/004.png", "Games" },
                    { new Guid("4eb62a6e-aea4-47f1-b8be-b193342af69a"), "~/img/Produtos/005.png", "Cadeiras" },
                    { new Guid("46312f94-16e1-4aaf-87d9-6422b5aee132"), "~/img/Produtos/006.png", "Conectividade" }
                });

            migrationBuilder.InsertData(
                table: "Marca",
                columns: new[] { "Id", "Nome" },
                values: new object[,]
                {
                    { new Guid("446fdddc-07eb-4141-8224-133679aa55ed"), "Nvidia" },
                    { new Guid("5ef94e77-90af-4da9-91f9-77120ff3fd5a"), "Logitech" }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "49de2cb0-e822-4837-b3e3-f91206f20c66", "b1c1284d-781a-47b8-8c04-38f9cc5dd3bd", "Administrador", "ADMINISTRADOR" },
                    { "50a82da4-56b3-4667-a521-060e8e2f0302", "b440d773-3302-4ce2-99a4-f4af96de2d7a", "Moderador", "MODERADOR" },
                    { "c72efc1f-f94e-47e2-bac3-5418d38dcb9a", "6e6005b1-f722-478a-8e51-859b640f2afc", "Usuario", "USUARIO" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NomeCompleto", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "49de2cb0-e822-4837-b3e3-f91206f20c66", 0, "1b5aed25-3988-45db-8843-dade6282a546", "admin@ecommerce.com.br", true, false, null, "Igor Oliveira de Lima", "ADMIN@ECOMMERCE.COM.BR", "ADMIN", "AQAAAAEAACcQAAAAEPTzppAVTZHmCinRshZIw9JjR3KaPUaYpAw6ZGFObeKvf9UViVmxpYOcUL5W5xwS1g==", null, false, "44539515", false, "Admin" });

            migrationBuilder.InsertData(
                table: "Produto",
                columns: new[] { "Id", "Descricao", "Estoque", "IdCategoria", "IdMarca", "Imagem", "Nome", "Valor" },
                values: new object[,]
                {
                    { new Guid("40b5b57a-cf37-4f35-a6d6-037f07a84767"), "A Placa Gráfica Nvidia Quadro P400 combina a mais recente arquitetura NVIDIA Quadro Pascal GPU com 2GB de ultra-rápido de memória on-board para entregar ótimo desempenho para uma gama de aplicações profissionais. Um fator de forma de baixo perfil e slot único torna-o compatível até com o chassi com mais espaço e com menor consumo de energia. O suporte para três monitores 4K (4096 x 2160 a 60Hz) com cores HDR oferece um amplo espaço de trabalho visual para visualizar seu trabalho em resolução extremamente alta.", 8u, new Guid("71783cda-2812-4deb-ad3e-9be1c501e462"), new Guid("446fdddc-07eb-4141-8224-133679aa55ed"), "~/img/Produtos/1.jpg", "Placa Gráfica Nvidia Quadro P400 2gb Gddr5 64bits - Pny Vcqp400v2-pb", 1223.99m },
                    { new Guid("86d0e1b1-d52a-4abd-94b7-8fa70f95ade6"), "O novíssimo GALAX Serious Gaming Edition está equipado com 1-Clip Booster, que pode ser instalado na placa traseira e é a precisão e qualidade que ganham. Quando o ventilador está na parte de trás, a placa de circuito impresso é na verdade muito mais curta do que o cooler e a chave é permitir que o ar flua o mais facilmente possível, portanto, o GALAX construiu orifícios maiores que permitem que o ar flua para cumprir o primeiro requisito. Além disso, a vantagem de adicionar uma ventoinha na placa traseira, o design da ventoinha auxiliar de 1 clipe suga o ar em vez de soprar o ar para dentro, criando efeitos de resfriamento push-pull tecnicamente corretos. Quando esta ventoinha adicional é usada, ela pode obter um melhor desempenho como se uma GPU funcionasse com uma placa traseira normal.", 10u, new Guid("71783cda-2812-4deb-ad3e-9be1c501e462"), new Guid("446fdddc-07eb-4141-8224-133679aa55ed"), "~/img/Produtos/2.jpg", "Placa De Vídeo Galax GeForce RTX 3070 Ti SG 1-Click 8gb GDRR6X 256bits 37ISM6MD4BSG", 7936m },
                    { new Guid("1b062e50-51d6-4f09-bcba-7f759cfde51f"), "O G403 HERO tem a versatilidade e o desempenho para atender todos os tipos de jogos e jogadores. Um mouse gamer leve, ergonômico e totalmente projetado para oferecer a precisão que você exige para jogar em alto nível, agora com o SENSOR HERO 25K de última geração.", 16u, new Guid("aca3b6fe-b9ff-4638-8858-37264d665106"), new Guid("5ef94e77-90af-4da9-91f9-77120ff3fd5a"), "~/img/Produtos/3.jpg", "Mouse Gamer Logitech G403 HERO com RGB LIGHTSYNC, 6 Botões Programáveis, Ajuste de Peso e Sensor HERO 25K - 910-005631", 209m },
                    { new Guid("6cd4e1bd-2748-4ae6-bf4a-4d7e5386a2c4"), "xperimente chamadas de voz, Skype, webinars e muito mais com clareza usando uma conexão USB plug-and-play simples com o headset H390. O microfone rígido do lado esquerdo pode ser colocado na posição mais adequada para capturar melhor sua voz e é móvel podendo ser recolhido para não atrapalhar quando não estiver sendo usado. Os controles integrados no fio do headset permitem controlar o volume ou colocar chamadas em silêncio com facilidade. O arco de cabeça ajustável com fones acolchoados giratórios de couro sintético oferece horas de conforto. E também é fácil de limpar.", 20u, new Guid("aca3b6fe-b9ff-4638-8858-37264d665106"), new Guid("5ef94e77-90af-4da9-91f9-77120ff3fd5a"), "~/img/Produtos/4.jpg", "Headset com fio USB Logitech H390 com Almofadas em Couro, Controles de Áudio Integrado e Microfone com Redução de Ruído - 981-000014", 179.99m },
                    { new Guid("f9cbf58c-654d-41de-b979-d1d6fa389499"), "O G305 apresenta o sensor HERO de última geração com sensibilidade de 200 a 12.000 DPI para precisão de nível de competição. A tecnologia sem fio LIGHTSPEED oferece desempenho super rápido de 1ms. Com incrível eficiência de energia, o G305 permanece ligado e pronto para jogar por até 250 horas com uma única pilha AA inclusa.", 1u, new Guid("aca3b6fe-b9ff-4638-8858-37264d665106"), new Guid("5ef94e77-90af-4da9-91f9-77120ff3fd5a"), "~/img/Produtos/5.jpg", "Mouse Gamer Sem Fio Logitech G305 Lightspeed, 12.000 DPI, 6 Botões Programáveis, Branco - 910-005290", 349.9m }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "49de2cb0-e822-4837-b3e3-f91206f20c66", "49de2cb0-e822-4837-b3e3-f91206f20c66" });
        }
    }
}
