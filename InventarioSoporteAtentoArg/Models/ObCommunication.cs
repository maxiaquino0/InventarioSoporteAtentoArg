using System.ComponentModel.DataAnnotations;

namespace InventarioSoporteAtentoArg.Models
{
    public class ObCommunication
    {
        [Key]
        public int ObCommunicationID { get; set; }
        public string Description { get; set; }
        public string EtiquetteAtento { get; set; }
        public string SerialNumber { get; set; }
        public string Model { get; set; }
        public string Observations { get; set; }
        public string Owner { get; set; }
    }
}