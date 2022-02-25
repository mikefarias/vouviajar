using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VouViajar.Modulos.Eventos.Migrations
{
    public partial class CriandoBaseDeDados : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Eventos");

            migrationBuilder.CreateTable(
                name: "Localidade",
                schema: "Eventos",
                columns: table => new
                {
                    LocalidadeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ativo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Localidade", x => x.LocalidadeID);
                });

            migrationBuilder.CreateTable(
                name: "Situacao",
                schema: "Eventos",
                columns: table => new
                {
                    SituacaoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ativo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Situacao", x => x.SituacaoID);
                });

            migrationBuilder.CreateTable(
                name: "Tipo",
                schema: "Eventos",
                columns: table => new
                {
                    TipoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ativo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipo", x => x.TipoID);
                });

            migrationBuilder.CreateTable(
                name: "Evento",
                schema: "Eventos",
                columns: table => new
                {
                    EventoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AgenciaID = table.Column<int>(type: "int", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Resumo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataFim = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalVagas = table.Column<int>(type: "int", nullable: false),
                    ValorVaga = table.Column<decimal>(type: "decimal(5)", precision: 5, nullable: false),
                    NomeArquivo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Arquivo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CadastradoEm = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OrigemID = table.Column<int>(type: "int", nullable: false),
                    DestinoID = table.Column<int>(type: "int", nullable: false),
                    SituacaoID = table.Column<int>(type: "int", nullable: false),
                    TipoID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Evento", x => x.EventoID);
                    table.ForeignKey(
                        name: "FK_Evento_Localidade_DestinoID",
                        column: x => x.DestinoID,
                        principalSchema: "Eventos",
                        principalTable: "Localidade",
                        principalColumn: "LocalidadeID");
                    table.ForeignKey(
                        name: "FK_Evento_Localidade_OrigemID",
                        column: x => x.OrigemID,
                        principalSchema: "Eventos",
                        principalTable: "Localidade",
                        principalColumn: "LocalidadeID");
                    table.ForeignKey(
                        name: "FK_Evento_Situacao_SituacaoID",
                        column: x => x.SituacaoID,
                        principalSchema: "Eventos",
                        principalTable: "Situacao",
                        principalColumn: "SituacaoID");
                    table.ForeignKey(
                        name: "FK_Evento_Tipo_TipoID",
                        column: x => x.TipoID,
                        principalSchema: "Eventos",
                        principalTable: "Tipo",
                        principalColumn: "TipoID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Evento_DestinoID",
                schema: "Eventos",
                table: "Evento",
                column: "DestinoID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Evento_OrigemID",
                schema: "Eventos",
                table: "Evento",
                column: "OrigemID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Evento_SituacaoID",
                schema: "Eventos",
                table: "Evento",
                column: "SituacaoID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Evento_TipoID",
                schema: "Eventos",
                table: "Evento",
                column: "TipoID",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Evento",
                schema: "Eventos");

            migrationBuilder.DropTable(
                name: "Localidade",
                schema: "Eventos");

            migrationBuilder.DropTable(
                name: "Situacao",
                schema: "Eventos");

            migrationBuilder.DropTable(
                name: "Tipo",
                schema: "Eventos");
        }
    }
}
