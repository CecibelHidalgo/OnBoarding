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
    public class OBTAspectoTecnicoController : ApiController
    {
        private dbProyectoOnboardingEntities db = new dbProyectoOnboardingEntities();
        [AllowAnonymous]
        // GET: api/OBTAspectoTecnico
        public IQueryable<OBTAspectoTecnico> GetOBTAspectoTecnico()
        {
            return db.OBTAspectoTecnico;
        }


        //// lista los aspectos tecnicos

        // GET: api/OBTRecurso/LIstar
        [Route("api/AspectoTecnico/Listar")]
        [HttpGet]
        public HttpResponseMessage Listar()
        {

            try
            {
                db.Configuration.LazyLoadingEnabled = false;
                db.Configuration.ProxyCreationEnabled = false;


                var entidadstL = (from aspetoTecnico in db.OBTAspectoTecnico
                                  where aspetoTecnico.Eliminado == false && aspetoTecnico.Activo == true

                                  select new
                                  {
                                      aspetoTecnico.CodigoAspectoTecnico,
                                      aspetoTecnico.NombreAspectoTecnico 
                                      
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


    


        // GET: api/OBTAspectoTecnico/5
        [ResponseType(typeof(OBTAspectoTecnico))]
        public IHttpActionResult GetOBTAspectoTecnico(int id)
        {
            OBTAspectoTecnico oBTAspectoTecnico = db.OBTAspectoTecnico.Find(id);
            if (oBTAspectoTecnico == null)
            {
                return NotFound();
            }

            return Ok(oBTAspectoTecnico);
        }

        // PUT: api/OBTAspectoTecnico/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutOBTAspectoTecnico(int id, OBTAspectoTecnico oBTAspectoTecnico)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != oBTAspectoTecnico.CodigoAspectoTecnico)
            {
                return BadRequest();
            }

            db.Entry(oBTAspectoTecnico).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OBTAspectoTecnicoExists(id))
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

        // POST: api/OBTAspectoTecnico
        [ResponseType(typeof(OBTAspectoTecnico))]
        public IHttpActionResult PostOBTAspectoTecnico(OBTAspectoTecnico oBTAspectoTecnico)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.OBTAspectoTecnico.Add(oBTAspectoTecnico);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = oBTAspectoTecnico.CodigoAspectoTecnico }, oBTAspectoTecnico);
        }

        // DELETE: api/OBTAspectoTecnico/5
        [ResponseType(typeof(OBTAspectoTecnico))]
        public IHttpActionResult DeleteOBTAspectoTecnico(int id)
        {
            OBTAspectoTecnico oBTAspectoTecnico = db.OBTAspectoTecnico.Find(id);
            if (oBTAspectoTecnico == null)
            {
                return NotFound();
            }

            db.OBTAspectoTecnico.Remove(oBTAspectoTecnico);
            db.SaveChanges();

            return Ok(oBTAspectoTecnico);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool OBTAspectoTecnicoExists(int id)
        {
            return db.OBTAspectoTecnico.Count(e => e.CodigoAspectoTecnico == id) > 0;
        }
    }
}