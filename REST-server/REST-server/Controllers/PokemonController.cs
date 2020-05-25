using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace REST_server.Controllers
{
    [Route("api/pokemon")]
    [ApiController]
    public class PokemonController : ControllerBase


    {

        private static List<Pokemon> pokemons = new List<Pokemon>
        {
            new Pokemon() {Name = "Pikachu", Strength = 9},
            new Pokemon() {Name = "Ditto", Strength = 12},
            new Pokemon() {Name = "Eric", Strength = 666}
        };

        [HttpPost]
        public ActionResult Post(Pokemon newPokemon)
        {
            pokemons.Add(newPokemon);
            Console.WriteLine(newPokemon.Name + " was created");

            return Created("", newPokemon);

        }


        [HttpGet]
        public ActionResult<List<Pokemon>> Get()
        {
            //Pokemon p = new Pokemon() { Name = "Pikachu", Strength = 9 };
            /*p.Name = "Pikachu";
            p.Strength = 9; */

            return Ok(pokemons);
            // return Ok("Crispy chiken plus meny med en chiken nugget");
        }

        [HttpGet]
        [Route("ditto")]
        public ActionResult GetDitto()
        {
            return Ok("Yay");
        }

        [HttpGet]
        [Route("num/{number}")]
        public ActionResult GetByNumber(int number)
        {
            return Ok("N: " + number);
        }


    }
}