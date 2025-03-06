using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Adapter
{
    public interface IRobotAdapter
    {
        void MoveTowardsLeft();
        void MoveTowardsRight();
        void MoveTowardsUp();
        void MoveTowardsDown();
    }
}
