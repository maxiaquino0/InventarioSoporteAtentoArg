using System.ComponentModel.DataAnnotations;

namespace InventarioSoporteAtentoArg.Models
{
    public class Floor
    {
        [Key]
        public int IdFloor { get; set; }
        public string Description { get; set; }
    }
}