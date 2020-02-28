using PatternAbstarctFactory;
using System;

namespace Paterns_from_ITVDN
{
    class Program
    {
        public static void Main(string[] args)
        {
            Client client = null;
            client = new Client(new PatternAbstarctFactory.Concrete.Factory1());
            client.Run();
            Console.ReadKey();
        }
    }
}
