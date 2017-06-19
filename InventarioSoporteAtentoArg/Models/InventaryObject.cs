using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace InventarioSoporteAtentoArg.Models
{
    public class InventaryObject
    {
        [Key]
        public int InventaryObjectID { get; set; }

        [Display(Name = "Tipo de Objeto")]
        public int ObjectTypeID { get; set; }

        [Display(Name = "Etiqueta Atento")]
        public string EtiquetteAtento { get; set; }

        [Display(Name = "Serial de Fabricante")]
        public string SerialNumber { get; set; }

        [Display(Name ="Modelo")]
        public string Model { get; set; }

        [Display(Name = "Nombre(PC/Dispositivo)")]
        public string Name { get; set; }

        [Display(Name = "Observaciones")]
        public string Observations { get; set; }

        [Display(Name = "Extension")]
        public string Extension { get; set; }

        [Display(Name ="Dueño")]
        public string Owner { get; set; }

        [Display(Name ="Cantidad Memoria RAM")]
        public string QuantityRam { get; set; }

        [Display(Name ="Tamaño de Disco")]
        public string QuantityHDD { get; set; }

        [Display(Name ="Procesador")]
        public string ModelProcessor { get; set; }

        [Display(Name ="Velocidad Procesador")]
        public string SpeedProcessor { get; set; }

        public virtual ObjectType ObjectType { get; set; }
        public virtual ICollection<Location> Locations { get; set; }
    }
}