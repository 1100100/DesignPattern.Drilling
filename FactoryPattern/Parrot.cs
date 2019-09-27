using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class Parrot : IAnimal
    {
        public string Say()
        {
            return "I am parrot!";
        }
    }
}
