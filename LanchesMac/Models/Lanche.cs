using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanchesMac.Models
{
    [Table("Lanches")]
    public class Lanche
    {
        [Key]
        public int LancheId { get; set; }

        [Required(ErrorMessage = "O nome do lanche deve ser informado.")]
        [Display(Name = "Nome do lanche")]
        [StringLength(80,MinimumLength = 10 ,ErrorMessage = "O {0} deve ter no minimo {1} e no maximo {2} caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "A descrição do lanche deve ser informada.")]
        [Display(Name = "Descrição do lanche")]
        [MinLength(20, ErrorMessage = "Descrição deve ter no minimo {0} caracteres.")]
        [MaxLength(200, ErrorMessage = "Descrição deve ter no maximo {0} caracteres.")]
        public string DescricaoCurta { get; set; }

        [Required(ErrorMessage = "A descrição detalhada do lanche deve ser informada.")]
        [Display(Name = "Descrição detalhada do lanche")]
        [MinLength(20, ErrorMessage = "Descrição detalhada deve ter no minimo {0} caracteres.")]
        [MaxLength(200, ErrorMessage = "Descrição detalhada deve ter no maximo {0} caracteres.")]
        public string DescricaoDetalhada{ get; set; }

        [Required(ErrorMessage = "Informe o preço do lanche.")]
        [Display(Name = "Preço")]
        [Column(TypeName = "decimal(10,2)")]
        [Range(1, 999.99, ErrorMessage = "O preço deve estar entre 1 e 999,99")]
        public decimal Preco{ get; set; }

        [Display(Name = "Caminho imagem normal.")]
        [StringLength(200, ErrorMessage = "O {0} deve ter no maximo {1} caracteres.")]
        public string ImagemURL { get; set; }

        [Display(Name = "Caminho imagem miniatura.")]
        [StringLength(200, ErrorMessage = "O {0} deve ter no maximo {1} caracteres.")]
        public string ImagemThumbnailURL { get; set; }

        [Display(Name = "Preferido?")]
        public bool IsLanchePreferido { get; set; }

        [Display(Name = "Estoque")]
        public bool EmEstoque {  get; set; }


        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}
