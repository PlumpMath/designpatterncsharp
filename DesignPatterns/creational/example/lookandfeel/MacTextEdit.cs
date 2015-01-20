using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.creational.example.lookandfeel
{
    class MacTextEdit : TextEdit
    {
        public override void inteact(Button a)
        {
            Console.WriteLine(this.GetType().Name +
                " interacts with " + a.GetType().Name);
        }
    }
}
