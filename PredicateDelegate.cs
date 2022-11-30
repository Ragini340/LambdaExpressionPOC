using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressionPOC
{
    class PredicateDelegate
    {
        public static bool IsEven(int num)
        {
            return num % 2 == 0;
        }
        static void Main(String[] args)
        {
            Predicate<int> isEvenNumber = (num) => { return num % 2 == 0; };


            SampleMethod(isEvenNumber);
            Predicate<String> stringPredicate = (val) => { return false; };
            Func<int, bool> isEvenFun = (num) => IsEven(num);
            Console.Read();
        }
        public static void SampleMethod(Predicate<int> predicate)
        {
            Console.WriteLine(predicate(5));
        }
    }
}
