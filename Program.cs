using System;

namespace TDD
{
    class InchCoverter
    {
        public static double Convert (int inches)
        {
            double cm = inches * 2.54;
            return cm;
        }

        static void Main(string[] args)
        {
            int inches = 1;
            double cm = Convert(inches);
        }
    }
}
   