using PA2.Attacks;
using PA2.Interfaces;
using PA2.Misc;
using System;

namespace PA2
{
    public class Player
    {
        public string Name {get; set;}

        public Character CharacterChoice {get; set;}

        public Player(int count){
            
            Name = GetName(count);
            CharacterChoice = GetCharacter();
        }
        
        public string GetName(int count){
            
            System.Console.ForegroundColor = System.ConsoleColor.Yellow;
            System.Console.Write($"[Player {count}] Please enter your name: ");
            System.Console.ResetColor();
            Name = System.Console.ReadLine();
            System.Console.Clear();
            
            return Name;
        }

        public Character GetCharacter(){
            
            int count;

            Character[] characters = Character.GetCharacters();
            System.Console.ForegroundColor = System.ConsoleColor.Yellow;
            System.Console.WriteLine($"[{Name}] Please enter the number of the character you wish to select...\n");
            System.Console.ResetColor();
            for (int i = 0; i < characters.Length; i++)
            {
                System.Console.WriteLine($"#{i+1}| Name: {characters[i].Name} | Ability: {characters[i].Ability} | Max Power: {characters[i].Power} | Max Defense: {characters[i].Defense}");
            }
            System.Console.ForegroundColor = System.ConsoleColor.Yellow;
            System.Console.Write("\nCharacter Selection: #");
            System.Console.ResetColor();            
            Validation Validate = new Validation();
            int input = Validate.MultiPlayer();
            while (true)
            {
                if (1 <= input && input <= Character.GetCharacters().Length)
                {
                    count = input;
                    break;
                }
                input = Validate.MultiPlayer();
            }

            return (Character)characters[count-1].CopyObject();
        }
       
        
        public override string ToString(){
            
            return "[" + Name + "] aka " + "\""+ CharacterChoice.Name +"\"";
        }
    }
}