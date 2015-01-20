using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DesignPatterns.creational.example.lookandfeel;
namespace DesignPatterns.testSuite
{
    class AbstractFactoryPattern : Pattern
    {
        public override void run()
        {
            LookAndFeel windowsLookAndFeel = new WindowsLookAndFeel();
            LookAndFeel macLookAndFeel = new MacLookAndFeel();
            Client winClient = new Client(windowsLookAndFeel);
            Client macClient = new Client(macLookAndFeel);
            winClient.Run();
            macClient.Run();
            
        }
    }
}
