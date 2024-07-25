using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Greet greet = new Greet();                
            
            greet.Hello();

            greet.Hello(args[0].ToString());

        }
    }
}
