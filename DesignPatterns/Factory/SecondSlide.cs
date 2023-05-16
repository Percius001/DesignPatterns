using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    internal class SecondSlide:Presentation
    {
        public override void AddSections()
        {
            Sections.Add(new Title());
            Sections.Add(new Content());
        }
    }
}
