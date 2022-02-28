using System;
using PA2.Interfaces;
namespace PA2.Attacks
{
    public class Cannnon: IAttack
    {
        public double Attack(string Name, double Power){

            double power = new Random().Next(1,Convert.ToInt32(Power));
            Console.WriteLine($"\"{Name}\" fired a cannon with {power} strength!");
            
            return power;
        }
    }
}