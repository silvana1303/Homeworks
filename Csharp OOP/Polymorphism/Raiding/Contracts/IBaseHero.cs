namespace Raiding
{
    public interface IBaseHero
    {
        public string Name { get; set; }
        public  int Power { get; set; }

        public void CastAbility();
    }
}