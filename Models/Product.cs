using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GerenciadorDeProdutosCRUD.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DisplayName("Product Name")]
        public string ProductName { get; set; }

        public string ProductDuda { get; set; }

        [Required]
        public double Price { get; set; }
        [Required]

        public int Qty { get; set; }
    }
}
