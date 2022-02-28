using PA2.Attacks;
namespace PA2
{
    public class JackTheMonkey: Character
    {
        public JackTheMonkey(){
            
            Name = "Jack The Monkey";
            Ability = "Claws";
            
            Health = 100;
            Power = new System.Random().Next(1,101);
            Defense = new System.Random().Next(1, System.Convert.ToInt32(Power));
            
            Attack = new Claws();
            Defend = new Defense();
        }
    }
}