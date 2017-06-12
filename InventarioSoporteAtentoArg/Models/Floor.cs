using System.ComponentModel.DataAnnotations;

namespace InventarioSoporteAtentoArg.Models
{
    public class Floor
    {
        [Key]
        public int FloorID { get; set; }
        public string Description { get; set; }
    }
}