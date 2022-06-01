using Microsoft.EntityFrameworkCore.Migrations;

namespace AppEcommerce.Migrations
{
    public partial class criarbanco2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "6e935498-e017-4358-afd1-e06389fd53d1");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "c5b48e46-6447-4513-89ba-1a8d4ee98ca3");

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "43c853b0-eaf6-42d2-b649-080b0f40189f", "43c853b0-eaf6-42d2-b649-080b0f40189f" });

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "43c853b0-eaf6-42d2-b649-080b0f40189f");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "43c853b0-eaf6-42d2-b649-080b0f40189f");

            migrationBuilder.AddColumn<bool>(
                name: "ExibirHome",
                table: "Produto",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "90f97045-6579-4896-853a-0dcf8fd5a39d", "2cee90d8-b300-48ef-8db0-65f2269b6ca1", "Administrador", "ADMINISTRADOR" },
                    { "3170be19-6424-4b3d-b884-bdad31e0a7ab", "e5c74cdb-2260-4254-b547-cbf451b6b4c3", "Moderador", "MODERADOR" },
                    { "3b35eabf-fcce-43dc-9145-ece642b59c33", "0e700103-b689-49b5-b237-7eac80e5b3fc", "Usuario", "USUARIO" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NomeCompleto", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "90f97045-6579-4896-853a-0dcf8fd5a39d", 0, "9c4f4760-dad8-452a-afe4-ddc3cc759825", "igorsax258@gmail.com", true, false, null, "Igor Oliveira de Lima", "IGORSAX258@GMAIL.COM", "ADMIN", "AQAAAAEAACcQAAAAEArEG0l+byQn1s+5oxobueMCzl1To0ars8aTHG0eLRP8veUBygB81FW9zZWXCiCCsA==", null, false, "31764686", false, "Admin" });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "90f97045-6579-4896-853a-0dcf8fd5a39d", "90f97045-6579-4896-853a-0dcf8fd5a39d" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "3170be19-6424-4b3d-b884-bdad31e0a7ab");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "3b35eabf-fcce-43dc-9145-ece642b59c33");

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "90f97045-6579-4896-853a-0dcf8fd5a39d", "90f97045-6579-4896-853a-0dcf8fd5a39d" });

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "90f97045-6579-4896-853a-0dcf8fd5a39d");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "90f97045-6579-4896-853a-0dcf8fd5a39d");

            migrationBuilder.DropColumn(
                name: "ExibirHome",
                table: "Produto");

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "43c853b0-eaf6-42d2-b649-080b0f40189f", "e688735d-a70d-45c9-8b5f-4f99ae10d031", "Administrador", "ADMINISTRADOR" },
                    { "6e935498-e017-4358-afd1-e06389fd53d1", "238db4f0-1282-4dba-8d7f-492e3bbf8623", "Moderador", "MODERADOR" },
                    { "c5b48e46-6447-4513-89ba-1a8d4ee98ca3", "0cc6688d-4df4-4dc5-b4e0-3d6c76211aa8", "Usuario", "USUARIO" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NomeCompleto", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "43c853b0-eaf6-42d2-b649-080b0f40189f", 0, "c8269a02-b53d-4f1a-a2b8-f87e78556759", "igorsax258@gmail.com", true, false, null, "Igor Oliveira de Lima", "IGORSAX258@GMAIL.COM", "ADMIN", "AQAAAAEAACcQAAAAEKtZqeScOVI/vSdDZjPj/abW7HMaAjpOpEt4mYanZ4PJZdTwptxaj2SG3KOxLWzEMA==", null, false, "55725192", false, "Admin" });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "43c853b0-eaf6-42d2-b649-080b0f40189f", "43c853b0-eaf6-42d2-b649-080b0f40189f" });
        }
    }
}
