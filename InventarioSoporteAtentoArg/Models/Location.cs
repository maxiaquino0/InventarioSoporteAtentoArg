﻿using System;
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
        public string PositionIT { get; set; }
        public int ObjectID { get; set; }

        public virtual Platform Platform { get; set; }
        public virtual Floor Floor { get; set; }
        public virtual Room Room { get; set; }
    }
}