using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AppEcommerce.Migrations
{
    public partial class bandodois : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: new Guid("710cbc38-b210-42e4-8376-b983589aa81a"));

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: new Guid("736dbd51-139c-478b-abac-a40edf495247"));

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: new Guid("b47a8499-1732-49c7-8082-ad2fc2f1ca57"));

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: new Guid("c975c21f-f560-4ec1-846c-80c503e8498a"));

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("40955cac-7f3d-4099-9a2c-88f65f4da47c"));

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("647df8c8-770a-420b-b0b1-ee9862c9d31e"));

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("b3df51e7-6cea-4cef-a1f0-5bc5b1035796"));

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("d66bd7f4-e61a-49ef-aadb-762cb49e7c43"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "6cfa3d77-8ab3-45ca-afce-2537ba224605");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "eee44020-2dea-4147-a7f6-7a33e21707ea");

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1902f2ee-cd2a-4a09-9fe4-29629ba3887e", "1902f2ee-cd2a-4a09-9fe4-29629ba3887e" });

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: new Guid("5e7d0963-0f25-4898-b61a-193622b32222"));

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: new Guid("89cba3de-3c51-4e58-8bc2-b7058656190f"));

            migrationBuilder.DeleteData(
                table: "Marca",
                keyColumn: "Id",
                keyValue: new Guid("42961b69-fb9f-41f5-adf5-85665e264aab"));

            migrationBuilder.DeleteData(
                table: "Marca",
                keyColumn: "Id",
                keyValue: new Guid("ba9c684b-ec5b-4c0d-850c-352efd82b52a"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "1902f2ee-cd2a-4a09-9fe4-29629ba3887e");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "1902f2ee-cd2a-4a09-9fe4-29629ba3887e");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("5e7d0963-0f25-4898-b61a-193622b32222"), "~/img/Produtos/001.png", "Computadores" },
                    { new Guid("710cbc38-b210-42e4-8376-b983589aa81a"), "~/img/Produtos/002.png", "Celulares" },
                    { new Guid("89cba3de-3c51-4e58-8bc2-b7058656190f"), "~/img/Produtos/003.png", "Periféricos" },
                    { new Guid("c975c21f-f560-4ec1-846c-80c503e8498a"), "~/img/Produtos/004.png", "Games" },
                    { new Guid("736dbd51-139c-478b-abac-a40edf495247"), "~/img/Produtos/005.png", "Cadeiras" },
                    { new Guid("b47a8499-1732-49c7-8082-ad2fc2f1ca57"), "~/img/Produtos/006.png", "Conectividade" }
                });

            migrationBuilder.InsertData(
                table: "Marca",
                columns: new[] { "Id", "Nome" },
                values: new object[,]
                {
                    { new Guid("ba9c684b-ec5b-4c0d-850c-352efd82b52a"), "Nvidia" },
                    { new Guid("42961b69-fb9f-41f5-adf5-85665e264aab"), "Logitech" }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1902f2ee-cd2a-4a09-9fe4-29629ba3887e", "9c9bc30a-4aa7-4de2-a9c0-158653fbd5fb", "Administrador", "ADMINISTRADOR" },
                    { "eee44020-2dea-4147-a7f6-7a33e21707ea", "561d6884-4fee-47cf-af96-bc97aba31e61", "Moderador", "MODERADOR" },
                    { "6cfa3d77-8ab3-45ca-afce-2537ba224605", "e19dd368-e76c-4326-8495-24161365c6dc", "Usuario", "USUARIO" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NomeCompleto", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "1902f2ee-cd2a-4a09-9fe4-29629ba3887e", 0, "ec622d29-faf6-4c6d-a32c-768ad6f694cf", "admin@ecommerce.com.br", true, false, null, "Igor Oliveira de Lima", "ADMIN@ECOMMERCE.COM.BR", "ADMIN", "AQAAAAEAACcQAAAAEAUYENyKtY2zvnw4Ie0DBL6ajagYrwNgTeh9eQpORwU6gMOqyPSvftRradybOujmbg==", null, false, "12405375", false, "Admin" });

            migrationBuilder.InsertData(
                table: "Produto",
                columns: new[] { "Id", "Descricao", "Estoque", "IdCategoria", "IdMarca", "Imagem", "Nome", "Valor" },
                values: new object[,]
                {
                    { new Guid("b3df51e7-6cea-4cef-a1f0-5bc5b1035796"), "A Placa Gráfica Nvidia Quadro P400 combina a mais recente arquitetura NVIDIA Quadro Pascal GPU com 2GB de ultra-rápido de memória on-board para entregar ótimo desempenho para uma gama de aplicações profissionais. Um fator de forma de baixo perfil e slot único torna-o compatível até com o chassi com mais espaço e com menor consumo de energia. O suporte para três monitores 4K (4096 x 2160 a 60Hz) com cores HDR oferece um amplo espaço de trabalho visual para visualizar seu trabalho em resolução extremamente alta.", 8u, new Guid("5e7d0963-0f25-4898-b61a-193622b32222"), new Guid("ba9c684b-ec5b-4c0d-850c-352efd82b52a"), "~/img/Produtos/1.jpg", "Placa Gráfica Nvidia Quadro P400 2gb Gddr5 64bits - Pny Vcqp400v2-pb", 1223.99m },
                    { new Guid("d66bd7f4-e61a-49ef-aadb-762cb49e7c43"), "O novíssimo GALAX Serious Gaming Edition está equipado com 1-Clip Booster, que pode ser instalado na placa traseira e é a precisão e qualidade que ganham. Quando o ventilador está na parte de trás, a placa de circuito impresso é na verdade muito mais curta do que o cooler e a chave é permitir que o ar flua o mais facilmente possível, portanto, o GALAX construiu orifícios maiores que permitem que o ar flua para cumprir o primeiro requisito. Além disso, a vantagem de adicionar uma ventoinha na placa traseira, o design da ventoinha auxiliar de 1 clipe suga o ar em vez de soprar o ar para dentro, criando efeitos de resfriamento push-pull tecnicamente corretos. Quando esta ventoinha adicional é usada, ela pode obter um melhor desempenho como se uma GPU funcionasse com uma placa traseira normal.", 10u, new Guid("5e7d0963-0f25-4898-b61a-193622b32222"), new Guid("ba9c684b-ec5b-4c0d-850c-352efd82b52a"), "~/img/Produtos/2.jpg", "Placa De Vídeo Galax GeForce RTX 3070 Ti SG 1-Click 8gb GDRR6X 256bits 37ISM6MD4BSG", 7936m },
                    { new Guid("647df8c8-770a-420b-b0b1-ee9862c9d31e"), "O G403 HERO tem a versatilidade e o desempenho para atender todos os tipos de jogos e jogadores. Um mouse gamer leve, ergonômico e totalmente projetado para oferecer a precisão que você exige para jogar em alto nível, agora com o SENSOR HERO 25K de última geração.", 16u, new Guid("89cba3de-3c51-4e58-8bc2-b7058656190f"), new Guid("42961b69-fb9f-41f5-adf5-85665e264aab"), "~/img/Produtos/3.jpg", "Mouse Gamer Logitech G403 HERO com RGB LIGHTSYNC, 6 Botões Programáveis, Ajuste de Peso e Sensor HERO 25K - 910-005631", 209m },
                    { new Guid("40955cac-7f3d-4099-9a2c-88f65f4da47c"), "xperimente chamadas de voz, Skype, webinars e muito mais com clareza usando uma conexão USB plug-and-play simples com o headset H390. O microfone rígido do lado esquerdo pode ser colocado na posição mais adequada para capturar melhor sua voz e é móvel podendo ser recolhido para não atrapalhar quando não estiver sendo usado. Os controles integrados no fio do headset permitem controlar o volume ou colocar chamadas em silêncio com facilidade. O arco de cabeça ajustável com fones acolchoados giratórios de couro sintético oferece horas de conforto. E também é fácil de limpar.", 20u, new Guid("89cba3de-3c51-4e58-8bc2-b7058656190f"), new Guid("42961b69-fb9f-41f5-adf5-85665e264aab"), "~/img/Produtos/4.jpg", "Headset com fio USB Logitech H390 com Almofadas em Couro, Controles de Áudio Integrado e Microfone com Redução de Ruído - 981-000014", 179.99m }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1902f2ee-cd2a-4a09-9fe4-29629ba3887e", "1902f2ee-cd2a-4a09-9fe4-29629ba3887e" });
        }
    }
}
