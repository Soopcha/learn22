using System;
using System.Runtime.InteropServices.Marshalling;

namespace project
{
    abstract class RobotAbstract: IRun, IJump  //абстрактный класс - есть реализация некоторых методов
    {

        private string name;
        private int weight;
        private byte[] coordinates;

        public static int count;

        protected string surname;



        public RobotAbstract()
        {
            System.Console.WriteLine("Object has been created");
        }

        public RobotAbstract(string name_, int weight_, byte[] coordinates_)
        {
            System.Console.WriteLine("Object has been created");
            this.setValues(name_, weight_, coordinates_);
        }

        public void setValues(string name, int weight, byte[] coordinates)
        {
            this.name = name;
            this.weight = weight;
            this.coordinates = coordinates;

        }
        public abstract void printValues();



        public static void Print()
        { //this не юзаем в сатич методах и полях
            System.Console.WriteLine("hiiii" + count);

        }

        public void RobotRun()
        {
           System.Console.WriteLine("Robot is now ranning ");
        }

        public void Jump()
        {
            System.Console.WriteLine("Robot is now jumping ");
        }

        // Аксессоры «get» и «set»
        public int Weight
        {
            get
            {
                return this.weight;
            }
            set
            {
                if (value < 1)
                    this.weight = 1;
                else
                    this.weight = value;
            }
        }

        //аксессор сам по себе - как обычное поле по сути
        public int Width { get; set; }
        // public int Width { private get; set; }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {

                this.name = value;
            }
        }

        public byte[] Coordinates
        {
            get
            {
                return this.coordinates;
            }
            set
            {

                this.coordinates = value;
            }
        }

        public float speed { get; set; }
        public float y { get; set; }
    }
}