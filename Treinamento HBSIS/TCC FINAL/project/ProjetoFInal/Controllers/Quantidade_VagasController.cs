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
    public class Quantidade_VagasController : ApiController
    {
        private BaseDeDados db = new BaseDeDados();

        // GET: api/Quantidade_Vagas
        public IQueryable<Quantidade_Vaga> GetQuantidade_Vagas()
        {
            return db.Quantidade_Vagas;
        }

        // GET: api/Quantidade_Vagas/5
        [ResponseType(typeof(Quantidade_Vaga))]
        public async Task<IHttpActionResult> GetQuantidade_Vaga(int id)
        {
            Quantidade_Vaga quantidade_Vaga = await db.Quantidade_Vagas.FindAsync(id);
            if (quantidade_Vaga == null)
            {
                return NotFound();
            }

            return Ok(quantidade_Vaga);
        }

        // PUT: api/Quantidade_Vagas/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutQuantidade_Vaga(int id, Quantidade_Vaga quantidade_Vaga)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != quantidade_Vaga.Id)
            {
                return BadRequest();
            }

            db.Entry(quantidade_Vaga).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Quantidade_VagaExists(id))
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

        // POST: api/Quantidade_Vagas
        [ResponseType(typeof(Quantidade_Vaga))]
        public async Task<IHttpActionResult> PostQuantidade_Vaga(Quantidade_Vaga quantidade_Vaga)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Quantidade_Vagas.Add(quantidade_Vaga);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = quantidade_Vaga.Id }, quantidade_Vaga);
        }

        // DELETE: api/Quantidade_Vagas/5
        [ResponseType(typeof(Quantidade_Vaga))]
        public async Task<IHttpActionResult> DeleteQuantidade_Vaga(int id)
        {
            Quantidade_Vaga quantidade_Vaga = await db.Quantidade_Vagas.FindAsync(id);
            if (quantidade_Vaga == null)
            {
                return NotFound();
            }

            db.Quantidade_Vagas.Remove(quantidade_Vaga);
            await db.SaveChangesAsync();

            return Ok(quantidade_Vaga);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Quantidade_VagaExists(int id)
        {
            return db.Quantidade_Vagas.Count(e => e.Id == id) > 0;
        }
    }
}