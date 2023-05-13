using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory
{
    internal abstract class Carnivore
    {
        public abstract void Eat(Herbivore herbivore);
    }
}
