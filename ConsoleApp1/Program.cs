using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Greet greet = new Greet();

            Console.WriteLine(DateTime.Now.AddHours(-1));

            greet.Hello();

            greet.Hello(args[0].ToString());

        }
    }
}
