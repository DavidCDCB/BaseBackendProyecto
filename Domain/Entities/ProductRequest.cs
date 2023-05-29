using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    [Table("productrequest")]
    public class ProductRequest
    {
        public int ProductsId { get; set; }
        public int RequestsId { get; set; }

        // Propiedades de navegación a las entidades principales
        //public Product Product { get; set; }
        //public Request Request { get; set; }

    }
}
