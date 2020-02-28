namespace PatternAbstarctFactory.Factory_2
{
    internal class ProductB2 : AbstractProductB
    {
        public override void Interuct(AbstractProductA abstractProductA)
        {
            System.Console.WriteLine("This is factory 2 " + this.ToString() + " " + abstractProductA.ToString());
        }
    }
}