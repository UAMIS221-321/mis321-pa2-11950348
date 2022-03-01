using System;
using PA2.Misc;

namespace PA2
{
    public class SinglePlayerBattle
    {
        public Player PlayerOne {get; set;}

        public AI PlayerTwo {get; set;}

        public SinglePlayerBattle(ref Player playerOne, ref AI playerTwo){
            
            PlayerOne = playerOne;
            PlayerTwo = playerTwo;
        }

        public void Battle(ref Player playerOne, ref AI playerTwo, int difficulty){

            //Player
            double playerOneOffensePower = 0;
            double playerOneDefensePower = 0;
            double playerOneBonus;
            double playerOneTurnDifference;
            double playerOneTurnDamage;

            //AI
            double playerTwoOffensePower = 0;
            double playerTwoDefensePower = 0;
            double playerTwoBonus;
            double playerTwoTurnDifference;
            double playerTwoTurnDamage;
            
            System.Console.ForegroundColor = System.ConsoleColor.Yellow;
            System.Console.WriteLine($"\n[{PlayerOne.Name}] aka \"{PlayerOne.CharacterChoice.Name}\" it is your move!\n");
            System.Console.ResetColor();
            System.Console.WriteLine("#1| Attack");
            System.Console.WriteLine("#2| Flee");
            System.Console.ForegroundColor = System.ConsoleColor.Yellow;
            System.Console.Write("\nBattle Selection: #");
            System.Console.ResetColor();
            string playerOneAttack = PlayerOneBattleChoice();

            //Check for player attack bonus
            if (PlayerOne.CharacterChoice.Name == "Jack Sparrow" && PlayerTwo.CharacterChoice.Name == "Will Turner")
            {
                System.Console.ForegroundColor = System.ConsoleColor.Yellow;
                System.Console.WriteLine("[Jack Sparrow's] Attack Bonus is Active!");
                System.Console.ResetColor();

                
                playerOneBonus = 1.2;
            }
            else if (PlayerOne.CharacterChoice.Name == "Will Turner" && PlayerTwo.CharacterChoice.Name == "Davy Jones")
            {
                System.Console.ForegroundColor = System.ConsoleColor.Yellow;
                System.Console.WriteLine("[Will Turner's] Attack Bonus is Active!");
                System.Console.ResetColor();

                playerOneBonus = 1.2;
            }
            else if (PlayerOne.CharacterChoice.Name == "Davy Jones" && PlayerTwo.CharacterChoice.Name == "Jack Sparrow")
            {
                System.Console.ForegroundColor = System.ConsoleColor.Yellow;
                System.Console.WriteLine("[Davy Jone's] Attack Bonus is Active!");
                System.Console.ResetColor();

                playerOneBonus = 1.2;
            }
            else if (PlayerOne.CharacterChoice.Name == "Angelica" && PlayerTwo.CharacterChoice.Name == "Black Beard")
            {
                System.Console.ForegroundColor = System.ConsoleColor.Yellow;
                System.Console.WriteLine("[Angelica's] Attack Bonus is Active!");
                System.Console.ResetColor();

                playerOneBonus = 1.2;
            }
            else if (PlayerOne.CharacterChoice.Name == "Angelica" &&  PlayerTwo.CharacterChoice.Name == "Jack Sparrow")
            {
                System.Console.ForegroundColor = System.ConsoleColor.Yellow;
                System.Console.WriteLine("[Angelica's] Attack Bonus is Active!");
                System.Console.ResetColor();

                playerOneBonus = 1.2;
            }
            else if (PlayerOne.CharacterChoice.Name == "Black Beard" && PlayerTwo.CharacterChoice.Name == "Jack Sparrow")
            {
                System.Console.ForegroundColor = System.ConsoleColor.Yellow;
                System.Console.WriteLine("[Black Beard's] Attack Bonus is Active!");
                System.Console.ResetColor();

                playerOneBonus = 1.2;
            }
            else if (PlayerOne.CharacterChoice.Name == "Jack The Monkey" && PlayerTwo.CharacterChoice.Name == "Black Beard")
            {
                System.Console.ForegroundColor = System.ConsoleColor.Yellow;
                System.Console.WriteLine("[Jack The Monkey's] Attack Bonus is Active!");
                System.Console.ResetColor();

                playerOneBonus = 1.2;
            }
            else 
            {
                playerOneBonus = 1;
            }
            
            //Players Battle Selection
            if (playerOneAttack == "1")
            {
                playerOneOffensePower = this.PlayerOne.CharacterChoice.Attack.Attack(this.PlayerOne.CharacterChoice.Name, this.PlayerOne.CharacterChoice.Power);
                playerTwoDefensePower = this.PlayerOne.CharacterChoice.Defend.Defend(this.PlayerTwo.CharacterChoice.Name, this.PlayerTwo.CharacterChoice.Defense);
            }
            //Players Flee Selection
            else if (playerOneAttack == "2")
            {
                System.Console.WriteLine($"[{PlayerOne.Name}] aka \"{PlayerOne.CharacterChoice.Name}\" ran away this round!");
            }
            
            //Player Logic
            playerOneTurnDifference = playerOneOffensePower - playerTwoDefensePower;
            if ((playerOneOffensePower - playerTwoDefensePower) < 0)
            {
                playerOneTurnDifference = 0;
            }
            playerOneTurnDamage = (playerOneTurnDifference) * playerOneBonus;
            System.Console.WriteLine($"\"{PlayerOne.CharacterChoice.Name}\" yeild {playerOneTurnDamage} damage to {PlayerTwo.CharacterChoice.Name}!");
            if (PlayerTwo.CharacterChoice.Health - playerOneTurnDamage < 0)
            {
                PlayerTwo.CharacterChoice.Health = 0;
            }
            else
            {
                PlayerTwo.CharacterChoice.Health = PlayerTwo.CharacterChoice.Health - playerOneTurnDamage;
            }


            //AI's Turn Starts Here


            //If the AI is dead it can't go...
            if (PlayerTwo.CharacterChoice.Health > 0)
            {
                string aiAttack = GetAIAttack(difficulty);

                //Check for AI attack bonus
                if (PlayerTwo.CharacterChoice.Name == "Jack Sparrow" && PlayerOne.CharacterChoice.Name == "Will Turner")
                {
                    System.Console.ForegroundColor = System.ConsoleColor.Yellow;
                    System.Console.WriteLine("[Jack Sparrow's] Attack Bonus is Active!");
                    System.Console.ResetColor();

                
                    playerTwoBonus = 1.2;
                }
                else if (PlayerTwo.CharacterChoice.Name == "Will Turner" && PlayerOne.CharacterChoice.Name == "Davy Jones")
                {
                    System.Console.ForegroundColor = System.ConsoleColor.Yellow;
                    System.Console.WriteLine("[Will Turner's] Attack Bonus is Active!");
                    System.Console.ResetColor();

                    playerTwoBonus = 1.2;
                }
                else if (PlayerTwo.CharacterChoice.Name == "Davy Jones" && PlayerOne.CharacterChoice.Name == "Jack Sparrow")
                {
                    System.Console.ForegroundColor = System.ConsoleColor.Yellow;
                    System.Console.WriteLine("[Davy Jone's] Attack Bonus is Active!");
                    System.Console.ResetColor();

                    playerTwoBonus = 1.2;
                }
                else if (PlayerTwo.CharacterChoice.Name == "Angelica" && PlayerOne.CharacterChoice.Name == "Black Beard")
                {
                    System.Console.ForegroundColor = System.ConsoleColor.Yellow;
                    System.Console.WriteLine("[Angelica's] Attack Bonus is Active!");
                    System.Console.ResetColor();

                    playerTwoBonus = 1.2;
                }
                else if (PlayerTwo.CharacterChoice.Name == "Angelica" &&  PlayerOne.CharacterChoice.Name == "Jack Sparrow")
                {
                    System.Console.ForegroundColor = System.ConsoleColor.Yellow;
                    System.Console.WriteLine("[Angelica's] Attack Bonus is Active!");
                    System.Console.ResetColor();

                    playerTwoBonus = 1.2;
                }
                else if (PlayerTwo.CharacterChoice.Name == "Black Beard" && PlayerOne.CharacterChoice.Name == "Jack Sparrow")
                {
                    System.Console.ForegroundColor = System.ConsoleColor.Yellow;
                    System.Console.WriteLine("[Black Beard's] Attack Bonus is Active!");
                    System.Console.ResetColor();

                    playerTwoBonus = 1.2;
                }
                else if (PlayerTwo.CharacterChoice.Name == "Jack The Monkey" && PlayerOne.CharacterChoice.Name == "Black Beard")
                {
                    System.Console.ForegroundColor = System.ConsoleColor.Yellow;
                    System.Console.WriteLine("[Jack The Monkey's] Attack Bonus is Active!");
                    System.Console.ResetColor();

                    playerTwoBonus = 1.2;
                }
                else 
                {
                    playerTwoBonus = 1;
                }

                //AI attacking
                if (aiAttack == "1")
                {
                    playerTwoOffensePower = this.PlayerTwo.CharacterChoice.Attack.Attack(this.PlayerTwo.CharacterChoice.Name, this.PlayerTwo.CharacterChoice.Power);
                    playerOneDefensePower = this.PlayerTwo.CharacterChoice.Defend.Defend(this.PlayerOne.CharacterChoice.Name, this.PlayerOne.CharacterChoice.Defense);
                }
                //Flee Selection
                else if (aiAttack =="2")
                {
                    System.Console.WriteLine($"[{PlayerTwo.Name}] aka \"{PlayerOne.CharacterChoice.Name}\" ran away this round!");
                }

                //AI Logic
                playerTwoTurnDifference = playerTwoOffensePower - playerOneDefensePower;
                if ((playerTwoOffensePower - playerOneDefensePower) < 0)
                {
                    playerTwoTurnDifference = 0;
                }
                playerTwoTurnDamage = (playerTwoTurnDifference) * playerTwoBonus;
                System.Console.WriteLine($"\"{PlayerTwo.CharacterChoice.Name}\" yeild {playerTwoTurnDamage} damage to {PlayerOne.CharacterChoice.Name}!");
                if (PlayerOne.CharacterChoice.Health - playerTwoTurnDamage < 0)
                {
                    PlayerOne.CharacterChoice.Health = 0;
                }
                else
                {
                    PlayerOne.CharacterChoice.Health = PlayerOne.CharacterChoice.Health - playerTwoTurnDamage;
                }
            }
        }

        
        private string PlayerOneBattleChoice(){

            string choice = System.Console.ReadLine();
            while (choice != "2")
            {
                if (choice == "1")
                {    
                    return "1";
                }
                System.Console.ForegroundColor = System.ConsoleColor.Red;
                System.Console.Write("[Error] Invalid Selection! Please choose either \"#1\" or \"#2\": #");
                System.Console.ResetColor();
                choice = System.Console.ReadLine();
            }
            return "2";
        }

