using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Greet
    {
        public void Hello(string name = "World")
        {
            Console.WriteLine("Hello {0}!",name);
        }
    }
}
