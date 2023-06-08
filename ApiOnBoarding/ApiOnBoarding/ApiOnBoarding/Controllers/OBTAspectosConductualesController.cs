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
using System.Web.Http.Cors;

namespace ApiOnBoarding.Controllers
{
    [EnableCors("*", "*", "*")]
    public class OBTAspectosConductualesController : ApiController
    {
        private dbProyectoOnboardingEntities db = new dbProyectoOnboardingEntities();

        [AllowAnonymous]
        // GET: api/OBTAspectosConductuales
        public IQueryable<OBTAspectosConductuales> GetOBTAspectosConductuales()
        {
            return db.OBTAspectosConductuales;
        }


        //// lista los aspectos conductuales

        // GET: api/OBTRecurso/LIstar
        [Route("api/AspectoConductual/Listar")]
        [HttpGet]
        public HttpResponseMessage Listar()
        {

            try
            {
                db.Configuration.LazyLoadingEnabled = false;
                db.Configuration.ProxyCreationEnabled = false;


                var entidadstL = (from aspetoConductual in db.OBTAspectosConductuales
                                  where aspetoConductual.Eliminado == false && aspetoConductual.Activo == true
                                  
                                  select new
                                  {
                                      aspetoConductual.CodigoWill,
                                      aspetoConductual.NombreWill,
                                      aspetoConductual.Descripcion,
                                      aspetoConductual.Peso
                                  }).ToList();

                if (entidadstL != null && entidadstL.Count() > 0)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, entidadstL);
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound);
                }


            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.GetBaseException().Message);
            }


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