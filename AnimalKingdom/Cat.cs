namespace AnimalKingdom
{
    public class Cat : Animal, IMammal
    {
        public int NumberOfNipples {get; } = 2;
        public override string Sound()
        {
            return base.Sound() + "Miau";
        }
    }
}
