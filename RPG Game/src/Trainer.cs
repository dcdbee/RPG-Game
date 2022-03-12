using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Game.src
{
    class Trainer
    {
        private string name;
        private List<Pokemon> PokemonList = new List<Pokemon>();

        #region Setters & Getters
        public string GetName()
        {
            return name;
        }
        public void SetName(string input)
        {
            name = input;
        }

        public void AddPokemon(Pokemon tPokemon)
        {
            PokemonList.Add(tPokemon);
        }

        public List<Pokemon> GetPokemonList()
        {
            return PokemonList;
        }

        public void RemovePokemon(Pokemon tPokemon)
        {
            int temp = tPokemon.GetID();
            PokemonList.RemoveAt(temp);
            for(int i = temp; i < PokemonList.Count; i++)
            {
                PokemonList[i].SetID(PokemonList[i].GetID() + 1);
            }
        }

        public int GetPokemonCount()
        {
            return PokemonList.Count;
        }
        #endregion
    }
}
