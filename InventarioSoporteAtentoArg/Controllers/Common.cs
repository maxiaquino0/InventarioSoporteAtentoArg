using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using InventarioSoporteAtentoArg.Models;

namespace InventarioSoporteAtentoArg.Controllers
{
    public class Common
    {
        private static InventarioSoporteAtentoArgContext db = new InventarioSoporteAtentoArgContext();

        public static List<Floor> GetFloors()
        {
            var list = db.Floors.ToList();
            list.Add(new Floor { FloorID = 0, Description = "[Sin Selección]" });
            list = list.OrderBy(c => c.Description).ToList();
            return list;
        }

        public static List<InventaryObject> GetInventaryObjects()
        {
            var list = db.InventaryObjects.ToList();
            list.Add(new InventaryObject { InventaryObjectID = 0, EtiquetteAtento = "[Sin Selección]" });
            list = list.OrderBy(c => c.EtiquetteAtento).ToList();
            return list;
        }

        public static List<ObjectType> GetObjectTypes()
        {
            var list = db.ObjectTypes.ToList();
            list.Add(new ObjectType { objectTypeID = 0, Description = "[Sin Selección]" });
            list = list.OrderBy(c => c.Description).ToList();
            return list;
        }

        public static List<Platform> GetPlatforms()
        {
            var list = db.Platforms.ToList();
            list.Add(new Platform { PlatformID = 0, Name = "[Sin Selección]" });
            list = list.OrderBy(c => c.Name).ToList();
            return list;
        }

        public static List<Room> GetRooms()
        {
            var list = db.Rooms.ToList();
            list.Add(new Room { RoomID = 0, Description = "[Sin Selección]" });
            list = list.OrderBy(c => c.Description).ToList();
            return list;
        }


    }
}