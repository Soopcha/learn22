using System;
namespace project {
    struct Book{//структура - что-то меньше класса

        private string title, avtor, intro;
        private short pages;
        public void setValues (string title, string avtor){
            this.title = title;
            this.avtor = avtor;
        }
        public void printValues(){
            System.Console.WriteLine(this.avtor + " написал книгу" + this.title);
        }
    }
}