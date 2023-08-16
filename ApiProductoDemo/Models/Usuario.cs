using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiProductoDemo.Models
{
    public class Usuario
    {
        [Key]
        public int id { get; set; }
        public string email { get; set; }
        public string nombre { get; set; }
        public string password { get; set; }

    }
}
