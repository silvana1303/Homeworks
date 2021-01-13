using System;
using System.Collections.Generic;
using System.Linq;

namespace pizzacalories
{
    public class Pizza
    {
        private string name;
        private Dough dough;
        private List<Topping> toppings;

        public Pizza(string name, Dough dough)
        {
            this.Name = name;
            this.Dough = dough;
            this.toppings = new List<Topping>();
        }

        public string Name
        {
            get { return name; }
            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value) || value.Length < 1 || value.Length > 15)
                {
                   throw new Exception("Pizza name should be between 1 and 15 symbols.");
                }
                name = value;
            }
        }

        public Dough Dough
        {
            get
            {
                return dough;
            }
            set
            {
                dough = value;
            }
        }

        public IReadOnlyCollection<Topping> Toppings
        {
            get { return toppings.AsReadOnly(); }
           
        }

        public void AddTopping(Topping topping)
        {
            if (Toppings.Count < 10)
            {
                toppings.Add(topping);
            }
            else
            {
                throw new Exception("Number of toppings should be in range [0..10].");
            }
            
        }

        public double TotalCalories()
        {
            double sum = this.Dough.CalculateCalories() + Toppings.Sum(x => x.CalculateTopping());
            return sum;
        }

        public override string ToString()
        {
            return $"{this.Name} - {this.TotalCalories():f2} Calories.";
        }
    }
}