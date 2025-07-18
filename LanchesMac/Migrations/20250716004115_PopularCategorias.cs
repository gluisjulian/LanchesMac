﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanchesMac.Migrations
{
    public partial class PopularCategorias : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO CATEGORIAS (CategoriaNome, Descricao) " +
                "VALUES ('Normal', 'Lanche feito com ingredientes normais.' )");

            migrationBuilder.Sql("INSERT INTO CATEGORIAS (CategoriaNome, Descricao) " +
                "VALUES ('Natural', 'Lanche feito com ingredientes naturais.' )");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Categorias");
        }
    }
}
