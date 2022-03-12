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
            GameManager GManager = new GameManager();
            PokemonManager PManager = new PokemonManager();
            Console.WriteLine("What is your name?");
            string tname = Console.ReadLine();
            Trainer Player = new Trainer();
            Player.SetName(tname);

            PManager = new PokemonManager();
            PManager.Populate();
            Console.WriteLine($"Select a starter");
            for (int i = 0; i < PManager.GetStarters().Count; i++)
            {
                Console.WriteLine($"{i} - {PManager.GetStarters()[i].GetName()}");
            }
            Pokemon tPokemon = PManager.GetStarters()[int.Parse(Console.ReadLine())];
            Console.WriteLine(tPokemon.GetName());
            Player.AddPokemon(tPokemon);
            GManager.Saver(Player);
            Console.ReadKey();
        }
    }
}
