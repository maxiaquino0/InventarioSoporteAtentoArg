using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace InventarioSoporteAtentoArg.Models
{
    public class InventarioSoporteAtentoArgContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public InventarioSoporteAtentoArgContext() : base("name=InventarioSoporteAtentoArgContext")
        {
        }

        public System.Data.Entity.DbSet<InventarioSoporteAtentoArg.Models.Floor> Floors { get; set; }

        public System.Data.Entity.DbSet<InventarioSoporteAtentoArg.Models.Room> Rooms { get; set; }

        public System.Data.Entity.DbSet<InventarioSoporteAtentoArg.Models.Platform> Platforms { get; set; }

        public System.Data.Entity.DbSet<InventarioSoporteAtentoArg.Models.ObjectType> ObjectTypes { get; set; }

        public System.Data.Entity.DbSet<InventarioSoporteAtentoArg.Models.InventaryObject> InventaryObjects { get; set; }
    }
}
