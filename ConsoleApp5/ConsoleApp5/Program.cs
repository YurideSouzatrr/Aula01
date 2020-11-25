using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int? n = null;
            long? p = null;
            ushort? l = null;
            double? k = null;
            double? i = null;
            double? y = 34;
            double? b = null;
          double? a = 65000000; 
            ushort? t = 500;
            double r = 7.50;
            Console.WriteLine(i.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());
            if (b.HasValue)
                Console.WriteLine(b.Value);
            else
                Console.WriteLine("");
            if (a.HasValue)
                Console.WriteLine(a.Value);
            else
                Console.WriteLine("");
        }
    }
}
