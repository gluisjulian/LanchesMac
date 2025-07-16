using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanchesMac.Migrations
{
    public partial class PopularLanches : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Lanches (CategoriaId, DescricaoCurta, DescricaoDetalhada, EmEstoque, ImagemThumbnailURL, ImagemUrl, IsLanchePreferido, Nome, Preco) " +
                "VALUES (1, 'Pão, Hamburguer, ovo, presunto, queijo e batata palha', 'Delicioso pão de hamburguer com ovo frito; presunto e queijo de primeira qualidade acompanhado com batata palha', 1, 'http://macoratti.net/Imagens/lanches/cheesesalada1.jpg', 'http://macoratti.net/Imagens/lanches/cheesesalada1.jpg', 0, 'Cheese Salada', 12.50)");

            migrationBuilder.Sql("INSERT INTO Lanches (CategoriaId, DescricaoCurta, DescricaoDetalhada, EmEstoque, ImagemThumbnailURL, ImagemUrl, IsLanchePreferido, Nome, Preco) " +
                "VALUES (1, 'Pão, Hamburguer, ovo, presunto, queijo e batata palha', 'Delicioso pão de hamburguer com ovo frito; presunto e queijo de primeira qualidade acompanhado com batata palha', 1, 'http://macoratti.net/Imagens/lanches/cheesesalada1.jpg', 'http://macoratti.net/Imagens/lanches/cheesesalada1.jpg', 0, 'Cheese Salada', 12.50)");

            migrationBuilder.Sql("INSERT INTO Lanches (CategoriaId, DescricaoCurta, DescricaoDetalhada, EmEstoque, ImagemThumbnailURL, ImagemUrl, IsLanchePreferido, Nome, Preco) " +
                "VALUES (1, 'Pão, Hamburguer, ovo, presunto, queijo e batata palha', 'Delicioso pão de hamburguer com ovo frito; presunto e queijo de primeira qualidade acompanhado com batata palha', 1, 'http://macoratti.net/Imagens/lanches/cheesesalada1.jpg', 'http://macoratti.net/Imagens/lanches/cheesesalada1.jpg', 0, 'Cheese Salada', 12.50)");

            migrationBuilder.Sql("INSERT INTO Lanches (CategoriaId, DescricaoCurta, DescricaoDetalhada, EmEstoque, ImagemThumbnailURL, ImagemUrl, IsLanchePreferido, Nome, Preco) " +
                "VALUES (2, 'Pão, Hamburguer, ovo, presunto, queijo e batata palha', 'Delicioso pão de hamburguer com ovo frito; presunto e queijo de primeira qualidade acompanhado com batata palha', 1, 'http://macoratti.net/Imagens/lanches/cheesesalada1.jpg', 'http://macoratti.net/Imagens/lanches/cheesesalada1.jpg', 1, 'Cheese Salada', 12.50)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Lanches");
        }
    }
}
