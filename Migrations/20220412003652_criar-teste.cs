using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AppEcommerce.Migrations
{
    public partial class criarteste : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pedido_Cliente_IdCliente",
                table: "Pedido");

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

            migrationBuilder.AlterColumn<string>(
                name: "IdCliente",
                table: "Pedido",
                type: "varchar(255)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(255)")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Categoria",
                columns: new[] { "Id", "Imagem", "Nome" },
                values: new object[,]
                {
                    { new Guid("f653713b-90ca-45dc-aeb1-41713c17c8c6"), "~/img/Produtos/001.png", "Hardware" },
                    { new Guid("d492710f-6925-4d3f-bafc-2314e0b7f7fc"), "~/img/Produtos/002.png", "Celulares" },
                    { new Guid("540d4fa2-e040-4429-b071-f8d9221d54f5"), "~/img/Produtos/003.png", "Periféricos" },
                    { new Guid("625a4099-3797-4d50-92bf-8dd01b449e17"), "~/img/Produtos/004.png", "Games" },
                    { new Guid("ddb14a86-abd5-4dcd-99e5-811b0b38bcc6"), "~/img/Produtos/005.png", "Cadeiras" },
                    { new Guid("ea1ad97f-5771-47d9-bde4-731c5f94c3d3"), "~/img/Produtos/006.png", "Conectividade" }
                });

            migrationBuilder.InsertData(
                table: "Marca",
                columns: new[] { "Id", "Nome" },
                values: new object[,]
                {
                    { new Guid("ae606c8c-b979-412e-aa90-5725eb6e45a2"), "Nvidia" },
                    { new Guid("027bc9ab-c8b0-4d69-bf2e-87f61fd20d39"), "Logitech" },
                    { new Guid("828652a6-5eff-422f-875c-a4ed654c1569"), "Motorola" },
                    { new Guid("e6a5a354-f429-4670-a0a1-bcb74c1f0931"), "D-Link" }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5a10e121-a8e0-4c61-87e0-51d23ccf7ba5", "ddccebf1-cc22-4ebb-a925-7cfa6274be83", "Administrador", "ADMINISTRADOR" },
                    { "175172d3-1db3-4e97-9ea0-390ca00c7e7f", "59609558-e2a8-431f-8a08-9a5bcf765d97", "Moderador", "MODERADOR" },
                    { "5ca34725-a638-45c3-8226-d846a807c281", "e163af24-c05c-4130-af5d-011b629b6065", "Usuario", "USUARIO" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NomeCompleto", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "5a10e121-a8e0-4c61-87e0-51d23ccf7ba5", 0, "fbc55985-1133-4a3a-a74b-9a73c0c3244b", "admin@ecommerce.com.br", true, false, null, "Igor Oliveira de Lima", "ADMIN@ECOMMERCE.COM.BR", "ADMIN", "AQAAAAEAACcQAAAAEAQBGCUlpd7o2d8hxeKotPqve5XQUN//2IzSfJx7RpKW0G0U7gyuY3zDgIvqziklEQ==", null, false, "31764686", false, "Admin" });

            migrationBuilder.InsertData(
                table: "Produto",
                columns: new[] { "Id", "Descricao", "Estoque", "IdCategoria", "IdMarca", "Imagem", "Nome", "Valor" },
                values: new object[,]
                {
                    { new Guid("07450ee1-9439-459b-8972-e21abe141364"), "A Placa Gráfica Nvidia Quadro P400 combina a mais recente arquitetura NVIDIA Quadro Pascal GPU com 2GB de ultra-rápido de memória on-board para entregar ótimo desempenho para uma gama de aplicações profissionais. Um fator de forma de baixo perfil e slot único torna-o compatível até com o chassi com mais espaço e com menor consumo de energia. O suporte para três monitores 4K (4096 x 2160 a 60Hz) com cores HDR oferece um amplo espaço de trabalho visual para visualizar seu trabalho em resolução extremamente alta.", 8u, new Guid("f653713b-90ca-45dc-aeb1-41713c17c8c6"), new Guid("ae606c8c-b979-412e-aa90-5725eb6e45a2"), "~/img/Produtos/1.jpg", "Placa Gráfica Nvidia Quadro P400 2gb Gddr5 64bits - Pny Vcqp400v2-pb", 1223m },
                    { new Guid("4cfe9401-8ce9-41c4-a546-75519bb08f5f"), "O novíssimo GALAX Serious Gaming Edition está equipado com 1-Clip Booster, que pode ser instalado na placa traseira e é a precisão e qualidade que ganham. Quando o ventilador está na parte de trás, a placa de circuito impresso é na verdade muito mais curta do que o cooler e a chave é permitir que o ar flua o mais facilmente possível, portanto, o GALAX construiu orifícios maiores que permitem que o ar flua para cumprir o primeiro requisito. Além disso, a vantagem de adicionar uma ventoinha na placa traseira, o design da ventoinha auxiliar de 1 clipe suga o ar em vez de soprar o ar para dentro, criando efeitos de resfriamento push-pull tecnicamente corretos. Quando esta ventoinha adicional é usada, ela pode obter um melhor desempenho como se uma GPU funcionasse com uma placa traseira normal.", 10u, new Guid("f653713b-90ca-45dc-aeb1-41713c17c8c6"), new Guid("ae606c8c-b979-412e-aa90-5725eb6e45a2"), "~/img/Produtos/2.jpg", "Placa De Vídeo Galax GeForce RTX 3070 Ti SG 1-Click 8gb GDRR6X 256bits 37ISM6MD4BSG", 7936m },
                    { new Guid("eb8f5e6e-e6d2-467e-aaa0-fd857751ba97"), "Potência e desempenho em uma Solução Compacta. A NVIDIA T1000, desenvolvida com base na arquitetura de GPU NVIDIA Turing, é uma solução poderosa e discreta que oferece excelentes recursos e desempenho exigidos por intensos aplicativos profissionais em uma placa gráfica de formato compacto. Com 896 CUDA Cores e 4 GB de memória GDDR6, a T1000 permite que os profissionais lidem com vários fluxos de trabalho, desde a modelagem 3D até a edição de vídeo.", 0u, new Guid("f653713b-90ca-45dc-aeb1-41713c17c8c6"), new Guid("ae606c8c-b979-412e-aa90-5725eb6e45a2"), "~/img/Produtos/6.jpg", "Pny Quadro Workstation Server Placa De Video Pny Vcnt1000-pb T1000 4GB DDR6 128bit Dp", 2743m },
                    { new Guid("5c366e87-d0ea-4d81-b99b-3c5d44ec3d5f"), "O G403 HERO tem a versatilidade e o desempenho para atender todos os tipos de jogos e jogadores. Um mouse gamer leve, ergonômico e totalmente projetado para oferecer a precisão que você exige para jogar em alto nível, agora com o SENSOR HERO 25K de última geração.", 16u, new Guid("540d4fa2-e040-4429-b071-f8d9221d54f5"), new Guid("027bc9ab-c8b0-4d69-bf2e-87f61fd20d39"), "~/img/Produtos/3.jpg", "Mouse Gamer Logitech G403 HERO com RGB LIGHTSYNC, 6 Botões Programáveis, Ajuste de Peso e Sensor HERO 25K - 910-005631", 209m },
                    { new Guid("33222658-9910-4977-bea9-51ea2e32ad6e"), "xperimente chamadas de voz, Skype, webinars e muito mais com clareza usando uma conexão USB plug-and-play simples com o headset H390. O microfone rígido do lado esquerdo pode ser colocado na posição mais adequada para capturar melhor sua voz e é móvel podendo ser recolhido para não atrapalhar quando não estiver sendo usado. Os controles integrados no fio do headset permitem controlar o volume ou colocar chamadas em silêncio com facilidade. O arco de cabeça ajustável com fones acolchoados giratórios de couro sintético oferece horas de conforto. E também é fácil de limpar.", 20u, new Guid("540d4fa2-e040-4429-b071-f8d9221d54f5"), new Guid("027bc9ab-c8b0-4d69-bf2e-87f61fd20d39"), "~/img/Produtos/4.jpg", "Headset com fio USB Logitech H390 com Almofadas em Couro, Controles de Áudio Integrado e Microfone com Redução de Ruído - 981-000014", 179m },
                    { new Guid("66cd6a62-2870-4034-a0cf-88d28f11d8f8"), "O G305 apresenta o sensor HERO de última geração com sensibilidade de 200 a 12.000 DPI para precisão de nível de competição. A tecnologia sem fio LIGHTSPEED oferece desempenho super rápido de 1ms. Com incrível eficiência de energia, o G305 permanece ligado e pronto para jogar por até 250 horas com uma única pilha AA inclusa.", 1u, new Guid("540d4fa2-e040-4429-b071-f8d9221d54f5"), new Guid("027bc9ab-c8b0-4d69-bf2e-87f61fd20d39"), "~/img/Produtos/5.jpg", "Mouse Gamer Sem Fio Logitech G305 Lightspeed, 12.000 DPI, 6 Botões Programáveis, Branco - 910-005290", 349m },
                    { new Guid("a03b39e2-975b-4f03-ad70-da3fdac97d3a"), "O Smartphone Moto E7 conta com sensor de câmera de 48MP que deixam as fotos sempre claras e nítidas, em qualquer iluminação. A tecnologia que o acompanha, Quad Pixel, proporciona 4 vezes mais sensibilidade a luz, para que os resultados fiquem ótimos em qualquer ambiente.", 20u, new Guid("d492710f-6925-4d3f-bafc-2314e0b7f7fc"), new Guid("828652a6-5eff-422f-875c-a4ed654c1569"), "~/img/Produtos/7.jpg", "Smartphone Motorola Moto E7, 64GB, RAM 4GB, Octa-Core, Câmera 48MP, 4000mAh, Cinza Metálico - PALV0031BR", 892m },
                    { new Guid("523abaf2-7b34-48fe-8bca-03e7008a7819"), "Com recursos de ponta como TR-069 e interface web amigável que possibilita a criação de uma firmware personalizável, o DIR-842 é perfeito para provedores de internet que desejam implementar uma solução Wi-Fi de alta qualidade com a possibilidade de personalizar diversos dispositivos ao mesmo tempo. ", 10u, new Guid("ea1ad97f-5771-47d9-bde4-731c5f94c3d3"), new Guid("e6a5a354-f429-4670-a0a1-bcb74c1f0931"), "~/img/Produtos/8.jpg", "Roteador Wireless D-Link Gigabit-Ethernet AC 1200Mbps, Dual Band, 4 Antenas - DIR-842", 164m }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "5a10e121-a8e0-4c61-87e0-51d23ccf7ba5", "5a10e121-a8e0-4c61-87e0-51d23ccf7ba5" });

            migrationBuilder.AddForeignKey(
                name: "FK_Pedido_Cliente_IdCliente",
                table: "Pedido",
                column: "IdCliente",
                principalTable: "Cliente",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pedido_Cliente_IdCliente",
                table: "Pedido");

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: new Guid("625a4099-3797-4d50-92bf-8dd01b449e17"));

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: new Guid("ddb14a86-abd5-4dcd-99e5-811b0b38bcc6"));

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("07450ee1-9439-459b-8972-e21abe141364"));

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("33222658-9910-4977-bea9-51ea2e32ad6e"));

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("4cfe9401-8ce9-41c4-a546-75519bb08f5f"));

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("523abaf2-7b34-48fe-8bca-03e7008a7819"));

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("5c366e87-d0ea-4d81-b99b-3c5d44ec3d5f"));

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("66cd6a62-2870-4034-a0cf-88d28f11d8f8"));

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("a03b39e2-975b-4f03-ad70-da3fdac97d3a"));

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("eb8f5e6e-e6d2-467e-aaa0-fd857751ba97"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "175172d3-1db3-4e97-9ea0-390ca00c7e7f");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "5ca34725-a638-45c3-8226-d846a807c281");

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5a10e121-a8e0-4c61-87e0-51d23ccf7ba5", "5a10e121-a8e0-4c61-87e0-51d23ccf7ba5" });

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: new Guid("540d4fa2-e040-4429-b071-f8d9221d54f5"));

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: new Guid("d492710f-6925-4d3f-bafc-2314e0b7f7fc"));

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: new Guid("ea1ad97f-5771-47d9-bde4-731c5f94c3d3"));

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: new Guid("f653713b-90ca-45dc-aeb1-41713c17c8c6"));

            migrationBuilder.DeleteData(
                table: "Marca",
                keyColumn: "Id",
                keyValue: new Guid("027bc9ab-c8b0-4d69-bf2e-87f61fd20d39"));

            migrationBuilder.DeleteData(
                table: "Marca",
                keyColumn: "Id",
                keyValue: new Guid("828652a6-5eff-422f-875c-a4ed654c1569"));

            migrationBuilder.DeleteData(
                table: "Marca",
                keyColumn: "Id",
                keyValue: new Guid("ae606c8c-b979-412e-aa90-5725eb6e45a2"));

            migrationBuilder.DeleteData(
                table: "Marca",
                keyColumn: "Id",
                keyValue: new Guid("e6a5a354-f429-4670-a0a1-bcb74c1f0931"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "5a10e121-a8e0-4c61-87e0-51d23ccf7ba5");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "5a10e121-a8e0-4c61-87e0-51d23ccf7ba5");

            migrationBuilder.AlterColumn<string>(
                name: "IdCliente",
                table: "Pedido",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Pedido_Cliente_IdCliente",
                table: "Pedido",
                column: "IdCliente",
                principalTable: "Cliente",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
