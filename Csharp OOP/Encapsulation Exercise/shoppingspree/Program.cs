using System;
using System.Collections.Generic;
using System.Linq;

namespace shoppingspree
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] persons = Console.ReadLine().Split(new [] {';'}, StringSplitOptions.RemoveEmptyEntries);
            string[] products = Console.ReadLine().Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

            try
            {
                List<Person> people = new List<Person>();
                List<Product> allProducts = new List<Product>();

                string personName = string.Empty;
                int money = 0;
                string productName = string.Empty;
                int cost = 0;

                Person person = null;
                Product product = null;

                foreach (var x in persons)
                {
                    string[] personData = x.Split(new [] {'='}, StringSplitOptions.RemoveEmptyEntries);

                    personName = personData[0];
                    money = int.Parse(personData[1]);
                    person = new Person(personName, money);
                    people.Add(person);
                }

                foreach (var y in products)
                {
                    string[] personData = y.Split(new[] { '=' }, StringSplitOptions.RemoveEmptyEntries);

                    productName = personData[0];
                    cost = int.Parse(personData[1]);
                    product = new Product(productName, cost);
                    allProducts.Add(product);
                }


                string[] command = Console.ReadLine().Split();

                while (command[0] != "END")
                {
                    string buyer = command[0];
                    string productWanted = command[1];

                    Person rightbuyer = people.FirstOrDefault(x => x.PersonName == buyer);
                    Product rightProduct = allProducts.FirstOrDefault(x => x.ProductName == productWanted);

                    rightbuyer.BuyProduct(rightProduct);


                    command = Console.ReadLine().Split();
                }


                foreach (var x in people)
                {
                    Console.WriteLine(x.ToString());
                }
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
                return;
            }

        }
    }
}
