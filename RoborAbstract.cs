using System;
using System.Runtime.InteropServices.Marshalling;

namespace project
{
    abstract class RobotAbstract  //абстрактный класс - как интерфейс
    {

        private string name;
        private int weight;
        private byte[] coordinates;

        public static int count;

        protected string surname;


        
        public Robot()
        {
            System.Console.WriteLine("Object has been created");
        } 

        public Robot(string name_, int weight_, byte[] coordinates_)
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
        public virtual void printValues()
        {
            System.Console.WriteLine(name + "  " + weight + "  ");
            foreach (byte el in coordinates)
                System.Console.WriteLine(el);

        }


        public static void Print()
        { //this не юзаем в сатич методах и полях
            System.Console.WriteLine("hiiii" + count);

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
        public int Width {get; set; }
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
    }
}