using System;

namespace AbstractFactoryPattern
{
    public class FactoryProducer
    {
        public static AbstractFactory GetFactory(string type)
        {
            switch (type.ToLower())
            {
                case "animal":
                    return new AnimalFactory();
                case "color":
                    return new ColorFactory();
                default:
                    throw new NotSupportedException();
            }
        }
    }
}
