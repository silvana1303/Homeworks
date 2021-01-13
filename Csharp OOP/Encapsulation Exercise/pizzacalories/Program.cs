using System;

namespace pizzacalories
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine().Split()[1];
            string[] doughStrings = Console.ReadLine().Split();
            string[] toppingStrings = Console.ReadLine().Split();

            try
            {
                string flourType = doughStrings[1];
                string bakingTech = doughStrings[2];
                double weight = double.Parse(doughStrings[3]);

                Dough dough = new Dough(flourType,bakingTech,weight);

                Pizza pizza = new Pizza(name, dough);

                while (toppingStrings[0] != "END")
                {
                    string toppingType = toppingStrings[1];
                    double toppingWeight = double.Parse(toppingStrings[2]);

                    Topping topping = new Topping(toppingType, toppingWeight);

                    pizza.AddTopping(topping);

                    toppingStrings = Console.ReadLine().Split();
                }

                Console.WriteLine(pizza);
            
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }
        }
    }
}
