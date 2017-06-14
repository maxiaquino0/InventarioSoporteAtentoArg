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
        public string Description { get; set; }

        public virtual ICollection<InventaryObject> InventaryObjects { get; set; }
    }
}