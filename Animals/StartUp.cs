using System;
using System.Collections.Generic;
using System.Linq;

namespace Animals
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();

           
           

            while (input != "Beast!")
            {
                string[] arrStrings = Console.ReadLine().Split().ToArray();

                string name = arrStrings[0];
                int age = int.Parse(arrStrings[1]);
                string gender = arrStrings[2];

                Animal animal = null;

                if (input == "Dog")
                {
                   animal = new Dog(name, age, gender);
                }
                else if (input == "Frog")
                {
                    animal = new Frog(name, age, gender);
                   
                }
                else if (input == "Cat")
                {
                    animal = new Cat(name, age, gender);
                    
                }
                else if (input == "Kitten")
                {
                   animal = new Kitten(name, age);
                 
                }
                else if (input == "Tomcat")
                {
                    animal = new Tomcat(name, age);
                }

                Console.WriteLine(animal.ToString());

                input = Console.ReadLine();
            }

           
        }
    }
}
