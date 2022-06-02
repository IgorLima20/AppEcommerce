using Microsoft.EntityFrameworkCore.Metadata;
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
                keyValue: "151f6288-5a24-4dc5-98a1-6b67e2c970f5");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "9d542f4d-9c19-4fb9-be12-47880e76e346");

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ace5218a-9ac7-4788-8d1b-22116a89d4bb", "ace5218a-9ac7-4788-8d1b-22116a89d4bb" });

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "ace5218a-9ac7-4788-8d1b-22116a89d4bb");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "ace5218a-9ac7-4788-8d1b-22116a89d4bb");

            migrationBuilder.CreateTable(
                name: "Contato",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Assunto = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Mensagem = table.Column<string>(type: "varchar(600)", maxLength: 600, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contato", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6d3baa71-5074-4b21-baac-cdfbce276910", "8be49294-a65d-44a1-a437-e641e9c33e57", "Administrador", "ADMINISTRADOR" },
                    { "74d51b1d-5384-44ed-a35a-e85e01be3f65", "7fa68a9d-d331-4ca7-99d1-caa8967f187d", "Moderador", "MODERADOR" },
                    { "1519828e-07ae-4884-b528-78536296cb68", "c151af29-daea-45ad-a891-c77c50c5a603", "Usuario", "USUARIO" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NomeCompleto", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "6d3baa71-5074-4b21-baac-cdfbce276910", 0, "45fe43df-b011-4479-bf0f-524a401e5c00", "igorsax258@gmail.com", true, false, null, "Igor Oliveira de Lima", "IGORSAX258@GMAIL.COM", "ADMIN", "AQAAAAEAACcQAAAAEKCszmnb0m5Xdtfms5hP0We+KpZdGzv9d1NP6uNOUfL21wLK5nuk2OEFBusMARzVPg==", null, false, "10736577", false, "Admin" });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "6d3baa71-5074-4b21-baac-cdfbce276910", "6d3baa71-5074-4b21-baac-cdfbce276910" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contato");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "1519828e-07ae-4884-b528-78536296cb68");

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "74d51b1d-5384-44ed-a35a-e85e01be3f65");

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6d3baa71-5074-4b21-baac-cdfbce276910", "6d3baa71-5074-4b21-baac-cdfbce276910" });

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: "6d3baa71-5074-4b21-baac-cdfbce276910");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: "6d3baa71-5074-4b21-baac-cdfbce276910");

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ace5218a-9ac7-4788-8d1b-22116a89d4bb", "2b81f948-7ccc-4ee3-a374-d23c878ab7fe", "Administrador", "ADMINISTRADOR" },
                    { "9d542f4d-9c19-4fb9-be12-47880e76e346", "4307930a-153f-4d43-8447-3ae379369f5c", "Moderador", "MODERADOR" },
                    { "151f6288-5a24-4dc5-98a1-6b67e2c970f5", "f8019cb6-82e3-40d3-870a-07af246a920a", "Usuario", "USUARIO" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NomeCompleto", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "ace5218a-9ac7-4788-8d1b-22116a89d4bb", 0, "4761a36a-8b0a-4c31-81fe-fd2e81dd4522", "igorsax258@gmail.com", true, false, null, "Igor Oliveira de Lima", "IGORSAX258@GMAIL.COM", "ADMIN", "AQAAAAEAACcQAAAAEKOUYInMk/IEUJee+bx4dmOKrXG/Nq5R/kSx2/M9t83NAI1wUjspte8TBko/3mX0tA==", null, false, "55725192", false, "Admin" });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ace5218a-9ac7-4788-8d1b-22116a89d4bb", "ace5218a-9ac7-4788-8d1b-22116a89d4bb" });
        }
    }
}
