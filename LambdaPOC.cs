using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressionPOC
{
    class LambdaPOC
    {
        static void Main(String[] args)
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 8, 9, 10 };
            Console.Write("The list is : " + numbers);
            foreach(var value in numbers)
            {
                Console.Write("{0} ",value);
            }
            
            Console.WriteLine();
            List<int> divisibleBy3 = numbers.FindAll(x => (x % 7 == 0));

            Console.Write("The list is divisal by 3: " + divisibleBy3);
            Console.Write("Numbers divisible by 3 are :");
            foreach(var value in divisibleBy3)
            {
                Console.Write(" {0} ", value);
            }
            Console.WriteLine();
        }
        
    }
}
