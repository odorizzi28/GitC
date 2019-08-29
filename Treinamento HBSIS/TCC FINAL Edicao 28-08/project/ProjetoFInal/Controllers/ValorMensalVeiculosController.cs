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
    public class ValorMensalVeiculosController : ApiController
    {
        private BaseDeDados db = new BaseDeDados();

        // GET: api/ValorMensalVeiculos
        public IQueryable<ValorMensalVeiculo> GetValorMensals()
        {
            return db.ValorMensals;
        }

        // GET: api/ValorMensalVeiculos/5
        [ResponseType(typeof(ValorMensalVeiculo))]
        public async Task<IHttpActionResult> GetValorMensalVeiculo(int id)
        {
            ValorMensalVeiculo valorMensalVeiculo = await db.ValorMensals.FindAsync(id);
            if (valorMensalVeiculo == null)
            {
                return NotFound();
            }

            return Ok(valorMensalVeiculo);
        }

        // PUT: api/ValorMensalVeiculos/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutValorMensalVeiculo(int id, ValorMensalVeiculo valorMensalVeiculo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != valorMensalVeiculo.Id)
            {
                return BadRequest();
            }

            db.Entry(valorMensalVeiculo).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ValorMensalVeiculoExists(id))
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

        // POST: api/ValorMensalVeiculos
        [ResponseType(typeof(ValorMensalVeiculo))]
        public async Task<IHttpActionResult> PostValorMensalVeiculo(ValorMensalVeiculo valorMensalVeiculo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.ValorMensals.Add(valorMensalVeiculo);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = valorMensalVeiculo.Id }, valorMensalVeiculo);
        }

        // DELETE: api/ValorMensalVeiculos/5
        [ResponseType(typeof(ValorMensalVeiculo))]
        public async Task<IHttpActionResult> DeleteValorMensalVeiculo(int id)
        {
            ValorMensalVeiculo valorMensalVeiculo = await db.ValorMensals.FindAsync(id);
            if (valorMensalVeiculo == null)
            {
                return NotFound();
            }

            db.ValorMensals.Remove(valorMensalVeiculo);
            await db.SaveChangesAsync();

            return Ok(valorMensalVeiculo);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ValorMensalVeiculoExists(int id)
        {
            return db.ValorMensals.Count(e => e.Id == id) > 0;
        }
    }
}