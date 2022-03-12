using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Game.src
{
    class Pokemon
    {
        private int id;
        private string nickname;
        private string name;
        private int level;
        private int experience;
        private int hp;
        private int maxHp;
        private bool starter;
        private PokemonTypes pType;
        private List<MoveTypes> moveList;
        private Trainer pTrainer;

        //Constructor
        public Pokemon(string t_name, PokemonTypes t_type, int t_level, int t_exp, int t_maxHp, Trainer t_trainer = null)
        {
            nickname = "null";
            name = t_name;
            level = t_level;
            experience = t_exp;
            hp = maxHp = t_maxHp;
            pType = t_type;
            pTrainer = t_trainer;
            if(t_trainer != null)
            {
                id = t_trainer.GetPokemonCount();
            }
            else { id = -1; }
        }

        #region Getters+Setters
        public int CatchPercentage()
        {
            return -1;
        }

        public string GetName()
        {
            return name;
        }

        public string GetNick()
        {
            return nickname;
        }

        public void SetNick(string nick)
        {
            nickname = nick;
        }

        public int GetLevel()
        { 
            return level;
        } 
        public void SetLevel(int nLevel)
        {
            level = nLevel; 
        }

        public int GetExperience() 
        {
            return experience;
        }
        public void SetExperience(int texp) 
        { 
            experience = texp;
        }
        
        public int GetHp() 
        {
            return hp;
        }
        public void SetHp(int thp) 
        { 
            hp = thp; 
        }

        public int GetMaxHp()
        {
            return maxHp;
        }
        public void SetMaxHp(int thp) 
        { 
            maxHp = thp; 
        }

        public PokemonTypes GetType()
        {
            return pType; 
        }

        public bool GetIsStarter()
        {
            return starter;
        }

        public void SetIsStarter(bool input)
        {
            starter = input;
        }

        public int GetID()
        {
            return id;
        }

        public void SetID(int temp)
        {
            id = temp;
        }
        #endregion

    }
}
