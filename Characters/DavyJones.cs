using PA2.Attacks;
namespace PA2
{
    public class DavyJones: Character
    {
        public DavyJones(){
            
            Name = "Davy Jones";
            Ability = "Cannon fire";
            
            Health = 100;
            Power = new System.Random().Next(1,101);
            Defense = new System.Random().Next(1, System.Convert.ToInt32(Power));

            Attack = new Cannnon();
            Defend = new Defense();
        }
    }
}