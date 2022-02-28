using PA2.Attacks;
namespace PA2
{
    public class Angelica: Character
    {
        public Angelica(){
            
            Name = "Angelica";
            Ability = "Dagger";
            
            Health = 100;
            Power = new System.Random().Next(1,101);
            Defense = new System.Random().Next(1, System.Convert.ToInt32(Power));

            Attack = new Dagger();
            Defend = new Defense();
        }
    }
}