using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoDLA.Migrations
{
    public partial class addUserId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "$2a$11$TBgzr5UyQ2wiwJGtdJJ6COYw3bNGN2Q.LMpgiRJthaJWQYIyrP6UK");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "$2a$11$n4nmGaJIbfhVYjsbPq/zd.4xuo8xjd6RoO2PjAlsYEjjpEfNh/ZP.");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "Password",
                value: "$2a$11$uetBdy7Zu0wUVEm/TIy/auSPouarz7Zqau1Q30mzssWrhbtc3DcKS");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "$2a$11$Qejqj6gM3VEIxM/Mr1kfLeKg.WufaUxZKJITG/XOQGZ409RUcOBlG");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "$2a$11$tgzp34ZmLQ8FmL6jiPi/EOIhtsgLF1U43aISfA2wn5Md2nwasR1P.");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "Password",
                value: "$2a$11$DtbcoVDCP6LnWXWOGBy0V.KV4KF3LClrJXkB9wzYOxgJHStYF8gDG");
        }
    }
}
