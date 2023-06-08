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
using ApiOnBoarding.Models;

namespace ApiOnBoarding.Controllers
{
    public class OBTPuestoController : ApiController
    {
        private dbProyectoOnboardingEntities db = new dbProyectoOnboardingEntities();
        [AllowAnonymous]

        // GET: api/OBTPuesto
        public IQueryable<OBTPuesto> GetOBTPuesto()
        {
            return db.OBTPuesto;
        }

        // GET: api/OBTPuesto/5
        [ResponseType(typeof(OBTPuesto))]
        public IHttpActionResult GetOBTPuesto(int id)
        {
            OBTPuesto oBTPuesto = db.OBTPuesto.Find(id);
            if (oBTPuesto == null)
            {
                return NotFound();
            }

            return Ok(oBTPuesto);
        }

        // PUT: api/OBTPuesto/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutOBTPuesto(int id, OBTPuesto oBTPuesto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != oBTPuesto.CodigoPuesto)
            {
                return BadRequest();
            }

            db.Entry(oBTPuesto).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OBTPuestoExists(id))
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

        // POST: api/OBTPuesto
        [ResponseType(typeof(OBTPuesto))]
        public IHttpActionResult PostOBTPuesto(OBTPuesto oBTPuesto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.OBTPuesto.Add(oBTPuesto);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = oBTPuesto.CodigoPuesto }, oBTPuesto);
        }

        // DELETE: api/OBTPuesto/5
        [ResponseType(typeof(OBTPuesto))]
        public IHttpActionResult DeleteOBTPuesto(int id)
        {
            OBTPuesto oBTPuesto = db.OBTPuesto.Find(id);
            if (oBTPuesto == null)
            {
                return NotFound();
            }

            db.OBTPuesto.Remove(oBTPuesto);
            db.SaveChanges();

            return Ok(oBTPuesto);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool OBTPuestoExists(int id)
        {
            return db.OBTPuesto.Count(e => e.CodigoPuesto == id) > 0;
        }
    }
}