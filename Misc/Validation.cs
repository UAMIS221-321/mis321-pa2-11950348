using System;

namespace PA2.Misc
{
    public class Validation
    {
        public int MultiPlayer(){
            
            string userInput = Console.ReadLine();
            int userInt;
            //Making sure user input is a number and within the number range of characters
            while (!int.TryParse(userInput, out userInt) || (int.Parse(userInput) > 6) || (int.Parse(userInput) <= 0))
            {
                System.Console.ForegroundColor = System.ConsoleColor.Red;
                System.Console.Write($"Error: \"{userInput}\" is not a vaild input! Please try again: ");
                System.Console.ResetColor();
                userInput = Console.ReadLine();
            }
            Character[] characters = Character.GetCharacters();
            int i = int.Parse(userInput)-1;
            System.Console.ForegroundColor = System.ConsoleColor.Yellow;
            System.Console.Write($"Sucess! You selected player: #{i+1}| Name: {characters[i].Name} | Ability: {characters[i].Ability} | Max Power: {characters[i].Power} | Max Defense: {characters[i].Defense}\n\n");
            System.Console.ResetColor();
            Default.Key();
            System.Console.Clear();
            
            return userInt;
        }


        public int SinglePlayer(int randomCharacter){
            
            //AI's Choice
            int userInt = randomCharacter;
            Character[] characters = Character.GetCharacters();
            int i = userInt - 1;
            System.Console.WriteLine();
            System.Console.ForegroundColor = System.ConsoleColor.Yellow;
            System.Console.Write($"[AI] selected player: #{i+1}| Name: {characters[i].Name} | Ability: {characters[i].Ability} | Max Power: {characters[i].Power} | Max Defense: {characters[i].Defense}\n\n");
            System.Console.ResetColor();
            Default.Key();
            System.Console.Clear();
            
            return userInt;
        }


        
    }
}