using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject99
{
    class ClassMock
    {
        static void Main(string[] args)
        {
            int n1= int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int temp = n1;
            int mul = 1;

            for (int i=1;i<n2;i++)
            {
                mul = n1 + temp ;
                n1 = mul;
            }
            Console.WriteLine(mul);


        }
    }
}
