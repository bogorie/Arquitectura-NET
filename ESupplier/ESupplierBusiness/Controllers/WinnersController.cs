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
using ESupplierBusiness.Models;

namespace ESupplierBusiness.Controllers
{
    public class WINNERSController : ApiController
    {
        private Entities db = new Entities();

        // GET: api/WINNERS
        public IQueryable<WINNERS> GetWINNERS()
        {
            System.Diagnostics.Debug.WriteLine($" - [GET] winners/");
            return db.WINNERS;
        }

        // GET: api/WINNERS/5
        [ResponseType(typeof(WINNERS))]
        public IHttpActionResult GetWINNERS(decimal id)
        {
            WINNERS wINNERS = db.WINNERS.Find(id);
            if (wINNERS == null)
            {
                return NotFound();
            }

            return Ok(wINNERS);
        }

        // PUT: api/WINNERS/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutWINNERS(decimal id, WINNERS wINNERS)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != wINNERS.DOCUMENT)
            {
                return BadRequest();
            }

            db.Entry(wINNERS).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WINNERSExists(id))
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

        // POST: api/WINNERS
        [ResponseType(typeof(WINNERS))]
        public IHttpActionResult PostWINNERS(WINNERS wINNERS)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.WINNERS.Add(wINNERS);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (WINNERSExists(wINNERS.DOCUMENT))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = wINNERS.DOCUMENT }, wINNERS);
        }

        // DELETE: api/WINNERS/5
        [ResponseType(typeof(WINNERS))]
        public IHttpActionResult DeleteWINNERS(decimal id)
        {
            WINNERS wINNERS = db.WINNERS.Find(id);
            if (wINNERS == null)
            {
                return NotFound();
            }

            db.WINNERS.Remove(wINNERS);
            db.SaveChanges();

            return Ok(wINNERS);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool WINNERSExists(decimal id)
        {
            return db.WINNERS.Count(e => e.DOCUMENT == id) > 0;
        }
    }
}