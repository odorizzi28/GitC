using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using ProjetoFInal.Models;

namespace ProjetoFInal.Controllers
{
    public class TermosDeUsosController : ApiController
    {
        private BaseDeDados db = new BaseDeDados();

        // GET: api/TermosDeUsos
        public IQueryable<TermosDeUso> GetTermosDeUsos()
        {
            return db.TermosDeUsos;
        }

        // GET: api/TermosDeUsos/5
        [ResponseType(typeof(TermosDeUso))]
        public async Task<IHttpActionResult> GetTermosDeUso(int id)
        {
            TermosDeUso termosDeUso = await db.TermosDeUsos.FindAsync(id);
            if (termosDeUso == null)
            {
                return NotFound();
            }

            return Ok(termosDeUso);
        }

        // PUT: api/TermosDeUsos/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutTermosDeUso(int id, TermosDeUso termosDeUso)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != termosDeUso.Id)
            {
                return BadRequest();
            }


            db.Entry(termosDeUso).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TermosDeUsoExists(id))
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

        // POST: api/TermosDeUsos
        [ResponseType(typeof(TermosDeUso))]
        public async Task<IHttpActionResult> PostTermosDeUso(TermosDeUso termosDeUso)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            
            db.TermosDeUsos.Add(termosDeUso);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = termosDeUso.Id }, termosDeUso);
        }

        // DELETE: api/TermosDeUsos/5
        [ResponseType(typeof(TermosDeUso))]
        public async Task<IHttpActionResult> DeleteTermosDeUso(int id)
        {
            TermosDeUso termosDeUso = await db.TermosDeUsos.FindAsync(id);
            if (termosDeUso == null)
            {
                return NotFound();
            }

            db.TermosDeUsos.Remove(termosDeUso);
            await db.SaveChangesAsync();

            return Ok(termosDeUso);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TermosDeUsoExists(int id)
        {
            return db.TermosDeUsos.Count(e => e.Id == id) > 0;
        }
    }
}