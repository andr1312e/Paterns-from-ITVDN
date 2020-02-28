using System;

namespace PatternAbstarctFactory
{
    //Содержит набор абстрактных фабричных методов. Они описывают взаимодествие между объектами
    //и имеют возвращаемые значения абстрактных продуктов, тем самым позволяя
    //применять технику абстрагирования процесса инстанцирования
    public abstract class AbstractFactory
    {
        public abstract AbstractProductA CreateProductA();


        public abstract AbstractProductB CreateProductB();

    }
}