using System;
using System.Collections.Generic;
using System.Text;
namespace Human3
{   //Създаваме клас Human - рецепта за създаване на един човек
    //Абстрактен тип данни, който създаваме ние, за разлика от примитивните типове данни, които се съдържат в C# като int, doube, string.
    //можем да декларираме променливи - в случая се наричат полета (properties, instancse variable). Не е добре всеки да може да променя и задава свойствата, например - да ви прекръсти името! Затова свойствата се правят private и се измислят други методи (accessor methods - Getters and setters), които са за достигане на свойствата. Пропъртитата вече ги достигаме, като се обръщаме към методи. Методите могат да бъдат мислещи.
     // //Дефиниране на prorerties (свойства) - между поле и функция. Пропъртита, които пазят стойностите си в полета.
     //Може да имаме prorerties (свойства), на които да не съответстват полета, както и обратно.
    
    class Human
    {
        private string name;
        private int age;
       
        public string Name //пропъртита
        {
            get { return name; }
            set { name = value; }
        }

        public int Age //пропъртита
        {
            get { return age; }
            set { age = value; }
        }
    }
}
