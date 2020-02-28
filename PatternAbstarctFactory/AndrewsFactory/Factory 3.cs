using System;
using System.Collections.Generic;
using System.Text;

namespace PatternAbstarctFactory.AndrewsFactory
{
    public class Factory_3 : AbstractFactory
    {
        public override AbstractProductA CreateProductA() 
        {
            return new ProductA3();
        }
        public override AbstractProductB CreateProductB() 
        {
            return new ProductB3();
        }
    }
}
