using System;

namespace project
{
    class Robot
    {

        //private protected - внтри классов наследников тоже public модификаторы  доступа
        private string name;
        private int weight;
        private byte[] coordinates;

        public void setValues(string name_, int weight_, byte[] coordinates_){
            // this.name = name;
            // this.weight = weight;
            // this.coordinates = coordinates;
            name = name_;
            weight=weight_;
            coordinates=coordinates_;
        }
        public void printValues(){
            System.Console.WriteLine(name + "  " + weight + "  ");
            foreach (byte el in coordinates)
                System.Console.WriteLine(el);
            
        }

    }
}