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

    }
}