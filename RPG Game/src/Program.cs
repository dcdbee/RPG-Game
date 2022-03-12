using RPG_Game.src;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Game
{
    class Program
    {
        static void Main()
        {
            Manager GameManager = new Manager();

            Console.WriteLine("What is your name?");
            string tname = Console.ReadLine();
            PokemonManager manager = new PokemonManager();
            manager.Populate();
            Console.WriteLine($"Select a starter");
            for (int i = 0; i < manager.GetStarters().Count; i++)
            {
                Console.WriteLine($"{i} - {manager.GetStarters()[i].GetName()}");
            }
            Pokemon tPokemon = manager.GetStarters()[int.Parse(Console.ReadLine())];
            Console.WriteLine(tPokemon.GetName());
            Player.AddPokemon(tPokemon);
            Console.ReadKey();
        }
    }
}
