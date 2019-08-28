﻿using System;
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
using ExercicioFinalWEBAPI.Models;

namespace ExercicioFinalWEBAPI.Controllers
{
    public class ClientesController : ApiController
    {
        private ContextDB db = new ContextDB();

        // GET: api/Clientes
        public IQueryable<Cliente> Getclientes()
        {
            return db.clientes;
        }

        // GET: api/Clientes/5
        [ResponseType(typeof(Cliente))]
        public async Task<IHttpActionResult> GetCliente(int id)
        {
            Cliente cliente = await db.clientes.FindAsync(id);
            if (cliente == null)
            {
                return NotFound();
            }

            return Ok(cliente);
        }

        // PUT: api/Clientes/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutCliente(int id, Cliente cliente)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != cliente.Id)
            {
                return BadRequest();
            }

            db.Entry(cliente).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClienteExists(id))
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

        // POST: api/Clientes
        [ResponseType(typeof(Cliente))]
        public async Task<IHttpActionResult> PostCliente(Cliente cliente)
        {
            if (cliente.CPfouCNPJ.Length == 18 && cliente.NomeFantasia == null)

                return BadRequest("Nome fantasia nao pode ser nulo");

            if (!ModelState.IsValid)
            {
                if (ModelState.Keys.First().ToString() != "clientes.Id")
                    return BadRequest(ModelState);
            }

            db.clientes.Add(cliente);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = cliente.Id }, cliente);
        }
        // DELETE: api/Clientes/5
        [ResponseType(typeof(Cliente))]
        public async Task<IHttpActionResult> DeleteCliente(int id)
        {
            Cliente cliente = await db.clientes.FindAsync(id);
            if (cliente == null)
            {
                return NotFound();
            }
            db.clientes.Remove(cliente);
            await db.SaveChangesAsync();
            return Ok(cliente);
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ClienteExists(int id)
        {
            return db.clientes.Count(e => e.Id == id) > 0;
        }
    }
}