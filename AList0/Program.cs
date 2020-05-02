using System;

namespace AList0
{
    class Program
    {
        static void Main(string[] args)
        {
            AL0 arrayTest = new AL0(new int []{ 10, -2, 3, 0});
            arrayTest.AddElement(6);
            arrayTest.PrintMyArray();
            arrayTest.Sort_Insert();
            arrayTest.PrintMyArray();
            arrayTest.MixArray();
            arrayTest.PrintMyArray();

        }
    }
}
