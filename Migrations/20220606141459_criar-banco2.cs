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
                keyValue: "0b22f597-0cea-43ee-8c0f-16ad6094cf5f");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "e7f97be3-000a-45cd-9800-5c6205dd35ff");

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "da719410-a66a-4953-a1be-35a7efe6b7e1", "da719410-a66a-4953-a1be-35a7efe6b7e1" });

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "da719410-a66a-4953-a1be-35a7efe6b7e1");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "da719410-a66a-4953-a1be-35a7efe6b7e1");

            migrationBuilder.AddColumn<uint>(
                name: "Ordem",
                table: "ImagensSite",
                type: "int unsigned",
                nullable: false,
                defaultValue: 0u);

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "25470220-cb82-4592-9ebb-f1a7f62a3b13", "4ad37f3d-e794-43f4-aa79-19f501d1cf0b", "Administrador", "ADMINISTRADOR" },
                    { "3e376325-cae1-4371-bd7c-508b4ee03c41", "2be9dfce-e0ba-4702-844d-115c24c0e517", "Moderador", "MODERADOR" },
                    { "5707e1dc-2cc4-4e49-9547-e2ed0c90ea78", "31980db3-540f-49c7-964e-d9a738db5707", "Usuario", "USUARIO" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NomeCompleto", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "25470220-cb82-4592-9ebb-f1a7f62a3b13", 0, "e30220be-95a2-4495-89cf-f27539fe4d25", "igorsax258@gmail.com", true, false, null, "Igor Oliveira de Lima", "IGORSAX258@GMAIL.COM", "ADMIN", "AQAAAAEAACcQAAAAEEaDkkKLorYUneBvY0xqWPUaeTz8B1FG+BLOfvSR+ymsnRn/Zc8QNDCXALJa1s6ChQ==", null, false, "7469042", false, "Admin" });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "25470220-cb82-4592-9ebb-f1a7f62a3b13", "25470220-cb82-4592-9ebb-f1a7f62a3b13" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "3e376325-cae1-4371-bd7c-508b4ee03c41");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "5707e1dc-2cc4-4e49-9547-e2ed0c90ea78");

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "25470220-cb82-4592-9ebb-f1a7f62a3b13", "25470220-cb82-4592-9ebb-f1a7f62a3b13" });

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "25470220-cb82-4592-9ebb-f1a7f62a3b13");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "25470220-cb82-4592-9ebb-f1a7f62a3b13");

            migrationBuilder.DropColumn(
                name: "Ordem",
                table: "ImagensSite");

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "da719410-a66a-4953-a1be-35a7efe6b7e1", "1cc62182-4de3-4122-b39d-880cff92a090", "Administrador", "ADMINISTRADOR" },
                    { "0b22f597-0cea-43ee-8c0f-16ad6094cf5f", "790bc68d-c0d0-45a4-99ae-c475bb617fc3", "Moderador", "MODERADOR" },
                    { "e7f97be3-000a-45cd-9800-5c6205dd35ff", "b7f9937b-a55e-46cc-8225-31b265fc188a", "Usuario", "USUARIO" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NomeCompleto", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "da719410-a66a-4953-a1be-35a7efe6b7e1", 0, "fba32819-e480-4eb8-b4ee-d81d0ade75ce", "igorsax258@gmail.com", true, false, null, "Igor Oliveira de Lima", "IGORSAX258@GMAIL.COM", "ADMIN", "AQAAAAEAACcQAAAAEKpHT3diRoOl/wEEqmK+pm37lO3GhFilnbjCBi3vM9hgkRMDKql4q+1qjI57yImXVQ==", null, false, "60482217", false, "Admin" });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "da719410-a66a-4953-a1be-35a7efe6b7e1", "da719410-a66a-4953-a1be-35a7efe6b7e1" });
        }
    }
}
