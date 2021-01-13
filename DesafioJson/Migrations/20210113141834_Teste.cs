using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DesafioJson.Migrations
{
    public partial class Teste : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Desafio");

            migrationBuilder.CreateTable(
                name: "UnidadeGestora",
                schema: "Desafio",
                columns: table => new
                {
                    Codigo = table.Column<int>(type: "int", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    NomeReduzido = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DataCriacao = table.Column<DateTime>(type: "DateTime", nullable: false),
                    Cnpj = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    IntegracaoCompras = table.Column<bool>(type: "BIT", nullable: false),
                    EmitePreEmpenhoIntegrado = table.Column<bool>(type: "BIT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnidadeGestora", x => x.Codigo);
                });

            migrationBuilder.CreateTable(
                name: "Contadores",
                schema: "Desafio",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "Date", nullable: false),
                    Endereco = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Numero = table.Column<int>(type: "Int", nullable: false),
                    Bairro = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Ativo = table.Column<bool>(type: "BIT", nullable: false),
                    UnidadeGestoraCodigo = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contadores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contadores_UnidadeGestora_UnidadeGestoraCodigo",
                        column: x => x.UnidadeGestoraCodigo,
                        principalSchema: "Desafio",
                        principalTable: "UnidadeGestora",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Orcamentaria",
                schema: "Desafio",
                columns: table => new
                {
                    Codigo = table.Column<int>(type: "int", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    UsuarioInclusaoRegistro = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DataInclusaoRegistro = table.Column<DateTime>(type: "Date", nullable: false),
                    UnidadeGestoraCodigo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orcamentaria", x => x.Codigo);
                    table.ForeignKey(
                        name: "FK_Orcamentaria_UnidadeGestora_UnidadeGestoraCodigo",
                        column: x => x.UnidadeGestoraCodigo,
                        principalSchema: "Desafio",
                        principalTable: "UnidadeGestora",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contadores_UnidadeGestoraCodigo",
                schema: "Desafio",
                table: "Contadores",
                column: "UnidadeGestoraCodigo");

            migrationBuilder.CreateIndex(
                name: "IX_Orcamentaria_UnidadeGestoraCodigo",
                schema: "Desafio",
                table: "Orcamentaria",
                column: "UnidadeGestoraCodigo",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contadores",
                schema: "Desafio");

            migrationBuilder.DropTable(
                name: "Orcamentaria",
                schema: "Desafio");

            migrationBuilder.DropTable(
                name: "UnidadeGestora",
                schema: "Desafio");
        }
    }
}
