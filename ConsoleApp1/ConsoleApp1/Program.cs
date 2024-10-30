using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearch<int>.For(new int[] {1,2,4},0);
        }
    }
    class BinarySearch<DataType>
    {
        public static void For(int[] Domain, int Value, int From, int To)
        {
            int Mideum = (From + To) / 2;
            if (Domain[Mideum] == Value) Console.WriteLine(Mideum);
            else if (Mideum == Domain.Length - 1|| Mideum ==0) Console.WriteLine(-1);
            else if (Domain[Mideum] < Value) For(Domain, Value, Mideum + 1, To);
            else For(Domain, Value, From, Mideum - 1);
        }
        public static void For(int[] Domain, int Value)
        {
            int From = 0, To = Domain.Length - 1;
            for (int Mideum = (Domain.Length - 1) / 2; (Mideum != Domain.Length - 1 && Mideum != 0)|| Domain[Mideum] == Value; Mideum = (From + To)/2)
            {
                if (Domain[Mideum] == Value)
                {
                    Console.WriteLine(Mideum);
                    return;
                }
                else if (Domain[Mideum] < Value) From = Mideum + 1;
                else To = Mideum - 1;
            }
            Console.WriteLine(-1);
        }
    }
}
