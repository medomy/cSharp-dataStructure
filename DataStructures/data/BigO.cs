using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.data
{
    // explaination of O notation
    internal class BigO
    {
        // contant O(1) for sum calculations
        static public int ConstantBigONotationSum(int n)
        {
            return n * (n + 1) / 2;
        }

        // every loop is O(n) when the step accumulates
        // when the step is multipliction or division it's O(Logn)

        // recursive is exponontial O(2^n);
        static public int Fib(int n)
        {
            if (n < 2) return n;
            return Fib(n - 1) + Fib(n - 2);
        }
    }
}
