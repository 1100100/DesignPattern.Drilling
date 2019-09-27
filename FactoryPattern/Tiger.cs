using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class Tiger : IAnimal
    {
        public string Say()
        {
            return "I am tiger!";
        }
    }
}
