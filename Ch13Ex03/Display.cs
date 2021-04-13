using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ch13Ex03
{
    class Display
    {
        public void DisplayMessage(object source, MessageArrivedEventArgs e)
        {
            WriteLine($"Message arrived from: {(source as Connection)?.Name}");
            WriteLine($"Message arrived: {e.Message}");
        }
    }
}
