﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory
{
    internal class Lion:Carnivore
    {
        public override void Eat(Herbivore herbivore)
        {
            Console.WriteLine(this.GetType().Name + " eats " + herbivore.GetType().Name);
        }
    }
}
