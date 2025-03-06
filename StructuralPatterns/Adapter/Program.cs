namespace StructuralPatterns.Adapter
{
    //Client Code. It can be changed as per the caller like from API, Web app, console app etc...
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
