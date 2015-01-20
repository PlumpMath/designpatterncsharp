using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.creational.factory
{
    abstract class Creator
    {
        public abstract Product FactoryMethod();
    }
}
