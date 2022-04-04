using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AppEcommerce.Migrations
{
    public partial class finalteste : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("b4e01979-6fcf-4feb-b1cb-c172ad44b8f4"), "~/img/Produtos/001.png", "Hardware" },
                    { new Guid("715fec1d-0cf6-4f44-adec-2d2ccb7d35d0"), "~/img/Produtos/002.png", "Celulares" },
                    { new Guid("613a6739-52cb-49eb-af65-d701f4ddf895"), "~/img/Produtos/003.png", "Periféricos" },
                    { new Guid("e1da9e97-7a9b-4956-8a01-042439ed752b"), "~/img/Produtos/004.png", "Games" },
                    { new Guid("fd15c5ef-e57a-4ab7-9ca3-22467f93eab7"), "~/img/Produtos/005.png", "Cadeiras" },
                    { new Guid("0ab2f94b-42b6-4d57-bf86-c96e16b1aa6c"), "~/img/Produtos/006.png", "Conectividade" }
                });

            migrationBuilder.InsertData(
                table: "Marca",
                columns: new[] { "Id", "Nome" },
                values: new object[,]
                {
                    { new Guid("05e05427-6f80-4f02-9b83-3d39f2355011"), "Nvidia" },
                    { new Guid("85486af8-07ba-455c-8e16-245721253aa2"), "Logitech" },
                    { new Guid("b71ed344-64df-4479-bda4-c7f277026b91"), "Motorola" },
                    { new Guid("c08f9f34-0427-4c68-b456-4fa8e7c5309c"), "D-Link" }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "dd3c4e7f-9385-4a9b-927b-97ff0550f2c2", "7604ce93-acf4-4cb4-b1a9-4ab8cf8f4e16", "Administrador", "ADMINISTRADOR" },
                    { "b1107611-9c23-4f96-a8ba-99cc697546dd", "25dbeae9-3c48-4b70-a9aa-5612fbfdc406", "Moderador", "MODERADOR" },
                    { "364d87df-97c5-4b87-ae80-3ffac118b4d7", "1cded357-6c5e-4306-9142-861b7320eff7", "Usuario", "USUARIO" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NomeCompleto", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "dd3c4e7f-9385-4a9b-927b-97ff0550f2c2", 0, "7e61b1a4-e220-4338-a0f1-178436d44cc5", "admin@ecommerce.com.br", true, false, null, "Igor Oliveira de Lima", "ADMIN@ECOMMERCE.COM.BR", "ADMIN", "AQAAAAEAACcQAAAAEKGbJ1uA41Fzg2bl2S+lIYVLupEPaonWOKNzX5CfGGKmHrE/CXwz702m7xo4frPOkw==", null, false, "44539515", false, "Admin" });

            migrationBuilder.InsertData(
                table: "Produto",
                columns: new[] { "Id", "Descricao", "Estoque", "IdCategoria", "IdMarca", "Imagem", "Nome", "Valor" },
                values: new object[,]
                {
                    { new Guid("12bcc7ee-5a79-4d94-8f7b-25349d21e7d0"), "A Placa Gráfica Nvidia Quadro P400 combina a mais recente arquitetura NVIDIA Quadro Pascal GPU com 2GB de ultra-rápido de memória on-board para entregar ótimo desempenho para uma gama de aplicações profissionais. Um fator de forma de baixo perfil e slot único torna-o compatível até com o chassi com mais espaço e com menor consumo de energia. O suporte para três monitores 4K (4096 x 2160 a 60Hz) com cores HDR oferece um amplo espaço de trabalho visual para visualizar seu trabalho em resolução extremamente alta.", 8u, new Guid("b4e01979-6fcf-4feb-b1cb-c172ad44b8f4"), new Guid("05e05427-6f80-4f02-9b83-3d39f2355011"), "~/img/Produtos/1.jpg", "Placa Gráfica Nvidia Quadro P400 2gb Gddr5 64bits - Pny Vcqp400v2-pb", 1223.99m },
                    { new Guid("d20fed84-1f98-4465-b7b6-e70993fa413f"), "O novíssimo GALAX Serious Gaming Edition está equipado com 1-Clip Booster, que pode ser instalado na placa traseira e é a precisão e qualidade que ganham. Quando o ventilador está na parte de trás, a placa de circuito impresso é na verdade muito mais curta do que o cooler e a chave é permitir que o ar flua o mais facilmente possível, portanto, o GALAX construiu orifícios maiores que permitem que o ar flua para cumprir o primeiro requisito. Além disso, a vantagem de adicionar uma ventoinha na placa traseira, o design da ventoinha auxiliar de 1 clipe suga o ar em vez de soprar o ar para dentro, criando efeitos de resfriamento push-pull tecnicamente corretos. Quando esta ventoinha adicional é usada, ela pode obter um melhor desempenho como se uma GPU funcionasse com uma placa traseira normal.", 10u, new Guid("b4e01979-6fcf-4feb-b1cb-c172ad44b8f4"), new Guid("05e05427-6f80-4f02-9b83-3d39f2355011"), "~/img/Produtos/2.jpg", "Placa De Vídeo Galax GeForce RTX 3070 Ti SG 1-Click 8gb GDRR6X 256bits 37ISM6MD4BSG", 7936m },
                    { new Guid("3fcab97b-3dc8-4ee3-8132-16cba77af00a"), "Potência e desempenho em uma Solução Compacta. A NVIDIA T1000, desenvolvida com base na arquitetura de GPU NVIDIA Turing, é uma solução poderosa e discreta que oferece excelentes recursos e desempenho exigidos por intensos aplicativos profissionais em uma placa gráfica de formato compacto. Com 896 CUDA Cores e 4 GB de memória GDDR6, a T1000 permite que os profissionais lidem com vários fluxos de trabalho, desde a modelagem 3D até a edição de vídeo.", 0u, new Guid("b4e01979-6fcf-4feb-b1cb-c172ad44b8f4"), new Guid("05e05427-6f80-4f02-9b83-3d39f2355011"), "~/img/Produtos/6.jpg", "Pny Quadro Workstation Server Placa De Video Pny Vcnt1000-pb T1000 4GB DDR6 128bit Dp", 2743.98m },
                    { new Guid("9468ac4d-88e6-4594-b356-626d19769f28"), "O G403 HERO tem a versatilidade e o desempenho para atender todos os tipos de jogos e jogadores. Um mouse gamer leve, ergonômico e totalmente projetado para oferecer a precisão que você exige para jogar em alto nível, agora com o SENSOR HERO 25K de última geração.", 16u, new Guid("613a6739-52cb-49eb-af65-d701f4ddf895"), new Guid("85486af8-07ba-455c-8e16-245721253aa2"), "~/img/Produtos/3.jpg", "Mouse Gamer Logitech G403 HERO com RGB LIGHTSYNC, 6 Botões Programáveis, Ajuste de Peso e Sensor HERO 25K - 910-005631", 209m },
                    { new Guid("e27803dc-40c5-41d9-9c28-366a4f3ec057"), "xperimente chamadas de voz, Skype, webinars e muito mais com clareza usando uma conexão USB plug-and-play simples com o headset H390. O microfone rígido do lado esquerdo pode ser colocado na posição mais adequada para capturar melhor sua voz e é móvel podendo ser recolhido para não atrapalhar quando não estiver sendo usado. Os controles integrados no fio do headset permitem controlar o volume ou colocar chamadas em silêncio com facilidade. O arco de cabeça ajustável com fones acolchoados giratórios de couro sintético oferece horas de conforto. E também é fácil de limpar.", 20u, new Guid("613a6739-52cb-49eb-af65-d701f4ddf895"), new Guid("85486af8-07ba-455c-8e16-245721253aa2"), "~/img/Produtos/4.jpg", "Headset com fio USB Logitech H390 com Almofadas em Couro, Controles de Áudio Integrado e Microfone com Redução de Ruído - 981-000014", 179.99m },
                    { new Guid("3f8c6847-e4d0-4db0-9e43-7181c20463c3"), "O G305 apresenta o sensor HERO de última geração com sensibilidade de 200 a 12.000 DPI para precisão de nível de competição. A tecnologia sem fio LIGHTSPEED oferece desempenho super rápido de 1ms. Com incrível eficiência de energia, o G305 permanece ligado e pronto para jogar por até 250 horas com uma única pilha AA inclusa.", 1u, new Guid("613a6739-52cb-49eb-af65-d701f4ddf895"), new Guid("85486af8-07ba-455c-8e16-245721253aa2"), "~/img/Produtos/5.jpg", "Mouse Gamer Sem Fio Logitech G305 Lightspeed, 12.000 DPI, 6 Botões Programáveis, Branco - 910-005290", 349.9m },
                    { new Guid("e4a42b4b-bfb6-4b5c-aecd-685aec028829"), "O Smartphone Moto E7 conta com sensor de câmera de 48MP que deixam as fotos sempre claras e nítidas, em qualquer iluminação. A tecnologia que o acompanha, Quad Pixel, proporciona 4 vezes mais sensibilidade a luz, para que os resultados fiquem ótimos em qualquer ambiente.", 20u, new Guid("715fec1d-0cf6-4f44-adec-2d2ccb7d35d0"), new Guid("b71ed344-64df-4479-bda4-c7f277026b91"), "~/img/Produtos/7.jpg", "Smartphone Motorola Moto E7, 64GB, RAM 4GB, Octa-Core, Câmera 48MP, 4000mAh, Cinza Metálico - PALV0031BR", 892.05m },
                    { new Guid("024aaa9f-fdbf-4adc-8055-a3325df5c125"), "Com recursos de ponta como TR-069 e interface web amigável que possibilita a criação de uma firmware personalizável, o DIR-842 é perfeito para provedores de internet que desejam implementar uma solução Wi-Fi de alta qualidade com a possibilidade de personalizar diversos dispositivos ao mesmo tempo. ", 10u, new Guid("0ab2f94b-42b6-4d57-bf86-c96e16b1aa6c"), new Guid("c08f9f34-0427-4c68-b456-4fa8e7c5309c"), "~/img/Produtos/8.jpg", "Roteador Wireless D-Link Gigabit-Ethernet AC 1200Mbps, Dual Band, 4 Antenas - DIR-842", 164.9m }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "dd3c4e7f-9385-4a9b-927b-97ff0550f2c2", "dd3c4e7f-9385-4a9b-927b-97ff0550f2c2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: new Guid("e1da9e97-7a9b-4956-8a01-042439ed752b"));

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: new Guid("fd15c5ef-e57a-4ab7-9ca3-22467f93eab7"));

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("024aaa9f-fdbf-4adc-8055-a3325df5c125"));

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("12bcc7ee-5a79-4d94-8f7b-25349d21e7d0"));

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("3f8c6847-e4d0-4db0-9e43-7181c20463c3"));

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("3fcab97b-3dc8-4ee3-8132-16cba77af00a"));

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("9468ac4d-88e6-4594-b356-626d19769f28"));

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("d20fed84-1f98-4465-b7b6-e70993fa413f"));

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("e27803dc-40c5-41d9-9c28-366a4f3ec057"));

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("e4a42b4b-bfb6-4b5c-aecd-685aec028829"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "364d87df-97c5-4b87-ae80-3ffac118b4d7");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "b1107611-9c23-4f96-a8ba-99cc697546dd");

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "dd3c4e7f-9385-4a9b-927b-97ff0550f2c2", "dd3c4e7f-9385-4a9b-927b-97ff0550f2c2" });

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: new Guid("0ab2f94b-42b6-4d57-bf86-c96e16b1aa6c"));

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: new Guid("613a6739-52cb-49eb-af65-d701f4ddf895"));

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: new Guid("715fec1d-0cf6-4f44-adec-2d2ccb7d35d0"));

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: new Guid("b4e01979-6fcf-4feb-b1cb-c172ad44b8f4"));

            migrationBuilder.DeleteData(
                table: "Marca",
                keyColumn: "Id",
                keyValue: new Guid("05e05427-6f80-4f02-9b83-3d39f2355011"));

            migrationBuilder.DeleteData(
                table: "Marca",
                keyColumn: "Id",
                keyValue: new Guid("85486af8-07ba-455c-8e16-245721253aa2"));

            migrationBuilder.DeleteData(
                table: "Marca",
                keyColumn: "Id",
                keyValue: new Guid("b71ed344-64df-4479-bda4-c7f277026b91"));

            migrationBuilder.DeleteData(
                table: "Marca",
                keyColumn: "Id",
                keyValue: new Guid("c08f9f34-0427-4c68-b456-4fa8e7c5309c"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "dd3c4e7f-9385-4a9b-927b-97ff0550f2c2");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "dd3c4e7f-9385-4a9b-927b-97ff0550f2c2");

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
    }
}
