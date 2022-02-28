using System;
using PA2.Misc;

namespace PA2
{
    public class MultiPlayer
    {
        public Player[] Players {get; set;}
    
        public MultiPlayer(){
            
            Output.HowToPlay();
            FlipCoin();
            Players = new Player[]{new Player(1), new Player(2)};
        }

        public static void FlipCoin(){
            
            System.Console.Write("\n\n#1| Continue \n#2| We can't decide, flip a coin\n\n");
            System.Console.ForegroundColor = System.ConsoleColor.Yellow;
            System.Console.Write("\rFirst, decide who will be \"[Player 1]\" and who will be \"[Player 2]\": #");
            System.Console.ResetColor();
            switch (System.Console.ReadLine()) 
            {
                case "1": 
                    System.Console.Clear();
                    break;
                
                case "2":
                    System.Console.Clear();
                    System.Console.Write("Decide who will be \"Heads\" and who will be \"Tails\".\n\nPress any [key] to flip the coin...");
                    System.Console.ReadKey();
                    System.Console.Clear();
                    
                    //Coin Flip
                    int randomNumber = new Random().Next(1,3);
                    if (randomNumber == 1)
                    {
                        System.Console.ForegroundColor = System.ConsoleColor.Yellow;
                        System.Console.WriteLine("[Player One] is \"Heads\"!\n");
                        System.Console.ResetColor();
                        Default.Key();
                        System.Console.Clear();
                    }
                    else if (randomNumber == 2)
                    {
                        System.Console.ForegroundColor = System.ConsoleColor.Yellow;
                        System.Console.WriteLine("[Player One] is \"Tails\"!\n");
                        System.Console.ResetColor();
                        Default.Key();
                        System.Console.Clear();
                    }
                    break;

                default:
                    Output.InvalidMenuSelectionError();
                    FlipCoin();
                    break;
            
            }
        }



        public void Battle(){
            
            bool someoneWon = false;
            
            //Randomly choose who starts
            int randomNumber = new Random().Next(1,3); //Will either be 1 or 2
            Player offense = Players[Math.Abs(randomNumber-1)]; //Will either be [0] or [1]
            Player defense = Players[Math.Abs(randomNumber-2)]; //Will either be [0] or [1]
            
            while(!someoneWon)
            {
                //Start new MultiplayerBattle
                MultiPlayerBattle battle = new MultiPlayerBattle(ref offense, ref defense);
                int winner;

                //Start Battle
                battle.Battle();
                System.Console.WriteLine("");
                Default.Key();

                //Display player Health
                DisplayPlayersHealth();

                //Check if player 1 parished
                if (Players[0].CharacterChoice.Health <= 0)
                {
                    winner = 1;
                }
                
                //Check if player 2 parished
                else if (Players[1].CharacterChoice.Health <= 0)
                {
                    winner = 2;
                }
                else
                {
                    winner = 3;
                }
                
                //If player 1 won
                if (winner == 2)
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
                
                //If player 2 won
                else if (winner == 1)
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
                    System.Console.WriteLine("[" + Players[1].Name + "]" + " aka \"" + Players[1].CharacterChoice.Name + "\" is victorious!\n");
                    System.Console.ResetColor();
                    Default.Key();
                    Output.GameOver();
                    return;
                }
                
                //Switch who's Offense & who's Defense
                if (offense.ToString() == Players[0].ToString())
                {
                    offense = Players[1];
                    defense = Players[0];
                }
                else
                {
                    offense = Players[0];
                    defense = Players[1];
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
            if (Players[1].CharacterChoice.Health <=0)
            {
                System.Console.ForegroundColor = System.ConsoleColor.Red;
                System.Console.WriteLine(Players[1].ToString() + " | " + "Parished");
                System.Console.ResetColor();
            }
            else if (Players[1].CharacterChoice.Health <= 40)
            {
                System.Console.ForegroundColor = System.ConsoleColor.Red;
                System.Console.WriteLine(Players[1].ToString() + " | " + Players[1].CharacterChoice.Health);
                System.Console.ResetColor();
            }
            else if (Players[1].CharacterChoice.Health < 80)
            {
                System.Console.ForegroundColor = System.ConsoleColor.Yellow;
                System.Console.WriteLine(Players[1].ToString() + " | " + Players[1].CharacterChoice.Health);
                System.Console.ResetColor();
            }
            else if (Players[1].CharacterChoice.Health >= 80)
            {
                System.Console.ForegroundColor = System.ConsoleColor.Green;
                System.Console.WriteLine(Players[1].ToString() + " | " + Players[1].CharacterChoice.Health);
                System.Console.ResetColor();
            }
        }
    }
}