         private string GetAIAttack(int difficulty){

            System.Console.WriteLine();
            Default.Key();
            System.Console.Clear();
            DisplayPlayersHealth(); 
            System.Console.WriteLine("");
            for (int dots = 0; dots <= 3; dots++)
            {
                System.Console.ForegroundColor = System.ConsoleColor.Yellow;
                System.Console.Write("\r[AI] aka \"" + PlayerTwo.CharacterChoice.Name +"\" is selecting a move{0}", new string('.', dots));
                System.Console.ResetColor();
                System.Threading.Thread.Sleep(150);
            }
            System.Console.WriteLine("");

            //AI Difficulty
            int randomNumber = new Random().Next(1,101);
            if (difficulty == 1)
            {
                if (randomNumber > 5) //Hard = 95% chance of attacking
                {
                    return "1";
                }
            }
            else if (difficulty == 2)
            {
                if (randomNumber >= 50) //Medium = 50% chance of attacking
                {
                    return "1";
                }
            }
            else if (difficulty == 3)
            {
                if (randomNumber > 80) //Easy = 20% chance of attacking
                {
                    return "1";
                }
            }
           
            return "2";
        }

        public void DisplayPlayersHealth(){
            
            //Player's Health
            System.Console.Clear();
            if (PlayerOne.CharacterChoice.Health <=0)
            {
                System.Console.ForegroundColor = System.ConsoleColor.Red;
                System.Console.WriteLine(PlayerOne.ToString() + " | " + "Parished");
                System.Console.ResetColor();
            }
            else if (PlayerOne.CharacterChoice.Health <= 40)
            {
                System.Console.ForegroundColor = System.ConsoleColor.Red;
                System.Console.WriteLine(PlayerOne.ToString() + " | " + PlayerOne.CharacterChoice.Health);
                System.Console.ResetColor();
            }
            else if (PlayerOne.CharacterChoice.Health < 80)
            {
                System.Console.ForegroundColor = System.ConsoleColor.Yellow;
                System.Console.WriteLine(PlayerOne.ToString() + " | " + PlayerOne.CharacterChoice.Health);
                System.Console.ResetColor();
            }
            else if(PlayerOne.CharacterChoice.Health >= 80)
            {
                System.Console.ForegroundColor = System.ConsoleColor.Green;
                System.Console.WriteLine(PlayerOne.ToString() + " | " + PlayerOne.CharacterChoice.Health);
                System.Console.ResetColor();
            }

            //AI's Health
            if (PlayerTwo.CharacterChoice.Health <=0)
            {
                System.Console.ForegroundColor = System.ConsoleColor.Red;
                System.Console.WriteLine(PlayerTwo.ToString() + " | " + "Parished");
                System.Console.ResetColor();
            }
            else if (PlayerTwo.CharacterChoice.Health <= 40)
            {
                System.Console.ForegroundColor = System.ConsoleColor.Red;
                System.Console.WriteLine(PlayerTwo.ToString() + " | " + PlayerTwo.CharacterChoice.Health);
                System.Console.ResetColor();
            }
            else if (PlayerTwo.CharacterChoice.Health < 80)
            {
                System.Console.ForegroundColor = System.ConsoleColor.Yellow;
                System.Console.WriteLine(PlayerTwo.ToString() + " | " + PlayerTwo.CharacterChoice.Health);
                System.Console.ResetColor();
            }
            else if (PlayerTwo.CharacterChoice.Health >= 80)
            {
                System.Console.ForegroundColor = System.ConsoleColor.Green;
                System.Console.WriteLine(PlayerTwo.ToString() + " | " + PlayerTwo.CharacterChoice.Health);
                System.Console.ResetColor();
            }
        }   

    }
}