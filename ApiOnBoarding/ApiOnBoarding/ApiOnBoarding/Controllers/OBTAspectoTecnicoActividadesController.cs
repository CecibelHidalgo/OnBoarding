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
    public class OBTAspectoTecnicoActividadesController : ApiController
    {
        private dbProyectoOnboardingEntities db = new dbProyectoOnboardingEntities();
        [AllowAnonymous]
        // GET: api/OBTAspectoTecnicoActividades
        public IQueryable<OBTAspectoTecnicoActividad> GetOBTAspectoTecnicoActividad()
        {
            return db.OBTAspectoTecnicoActividad;
        }

        // GET: api/OBTAspectoTecnicoActividades/5
        [ResponseType(typeof(OBTAspectoTecnicoActividad))]
        public IHttpActionResult GetOBTAspectoTecnicoActividad(int id)
        {
            OBTAspectoTecnicoActividad oBTAspectoTecnicoActividad = db.OBTAspectoTecnicoActividad.Find(id);
            if (oBTAspectoTecnicoActividad == null)
            {
                return NotFound();
            }

            return Ok(oBTAspectoTecnicoActividad);
        }

        // PUT: api/OBTAspectoTecnicoActividades/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutOBTAspectoTecnicoActividad(int id, OBTAspectoTecnicoActividad oBTAspectoTecnicoActividad)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != oBTAspectoTecnicoActividad.CodigoAspectoTecnicoActividad)
            {
                return BadRequest();
            }

            db.Entry(oBTAspectoTecnicoActividad).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OBTAspectoTecnicoActividadExists(id))
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

        // POST: api/OBTAspectoTecnicoActividades
        [ResponseType(typeof(OBTAspectoTecnicoActividad))]
        public IHttpActionResult PostOBTAspectoTecnicoActividad(OBTAspectoTecnicoActividad oBTAspectoTecnicoActividad)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.OBTAspectoTecnicoActividad.Add(oBTAspectoTecnicoActividad);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = oBTAspectoTecnicoActividad.CodigoAspectoTecnicoActividad }, oBTAspectoTecnicoActividad);
        }

        // DELETE: api/OBTAspectoTecnicoActividades/5
        [ResponseType(typeof(OBTAspectoTecnicoActividad))]
        public IHttpActionResult DeleteOBTAspectoTecnicoActividad(int id)
        {
            OBTAspectoTecnicoActividad oBTAspectoTecnicoActividad = db.OBTAspectoTecnicoActividad.Find(id);
            if (oBTAspectoTecnicoActividad == null)
            {
                return NotFound();
            }

            db.OBTAspectoTecnicoActividad.Remove(oBTAspectoTecnicoActividad);
            db.SaveChanges();

            return Ok(oBTAspectoTecnicoActividad);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool OBTAspectoTecnicoActividadExists(int id)
        {
            return db.OBTAspectoTecnicoActividad.Count(e => e.CodigoAspectoTecnicoActividad == id) > 0;
        }
    }
}