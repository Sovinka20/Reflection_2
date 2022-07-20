using NUnit.Framework.Internal;
using System;
using System.Reflection;

namespace Reflection1
{
    // Сам абстрактный класс
   abstract class Cat
    {
        // Поля этого класса
        public int age = 1;
        public string name;
        public int tailCount = 4;

    }
        class  Cat1 : Cat {
        // Конструкторы для переменных абстрактного класса
        public int Age(int age)
        {          
            return age;
        }
        public string Name(string name)
        {
            return name;
        }
        public int TailCount(int tailCount)
        {
            return tailCount;
        }

    }

    class Program
    {
            
        static void Main(string[] args)
        {
            //Задание: Создайте экземпляр абстрактного класса с помощью рефлексии

            // Создание экземпляра класса через рефлексию
            Type type1 = typeof(Cat1);
            object obj = Activator.CreateInstance(type1);
            var rr = (Cat1)obj;

            // Запись новых значений в переменные
            int tt = rr.Age(1);
            Console.WriteLine("age = {0} \n", tt);
            string tt1 = rr.Name("Barsik");
            Console.Write("name = {0} \n", tt1);
            int tt2 = rr.TailCount(0);
            Console.Write("tailCount = {0} \n", tt2);

            Console.ReadKey();

        }
    }
    
}