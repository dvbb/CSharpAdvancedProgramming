using System;

namespace MyException
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            try
            {
                throw new ValidationExcepion("now i try to throw a validation exception");
                //throw new Exception("a Exception");
            }
            catch (ValidationExcepion ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey(); 
        }
    }


    public class ValidationExcepion : Exception
    {
        public ValidationExcepion() : base("a new ValidationExcepion") { }
        public ValidationExcepion(string message):base(message)
        {
            
        }


    }

}
