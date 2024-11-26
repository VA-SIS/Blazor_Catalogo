using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blazor_Catalogo.Shared.Models;

public class Produto
{
    [Key]
    public int ProdutoId { get; set; }

    [Required(ErrorMessage = "Informe o nome do produto")]
    [MaxLength(100)]
    public string? Nome { get; set; }

    [Required(ErrorMessage = "Informe a descrição do produto")]
    [MaxLength(200)]
    public string? Descricao { get; set; }

    [Required(ErrorMessage = "Informe o preço do produto")]
    [Column(TypeName = "decimal(18,2)")]
    public decimal Preco { get; set; }

    public string? ImagemUrl { get; set; }

    public int CategoriaId { get; set; }
    public virtual Categoria? Categoria { get; set; }
}

