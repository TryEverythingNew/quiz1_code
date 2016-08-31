using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz1
{
    class Program
    {
        static void Main(string[] args)
        {
            string A = "Hello World!";
            string B = "Hello";
            B += " World!";
            string C = "Hello World!";

            Console.WriteLine(Object.ReferenceEquals(A, B));
            Console.WriteLine(Object.ReferenceEquals(A, C));
            Console.WriteLine(Object.ReferenceEquals(B, C));

            Console.WriteLine(A == B);
            Console.WriteLine(A == C);
            Console.WriteLine(B == C);

            object oA = A; // Line 12
            object oB = B; // Line 13
            object oC = C; // Line 14

            Console.WriteLine(oA == oB);
            Console.WriteLine(oA == oC);
            Console.WriteLine(oB == oC);

            Console.WriteLine(Object.ReferenceEquals(oA, A));
            Console.WriteLine(Object.ReferenceEquals(oA, oC));
            Console.WriteLine(Object.ReferenceEquals(oB, oC));
        }
    }
}
