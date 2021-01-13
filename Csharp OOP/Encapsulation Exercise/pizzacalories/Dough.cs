using System;

namespace pizzacalories
{
    public class Dough
    {
        private string flourType;
        private string bakingTech;
        private double weight;

        public Dough(string flourType, string bakingTech, double weight)
        {
            this.FlourType = flourType;
            this.BakingTech = bakingTech;
            this.Weight = weight;
        }
        public string FlourType
        {
            get { return flourType; }
            private set
            {
                if (value.ToLower() != "white" && value.ToLower() != "wholegrain")
                {
                    throw new Exception("Invalid type of dough.");
                }
                flourType = value;
            }
        }

        public string BakingTech
        {
            get { return bakingTech; }
            private set
            {
                if (value.ToLower() != "crispy" && value.ToLower() != "chewy" && value.ToLower() != "homemade")
                {
                    throw new Exception("Invalid type of dough.");
                }
                bakingTech = value;
            }
        }

        public double Weight
        {
            get { return weight; }
            private set
            {
                if (value < 1 || value > 200)
                {
                    throw new Exception("Dough weight should be in the range [1..200].");
                }
                weight = value;
            }
        }

        public double CalculateCalories()
        {
            double bakingModifier = 0;
            double techModifier = 0;

            if (FlourType.ToLower() == "white")
            {
                bakingModifier = 1.5;
            }
            else
            {
                bakingModifier = 1.0;
            }

            if (BakingTech.ToLower() == "crispy")
            {
                techModifier = 0.9;
            }
            else if (BakingTech.ToLower() == "chewy")
            {
                techModifier = 1.1;
            }
            else
            {
                techModifier = 1.0;
            }

            double sum = 2 * Weight * bakingModifier * techModifier;

            return sum;

        }

    }
}