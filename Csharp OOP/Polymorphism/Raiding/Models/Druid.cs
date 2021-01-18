using System;
using System.Text;

namespace Raiding
{
    public class Druid : BaseHero
    {
        public Druid(string name) : base(name)
        {
            Power = 80;
        }

        public override void CastAbility()
        {
            Console.WriteLine($"{ GetType().Name} - {this.Name} healed for {this.Power}");
        }
    
    }
}