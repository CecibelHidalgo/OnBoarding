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
    public class OBTRecursoController : ApiController
    {
        private dbProyectoOnboardingEntities db = new dbProyectoOnboardingEntities();

        [AllowAnonymous]
        // GET: api/OBTRecurso
        public IQueryable<OBTRecurso> GetOBTRecurso()
        {
            return db.OBTRecurso;
        }


        [AllowAnonymous]

        //// lista los recursos asociados al empleado

        // GET: api/OBTRecurso/LIstar
        [Route("api/Recurso/Listar")]
        [HttpGet]
        public HttpResponseMessage Listar()
        {

            try
            {
                db.Configuration.LazyLoadingEnabled = false;
                db.Configuration.ProxyCreationEnabled = false;

            
                var entidadstL = (from recurso in db.OBTRecurso
                                   where recurso.Eliminado == false && recurso.Activo == true
                                   join empleado in db.OBTEmpleado
                                   on recurso.CodigoEmpleado equals empleado.CodigoEmpleado
                                  where empleado.Eliminado == false && empleado.Activo == true
                                  select new
                                  {
                                      recurso.CodigoRecurso,
                                      recurso.NombreRecurso,
                                      recurso.CodigoEmpleado,
                                      NombreEmpleado = (empleado.NombreEmpleado == null ? "" : empleado.NombreEmpleado) + " " +
                                          (empleado.ApellidoEmpleado == null ? "" : empleado.ApellidoEmpleado) 
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



        // GET: api/OBTRecurso/2
        [ResponseType(typeof(OBTRecurso))]
        public IHttpActionResult GetOBTRecurso(int id)
        {
            OBTRecurso oBTRecurso = db.OBTRecurso.Find(id);
            if (oBTRecurso == null)
            {
                return NotFound();
            }

            return Ok(oBTRecurso);
        }


        

        // PUT: api/OBTRecurso/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutOBTRecurso(int id, OBTRecurso oBTRecurso)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != oBTRecurso.CodigoRecurso)
            {
                return BadRequest();
            }

            db.Entry(oBTRecurso).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OBTRecursoExists(id))
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

        // POST: api/OBTRecurso
        [ResponseType(typeof(OBTRecurso))]
        public IHttpActionResult PostOBTRecurso(OBTRecurso oBTRecurso)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.OBTRecurso.Add(oBTRecurso);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = oBTRecurso.CodigoRecurso }, oBTRecurso);
        }

        // DELETE: api/OBTRecurso/5
        [ResponseType(typeof(OBTRecurso))]
        public IHttpActionResult DeleteOBTRecurso(int id)
        {
            OBTRecurso oBTRecurso = db.OBTRecurso.Find(id);
            if (oBTRecurso == null)
            {
                return NotFound();
            }

            db.OBTRecurso.Remove(oBTRecurso);
            db.SaveChanges();

            return Ok(oBTRecurso);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool OBTRecursoExists(int id)
        {
            return db.OBTRecurso.Count(e => e.CodigoRecurso == id) > 0;
        }
    }
}