using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calbmi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double weight, height;
            Console.WriteLine("Input Weight (kg) : ");
            double.TryParse(Console.ReadLine(), out weight);

            Console.WriteLine("Input Height (cm) : ");
            double.TryParse(Console.ReadLine(), out height);

            double bmi = weight / Math.Pow(height/100, 2);
            Console.WriteLine("BMI = {0:F2}", bmi);
            Console.ReadKey();
        }
    }
}
