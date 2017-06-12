using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace InventarioSoporteAtentoArg.Models
{
    public class ObCPU
    {
        [Key]
        public int ObCPUID { get; set; }
        public string Description { get; set; }
        public string EtiquetteAtento { get; set; }
        public string SerialNumber { get; set; }
        public string Model { get; set; }
        public string NamePC { get; set; }
        public string Observations { get; set; }
        public string Owner { get; set; }
        public string QuantityRam { get; set; }
        public string QuantityHDD { get; set; }
        public string ModelProcessor { get; set; }
        public string SpeedProcessor { get; set; }
    }
}