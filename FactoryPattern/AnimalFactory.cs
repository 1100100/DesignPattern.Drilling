using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public enum Animal
    {
        Parrot,
        Tiger
    }
    public class AnimalFactory
    {
        public IAnimal GetAnimal(Animal animal)
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
    }
}
