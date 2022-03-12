using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Game.src
{
    public class PokemonManager
    {
        private List<Pokemon> Starters;
        private List<Pokemon> WildPokemon;
        //        Pokemon(string t_name, PokemonTypes t_type, int t_level, int t_exp, int t_maxHp)
        public void Populate()
        {
            Starters = new List<Pokemon>();
            Pokemon Tepig = new Pokemon("Tepig", PokemonTypes.FIRE, 5, 25, 20);
            Pokemon Turtwig = new Pokemon("Turtwig", PokemonTypes.GRASS, 5, 25, 20);
            Starters.Add(Turtwig);
            Starters.Add(Tepig);
        }

        public List<Pokemon> GetStarters()
        {
            return Starters;
        }
    }
}
