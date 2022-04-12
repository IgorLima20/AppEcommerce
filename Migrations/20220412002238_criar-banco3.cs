using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AppEcommerce.Migrations
{
    public partial class criarbanco3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: new Guid("0deeabdd-cea6-4fb4-bbfb-b327ce5c4ade"));

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: new Guid("48a7ee25-74db-4a5d-a11c-65c339aad23d"));

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("0aff5f32-5422-4f9c-88a8-4bae37962cdf"));

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("0e527109-700e-491e-9104-69d46c59d1ba"));

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("6116952a-406c-4436-b265-2c7ac7ba7ee5"));

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("68dc5b88-a0c5-4ca9-b696-ecb4ffab48e9"));

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("7e0e9a25-1ba6-4088-9b44-4685ce392436"));

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("d6d79dee-533e-4bc2-99b5-536bdedf0989"));

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("dcaaea76-62dc-430c-a346-317bad581a69"));

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("f3de6bab-1ee2-4013-b6b4-87ba47fc8e07"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "4aaf14ff-4587-42eb-89fb-e65fcbe81551");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "e8dbaa9d-3f84-4184-b720-d2da14bd4d1b");

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bbcf6e51-e1fa-4ec0-80f5-03c9af7b8b72", "bbcf6e51-e1fa-4ec0-80f5-03c9af7b8b72" });

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: new Guid("26c6dc8c-75d0-496e-8a04-085aebc6415c"));

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: new Guid("59bbb131-66ff-4557-92f6-a7675694720c"));

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: new Guid("87fbe78b-50e1-436d-bd9e-796834c9b29b"));

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: new Guid("f308788e-a597-41a7-bf0d-a08f0124e2bc"));

            migrationBuilder.DeleteData(
                table: "Marca",
                keyColumn: "Id",
                keyValue: new Guid("1d03fff4-4df0-4914-9576-0e63a96d0b93"));

            migrationBuilder.DeleteData(
                table: "Marca",
                keyColumn: "Id",
                keyValue: new Guid("277a85a0-e68b-4d0b-aa0d-f541e0e3bcaf"));

            migrationBuilder.DeleteData(
                table: "Marca",
                keyColumn: "Id",
                keyValue: new Guid("74bf313a-8def-4764-872e-d677f617ca98"));

            migrationBuilder.DeleteData(
                table: "Marca",
                keyColumn: "Id",
                keyValue: new Guid("8885aa6a-bed2-4592-aeb1-8506e459ec82"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "bbcf6e51-e1fa-4ec0-80f5-03c9af7b8b72");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "bbcf6e51-e1fa-4ec0-80f5-03c9af7b8b72");

            migrationBuilder.InsertData(
                table: "Categoria",
                columns: new[] { "Id", "Imagem", "Nome" },
                values: new object[,]
                {
                    { new Guid("8beea598-a3bb-4919-ae33-3c51226a3021"), "~/img/Produtos/001.png", "Hardware" },
                    { new Guid("5fe28d9b-8c9a-4d02-b5d6-75bf173954e9"), "~/img/Produtos/002.png", "Celulares" },
                    { new Guid("95d77409-bb85-4cbd-837a-8e503245785d"), "~/img/Produtos/003.png", "Periféricos" },
                    { new Guid("e0022a28-9903-46df-b36c-2599486ee84d"), "~/img/Produtos/004.png", "Games" },
                    { new Guid("dc018fb3-6ebf-494d-8f04-cca79a8048a7"), "~/img/Produtos/005.png", "Cadeiras" },
                    { new Guid("b90f4d34-c4da-4343-9d90-8ffd167938dd"), "~/img/Produtos/006.png", "Conectividade" }
                });

            migrationBuilder.InsertData(
                table: "Marca",
                columns: new[] { "Id", "Nome" },
                values: new object[,]
                {
                    { new Guid("574acee5-d9cd-40fd-8c48-b2c1d8803540"), "Nvidia" },
                    { new Guid("c136b93e-fdf4-43a6-9386-a603b1a57a1d"), "Logitech" },
                    { new Guid("f9395829-5516-4442-ad71-17c34695a036"), "Motorola" },
                    { new Guid("ea6259ae-7c0a-4505-85da-f7fcf5f9e567"), "D-Link" }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "c8097dce-1c8a-4518-a53b-ac1180376759", "3b0374be-9044-4788-a4ca-9def36d32deb", "Administrador", "ADMINISTRADOR" },
                    { "2d74213c-b93b-456d-95f0-3482959453a5", "59dbc640-b6ac-4759-8f6c-00776b10c2d3", "Moderador", "MODERADOR" },
                    { "9370a5b5-60ab-4455-8371-5d731d1c6630", "474491bb-0fcc-4250-b3e2-d73d74536376", "Usuario", "USUARIO" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NomeCompleto", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "c8097dce-1c8a-4518-a53b-ac1180376759", 0, "b2e53d47-8f06-4a01-b99a-10c7dafa4231", "admin@ecommerce.com.br", true, false, null, "Igor Oliveira de Lima", "ADMIN@ECOMMERCE.COM.BR", "ADMIN", "AQAAAAEAACcQAAAAEIUu05mJT2DLcx+FQauUERQFZCzAWphUUNAT/w+DIBpf1SOazzB9S7KPh9fSSQS+KQ==", null, false, "55725192", false, "Admin" });

            migrationBuilder.InsertData(
                table: "Produto",
                columns: new[] { "Id", "Descricao", "Estoque", "IdCategoria", "IdMarca", "Imagem", "Nome", "Valor" },
                values: new object[,]
                {
                    { new Guid("11b9ab34-a058-4ade-8912-4c406ca9a00d"), "A Placa Gráfica Nvidia Quadro P400 combina a mais recente arquitetura NVIDIA Quadro Pascal GPU com 2GB de ultra-rápido de memória on-board para entregar ótimo desempenho para uma gama de aplicações profissionais. Um fator de forma de baixo perfil e slot único torna-o compatível até com o chassi com mais espaço e com menor consumo de energia. O suporte para três monitores 4K (4096 x 2160 a 60Hz) com cores HDR oferece um amplo espaço de trabalho visual para visualizar seu trabalho em resolução extremamente alta.", 8u, new Guid("8beea598-a3bb-4919-ae33-3c51226a3021"), new Guid("574acee5-d9cd-40fd-8c48-b2c1d8803540"), "~/img/Produtos/1.jpg", "Placa Gráfica Nvidia Quadro P400 2gb Gddr5 64bits - Pny Vcqp400v2-pb", 1223m },
                    { new Guid("baa85166-57c9-416f-a3f1-dda4792f8b19"), "O novíssimo GALAX Serious Gaming Edition está equipado com 1-Clip Booster, que pode ser instalado na placa traseira e é a precisão e qualidade que ganham. Quando o ventilador está na parte de trás, a placa de circuito impresso é na verdade muito mais curta do que o cooler e a chave é permitir que o ar flua o mais facilmente possível, portanto, o GALAX construiu orifícios maiores que permitem que o ar flua para cumprir o primeiro requisito. Além disso, a vantagem de adicionar uma ventoinha na placa traseira, o design da ventoinha auxiliar de 1 clipe suga o ar em vez de soprar o ar para dentro, criando efeitos de resfriamento push-pull tecnicamente corretos. Quando esta ventoinha adicional é usada, ela pode obter um melhor desempenho como se uma GPU funcionasse com uma placa traseira normal.", 10u, new Guid("8beea598-a3bb-4919-ae33-3c51226a3021"), new Guid("574acee5-d9cd-40fd-8c48-b2c1d8803540"), "~/img/Produtos/2.jpg", "Placa De Vídeo Galax GeForce RTX 3070 Ti SG 1-Click 8gb GDRR6X 256bits 37ISM6MD4BSG", 7936m },
                    { new Guid("3686efc2-deef-43c4-a3cf-1483fb30e2ff"), "Potência e desempenho em uma Solução Compacta. A NVIDIA T1000, desenvolvida com base na arquitetura de GPU NVIDIA Turing, é uma solução poderosa e discreta que oferece excelentes recursos e desempenho exigidos por intensos aplicativos profissionais em uma placa gráfica de formato compacto. Com 896 CUDA Cores e 4 GB de memória GDDR6, a T1000 permite que os profissionais lidem com vários fluxos de trabalho, desde a modelagem 3D até a edição de vídeo.", 0u, new Guid("8beea598-a3bb-4919-ae33-3c51226a3021"), new Guid("574acee5-d9cd-40fd-8c48-b2c1d8803540"), "~/img/Produtos/6.jpg", "Pny Quadro Workstation Server Placa De Video Pny Vcnt1000-pb T1000 4GB DDR6 128bit Dp", 2743m },
                    { new Guid("47b352ec-893a-4953-93a1-cdc3688613ab"), "O G403 HERO tem a versatilidade e o desempenho para atender todos os tipos de jogos e jogadores. Um mouse gamer leve, ergonômico e totalmente projetado para oferecer a precisão que você exige para jogar em alto nível, agora com o SENSOR HERO 25K de última geração.", 16u, new Guid("95d77409-bb85-4cbd-837a-8e503245785d"), new Guid("c136b93e-fdf4-43a6-9386-a603b1a57a1d"), "~/img/Produtos/3.jpg", "Mouse Gamer Logitech G403 HERO com RGB LIGHTSYNC, 6 Botões Programáveis, Ajuste de Peso e Sensor HERO 25K - 910-005631", 209m },
                    { new Guid("8ff3525b-9a19-4b72-8f4b-003ed2d815ba"), "xperimente chamadas de voz, Skype, webinars e muito mais com clareza usando uma conexão USB plug-and-play simples com o headset H390. O microfone rígido do lado esquerdo pode ser colocado na posição mais adequada para capturar melhor sua voz e é móvel podendo ser recolhido para não atrapalhar quando não estiver sendo usado. Os controles integrados no fio do headset permitem controlar o volume ou colocar chamadas em silêncio com facilidade. O arco de cabeça ajustável com fones acolchoados giratórios de couro sintético oferece horas de conforto. E também é fácil de limpar.", 20u, new Guid("95d77409-bb85-4cbd-837a-8e503245785d"), new Guid("c136b93e-fdf4-43a6-9386-a603b1a57a1d"), "~/img/Produtos/4.jpg", "Headset com fio USB Logitech H390 com Almofadas em Couro, Controles de Áudio Integrado e Microfone com Redução de Ruído - 981-000014", 179m },
                    { new Guid("ff0daab8-9c17-4aca-96a1-028670788c03"), "O G305 apresenta o sensor HERO de última geração com sensibilidade de 200 a 12.000 DPI para precisão de nível de competição. A tecnologia sem fio LIGHTSPEED oferece desempenho super rápido de 1ms. Com incrível eficiência de energia, o G305 permanece ligado e pronto para jogar por até 250 horas com uma única pilha AA inclusa.", 1u, new Guid("95d77409-bb85-4cbd-837a-8e503245785d"), new Guid("c136b93e-fdf4-43a6-9386-a603b1a57a1d"), "~/img/Produtos/5.jpg", "Mouse Gamer Sem Fio Logitech G305 Lightspeed, 12.000 DPI, 6 Botões Programáveis, Branco - 910-005290", 349m },
                    { new Guid("b20ed8d4-d1fa-4059-b14f-ae07caff2fff"), "O Smartphone Moto E7 conta com sensor de câmera de 48MP que deixam as fotos sempre claras e nítidas, em qualquer iluminação. A tecnologia que o acompanha, Quad Pixel, proporciona 4 vezes mais sensibilidade a luz, para que os resultados fiquem ótimos em qualquer ambiente.", 20u, new Guid("5fe28d9b-8c9a-4d02-b5d6-75bf173954e9"), new Guid("f9395829-5516-4442-ad71-17c34695a036"), "~/img/Produtos/7.jpg", "Smartphone Motorola Moto E7, 64GB, RAM 4GB, Octa-Core, Câmera 48MP, 4000mAh, Cinza Metálico - PALV0031BR", 892m },
                    { new Guid("d9ed62b7-660d-4d48-aa6d-fb79f51c7af2"), "Com recursos de ponta como TR-069 e interface web amigável que possibilita a criação de uma firmware personalizável, o DIR-842 é perfeito para provedores de internet que desejam implementar uma solução Wi-Fi de alta qualidade com a possibilidade de personalizar diversos dispositivos ao mesmo tempo. ", 10u, new Guid("b90f4d34-c4da-4343-9d90-8ffd167938dd"), new Guid("ea6259ae-7c0a-4505-85da-f7fcf5f9e567"), "~/img/Produtos/8.jpg", "Roteador Wireless D-Link Gigabit-Ethernet AC 1200Mbps, Dual Band, 4 Antenas - DIR-842", 164m }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "c8097dce-1c8a-4518-a53b-ac1180376759", "c8097dce-1c8a-4518-a53b-ac1180376759" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: new Guid("dc018fb3-6ebf-494d-8f04-cca79a8048a7"));

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: new Guid("e0022a28-9903-46df-b36c-2599486ee84d"));

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("11b9ab34-a058-4ade-8912-4c406ca9a00d"));

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("3686efc2-deef-43c4-a3cf-1483fb30e2ff"));

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("47b352ec-893a-4953-93a1-cdc3688613ab"));

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("8ff3525b-9a19-4b72-8f4b-003ed2d815ba"));

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("b20ed8d4-d1fa-4059-b14f-ae07caff2fff"));

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("baa85166-57c9-416f-a3f1-dda4792f8b19"));

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("d9ed62b7-660d-4d48-aa6d-fb79f51c7af2"));

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("ff0daab8-9c17-4aca-96a1-028670788c03"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "2d74213c-b93b-456d-95f0-3482959453a5");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "9370a5b5-60ab-4455-8371-5d731d1c6630");

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c8097dce-1c8a-4518-a53b-ac1180376759", "c8097dce-1c8a-4518-a53b-ac1180376759" });

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: new Guid("5fe28d9b-8c9a-4d02-b5d6-75bf173954e9"));

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: new Guid("8beea598-a3bb-4919-ae33-3c51226a3021"));

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: new Guid("95d77409-bb85-4cbd-837a-8e503245785d"));

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: new Guid("b90f4d34-c4da-4343-9d90-8ffd167938dd"));

            migrationBuilder.DeleteData(
                table: "Marca",
                keyColumn: "Id",
                keyValue: new Guid("574acee5-d9cd-40fd-8c48-b2c1d8803540"));

            migrationBuilder.DeleteData(
                table: "Marca",
                keyColumn: "Id",
                keyValue: new Guid("c136b93e-fdf4-43a6-9386-a603b1a57a1d"));

            migrationBuilder.DeleteData(
                table: "Marca",
                keyColumn: "Id",
                keyValue: new Guid("ea6259ae-7c0a-4505-85da-f7fcf5f9e567"));

            migrationBuilder.DeleteData(
                table: "Marca",
                keyColumn: "Id",
                keyValue: new Guid("f9395829-5516-4442-ad71-17c34695a036"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "c8097dce-1c8a-4518-a53b-ac1180376759");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "c8097dce-1c8a-4518-a53b-ac1180376759");

            migrationBuilder.InsertData(
                table: "Categoria",
                columns: new[] { "Id", "Imagem", "Nome" },
                values: new object[,]
                {
                    { new Guid("f308788e-a597-41a7-bf0d-a08f0124e2bc"), "~/img/Produtos/001.png", "Hardware" },
                    { new Guid("59bbb131-66ff-4557-92f6-a7675694720c"), "~/img/Produtos/002.png", "Celulares" },
                    { new Guid("87fbe78b-50e1-436d-bd9e-796834c9b29b"), "~/img/Produtos/003.png", "Periféricos" },
                    { new Guid("0deeabdd-cea6-4fb4-bbfb-b327ce5c4ade"), "~/img/Produtos/004.png", "Games" },
                    { new Guid("48a7ee25-74db-4a5d-a11c-65c339aad23d"), "~/img/Produtos/005.png", "Cadeiras" },
                    { new Guid("26c6dc8c-75d0-496e-8a04-085aebc6415c"), "~/img/Produtos/006.png", "Conectividade" }
                });

            migrationBuilder.InsertData(
                table: "Marca",
                columns: new[] { "Id", "Nome" },
                values: new object[,]
                {
                    { new Guid("277a85a0-e68b-4d0b-aa0d-f541e0e3bcaf"), "Nvidia" },
                    { new Guid("1d03fff4-4df0-4914-9576-0e63a96d0b93"), "Logitech" },
                    { new Guid("74bf313a-8def-4764-872e-d677f617ca98"), "Motorola" },
                    { new Guid("8885aa6a-bed2-4592-aeb1-8506e459ec82"), "D-Link" }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "bbcf6e51-e1fa-4ec0-80f5-03c9af7b8b72", "5e87093e-866f-4572-8036-e3b379456194", "Administrador", "ADMINISTRADOR" },
                    { "e8dbaa9d-3f84-4184-b720-d2da14bd4d1b", "c36f5147-64c5-4ad8-95f7-d9878d33b2ab", "Moderador", "MODERADOR" },
                    { "4aaf14ff-4587-42eb-89fb-e65fcbe81551", "4b8ccea7-0a87-4c65-acff-a7f33cc4c213", "Usuario", "USUARIO" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NomeCompleto", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "bbcf6e51-e1fa-4ec0-80f5-03c9af7b8b72", 0, "c4eaac73-9cc8-4fff-9f26-7d8af4fb5780", "admin@ecommerce.com.br", true, false, null, "Igor Oliveira de Lima", "ADMIN@ECOMMERCE.COM.BR", "ADMIN", "AQAAAAEAACcQAAAAEMWcsX41cJZLioWa5f4JRshfg/zLfjnnoeddktsEqerCByZbeowDOBNH2zDA57CViA==", null, false, "55725192", false, "Admin" });

            migrationBuilder.InsertData(
                table: "Produto",
                columns: new[] { "Id", "Descricao", "Estoque", "IdCategoria", "IdMarca", "Imagem", "Nome", "Valor" },
                values: new object[,]
                {
                    { new Guid("0aff5f32-5422-4f9c-88a8-4bae37962cdf"), "A Placa Gráfica Nvidia Quadro P400 combina a mais recente arquitetura NVIDIA Quadro Pascal GPU com 2GB de ultra-rápido de memória on-board para entregar ótimo desempenho para uma gama de aplicações profissionais. Um fator de forma de baixo perfil e slot único torna-o compatível até com o chassi com mais espaço e com menor consumo de energia. O suporte para três monitores 4K (4096 x 2160 a 60Hz) com cores HDR oferece um amplo espaço de trabalho visual para visualizar seu trabalho em resolução extremamente alta.", 8u, new Guid("f308788e-a597-41a7-bf0d-a08f0124e2bc"), new Guid("277a85a0-e68b-4d0b-aa0d-f541e0e3bcaf"), "~/img/Produtos/1.jpg", "Placa Gráfica Nvidia Quadro P400 2gb Gddr5 64bits - Pny Vcqp400v2-pb", 1223m },
                    { new Guid("d6d79dee-533e-4bc2-99b5-536bdedf0989"), "O novíssimo GALAX Serious Gaming Edition está equipado com 1-Clip Booster, que pode ser instalado na placa traseira e é a precisão e qualidade que ganham. Quando o ventilador está na parte de trás, a placa de circuito impresso é na verdade muito mais curta do que o cooler e a chave é permitir que o ar flua o mais facilmente possível, portanto, o GALAX construiu orifícios maiores que permitem que o ar flua para cumprir o primeiro requisito. Além disso, a vantagem de adicionar uma ventoinha na placa traseira, o design da ventoinha auxiliar de 1 clipe suga o ar em vez de soprar o ar para dentro, criando efeitos de resfriamento push-pull tecnicamente corretos. Quando esta ventoinha adicional é usada, ela pode obter um melhor desempenho como se uma GPU funcionasse com uma placa traseira normal.", 10u, new Guid("f308788e-a597-41a7-bf0d-a08f0124e2bc"), new Guid("277a85a0-e68b-4d0b-aa0d-f541e0e3bcaf"), "~/img/Produtos/2.jpg", "Placa De Vídeo Galax GeForce RTX 3070 Ti SG 1-Click 8gb GDRR6X 256bits 37ISM6MD4BSG", 7936m },
                    { new Guid("0e527109-700e-491e-9104-69d46c59d1ba"), "Potência e desempenho em uma Solução Compacta. A NVIDIA T1000, desenvolvida com base na arquitetura de GPU NVIDIA Turing, é uma solução poderosa e discreta que oferece excelentes recursos e desempenho exigidos por intensos aplicativos profissionais em uma placa gráfica de formato compacto. Com 896 CUDA Cores e 4 GB de memória GDDR6, a T1000 permite que os profissionais lidem com vários fluxos de trabalho, desde a modelagem 3D até a edição de vídeo.", 0u, new Guid("f308788e-a597-41a7-bf0d-a08f0124e2bc"), new Guid("277a85a0-e68b-4d0b-aa0d-f541e0e3bcaf"), "~/img/Produtos/6.jpg", "Pny Quadro Workstation Server Placa De Video Pny Vcnt1000-pb T1000 4GB DDR6 128bit Dp", 2743m },
                    { new Guid("6116952a-406c-4436-b265-2c7ac7ba7ee5"), "O G403 HERO tem a versatilidade e o desempenho para atender todos os tipos de jogos e jogadores. Um mouse gamer leve, ergonômico e totalmente projetado para oferecer a precisão que você exige para jogar em alto nível, agora com o SENSOR HERO 25K de última geração.", 16u, new Guid("87fbe78b-50e1-436d-bd9e-796834c9b29b"), new Guid("1d03fff4-4df0-4914-9576-0e63a96d0b93"), "~/img/Produtos/3.jpg", "Mouse Gamer Logitech G403 HERO com RGB LIGHTSYNC, 6 Botões Programáveis, Ajuste de Peso e Sensor HERO 25K - 910-005631", 209m },
                    { new Guid("7e0e9a25-1ba6-4088-9b44-4685ce392436"), "xperimente chamadas de voz, Skype, webinars e muito mais com clareza usando uma conexão USB plug-and-play simples com o headset H390. O microfone rígido do lado esquerdo pode ser colocado na posição mais adequada para capturar melhor sua voz e é móvel podendo ser recolhido para não atrapalhar quando não estiver sendo usado. Os controles integrados no fio do headset permitem controlar o volume ou colocar chamadas em silêncio com facilidade. O arco de cabeça ajustável com fones acolchoados giratórios de couro sintético oferece horas de conforto. E também é fácil de limpar.", 20u, new Guid("87fbe78b-50e1-436d-bd9e-796834c9b29b"), new Guid("1d03fff4-4df0-4914-9576-0e63a96d0b93"), "~/img/Produtos/4.jpg", "Headset com fio USB Logitech H390 com Almofadas em Couro, Controles de Áudio Integrado e Microfone com Redução de Ruído - 981-000014", 179m },
                    { new Guid("68dc5b88-a0c5-4ca9-b696-ecb4ffab48e9"), "O G305 apresenta o sensor HERO de última geração com sensibilidade de 200 a 12.000 DPI para precisão de nível de competição. A tecnologia sem fio LIGHTSPEED oferece desempenho super rápido de 1ms. Com incrível eficiência de energia, o G305 permanece ligado e pronto para jogar por até 250 horas com uma única pilha AA inclusa.", 1u, new Guid("87fbe78b-50e1-436d-bd9e-796834c9b29b"), new Guid("1d03fff4-4df0-4914-9576-0e63a96d0b93"), "~/img/Produtos/5.jpg", "Mouse Gamer Sem Fio Logitech G305 Lightspeed, 12.000 DPI, 6 Botões Programáveis, Branco - 910-005290", 349m },
                    { new Guid("f3de6bab-1ee2-4013-b6b4-87ba47fc8e07"), "O Smartphone Moto E7 conta com sensor de câmera de 48MP que deixam as fotos sempre claras e nítidas, em qualquer iluminação. A tecnologia que o acompanha, Quad Pixel, proporciona 4 vezes mais sensibilidade a luz, para que os resultados fiquem ótimos em qualquer ambiente.", 20u, new Guid("59bbb131-66ff-4557-92f6-a7675694720c"), new Guid("74bf313a-8def-4764-872e-d677f617ca98"), "~/img/Produtos/7.jpg", "Smartphone Motorola Moto E7, 64GB, RAM 4GB, Octa-Core, Câmera 48MP, 4000mAh, Cinza Metálico - PALV0031BR", 892m },
                    { new Guid("dcaaea76-62dc-430c-a346-317bad581a69"), "Com recursos de ponta como TR-069 e interface web amigável que possibilita a criação de uma firmware personalizável, o DIR-842 é perfeito para provedores de internet que desejam implementar uma solução Wi-Fi de alta qualidade com a possibilidade de personalizar diversos dispositivos ao mesmo tempo. ", 10u, new Guid("26c6dc8c-75d0-496e-8a04-085aebc6415c"), new Guid("8885aa6a-bed2-4592-aeb1-8506e459ec82"), "~/img/Produtos/8.jpg", "Roteador Wireless D-Link Gigabit-Ethernet AC 1200Mbps, Dual Band, 4 Antenas - DIR-842", 164m }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "bbcf6e51-e1fa-4ec0-80f5-03c9af7b8b72", "bbcf6e51-e1fa-4ec0-80f5-03c9af7b8b72" });
        }
    }
}
