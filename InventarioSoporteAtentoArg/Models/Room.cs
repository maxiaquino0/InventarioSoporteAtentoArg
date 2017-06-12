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
        public string Description { get; set; }
        public int PlatformID { get; set; }

        public virtual Platform Platform { get; set; }
    }
}