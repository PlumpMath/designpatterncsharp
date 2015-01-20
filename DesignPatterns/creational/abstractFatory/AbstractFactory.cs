﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.creational.abstractFatory
{
    abstract class AbstractFactory
    {
        public abstract AbstractProductA CreateProductA();
        public abstract AbstractProductB CreateProductB();
    }
}
