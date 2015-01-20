using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.creational.example.lookandfeel
{
    class WindowsLookAndFeel : LookAndFeel
    {
        public override Button CreateButton()
        {
            return new WinButton();
        }
        public override TextEdit CreateTextEdit()
        {
            return new WinTextEdit();
        }
    }
}
