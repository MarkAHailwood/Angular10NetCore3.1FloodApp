using AngularCore3._1Weather.Models;
using AngularCore3._1Weather.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AngularCore3._1Weather.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FloodController : ControllerBase
    {
        public IHttpClientFactory HttpClientFactory { get; }
        public IFloodService FloodService { get; }

        public FloodController(IHttpClientFactory httpClientFactory, IFloodService floodService)
        {
            HttpClientFactory = httpClientFactory;
            FloodService = floodService;
        }
        
        // GET: api/<FloodController>
        [HttpGet]
        public async Task<ActionResult<List<FloodSummary>>> Get()
        {
            var floodResultSummary = await FloodService.GetFloodForecast("Somerset");

            return floodResultSummary;
        }

        // GET api/<FloodController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<FloodController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<FloodController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<FloodController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
