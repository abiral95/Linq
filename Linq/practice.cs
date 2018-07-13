using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Linq
{
    public class practice
    {
      
        //      static AreaDel delarea = Area;

        static void Main(string[] Args)

        {

            //    double circleArea = delarea.Invoke(20);

            Func<int, double> area = delegate (int r)
            {
                return 3.14 * r * r;
            };


            double a = area(20);

            Action<int> circumference = delegate (int r)
            {

                Console.Write(2 * 3.14 * r);

            };

            Func<int, double> length = s => s + 3;

            double ab = length(3);


          

        }

   //     static double Area(int r) {

    //       return (2*3.14*r);

   //     }
    }
}