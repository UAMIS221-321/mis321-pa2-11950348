using System;
using PA2.Misc;

namespace PA2
{
    class Program
    {
        static void Main(string[] args)
        {
            Output.Welcome();
            System.Console.Clear();
            Start();
        }

        public static void Start(){
            
            System.Console.Clear();
            Output.MenuOption();
            System.Console.Write("\n\n#1| Multi-Player (Base Requirements) \n#2| Single-Player (Extra)\n#3| Exit\n\n");
            System.Console.ForegroundColor = System.ConsoleColor.Yellow;
            System.Console.Write("\rPlease select a gamemode: #");
            System.Console.ResetColor();
            switch (System.Console.ReadLine()) 
            { 
                case "1": 
                    //Multi Player (1v1)
                    Output.OnevsOne();
                    System.Console.Clear();
                    MultiPlayer MultiPlayerGame = new MultiPlayer();
                    Output.Battle();
                    MultiPlayerGame.DisplayPlayersHealth();
                    MultiPlayerGame.Battle();
                    Start();
                    break;
                
                case "2":
                    //Single Player (1vAI)
                    Output.AIvsPlayer();
                    System.Console.Clear();
                    SinglePlayer SinglePlayerGame = new SinglePlayer();
                    Output.Battle();
                    SinglePlayerGame.DisplayPlayersHealth();
                    SinglePlayerGame.Battle();
                    Start();
                    break;
                
                case "3":
                    //Exit
                    Output.Exit();
                    System.Console.Clear();
                    break;

                default:
                    Output.InvalidMenuSelectionError();
                    Start();
                    break;
            
            }
        }
    }
}