﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace InventarioSoporteAtentoArg.Models
{
    public class ObPeripheral
    {
        [Key]
        public int IdObPeripheral { get; set; }
        public string Description { get; set; }
        public string EtiquetteAtento { get; set; }
        public string SerialNumber { get; set; }
        public string Model { get; set; }
        public string Name { get; set; }
        public string Observations { get; set; }
        public string Owner { get; set; }
    }
}