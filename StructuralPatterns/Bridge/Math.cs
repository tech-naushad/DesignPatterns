using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Bridge
{
    public class Math : ISubject
    {
        public void Teach()
        {
            Console.WriteLine("Tech Math Subject");
        }
    }
}
