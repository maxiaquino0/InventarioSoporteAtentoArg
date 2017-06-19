using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace InventarioSoporteAtentoArg.Models
{
    public class Floor
    {
        [Key]
        public int FloorID { get; set; }

        [Display(Name ="Piso")]
        public string Description { get; set; }

        public virtual ICollection<Location> Locations { get; set; }
    }
}