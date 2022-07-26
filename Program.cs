
using System;

namespace MathTask
{
    class MathTaskOne
    {
    
        public static void Main()
        {
                        
            double mealCost = Double.Parse(Console.ReadLine());
            int tipPercent = Int32.Parse(Console.ReadLine());
            int taxPercent = Int32.Parse(Console.ReadLine());
            
            double tip = mealCost * tipPercent / 100;
            double tax = mealCost * taxPercent / 100;
            
            double totalCost = mealCost + tip + tax;
            
            Console.WriteLine("The total meal cost is " + Math.Round(totalCost) + " dollars.");
            
            
        }
        
    }
    
}