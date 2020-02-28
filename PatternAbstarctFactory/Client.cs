using System;

namespace PatternAbstarctFactory
{
    //Класс Клиент создает и использует продукты пользуясь интерфейсами абстрактных классов
    //Ему ничего не известно про конкретные классы
    //СВЯЗЬ
    //Класс Клиент связан связями отношения ассоциации с классами абстрактных продуктов и фабрики
    //Конкретные классы связаны наследованием и их абстрактными вариантами
    //
    public class Client
    {
        AbstractProductA abstractProductA;
        AbstractProductB abstractProductB;

        public Client(AbstractFactory abstractFactory)
        {
            abstractProductA = abstractFactory.CreateProductA();
            abstractProductB = abstractFactory.CreateProductB();
        }
        public void Run()
        {
            abstractProductB.Interuct(abstractProductA);
        }
    }
}
