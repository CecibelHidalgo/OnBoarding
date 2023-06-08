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
    public class OBTAreasController : ApiController
    {
        private dbProyectoOnboardingEntities db = new dbProyectoOnboardingEntities();

        [AllowAnonymous]
        // GET: api/OBTAreas
        public IQueryable<OBTArea> GetOBTArea()
        {
            return db.OBTArea;
        }

        // GET: api/OBTAreas/5
        [AllowAnonymous]
        [ResponseType(typeof(OBTArea))]
        public IHttpActionResult GetOBTArea(int id)
        {
            OBTArea oBTArea = db.OBTArea.Find(id);
            if (oBTArea == null)
            {
                return NotFound();
            }

            return Ok(oBTArea);
        }

        // PUT: api/OBTAreas/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutOBTArea(int id, OBTArea oBTArea)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != oBTArea.CodigoArea)
            {
                return BadRequest();
            }

            db.Entry(oBTArea).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OBTAreaExists(id))
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

        // POST: api/OBTAreas
        [ResponseType(typeof(OBTArea))]
        public IHttpActionResult PostOBTArea(OBTArea oBTArea)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.OBTArea.Add(oBTArea);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = oBTArea.CodigoArea }, oBTArea);
        }

        // DELETE: api/OBTAreas/5
        [ResponseType(typeof(OBTArea))]
        public IHttpActionResult DeleteOBTArea(int id)
        {
            OBTArea oBTArea = db.OBTArea.Find(id);
            if (oBTArea == null)
            {
                return NotFound();
            }

            db.OBTArea.Remove(oBTArea);
            db.SaveChanges();

            return Ok(oBTArea);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool OBTAreaExists(int id)
        {
            return db.OBTArea.Count(e => e.CodigoArea == id) > 0;
        }
    }
}