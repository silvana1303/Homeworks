namespace foodShortage
{
    public class Citizen : IName, IAge, IBuyer
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Food { get; set; }
        public string Id { get; set; }
        public string Birthdate { get; set; }

        public Citizen(string name, int age, string id, string birthday)
        {
            Name = name;
            Age = age;
            Food = 0;
            Id = id;
            Birthdate = birthday;
        }

        public void BuyFood()
        {
            this.Food += 10;
        }
    }
}