using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace InventarioSoporteAtentoArg.Models
{
    public class Platform
    {
        [Key]
        public int PlatformID { get; set; }

        [Display(Name ="Nombre de Plataforma")]
        public string Name { get; set; }

        [JsonIgnore]
        public virtual ICollection<Room> Rooms { get; set; }
        [JsonIgnore]
        public virtual ICollection<Location> Locations { get; set; }
    }
}