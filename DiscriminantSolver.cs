using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class DiscriminantSolver
    {
        private readonly List<DiscriminantHandler> _handlers;

        public DiscriminantSolver()
        {
            _handlers = new List<DiscriminantHandler>()
            {
                new NegativeDiscriminantHandler(),
                new PositiveDiscriminantHandler(),
                new ZeroDiscriminantHandler()
            };
        }

        public void Solve(QuadraticEquation equation)
        {
            foreach (var handler in _handlers)
            {
                handler.Handle(equation);
            }
        }
    }
}
