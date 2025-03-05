using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Bridge
{
    public class History : ISubject
    {
        public void Teach()
        {
            Console.WriteLine("Tech History Subject");
        }
    }
}
