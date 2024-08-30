using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class ZeroDiscriminantHandler : DiscriminantHandler
    {
        public override void Handle(QuadraticEquation equation)
        {
            double discriminant = equation.CalculateDiscriminant();
            if (discriminant == 0)
            {
                double root = -equation.B / (2 * equation.A);

                Console.WriteLine($"Discriminant equals 0. Root of equation: {root}");
            }
        }
    }
}
