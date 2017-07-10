using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace InventarioSoporteAtentoArg.Models
{
    public class Room
    {
        [Key]
        public int RoomID { get; set; }

        [Display(Name ="Nombre de Sala/Oficina")]
        public string Description { get; set; }

        [Display(Name ="Nombre de Plataforma")]
        public int PlatformID { get; set; }

        [JsonIgnore]
        public virtual Platform Platform { get; set; }
        [JsonIgnore]
        public virtual ICollection<Location> Locations { get; set; }
    }
}