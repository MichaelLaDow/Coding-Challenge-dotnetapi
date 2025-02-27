using Coding_Challenge_dotnetapi.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace Coding_Challenge_dotnetapi.Controllers
{
    public class CharactersController : ControllerBase
    {
        private static readonly List<Character> _db = new List<Character>()
        {
            new Character()
            {
                Id = 1,
                Name = "Pike",
                Stat = new Stat() {StatId = 1, Name = "Health", Value = 5},
                Traits = new List<Trait>
                {
                    new Trait()
                    {
                        TraitId = 1,
                        Name = "Healthy",
                        ModifierValue = 0
                    }
                }
            },
                        new Character()
            {
                Id = 2,
                Name = "Vax",
                Traits = new List<Trait>
                {
                    new Trait()
                    {
                        TraitId = 2,
                        Name = "Wounded",
                        ModifierValue = -2
                    }
                }
            }
        };

        public CharactersController()
        {

        }

        public IActionResult Get()
        {
            var result = _db.Where(x => x.DeletedAt != null).ToList();
            return Ok(result);
        }
        public IActionResult GetById(int id)
        {
            var result = _db.Where(x => x.Id == id).FirstOrDefault();
            return Ok();
        }
        public IActionResult Post(Character character)
        {
            return Ok();
        }
    }
}
