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
    public class SendersDataController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: api/SendersData/ListSenders
        [HttpGet]
        public IQueryable<Sender> ListSenders()
        {
            return db.Senders;
        }

        // FIND: api/SendersData/FindSender/5
        [ResponseType(typeof(Sender))]
        [HttpGet]
        public IHttpActionResult FindSender(int id)
        {
            Sender sender = db.Senders.Find(id);
            if (sender == null)
            {
                return NotFound();
            }

            return Ok(sender);
        }

        // UPDATE: api/SendersData/UpdateSender/5
        [ResponseType(typeof(void))]
        [HttpPost]
        public IHttpActionResult UpdateSender(int id, Sender sender)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != sender.MessageSentId)
            {
                return BadRequest();
            }

            db.Entry(sender).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SenderExists(id))
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

        // POST: api/SendersData/AddSender
        [ResponseType(typeof(Sender))]
        [HttpPost]
        public IHttpActionResult AddSender(Sender sender)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Senders.Add(sender);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", routeValues: new { id = sender.MessageSentId }, sender);
        }

        // DELETE: api/SendersData/DeleteSender/5
        [ResponseType(typeof(Sender))]
        [HttpPost]
        public IHttpActionResult DeleteSender(int id)
        {
            Sender sender = db.Senders.Find(id);
            if (sender == null)
            {
                return NotFound();
            }

            db.Senders.Remove(sender);
            db.SaveChanges();

            return Ok(sender);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool SenderExists(int id)
        {
            return db.Senders.Count(e => e.MessageSentId == id) > 0;
        }
    }
}