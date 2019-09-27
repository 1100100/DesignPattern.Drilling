using System;

namespace AbstractFactoryPattern
{
    public enum Animal
    {
        Parrot,
        Tiger
    }
    public class AnimalFactory : AbstractFactory
    {
        public override IAnimal GetAnimal(Animal animal)
        {
            switch (animal)
            {
                case Animal.Parrot:
                    return new Parrot();
                case Animal.Tiger:
                    return new Tiger();
                default:
                    throw new NotSupportedException();
            }
        }

        public override IColor GetColor(Color color)
        {
            return null;
        }
    }
}
