using System;
using PA2.Misc;

namespace PA2
{
    public class SinglePlayer
    {
        public Player[] Players {get; set;}
        public AI[] AIs {get; set;}

        public SinglePlayer(){
            
            Output.HowToPlayAI();
            Players = new Player[]{new Player(1)};
            AIs = new AI[]{new AI(1)};
        }

        private int GetDificulty(){

            System.Console.ForegroundColor = System.ConsoleColor.Yellow;
            System.Console.WriteLine();
            System.Console.WriteLine($"[Player] Please select the dificulty level for the [AI]... ");
            System.Console.ResetColor();
            System.Console.WriteLine("\n#1| Hard\n#2| Medium\n#3| Easy\n");
            System.Console.ForegroundColor = System.ConsoleColor.Yellow;
            System.Console.Write("\rPlease select a dificulty: #");
            System.Console.ResetColor();
            string usersInput = Console.ReadLine();
            while (usersInput != "1" + "2" + "3")
            {
                if (usersInput == "1")
                {
                    return 1;
                }
                else if (usersInput == "2")
                {
                    return 2;
                }
                else if (usersInput == "3")
                {
                    return 3;
                }
                System.Console.ForegroundColor = System.ConsoleColor.Red;
                System.Console.Write("[Error] Invalid Selection! Please choose either \"#1\" \"#2\" or #\"3\": #");
                System.Console.ResetColor();
                usersInput = System.Console.ReadLine();
            }
            
            return 0;
        }
        
        
        public void Battle(){
            
            Player playerOne = Players[0];
            AI playerTwo = AIs[0];
            bool weHaveAWinner = false;
            int difficulty = GetDificulty();
            
            if (difficulty == 1)
            {
                System.Console.Clear();
                System.Console.ForegroundColor = System.ConsoleColor.Red;
                System.Console.WriteLine($"Sucess! [AI] is set to Hard!\n");
                System.Console.ResetColor();
                Default.Key();
            }
            else if (difficulty == 2)
            {
                System.Console.Clear();
                System.Console.ForegroundColor = System.ConsoleColor.Yellow;
                System.Console.WriteLine($"Sucess! [AI] is set to Medium!\n");
                System.Console.ResetColor();
                Default.Key();
            }
            else if (difficulty == 3)
            {
                System.Console.Clear();
                System.Console.ForegroundColor = System.ConsoleColor.Green;
                System.Console.WriteLine($"Sucess! [AI] is set to Easy!\n");
                System.Console.ResetColor();
                Default.Key();
            }
            
            DisplayPlayersHealth();
            
            while(!weHaveAWinner)
            {
                SinglePlayerBattle battle = new SinglePlayerBattle(ref playerOne,ref playerTwo);
                battle.Battle(ref playerOne, ref playerTwo, difficulty);
                System.Console.WriteLine("");
                Default.Key();
                DisplayPlayersHealth();
                int winner;
                //Check player health then assign winner values
                if (Players[0].CharacterChoice.Health <= 0)
                {
                    winner = 1;
                }
                else if (AIs[0].CharacterChoice.Health <= 0)
                {
                    winner = 2;
                }
                else
                {
                    winner = 3;
                }
                //Check for winner
                if (winner == 1)
                {
                    System.Console.Write("\n");
                    for (int dots = 0; dots <= 3; dots++)
                    {
                        System.Console.ForegroundColor = System.ConsoleColor.Yellow;
                        System.Console.Write("\rWe have a winner{0}", new string('.', dots));
                        System.Console.ResetColor();
                        System.Threading.Thread.Sleep(300);
                    }
                    System.Console.WriteLine("\n");
                    Default.Key();
                    System.Console.Clear();
                    System.Console.ForegroundColor = System.ConsoleColor.Yellow;
                    System.Console.WriteLine("[" + AIs[0].Name + "]" + " aka \"" + AIs[0].CharacterChoice.Name + "\" is victorious!\n");
                    System.Console.ResetColor();
                    Default.Key();
                    Output.GameOver();

                    return;
                }
                else if (winner == 2)
                {
                    System.Console.Write("\n");
                    for (int dots = 0; dots <= 3; dots++)
                    {
                        System.Console.ForegroundColor = System.ConsoleColor.Yellow;
                        System.Console.Write("\rWe have a winner{0}", new string('.', dots));
                        System.Console.ResetColor();
                        System.Threading.Thread.Sleep(300);
                    }
                    System.Console.WriteLine("\n");
                    Default.Key();
                    System.Console.Clear();
                    System.Console.ForegroundColor = System.ConsoleColor.Yellow;
                    System.Console.WriteLine("[" + Players[0].Name + "]" + " aka \"" + Players[0].CharacterChoice.Name + "\" is victorious!\n");
                    System.Console.ResetColor();
                    Default.Key();
                    Output.GameOver();
                    return;
                }
            }
        }
        

        public void DisplayPlayersHealth(){
            
            //Player 1's Health
            System.Console.Clear();
            if (Players[0].CharacterChoice.Health <=0)
            {
                System.Console.ForegroundColor = System.ConsoleColor.Red;
                System.Console.WriteLine(Players[0].ToString() + " | " + "Parished");
                System.Console.ResetColor();
            }
            else if (Players[0].CharacterChoice.Health <= 40)
            {
                System.Console.ForegroundColor = System.ConsoleColor.Red;
                System.Console.WriteLine(Players[0].ToString() + " | " + Players[0].CharacterChoice.Health);
                System.Console.ResetColor();
            }
            else if (Players[0].CharacterChoice.Health < 80)
            {
                System.Console.ForegroundColor = System.ConsoleColor.Yellow;
                System.Console.WriteLine(Players[0].ToString() + " | " + Players[0].CharacterChoice.Health);
                System.Console.ResetColor();
            }
            else if(Players[0].CharacterChoice.Health >= 80)
            {
                System.Console.ForegroundColor = System.ConsoleColor.Green;
                System.Console.WriteLine(Players[0].ToString() + " | " + Players[0].CharacterChoice.Health);
                System.Console.ResetColor();
            }

            //Player 2's Health
            if (AIs[0].CharacterChoice.Health <=0)
            {
                System.Console.ForegroundColor = System.ConsoleColor.Red;
                System.Console.WriteLine(AIs[0].ToString() + " | " + "Parished");
                System.Console.ResetColor();
            }
            else if (AIs[0].CharacterChoice.Health <= 40)
            {
                System.Console.ForegroundColor = System.ConsoleColor.Red;
                System.Console.WriteLine(AIs[0].ToString() + " | " + AIs[0].CharacterChoice.Health);
                System.Console.ResetColor();
            }
            else if (AIs[0].CharacterChoice.Health < 80)
            {
                System.Console.ForegroundColor = System.ConsoleColor.Yellow;
                System.Console.WriteLine(AIs[0].ToString() + " | " + AIs[0].CharacterChoice.Health);
                System.Console.ResetColor();
            }
            else if (AIs[0].CharacterChoice.Health >= 80)
            {
                System.Console.ForegroundColor = System.ConsoleColor.Green;
                System.Console.WriteLine(AIs[0].ToString() + " | " + AIs[0].CharacterChoice.Health);
                System.Console.ResetColor();
            }
        }
    }
}