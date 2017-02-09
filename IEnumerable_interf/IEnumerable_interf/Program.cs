using System;
using System.Collections.Generic;
using System.Linq;


namespace IEnumerable_interf
{
    
    class Program
    {
          static void Main(string[] args)
        {
            foreach (var item in Fib().Skip(10).Take(30))
            {
                Console.WriteLine(item);
            }
            Console.Read();
        }
        static  IEnumerable<int> Fib()
        {
            int current = 0;
            int next = 1;
            while (true)
            {
                yield return current;
                int temp = current;
                current = next;
                next = temp + current;
            }
        }
    }
}
