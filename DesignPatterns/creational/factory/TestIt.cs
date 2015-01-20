using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.creational.factory
{
    class TestIt
    {
        public void run() 
        {
            Creator[] creators = new Creator[2];
            creators[0] = new ConcreteCreatorA();
            creators[1] = new ConcreteCreatorB();
            foreach (Creator creator in creators) 
            {
                Product product = creator.FactoryMethod();
                Console.WriteLine("Created {0}",
                product.GetType().Name);
                Console.ReadKey();
            }

        }
    }
}
