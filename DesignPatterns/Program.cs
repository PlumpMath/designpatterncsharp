using System;
using System.Text;
using DesignPatterns.testSuite;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            TestSuite creationalPatterns = new CreationalTestSuite();
            foreach (Pattern pattern in creationalPatterns.Patterns) 
            {
                pattern.run();
            }
            Console.ReadKey();
        }
    }
}
