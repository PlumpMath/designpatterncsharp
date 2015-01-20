using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.testSuite
{
   abstract class TestSuite
    {
        private List<Pattern> _patterns=new List<Pattern>();
        public TestSuite() 
        {
            this.createTest();
        }
        public List<Pattern> Patterns 
        {
            get { return _patterns; }
        }
        public abstract void createTest();
    }
}
