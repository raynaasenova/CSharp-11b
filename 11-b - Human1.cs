using System;
using System.Collections.Generic;
using System.Text;

namespace Human
{
    //Съзваме клас Person - рецепта за създаване на един човек
    //Абстрактен тип данни, който създаваме ние, за разлика от примитивните типове данни, които се съдържат в C# като int, doube, string.
    class Human
    {//можем да декларираме променливи - в случая се наричат полета (properties, instancse variable). Не е добре всеки да може да променя и задава свойствата, например - да ви прекръсти името! 	

        public string name;
        public int age;
    }
}
