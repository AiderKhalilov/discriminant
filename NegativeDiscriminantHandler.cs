using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class NegativeDiscriminantHandler : DiscriminantHandler

    {
        public override void Handle(QuadraticEquation equation)
        {
            double discriminant = equation.CalculateDiscriminant();
            if (discriminant < 0)
            {
                Console.WriteLine("Discriminant is negative. Complex roots");
            }

        }
    }
}
