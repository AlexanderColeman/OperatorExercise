using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorExercise
{
    public class Methods
    {

        public static void AreaOfCircle()
        {
            Console.WriteLine("What is the radius of your circle");

            double radius = Convert.ToDouble(Console.ReadLine());
            double area = Math.Round(Math.PI * Math.Pow(radius, 2),2);

            Console.WriteLine($"The area of a circle with a radius of {radius} is: {area}");
        }
    }
}
