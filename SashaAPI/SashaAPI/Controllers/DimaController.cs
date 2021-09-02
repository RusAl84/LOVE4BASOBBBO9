using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SashaAPI.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class DimaController : ControllerBase
  {
    // GET: api/<DimaController>
    [HttpGet]
    public IEnumerable<string> Get()
    {
      return new string[] { "Мама ", "я хочу в Кабул" };
    }

    // GET api/<DimaController>/5
    [HttpGet("{id}")]
    public string Get(int id)
    {
      return "Дима съел " + id.ToString()+ " Ёжиков" ;
    }

    // POST api/<DimaController>
    [HttpPost]
    public void Post([FromBody] string value)
    {
    }

    // PUT api/<DimaController>/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE api/<DimaController>/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
  }
}
