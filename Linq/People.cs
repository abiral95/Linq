using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Linq
{
    class People
    {

        static void Main() { 

        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 ,9, 10};

        IEnumerable<int> result = numbers.Where(x => x % 2 == 0 );

            foreach (int no in result)
            {
                Console.WriteLine(no);

            }


        }
    }
}