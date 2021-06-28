using System;
using System.Collections.Generic;
namespace chapter2._2_11
{
    class Program
    {
        static void Main(string[] args)
        {
            static IEnumerable<int> CreateSimpleIterator()
            {
                yield return 10;
                for (int i = 0; i < 3; i++)
                {
                    yield return i;
                }
                yield return 20;
            }
            foreach (int value in CreateSimpleIterator())
            {
                Console.WriteLine(value);
            }
            Console.ReadKey();
        }
    }
}
