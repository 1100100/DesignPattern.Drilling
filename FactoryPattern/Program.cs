using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new AnimalFactory();

            var parrot = factory.GetAnimal(Animal.Parrot);
            Console.WriteLine(parrot.Say());

            var tiger = factory.GetAnimal(Animal.Tiger);
            Console.WriteLine(tiger.Say());

            Console.ReadKey();
        }
    }
}
