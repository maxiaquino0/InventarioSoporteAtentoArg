using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace InventarioSoporteAtentoArg.Models
{
    public class Location
    {
        [Key]
        public int LocationID { get; set; }
        public int PlatformID { get; set; }
        public int FloorID { get; set; }
        public int RoomID { get; set; }

        [Display(Name ="Puesto IT")]
        public string PositionIT { get; set; }

        [Display(Name ="Escritorio")]
        public string Desk { get; set; }

        
        public int InventaryObjectID { get; set; }

        [JsonIgnore]
        public virtual Platform Platform { get; set; }
        [JsonIgnore]
        public virtual Floor Floor { get; set; }
        [JsonIgnore]
        public virtual Room Room { get; set; }
        [JsonIgnore]
        public virtual InventaryObject InventaryObject { get; set; }
    }
}