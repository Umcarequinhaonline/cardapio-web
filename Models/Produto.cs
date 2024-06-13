using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CardapioWeb.Models
{
    [Table ("produtos")]
    public class Produto
    {
        [Key]
        public int id { get; set; }
        [Required (ErrorMessage ="Campo Obrigatorio")]
        [Display(Name ="Nome do produto")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Campo Obrigatorio")]
        public string Descricao_curta { get; set;}
        public string Descricao_detalhada { get; set;}
        [Required(ErrorMessage = "Campo Obrigatorio")]
        public decimal preco { get; set;}
        
        public bool Produto_Preferido { get; set;}
        public bool Em_Estoque { get; set;}
        public virtual Categoria Categoria { get; set;}// campo virtual que busca referencias do categoria


        // a classe produto vai ter o id estrangeiro da classe categoria pois , tem varios profutois em uma categoria

    }
}
