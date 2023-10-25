using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace version3
{
    public class Task4

    {
        abstract class Animal
        {
            public abstract string MakeSound();
        }

        class Dog : Animal
        {
            public override string MakeSound()
            {
                return "Woof";
            }
        }

        class Cat : Animal
        {
            public override string MakeSound()
            {
                return "Meow";
            }
        }
        public void task4()
        {
            Animal dog = new Dog();
            Animal cat = new Cat();

            Console.WriteLine("Dog says: " + dog.MakeSound());
            Console.WriteLine("Cat says: " + cat.MakeSound());
        }
    }

}
