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
using pxLiveApi.Models;

namespace pxLiveApi.Controllers
{
    public class CurrentTracksController : ApiController
    {
        private pxLiveApiContext db = new pxLiveApiContext();

        // GET: api/CurrentTracks
        public IQueryable<CurrentTrack> GetCurrentTracks()
        {
            return db.CurrentTracks;
        }

        // GET: api/CurrentTracks/5
        [ResponseType(typeof(CurrentTrack))]
        public IHttpActionResult GetCurrentTrack(int id)
        {
            CurrentTrack currentTrack = db.CurrentTracks.Find(id);
            if (currentTrack == null)
            {
                return NotFound();
            }

            return Ok(currentTrack);
        }

        // PUT: api/CurrentTracks/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCurrentTrack(int id, CurrentTrack currentTrack)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != currentTrack.Id)
            {
                return BadRequest();
            }

            db.Entry(currentTrack).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CurrentTrackExists(id))
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

        // POST: api/CurrentTracks
        [ResponseType(typeof(CurrentTrack))]
        public IHttpActionResult PostCurrentTrack(CurrentTrack currentTrack)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.CurrentTracks.Add(currentTrack);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = currentTrack.Id }, currentTrack);
        }

        // DELETE: api/CurrentTracks/5
        [ResponseType(typeof(CurrentTrack))]
        public IHttpActionResult DeleteCurrentTrack(int id)
        {
            CurrentTrack currentTrack = db.CurrentTracks.Find(id);
            if (currentTrack == null)
            {
                return NotFound();
            }

            db.CurrentTracks.Remove(currentTrack);
            db.SaveChanges();

            return Ok(currentTrack);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CurrentTrackExists(int id)
        {
            return db.CurrentTracks.Count(e => e.Id == id) > 0;
        }
    }
}