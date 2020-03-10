using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintResults(0, 0);
            PrintResults(15, 0);
            PrintResults(5, Double.MaxValue);
            PrintResults(10, Double.MaxValue);
            PrintResults(10, Double.NaN);
        }
        public static double CalcSum(double k, double z)
        {
            int i = 1;
            if (k < 1 || k > 14)
            {
                throw new ArgumentOutOfRangeException(nameof(k), k, "Invalid value");
            }

            return 1 / Math.Sqrt(z * i) + Math.Tan(k / i);
        }
        static void PrintResults(double k, double z)
        { 
            Console.Write($"k:{k} z:{z} result:"); 
            try 
            { 
                Console.WriteLine(CalcSum(k, z)); 
            }
            catch (ArgumentOutOfRangeException e) 
            { 
                Console.WriteLine("EXCEPTION! {0}", e.Message); 
            } 
        }
    }
}

//(1/√z⋅i+tg(k/i)
//k<15