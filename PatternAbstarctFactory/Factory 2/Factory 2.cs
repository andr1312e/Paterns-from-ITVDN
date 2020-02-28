using System;
using System.Collections.Generic;
using System.Text;

namespace PatternAbstarctFactory.Factory_2
{
    public class Factory_2:AbstractFactory
    {
        public override AbstractProductA CreateProductA() 
        {
            return new ProductA2();
        }
        public override AbstractProductB CreateProductB()
        {
            return new ProductB2();
        }
    }
}
