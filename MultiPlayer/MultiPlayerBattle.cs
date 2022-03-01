using System;

namespace PA2
{
    public class MultiPlayerBattle
    {
        public Player Offense {get; set;}

        public Player Defense {get; set;}

        public MultiPlayerBattle(ref Player offense, ref Player defense){
            
            Offense = offense;
            Defense = defense;
        }

        public void Battle(){
            
            double bonus;
            double offensePower = 0;
            double defensePower = 0;

            System.Console.ForegroundColor = System.ConsoleColor.Yellow;
            System.Console.WriteLine($"\n[{Offense.Name}] aka \"{Offense.CharacterChoice.Name}\" it is your move!\n");
            System.Console.ResetColor();
            System.Console.WriteLine("#1| Attack");
            System.Console.WriteLine("#2| Flee");
            System.Console.ForegroundColor = System.ConsoleColor.Yellow;
            System.Console.Write("\nBattle Selection: #");
            System.Console.ResetColor();
            
            //Player selects to Attack or Flee
            string attack = MultiPlayerBattleChoice();
            
            //Check for any active attack bonus
            if (Offense.CharacterChoice.Name == "Jack Sparrow" && Defense.CharacterChoice.Name == "Will Turner")
            {
                System.Console.ForegroundColor = System.ConsoleColor.Yellow;
                System.Console.WriteLine("[Jack Sparrow's] Attack Bonus is Active!");
                System.Console.ResetColor();

                
                bonus = 1.2;
            }
            else if (Offense.CharacterChoice.Name == "Will Turner" && Defense.CharacterChoice.Name == "Davy Jones")
            {
                System.Console.ForegroundColor = System.ConsoleColor.Yellow;
                System.Console.WriteLine("[Will Turner's] Attack Bonus is Active!");
                System.Console.ResetColor();

                bonus = 1.2;
            }
            else if (Offense.CharacterChoice.Name == "Davy Jones" && Defense.CharacterChoice.Name == "Jack Sparrow")
            {
                System.Console.ForegroundColor = System.ConsoleColor.Yellow;
                Console.WriteLine("[Davy Jone's] Attack Bonus is Active!");
                System.Console.ResetColor();

                bonus = 1.2;
            }
            //End of base requirement attack bonus
            else if (Offense.CharacterChoice.Name == "Angelica" && Defense.CharacterChoice.Name == "Black Beard")
            {
                System.Console.ForegroundColor = System.ConsoleColor.Yellow;
                System.Console.WriteLine("[Angelica's] Attack Bonus is Active!");
                System.Console.ResetColor();

                bonus = 1.2;
            }
            else if (Offense.CharacterChoice.Name == "Angelica" &&  Defense.CharacterChoice.Name == "Jack Sparrow")
            {
                System.Console.ForegroundColor = System.ConsoleColor.Yellow;
                System.Console.WriteLine("[Angelica's] Attack Bonus is Active!");
                System.Console.ResetColor();

                bonus = 1.2;
            }
            else if (Offense.CharacterChoice.Name == "Black Beard" && Defense.CharacterChoice.Name == "Jack Sparrow")
            {
                System.Console.ForegroundColor = System.ConsoleColor.Yellow;
                System.Console.WriteLine("[Black Beard's] Attack Bonus is Active!");
                System.Console.ResetColor();

                bonus = 1.2;
            }
            else if (Offense.CharacterChoice.Name == "Jack The Monkey" && Defense.CharacterChoice.Name == "Black Beard")
            {
                System.Console.ForegroundColor = System.ConsoleColor.Yellow;
                System.Console.WriteLine("[Jack The Monkey's] Attack Bonus is Active!");
                System.Console.ResetColor();

                bonus = 1.2;
            }
            else 
            {
                bonus = 1;
            }
            
            
            if (attack == "1")
            {
                offensePower = this.Offense.CharacterChoice.Attack.Attack(this.Offense.CharacterChoice.Name, this.Offense.CharacterChoice.Power);
                defensePower = this.Offense.CharacterChoice.Defend.Defend(this.Defense.CharacterChoice.Name, this.Defense.CharacterChoice.Defense);
            }
            
            //Flee Selection
            else if (attack == "2")
            {
                System.Console.WriteLine($"[{Offense.Name}] aka \"{Offense.CharacterChoice.Name}\" ran away this round!");
            }
            
            //Damage Caculation Logic
            MultiPlayerBattleLogic(offensePower,defensePower, bonus);
        }

        
        private string MultiPlayerBattleChoice(){

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
        
        
        public void MultiPlayerBattleLogic(double offensePower, double defensePower, double bonus){
        
            double difference = offensePower - defensePower;
            if ((offensePower - defensePower) < 0)
            {
                difference = 0;
            }
            double damage = (difference) * bonus;
            System.Console.WriteLine($"\"{Offense.CharacterChoice.Name}\" yeild {damage} damage to {Defense.CharacterChoice.Name}!");
            if (Defense.CharacterChoice.Health - damage < 0)
            {
                Defense.CharacterChoice.Health = 0;
            }
            else
            {
                Defense.CharacterChoice.Health = Defense.CharacterChoice.Health - damage;
            }
        }
    }
}