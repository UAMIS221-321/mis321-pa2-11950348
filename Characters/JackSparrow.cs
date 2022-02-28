using PA2.Attacks;
namespace PA2
{
    public class JackSparrow: Character
    {
        public JackSparrow(){
            
            Name = "Jack Sparrow";
            Ability = "Distraction";
            
            Health = 100;
            Power = new System.Random().Next(1,101);
            Defense = new System.Random().Next(1, System.Convert.ToInt32(Power));

            Attack = new Distraction();
            Defend = new Defense();
        }
    }
}