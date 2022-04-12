using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AppEcommerce.Migrations
{
    public partial class criarbanco2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: new Guid("41c8ea80-b775-4f4f-99f6-ed3ae0f4cc24"));

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: new Guid("65226b07-a1b0-46c2-8885-cc02991acb21"));

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("06280dad-3c79-4df5-9fe6-ced9b0a436f4"));

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("0b87e073-a860-455e-aaa3-1c04fb6cef5b"));

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("56c344ce-cf26-4948-bef1-fb1dc365663f"));

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("7f3c4d64-4911-4062-80ff-2b7da8ecc76f"));

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("c4b47104-cc27-4afd-9347-95ce2b0fe4eb"));

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("c556ce61-6aad-4920-aa31-090e94613ef3"));

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("dc48c6d4-f6e4-42e8-b6a1-d9ea7918d7f7"));

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("f5a4d05a-6393-403a-8713-05b08ec15ff7"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "b42df46f-b982-45e7-9537-6daad48f44df");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "c8fabef2-e8b6-4be6-9d33-598276487bd2");

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3a1e3203-fe05-490a-b04c-31c5d1590702", "3a1e3203-fe05-490a-b04c-31c5d1590702" });

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: new Guid("00c62db0-5fb6-453f-b860-1369c529deed"));

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: new Guid("608cf0f2-8528-42c1-a13e-a62e04c0b500"));

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: new Guid("bfd981df-9f82-4ef4-8fa0-2f2e2e5ed43b"));

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: new Guid("dcaffe0b-4157-4eca-ac88-f39bdc3b8a26"));

            migrationBuilder.DeleteData(
                table: "Marca",
                keyColumn: "Id",
                keyValue: new Guid("08a6c304-ea60-4f16-a128-d9544a6d7856"));

            migrationBuilder.DeleteData(
                table: "Marca",
                keyColumn: "Id",
                keyValue: new Guid("7f3a71c8-e082-4b05-b4f2-9265ba60a5c4"));

            migrationBuilder.DeleteData(
                table: "Marca",
                keyColumn: "Id",
                keyValue: new Guid("86fe38f3-fc06-47ce-b6d8-08266431e15a"));

            migrationBuilder.DeleteData(
                table: "Marca",
                keyColumn: "Id",
                keyValue: new Guid("92f3f92a-5da4-40cb-a594-d84884e79496"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "3a1e3203-fe05-490a-b04c-31c5d1590702");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "3a1e3203-fe05-490a-b04c-31c5d1590702");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("dcaffe0b-4157-4eca-ac88-f39bdc3b8a26"), "~/img/Produtos/001.png", "Hardware" },
                    { new Guid("bfd981df-9f82-4ef4-8fa0-2f2e2e5ed43b"), "~/img/Produtos/002.png", "Celulares" },
                    { new Guid("608cf0f2-8528-42c1-a13e-a62e04c0b500"), "~/img/Produtos/003.png", "Periféricos" },
                    { new Guid("41c8ea80-b775-4f4f-99f6-ed3ae0f4cc24"), "~/img/Produtos/004.png", "Games" },
                    { new Guid("65226b07-a1b0-46c2-8885-cc02991acb21"), "~/img/Produtos/005.png", "Cadeiras" },
                    { new Guid("00c62db0-5fb6-453f-b860-1369c529deed"), "~/img/Produtos/006.png", "Conectividade" }
                });

            migrationBuilder.InsertData(
                table: "Marca",
                columns: new[] { "Id", "Nome" },
                values: new object[,]
                {
                    { new Guid("7f3a71c8-e082-4b05-b4f2-9265ba60a5c4"), "Nvidia" },
                    { new Guid("08a6c304-ea60-4f16-a128-d9544a6d7856"), "Logitech" },
                    { new Guid("86fe38f3-fc06-47ce-b6d8-08266431e15a"), "Motorola" },
                    { new Guid("92f3f92a-5da4-40cb-a594-d84884e79496"), "D-Link" }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3a1e3203-fe05-490a-b04c-31c5d1590702", "c24de744-2a94-45de-8073-3ea31a6933c7", "Administrador", "ADMINISTRADOR" },
                    { "b42df46f-b982-45e7-9537-6daad48f44df", "0e07c6b3-8edf-43ee-8b28-0d489fa3ce72", "Moderador", "MODERADOR" },
                    { "c8fabef2-e8b6-4be6-9d33-598276487bd2", "92276f30-a0da-4919-97ce-bb3206caf1e9", "Usuario", "USUARIO" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NomeCompleto", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3a1e3203-fe05-490a-b04c-31c5d1590702", 0, "e52b5eb1-aa88-4aaa-9598-ba1b37f56b0c", "admin@ecommerce.com.br", true, false, null, "Igor Oliveira de Lima", "ADMIN@ECOMMERCE.COM.BR", "ADMIN", "AQAAAAEAACcQAAAAEOIa/aggkiEOHxxAccKD6qOO5F1dNQKAHpJweiNoWZ6cAxbSvWH6laT3AKsuOUQApw==", null, false, "50930930", false, "Admin" });

            migrationBuilder.InsertData(
                table: "Produto",
                columns: new[] { "Id", "Descricao", "Estoque", "IdCategoria", "IdMarca", "Imagem", "Nome", "Valor" },
                values: new object[,]
                {
                    { new Guid("dc48c6d4-f6e4-42e8-b6a1-d9ea7918d7f7"), "A Placa Gráfica Nvidia Quadro P400 combina a mais recente arquitetura NVIDIA Quadro Pascal GPU com 2GB de ultra-rápido de memória on-board para entregar ótimo desempenho para uma gama de aplicações profissionais. Um fator de forma de baixo perfil e slot único torna-o compatível até com o chassi com mais espaço e com menor consumo de energia. O suporte para três monitores 4K (4096 x 2160 a 60Hz) com cores HDR oferece um amplo espaço de trabalho visual para visualizar seu trabalho em resolução extremamente alta.", 8u, new Guid("dcaffe0b-4157-4eca-ac88-f39bdc3b8a26"), new Guid("7f3a71c8-e082-4b05-b4f2-9265ba60a5c4"), "~/img/Produtos/1.jpg", "Placa Gráfica Nvidia Quadro P400 2gb Gddr5 64bits - Pny Vcqp400v2-pb", 1223.99m },
                    { new Guid("c556ce61-6aad-4920-aa31-090e94613ef3"), "O novíssimo GALAX Serious Gaming Edition está equipado com 1-Clip Booster, que pode ser instalado na placa traseira e é a precisão e qualidade que ganham. Quando o ventilador está na parte de trás, a placa de circuito impresso é na verdade muito mais curta do que o cooler e a chave é permitir que o ar flua o mais facilmente possível, portanto, o GALAX construiu orifícios maiores que permitem que o ar flua para cumprir o primeiro requisito. Além disso, a vantagem de adicionar uma ventoinha na placa traseira, o design da ventoinha auxiliar de 1 clipe suga o ar em vez de soprar o ar para dentro, criando efeitos de resfriamento push-pull tecnicamente corretos. Quando esta ventoinha adicional é usada, ela pode obter um melhor desempenho como se uma GPU funcionasse com uma placa traseira normal.", 10u, new Guid("dcaffe0b-4157-4eca-ac88-f39bdc3b8a26"), new Guid("7f3a71c8-e082-4b05-b4f2-9265ba60a5c4"), "~/img/Produtos/2.jpg", "Placa De Vídeo Galax GeForce RTX 3070 Ti SG 1-Click 8gb GDRR6X 256bits 37ISM6MD4BSG", 7936m },
                    { new Guid("0b87e073-a860-455e-aaa3-1c04fb6cef5b"), "Potência e desempenho em uma Solução Compacta. A NVIDIA T1000, desenvolvida com base na arquitetura de GPU NVIDIA Turing, é uma solução poderosa e discreta que oferece excelentes recursos e desempenho exigidos por intensos aplicativos profissionais em uma placa gráfica de formato compacto. Com 896 CUDA Cores e 4 GB de memória GDDR6, a T1000 permite que os profissionais lidem com vários fluxos de trabalho, desde a modelagem 3D até a edição de vídeo.", 0u, new Guid("dcaffe0b-4157-4eca-ac88-f39bdc3b8a26"), new Guid("7f3a71c8-e082-4b05-b4f2-9265ba60a5c4"), "~/img/Produtos/6.jpg", "Pny Quadro Workstation Server Placa De Video Pny Vcnt1000-pb T1000 4GB DDR6 128bit Dp", 2743.98m },
                    { new Guid("7f3c4d64-4911-4062-80ff-2b7da8ecc76f"), "O G403 HERO tem a versatilidade e o desempenho para atender todos os tipos de jogos e jogadores. Um mouse gamer leve, ergonômico e totalmente projetado para oferecer a precisão que você exige para jogar em alto nível, agora com o SENSOR HERO 25K de última geração.", 16u, new Guid("608cf0f2-8528-42c1-a13e-a62e04c0b500"), new Guid("08a6c304-ea60-4f16-a128-d9544a6d7856"), "~/img/Produtos/3.jpg", "Mouse Gamer Logitech G403 HERO com RGB LIGHTSYNC, 6 Botões Programáveis, Ajuste de Peso e Sensor HERO 25K - 910-005631", 209m },
                    { new Guid("f5a4d05a-6393-403a-8713-05b08ec15ff7"), "xperimente chamadas de voz, Skype, webinars e muito mais com clareza usando uma conexão USB plug-and-play simples com o headset H390. O microfone rígido do lado esquerdo pode ser colocado na posição mais adequada para capturar melhor sua voz e é móvel podendo ser recolhido para não atrapalhar quando não estiver sendo usado. Os controles integrados no fio do headset permitem controlar o volume ou colocar chamadas em silêncio com facilidade. O arco de cabeça ajustável com fones acolchoados giratórios de couro sintético oferece horas de conforto. E também é fácil de limpar.", 20u, new Guid("608cf0f2-8528-42c1-a13e-a62e04c0b500"), new Guid("08a6c304-ea60-4f16-a128-d9544a6d7856"), "~/img/Produtos/4.jpg", "Headset com fio USB Logitech H390 com Almofadas em Couro, Controles de Áudio Integrado e Microfone com Redução de Ruído - 981-000014", 179.99m },
                    { new Guid("06280dad-3c79-4df5-9fe6-ced9b0a436f4"), "O G305 apresenta o sensor HERO de última geração com sensibilidade de 200 a 12.000 DPI para precisão de nível de competição. A tecnologia sem fio LIGHTSPEED oferece desempenho super rápido de 1ms. Com incrível eficiência de energia, o G305 permanece ligado e pronto para jogar por até 250 horas com uma única pilha AA inclusa.", 1u, new Guid("608cf0f2-8528-42c1-a13e-a62e04c0b500"), new Guid("08a6c304-ea60-4f16-a128-d9544a6d7856"), "~/img/Produtos/5.jpg", "Mouse Gamer Sem Fio Logitech G305 Lightspeed, 12.000 DPI, 6 Botões Programáveis, Branco - 910-005290", 349.9m },
                    { new Guid("c4b47104-cc27-4afd-9347-95ce2b0fe4eb"), "O Smartphone Moto E7 conta com sensor de câmera de 48MP que deixam as fotos sempre claras e nítidas, em qualquer iluminação. A tecnologia que o acompanha, Quad Pixel, proporciona 4 vezes mais sensibilidade a luz, para que os resultados fiquem ótimos em qualquer ambiente.", 20u, new Guid("bfd981df-9f82-4ef4-8fa0-2f2e2e5ed43b"), new Guid("86fe38f3-fc06-47ce-b6d8-08266431e15a"), "~/img/Produtos/7.jpg", "Smartphone Motorola Moto E7, 64GB, RAM 4GB, Octa-Core, Câmera 48MP, 4000mAh, Cinza Metálico - PALV0031BR", 892.05m },
                    { new Guid("56c344ce-cf26-4948-bef1-fb1dc365663f"), "Com recursos de ponta como TR-069 e interface web amigável que possibilita a criação de uma firmware personalizável, o DIR-842 é perfeito para provedores de internet que desejam implementar uma solução Wi-Fi de alta qualidade com a possibilidade de personalizar diversos dispositivos ao mesmo tempo. ", 10u, new Guid("00c62db0-5fb6-453f-b860-1369c529deed"), new Guid("92f3f92a-5da4-40cb-a594-d84884e79496"), "~/img/Produtos/8.jpg", "Roteador Wireless D-Link Gigabit-Ethernet AC 1200Mbps, Dual Band, 4 Antenas - DIR-842", 164.9m }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "3a1e3203-fe05-490a-b04c-31c5d1590702", "3a1e3203-fe05-490a-b04c-31c5d1590702" });
        }
    }
}
