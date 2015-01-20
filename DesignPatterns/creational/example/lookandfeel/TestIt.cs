using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.creational.example.lookandfeel
{
    class TestIt
    {
        public void Run() 
        {
            LookAndFeel windowsLookAndFeel = new WindowsLookAndFeel();
            LookAndFeel macLookAndFeel = new MacLookAndFeel();
            Client winClient = new Client(windowsLookAndFeel);
            Client macClient = new Client(macLookAndFeel);
            winClient.Run();
            macClient.Run();
            Console.ReadKey();

        }
    }
}
