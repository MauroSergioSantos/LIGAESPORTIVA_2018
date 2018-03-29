using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SGLE.InfraStructure.Migrations
{
    public partial class ConfiguraClassesArbitroAssistenteAtletaCampeonatoEquipe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "NomeEquipe",
                table: "Equipe",
                type: "varchar(180)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Endereco",
                table: "Equipe",
                type: "varchar(140)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Equipe",
                type: "varchar(120)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NomedoCampeonato",
                table: "Campeonato",
                type: "varchar(200)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RG",
                table: "Atleta",
                type: "varchar(10)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NomedoAtleta",
                table: "Atleta",
                type: "varchar(140)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Naturalidade",
                table: "Atleta",
                type: "varchar(120)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nacionalidade",
                table: "Atleta",
                type: "varchar(120)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Endereco",
                table: "Atleta",
                type: "varchar(180)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CPF",
                table: "Atleta",
                type: "varchar(11)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RG",
                table: "Assistente",
                type: "varchar(10)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NomeAssistente",
                table: "Assistente",
                type: "varchar(120)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Naturalidade",
                table: "Assistente",
                type: "varchar(120)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nacionalidade",
                table: "Assistente",
                type: "varchar(120)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Endereco",
                table: "Assistente",
                type: "varchar(180)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CPF",
                table: "Assistente",
                type: "varchar(11)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RG",
                table: "Arbitro",
                type: "varchar(200)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NomeArbitro",
                table: "Arbitro",
                type: "varchar(180)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Naturalidade",
                table: "Arbitro",
                type: "varchar(120)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nacionalidade",
                table: "Arbitro",
                type: "varchar(80)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Endereco",
                table: "Arbitro",
                type: "varchar(200)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CPF",
                table: "Arbitro",
                type: "varchar(11)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "NomeEquipe",
                table: "Equipe",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(180)");

            migrationBuilder.AlterColumn<string>(
                name: "Endereco",
                table: "Equipe",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(140)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Equipe",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(120)");

            migrationBuilder.AlterColumn<string>(
                name: "NomedoCampeonato",
                table: "Campeonato",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(200)");

            migrationBuilder.AlterColumn<string>(
                name: "RG",
                table: "Atleta",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(10)");

            migrationBuilder.AlterColumn<string>(
                name: "NomedoAtleta",
                table: "Atleta",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(140)");

            migrationBuilder.AlterColumn<string>(
                name: "Naturalidade",
                table: "Atleta",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(120)");

            migrationBuilder.AlterColumn<string>(
                name: "Nacionalidade",
                table: "Atleta",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(120)");

            migrationBuilder.AlterColumn<string>(
                name: "Endereco",
                table: "Atleta",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(180)");

            migrationBuilder.AlterColumn<string>(
                name: "CPF",
                table: "Atleta",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(11)");

            migrationBuilder.AlterColumn<string>(
                name: "RG",
                table: "Assistente",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(10)");

            migrationBuilder.AlterColumn<string>(
                name: "NomeAssistente",
                table: "Assistente",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(120)");

            migrationBuilder.AlterColumn<string>(
                name: "Naturalidade",
                table: "Assistente",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(120)");

            migrationBuilder.AlterColumn<string>(
                name: "Nacionalidade",
                table: "Assistente",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(120)");

            migrationBuilder.AlterColumn<string>(
                name: "Endereco",
                table: "Assistente",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(180)");

            migrationBuilder.AlterColumn<string>(
                name: "CPF",
                table: "Assistente",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(11)");

            migrationBuilder.AlterColumn<string>(
                name: "RG",
                table: "Arbitro",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(200)");

            migrationBuilder.AlterColumn<string>(
                name: "NomeArbitro",
                table: "Arbitro",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(180)");

            migrationBuilder.AlterColumn<string>(
                name: "Naturalidade",
                table: "Arbitro",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(120)");

            migrationBuilder.AlterColumn<string>(
                name: "Nacionalidade",
                table: "Arbitro",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(80)");

            migrationBuilder.AlterColumn<string>(
                name: "Endereco",
                table: "Arbitro",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(200)");

            migrationBuilder.AlterColumn<string>(
                name: "CPF",
                table: "Arbitro",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(11)");
        }
    }
}
