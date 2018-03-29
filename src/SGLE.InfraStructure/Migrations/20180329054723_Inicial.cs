using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SGLE.InfraStructure.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Arbitro",
                columns: table => new
                {
                    ArbitroId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Altura = table.Column<decimal>(nullable: false),
                    CPF = table.Column<string>(nullable: true),
                    DataNascimento = table.Column<DateTime>(nullable: false),
                    Endereco = table.Column<string>(nullable: true),
                    Nacionalidade = table.Column<string>(nullable: true),
                    Naturalidade = table.Column<string>(nullable: true),
                    NomeArbitro = table.Column<string>(nullable: true),
                    Peso = table.Column<decimal>(nullable: false),
                    RG = table.Column<string>(nullable: true),
                    Tipo = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Arbitro", x => x.ArbitroId);
                });

            migrationBuilder.CreateTable(
                name: "Assistente",
                columns: table => new
                {
                    AssistenteId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Altura = table.Column<decimal>(nullable: false),
                    CPF = table.Column<string>(nullable: true),
                    DataNascimento = table.Column<DateTime>(nullable: false),
                    Endereco = table.Column<string>(nullable: true),
                    Nacionalidade = table.Column<string>(nullable: true),
                    Naturalidade = table.Column<string>(nullable: true),
                    NomeAssistente = table.Column<string>(nullable: true),
                    Peso = table.Column<decimal>(nullable: false),
                    RG = table.Column<string>(nullable: true),
                    Tipo = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assistente", x => x.AssistenteId);
                });

            migrationBuilder.CreateTable(
                name: "Campeonato",
                columns: table => new
                {
                    CampeonatoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ativo = table.Column<bool>(nullable: false),
                    DataFim = table.Column<DateTime>(nullable: false),
                    DataInicio = table.Column<DateTime>(nullable: false),
                    NomedoCampeonato = table.Column<string>(nullable: true),
                    Temporada = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Campeonato", x => x.CampeonatoId);
                });

            migrationBuilder.CreateTable(
                name: "Equipe",
                columns: table => new
                {
                    EquipeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AtletaId = table.Column<int>(nullable: false),
                    CampeonatoId = table.Column<int>(nullable: true),
                    DataCadastro = table.Column<DateTime>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Endereco = table.Column<string>(nullable: true),
                    NomeEquipe = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipe", x => x.EquipeId);
                    table.ForeignKey(
                        name: "FK_Equipe_Campeonato_CampeonatoId",
                        column: x => x.CampeonatoId,
                        principalTable: "Campeonato",
                        principalColumn: "CampeonatoId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Atleta",
                columns: table => new
                {
                    AtletaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Altura = table.Column<decimal>(nullable: false),
                    CPF = table.Column<string>(nullable: true),
                    Categoria = table.Column<int>(nullable: false),
                    DatadeNascimento = table.Column<DateTime>(nullable: false),
                    Endereco = table.Column<string>(nullable: true),
                    EquipeId = table.Column<int>(nullable: true),
                    Nacionalidade = table.Column<string>(nullable: true),
                    Naturalidade = table.Column<string>(nullable: true),
                    NomedoAtleta = table.Column<string>(nullable: true),
                    Peso = table.Column<decimal>(nullable: false),
                    Posicao = table.Column<int>(nullable: false),
                    RG = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Atleta", x => x.AtletaId);
                    table.ForeignKey(
                        name: "FK_Atleta_Equipe_EquipeId",
                        column: x => x.EquipeId,
                        principalTable: "Equipe",
                        principalColumn: "EquipeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Atleta_EquipeId",
                table: "Atleta",
                column: "EquipeId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipe_CampeonatoId",
                table: "Equipe",
                column: "CampeonatoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Arbitro");

            migrationBuilder.DropTable(
                name: "Assistente");

            migrationBuilder.DropTable(
                name: "Atleta");

            migrationBuilder.DropTable(
                name: "Equipe");

            migrationBuilder.DropTable(
                name: "Campeonato");
        }
    }
}
