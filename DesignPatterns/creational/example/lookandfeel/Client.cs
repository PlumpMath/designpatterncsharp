using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.creational.example.lookandfeel
{
    class Client
    {
        private TextEdit textEdit;
        private Button button;
        public Client(LookAndFeel lookAndFeel) 
        {
            textEdit = lookAndFeel.CreateTextEdit();
            button = lookAndFeel.CreateButton();
        }
        public void Run() 
        {
            textEdit.inteact(button);
        }
    }
}
