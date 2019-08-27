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
    public class VeiculosController : ApiController
    {
        private BaseDeDados db = new BaseDeDados();

        // GET: api/Veiculos
        public IQueryable<Veiculo> GetVeiculos()
        {
            return db.Veiculos;
        }

        // GET: api/Veiculos/5
        [ResponseType(typeof(Veiculo))]
        public async Task<IHttpActionResult> GetVeiculo(string id)
        {
            Veiculo veiculo = await db.Veiculos.FindAsync(id);
            if (veiculo == null)
            {
                return NotFound();
            }

            return Ok(veiculo);
        }

        // PUT: api/Veiculos/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutVeiculo(string id, Veiculo veiculo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != veiculo.Usuario)
            {
                return BadRequest();
            }

            db.Entry(veiculo).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VeiculoExists(id))
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

        // POST: api/Veiculos
        [ResponseType(typeof(Veiculo))]
        public async Task<IHttpActionResult> PostVeiculo(Veiculo veiculo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Veiculos.Add(veiculo);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (VeiculoExists(veiculo.Usuario))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = veiculo.Usuario }, veiculo);
        }

        // DELETE: api/Veiculos/5
        [ResponseType(typeof(Veiculo))]
        public async Task<IHttpActionResult> DeleteVeiculo(string id)
        {
            Veiculo veiculo = await db.Veiculos.FindAsync(id);
            if (veiculo == null)
            {
                return NotFound();
            }

            db.Veiculos.Remove(veiculo);
            await db.SaveChangesAsync();

            return Ok(veiculo);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool VeiculoExists(string id)
        {
            return db.Veiculos.Count(e => e.Usuario == id) > 0;
        }
    }
}