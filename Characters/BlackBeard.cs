using PA2.Attacks;
namespace PA2
{
    public class BlackBeard: Character
    {
        public BlackBeard(){
            
            Name = "Black Beard";
            Ability = "Sword";
            
            Health = 100;
            Power = new System.Random().Next(1,101);
            Defense = new System.Random().Next(1, System.Convert.ToInt32(Power));
            
            Attack = new Sword();
            Defend = new Defense();
        }
    }
}