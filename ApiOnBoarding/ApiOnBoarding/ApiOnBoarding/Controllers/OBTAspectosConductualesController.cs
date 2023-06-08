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
    public class OBTAspectosConductualesController : ApiController
    {
        private dbProyectoOnboardingEntities db = new dbProyectoOnboardingEntities();

        [AllowAnonymous]
        // GET: api/OBTAspectosConductuales
        public IQueryable<OBTAspectosConductuales> GetOBTAspectosConductuales()
        {
            return db.OBTAspectosConductuales;
        }

        // GET: api/OBTAspectosConductuales/5
        [ResponseType(typeof(OBTAspectosConductuales))]
        public IHttpActionResult GetOBTAspectosConductuales(int id)
        {
            OBTAspectosConductuales oBTAspectosConductuales = db.OBTAspectosConductuales.Find(id);
            if (oBTAspectosConductuales == null)
            {
                return NotFound();
            }

            return Ok(oBTAspectosConductuales);
        }

        // PUT: api/OBTAspectosConductuales/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutOBTAspectosConductuales(int id, OBTAspectosConductuales oBTAspectosConductuales)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != oBTAspectosConductuales.CodigoWill)
            {
                return BadRequest();
            }

            db.Entry(oBTAspectosConductuales).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OBTAspectosConductualesExists(id))
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

        // POST: api/OBTAspectosConductuales
        [ResponseType(typeof(OBTAspectosConductuales))]
        public IHttpActionResult PostOBTAspectosConductuales(OBTAspectosConductuales oBTAspectosConductuales)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.OBTAspectosConductuales.Add(oBTAspectosConductuales);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = oBTAspectosConductuales.CodigoWill }, oBTAspectosConductuales);
        }

        // DELETE: api/OBTAspectosConductuales/5
        [ResponseType(typeof(OBTAspectosConductuales))]
        public IHttpActionResult DeleteOBTAspectosConductuales(int id)
        {
            OBTAspectosConductuales oBTAspectosConductuales = db.OBTAspectosConductuales.Find(id);
            if (oBTAspectosConductuales == null)
            {
                return NotFound();
            }

            db.OBTAspectosConductuales.Remove(oBTAspectosConductuales);
            db.SaveChanges();

            return Ok(oBTAspectosConductuales);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool OBTAspectosConductualesExists(int id)
        {
            return db.OBTAspectosConductuales.Count(e => e.CodigoWill == id) > 0;
        }
    }
}