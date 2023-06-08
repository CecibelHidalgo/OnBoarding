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
    public class OBTDetalleAspectosController : ApiController
    {
        private dbProyectoOnboardingEntities db = new dbProyectoOnboardingEntities();

        [AllowAnonymous]
        // GET: api/OBTDetalleAspectos
        public IQueryable<OBTDetalleAspectos> GetOBTDetalleAspectos()
        {
            return db.OBTDetalleAspectos;
        }

        // GET: api/OBTDetalleAspectos/5
        [ResponseType(typeof(OBTDetalleAspectos))]
        public IHttpActionResult GetOBTDetalleAspectos(int id)
        {
            OBTDetalleAspectos oBTDetalleAspectos = db.OBTDetalleAspectos.Find(id);
            if (oBTDetalleAspectos == null)
            {
                return NotFound();
            }

            return Ok(oBTDetalleAspectos);
        }

        // PUT: api/OBTDetalleAspectos/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutOBTDetalleAspectos(int id, OBTDetalleAspectos oBTDetalleAspectos)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != oBTDetalleAspectos.CodigoDetalle)
            {
                return BadRequest();
            }

            db.Entry(oBTDetalleAspectos).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OBTDetalleAspectosExists(id))
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

        // POST: api/OBTDetalleAspectos
        [ResponseType(typeof(OBTDetalleAspectos))]
        public IHttpActionResult PostOBTDetalleAspectos(OBTDetalleAspectos oBTDetalleAspectos)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.OBTDetalleAspectos.Add(oBTDetalleAspectos);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = oBTDetalleAspectos.CodigoDetalle }, oBTDetalleAspectos);
        }

        // DELETE: api/OBTDetalleAspectos/5
        [ResponseType(typeof(OBTDetalleAspectos))]
        public IHttpActionResult DeleteOBTDetalleAspectos(int id)
        {
            OBTDetalleAspectos oBTDetalleAspectos = db.OBTDetalleAspectos.Find(id);
            if (oBTDetalleAspectos == null)
            {
                return NotFound();
            }

            db.OBTDetalleAspectos.Remove(oBTDetalleAspectos);
            db.SaveChanges();

            return Ok(oBTDetalleAspectos);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool OBTDetalleAspectosExists(int id)
        {
            return db.OBTDetalleAspectos.Count(e => e.CodigoDetalle == id) > 0;
        }
    }
}