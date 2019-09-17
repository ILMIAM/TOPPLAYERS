using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using TOPPLAYERS.Model;

namespace TOPPLAYERS.Controllers
{


    [Produces("application/json")]
    [Route("GET/players")]
    public class PalyerController : Controller
    {
        List<Player> PlayersList = new List<Player>();
      
        public PalyerController()
        {
            RootObject Players = JsonConvert.DeserializeObject<RootObject>(SerializationRepository.PlayersDocument);
            PlayersList = ((RootObject)Players).Players;
        }
        // GET: api/Players
        [HttpGet]
        public List<Player> Players()
        {
            return PlayersList.OrderBy(x=>x.Id).ToList(); 
        }

        // GET: api//Players/5
        [HttpGet("{id}", Name = "GetById")]
        public IActionResult GetById(int id)
        {
            var player = PlayersList.FirstOrDefault(c => c.Id == id);
            if (player == null)
            { return NotFound(); }
            return new ObjectResult(player);
        }

        // DELETE: api/Players/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var player = PlayersList.FirstOrDefault(p => p.Id == id);
            if (player == null)
            {
                return NotFound();
            }

            PlayersList.Remove(player);
            return new NoContentResult();
        }


    }
}