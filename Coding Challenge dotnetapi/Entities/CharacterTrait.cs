using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace Coding_Challenge_dotnetapi.Entities
{
    public class CharacterTrait
    {
        public virtual DbSet<Character> Characters{ get; set; }
        public virtual DbSet<Trait> Traits { get; set; }
        public virtual DbSet<CharacterTrait> CharacterTraits { get; set; }
        public virtual DbSet<Stat> Stats { get; set; }
    }
}
