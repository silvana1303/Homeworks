using System;
using System.Text;

namespace shoppingspree
{
    public class Product
    {
        private string productName;
        private int cost;

        public Product(string productName, int cost)
        {
            this.ProductName = productName;
            this.Cost = cost;
        }

        public string ProductName
        {
            get { return productName; }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                productName = value;
            }
        }

        public int Cost
        {
            get { return cost; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                cost = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{productName}");
           return sb.ToString().Trim();
           
        }
    }
}