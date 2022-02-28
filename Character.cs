using PA2.Interfaces;
using PA2.Attacks;
using System;

namespace PA2
{
    public abstract class Character
    {
        public string Name {get; set;}
        public string Ability {get; set;}
        public double Power {get; set;}
        public double Defense {get; set;}
        public double Health {get; set;}


        public IAttack Attack {get; set;}
        public IDefend Defend {get; set;}


        public static Character[] characters = {new JackSparrow(), new WillTurner(), new DavyJones(), new BlackBeard(), new Angelica(), new JackTheMonkey()};

        public static Character[] GetCharacters(){
            return characters;   
        }

        //Shallow and Deep Copy/Cloning is really cool
        public object CopyObject(){
           return this.MemberwiseClone();
        }
    }
}