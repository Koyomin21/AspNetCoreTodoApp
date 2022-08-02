using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoDLA.Migrations
{
    public partial class seedUsersRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Admin" },
                    { 2, "User" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Password", "RoleId" },
                values: new object[,]
                {
                    { 1, "anuar@mail.ru", "$2a$11$3rIpoh7LuzD.tCnAM2GVVO9NghLztrHIV1edwphFPwPypvFu5xpqS", 1 },
                    { 2, "elvira@mail.ru", "$2a$11$Xl02pDNbo1xgjyMYXEEv0.4gz.p59Rg4o1l/3BXz82KRSQV0sqPkO", 2 },
                    { 3, "aldik@mail.ru", "$2a$11$4DPFwxNAMWHPyrAsOgQFyeGA0TTysofMulPmFvflM7zX9y2zW3i42", 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
