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
    public class OBTDetalleAspectosController : ApiController
    {
        private dbProyectoOnboardingEntities db = new dbProyectoOnboardingEntities();

        [AllowAnonymous]
        // GET: api/OBTDetalleAspectos
        public IQueryable<OBTDetalleAspectos> GetOBTDetalleAspectos()
        {
            return db.OBTDetalleAspectos;
        }


        // lista el detalle de los aspectos (técnicos y Conceptuales) que estan asociados

        [Route("api/DetalleAspecto/ListarDetalle")]
        [HttpGet]
        public HttpResponseMessage ListarDetalle()
        {

            try
            {
                db.Configuration.LazyLoadingEnabled = false;
                db.Configuration.ProxyCreationEnabled = false;


                var entidadstL = (from detalleAspectos in db.OBTDetalleAspectos
                                  where detalleAspectos.Eliminado == false && detalleAspectos.Activo == true
                                  join  empleado in db.OBTEmpleado
                                  on detalleAspectos.CodigoEmpleado equals empleado.CodigoEmpleado
                                  where empleado.Eliminado == false && empleado.Activo == true
                                  join puesto in db.OBTPuesto
                                  on empleado.CodigoPuesto equals puesto.CodigoPuesto
                                  where puesto.Activo == true && puesto.Eliminado == false
                                  join area in db.OBTArea
                                  on empleado.CodigoArea equals area.CodigoArea
                                  where area.Activo == true && area.Eliminado == false
                                  join aspectoTecnico in db.OBTAspectoTecnico
                                  on detalleAspectos.CodigoAspectoTecnico equals aspectoTecnico.CodigoAspectoTecnico
                                  where detalleAspectos.Activo == true && detalleAspectos.Eliminado == false
                                  join aspectoTecnicoActividad in db.OBTAspectoTecnicoActividad
                                  on detalleAspectos.CodigoAspectoTecnico equals aspectoTecnicoActividad.CodigoAspectoTecnico
                                  where aspectoTecnicoActividad.Activo == true && aspectoTecnicoActividad.Eliminado == false
                                  join aspectoConductual in db.OBTAspectosConductuales
                                  on detalleAspectos.CodigoWill equals aspectoConductual.CodigoWill
                                  where aspectoConductual.Activo == true && aspectoConductual.Eliminado == false


                                  select new
                                  {
                                      empleado.CodigoEmpleado,
                                      NombreEmpleado = (empleado.NombreEmpleado == null ? "" : empleado.NombreEmpleado) + " " +
                                          (empleado.ApellidoEmpleado == null ? "" : empleado.ApellidoEmpleado),
                                      area.NombreArea,
                                      puesto.NombrePuesto,
                                      aspectoTecnico.NombreAspectoTecnico,
                                      aspectoTecnicoActividad.NombreActividad,
                                      aspectoConductual.NombreWill,
                                      aspectoConductual.Descripcion,
                                      aspectoConductual.Peso
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