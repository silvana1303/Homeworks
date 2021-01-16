namespace foodShortage
{
    public class Rebel : IName, IAge, IBuyer
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Food { get; set; }
        public string Group { get; set; }

        public Rebel(string name, int age, string @group)
        {
            Name = name;
            Age = age;
            Food = 0;
            Group = @group;
        }
        public void BuyFood()
        {
            this.Food += 5;
        }
    }
}