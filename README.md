# IEnumerable
<h3>In mathematics, the <a href=https://en.wikipedia.org/wiki/Fibonacci_number><b><i>Fibonacci numbers</i></b></a> are the numbers in the following integer sequence, called the Fibonacci sequence, and characterized by the fact that every number after the first two is the sum of the two preceding ones:</h3>

![fib1](https://cloud.githubusercontent.com/assets/20840005/22788983/10d6ed76-eefb-11e6-8bcb-440dd4c08dd0.jpg)


```C#
using System;
using System.Collections.Generic;
using System.Linq;


namespace IEnumerable_interf
{
    
    class Program
    {
          static void Main(string[] args)
        {
            foreach (var item in Fib().Skip(0).Take(20))
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
```
<h3> Also we can skip some elements.</h3>

![fib](https://cloud.githubusercontent.com/assets/20840005/22788812/785034cc-eefa-11e6-8eae-bce54738c4ec.gif)


#### We can't use<a href=https://msdn.microsoft.com/en-us/library/14akc2c7.aspx> the ref and out</a> keywords for the <b>Iterator methods, which include a yield return or yield break</b> statement.

