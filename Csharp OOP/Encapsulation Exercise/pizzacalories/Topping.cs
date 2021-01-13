using System;

namespace pizzacalories
{
    public class Topping
    {
        private string toppingType;
        private double toppingWeight;

        public Topping(string toppingType, double toppingWeight)
        {
            this.ToppingType = toppingType;
            this.Weight = toppingWeight;
        }

        //"[Topping type name] weight should be in the range [1..50].".

        public string ToppingType
        {
            get { return toppingType; }
            private set
            {
                if (value.ToLower() != "meat" && value.ToLower() != "veggies" && value.ToLower() != "cheese" && value.ToLower() != "sauce")
                {
                    throw new Exception($"Cannot place {value} on top of your pizza.");
                }
                toppingType = value;
            }
        }

        public double Weight
        {
            get { return toppingWeight; }
            private set
            {
                if (value < 1 || value > 50)
                {
                    throw new Exception($"{this.ToppingType} weight should be in the range [1..50].");
                }
                toppingWeight = value;
            }
        }

        public double CalculateTopping()
        {
            double toppingModifier = 0;

            if (ToppingType.ToLower() == "meat")
            {
                toppingModifier = 1.2;
            }
            else if (ToppingType.ToLower() == "veggies")
            {
                toppingModifier = 0.8;
            }
            else if (ToppingType.ToLower() == "cheese")
            {
                toppingModifier = 1.1;
            }
            else
            {
                toppingModifier = 0.9;
            }

            double sum = 2 * Weight * toppingModifier;

            return sum;
        }
    }
}