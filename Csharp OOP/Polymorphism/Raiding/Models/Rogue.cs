using System;
using System.Text;

namespace Raiding
{
    public class Rogue : BaseHero
    {
        public Rogue(string name) : base(name)
        {
            Power = 80;
        }

        public override void CastAbility()
        {
            Console.WriteLine($"{ GetType().Name} - {this.Name} hit for {this.Power} damage");
        }
    
    }
}