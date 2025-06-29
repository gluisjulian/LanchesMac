﻿namespace LanchesMac.Models
{
    public class Lanche
    {
        public int LancheId { get; set; }
        public string Nome { get; set; }
        public string DescricaoCurta { get; set; }
        public string DescricaoDetalhada{ get; set; }
        public decimal Preco{ get; set; }
        public string ImagemURL { get; set; }
        public string ImagemThumbnailURL { get; set; }
        public bool IsLacnhePreferido { get; set; }
        public bool EmEstoque {  get; set; }

        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}
