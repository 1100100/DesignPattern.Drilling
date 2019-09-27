using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{

    public abstract class AbstractFactory
    {
        public abstract IAnimal GetAnimal(Animal animal);

        public abstract IColor GetColor(Color color);
    }
}
