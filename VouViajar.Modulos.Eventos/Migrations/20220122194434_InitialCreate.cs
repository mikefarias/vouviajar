using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VouViajar.Modulos.Eventos.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Localidade",
                columns: table => new
                {
                    IdLocalidade = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ativo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Localidade", x => x.IdLocalidade);
                });

            migrationBuilder.CreateTable(
                name: "Situacao",
                columns: table => new
                {
                    IdSituacao = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ativo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Situacao", x => x.IdSituacao);
                });

            migrationBuilder.CreateTable(
                name: "Tipo",
                columns: table => new
                {
                    IdTipo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ativo = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipo", x => x.IdTipo);
                });

            migrationBuilder.CreateTable(
                name: "Evento",
                columns: table => new
                {
                    IdEvento = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdAgencia = table.Column<int>(type: "int", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Resumo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataFim = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OrigemIdLocalidade = table.Column<int>(type: "int", nullable: true),
                    DestinoIdLocalidade = table.Column<int>(type: "int", nullable: true),
                    TotalVagas = table.Column<int>(type: "int", nullable: false),
                    ValorVaga = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NomeArquivo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Arquivo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SituacaoIdSituacao = table.Column<int>(type: "int", nullable: true),
                    TipoIdTipo = table.Column<int>(type: "int", nullable: true),
                    CadastradoEm = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Evento", x => x.IdEvento);
                    table.ForeignKey(
                        name: "FK_Evento_Localidade_DestinoIdLocalidade",
                        column: x => x.DestinoIdLocalidade,
                        principalTable: "Localidade",
                        principalColumn: "IdLocalidade",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Evento_Localidade_OrigemIdLocalidade",
                        column: x => x.OrigemIdLocalidade,
                        principalTable: "Localidade",
                        principalColumn: "IdLocalidade",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Evento_Situacao_SituacaoIdSituacao",
                        column: x => x.SituacaoIdSituacao,
                        principalTable: "Situacao",
                        principalColumn: "IdSituacao",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Evento_Tipo_TipoIdTipo",
                        column: x => x.TipoIdTipo,
                        principalTable: "Tipo",
                        principalColumn: "IdTipo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Evento_DestinoIdLocalidade",
                table: "Evento",
                column: "DestinoIdLocalidade");

            migrationBuilder.CreateIndex(
                name: "IX_Evento_OrigemIdLocalidade",
                table: "Evento",
                column: "OrigemIdLocalidade");

            migrationBuilder.CreateIndex(
                name: "IX_Evento_SituacaoIdSituacao",
                table: "Evento",
                column: "SituacaoIdSituacao");

            migrationBuilder.CreateIndex(
                name: "IX_Evento_TipoIdTipo",
                table: "Evento",
                column: "TipoIdTipo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Evento");

            migrationBuilder.DropTable(
                name: "Localidade");

            migrationBuilder.DropTable(
                name: "Situacao");

            migrationBuilder.DropTable(
                name: "Tipo");
        }
    }
}
