using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetMax(10, 14)); 
            Console.ReadLine();

        }
        static int GetMax(int num1, int num2)
        {
            int result;

            if (num1 > num2)
            {
                result = num1;


            }
            else
                result = num2;
            return result;
        }

           

        
    }  
}
