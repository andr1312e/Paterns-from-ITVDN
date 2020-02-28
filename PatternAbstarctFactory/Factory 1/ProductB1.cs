using System;

namespace PatternAbstarctFactory.Concrete
{
    internal class ProductB1:AbstractProductB
    {
        public ProductB1()
        {
        }
        public override void Interuct(AbstractProductA abstractProductA)
        {
            Console.WriteLine(this.ToString() + " interact with " + abstractProductA.ToString());
        }
    }
}