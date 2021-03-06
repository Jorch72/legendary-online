﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LegendaryOnline.Data.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LegendaryOnline.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HeroController : ControllerBase
    {
        // GET: api/Hero
        [HttpGet]
        public IEnumerable<string> Get(HeroDbContext dbContext)
        {
            return dbContext.Heroes.Select(x => x.Name);
        }

        // GET: api/Hero/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Hero
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Hero/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
