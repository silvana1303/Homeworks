using System;

namespace Raiding
{
    public abstract class BaseHero : IBaseHero
    {
        public string Name { get; set; }
        public int Power { get; set; }

        protected BaseHero(string name)
        {
            Name = name;
        }

        public abstract void CastAbility();

    }
}