using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using InventarioSoporteAtentoArg.Models;

namespace InventarioSoporteAtentoArg.Controllers
{
    public class LocationsController : Controller
    {
        private InventarioSoporteAtentoArgContext db = new InventarioSoporteAtentoArgContext();

        // GET: Locations
        public ActionResult Index()
        {
            var locations = db.Locations.Include(l => l.Floor).Include(l => l.InventaryObject).Include(l => l.Platform).Include(l => l.Room);
            return View(locations.ToList());
        }

        // GET: Locations/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Location location = db.Locations.Find(id);
            if (location == null)
            {
                return HttpNotFound();
            }
            return View(location);
        }

        // GET: Locations/Create
        public ActionResult Create()
        {
            ViewBag.FloorID = new SelectList(db.Floors, "FloorID", "Description");
            ViewBag.InventaryObjectID = new SelectList(db.InventaryObjects, "InventaryObjectID", "EtiquetteAtento");
            ViewBag.PlatformID = new SelectList(db.Platforms, "PlatformID", "Name");
            ViewBag.RoomID = new SelectList(db.Rooms, "RoomID", "Description");
            return View();
        }

        // POST: Locations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "LocationID,PlatformID,FloorID,RoomID,PositionIT,Desk,InventaryObjectID")] Location location)
        {
            if (ModelState.IsValid)
            {
                db.Locations.Add(location);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.FloorID = new SelectList(db.Floors, "FloorID", "Description", location.FloorID);
            ViewBag.InventaryObjectID = new SelectList(db.InventaryObjects, "InventaryObjectID", "EtiquetteAtento", location.InventaryObjectID);
            ViewBag.PlatformID = new SelectList(db.Platforms, "PlatformID", "Name", location.PlatformID);
            ViewBag.RoomID = new SelectList(db.Rooms, "RoomID", "Description", location.RoomID);
            return View(location);
        }

        // GET: Locations/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Location location = db.Locations.Find(id);
            if (location == null)
            {
                return HttpNotFound();
            }
            ViewBag.FloorID = new SelectList(db.Floors, "FloorID", "Description", location.FloorID);
            ViewBag.InventaryObjectID = new SelectList(db.InventaryObjects, "InventaryObjectID", "EtiquetteAtento", location.InventaryObjectID);
            ViewBag.PlatformID = new SelectList(db.Platforms, "PlatformID", "Name", location.PlatformID);
            ViewBag.RoomID = new SelectList(db.Rooms, "RoomID", "Description", location.RoomID);
            return View(location);
        }

        // POST: Locations/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "LocationID,PlatformID,FloorID,RoomID,PositionIT,Desk,InventaryObjectID")] Location location)
        {
            if (ModelState.IsValid)
            {
                db.Entry(location).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.FloorID = new SelectList(db.Floors, "FloorID", "Description", location.FloorID);
            ViewBag.InventaryObjectID = new SelectList(db.InventaryObjects, "InventaryObjectID", "EtiquetteAtento", location.InventaryObjectID);
            ViewBag.PlatformID = new SelectList(db.Platforms, "PlatformID", "Name", location.PlatformID);
            ViewBag.RoomID = new SelectList(db.Rooms, "RoomID", "Description", location.RoomID);
            return View(location);
        }

        // GET: Locations/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Location location = db.Locations.Find(id);
            if (location == null)
            {
                return HttpNotFound();
            }
            return View(location);
        }

        // POST: Locations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Location location = db.Locations.Find(id);
            db.Locations.Remove(location);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
