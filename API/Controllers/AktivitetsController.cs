using Persistence;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System;
using Domain;

namespace API.Controllers
{
    public class AktivitetsController : BaseAPIController
    {
        private readonly DataContext context;
        public AktivitetsController(DataContext context)
        {
            this.context = context;
        }

        [HttpGet]

        public async Task<ActionResult<List<Aktiviteter>>> GetAktiviteter()
        {
            return await this.context.Aktiviteters.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Aktiviteter>> GetAktivitet(Guid id)
        {
            return await this.context.Aktiviteters.FindAsync(id);
        }
    }
}