using PA2.Attacks;
namespace PA2
{
    public class WillTurner: Character
    {
        public WillTurner(){
            
            Name = "Will Turner";
            Ability = "Sword";
            
            Health = 100;
            Power = new System.Random().Next(1,101);
            Defense = new System.Random().Next(1, System.Convert.ToInt32(Power));

            Attack = new Sword();
            Defend = new Defense();
        }
    }
}