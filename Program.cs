using System;

namespace Basics
{
    
    class Person
    {
        public string Name;
        public int Age;
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        // Convert Person to int.
        public static implicit operator int(Person p) 
        {
            return p.Age;
        }
        //Convert int to Person
        public static implicit operator Person(int i)
        {
            return new Person("Tina", i);// ("Tina" is Latin for "No one".)
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Mike", 25);
            //Convert a Person object to an int.
            int age = person1;
            Console.WriteLine("Person info: {0}, {1}", person1.Name, age);
            //Convert an int to a Person object
            Person Person2 = 35;
            Console.WriteLine("Person info: {0}, {1}", Person2.Name, Person2.Age);

            Console.ReadLine();
        }
    }
}
