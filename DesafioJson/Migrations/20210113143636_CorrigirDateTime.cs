using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DesafioJson.Migrations
{
    public partial class CorrigirDateTime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DataInclusaoRegistro",
                schema: "Desafio",
                table: "Orcamentaria",
                type: "DateTime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "Date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataNascimento",
                schema: "Desafio",
                table: "Contadores",
                type: "DateTime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "Date");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DataInclusaoRegistro",
                schema: "Desafio",
                table: "Orcamentaria",
                type: "Date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DateTime");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataNascimento",
                schema: "Desafio",
                table: "Contadores",
                type: "Date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DateTime");
        }
    }
}
