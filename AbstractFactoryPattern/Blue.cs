using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public class Blue : IColor
    {
        public string SayColor()
        {
            return "This is blue!";
        }
    }
}
