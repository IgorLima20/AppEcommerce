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
                keyValue: new Guid("0094edaf-44d0-482e-a08a-94d9e4436166"));

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: new Guid("3858c818-0980-4ebf-b393-e486b3f9e1b8"));

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: new Guid("38c96576-73f3-482b-84c4-9b63ee79a346"));

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: new Guid("7dbe530c-2fcd-48df-8ffc-659d3f641780"));

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: new Guid("aefb144e-362f-4ccb-a525-d61cb0a4a2fc"));

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: new Guid("d3854c99-07ef-4d23-ae6f-245895c45813"));

            migrationBuilder.DeleteData(
                table: "Marca",
                keyColumn: "Id",
                keyValue: new Guid("33479939-adfd-423d-b033-4bfbb1fb65b8"));

            migrationBuilder.DeleteData(
                table: "Marca",
                keyColumn: "Id",
                keyValue: new Guid("38552366-f623-4328-b3c4-7e77f604ac88"));

            migrationBuilder.DeleteData(
                table: "Marca",
                keyColumn: "Id",
                keyValue: new Guid("5cccd0d9-47be-4429-aca3-f5d8d94d0435"));

            migrationBuilder.DeleteData(
                table: "Marca",
                keyColumn: "Id",
                keyValue: new Guid("9bfeab4c-ad56-4f38-91cf-59bcfa18cd61"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "72c921a4-1454-47fb-bb93-9532f67db469");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "b82120a9-55c4-4887-b6e4-45dfd453d984");

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "acdb899c-63d4-43aa-ad29-3923c3eba6d7", "acdb899c-63d4-43aa-ad29-3923c3eba6d7" });

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "acdb899c-63d4-43aa-ad29-3923c3eba6d7");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "acdb899c-63d4-43aa-ad29-3923c3eba6d7");

            migrationBuilder.AddColumn<string>(
                name: "Imagem",
                table: "Marca",
                type: "varchar(200)",
                maxLength: 200,
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Categoria",
                columns: new[] { "Id", "Imagem", "Nome" },
                values: new object[,]
                {
                    { new Guid("acf2672d-2ffc-4e3b-a96f-baa0ad7b88aa"), "~/img/Produtos/001.png", "Hardware" },
                    { new Guid("491998c1-9c28-47b8-ad08-b7b16005f1e2"), "~/img/Produtos/002.png", "Celulares" },
                    { new Guid("0f0b9024-f03a-4c05-93bf-ab732f36172b"), "~/img/Produtos/003.png", "Periféricos" },
                    { new Guid("63773f54-dacd-4913-b43c-3c4c1eb75f8d"), "~/img/Produtos/004.png", "Games" },
                    { new Guid("1b068617-b93b-4cbe-8323-de449b4833a7"), "~/img/Produtos/005.png", "Cadeiras" },
                    { new Guid("6017706d-0f4b-41ec-8423-76cb974a8044"), "~/img/Produtos/006.png", "Conectividade" }
                });

            migrationBuilder.InsertData(
                table: "Marca",
                columns: new[] { "Id", "Imagem", "Nome" },
                values: new object[,]
                {
                    { new Guid("521947cf-c707-4b63-ae22-8432556191b6"), null, "Nvidia" },
                    { new Guid("0b326bb2-8ea7-4141-bf6f-c6c79b953eff"), null, "Logitech" },
                    { new Guid("064cbd41-19f7-4792-8931-b0f23bab435c"), null, "Motorola" },
                    { new Guid("4e40f27a-9e21-4bd9-b488-3fe2bfd349d8"), null, "D-Link" }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2982a81e-78fc-40a1-b920-b70353ffd012", "86b68d35-0895-436a-a780-57348790788e", "Administrador", "ADMINISTRADOR" },
                    { "15611437-18c5-4975-b7b8-441d85e500b3", "2bf72526-aefc-4909-850b-41be047b9924", "Moderador", "MODERADOR" },
                    { "a399dc95-efe6-4c31-9717-651510b902fd", "c61c11bc-6d17-4021-90fa-50b775151c3e", "Usuario", "USUARIO" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NomeCompleto", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "2982a81e-78fc-40a1-b920-b70353ffd012", 0, "e26a8cf2-4d40-49af-b04c-62b0a70dafb6", "igorsax258@gmail.com", true, false, null, "Igor Oliveira de Lima", "IGORSAX258@GMAIL.COM", "ADMIN", "AQAAAAEAACcQAAAAEIU+IqPc74Hag8HPMIEy50o9fO9dxeytR+ElnIc15OOjvdW0eB7zJ9RIpRe+4hYG6w==", null, false, "23387474", false, "Admin" });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "IdCategoria", "IdMarca" },
                values: new object[] { new Guid("acf2672d-2ffc-4e3b-a96f-baa0ad7b88aa"), new Guid("521947cf-c707-4b63-ae22-8432556191b6") });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "IdCategoria", "IdMarca" },
                values: new object[] { new Guid("acf2672d-2ffc-4e3b-a96f-baa0ad7b88aa"), new Guid("521947cf-c707-4b63-ae22-8432556191b6") });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "IdCategoria", "IdMarca" },
                values: new object[] { new Guid("0f0b9024-f03a-4c05-93bf-ab732f36172b"), new Guid("0b326bb2-8ea7-4141-bf6f-c6c79b953eff") });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "IdCategoria", "IdMarca" },
                values: new object[] { new Guid("0f0b9024-f03a-4c05-93bf-ab732f36172b"), new Guid("0b326bb2-8ea7-4141-bf6f-c6c79b953eff") });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "IdCategoria", "IdMarca" },
                values: new object[] { new Guid("0f0b9024-f03a-4c05-93bf-ab732f36172b"), new Guid("0b326bb2-8ea7-4141-bf6f-c6c79b953eff") });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "IdCategoria", "IdMarca" },
                values: new object[] { new Guid("acf2672d-2ffc-4e3b-a96f-baa0ad7b88aa"), new Guid("521947cf-c707-4b63-ae22-8432556191b6") });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "IdCategoria", "IdMarca" },
                values: new object[] { new Guid("491998c1-9c28-47b8-ad08-b7b16005f1e2"), new Guid("064cbd41-19f7-4792-8931-b0f23bab435c") });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "IdCategoria", "IdMarca" },
                values: new object[] { new Guid("6017706d-0f4b-41ec-8423-76cb974a8044"), new Guid("4e40f27a-9e21-4bd9-b488-3fe2bfd349d8") });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2982a81e-78fc-40a1-b920-b70353ffd012", "2982a81e-78fc-40a1-b920-b70353ffd012" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: new Guid("0f0b9024-f03a-4c05-93bf-ab732f36172b"));

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: new Guid("1b068617-b93b-4cbe-8323-de449b4833a7"));

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: new Guid("491998c1-9c28-47b8-ad08-b7b16005f1e2"));

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: new Guid("6017706d-0f4b-41ec-8423-76cb974a8044"));

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: new Guid("63773f54-dacd-4913-b43c-3c4c1eb75f8d"));

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "Id",
                keyValue: new Guid("acf2672d-2ffc-4e3b-a96f-baa0ad7b88aa"));

            migrationBuilder.DeleteData(
                table: "Marca",
                keyColumn: "Id",
                keyValue: new Guid("064cbd41-19f7-4792-8931-b0f23bab435c"));

            migrationBuilder.DeleteData(
                table: "Marca",
                keyColumn: "Id",
                keyValue: new Guid("0b326bb2-8ea7-4141-bf6f-c6c79b953eff"));

            migrationBuilder.DeleteData(
                table: "Marca",
                keyColumn: "Id",
                keyValue: new Guid("4e40f27a-9e21-4bd9-b488-3fe2bfd349d8"));

            migrationBuilder.DeleteData(
                table: "Marca",
                keyColumn: "Id",
                keyValue: new Guid("521947cf-c707-4b63-ae22-8432556191b6"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "15611437-18c5-4975-b7b8-441d85e500b3");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "a399dc95-efe6-4c31-9717-651510b902fd");

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2982a81e-78fc-40a1-b920-b70353ffd012", "2982a81e-78fc-40a1-b920-b70353ffd012" });

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "2982a81e-78fc-40a1-b920-b70353ffd012");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "2982a81e-78fc-40a1-b920-b70353ffd012");

            migrationBuilder.DropColumn(
                name: "Imagem",
                table: "Marca");

            migrationBuilder.InsertData(
                table: "Categoria",
                columns: new[] { "Id", "Imagem", "Nome" },
                values: new object[,]
                {
                    { new Guid("aefb144e-362f-4ccb-a525-d61cb0a4a2fc"), "~/img/Produtos/001.png", "Hardware" },
                    { new Guid("7dbe530c-2fcd-48df-8ffc-659d3f641780"), "~/img/Produtos/002.png", "Celulares" },
                    { new Guid("38c96576-73f3-482b-84c4-9b63ee79a346"), "~/img/Produtos/003.png", "Periféricos" },
                    { new Guid("0094edaf-44d0-482e-a08a-94d9e4436166"), "~/img/Produtos/004.png", "Games" },
                    { new Guid("d3854c99-07ef-4d23-ae6f-245895c45813"), "~/img/Produtos/005.png", "Cadeiras" },
                    { new Guid("3858c818-0980-4ebf-b393-e486b3f9e1b8"), "~/img/Produtos/006.png", "Conectividade" }
                });

            migrationBuilder.InsertData(
                table: "Marca",
                columns: new[] { "Id", "Nome" },
                values: new object[,]
                {
                    { new Guid("5cccd0d9-47be-4429-aca3-f5d8d94d0435"), "Nvidia" },
                    { new Guid("38552366-f623-4328-b3c4-7e77f604ac88"), "Logitech" },
                    { new Guid("33479939-adfd-423d-b033-4bfbb1fb65b8"), "Motorola" },
                    { new Guid("9bfeab4c-ad56-4f38-91cf-59bcfa18cd61"), "D-Link" }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "acdb899c-63d4-43aa-ad29-3923c3eba6d7", "71385a02-0c9e-449b-b0a4-2e792b7f4eae", "Administrador", "ADMINISTRADOR" },
                    { "72c921a4-1454-47fb-bb93-9532f67db469", "ee32ca64-06e9-4797-8a12-7396aa44d4c3", "Moderador", "MODERADOR" },
                    { "b82120a9-55c4-4887-b6e4-45dfd453d984", "2da88418-d70e-447a-816d-05a2e6608d01", "Usuario", "USUARIO" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NomeCompleto", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "acdb899c-63d4-43aa-ad29-3923c3eba6d7", 0, "a7cc023a-53cb-46ff-b5cf-047b2b4afe72", "igorsax258@gmail.com", true, false, null, "Igor Oliveira de Lima", "IGORSAX258@GMAIL.COM", "ADMIN", "AQAAAAEAACcQAAAAEA4gftfAqcYsdHjVDo7n8A465vYLzlST/OJ/o2qudo+/8EbcPwaz4CUR9Q9WcBSByA==", null, false, "45027976", false, "Admin" });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "IdCategoria", "IdMarca" },
                values: new object[] { new Guid("aefb144e-362f-4ccb-a525-d61cb0a4a2fc"), new Guid("5cccd0d9-47be-4429-aca3-f5d8d94d0435") });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "IdCategoria", "IdMarca" },
                values: new object[] { new Guid("aefb144e-362f-4ccb-a525-d61cb0a4a2fc"), new Guid("5cccd0d9-47be-4429-aca3-f5d8d94d0435") });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "IdCategoria", "IdMarca" },
                values: new object[] { new Guid("38c96576-73f3-482b-84c4-9b63ee79a346"), new Guid("38552366-f623-4328-b3c4-7e77f604ac88") });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "IdCategoria", "IdMarca" },
                values: new object[] { new Guid("38c96576-73f3-482b-84c4-9b63ee79a346"), new Guid("38552366-f623-4328-b3c4-7e77f604ac88") });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "IdCategoria", "IdMarca" },
                values: new object[] { new Guid("38c96576-73f3-482b-84c4-9b63ee79a346"), new Guid("38552366-f623-4328-b3c4-7e77f604ac88") });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "IdCategoria", "IdMarca" },
                values: new object[] { new Guid("aefb144e-362f-4ccb-a525-d61cb0a4a2fc"), new Guid("5cccd0d9-47be-4429-aca3-f5d8d94d0435") });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "IdCategoria", "IdMarca" },
                values: new object[] { new Guid("7dbe530c-2fcd-48df-8ffc-659d3f641780"), new Guid("33479939-adfd-423d-b033-4bfbb1fb65b8") });

            migrationBuilder.UpdateData(
                table: "Produto",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "IdCategoria", "IdMarca" },
                values: new object[] { new Guid("3858c818-0980-4ebf-b393-e486b3f9e1b8"), new Guid("9bfeab4c-ad56-4f38-91cf-59bcfa18cd61") });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "acdb899c-63d4-43aa-ad29-3923c3eba6d7", "acdb899c-63d4-43aa-ad29-3923c3eba6d7" });
        }
    }
}
