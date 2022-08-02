using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoDLA.Migrations
{
    public partial class AddedCreationDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Todos",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Todos");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Password",
                value: "$2a$11$3rIpoh7LuzD.tCnAM2GVVO9NghLztrHIV1edwphFPwPypvFu5xpqS");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "Password",
                value: "$2a$11$Xl02pDNbo1xgjyMYXEEv0.4gz.p59Rg4o1l/3BXz82KRSQV0sqPkO");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "Password",
                value: "$2a$11$4DPFwxNAMWHPyrAsOgQFyeGA0TTysofMulPmFvflM7zX9y2zW3i42");
        }
    }
}
