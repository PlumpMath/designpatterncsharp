using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.creational.example.lookandfeel
{
    abstract class LookAndFeel
    {
        public abstract Button CreateButton();
        public abstract TextEdit CreateTextEdit();
    }
}
