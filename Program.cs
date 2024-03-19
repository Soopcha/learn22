// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;
using System.Collections.Generic;

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


            Killer killer = new Killer("Killer", 4500, new byte[] { 0, 1, 1 }, 100);
            //killer.setValues("Killer", 4500, new byte[] { 0, 1, 1 });
            killer.printValues();
            //killer.Health = 1000;
            System.Console.WriteLine(killer.Health);
            killer.Lazer();



            System.Console.WriteLine();
            System.Console.WriteLine();


            //массив указателей
            List<Robot> robots = new List<Robot>();
            robots.Add(new Robot("Alex", 400, new byte[] { 0, 1, 1 }));
            robots.Add(new Robot("Bob", 400, new byte[] { 0, 1, 1 }));
            robots.Add(new Robot("Dad", 400, new byte[] { 0, 1, 1 }));
            robots.Add(new Robot("Alexyi", 400, new byte[] { 0, 1, 1 }));

            foreach (Robot obj in robots)
            {
                System.Console.WriteLine(obj.Name);
            }


            //оператор as - обрабатываем обьект как обьект другого класса
            List<Killer> robotsKill = new List<Killer>();
            robotsKill.Add(new Killer("Alex", 400, new byte[] { 0, 1, 1 }, 200));
            robotsKill.Add(new Killer("Bob", 400, new byte[] { 0, 1, 1 }, 300));
            robotsKill.Add(new Killer("Dad", 400, new byte[] { 0, 1, 1 }, 400));
            robotsKill.Add(new Killer("Alexyi", 400, new byte[] { 0, 1, 1 }, 300));

            //хотим обрабатывать обьект с именем "Alex" как обьект класса robot
            //можем сделать тк robot - родитель robotsKill
            Robot newRobot = null;
            foreach (Killer obj in robotsKill)
            {
                if (obj.Name == "Alex")
                {
                    newRobot = obj as Robot; //определенный обьект приводим к типу данных определенному
                    //лазер уже не работает
                }
                System.Console.WriteLine(obj is Robot);
                System.Console.WriteLine(obj is Program);
                System.Console.WriteLine(obj is int);
            }

            int num = 9;
            System.Console.WriteLine(num is float);
            //оператор is - проверка принадлежит ли обьект к опред типу данных




            killer.printValues();
            robot.printValues();



            //абстрактные классы - интерфейсы
            Bot botA = new Bot("Bot",800, new byte[] { 0, 1, 1 });
        }
    }
}
