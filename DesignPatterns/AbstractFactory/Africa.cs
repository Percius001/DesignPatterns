using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory
{
    internal class Africa:Country
    {
        public override Herbivore CreateHerbivore()
        {
            return new Wildbeest();
        }

        public override Carnivore CreateCarnivore()
        {
            return new Lion();
        }
    }
}
