using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CardapioWeb.Models
{
    [Table("Categorias")] // quando o codigo for lido irá buscar no banco de dados 
    public class Categoria //ela é o objeto em si, a categoria em si
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
    }
}
