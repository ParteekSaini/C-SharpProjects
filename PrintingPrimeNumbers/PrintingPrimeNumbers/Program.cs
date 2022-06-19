using System;
using static System.Console;

namespace PrintingPrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            String number;
            int number1,count;
            WriteLine("Enter the number upto which you want to print Prime numbers");
            number = ReadLine();
            number1 = int.Parse(number);
            for (int i = 2; i <= number1; i++)
            {
                count = 0;
                for(int k=2;k<i;k++)
                {
                    int remainder = i % k;
                    if(remainder==0)
                    {
                        break;
                    }
                    else
                    {
                        count = count + 1;
                    }
                }
                if (count == i - 2)
                    Write("{0}  ",i);
            }
            ReadKey();

        }
    }
}
