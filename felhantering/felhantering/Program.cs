using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Felhantering_Uppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            bool klar = false;

            while (!klar)
            {
                try
                {
                    Console.Clear();

                    Console.Write("Mata in start ");
                    int start = int.Parse(Console.ReadLine());

                    Console.Write("Mata in stop ");
                    int stop = int.Parse(Console.ReadLine());

                    Console.Write("Mata in steg ");
                    int steg = int.Parse(Console.ReadLine());

                    if (steg > 0)
                    {
                        for (int i = start; i <= stop; i += steg)
                        {
                            klar = true;
                            Console.Write(i + " ");
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.ReadKey();
                }
            }
            Console.ReadLine();
        }
    }
}
