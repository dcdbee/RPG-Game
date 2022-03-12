using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Game.src
{
    public enum PokemonTypes
    {
        NORMAL,
        FIRE,
        WATER,
        GRASS,
        ELECTRIC,
        ICE,
        FIGHTING,
        POISON,
        GROUND,
        FLYING,
        PSYCHIC,
        BUG,
        ROCK,
        GHOST
    }
    public class Types
    {
        public bool isEffective(PokemonTypes attacker, PokemonTypes victim)
        {
            if(attacker == PokemonTypes.FIRE && victim == PokemonTypes.GRASS)
            {
                return true;
            }
            return false;
        }
    }
}
