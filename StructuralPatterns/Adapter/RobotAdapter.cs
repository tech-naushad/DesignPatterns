using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Adapter
{
    public class RobotAdapter : IRobotAdapter
    {
        private readonly LegacyRobot _legacyRobot;
        public RobotAdapter(LegacyRobot legacyRobot)
        {
            _legacyRobot = legacyRobot;
        }
        public void MoveTowardsLeft()
        {
            _legacyRobot.MoveLeft();
        }
        public void MoveTowardsRight()
        {
            _legacyRobot.MoveRight();
        }
        public void MoveTowardsUp()
        {
            _legacyRobot.MoveUp();
        }
        public void MoveTowardsDown()
        {
            _legacyRobot.MoveDown();
        }
        
    }
}
