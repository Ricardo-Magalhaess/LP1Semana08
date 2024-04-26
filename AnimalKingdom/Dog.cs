namespace AnimalKingdom
{
    public class Dog : Animal, IMammal
    {
        public int NumberOfNipples {get; } = 2;
        public override string Sound()
        {
            return base.Sound() + "Woof!";
        }
    }
}
