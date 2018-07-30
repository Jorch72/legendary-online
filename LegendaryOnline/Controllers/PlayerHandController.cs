using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LegendaryOnline.Data.Context;
using LegendaryOnline.Models.GameModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LegendaryOnline.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerHandController : ControllerBase
    {
        // GET: api/PlayerHand
        [HttpGet]
        public PlayerHand Get(HeroDbContext dbContext)
        {
            return new PlayerHand
            {
                Cards = dbContext.HeroCards.ToList()
            };
        }

        // GET: api/PlayerHand/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/PlayerHand
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/PlayerHand/5
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
