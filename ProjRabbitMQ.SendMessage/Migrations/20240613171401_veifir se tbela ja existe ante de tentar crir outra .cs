using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjRabbitMQ.SendMessage.Migrations
{
    public partial class veifirsetbelajaexisteantedetentarcriroutra : Migration
    {

        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Seu trecho de código personalizado para criar a tabela 'Message', se ela ainda não existir
            migrationBuilder.Sql("IF OBJECT_ID('dbo.Message', 'U') IS NULL BEGIN CREATE TABLE dbo.Message (Id INT PRIMARY KEY) END");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
