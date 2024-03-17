using System;
using System.Runtime.InteropServices.Marshalling;

namespace project
{
    class Robot
    {

        //private protected - внтри классов наследников тоже public модификаторы  доступа
        private string name;
        private int weight;
        private byte[] coordinates;

        public static int count;

        protected string surname;


        //кострукторов сколько угодно
        public Robot()
        {
            System.Console.WriteLine("Object has been created");
        } // конструктор по умолчанию

        public Robot(string name_, int weight_, byte[] coordinates_)
        {
            System.Console.WriteLine("Object has been created");
            this.setValues(name_, weight_, coordinates_);
        }

        public void setValues(string name_, int weight_, byte[] coordinates_)
        {
            // this.name = name;
            // this.weight = weight;
            // this.coordinates = coordinates;  - так лучше
            name = name_;
            weight = weight_;
            coordinates = coordinates_;
        }
        public void printValues()
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

    }
}