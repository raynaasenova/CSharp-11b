using System;

namespace Human3
{
    class Program
    {
        static void Main(string[] args)
        {
            Human person1 = new Human(); //не се различават по нищо
            Human person2 = new Human(); 

            person1.Name = "Stoyan"; //Даваме характеристики на човека
            person1.Age = 25;

            person2.Name = "Ivan";
            person2.Age = 20;

            Console.WriteLine(person1.Name + ": " + person1.Age);
            Console.WriteLine(person2.Name + ": " + person2.Age);
        }
    }
}
