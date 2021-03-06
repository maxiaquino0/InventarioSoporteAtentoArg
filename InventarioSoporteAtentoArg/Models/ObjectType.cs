﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace InventarioSoporteAtentoArg.Models
{
    public class ObjectType
    {
        [Key]
        public int objectTypeID { get; set; }

        [Display(Name ="Tipo de Objeto")]
        public string Description { get; set; }

        [JsonIgnore]
        public virtual ICollection<InventaryObject> InventaryObjects { get; set; }
    }
}