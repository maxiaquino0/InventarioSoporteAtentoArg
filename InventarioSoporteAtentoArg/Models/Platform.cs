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
        public int IdPlatform { get; set; }
        public string Name { get; set; }
    }
}