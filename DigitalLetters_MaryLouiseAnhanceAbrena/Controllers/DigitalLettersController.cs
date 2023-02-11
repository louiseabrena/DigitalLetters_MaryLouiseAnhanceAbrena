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
using DigitalLetters_MaryLouiseAnhanceAbrena.Models;

namespace DigitalLetters_MaryLouiseAnhanceAbrena.Controllers
{
    public class DigitalLettersController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: api/DigitalLetters/ListLetters
        [HttpGet]
        public IQueryable<DigitalLetters> ListLetters()
        {
            return db.Letters;
        }

        // FIND: api/DigitalLetters/FindLetters/5
        [ResponseType(typeof(DigitalLetters))]
        [HttpGet]
        public IHttpActionResult FindDigitalLetters(int id)
        {
            DigitalLetters digitalLetters = db.Letters.Find(id);
            if (digitalLetters == null)
            {
                return NotFound();
            }

            return Ok(digitalLetters);
        }

        // UPDATE: api/DigitalLetters/UpdateDigitalLetters/5
        [ResponseType(typeof(void))]
        [HttpPost]
        public IHttpActionResult UpdateDigitalLetters(int id, DigitalLetters digitalLetters)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != digitalLetters.LetterId)
            {
                return BadRequest();
            }

            db.Entry(digitalLetters).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DigitalLettersExists(id))
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

        // POST: api/DigitalLetters/AddDigitalLetters
        [ResponseType(typeof(DigitalLetters))]
        [HttpPost]
        public IHttpActionResult AddDigitalLetters(DigitalLetters digitalLetters)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Letters.Add(digitalLetters);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = digitalLetters.LetterId }, digitalLetters);
        }

        // DELETE: api/DigitalLetters/DeleteDigitalLetters/5
        [ResponseType(typeof(DigitalLetters))]
        [HttpPost]
        public IHttpActionResult DeleteDigitalLetters(int id)
        {
            DigitalLetters digitalLetters = db.Letters.Find(id);
            if (digitalLetters == null)
            {
                return NotFound();
            }

            db.Letters.Remove(digitalLetters);
            db.SaveChanges();

            return Ok(digitalLetters);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool DigitalLettersExists(int id)
        {
            return db.Letters.Count(e => e.LetterId == id) > 0;
        }
    }
}