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
using System.Xml;
using ESupplierBusiness.Models;
using Newtonsoft.Json;

namespace ESupplierBusiness.Controllers
{
    public class WinnersController : ApiController
    {
        private esupplierEntities db = new esupplierEntities();

        // GET: api/Winners
        public IQueryable<Winners> GetWinners()
        {
            System.Diagnostics.Debug.WriteLine($" - [GET] winners/");
            return db.Winners;
        }

        // GET: api/Winners/5
        [ResponseType(typeof(Winners))]
        public IHttpActionResult GetWinners(int id)
        {
            Winners winners = db.Winners.Find(id);
            if (winners == null)
            {
                return NotFound();
            }

            return Ok(winners);
        }

        // PUT: api/Winners/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutWinners(int id, Winners winners)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != winners.document)
            {
                return BadRequest();
            }

            db.Entry(winners).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WinnersExists(id))
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

        // POST: api/Winners
        [ResponseType(typeof(Winners))]
        public IHttpActionResult PostWinners(Winners winners)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Winners.Add(winners);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (WinnersExists(winners.document))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = winners.document }, winners);
        }

        // DELETE: api/Winners/5
        [ResponseType(typeof(Winners))]
        public IHttpActionResult DeleteWinners(int id)
        {
            Winners winners = db.Winners.Find(id);
            if (winners == null)
            {
                return NotFound();
            }

            db.Winners.Remove(winners);
            db.SaveChanges();

            return Ok(winners);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool WinnersExists(int id)
        {
            return db.Winners.Count(e => e.document == id) > 0;
        }
    }
}