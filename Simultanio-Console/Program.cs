using System;

namespace SimultanioConsole
{
    class MainClass
    {
        public static void Main (string[] args)
        {
            Console.WriteLine (Simultanio.MyClass.Hello);
            var res = Simultanio.MyClass.Adder(10, 10);
            Console.Out.WriteLine("The result is {0}",res);
        }
    }
}