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
    public class PeriodoLocacoesController : ApiController
    {
        private BaseDeDados db = new BaseDeDados();

        [Route("Api/PeriodoLocacoes/{TipoVeiculo}")]
        [HttpGet]
        public IEnumerable<PeriodoLocacao> ObterPeriodoLocacaoTIPOVEICULO(int TipoVeiculo)
        {

            return db.PeriodoLocacaos.Where(x => x.TipoVeiculo == TipoVeiculo);
        }

        [Route("Api/PeriodoLocacoes/TipoVeiculo/{Status}")]
        [HttpGet]
        public IEnumerable<PeriodoLocacao> ObterStatus( int TipoVeiculo, int Status)
        {

            return db.PeriodoLocacaos.Where(x => x.TipoVeiculo == TipoVeiculo && x.Status == Status);
        }


        [Route("Api/DisponibilidadePorVeiculo/{TipoVeiculo}")]
        [HttpGet]
        public IQueryable<PeriodoLocacao> Locacaos(int TipoVeiculo)
        {
            return db.PeriodoLocacaos.Where(x => x.TipoVeiculo == TipoVeiculo && x.DataFinal > DateTime.Now);
        }

        // GET: api/PeriodoLocacoes
        public IQueryable<PeriodoLocacao> GetPeriodoLocacaos()
        {
            return db.PeriodoLocacaos;
        }

        // GET: api/PeriodoLocacoes/5
        [ResponseType(typeof(PeriodoLocacao))]
        public async Task<IHttpActionResult> GetPeriodoLocacao(int id)
        {
            PeriodoLocacao periodoLocacao = await db.PeriodoLocacaos.FindAsync(id);
            if (periodoLocacao == null)
            {
                return NotFound();
            }

            return Ok(periodoLocacao);
        }

        // PUT: api/PeriodoLocacoes/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutPeriodoLocacao(int id, PeriodoLocacao periodoLocacao)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != periodoLocacao.Id)
            {
                return BadRequest();
            }

            db.Entry(periodoLocacao).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PeriodoLocacaoExists(id))
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

        // POST: api/PeriodoLocacoes
        [ResponseType(typeof(PeriodoLocacao))]
        public async Task<IHttpActionResult> PostPeriodoLocacao(PeriodoLocacao periodoLocacao)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.PeriodoLocacaos.Add(periodoLocacao);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = periodoLocacao.Id }, periodoLocacao);
        }

        // DELETE: api/PeriodoLocacoes/5
        [ResponseType(typeof(PeriodoLocacao))]
        public async Task<IHttpActionResult> DeletePeriodoLocacao(int id)
        {
            PeriodoLocacao periodoLocacao = await db.PeriodoLocacaos.FindAsync(id);
            if (periodoLocacao == null)
            {
                return NotFound();
            }

            db.PeriodoLocacaos.Remove(periodoLocacao);
            await db.SaveChangesAsync();

            return Ok(periodoLocacao);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PeriodoLocacaoExists(int id)
        {
            return db.PeriodoLocacaos.Count(e => e.Id == id) > 0;
        }
    }
}