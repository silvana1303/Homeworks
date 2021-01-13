using System;
using System.Collections.Generic;
using System.Text;

namespace shoppingspree
{
    public class Person
    {
        private string personName;
        private int money;
        private List<Product> bagProducts;

        public Person(string personName, int money)
        {
            this.PersonName = personName;
            this.Money = money;
            this.bagProducts = new List<Product>();
        }

        public string PersonName
        {
            get { return personName; }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                personName = value;
            }
        }

        public int Money
        {
            get { return money; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                money = value;
            }
        }

        public IReadOnlyCollection<Product> BagProducts => bagProducts.AsReadOnly();

        public void BuyProduct(Product rightProduct)
        {
            if (this.Money >= rightProduct.Cost)
            {
                this.Money -= rightProduct.Cost;
                bagProducts.Add(rightProduct);
                Console.WriteLine($"{this.PersonName} bought {rightProduct}");
            }
            else
            {
                Console.WriteLine($"{this.PersonName} can't afford {rightProduct}");
            }

        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            if (this.bagProducts.Count == 0)
            {
                sb.AppendLine($"{personName} - Nothing bought");
                return sb.ToString().TrimEnd();
            }

            sb.AppendLine($"{personName} - {string.Join(", ", bagProducts)}");

            return sb.ToString().Trim();

        }
    }
}