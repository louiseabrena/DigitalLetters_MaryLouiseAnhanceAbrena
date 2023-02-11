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
    public class RecieversController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: api/Recievers/ListReceivers
        [HttpGet]
        public IQueryable<Reciever> ListReceivers()
        {
            return db.Receivers;
        }

        // FIND: api/Recievers/FindReciever/5
        [ResponseType(typeof(Reciever))]
        [HttpGet]
        public IHttpActionResult FindReciever(int id)
        {
            Reciever reciever = db.Receivers.Find(id);
            if (reciever == null)
            {
                return NotFound();
            }

            return Ok(reciever);
        }

        // PUT: api/Recievers/UpdateReciever/5
        [HttpPost]
        [ResponseType(typeof(void))]
        public IHttpActionResult UpdateReciever(int id, Reciever reciever)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != reciever.MessageReceiveId)
            {
                return BadRequest();
            }

            db.Entry(reciever).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RecieverExists(id))
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

        // POST: api/Recievers/AddReciever
        [ResponseType(typeof(Reciever))]
        [HttpPost]
        public IHttpActionResult AddReciever(Reciever reciever)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Receivers.Add(reciever);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = reciever.MessageReceiveId }, reciever);
        }

        // DELETE: api/Recievers/DeleteReciever/5
        [ResponseType(typeof(Reciever))]
        [HttpPost]
        public IHttpActionResult DeleteReciever(int id)
        {
            Reciever reciever = db.Receivers.Find(id);
            if (reciever == null)
            {
                return NotFound();
            }

            db.Receivers.Remove(reciever);
            db.SaveChanges();

            return Ok(reciever);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool RecieverExists(int id)
        {
            return db.Receivers.Count(e => e.MessageReceiveId == id) > 0;
        }
    }
}