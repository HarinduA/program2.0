using System;

namespace MethodOverloarding
{
    public class Test() 
    {
        
        public void animalSound() 
        {
            Console.WriteLine("The animal makes a sound");
        }
        }

        class Pig : Test  // Derived class (child) 
        {
        public void animalSound() 
        {
            Console.WriteLine("The pig says: wee wee");
        }
        }

        class Dog : Test // Derived class (child) 
        {
        public void animalSound() 
        {
            Console.WriteLine("The dog says: bow wow");
        }
    }

}

