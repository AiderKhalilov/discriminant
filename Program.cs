using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter value for A: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter value for B: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter value for C: ");
            double c = Convert.ToDouble(Console.ReadLine());


            QuadraticEquation equation = new QuadraticEquation(a, b, c);
            DiscriminantSolver solver = new DiscriminantSolver();
            solver.Solve(equation);

            Console.ReadLine();
        }
    }
}
