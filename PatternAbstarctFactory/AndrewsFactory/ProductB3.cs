using System;
using System.Collections.Generic;
using System.Text;

namespace PatternAbstarctFactory.AndrewsFactory
{
    public class ProductB3:AbstractProductB
    {
        public override void Interuct(AbstractProductA abstractProductA)
        {
            System.Console.WriteLine("Andrew's Factory " + this.ToString());
        }
    }
}
