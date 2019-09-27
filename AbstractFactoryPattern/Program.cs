using System;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var animalFactory = FactoryProducer.GetFactory("animal");

            var parrot = animalFactory.GetAnimal(Animal.Parrot);
            Console.WriteLine(parrot.Say());
            var tiger = animalFactory.GetAnimal(Animal.Tiger);
            Console.WriteLine(tiger.Say());

            var colorFactory = FactoryProducer.GetFactory("color");
            var blue = colorFactory.GetColor(Color.Blue);
            Console.WriteLine(blue.SayColor());
            var red = colorFactory.GetColor(Color.Red);
            Console.WriteLine(red.SayColor());

            Console.ReadKey();
        }
    }
}
