using PA2.Attacks;
using PA2.Interfaces;
using PA2.Misc;
using System;

namespace PA2
{
    public class AI
    {
        public string Name {get; set;}
        public Character CharacterChoice {get; set;}

        public AI (int index){
            
            System.Console.Clear();
            Name = "AI";
            CharacterChoice = AIPicksCharacter();
             
        }

        
        public Character AIPicksCharacter(){
            
            Character[] characters = Character.GetCharacters();
            System.Console.ForegroundColor = System.ConsoleColor.Yellow;
            System.Console.WriteLine($"[{Name}] Is selecting a character...\n");
            System.Threading.Thread.Sleep(300);
            System.Console.ResetColor();
            for (int i = 0; i < characters.Length; i++)
            {
                System.Console.WriteLine($"#{i+1}| Name: {characters[i].Name} | Ability: {characters[i].Ability} | Max Power: {characters[i].Power} | Max Defense: {characters[i].Defense}");
            }
            
            int randomCharacter = new Random().Next(1,7);
            System.Threading.Thread.Sleep(300);
            System.Console.ForegroundColor = System.ConsoleColor.Yellow;
            System.Console.Write($"\nCharacter Selection: #{randomCharacter}");
            System.Console.ResetColor();            
            Validation Validate = new Validation();
            int index;
            randomCharacter = Validate.SinglePlayer(randomCharacter);
            while (true)
            {
                if (1 <= randomCharacter && randomCharacter <= Character.GetCharacters().Length)
                {
                    index = randomCharacter;
                    break;
                }
                randomCharacter = Validate.SinglePlayer(randomCharacter);
            }
            
            //Need to return the AI's random character selection
            return (Character)characters[randomCharacter-1];
        }
       

        public override string ToString()
        {
            return "[" + Name + "] aka " + "\""+ CharacterChoice.Name +"\"";
        }
    }
}