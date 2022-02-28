using System;
using PA2.Interfaces;
namespace PA2.Attacks
{
    public class Defense: IDefend
    {
        double IDefend.Defend(string Name, double Defense){

            double power = new Random().Next(1,Convert.ToInt32(Defense));
            Console.WriteLine($"\"{Name}\" defended with {power} strength!");
            
            return power;
        }
    }
}