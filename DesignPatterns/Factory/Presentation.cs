using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    internal abstract class Presentation
    {
        List<Section> sections = new List<Section>();
        public List<Section> Sections { get { return sections; } }
        public Presentation() {
            this.AddSections();
        }
        public abstract void AddSections();
    }
}
