using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using InventarioSoporteAtentoArg.Models;

namespace InventarioSoporteAtentoArg.Controllers
{
    public class ObjectTypesAPIController : ApiController
    {
        private InventarioSoporteAtentoArgContext db = new InventarioSoporteAtentoArgContext();

        // GET: api/ObjectTypesAPI
        public IQueryable<ObjectType> GetObjectTypes()
        {
            return db.ObjectTypes;
        }

        // GET: api/ObjectTypesAPI/5
        [ResponseType(typeof(ObjectType))]
        public IHttpActionResult GetObjectType(int id)
        {
            ObjectType objectType = db.ObjectTypes.Find(id);
            if (objectType == null)
            {
                return NotFound();
            }

            return Ok(objectType);
        }

        // PUT: api/ObjectTypesAPI/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutObjectType(int id, ObjectType objectType)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != objectType.objectTypeID)
            {
                return BadRequest();
            }

            db.Entry(objectType).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ObjectTypeExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/ObjectTypesAPI
        [ResponseType(typeof(ObjectType))]
        public IHttpActionResult PostObjectType(ObjectType objectType)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.ObjectTypes.Add(objectType);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = objectType.objectTypeID }, objectType);
        }

        // DELETE: api/ObjectTypesAPI/5
        [ResponseType(typeof(ObjectType))]
        public IHttpActionResult DeleteObjectType(int id)
        {
            ObjectType objectType = db.ObjectTypes.Find(id);
            if (objectType == null)
            {
                return NotFound();
            }

            db.ObjectTypes.Remove(objectType);
            db.SaveChanges();

            return Ok(objectType);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ObjectTypeExists(int id)
        {
            return db.ObjectTypes.Count(e => e.objectTypeID == id) > 0;
        }
    }
}