using System;


namespace project
{
    class Killer : Robot { // : - НАСЛЕДОВАНИЕ от робота  
    //имеем доступы ко всем полям аксессорам конструкторам  паблик и протектед
        
        public int Health {get; set;}

        public void Lazer(){
            System.Console.WriteLine("Laser shooting ");

            this.surname = "Фамилия"; // проверка протектед
        }

        public Killer(string name, int weight, byte[] coordinates, int health): base(name,weight,coordinates){
            // : base - обращение к класссу родителю и они там переданы в конструктор который подходит по этим параметрам
            this.Health = health;
            base.printValues();
        }

        public override void printValues()
        {
            base.printValues(); //изночально выполнен метод из род класса
            System.Console.WriteLine("health"+ this.Health);
        }


    }
}