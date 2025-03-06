namespace StructuralPatterns.Adapter
{
    class Program
    {
        static void Main()
        {
            var robotAdapter = new RobotAdapter(new LegacyRobot());

            robotAdapter.MoveTowardsLeft();
            robotAdapter.MoveTowardsRight();
            robotAdapter.MoveTowardsUp();
            robotAdapter.MoveTowardsDown();
        }
    }
}
