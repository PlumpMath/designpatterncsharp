using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.creational.abstractFatory
{
    class Client 
    {
        private AbstractProductA productA;
        private AbstractProductB productB;
        public Client(AbstractFactory factory)
        {
            productA = factory.CreateProductA();
            productB = factory.CreateProductB();
        }
        public void Run() 
        {
            productB.Interact(productA);
        }
    }
}
