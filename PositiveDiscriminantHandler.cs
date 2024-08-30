using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class PositiveDiscriminantHandler : DiscriminantHandler
    {
        public override void Handle(QuadraticEquation equation)
        {
            double discriminant = equation.CalculateDiscriminant();
            if (discriminant > 0)
            {
                double root1 = (-equation.B + Math.Sqrt(discriminant)) / (2 * equation.A);
                double root2 = (-equation.B - Math.Sqrt(discriminant)) / (2 * equation.A);

                Console.WriteLine($"Discriminant is positive. Roots of equation: {root1} and {root2}");
            }
        }
    }
}
