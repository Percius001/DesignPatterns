﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Prototype
{
    internal class ColorManager
    {
        private Dictionary<string,ColorPrototype> _colors = new Dictionary<string,ColorPrototype>();

        public ColorPrototype this[string key]
        {
            get { return _colors[key]; }
            set { _colors[key] = value; }
        }
    }
}
