using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.testSuite
{
    class CreationalTestSuite : TestSuite
    {
        public override void createTest()
        {
            Patterns.Add(new FactoryPattern());
            Patterns.Add(new AbstractFactoryPattern());
        }
    }
}
