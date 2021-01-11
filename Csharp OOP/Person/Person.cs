using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
    public class Person
    {
        private string name;
        private int age;

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public virtual string Name //The virtual keyword is used to modify a method, property, indexer, or event declaration and allow for it to
                                   //be overridden in a derived class
        {
            get
            {
                return this.name;
            }

            protected set // всеки наследник го вижда, но не се вижда за външния свят
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Name's length should not be less than 3 symbols!");
                }

                this.name = value;
            }
        }

       

        public virtual int Age
        {
            get
            {
                return this.age; // задължително с малки букви иначе се пълни стака
            }

            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age must be positive!");
                }

                this.age = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(String.Format("Name: {0}, Age: {1}",
                this.Name,
                this.Age));

            return sb.ToString().TrimEnd();
        }
    }
}
