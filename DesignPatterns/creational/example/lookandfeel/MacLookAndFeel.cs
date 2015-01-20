using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.creational.example.lookandfeel
{
    class MacLookAndFeel : LookAndFeel
    {
        public override Button CreateButton()
        {
            return new MacButton();
        }
        public override TextEdit CreateTextEdit()
        {
            return new MacTextEdit();
        }
    }
}
