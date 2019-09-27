using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern
{
    public class Red : IColor
    {
        public string SayColor()
        {
            return "This is red!";
        }
    }
}
