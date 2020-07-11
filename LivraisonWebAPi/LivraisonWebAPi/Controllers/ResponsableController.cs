using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LivraisonWebAPi.Models;
using Microsoft.AspNetCore.Mvc;

namespace LivraisonWebAPi.Controllers
{
  
    [ApiController]
    [Route("[controller]")]
    public class ResponsableController: ControllerBase
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<Responsable> Get()
        {
            using (var context = new gestion_livraisonContext())
            {
                return context.Responsables.ToList();
                //if i want to get on city 
                //return context.Ville.Where(Ville => Ville.Id==1).ToList();

            }
        }

        //// GET api/values/5
        //[HttpGet("{id}")]
        //public ActionResult<string> Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/values
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/values/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/values/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
