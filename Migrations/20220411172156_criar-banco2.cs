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
                keyValue: new Guid("12888754-543b-4700-a461-d6653bb26a12"));

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: new Guid("d31fdded-3296-4d96-b8c2-379abd078c6d"));

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("1ce9fb9d-5236-4d33-ad70-5ca3e3967b65"));

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("650f2e8e-f032-499b-bb0d-61f855b93c48"));

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("a19b86eb-bc58-40cc-9ed5-65d2eb3db7cd"));

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("ab1f264a-3089-4653-89d1-712110db44cf"));

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("b093f3f8-4635-4ab8-a2f0-e1e5e9911485"));

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("b8075d1b-1751-4bed-aa50-871a26321ccb"));

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("c100c064-5b25-4cf1-99e2-1ab2ba7d8474"));

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("f5ccab0d-938b-4bf1-aedc-16cdd825c523"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "0154c802-6f00-494a-88c5-65a2380d2b57");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "12a83034-394b-4b9b-abaa-e31ca32b53b8");

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d599e847-03c0-40a5-8007-14c4f8b75712", "d599e847-03c0-40a5-8007-14c4f8b75712" });

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: new Guid("3b5cfb7a-757b-4883-b5fa-4d64c47d0437"));

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: new Guid("5865914d-4215-4e74-94ad-7066db399937"));

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: new Guid("a12c9772-1066-4034-821a-42297bd3e500"));

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: new Guid("bc63f413-a8a2-47b7-87a4-fc5c793bd4e5"));

            migrationBuilder.DeleteData(
                table: "Marca",
                keyColumn: "Id",
                keyValue: new Guid("2ecc0444-5009-4b67-ac4b-5429978e229e"));

            migrationBuilder.DeleteData(
                table: "Marca",
                keyColumn: "Id",
                keyValue: new Guid("37ac0299-d064-4485-9fe1-7b9797ac0d8d"));

            migrationBuilder.DeleteData(
                table: "Marca",
                keyColumn: "Id",
                keyValue: new Guid("3d6102b1-bc05-4b80-ac70-66857fb960fc"));

            migrationBuilder.DeleteData(
                table: "Marca",
                keyColumn: "Id",
                keyValue: new Guid("85ae9003-4672-4ca4-b596-5828cea72c17"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "d599e847-03c0-40a5-8007-14c4f8b75712");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "d599e847-03c0-40a5-8007-14c4f8b75712");

            migrationBuilder.AddColumn<string>(
                name: "IdCarrinho",
                table: "Pedido",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Categoria",
                columns: new[] { "Id", "Imagem", "Nome" },
                values: new object[,]
                {
                    { new Guid("d4b7d5ae-1fcb-4486-a39c-c0e3e7427a7c"), "~/img/Produtos/001.png", "Hardware" },
                    { new Guid("0dda230a-2db4-479c-8ba9-c10d60147181"), "~/img/Produtos/002.png", "Celulares" },
                    { new Guid("02adc493-a462-4bd6-8a23-4a897f91fda9"), "~/img/Produtos/003.png", "Periféricos" },
                    { new Guid("09d70408-f4d0-4910-97d7-93b6ba708340"), "~/img/Produtos/004.png", "Games" },
                    { new Guid("7e73f085-9dbd-45f3-bff8-0efdd159d7bd"), "~/img/Produtos/005.png", "Cadeiras" },
                    { new Guid("0e602c76-02cf-48ef-a3f4-e1a0eda17164"), "~/img/Produtos/006.png", "Conectividade" }
                });

            migrationBuilder.InsertData(
                table: "Marca",
                columns: new[] { "Id", "Nome" },
                values: new object[,]
                {
                    { new Guid("79b6f43b-6035-4a98-9e4f-be6a03ab8d2f"), "Nvidia" },
                    { new Guid("67738e5e-a8fc-4f75-bdad-3e3fab53a52a"), "Logitech" },
                    { new Guid("965f5cdc-ab02-4ba7-a4fc-b0fa0085f827"), "Motorola" },
                    { new Guid("527c7a45-b652-46a6-8045-2552e85b88bb"), "D-Link" }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "10f9ab9b-f146-4e99-b754-b367f0e17010", "e7cede79-179a-4c5f-ae70-5c261e77af68", "Administrador", "ADMINISTRADOR" },
                    { "ee02aedf-9bbb-4caf-baf0-79da36de9923", "81a3a876-4ca4-4d93-ab04-fdf5a98e1cac", "Moderador", "MODERADOR" },
                    { "36f46e8e-fae7-464a-bd7b-db088e16ac53", "58a5048e-bc2f-4ac5-a6c9-dfe3e820bc3b", "Usuario", "USUARIO" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NomeCompleto", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "10f9ab9b-f146-4e99-b754-b367f0e17010", 0, "82f2a1ab-db5d-47e0-af81-ae9d640f6729", "admin@ecommerce.com.br", true, false, null, "Igor Oliveira de Lima", "ADMIN@ECOMMERCE.COM.BR", "ADMIN", "AQAAAAEAACcQAAAAEFnbZwn0SuaSA2b4lfM9bMi2I+sH9R2JPporiPmbxv+0wXeQQLI0fbU517KR7jZ/0A==", null, false, "55725192", false, "Admin" });

            migrationBuilder.InsertData(
                table: "Produto",
                columns: new[] { "Id", "Descricao", "Estoque", "IdCategoria", "IdMarca", "Imagem", "Nome", "Valor" },
                values: new object[,]
                {
                    { new Guid("f429a7c9-08ff-4773-a2f8-6a2903015020"), "A Placa Gráfica Nvidia Quadro P400 combina a mais recente arquitetura NVIDIA Quadro Pascal GPU com 2GB de ultra-rápido de memória on-board para entregar ótimo desempenho para uma gama de aplicações profissionais. Um fator de forma de baixo perfil e slot único torna-o compatível até com o chassi com mais espaço e com menor consumo de energia. O suporte para três monitores 4K (4096 x 2160 a 60Hz) com cores HDR oferece um amplo espaço de trabalho visual para visualizar seu trabalho em resolução extremamente alta.", 8u, new Guid("d4b7d5ae-1fcb-4486-a39c-c0e3e7427a7c"), new Guid("79b6f43b-6035-4a98-9e4f-be6a03ab8d2f"), "~/img/Produtos/1.jpg", "Placa Gráfica Nvidia Quadro P400 2gb Gddr5 64bits - Pny Vcqp400v2-pb", 1223.99m },
                    { new Guid("476ff73f-7223-4212-8cec-7f1548fc96f5"), "O novíssimo GALAX Serious Gaming Edition está equipado com 1-Clip Booster, que pode ser instalado na placa traseira e é a precisão e qualidade que ganham. Quando o ventilador está na parte de trás, a placa de circuito impresso é na verdade muito mais curta do que o cooler e a chave é permitir que o ar flua o mais facilmente possível, portanto, o GALAX construiu orifícios maiores que permitem que o ar flua para cumprir o primeiro requisito. Além disso, a vantagem de adicionar uma ventoinha na placa traseira, o design da ventoinha auxiliar de 1 clipe suga o ar em vez de soprar o ar para dentro, criando efeitos de resfriamento push-pull tecnicamente corretos. Quando esta ventoinha adicional é usada, ela pode obter um melhor desempenho como se uma GPU funcionasse com uma placa traseira normal.", 10u, new Guid("d4b7d5ae-1fcb-4486-a39c-c0e3e7427a7c"), new Guid("79b6f43b-6035-4a98-9e4f-be6a03ab8d2f"), "~/img/Produtos/2.jpg", "Placa De Vídeo Galax GeForce RTX 3070 Ti SG 1-Click 8gb GDRR6X 256bits 37ISM6MD4BSG", 7936m },
                    { new Guid("f06245cf-91cb-4520-b473-0b2b05857acc"), "Potência e desempenho em uma Solução Compacta. A NVIDIA T1000, desenvolvida com base na arquitetura de GPU NVIDIA Turing, é uma solução poderosa e discreta que oferece excelentes recursos e desempenho exigidos por intensos aplicativos profissionais em uma placa gráfica de formato compacto. Com 896 CUDA Cores e 4 GB de memória GDDR6, a T1000 permite que os profissionais lidem com vários fluxos de trabalho, desde a modelagem 3D até a edição de vídeo.", 0u, new Guid("d4b7d5ae-1fcb-4486-a39c-c0e3e7427a7c"), new Guid("79b6f43b-6035-4a98-9e4f-be6a03ab8d2f"), "~/img/Produtos/6.jpg", "Pny Quadro Workstation Server Placa De Video Pny Vcnt1000-pb T1000 4GB DDR6 128bit Dp", 2743.98m },
                    { new Guid("c83ee0fe-52dd-40e5-b128-a5c90509bd04"), "O G403 HERO tem a versatilidade e o desempenho para atender todos os tipos de jogos e jogadores. Um mouse gamer leve, ergonômico e totalmente projetado para oferecer a precisão que você exige para jogar em alto nível, agora com o SENSOR HERO 25K de última geração.", 16u, new Guid("02adc493-a462-4bd6-8a23-4a897f91fda9"), new Guid("67738e5e-a8fc-4f75-bdad-3e3fab53a52a"), "~/img/Produtos/3.jpg", "Mouse Gamer Logitech G403 HERO com RGB LIGHTSYNC, 6 Botões Programáveis, Ajuste de Peso e Sensor HERO 25K - 910-005631", 209m },
                    { new Guid("354e8533-8de5-4e74-9190-e4ada7394f19"), "xperimente chamadas de voz, Skype, webinars e muito mais com clareza usando uma conexão USB plug-and-play simples com o headset H390. O microfone rígido do lado esquerdo pode ser colocado na posição mais adequada para capturar melhor sua voz e é móvel podendo ser recolhido para não atrapalhar quando não estiver sendo usado. Os controles integrados no fio do headset permitem controlar o volume ou colocar chamadas em silêncio com facilidade. O arco de cabeça ajustável com fones acolchoados giratórios de couro sintético oferece horas de conforto. E também é fácil de limpar.", 20u, new Guid("02adc493-a462-4bd6-8a23-4a897f91fda9"), new Guid("67738e5e-a8fc-4f75-bdad-3e3fab53a52a"), "~/img/Produtos/4.jpg", "Headset com fio USB Logitech H390 com Almofadas em Couro, Controles de Áudio Integrado e Microfone com Redução de Ruído - 981-000014", 179.99m },
                    { new Guid("765a9146-f646-4aa6-85ce-aecca37515c0"), "O G305 apresenta o sensor HERO de última geração com sensibilidade de 200 a 12.000 DPI para precisão de nível de competição. A tecnologia sem fio LIGHTSPEED oferece desempenho super rápido de 1ms. Com incrível eficiência de energia, o G305 permanece ligado e pronto para jogar por até 250 horas com uma única pilha AA inclusa.", 1u, new Guid("02adc493-a462-4bd6-8a23-4a897f91fda9"), new Guid("67738e5e-a8fc-4f75-bdad-3e3fab53a52a"), "~/img/Produtos/5.jpg", "Mouse Gamer Sem Fio Logitech G305 Lightspeed, 12.000 DPI, 6 Botões Programáveis, Branco - 910-005290", 349.9m },
                    { new Guid("5e6c1a13-058d-402d-b210-c98702c8f8e2"), "O Smartphone Moto E7 conta com sensor de câmera de 48MP que deixam as fotos sempre claras e nítidas, em qualquer iluminação. A tecnologia que o acompanha, Quad Pixel, proporciona 4 vezes mais sensibilidade a luz, para que os resultados fiquem ótimos em qualquer ambiente.", 20u, new Guid("0dda230a-2db4-479c-8ba9-c10d60147181"), new Guid("965f5cdc-ab02-4ba7-a4fc-b0fa0085f827"), "~/img/Produtos/7.jpg", "Smartphone Motorola Moto E7, 64GB, RAM 4GB, Octa-Core, Câmera 48MP, 4000mAh, Cinza Metálico - PALV0031BR", 892.05m },
                    { new Guid("9a2bfd54-01e2-4163-bb98-fb609275c030"), "Com recursos de ponta como TR-069 e interface web amigável que possibilita a criação de uma firmware personalizável, o DIR-842 é perfeito para provedores de internet que desejam implementar uma solução Wi-Fi de alta qualidade com a possibilidade de personalizar diversos dispositivos ao mesmo tempo. ", 10u, new Guid("0e602c76-02cf-48ef-a3f4-e1a0eda17164"), new Guid("527c7a45-b652-46a6-8045-2552e85b88bb"), "~/img/Produtos/8.jpg", "Roteador Wireless D-Link Gigabit-Ethernet AC 1200Mbps, Dual Band, 4 Antenas - DIR-842", 164.9m }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "10f9ab9b-f146-4e99-b754-b367f0e17010", "10f9ab9b-f146-4e99-b754-b367f0e17010" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: new Guid("09d70408-f4d0-4910-97d7-93b6ba708340"));

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: new Guid("7e73f085-9dbd-45f3-bff8-0efdd159d7bd"));

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("354e8533-8de5-4e74-9190-e4ada7394f19"));

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("476ff73f-7223-4212-8cec-7f1548fc96f5"));

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("5e6c1a13-058d-402d-b210-c98702c8f8e2"));

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("765a9146-f646-4aa6-85ce-aecca37515c0"));

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("9a2bfd54-01e2-4163-bb98-fb609275c030"));

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("c83ee0fe-52dd-40e5-b128-a5c90509bd04"));

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("f06245cf-91cb-4520-b473-0b2b05857acc"));

            migrationBuilder.DeleteData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: new Guid("f429a7c9-08ff-4773-a2f8-6a2903015020"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "36f46e8e-fae7-464a-bd7b-db088e16ac53");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "ee02aedf-9bbb-4caf-baf0-79da36de9923");

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "10f9ab9b-f146-4e99-b754-b367f0e17010", "10f9ab9b-f146-4e99-b754-b367f0e17010" });

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: new Guid("02adc493-a462-4bd6-8a23-4a897f91fda9"));

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: new Guid("0dda230a-2db4-479c-8ba9-c10d60147181"));

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: new Guid("0e602c76-02cf-48ef-a3f4-e1a0eda17164"));

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: new Guid("d4b7d5ae-1fcb-4486-a39c-c0e3e7427a7c"));

            migrationBuilder.DeleteData(
                table: "Marca",
                keyColumn: "Id",
                keyValue: new Guid("527c7a45-b652-46a6-8045-2552e85b88bb"));

            migrationBuilder.DeleteData(
                table: "Marca",
                keyColumn: "Id",
                keyValue: new Guid("67738e5e-a8fc-4f75-bdad-3e3fab53a52a"));

            migrationBuilder.DeleteData(
                table: "Marca",
                keyColumn: "Id",
                keyValue: new Guid("79b6f43b-6035-4a98-9e4f-be6a03ab8d2f"));

            migrationBuilder.DeleteData(
                table: "Marca",
                keyColumn: "Id",
                keyValue: new Guid("965f5cdc-ab02-4ba7-a4fc-b0fa0085f827"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "10f9ab9b-f146-4e99-b754-b367f0e17010");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "10f9ab9b-f146-4e99-b754-b367f0e17010");

            migrationBuilder.DropColumn(
                name: "IdCarrinho",
                table: "Pedido");

            migrationBuilder.InsertData(
                table: "Categoria",
                columns: new[] { "Id", "Imagem", "Nome" },
                values: new object[,]
                {
                    { new Guid("bc63f413-a8a2-47b7-87a4-fc5c793bd4e5"), "~/img/Produtos/001.png", "Hardware" },
                    { new Guid("5865914d-4215-4e74-94ad-7066db399937"), "~/img/Produtos/002.png", "Celulares" },
                    { new Guid("a12c9772-1066-4034-821a-42297bd3e500"), "~/img/Produtos/003.png", "Periféricos" },
                    { new Guid("d31fdded-3296-4d96-b8c2-379abd078c6d"), "~/img/Produtos/004.png", "Games" },
                    { new Guid("12888754-543b-4700-a461-d6653bb26a12"), "~/img/Produtos/005.png", "Cadeiras" },
                    { new Guid("3b5cfb7a-757b-4883-b5fa-4d64c47d0437"), "~/img/Produtos/006.png", "Conectividade" }
                });

            migrationBuilder.InsertData(
                table: "Marca",
                columns: new[] { "Id", "Nome" },
                values: new object[,]
                {
                    { new Guid("3d6102b1-bc05-4b80-ac70-66857fb960fc"), "Nvidia" },
                    { new Guid("2ecc0444-5009-4b67-ac4b-5429978e229e"), "Logitech" },
                    { new Guid("37ac0299-d064-4485-9fe1-7b9797ac0d8d"), "Motorola" },
                    { new Guid("85ae9003-4672-4ca4-b596-5828cea72c17"), "D-Link" }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "d599e847-03c0-40a5-8007-14c4f8b75712", "d2a6428e-4872-42d8-b236-2371e3781f5b", "Administrador", "ADMINISTRADOR" },
                    { "12a83034-394b-4b9b-abaa-e31ca32b53b8", "f18fe04d-cb58-4c5b-a235-216600f7f7b6", "Moderador", "MODERADOR" },
                    { "0154c802-6f00-494a-88c5-65a2380d2b57", "fd53a393-0775-4d39-a0a8-6d6c7c94d26b", "Usuario", "USUARIO" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NomeCompleto", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "d599e847-03c0-40a5-8007-14c4f8b75712", 0, "eade69cc-d91d-4adf-ad63-ba7dd7cc33d0", "admin@ecommerce.com.br", true, false, null, "Igor Oliveira de Lima", "ADMIN@ECOMMERCE.COM.BR", "ADMIN", "AQAAAAEAACcQAAAAEKkbRLSC75vc1t+2Z00NFtDutUeBS+ruBxsSAfDVQ+E6+E5vluOSzu3hGBAqDAnmsw==", null, false, "50930930", false, "Admin" });

            migrationBuilder.InsertData(
                table: "Produto",
                columns: new[] { "Id", "Descricao", "Estoque", "IdCategoria", "IdMarca", "Imagem", "Nome", "Valor" },
                values: new object[,]
                {
                    { new Guid("c100c064-5b25-4cf1-99e2-1ab2ba7d8474"), "A Placa Gráfica Nvidia Quadro P400 combina a mais recente arquitetura NVIDIA Quadro Pascal GPU com 2GB de ultra-rápido de memória on-board para entregar ótimo desempenho para uma gama de aplicações profissionais. Um fator de forma de baixo perfil e slot único torna-o compatível até com o chassi com mais espaço e com menor consumo de energia. O suporte para três monitores 4K (4096 x 2160 a 60Hz) com cores HDR oferece um amplo espaço de trabalho visual para visualizar seu trabalho em resolução extremamente alta.", 8u, new Guid("bc63f413-a8a2-47b7-87a4-fc5c793bd4e5"), new Guid("3d6102b1-bc05-4b80-ac70-66857fb960fc"), "~/img/Produtos/1.jpg", "Placa Gráfica Nvidia Quadro P400 2gb Gddr5 64bits - Pny Vcqp400v2-pb", 1223.99m },
                    { new Guid("ab1f264a-3089-4653-89d1-712110db44cf"), "O novíssimo GALAX Serious Gaming Edition está equipado com 1-Clip Booster, que pode ser instalado na placa traseira e é a precisão e qualidade que ganham. Quando o ventilador está na parte de trás, a placa de circuito impresso é na verdade muito mais curta do que o cooler e a chave é permitir que o ar flua o mais facilmente possível, portanto, o GALAX construiu orifícios maiores que permitem que o ar flua para cumprir o primeiro requisito. Além disso, a vantagem de adicionar uma ventoinha na placa traseira, o design da ventoinha auxiliar de 1 clipe suga o ar em vez de soprar o ar para dentro, criando efeitos de resfriamento push-pull tecnicamente corretos. Quando esta ventoinha adicional é usada, ela pode obter um melhor desempenho como se uma GPU funcionasse com uma placa traseira normal.", 10u, new Guid("bc63f413-a8a2-47b7-87a4-fc5c793bd4e5"), new Guid("3d6102b1-bc05-4b80-ac70-66857fb960fc"), "~/img/Produtos/2.jpg", "Placa De Vídeo Galax GeForce RTX 3070 Ti SG 1-Click 8gb GDRR6X 256bits 37ISM6MD4BSG", 7936m },
                    { new Guid("650f2e8e-f032-499b-bb0d-61f855b93c48"), "Potência e desempenho em uma Solução Compacta. A NVIDIA T1000, desenvolvida com base na arquitetura de GPU NVIDIA Turing, é uma solução poderosa e discreta que oferece excelentes recursos e desempenho exigidos por intensos aplicativos profissionais em uma placa gráfica de formato compacto. Com 896 CUDA Cores e 4 GB de memória GDDR6, a T1000 permite que os profissionais lidem com vários fluxos de trabalho, desde a modelagem 3D até a edição de vídeo.", 0u, new Guid("bc63f413-a8a2-47b7-87a4-fc5c793bd4e5"), new Guid("3d6102b1-bc05-4b80-ac70-66857fb960fc"), "~/img/Produtos/6.jpg", "Pny Quadro Workstation Server Placa De Video Pny Vcnt1000-pb T1000 4GB DDR6 128bit Dp", 2743.98m },
                    { new Guid("b8075d1b-1751-4bed-aa50-871a26321ccb"), "O G403 HERO tem a versatilidade e o desempenho para atender todos os tipos de jogos e jogadores. Um mouse gamer leve, ergonômico e totalmente projetado para oferecer a precisão que você exige para jogar em alto nível, agora com o SENSOR HERO 25K de última geração.", 16u, new Guid("a12c9772-1066-4034-821a-42297bd3e500"), new Guid("2ecc0444-5009-4b67-ac4b-5429978e229e"), "~/img/Produtos/3.jpg", "Mouse Gamer Logitech G403 HERO com RGB LIGHTSYNC, 6 Botões Programáveis, Ajuste de Peso e Sensor HERO 25K - 910-005631", 209m },
                    { new Guid("a19b86eb-bc58-40cc-9ed5-65d2eb3db7cd"), "xperimente chamadas de voz, Skype, webinars e muito mais com clareza usando uma conexão USB plug-and-play simples com o headset H390. O microfone rígido do lado esquerdo pode ser colocado na posição mais adequada para capturar melhor sua voz e é móvel podendo ser recolhido para não atrapalhar quando não estiver sendo usado. Os controles integrados no fio do headset permitem controlar o volume ou colocar chamadas em silêncio com facilidade. O arco de cabeça ajustável com fones acolchoados giratórios de couro sintético oferece horas de conforto. E também é fácil de limpar.", 20u, new Guid("a12c9772-1066-4034-821a-42297bd3e500"), new Guid("2ecc0444-5009-4b67-ac4b-5429978e229e"), "~/img/Produtos/4.jpg", "Headset com fio USB Logitech H390 com Almofadas em Couro, Controles de Áudio Integrado e Microfone com Redução de Ruído - 981-000014", 179.99m },
                    { new Guid("1ce9fb9d-5236-4d33-ad70-5ca3e3967b65"), "O G305 apresenta o sensor HERO de última geração com sensibilidade de 200 a 12.000 DPI para precisão de nível de competição. A tecnologia sem fio LIGHTSPEED oferece desempenho super rápido de 1ms. Com incrível eficiência de energia, o G305 permanece ligado e pronto para jogar por até 250 horas com uma única pilha AA inclusa.", 1u, new Guid("a12c9772-1066-4034-821a-42297bd3e500"), new Guid("2ecc0444-5009-4b67-ac4b-5429978e229e"), "~/img/Produtos/5.jpg", "Mouse Gamer Sem Fio Logitech G305 Lightspeed, 12.000 DPI, 6 Botões Programáveis, Branco - 910-005290", 349.9m },
                    { new Guid("b093f3f8-4635-4ab8-a2f0-e1e5e9911485"), "O Smartphone Moto E7 conta com sensor de câmera de 48MP que deixam as fotos sempre claras e nítidas, em qualquer iluminação. A tecnologia que o acompanha, Quad Pixel, proporciona 4 vezes mais sensibilidade a luz, para que os resultados fiquem ótimos em qualquer ambiente.", 20u, new Guid("5865914d-4215-4e74-94ad-7066db399937"), new Guid("37ac0299-d064-4485-9fe1-7b9797ac0d8d"), "~/img/Produtos/7.jpg", "Smartphone Motorola Moto E7, 64GB, RAM 4GB, Octa-Core, Câmera 48MP, 4000mAh, Cinza Metálico - PALV0031BR", 892.05m },
                    { new Guid("f5ccab0d-938b-4bf1-aedc-16cdd825c523"), "Com recursos de ponta como TR-069 e interface web amigável que possibilita a criação de uma firmware personalizável, o DIR-842 é perfeito para provedores de internet que desejam implementar uma solução Wi-Fi de alta qualidade com a possibilidade de personalizar diversos dispositivos ao mesmo tempo. ", 10u, new Guid("3b5cfb7a-757b-4883-b5fa-4d64c47d0437"), new Guid("85ae9003-4672-4ca4-b596-5828cea72c17"), "~/img/Produtos/8.jpg", "Roteador Wireless D-Link Gigabit-Ethernet AC 1200Mbps, Dual Band, 4 Antenas - DIR-842", 164.9m }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "d599e847-03c0-40a5-8007-14c4f8b75712", "d599e847-03c0-40a5-8007-14c4f8b75712" });
        }
    }
}
