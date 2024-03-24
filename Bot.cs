using System;
using System.Runtime.InteropServices.Marshalling;
namespace project
{
    class Bot : RobotAbstract 
    {

        public Bot()
        {

        }

        public Bot(string name, int weight, byte[] coordinates) : base(name, weight, coordinates)

        {
        }

        public override void printValues()
        {
            System.Console.WriteLine(this.Name+ " weight "+ this.Weight + " Coordinates ");
            foreach(byte el in this.Coordinates)
            System.Console.WriteLine(el);
        }
    }
}