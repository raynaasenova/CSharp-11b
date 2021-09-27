using System;
namespace Human
{
    class Program
    {
        static void Main(string[] args) //входна точка на програмата
        {
            Human person1 = new Human(); //не се различават по нищо
            Human person2 = new Human(); 

            person1.name = "Stoyan"; //Даваме характеристики на човека
            person1.age = 25;

            person2.name = "Ivan"; 
            person2.age = 20;

            Console.WriteLine(person1.name + ": " + person1.age);
            Console.WriteLine(person2.name + ": " + person2.age);
        }
    }
}
