using System;

namespace MyTest
{

    public class CSCalculator
    {
        public static double calcAdd(double a, double b)
        {
            double result = 0;
            result = a + b;
            return result;
        }

        static void Main(String[] args)
        {
            StudentProvider provider = new StudentProvider(null);
            var result = provider.GetStudentsTop20(new GetStudentRequest { });
        }


    }
}
