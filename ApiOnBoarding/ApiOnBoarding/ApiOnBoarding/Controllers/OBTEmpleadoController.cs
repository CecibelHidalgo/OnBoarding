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
    public class OBTEmpleadoController : ApiController
    {
        private dbProyectoOnboardingEntities db = new dbProyectoOnboardingEntities();

        [AllowAnonymous]
        // GET: api/OBTEmpleado
        public IQueryable<OBTEmpleado> GetOBTEmpleado()
        {
            return db.OBTEmpleado;
        }

        // lista todos los empleados

        [Route("api/Empleado/Listar")]
        [HttpGet]
        public HttpResponseMessage Listar()
        {

            try
            {
                db.Configuration.LazyLoadingEnabled = false;
                db.Configuration.ProxyCreationEnabled = false;


                var entidadstL = (from empleado in db.OBTEmpleado
                                  where empleado.Eliminado == false && empleado.Activo == true
                                  join puesto in db.OBTPuesto 
                                  on empleado.CodigoPuesto equals puesto.CodigoPuesto
                                  where puesto.Activo ==true && puesto.Eliminado==false
                                  join area in db.OBTArea
                                  on empleado.CodigoArea  equals area.CodigoArea
                                  where area.Activo == true && area.Eliminado == false

                                  select new
                                  {   empleado.CodigoEmpleado,
                                      NombreEmpleado = (empleado.NombreEmpleado == null ? "" : empleado.NombreEmpleado) + " " +
                                          (empleado.ApellidoEmpleado == null ? "" : empleado.ApellidoEmpleado),
                                      empleado.CodigoPuesto,    
                                      puesto.NombrePuesto,
                                      empleado.CodigoArea,
                                      area.NombreArea

                                         
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




        // GET: api/OBTEmpleado/5
        [ResponseType(typeof(OBTEmpleado))]
        public IHttpActionResult GetOBTEmpleado(int id)
        {
            OBTEmpleado oBTEmpleado = db.OBTEmpleado.Find(id);
            if (oBTEmpleado == null)
            {
                return NotFound();
            }

            return Ok(oBTEmpleado);
        }

        // PUT: api/OBTEmpleado/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutOBTEmpleado(int id, OBTEmpleado oBTEmpleado)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != oBTEmpleado.CodigoEmpleado)
            {
                return BadRequest();
            }

            db.Entry(oBTEmpleado).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OBTEmpleadoExists(id))
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

        // POST: api/OBTEmpleado
        [ResponseType(typeof(OBTEmpleado))]
        public IHttpActionResult PostOBTEmpleado(OBTEmpleado oBTEmpleado)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.OBTEmpleado.Add(oBTEmpleado);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = oBTEmpleado.CodigoEmpleado }, oBTEmpleado);
        }

        // DELETE: api/OBTEmpleado/5
        [ResponseType(typeof(OBTEmpleado))]
        public IHttpActionResult DeleteOBTEmpleado(int id)
        {
            OBTEmpleado oBTEmpleado = db.OBTEmpleado.Find(id);
            if (oBTEmpleado == null)
            {
                return NotFound();
            }

            db.OBTEmpleado.Remove(oBTEmpleado);
            db.SaveChanges();

            return Ok(oBTEmpleado);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool OBTEmpleadoExists(int id)
        {
            return db.OBTEmpleado.Count(e => e.CodigoEmpleado == id) > 0;
        }
    }
}