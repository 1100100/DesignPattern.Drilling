using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public enum Color
    {
        Blue,
        Red
    }
    public class ColorFactory : AbstractFactory
    {
        public override IAnimal GetAnimal(Animal animal)
        {
            return null;
        }

        public override IColor GetColor(Color color)
        {
            switch (color)
            {
                case Color.Blue:
                    return new Blue();
                case Color.Red:
                    return new Red();
                default:
                    throw new NotSupportedException();
            }
        }
    }
}
