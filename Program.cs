// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

namespace project
{
    class Program
    {
        static void Main()
        {
            // так не надо

            // RobotLoh robot = new RobotLoh();
            // robot.weight = 800;
            // robot.name = "Bpt";
            // robot.coordinates = new byte [] {0,0,0};

            // RobotLoh bot = new RobotLoh();
            // bot.weight = 800;
            // bot.name = "Bip";
            // bot.coordinates = new byte [] {0,0,0};

            // System.Console.WriteLine(robot.name);

            Robot robot = new Robot();
            robot.setValues("Bot", 600, new byte[] { 0, 1, 1 });
            robot.printValues();

            Robot.count = 5;
            Robot.Print();



            robot.Weight = -1000;
            System.Console.WriteLine("robot.Weight is " + robot.Weight); //автоматически гет будет


            robot.Width = -1000;
            System.Console.WriteLine("robot.Width is " + robot.Width);
            System.Console.WriteLine("robot.Weight is " + robot.Weight); // те с весом не связанно


            Killer killer = new Killer("Killer", 4500, new byte[] { 0, 1, 1 },100);
            //killer.setValues("Killer", 4500, new byte[] { 0, 1, 1 });
            killer.printValues();
            //killer.Health = 1000;
            System.Console.WriteLine(killer.Health);
            killer.Lazer();

        }
    }
}
