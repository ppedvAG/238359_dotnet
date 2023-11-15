using System;

namespace HalloStandardLib
{
    public class Calc
    {
        public int Sum(int a, int b)
        {
            return checked(a + b);
        }
    }
}
