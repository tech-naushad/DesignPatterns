using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Adapter
{
    public class LegacyRobot
    {
        public void MoveLeft()
        {
            Console.WriteLine("Moving left.....");
        }

        public void MoveRight()
        {
            Console.WriteLine("Moving right.....");
        }

        public void MoveUp()
        {
            Console.WriteLine("Moving up.....");
        }

        public void MoveDown()
        {
            Console.WriteLine("Moving Down.....");
        }
    }
}
