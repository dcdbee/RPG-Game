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
        public static GameManager GManager;
        public static PokemonManager PManager;
        static void Main()
        {
            PManager = new PokemonManager();
            GManager = new GameManager();
            PManager.Populate();
            if (!GManager.SaveExists())
            {
                Intro();
                Play();
            }
            else
            {
                GManager.Load();
                Play();
            }
            Console.ReadKey();
        }

        public static void Play()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Welcome {GManager.GetPlayer().GetName()}");
            Console.WriteLine("Pokemon:");
            for (int i = 0; i < GManager.GetPlayer().GetPokemonCount(); i++)
            {
                Pokemon temp = GManager.GetPlayer().GetPokemonList()[i];
                Console.WriteLine("Name: " + temp.GetName());
                Console.WriteLine("Level: " + temp.GetLevel());
                Console.WriteLine($"Starter?: {temp.GetIsStarter()}");
                Console.WriteLine("Type: " + temp.GetType());
                Console.WriteLine();
            }
        }

        public static void Intro()
        {
            Console.WriteLine("What is your name?");
            string tname = Console.ReadLine();
            Trainer Player = new Trainer();
            Player.SetName(tname);
            Console.WriteLine($"Select a starter");
            for (int i = 0; i < PManager.GetStarters().Count; i++)
            {
                Console.WriteLine($"{i} - {PManager.GetStarters()[i].GetName()}");
            }
            Pokemon tPokemon = PManager.GetStarters()[int.Parse(Console.ReadLine())];
            Console.WriteLine(tPokemon.GetName());
            Player.AddPokemon(tPokemon);
            GManager.SetPlayer(Player);
            GManager.InternalSaver(Player);
        }
    }
}
